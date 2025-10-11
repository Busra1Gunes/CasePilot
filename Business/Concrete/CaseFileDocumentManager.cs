using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Business.Settings;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.CaseFileDto;
using Entities.Dto.DocumentDto;
using Entities.Dto.DosyaDto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Linq;

public class CaseFileDocumentManager : ICaseFileDocumentService
{
    readonly ICaseFileDocumentDal _caseFileDocumentDal;
    readonly IDocumentTypeDal _documentTypeDal;
    readonly IMapper _mapper;
    readonly IUnitOfWork _unitOfWork;
    readonly IFileService _fileService;
    readonly FileStorageSettings _fileSettings;

    public CaseFileDocumentManager(
        ICaseFileDocumentDal caseFileDocumentDal,
        IMapper mapper,
        IDocumentTypeDal documentTypeDal,
        IUnitOfWork unitOfWork,
        IFileService fileService,
        IOptions<FileStorageSettings> fileSettings)
    {
        _caseFileDocumentDal = caseFileDocumentDal;
        _mapper = mapper;
        _documentTypeDal = documentTypeDal;
        _unitOfWork = unitOfWork;
        _fileService = fileService;
        _fileSettings = fileSettings.Value;
    }

    /// <summary>
    /// Dosya yükler ve kaydeder
    /// </summary>
    public async Task<IResult> AddAsync(CaseFileDocumentAddDto documentDto)
    {
        try
        {
            // DocumentUrl alanını kontrol et (IFormFile)
            if (documentDto.DocumentUrl == null || documentDto.DocumentUrl.Length == 0)
            {
                return new ErrorResult("Dosya seçilmedi veya dosya boş.");
            }

            // Uzantı kontrolü
            var fileExtension = Path.GetExtension(documentDto.DocumentUrl.FileName).ToLower();
            if (!_fileSettings.AllowedExtensions.Contains(fileExtension))
            {
                return new ErrorResult($"Geçersiz dosya formatı. İzin verilen: {string.Join(", ", _fileSettings.AllowedExtensions)}");
            }

            // Boyut kontrolü
            long maxSizeBytes = _fileSettings.MaxFileSizeMB * 1024 * 1024;
            if (documentDto.DocumentUrl.Length > maxSizeBytes)
            {
                return new ErrorResult($"Dosya boyutu çok büyük. Maksimum {_fileSettings.MaxFileSizeMB} MB.");
            }

            // Alt klasör (CaseFileID bazlı)
            string subFolder = $"casefile_{documentDto.CaseFileID}";

            // Dosyayı kaydet
            string filePath = await _fileService.SaveFileAsync(documentDto.DocumentUrl, subFolder);

            // Database kaydı
            var document = new CaseFileDocument
            {
                CaseFileID = documentDto.CaseFileID,
                DocumentTypeID = documentDto.DocumentTypeID,
                FileName = Path.GetFileNameWithoutExtension(documentDto.DocumentUrl.FileName),
                FileExtension = fileExtension,
                FilePath = filePath,
                FileSize = documentDto.DocumentUrl.Length,
                ContentType = documentDto.DocumentUrl.ContentType,
                CreatedDate = DateTime.Now,
                Status = true
            };

            await _caseFileDocumentDal.AddAsync(document);
            await _unitOfWork.SaveChangesAsync();

            return new SuccessDataResult<int>(document.ID, "Dosya başarıyla yüklendi.");
        }
        catch (Exception ex)
        {
            return new ErrorResult($"Dosya yüklenirken hata: {ex.Message}");
        }
    }

    /// <summary>
    /// Evrak günceller
    /// </summary>
    public async Task<IResult> Update(CaseFileDocumentUpdateDto documentDto)
    {
        try
        {
            var existingDocument = await _caseFileDocumentDal
                .Where(x => x.ID == documentDto.ID && x.Status == true)
                .FirstOrDefaultAsync();

            if (existingDocument == null)
            {
                return new ErrorResult("Evrak bulunamadı.");
            }

            existingDocument.CaseFileID = documentDto.CaseFileID;
            existingDocument.DocumentTypeID = documentDto.DocumentTypeID;
            existingDocument.UpdatedDate = DateTime.Now;

            // Eğer yeni dosya yüklendiyse
            if (documentDto.DocumentUrl != null && documentDto.DocumentUrl.Length > 0)
            {
                // Eski dosyayı sil
                await _fileService.DeleteFileAsync(existingDocument.FilePath);

                // Yeni dosyayı kaydet
                string subFolder = $"casefile_{documentDto.CaseFileID}";
                string newFilePath = await _fileService.SaveFileAsync(documentDto.DocumentUrl, subFolder);

                existingDocument.FileName = Path.GetFileNameWithoutExtension(documentDto.DocumentUrl.FileName);
                existingDocument.FileExtension = Path.GetExtension(documentDto.DocumentUrl.FileName).ToLower();
                existingDocument.FilePath = newFilePath;
                existingDocument.FileSize = documentDto.DocumentUrl.Length;
                existingDocument.ContentType = documentDto.DocumentUrl.ContentType;
            }

            _caseFileDocumentDal.Update(existingDocument);
            await _unitOfWork.SaveChangesAsync();

            return new SuccessResult(CommonMessages.EntityUpdated);
        }
        catch (Exception ex)
        {
            return new ErrorResult($"Evrak güncellenirken hata: {ex.Message}");
        }
    }

