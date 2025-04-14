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

namespace Business.Concrete
{
	public class CaseFileManager : ICaseFileService
	{

		readonly ICaseFileDal _caseFileDal;
		readonly IMapper _mapper;
        public CaseFileManager(Lazy<ICaseFileDal> caseFileDal ,IMapper mapper)
        {
            _caseFileDal = caseFileDal.Value;
			_mapper=mapper;
        }
        public IResult Add(CaseFileAddDto caseFile)
		{

			var caseFileAdd=_mapper.Map<CaseFileAddDto, CaseFile>(caseFile); 

			if (_caseFileDal.Where(k => k.IdentityNumber == caseFile.IdentityNumber).Any())
                return new ErrorResult("IdentityNumber!");
            caseFileAdd.OpeningDate=DateTime.Now;
            caseFileAdd.CaseStatus = 0;

			var sonuc= _caseFileDal.AddAsync(caseFileAdd);
			return new SuccessResult("");
		}

		public IDataResult<List<CaseFileDetailDto>> GetAll()
        {           
            var liste = _caseFileDal.GetAll()
					.Include(d => d.CaseType)
					.Include(b => b.ApplicationType)
					.Include(i => i.City)
					.Include(c => c.District).ToList();
           var list= _mapper.Map<List< CaseFileDetailDto>>(liste);
            return new SuccessDataResult<List<CaseFileDetailDto>>(list);
		}

		public IDataResult<List<CaseFileDetailDto>> GetAllByCaseTypeId(int id)
		{
			var liste = _caseFileDal.GetAll()
				.Include(d => d.CaseType)
				.Include(b => b.ApplicationType)
				.Include(i => i.City)
				.Include(c => c.District).Where(s=>s.CaseTypeID.Equals(id)).ToList();
			
			return new SuccessDataResult<List<CaseFileDetailDto>>(_mapper.Map<List<CaseFileDetailDto>>(liste));
		}

		public IDataResult<CaseFileDetailDto> GetById(int caseFileID)
		{

			var dosya = _caseFileDal.Where(k => k.ID == caseFileID)
				.Include(d => d.CaseType)
				.Include(b => b.ApplicationType)
				.Include(i => i.City)
				.Include(i=>i.CaseFileShares).ThenInclude(z=>z.User)
				.Include(i=>i.CaseFileDefendant).ThenInclude(d=>d.Defendant)
				.Include(c => c.District).SingleOrDefault();

			if (dosya == null)
			{
				return new ErrorDataResult<CaseFileDetailDto>("");
			}

			var liste = _mapper.Map<CaseFileDetailDto>(dosya);
			return new SuccessDataResult<CaseFileDetailDto>(liste, "");
		}

		public IResult Update(CaseFileUpdateDto caseFileUpdate)
        {
            CaseFile? caseFiles = _caseFileDal.Where(d => d.ID == caseFileUpdate.ID).SingleOrDefault();

            if (caseFiles == null)
                return new ErrorResult("Case File is empty");

            if (_caseFileDal.Where(k => k.IdentityNumber == caseFileUpdate.IdentityNumber).Any())
                return new ErrorResult("");
            _mapper.Map(caseFileUpdate, caseFiles);
            caseFiles.UpdatedDate = DateTime.Now;
            _caseFileDal.Update(caseFiles);

			return new SuccessResult("Update");	
		}
	}
}
