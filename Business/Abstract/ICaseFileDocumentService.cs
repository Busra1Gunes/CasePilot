using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.AddDto;
using Entities.Dto.CaseFileDto;
using Entities.Dto.DocumentDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.ListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICaseFileDocumentService
    {
        // Ana CRUD metodları
        Task<IResult> AddAsync(CaseFileDocumentAddDto document);
        Task<IResult> Update(CaseFileDocumentUpdateDto document);
        Task<IResult> DeleteCaseFileDocumentAsync(int id);

        // Listeleme metodları
        Task<IDataResult<List<CaseFileDocument>>> GetAll();
        Task<IDataResult<List<CaseFileDocumentListDto>>> GetAllByCaseFileID(int caseFileID);
        Task<IDataResult<CaseFileDocumentDetailDto>> GetById(int documentID);

        // Dosya işlemleri
        Task<IDataResult<FileDownloadDto>> DownloadFile(int documentID);

        // Evrak türü metodları
        Task<IDataResult<List<DocumentTypeListDto>>> GetAllDocumentType();
        Task<IResult> AddDocumentType(DocumentTypeAddDto documentTypeAddDto);
    }
}
