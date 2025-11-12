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
        private ICaseFileShareDal _caseFileShareDal;
        private IUnitOfWork _unitOfWork;

        public AccountTransactionManager(IAccountTransactionDal hesapHareketDal, IMapper mapper, IUnitOfWork unitOfWork, ICaseFileShareDal caseFileShareDal) : base(hesapHareketDal)
        {
            _hesapHareketDal = hesapHareketDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _caseFileShareDal = caseFileShareDal;
        }


        public async Task<IResult> Add(AccountTransactionAddDto hareket)
        {
            var accountTransaction = _mapper.Map<AccountTransactionAddDto, AccountTransaction>(hareket);

            await _hesapHareketDal.AddAsync(accountTransaction);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessDataResult<int>(accountTransaction.ID, CommonMessages.EntityAdded);
        }

        public async Task<IResult> AddWithCaseFileSharesAsync(AccountTransactionAddDto accountTransaction)
        {
            // 1️⃣ Ön kontrol: CaseFileID var mı ve hareket türü DosyaMasrafı mı?
            if (accountTransaction.caseFileID == null || accountTransaction.Type != TransactionType.DosyaMasrafi)
                return new ErrorResult("Bu işlem sadece Dosya Masrafı türü için geçerlidir.");

            int caseFileID = accountTransaction.caseFileID.Value;

            // 2️⃣ CaseFileShare tablosundan aktif paydaşları al
            var aktifPaylar = await _caseFileShareDal
                .Where(x => x.Status == true && x.CaseFileID == caseFileID)
                .ToListAsync();

            if (aktifPaylar == null || !aktifPaylar.Any())
                return new ErrorResult("Bu dosya için aktif pay bulunamadı.");

            // 3️⃣ Toplam tutarı pay sayısına böl
            decimal kisiBasiTutar =Convert.ToDecimal(accountTransaction.Amount / aktifPaylar.Count);

            // 4️⃣ Her bir pay için ayrı hareket oluştur
            foreach (var pay in aktifPaylar)
            {
                var yeniHareket = new AccountTransaction
                {
                    CaseFileID = caseFileID,
                    DebtorID = pay.UserID,          // Her pay sahibi borçlu olacak
                    CreditID = (int)accountTransaction.CreditID,    // Genellikle sistem veya dosya sahibi
                    Amount = kisiBasiTutar,
                    Type = accountTransaction.Type,
                    Description = $"Dosya masrafı payı - {kisiBasiTutar}₺ ({pay.User?.Name+" "+pay.User?.Surname})",
                    PaymentReceivedDate = accountTransaction.PaymentReceivedDate,
                    FinalPaymentDate = accountTransaction.FinalPaymentDate,
                    PaymentStatus = accountTransaction.PaymentStatus,
                    CreatedDate = DateTime.Now,
                    Status = true
                };

                await _hesapHareketDal.AddAsync(yeniHareket);
            }

            // 5️⃣ Tümünü tek seferde kaydet
            await _unitOfWork.SaveChangesAsync();

            return new SuccessResult($"{aktifPaylar.Count} pay sahibine toplam {accountTransaction.Amount}₺ masraf paylaştırıldı.");
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

        public async Task<IDataResult<List<AccountTransactionDto>>> GetAll()
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
                var hareketDtos = _mapper.Map<List<AccountTransactionDto>>(transactions);
                return new SuccessDataResult<List<AccountTransactionDto>>(hareketDtos);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<AccountTransactionDto>>($"Hesap hareketleri alınırken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IDataResult<AccountTransactionUpdateDto>> GetById(int transactionID)
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
                    return new ErrorDataResult<AccountTransactionUpdateDto>("Hesap hareketi bulunamadı.");
                }
                var dto = _mapper.Map<AccountTransactionUpdateDto>(transaction);
                return new SuccessDataResult<AccountTransactionUpdateDto>(dto);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<AccountTransactionUpdateDto>($"Hesap hareketi alınırken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> Update(int ID,AccountTransactionUpdateDto transaction)
        {
            try
            {
                var existingTransaction = await _hesapHareketDal
                    .Where(x => x.ID == ID && x.Status == true)
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
        public async Task<IResult> TogglePaymentStatusAsync(int accountTransactionID)
        {
            try
            {
                var transaction = await _hesapHareketDal
                    .Where(x => x.ID == accountTransactionID && x.Status == true)
                    .FirstOrDefaultAsync();

                if (transaction == null)
                    return new ErrorResult("Hesap hareketi bulunamadı.");

                // Current status mapping:
                // 1 -> Ödendi
                // 2 -> Ödenmedi
                // 3 -> Mahsuplasma (treat as other)

                if (transaction.PaymentStatus == 1)
                {
                    transaction.PaymentStatus = 2; // Ödendi -> Ödenmedi
                }
                else if (transaction.PaymentStatus == 2)
                {
                    transaction.PaymentStatus = 1; // Ödenmedi -> Ödendi
                }
                else
                {
                    // If it's a different status (e.g. mahsuplaşma), toggle to Ödendi
                    transaction.PaymentStatus = 1;
                }

                transaction.UpdatedDate = DateTime.Now;
                _hesapHareketDal.Update(transaction);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult("Ödeme durumu başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Ödeme durumu güncellenirken hata oluştu: {ex.Message}");
            }
        }
    }
}