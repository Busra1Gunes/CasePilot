﻿using Core.Utilities.Results;
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
        Task<IDataResult<List<CaseFileDocument>>> GetAll();
		Task<IDataResult<CaseFileDocumentListDto>> GetAllByCaseFileID(int caseFileID);
		Task<IDataResult<CaseFileDocumentListDto>> GetById(int evrakId);
		Task<IResult> AddAsync(CaseFileDocumentAddDto dosya, string url);
		Task<IResult> Update(CaseFileDocument evrak);
        Task<IDataResult<List<DocumentTypeListDto>>> GetAllDocumentType();
        Task<IResult> AddDocumentType(DocumentTypeAddDto documentTypeAddDto);

    }
}
