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
    public class DosyaDavaliManager : IDosyaDavaliService
    {
        IDosyaDavaliDal _dosyaDavaliDal;
        IMapper _mapper;

        public DosyaDavaliManager(IDosyaDavaliDal dosyaDavaliDal, IMapper mapper)
        {
            _dosyaDavaliDal = dosyaDavaliDal;
            _mapper = mapper;
        }        
        public IResult Add(DosyaDavali davali)
        {
           _dosyaDavaliDal.AddAsync(davali);
            return new SuccessResult();
        }

        public IDataResult<List<DosyaDavali>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<DosyaDavali>> GetAllByDosyaId(int dosyaID)
        {
            List<DosyaDavali> dosyaDavalis=_dosyaDavaliDal.GetAll().Where(d=>d.DosyaId.Equals(dosyaID)).ToList();
            return new SuccessDataResult<List<DosyaDavali>>(dosyaDavalis);
        }

        public IDataResult<DosyaDavali> GetById(int davaliId)
        {
            DosyaDavali? dosyaDavali = _dosyaDavaliDal.GetByIdAsync(davaliId).Result;
            return new SuccessDataResult<DosyaDavali>(dosyaDavali);
        }

        public IResult Update(DosyaDavali davali)
        {
            DosyaDavali dosyaDavali = _dosyaDavaliDal.GetByIdAsync(davali.Id).Result;
            _dosyaDavaliDal.Update(dosyaDavali);
            return new SuccessResult();
        }
    }
}
