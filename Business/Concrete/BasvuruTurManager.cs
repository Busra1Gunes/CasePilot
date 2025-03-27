using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BasvuruTurManager : IBasvuruTurService
    {
        IBasvuruTurDal _basvuruTurDal;
        readonly IMapper _mapper;
        public BasvuruTurManager(IBasvuruTurDal basvuruTurDal, IMapper mapper)
        {
            _basvuruTurDal = basvuruTurDal;
            _mapper = mapper;
        }
        public IResult Add(BasvuruTur basvuruTur)
        {
            _basvuruTurDal.AddAsync(basvuruTur);
            return new SuccessResult();
        }

        public IDataResult<List<BasvuruTur>> GetAll()
        {
            List<BasvuruTur> basvuruTurleri = _basvuruTurDal.GetAll().ToList();
            return new SuccessDataResult<List<BasvuruTur>>(basvuruTurleri);
        }

        public IDataResult<BasvuruTur> GetById(int basvuruTurId)
        {
            BasvuruTur basvuruTur = _basvuruTurDal.GetByIdAsync(basvuruTurId).Result;
            return new SuccessDataResult<BasvuruTur>(basvuruTur);
        }

        public IResult Update(BasvuruTur basvuruTur)
        {
            throw new NotImplementedException();
        }
    }
}
