using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities.Dto.KullaniciDto.KullaniciDto;
using System.Security.Cryptography;
using Entities.Dto;
using Core.Utilities.Interceptors;
using Core.Utilities.Messages;
using Business.Constants.Messages;
using Business.Constants.Messages.Entity;
using Business.Exceptions.CaseFile;
using Entities.Dto.CaseFileDto;
using Entities.Dto.FilterDto;
using DataAccess.Concrete.EntityFramework;
using Entities.Dto.HesapHareketDto;
using Entities.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Concrete
{
	public class CaseFileManager : Manager<CaseFile>, ICaseFileService
    {
        private ICaseFileDal _caseFileDal;
        private ICaseFileShareDal _caseFileShareDal;
        private IMapper _mapper;
		private IUnitOfWork _unitOfWork;
        private IAccountTransactionDal _accountTransactionDal;
        private IHearingDal _hearingDal;
        private IServiceProvider _serviceProvider;


        public CaseFileManager(ICaseFileDal caseFileDal, IMapper mapper, IUnitOfWork unitOfWork, 
            IHearingDal hearingDal,IAccountTransactionDal accountTransactionDal,
            ICaseFileShareDal caseFileShare,IServiceProvider serviceProvider) : base(caseFileDal)
        {
			_caseFileDal = caseFileDal;
			_mapper = mapper;
			_unitOfWork = unitOfWork;
            _hearingDal = hearingDal;
            _accountTransactionDal = accountTransactionDal;
            _caseFileShareDal = caseFileShare;
            _serviceProvider = serviceProvider;

        }
        public async Task<IDataResult<CaseFileCreateResponseDto>> CreateWithDetails(CaseFileCreateDto createDto)
        {
            

            try
            {
                CaseFile caseFileAdd = _mapper.Map<CaseFileAddDto, CaseFile>(createDto.CaseFile);

                if (_caseFileDal.Where(k => k.IdentityNumber == createDto.CaseFile.IdentityNumber).Any())
                    throw new IdentyNumberAlreadyExistsException();

                caseFileAdd.OpeningDate = DateTime.Now;
                caseFileAdd.Status = true;

                await _caseFileDal.AddAsync(caseFileAdd);
                await _unitOfWork.SaveChangesAsync();
                int caseFileID = caseFileAdd.ID;

                int sharesCreated = 0;
                if (createDto.Shares != null && createDto.Shares.Any())
                {
                    foreach (var shareDto in createDto.Shares)
                    {
                        var share = new CaseFileShare
                        {
                            CaseFileID = caseFileID,
                            UserID = (int)shareDto.UserID,
                            ShareRate = shareDto.ShareRate,
                            FilePermission = shareDto.FilePermission,
                            CreatedDate = DateTime.Now,
                            Status = true
                        };

                        await _caseFileShareDal.AddAsync(share);
                        await _unitOfWork.SaveChangesAsync();
                        sharesCreated++;
                    }
                }
                var response = new CaseFileCreateResponseDto
                {
                    CaseFileID = caseFileID,
                    SharesCreated = sharesCreated,
                    TransactionsCreated = 0,
                    Message = ""
                };
               
                return new SuccessDataResult<CaseFileCreateResponseDto>(response);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<CaseFileCreateResponseDto>($"İşlem başarısız: {ex.Message}");
            }
        }

        public async Task<IDataResult<CaseFileDetailWithSummaryDto>> GetByIdWithDetails(int caseFileID)
        {
            var caseFile = await _caseFileDal.GetAllQueryable()
      .Include(cf => cf.CaseType)
      .Include(cf => cf.ApplicationType)
      .Include(cf => cf.City)
      .Include(cf => cf.District)
      .Include(cf => cf.Court)
      .Include(cf => cf.CaseFileShares.Where(cfs => cfs.Status))
          .ThenInclude(cfs => cfs.User)
      .Include(cf => cf.CaseFileDefendant.Where(cfd => cfd.Status))
          .ThenInclude(cfd => cfd.Defendant)
      .SingleOrDefaultAsync(cf => cf.ID == caseFileID && cf.Status);

            if (caseFile == null)
                throw new CaseFileNotFoundException(caseFileID);

            // 2️⃣ Payları maple ve toplam pay oranını hesapla
            var shares = caseFile.CaseFileShares.ToList();
            var totalDto = new CaseFileShareTotalDto
            {
                TotalShareRate = shares.Sum(s => s.ShareRate)
            };
            var shareListDto = new CaseFileShareListDto
            {
                ShareDto = _mapper.Map<List<CaseFileShareDto>>(shares),
                Total = totalDto
            };

            // 3️⃣ Masrafları detaylı çek
            var transactions = await _accountTransactionDal
                .Where(t => t.CaseFileID == caseFileID && t.Type == TransactionType.DosyaMasrafi && t.Status)
                .Include(t => t.User1) // Borçlu
                .Include(t => t.User2) // Alacaklı
                .Include(t => t.CaseFile)
                .ToListAsync();

            var transactionDtos = _mapper.Map<List<AccountTransactionDto>>(transactions);

            // 4️⃣ Bakiye hesapla
            var balance = new AccountBalanceDto();
            foreach (var t in transactions)
            {
                bool odendi = t.PaymentStatus == 1;
                balance.TotalDebt += t.Amount;

                if (odendi)
                    balance.TotalCredit += t.Amount;
                else
                    balance.PendingDebt += t.Amount;
            }
            balance.NetBalance = balance.TotalCredit - balance.PendingDebt;

            var transactionListDto = new AccountTransactionListDto
            {
                Transaction = transactionDtos,
                Bakiye = balance
            };

            // 5️⃣ Ana DTO map
            var dto = _mapper.Map<CaseFileDetailWithSummaryDto>(caseFile);
            dto.CaseFileShares = shareListDto;
            dto.Transactions = transactionListDto;

            // Kullanıcı bazlı özet (isteğe bağlı)
            var expenseSummaryByUser = transactions
                .GroupBy(x => new { x.User1.ID, x.User1.Name, x.User1.Surname })
                .Select(g => new UserExpenseSummaryDto
                {
                    UserFullName = $"{g.Key.Name} {g.Key.Surname}",
                    PaidAmount = g.Where(x => x.PaymentStatus == 1).Sum(x => x.Amount),
                    UnpaidAmount = g.Where(x => x.PaymentStatus == 2).Sum(x => x.Amount)
                }).ToList();

            dto.TotalExpensesByUser = expenseSummaryByUser;
            dto.TotalExpenses = expenseSummaryByUser.Sum(x => x.TotalAmount);

            return new SuccessDataResult<CaseFileDetailWithSummaryDto>(dto, "Detaylı dosya bilgisi, paylar ve masraflar getirildi.");
        }

        public async Task<IResult> Add(CaseFileAddDto caseFile)
		{
			CaseFile caseFileAdd = _mapper.Map<CaseFileAddDto, CaseFile>(caseFile);

			if (_caseFileDal.Where(k => k.IdentityNumber == caseFile.IdentityNumber).Any())
                throw new IdentyNumberAlreadyExistsException();
    
                caseFileAdd.OpeningDate = DateTime.Now;
			caseFileAdd.Status = true;

			await _caseFileDal.AddAsync(caseFileAdd);
			await _unitOfWork.SaveChangesAsync();
			return new SuccessDataResult<int>(caseFileAdd.ID, CommonMessages.EntityAdded);
		}

        public async Task<IResult> Delete(int caseFileID)
        {
            CaseFile? caseFiles = _caseFileDal.Where(d => d.ID == caseFileID && d.Status.Equals(true)).SingleOrDefault();

            if (caseFiles == null)
                throw new InvalidCaseFileException();

            // Önce bu dosyaya ait duruşmaları sil
            var hearings = _hearingDal.Where(h => h.CaseFileID == caseFileID && h.Status == true).ToList();
            foreach (var hearing in hearings)
            {
                hearing.Status = false;
                hearing.DeletedDate = DateTime.Now;
                _hearingDal.Update(hearing);
            }

            // Sonra dosyayı sil
            caseFiles.DeletedDate = DateTime.Now;
            caseFiles.Status = false;
            _caseFileDal.Update(caseFiles);

            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityDeleted);
        }

        public async Task<IDataResult<List<CaseFileListDto>>> GetAllAsync()
        {
            var list = _caseFileDal.GetAllQueryable()
                .Include(d => d.CaseType)
                .Include(b => b.ApplicationType)
                .Include(b => b.Court)
                .Include(i => i.City)
                .Include(c => c.District)
                .Where(c => c.Status == true)
                .ToList();

            return new SuccessDataResult<List<CaseFileListDto>>(_mapper.Map<List<CaseFileListDto>>(list));
        }

        public async Task<IDataResult<CaseFileListWithSummaryDto>> GetFilteredAsync(CaseFileFilterDto filter)
        {
            var query = _caseFileDal.GetAllQueryable()
                .Include(d => d.CaseType)
                .Include(b => b.ApplicationType)
                .Include(i => i.City)
                .Include(c => c.District).Include(b => b.Court)
				.Include(cf => cf.CaseFileDefendant.Where(cfd => cfd.Status == true))
                    .ThenInclude(cfd => cfd.Defendant)
                .Include(cf => cf.CaseFileShares.Where(cfs => cfs.Status == true))
                    .ThenInclude(cfs => cfs.User)
                .Where(c => c.Status == true)
                .AsQueryable();

            // 🔎 Filtreler
            if (filter.CaseTypeID.HasValue)
                query = query.Where(c => c.CaseTypeID == filter.CaseTypeID.Value);

            if (filter.ApplicationTypeID.HasValue)
                query = query.Where(c => c.ApplicationTypeID == filter.ApplicationTypeID.Value);

            if (!string.IsNullOrEmpty(filter.Name))
                query = query.Where(c => c.Name.Contains(filter.Name));

            if (!string.IsNullOrEmpty(filter.Surname))
                query = query.Where(c => c.Surname.Contains(filter.Surname));

            if (!string.IsNullOrEmpty(filter.IdentityNumber))
                query = query.Where(c => c.IdentityNumber == filter.IdentityNumber);

            if (!string.IsNullOrEmpty(filter.FileNumber))
                query = query.Where(c => c.ID.ToString() == filter.FileNumber);

            if (!string.IsNullOrEmpty(filter.ShareUserName))
                query = query.Where(c => c.CaseFileShares
                    .Any(s => s.User.Name.Contains(filter.ShareUserName) ||
                              s.User.Surname.Contains(filter.ShareUserName)));

            if (!string.IsNullOrEmpty(filter.DefendantName))
                query = query.Where(c => c.CaseFileDefendant
                    .Any(d => d.Defendant.Name.Contains(filter.DefendantName)));

            // 📁 Dosyaları çek
            var caseFiles = await query.ToListAsync();

            // 📋 DTO'ya map et
            var resultList = _mapper.Map<List<CaseFileListDto>>(caseFiles);

            // 💰 Tüm masrafları toplayacağız
            List<AccountTransaction> allExpenses = new List<AccountTransaction>();

            foreach (var dto in resultList)
            {
                var expenses = await _accountTransactionDal
                    .Where(x => x.CaseFileID == dto.ID &&
                                x.Type == Entities.Enums.TransactionType.DosyaMasrafi &&
                                x.Status == true)
                    .Include(x => x.User1)
                    .ToListAsync();

                allExpenses.AddRange(expenses);

                if (expenses.Any())
                {
                    var grouped = expenses
                        .GroupBy(x => new { x.User1.ID, x.User1.Name, x.User1.Surname })
                        .Select(g => new
                        {
                            UserFullName = g.Key.Name + " " + g.Key.Surname,
                            PaidAmount = g.Where(x => x.PaymentStatus == 1).Sum(x => x.Amount),
                            UnpaidAmount = g.Where(x => x.PaymentStatus == 2).Sum(x => x.Amount)
                        });

                    // 👇 Kullanıcı bazlı masraf detaylarını string olarak yaz
                    dto.ExpenseSummary = string.Join(" | ", grouped.Select(g =>
                        $"{g.UserFullName} → Ödenen: {g.PaidAmount}₺, Bekleyen: {g.UnpaidAmount}₺"));
                }
                else
                {
                    dto.ExpenseSummary = "Masraf yok";
                }
            }

            // 📊 Genel özet bilgileri hesapla
            var totalCaseFiles = resultList.Count;

            var expenseSummaryByUser = allExpenses
                .GroupBy(x => new { x.User1.ID, x.User1.Name, x.User1.Surname })
                .Select(g => new UserExpenseSummaryDto
                {
                    UserFullName = g.Key.Name + " " + g.Key.Surname,
                    PaidAmount = g.Where(x => x.PaymentStatus == 1).Sum(x => x.Amount),
                    UnpaidAmount = g.Where(x => x.PaymentStatus == 2).Sum(x => x.Amount)
                })
                .OrderByDescending(x => x.TotalAmount)
                .ToList();

            var totalExpenses = expenseSummaryByUser.Sum(x => x.TotalAmount);

            // 🧾 Ana DTO'ya doldur
            var summaryDto = new CaseFileListWithSummaryDto
            {
                CaseFiles = resultList,
                TotalCaseFiles = totalCaseFiles,
                TotalExpensesByUser = expenseSummaryByUser,
                TotalExpenses = totalExpenses
            };

            return new SuccessDataResult<CaseFileListWithSummaryDto>(
                summaryDto,
                "Filtreli dosya listesi ve özet bilgileri getirildi."
            );
        }
        public  async Task<object> GetAllByCaseTypeId(int id)
		{
			List<CaseFile> list = _caseFileDal.GetAllQueryable()
				.Include(d => d.CaseType)
				.Include(b => b.ApplicationType)
				.Include(i => i.City)
				.Include(c => c.District).Where(s => s.CaseTypeID.Equals(id) && s.Status.Equals(true)).ToList();

            return _mapper.Map<List<CaseFileDetailDto>>(list);
        }

		public async Task<IDataResult<CaseFileDetailDto>> GetById(int caseFileID)
		{

			CaseFile? caseFile = _caseFileDal.Where(k => k.ID == caseFileID && k.Status.Equals(true))
				.Include(d => d.CaseType)
				.Include(b => b.ApplicationType)
				.Include(i => i.City)
				.Include(i => i.CaseFileShares).ThenInclude(z => z.User)
				.Include(i => i.CaseFileDefendant).ThenInclude(d => d.Defendant)
				.Include(c => c.District).SingleOrDefault();

			if (caseFile == null)
			{
				throw new CaseFileNotFoundException(caseFileID);
			}

			return new SuccessDataResult<CaseFileDetailDto>(_mapper.Map<CaseFileDetailDto>(caseFile), CommonMessages.EntityListed);
		}

		public async Task<IResult> Update(int caseFileID, CaseFileUpdateDto caseFileUpdate)
		{
			CaseFile? caseFiles = _caseFileDal.Where(d => d.ID == caseFileID && d.Status.Equals(true)).SingleOrDefault();

			if (caseFiles == null)
				throw new InvalidCaseFileException();

			if (_caseFileDal.Where(k => k.IdentityNumber == caseFileUpdate.IdentityNumber && k.ID!= caseFileID).Any())
                throw new IdentyNumberAlreadyExistsException();


            _mapper.Map(caseFileUpdate, caseFiles);
			caseFiles.UpdatedDate = DateTime.Now;
			 _caseFileDal.Update(caseFiles);

			await _unitOfWork.SaveChangesAsync();

			return new SuccessResult(CommonMessages.EntityUpdated);
		}

	}
}
