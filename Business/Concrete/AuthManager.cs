using AutoMapper;
using Business.Abstract;
using Business.Utilities.Security;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.KullaniciDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IKullaniciService _kullanicService;
        readonly IMapper _mapper;
        public AuthManager(IKullaniciService kullaniciService, IMapper mapper)
        {
            _kullanicService = kullaniciService;
            _mapper = mapper;
        }
        public IDataResult<AccessToken> Login(KullaniciLoginDto kullaniciLogin)
        {
            Kullanici? kullanici = _kullanicService
                .Where(k => k.KullaniciAdi.Equals(kullaniciLogin.KullaniciAdi) && k.Sifre.Equals(kullaniciLogin.Sifre)).FirstOrDefault();
            
            if (kullanici!=null)
            {
              AccessToken token=  _kullanicService.CreateAccessToken(kullanici).Data;
                return new SuccessDataResult<AccessToken>(token);
            }
           return new ErrorDataResult<AccessToken>();

          
        }

        public IDataResult<Kullanici> Register(KullaniciKayitDto kullaniciKayitDto)
        {
            var kullanici = _kullanicService.Where(k => k.KullaniciAdi.Equals(kullaniciKayitDto.KullaniciAdi)).Any();
            if (kullanici)
            {
                return new ErrorDataResult<Kullanici>("");
            }
            Kullanici kullanici1 = _mapper.Map<Kullanici>(kullaniciKayitDto);
            _kullanicService.AddAsync(kullanici1);
            return new SuccessDataResult<Kullanici>(kullanici1);

        }
    }
}
