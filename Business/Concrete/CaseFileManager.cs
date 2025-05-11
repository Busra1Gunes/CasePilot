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
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Messages;
using Business.Constants.Messages;
using Business.Constants.Messages.Entity;

namespace Business.Concrete
{
	public class CaseFileManager : ICaseFileService
	{
		readonly ICaseFileDal _caseFileDal;
		readonly IMapper _mapper;
		readonly IUnitOfWork _unitOfWork;

		public CaseFileManager(Lazy<ICaseFileDal> caseFileDal, IMapper mapper, IUnitOfWork unitOfWork)
		{
			_caseFileDal = caseFileDal.Value;
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}
		public async Task<IResult> Add(CaseFileAddDto caseFile)
		{
			CaseFile caseFileAdd = _mapper.Map<CaseFileAddDto, CaseFile>(caseFile);

			if (_caseFileDal.Where(k => k.IdentityNumber == caseFile.IdentityNumber).Any())
				return new ErrorResult(CaseFileMessages.IdentityNumberError);
			caseFileAdd.OpeningDate = DateTime.Now;
			caseFileAdd.CaseStatus = 0;

			await _caseFileDal.AddAsync(caseFileAdd);
			await _unitOfWork.SaveChangesAsync();
			return new SuccessResult(CommonMessages.EntityAdded);
		}

		public async Task<IDataResult<CaseFileDetailDto>> GetAll()
		{
			List<CaseFile> list = _caseFileDal.GetAllQueryable()
					.Include(d => d.CaseType)
					.Include(b => b.ApplicationType)
					.Include(i => i.City)
					.Include(c => c.District).ToList();
			return new SuccessDataResult<CaseFileDetailDto>(_mapper.Map<CaseFileDetailDto>(list));
		}
		public  async Task<IDataResult<CaseFileDetailDto>> GetAllByCaseTypeId(int id)
		{
			List<CaseFile> list = _caseFileDal.GetAllQueryable()
				.Include(d => d.CaseType)
				.Include(b => b.ApplicationType)
				.Include(i => i.City)
				.Include(c => c.District).Where(s => s.CaseTypeID.Equals(id)).ToList();

			return new SuccessDataResult<CaseFileDetailDto>(_mapper.Map<CaseFileDetailDto>(list));
		}

		public async Task<IDataResult<CaseFileDetailDto>> GetById(int caseFileID)
		{

			CaseFile? caseFile = _caseFileDal.Where(k => k.ID == caseFileID)
				.Include(d => d.CaseType)
				.Include(b => b.ApplicationType)
				.Include(i => i.City)
				.Include(i => i.CaseFileShares).ThenInclude(z => z.User)
				.Include(i => i.CaseFileDefendant).ThenInclude(d => d.Defendant)
				.Include(c => c.District).SingleOrDefault();

			if (caseFile == null)
			{
				throw new Exception();
			}

			var list = _mapper.Map<CaseFileDetailDto>(caseFile);
			return new SuccessDataResult<CaseFileDetailDto>(list, CommonMessages.EntityListed);
		}

		public async Task<IResult> Update(CaseFileUpdateDto caseFileUpdate)
		{
			CaseFile? caseFiles = _caseFileDal.Where(d => d.ID == caseFileUpdate.ID).SingleOrDefault();

			if (caseFiles == null)
				return new ErrorResult(CaseFileMessages.CaseFileEmptyError);

			if (_caseFileDal.Where(k => k.IdentityNumber == caseFileUpdate.IdentityNumber).Any())
				return new ErrorResult(CaseFileMessages.IdentityNumberError);


			_mapper.Map(caseFileUpdate, caseFiles);
			caseFiles.UpdatedDate = DateTime.Now;

			 _caseFileDal.Update(caseFiles);
			await _unitOfWork.SaveChangesAsync();

			return new SuccessResult(CommonMessages.EntityUpdated);
		}

	}
}
