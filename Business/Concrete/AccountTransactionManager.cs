// ============================================
// 1. ACCOUNTTRANSACTIONMANAGER - EKSİK METODLAR
// ============================================

using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Business.Exceptions.CaseFile;
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
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountTransactionManager : Manager<AccountTransaction>, IAccountTransactionService
    {
        private IMapper _mapper;
        private IAccountTransactionDal _hesapHareketDal;
        private IUnitOfWork _unitOfWork;

        public AccountTransactionManager(IAccountTransactionDal hesapHareketDal, IMapper mapper, IUnitOfWork unitOfWork) : base(hesapHareketDal)
        {
            _hesapHareketDal = hesapHareketDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        // MEVCUT METODLAR (Değiştirilmedi)
        //[ValidationAspect(typeof(AccountTransactionAddDtoValidator))]
        public async Task<IResult> Add(AccountTransactionAddDto hareket)
        {
            var accountTransaction = _mapper.Map<AccountTransactionAddDto, AccountTransaction>(hareket);

            await _hesapHareketDal.AddAsync(accountTransaction);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessDataResult<int>(accountTransaction.ID, CommonMessages.EntityAdded);
        }

        public async Task<IDataResult<AccountTransactionListDto>> GetAllByUserID(int userID)
        {
            var hareketler = _hesapHareketDal
                .Where(x => (x.DebtorID == userID || x.CreditID == userID) && x.Status == true)
                .Include(a => a.User1)
                .Include(a => a.User2)
                .Include(a => a.CaseFile);

            var hareketDtos = _mapper.Map<List<AccountTransactionDto>>(hareketler);

            var bakiyeDto = new AccountBalanceDto();

            foreach (var h in hareketler)
            {
                // Ödeme yapılmış mı kontrolü
                bool odendi = h.PaymentStatus == 1;

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
            bakiyeDto.NetBalance = (bakiyeDto.TotalCredit - bakiyeDto.TotalDebt);

            AccountTransactionListDto hesapHareketListDto = new AccountTransactionListDto
            {
                Bakiye = bakiyeDto,
                Transaction = hareketDtos
            };

            return new SuccessDataResult<AccountTransactionListDto>(hesapHareketListDto);
        }

        public async Task<IDataResult<AccountTransactionListDto>> GetAllByCaseFileID(int caseFileID)
        {
            var hareketler = _hesapHareketDal
                .Where(x => x.CaseFileID == caseFileID && x.Type == TransactionType.DosyaMasrafi && x.Status == true)
                .Include(x => x.User1)
                .Include(x => x.User2)
                .Include(x => x.CaseFile);

            var hareketDtos = _mapper.Map<List<AccountTransactionDto>>(hareketler);

            var bakiyeDto = new AccountBalanceDto();

            foreach (var h in hareketler)
            {
                bool odendi = h.PaymentStatus == 1;

                bakiyeDto.TotalDebt += h.Amount; // tüm masraf

                if (odendi)
                    bakiyeDto.TotalCredit += h.Amount; // ödenmiş masraf
                else
                    bakiyeDto.PendingDebt += h.Amount; // bekleyen masraf
            }

            // İsteğe bağlı: net bakiyeyi de gösterebiliriz
            bakiyeDto.NetBalance = bakiyeDto.TotalCredit - bakiyeDto.PendingDebt;

            var result = new AccountTransactionListDto
            {
                Bakiye = bakiyeDto,
                Transaction = hareketDtos
            };

            return new SuccessDataResult<AccountTransactionListDto>(result);
        }

        public async Task<IResult> Delete(int accountTransactionID)
        {
            AccountTransaction? accountTransaction = _hesapHareketDal
                .Where(d => d.ID == accountTransactionID && d.Status.Equals(true))
                .SingleOrDefault();

            if (accountTransaction == null)
                throw new InvalidCaseFileException();

            // Sonra dosyayı sil
            accountTransaction.DeletedDate = DateTime.Now;
            accountTransaction.Status = false;
            _hesapHareketDal.Update(accountTransaction);

            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityDeleted);
        }

        public async Task<IDataResult<List<AccountTransaction>>> GetAll()
        {
            try
            {
                // Tüm aktif hesap hareketlerini getir
                var transactions = await _hesapHareketDal
                    .Where(x => x.Status == true)
                    .Include(x => x.User1)
                    .Include(x => x.User2)
                    .Include(x => x.CaseFile)
                    .OrderByDescending(x => x.CreatedDate)
                    .ToListAsync();

                return new SuccessDataResult<List<AccountTransaction>>(transactions);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<AccountTransaction>>($"Hesap hareketleri alınırken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IDataResult<AccountTransaction>> GetById(int transactionID)
        {
            try
            {
                var transaction = await _hesapHareketDal
                    .Where(x => x.ID == transactionID && x.Status == true)
                    .Include(x => x.User1)
                    .Include(x => x.User2)
                    .Include(x => x.CaseFile)
                    .FirstOrDefaultAsync();

                if (transaction == null)
                {
                    return new ErrorDataResult<AccountTransaction>("Hesap hareketi bulunamadı.");
                }

                return new SuccessDataResult<AccountTransaction>(transaction);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<AccountTransaction>($"Hesap hareketi alınırken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> Update(AccountTransaction transaction)
        {
            try
            {
                var existingTransaction = await _hesapHareketDal
                    .Where(x => x.ID == transaction.ID && x.Status == true)
                    .FirstOrDefaultAsync();

                if (existingTransaction == null)
                {
                    return new ErrorResult("Hesap hareketi bulunamadı.");
                }
                _mapper.Map(transaction, existingTransaction);
                existingTransaction.UpdatedDate = DateTime.Now;
                _hesapHareketDal.Update(existingTransaction);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult(CommonMessages.EntityUpdated);
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Hesap hareketi güncellenirken hata oluştu: {ex.Message}");
            }
        }
    }
}