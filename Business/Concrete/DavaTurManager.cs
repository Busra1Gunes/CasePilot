using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class DavaTurManager : IDavaTurService
	{
		IDavaTurDal _davaturDal;
		readonly IMapper _mapper;
        public DavaTurManager(IDavaTurDal davaTurDal ,IMapper mapper)
        {
            _davaturDal = davaTurDal;
			_mapper = mapper;	
        }
        public IResult Add(DavaTur davaTur)
		{
			_davaturDal.AddAsync(davaTur);
			return new SuccessResult();
		}

		public IDataResult<List<DavaTur>> GetAll()
		{
		   List<DavaTur> davaTurleri=_davaturDal.GetAll().ToList();
			return new SuccessDataResult<List<DavaTur>>(davaTurleri);
		}

		public IDataResult<DavaTur> GetById(int davaturId)
		{
			DavaTur davaTur=_davaturDal.GetByIdAsync(davaturId).Result;
			return new SuccessDataResult<DavaTur>(davaTur);
		}

		public IResult Update(DavaTur davaTur)
		{
			throw new NotImplementedException();
		}
	}
}
