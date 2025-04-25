using AutoMapper;
using Business.Abstract;
using Business.ValidationRules;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class AccountTransactionManager : IAccountTransactionService
    {
        readonly IMapper _mapper;
        readonly IAccountTransactionDal _hesapHareketDal;
        public AccountTransactionManager(IAccountTransactionDal hesapHareketDal, IMapper mapper)
        {
            _hesapHareketDal = hesapHareketDal;
            _mapper = mapper;
        }
        [ValidationAspect(typeof(AccountTransactionAddDtoValidator))]
        public IResult Add(AccountTransactionAddDto hareket)
        {
            var hesapHareket = _mapper.Map<AccountTransactionAddDto, AccountTransaction>(hareket);
            //if (hesapHareket.Type == TransactionType.DosyaMasrafi)
            //{

            //    hesapHareket.TransactionStatus = TransactionStatus.Alacak;
            //}
            var sonuc = _hesapHareketDal.AddAsync(hesapHareket);
            return new SuccessResult("Hareket Kaydedildi");
        }

        public IDataResult<List<AccountTransaction>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccountTransactionListDto> GetAllByUserID(int userID)
        {
            
                var hareketler = _hesapHareketDal
                    .Where(x => x.DebtorID == userID || x.CreditID == userID)
                    .Include(a=>a.User1)
                    .Include(a=>a.User2)
                    .Include(a=>a.CaseFile);
                var hareketDtos = _mapper.Map<List<AccountTransactionDto>>(hareketler);

                var bakiyeDto = new AccountBalanceDto();

                foreach (var h in hareketler)
                {
                    // Ödeme yapılmış mı kontrolü
                    bool odendi = h.PaymentStatus == true;

                    // Kullanıcı borçlu taraf mı?
                    if (h.DebtorID == userID)
                    {
                        if (odendi)
                            bakiyeDto.TotalDebt += h.Amount;
                        else
                            bakiyeDto.PendingDebt += h.Amount;
                    }

                    // Kullanıcı alacaklı taraf mı?
                    if (h.CreditID == userID)
                    {
                        if (odendi)
                            bakiyeDto.TotalCredit += h.Amount;
                        else
                            bakiyeDto.PendingCredit += h.Amount;
                    }
                }

                // Net bakiye: alınan - gönderilen
                bakiyeDto.NetBalance = (bakiyeDto.TotalCredit  -
                                      bakiyeDto.TotalDebt );
                AccountTransactionListDto hesapHareketListDto = new AccountTransactionListDto
                {
                    Bakiye = bakiyeDto,
                    Transaction = hareketDtos
                };


                return new SuccessDataResult<AccountTransactionListDto>(hesapHareketListDto);


            
            //var harekets = _hesapHareketDal.Where()
            //.Include(d => d.Kullanici1)
            //.Include(b => b.Kullanici2)
            //.Include(i => i.Dosya)
            //.Include(i => i.Dosya).ToList();


            //if (harekets == null)
            //{
            //    return new ErrorDataResult<HesapHareketListDto>("Hareket bulunamadı");
            //}

            //var liste = _mapper.Map<HesapHareketListDto>(harekets);
            //return new SuccessDataResult<HesapHareketListDto>(liste, "Hareket Listelendi");
        }

        public IDataResult<AccountTransaction> GetById(int hareketId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(AccountTransaction hareket)
        {
            throw new NotImplementedException();
        }
    }
}
