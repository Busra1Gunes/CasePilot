using Core.Utilities.Results;
using Entities.Dto.CaseFileDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICaseFileNoteService
    {
        Task<IDataResult<List<CaseFileNoteListDto>>> GetByCaseFileId(int caseFileID);
        Task<IDataResult<List<CaseFileNoteListDto>>> GetByUserId(int userID);
        Task<IResult> Add(CaseFileNoteAddDto noteDto);
        Task<IResult> Delete(int noteID);
    }
}
