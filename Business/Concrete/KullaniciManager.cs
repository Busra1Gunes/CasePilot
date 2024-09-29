using AutoMapper;
using Business.Abstract;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.KullaniciDto;
using Entities.Dto.KullaniciDto.KullaniciDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business.Concrete
{
	public class KullaniciManager : IKullaniciService
	{
		IKullaniciDal _kullaniciDal;
		readonly IMapper _mapper;
		public KullaniciManager(IKullaniciDal kullaniciDal, IMapper mapper)
		{
			_kullaniciDal = kullaniciDal;
			_mapper = mapper;
		}
		// [LogAspect] --> AOP, Autofac ,AOP imkanı sunar
		[ValidationAspect(typeof(KullaniciValidator))]
		public IResult Add(KullaniciKayitDto kullanici)
		{
			Kullanici liste = _mapper.Map<KullaniciKayitDto, Kullanici>(kullanici);
			_kullaniciDal.Add(liste);
			return new SuccessResult("Kullanıcı eklendi");
		}
		public IDataResult<KullaniciListeDto> GetById(int id)
		{
			var kullanici = _kullaniciDal.Get(k => k.Id.Equals(id));
			var liste = _mapper.Map<KullaniciListeDto>(kullanici);
			return new SuccessDataResult<KullaniciListeDto>(liste);
		}
		public async Task<object> GetAll()
		{
			var list = _kullaniciDal.GetAll();
			return _mapper.Map<List<KullaniciListeDto>>(list);
		}


		public IResult DeleteById(int id)
		{
			var kullanici = _kullaniciDal.Get(k => k.Id.Equals(id)).FirstOrDefault(); ;
			_kullaniciDal.Delete(kullanici);
			return new SuccessResult("Kullanıcı Silindi");
		}
	}
}
