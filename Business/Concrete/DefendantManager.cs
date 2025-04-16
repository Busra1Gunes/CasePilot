using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.AddDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.ListDto;
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

        public DefendantManager( IMapper mapper, IDefendantDal defendantDal)
        {          
            _mapper = mapper;
            _defendantDal = defendantDal;

        }
        public IResult AddDefendat(DefendantAddDto defendantAddDto)
        {
            _defendantDal.AddAsync(_mapper.Map<Defendant>(defendantAddDto));
            return new SuccessResult();
        }
        public IDataResult<List<DefendantListDto>> GetAllDefendant()
        {
            List<Defendant> Defendants = _defendantDal.GetAll().ToList();
            var list = _mapper.Map<List<DefendantListDto>>(Defendants);
            return new SuccessDataResult<List<DefendantListDto>>(list);

        }

      
    }
}
