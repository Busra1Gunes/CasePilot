using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICaseFileDocumentService
    {
        IDataResult<List<CaseFileDocument>> GetAll();
        IDataResult<List<CaseFileDocument>> GetAllBycaseFileID(int caseFileID);

        IDataResult<CaseFileDocument> GetById(int evrakId);
        IResult Add(CaseFileDocumentAddDto dosya, string url);
        IResult Update(CaseFileDocument evrak);
      
    }
}
