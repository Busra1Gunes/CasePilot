using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.AddDto;
using Entities.Dto.DocumentDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.ListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CaseFileDocumentManager : ICaseFileDocumentService
    {
        ICaseFileDocumentDal _caseFileDocumentDal;
        IDocumentTypeDal _documentTypeDal;
        readonly IMapper _mapper;
        public CaseFileDocumentManager(ICaseFileDocumentDal caseFileDocumentDal, IMapper mapper, IDocumentTypeDal documentTypeDal)
        {
            _caseFileDocumentDal = caseFileDocumentDal;
            _mapper = mapper;
            _documentTypeDal = documentTypeDal;
        }
        public IResult Add(CaseFileDocumentAddDto resume, string url)
        {
            // Fotoğraf yolu kaydetme işlemi
            string? sqlImagePath = null;

            if (resume.DocumentUrl != null)
            {
                // Fotoğraf uzantısını kontrol ediyoruz
                var uzanti = Path.GetExtension(resume.DocumentUrl.FileName).ToLower();
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".docx", ".pdf", ".xlsx" };

                if (!allowedExtensions.Contains(uzanti))
                {
                    return new ErrorResult("Geçersiz dosya formatı. Sadece JPG, PNG,PDF,DOCX,XLSX kabul edilmektedir.");
                }

                // Klasör var mı kontrol ediyoruz, yoksa oluşturuyoruz
                var klasorYolu = "wwwroot/CaseFileDocuments";
                if (!Directory.Exists(klasorYolu))
                {
                    Directory.CreateDirectory(klasorYolu);
                }

                // Benzersiz dosya adı oluşturuluyor
                var tarihSaatDakikaSaniyeSalise = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                var resimYolu = Path.Combine(klasorYolu, $"{tarihSaatDakikaSaniyeSalise}{uzanti}");
                sqlImagePath = $"{url}CaseFileDocuments/{tarihSaatDakikaSaniyeSalise}{uzanti}";

                try
                {
                    using (var stream = new FileStream(resimYolu, FileMode.Create))
                    {
                        resume.DocumentUrl.CopyTo(stream);
                    }
                }
                catch (Exception ex)
                {
                    return new ErrorResult($"Dosya kaydedilirken bir hata oluştu: {ex.Message}");
                }
            }
            CaseFileDocument document = _mapper.Map<CaseFileDocument>(resume);
            document.DocumentUrl = sqlImagePath;


            _caseFileDocumentDal.AddAsync(document);

            return new SuccessResult("");
        }

        public IDataResult<List<CaseFileDocument>> GetAll()
        {
            List<CaseFileDocument> dosyaEvraklar = _caseFileDocumentDal.GetAll().ToList();
            return new SuccessDataResult<List<CaseFileDocument>>(dosyaEvraklar);
        }

        public IDataResult<List<CaseFileDocument>> GetAllBycaseFileID(int caseFileID)
        {
            List<CaseFileDocument> caseFileDocuments = _caseFileDocumentDal.GetAll().Where(e=>e.CaseFileID.Equals(caseFileID)).ToList();
            return new SuccessDataResult<List<CaseFileDocument>>(caseFileDocuments);
        }

        public IDataResult<CaseFileDocument> GetById(int documentID)
        {
            CaseFileDocument evrak = _caseFileDocumentDal.GetByIdAsync(documentID).Result;
            return new SuccessDataResult<CaseFileDocument>(evrak);
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
