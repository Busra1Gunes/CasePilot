using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.AddDto;
using Entities.Dto.CaseFileDto;
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
        IUnitOfWork _unitOfWork;

        public CaseFileDefendantManager(ICaseFileDefendantDal caseFileDefendantDal, IMapper mapper, IDefendantDal defendantDal, IUnitOfWork unitOfWork)
        {
            _caseFileDefendantDal = caseFileDefendantDal;
            _mapper = mapper;
            _defendantDal = defendantDal;
            _unitOfWork = unitOfWork;   
        }
        public async Task<IResult> Add(CaseFileDefendantAddDto caseFileDefendant)
        {
            await _caseFileDefendantDal.AddAsync(_mapper.Map<CaseFileDefendant>(caseFileDefendant));
            _unitOfWork.SaveChangesAsync();
            return new SuccessResult();
        }

        public async Task<IResult> AddDefendat(DefendantAddDto defendantAddDto)
        {
           await  _defendantDal.AddAsync(_mapper.Map<Defendant>(defendantAddDto));
            return new SuccessResult();
        }

        public async Task<IDataResult<List<CaseFileDefendant>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<CaseFileDefendantListDto>>> GetAllByCaseFileId(int caseFileID)
        {
			List<CaseFileDefendant> caseFileDefendants =  _caseFileDefendantDal.GetAllQueryable().Where(d => d.caseFileID.Equals(caseFileID)).Include(d=>d.Defendant)
                .Include(d=>d.CaseFile)
                .ToList();
            return new SuccessDataResult<List<CaseFileDefendantListDto>>(_mapper.Map<List<CaseFileDefendantListDto>>(caseFileDefendants));
        }

        public async Task<IDataResult<List<DefendantListDto>>> GetAllDefendant()
        {
			List<DefendantListDto> list = _mapper.Map<List<DefendantListDto>>(_defendantDal.GetAllQueryable().ToList());
            return new SuccessDataResult<List<DefendantListDto>>(list);

        }

        public async Task<IDataResult<CaseFileDefendant>> GetById(int caseFileDefendantID)
        {
            CaseFileDefendant? caseFileDefendant =await _caseFileDefendantDal.GetByIdAsync(caseFileDefendantID);
            return new SuccessDataResult<CaseFileDefendant>(caseFileDefendant);
        }

        public async Task<IResult> Update(CaseFileDefendant caseFileDefendant)
        {
            CaseFileDefendant caseFileDefendants = await _caseFileDefendantDal.GetByIdAsync(caseFileDefendant.ID);
           _caseFileDefendantDal.Update(caseFileDefendants);
            return new SuccessResult();
        }
    }
}
