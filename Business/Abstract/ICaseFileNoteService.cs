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
        Task<IDataResult<List<CaseFileNoteDto>>> GetByCaseFileId(int caseFileID);
        Task<IResult> Add(CaseFileNoteAddDto noteDto);
        Task<IResult> Delete(int noteID);
    }
}