    /// <summary>
    /// Evrak siler
    /// </summary>
    public async Task<IResult> DeleteCaseFileDocumentAsync(int id)
    {
        try
        {
            var document = await _caseFileDocumentDal
                .Where(d => d.ID == id && d.Status == true)
                .FirstOrDefaultAsync();

            if (document == null)
            {
                return new ErrorResult("Evrak bulunamadı.");
            }

            // Fiziksel dosyayı sil
            await _fileService.DeleteFileAsync(document.FilePath);

            // Soft delete
            document.DeletedDate = DateTime.Now;
            document.Status = false;
            _caseFileDocumentDal.Update(document);

            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityDeleted);
        }
        catch (Exception ex)
        {
            return new ErrorResult($"Evrak silinirken hata: {ex.Message}");
        }
    }

    /// <summary>
    /// Tüm evrakları getirir
    /// </summary>
    public async Task<IDataResult<List<CaseFileDocument>>> GetAll()
    {
        try
        {
            var documents = await _caseFileDocumentDal
                .GetAllQueryable()
                .Where(x => x.Status == true)
                .Include(d => d.DocumentType)
                .Include(d => d.CaseFile)
                .OrderByDescending(x => x.CreatedDate)
                .ToListAsync();

            return new SuccessDataResult<List<CaseFileDocument>>(documents);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<List<CaseFileDocument>>($"Hata: {ex.Message}");
        }
    }

    /// <summary>
    /// Dosyaya göre evrakları getirir
    /// </summary>
    public async Task<IDataResult<List<CaseFileDocumentListDto>>> GetAllByCaseFileID(int caseFileID)
    {
        try
        {
            var documents = await _caseFileDocumentDal
                .GetAllQueryable()
                .Include(d => d.DocumentType)
                .Include(d => d.CaseFile)
                .Where(e => e.CaseFileID == caseFileID && e.Status == true)
                .OrderByDescending(x => x.CreatedDate)
                .ToListAsync();

            var list = _mapper.Map<List<CaseFileDocumentListDto>>(documents);

            foreach (var item in list)
            {
                item.FileSizeFormatted = FormatFileSize(item.FileSize);
                // Dosya path'ini düzelt (Windows \ yerine / kullan)
                var doc = documents.First(d => d.ID == item.ID);
                item.FileUrl = $"/{doc.FilePath.Replace("\\", "/")}";
            }

            return new SuccessDataResult<List<CaseFileDocumentListDto>>(list);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<List<CaseFileDocumentListDto>>($"Hata: {ex.Message}");
        }
    }

    /// <summary>
    /// ID'ye göre evrak getirir
    /// </summary>
    public async Task<IDataResult<CaseFileDocumentDetailDto>> GetById(int documentID)
    {
        try
        {
            var document = await _caseFileDocumentDal
                .GetAllQueryable()
                .Include(d => d.DocumentType)
                .Include(d => d.CaseFile)
                .FirstOrDefaultAsync(d => d.ID == documentID && d.Status == true);

            if (document == null)
            {
                return new ErrorDataResult<CaseFileDocumentDetailDto>("Evrak bulunamadı.");
            }

            var dto = _mapper.Map<CaseFileDocumentDetailDto>(document);
            dto.FileSizeFormatted = FormatFileSize(document.FileSize);
            dto.FileUrl = $"/{document.FilePath.Replace("\\", "/")}";

            return new SuccessDataResult<CaseFileDocumentDetailDto>(dto);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<CaseFileDocumentDetailDto>($"Hata: {ex.Message}");
        }
    }

    /// <summary>
    /// Dosyayı indirir
    /// </summary>
    public async Task<IDataResult<FileDownloadDto>> DownloadFile(int documentID)
    {
        try
        {
            var document = await _caseFileDocumentDal
                .Where(x => x.ID == documentID && x.Status == true)
                .FirstOrDefaultAsync();

            if (document == null)
            {
                return new ErrorDataResult<FileDownloadDto>("Dosya bulunamadı.");
            }

            byte[] fileData = await _fileService.ReadFileAsync(document.FilePath);

            var fileDownload = new FileDownloadDto
            {
                FileData = fileData,
                FileName = $"{document.FileName}{document.FileExtension}",
                ContentType = document.ContentType
            };

            return new SuccessDataResult<FileDownloadDto>(fileDownload);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<FileDownloadDto>($"Hata: {ex.Message}");
        }
    }

    /// <summary>
    /// Tüm evrak türlerini getirir
    /// </summary>
    public async Task<IDataResult<List<DocumentTypeListDto>>> GetAllDocumentType()
    {
        try
        {
            var documents = await _documentTypeDal
                .GetAllQueryable()
                .Where(x => x.Status == true)
                .ToListAsync();

            return new SuccessDataResult<List<DocumentTypeListDto>>(
                _mapper.Map<List<DocumentTypeListDto>>(documents));
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<List<DocumentTypeListDto>>($"Hata: {ex.Message}");
        }
    }

    /// <summary>
    /// Yeni evrak türü ekler
    /// </summary>
    public async Task<IResult> AddDocumentType(DocumentTypeAddDto documentTypeAddDto)
    {
        try
        {
            await _documentTypeDal.AddAsync(_mapper.Map<DocumentType>(documentTypeAddDto));
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityAdded);
        }
        catch (Exception ex)
        {
            return new ErrorResult($"Hata: {ex.Message}");
        }
    }

    /// <summary>
    /// Dosya boyutunu formatlar
    /// </summary>
    private string FormatFileSize(long bytes)
    {
        string[] sizes = { "B", "KB", "MB", "GB" };
        double len = bytes;
        int order = 0;

        while (len >= 1024 && order < sizes.Length - 1)
        {
            order++;
            len = len / 1024;
        }

        return $"{len:0.##} {sizes[order]}";
    }
}

