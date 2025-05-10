using AutoMapper;
using Business.Abstract;
using Business.Exceptions.CaseFile;
using Business.Exceptions.CaseFileDocument;
using Core.FTP;
using Core.Utilities.Results;
using Business.Constants.Paths;
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
        readonly ICaseFileDocumentDal _caseFileDocumentDal;
        readonly IDocumentTypeDal _documentTypeDal;
	    readonly FtpSettings _ftpSettings;
		readonly IMapper _mapper;
		readonly IUnitOfWork _unitOfWork;

        public CaseFileDocumentManager(ICaseFileDocumentDal caseFileDocumentDal, IMapper mapper, IDocumentTypeDal documentTypeDal,
			IOptions<FtpSettings> ftpSettings,IUnitOfWork unitOfWork)
        {
            _caseFileDocumentDal = caseFileDocumentDal;
            _mapper = mapper;
            _documentTypeDal = documentTypeDal;
			_ftpSettings = ftpSettings.Value;
			_unitOfWork = unitOfWork;
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

				string fileName = $"{DateTime.Now:yyyyMMddHHmmssfff}{uzanti}";
                string ftpUploadPath = $"{_ftpSettings.Host}/{ FtpPaths.ftpUploadPath}/{fileName}";

                try
				{
					using var stream = resume.DocumentUrl.OpenReadStream();
					bool uploadResult = await UploadToFtpAsync(ftpUploadPath, stream, _ftpSettings.Username, _ftpSettings.Password);
					if (!uploadResult)
                        throw new FileUploadException();

                    ftpFileUrl = $"{FtpPaths.FtpFileUrl}/{fileName}";
                }
				catch (Exception ex)
				{
					throw new FileUploadException();
				}
			}

			var document = _mapper.Map<CaseFileDocument>(resume);
			document.DocumentUrl = ftpFileUrl;

			await _caseFileDocumentDal.AddAsync(document);
			await _unitOfWork.SaveChangesAsync();
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

				using FtpWebResponse? response = (FtpWebResponse)await request.GetResponseAsync();
				return response.StatusCode != FtpStatusCode.ClosingData;
			}
			catch
			{
                throw new FileUploadException();
            }
		}


		public IDataResult<List<CaseFileDocument>> GetAll()
        {
            List<CaseFileDocument> dosyaEvraklar = _caseFileDocumentDal.GetAllQueryable().ToList();
            return new SuccessDataResult<List<CaseFileDocument>>(dosyaEvraklar);
        }

        public IDataResult<List<CaseFileDocumentListDto>> GetAllByCaseFileID(int caseFileID)
        {
            List<CaseFileDocument> caseFileDocuments = _caseFileDocumentDal.GetAllQueryable()
				.Include(d=>d.DocumentType)
				.Include(d=>d.CaseFile)
				.Where(e=>e.CaseFileID.Equals(caseFileID)).ToList();

			var list = _mapper.Map<List<CaseFileDocumentListDto>>(caseFileDocuments);
			return new SuccessDataResult<List<CaseFileDocumentListDto>>(list);		
        }

        public IDataResult<CaseFileDocumentListDto> GetById(int documentID)
        {
            CaseFileDocument? evrak = _caseFileDocumentDal.GetAllQueryable()
				.Include(d => d.DocumentType)
				.Include(d => d.CaseFile)
				.FirstOrDefaultAsync(d=>d.ID.Equals(documentID)).Result;

			if (evrak == null)
				throw new CaseFileDocumentNotFoundException(documentID);
			return new SuccessDataResult<CaseFileDocumentListDto>(_mapper.Map<CaseFileDocumentListDto>(evrak));
        }

        public IResult Update(CaseFileDocument document)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<DocumentTypeListDto>> GetAllDocumentType()
        {
            List<DocumentType> documents = _documentTypeDal.GetAllQueryable().ToList();
            return new SuccessDataResult<List<DocumentTypeListDto>>(_mapper.Map<List<DocumentTypeListDto>>(documents));
        }

        public async Task<IResult> AddDocumentType(DocumentTypeAddDto documentTypeAddDto)
        {
            _documentTypeDal.AddAsync(_mapper.Map<DocumentType>(documentTypeAddDto));
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult();
        }
    }
}
