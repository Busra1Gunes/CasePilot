using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Business.Exceptions.CaseFile;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
    public class DefendantManager:IDefendantService
    {      
        IDefendantDal _defendantDal;
        IMapper _mapper;
        IUnitOfWork _unitOfWork;

        public DefendantManager( IMapper mapper, IDefendantDal defendantDal,    IUnitOfWork unitOfWork)
        {          
            _mapper = mapper;
            _defendantDal = defendantDal;
            _unitOfWork = unitOfWork;

        }
        public async Task<IResult> AddDefendat(DefendantAddDto defendantAddDto)
        {
            var defendant = _mapper.Map<Defendant>(defendantAddDto);
            await _defendantDal.AddAsync(defendant);
           await _unitOfWork.SaveChangesAsync();
            return new SuccessDataResult<int>(defendant.ID, CommonMessages.EntityAdded);
        }
        public async  Task<IDataResult<List<DefendantListDto>>> GetAllDefendant()
        {
            List<Defendant> Defendants =await _defendantDal.GetAllQueryable().ToListAsync();
            return new SuccessDataResult<List<DefendantListDto>>(_mapper.Map<List<DefendantListDto>>(Defendants));

        }
        public async Task<IResult> DeleteDefendantAsync(int id)
        {
            Defendant? defendant = _defendantDal.Where(d => d.ID == id && d.Status.Equals(true)).SingleOrDefault();

            if (defendant == null)
                throw new InvalidCaseFileException();

            defendant.DeletedDate = DateTime.Now;
            defendant.Status = false;
            _defendantDal.Update(defendant);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityUpdated);
        }


    }
}
