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

namespace Business.Concrete
{
	public class CaseFileManager : Manager<CaseFile>, ICaseFileService
    {
        private ICaseFileDal _caseFileDal;
        private IMapper _mapper;
		private IUnitOfWork _unitOfWork;

		public CaseFileManager(ICaseFileDal caseFileDal, IMapper mapper, IUnitOfWork unitOfWork) : base(caseFileDal)
        {
			_caseFileDal = caseFileDal;
			_mapper = mapper;
			_unitOfWork = unitOfWork;
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
			return new SuccessResult(CommonMessages.EntityAdded);
		}

        public async Task<IResult> Delete(int caseFileID)
        {
           CaseFile? caseFiles = _caseFileDal.Where(d => d.ID == caseFileID && d.Status.Equals(true)).SingleOrDefault();

			if (caseFiles == null)
				throw new InvalidCaseFileException();

		
			caseFiles.DeletedDate = DateTime.Now;
			caseFiles.Status=false;
			 _caseFileDal.Update(caseFiles);

			await _unitOfWork.SaveChangesAsync();

			return new SuccessResult(CommonMessages.EntityDeleted);
        }

        public async Task<object> GetAll()
		{
			List<CaseFile> list = _caseFileDal.GetAllQueryable()
					.Include(d => d.CaseType)
					.Include(b => b.ApplicationType)
					.Include(i => i.City)
					.Include(c => c.District).Where(c=>c.Status.Equals(true)).ToList();
      
            return new SuccessDataResult<List<CaseFileListDto>>(_mapper.Map<List<CaseFileListDto>>(list));
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

			if (_caseFileDal.Where(k => k.IdentityNumber == caseFileUpdate.IdentityNumber).Any())
                throw new IdentyNumberAlreadyExistsException();


            _mapper.Map(caseFileUpdate, caseFiles);
			caseFiles.UpdatedDate = DateTime.Now;
			 _caseFileDal.Update(caseFiles);

			await _unitOfWork.SaveChangesAsync();

			return new SuccessResult(CommonMessages.EntityUpdated);
		}

	}
}
