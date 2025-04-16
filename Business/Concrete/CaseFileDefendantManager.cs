using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.AddDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.ListDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CaseFileDefendantManager : ICaseFileDefendantService
    {
        ICaseFileDefendantDal _caseFileDefendantDal;
        IDefendantDal _defendantDal;
        IMapper _mapper;

        public CaseFileDefendantManager(ICaseFileDefendantDal caseFileDefendantDal, IMapper mapper, IDefendantDal defendantDal)
        {
            _caseFileDefendantDal = caseFileDefendantDal;
            _mapper = mapper;
            _defendantDal = defendantDal;

        }
        public IResult Add(CaseFileDefendantAddDto caseFileDefendant)
        {
            _caseFileDefendantDal.AddAsync(_mapper.Map<CaseFileDefendant>(caseFileDefendant));
            return new SuccessResult();
        }

        public IResult AddDefendat(DefendantAddDto defendantAddDto)
        {
            _defendantDal.AddAsync(_mapper.Map<Defendant>(defendantAddDto));
            return new SuccessResult();
        }

        public IDataResult<List<CaseFileDefendant>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CaseFileDefendant>> GetAllByCaseFileId(int caseFileID)
        {
            List<CaseFileDefendant> caseFileDefendants = _caseFileDefendantDal.GetAll().Where(d => d.caseFileID.Equals(caseFileID)).ToList();
            return new SuccessDataResult<List<CaseFileDefendant>>(caseFileDefendants);
        }

        public IDataResult<List<DefendantListDto>> GetAllDefendant()
        {
            List<Defendant> Defendants = _defendantDal.GetAll().ToList();
            var list = _mapper.Map<List<DefendantListDto>>(Defendants);
            return new SuccessDataResult<List<DefendantListDto>>(list);

        }

        public IDataResult<CaseFileDefendant> GetById(int caseFileDefendantID)
        {
            CaseFileDefendant? caseFileDefendant = _caseFileDefendantDal.GetByIdAsync(caseFileDefendantID).Result;
            return new SuccessDataResult<CaseFileDefendant>(caseFileDefendant);
        }

        public IResult Update(CaseFileDefendant caseFileDefendant)
        {
            CaseFileDefendant caseFileDefendants = _caseFileDefendantDal.GetByIdAsync(caseFileDefendant.ID).Result;
            _caseFileDefendantDal.Update(caseFileDefendants);
            return new SuccessResult();
        }
    }
}
