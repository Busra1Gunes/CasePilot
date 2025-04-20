using AutoMapper;
using Business.Abstract;
using Core.FTP;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.AddDto;
using Entities.Dto.CaseFileDto;
using Entities.Dto.DocumentDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.ListDto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CaseFileDocumentManager : ICaseFileDocumentService
    {
        ICaseFileDocumentDal _caseFileDocumentDal;
        IDocumentTypeDal _documentTypeDal;
		private readonly FtpSettings _ftpSettings;
		readonly IMapper _mapper;
        public CaseFileDocumentManager(ICaseFileDocumentDal caseFileDocumentDal, IMapper mapper, IDocumentTypeDal documentTypeDal, IOptions<FtpSettings> ftpSettings)
        {
            _caseFileDocumentDal = caseFileDocumentDal;
            _mapper = mapper;
            _documentTypeDal = documentTypeDal;
			_ftpSettings = ftpSettings.Value;
		}
		public async Task<IResult> AddAsync(CaseFileDocumentAddDto resume, string url)
		{
			string? ftpFileUrl = null;

			if (resume.DocumentUrl != null)
			{
				var uzanti = Path.GetExtension(resume.DocumentUrl.FileName).ToLower();
				var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".docx", ".pdf", ".xlsx" };

				if (!allowedExtensions.Contains(uzanti))
					return new ErrorResult("Geçersiz dosya formatı. Sadece JPG, PNG, PDF, DOCX, XLSX kabul edilmektedir.");

				var fileName = $"{DateTime.Now:yyyyMMddHHmmssfff}{uzanti}";
				var ftpUploadPath = $"{_ftpSettings.Host}/wwwroot/CaseFileDocuments/{fileName}";

				try
				{
					using var stream = resume.DocumentUrl.OpenReadStream();
					var uploadResult = await UploadToFtpAsync(ftpUploadPath, stream, _ftpSettings.Username, _ftpSettings.Password);
					if (!uploadResult)
						return new ErrorResult("FTP dosya yükleme başarısız.");

					ftpFileUrl = $"https://www.CasePilot.somee.com/CaseFileDocuments/{fileName}";
				}
				catch (Exception ex)
				{
					return new ErrorResult($"Dosya yüklenirken hata oluştu: {ex.Message}");
				}
			}

			var document = _mapper.Map<CaseFileDocument>(resume);
			document.DocumentUrl = ftpFileUrl;

			await _caseFileDocumentDal.AddAsync(document);
			return new SuccessResult("Veri başarıyla kaydedildi.");
		}


		private async Task<bool> UploadToFtpAsync(string ftpUrl, Stream fileStream, string username, string password)
		{
			try
			{
				var request = (FtpWebRequest)WebRequest.Create(ftpUrl);
				request.Method = WebRequestMethods.Ftp.UploadFile;
				request.Credentials = new NetworkCredential(username, password);
				request.EnableSsl = false;
				request.UseBinary = true;
				request.UsePassive = true;
				request.ContentLength = fileStream.Length;

				using var requestStream = await request.GetRequestStreamAsync();
				await fileStream.CopyToAsync(requestStream);

				using var response = (FtpWebResponse)await request.GetResponseAsync();
				return response.StatusCode != FtpStatusCode.ClosingData;
			}
			catch
			{
				return false;
			}
		}


		public IDataResult<List<CaseFileDocument>> GetAll()
        {
            List<CaseFileDocument> dosyaEvraklar = _caseFileDocumentDal.GetAll().ToList();
            return new SuccessDataResult<List<CaseFileDocument>>(dosyaEvraklar);
        }

        public IDataResult<List<CaseFileDocumentListDto>> GetAllByCaseFileID(int caseFileID)
        {
            List<CaseFileDocument> caseFileDocuments = _caseFileDocumentDal.GetAll()
				.Include(d=>d.DocumentType)
				.Include(d=>d.CaseFile)
				.Where(e=>e.CaseFileID.Equals(caseFileID)).ToList();

			var list = _mapper.Map<List<CaseFileDocumentListDto>>(caseFileDocuments);
			return new SuccessDataResult<List<CaseFileDocumentListDto>>(list);		
        }

        public IDataResult<CaseFileDocumentListDto> GetById(int documentID)
        {
            CaseFileDocument? evrak = _caseFileDocumentDal.GetAll()
				.Include(d => d.DocumentType)
				.Include(d => d.CaseFile).FirstOrDefaultAsync(d=>d.ID.Equals(documentID)).Result;		
			if(evrak == null) return new ErrorDataResult<CaseFileDocumentListDto>("");
			var list = _mapper.Map<CaseFileDocumentListDto>(evrak);
			return new SuccessDataResult<CaseFileDocumentListDto>(list);
        }

        public IResult Update(CaseFileDocument document)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<DocumentTypeListDto>> GetAllDocumentType()
        {
            List<DocumentType> documents = _documentTypeDal.GetAll().ToList();
            var list = _mapper.Map<List<DocumentTypeListDto>>(documents);
            return new SuccessDataResult<List<DocumentTypeListDto>>(list);
        }

        public IResult AddDocumentType(DocumentTypeAddDto documentTypeAddDto)
        {
            _documentTypeDal.AddAsync(_mapper.Map<DocumentType>(documentTypeAddDto));
            return new SuccessResult();
        }
    }
}
