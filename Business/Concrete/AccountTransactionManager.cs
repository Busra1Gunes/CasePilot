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

	public class AccountTransactionManager :Manager<AccountTransaction>, IAccountTransactionService
	{
		private IMapper _mapper;
		private IAccountTransactionDal _hesapHareketDal;
		private IUnitOfWork _unitOfWork;
		public AccountTransactionManager(IAccountTransactionDal hesapHareketDal, IMapper mapper, IUnitOfWork unitOfWork):base(hesapHareketDal)
		{
			_hesapHareketDal = hesapHareketDal;
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}
		//[ValidationAspect(typeof(AccountTransactionAddDtoValidator))]
		public async Task<IResult> Add(AccountTransactionAddDto hareket)
		{
			var hesapHareket = _mapper.Map<AccountTransactionAddDto, AccountTransaction>(hareket);

			await _hesapHareketDal.AddAsync(hesapHareket);
			_unitOfWork.SaveChangesAsync();
			return new SuccessResult("Hareket Kaydedildi");
		}

		public Task<IDataResult<List<AccountTransaction>>> GetAll()
		{
			throw new NotImplementedException();
		}

		public async Task<IDataResult<AccountTransactionListDto>> GetAllByUserID(int userID)
		{

			var hareketler = _hesapHareketDal
				.Where(x => x.DebtorID == userID || x.CreditID == userID)
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
			bakiyeDto.NetBalance = (bakiyeDto.TotalCredit -
								  bakiyeDto.TotalDebt);
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
		.Where(x => x.CaseFileID == caseFileID && x.Type == TransactionType.DosyaMasrafi)
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
		public Task<IDataResult<AccountTransaction>> GetById(int hareketId)
		{
			throw new NotImplementedException();
		}

		public Task<IResult> Update(AccountTransaction hareket)
		{
			throw new NotImplementedException();
		}
	}
}
