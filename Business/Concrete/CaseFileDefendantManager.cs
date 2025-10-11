using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Business.Exceptions.CaseFile;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.AddDto;
using Entities.Dto.CaseFileDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.ListDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CaseFileDefendantManager : ICaseFileDefendantService
    {
        ICaseFileDefendantDal _caseFileDefendantDal;
        IDefendantDal _defendantDal;
        IMapper _mapper;
        IUnitOfWork _unitOfWork;

        public CaseFileDefendantManager(ICaseFileDefendantDal caseFileDefendantDal, IMapper mapper, IDefendantDal defendantDal, IUnitOfWork unitOfWork)
        {
            _caseFileDefendantDal = caseFileDefendantDal;
            _mapper = mapper;
            _defendantDal = defendantDal;
            _unitOfWork = unitOfWork;
        }

        // MEVCUT METODLAR (Değiştirilmedi)
        public async Task<IResult> Add(CaseFileDefendantAddDto caseFileDefendant)
        {
            var casefileDefendant = _mapper.Map<CaseFileDefendant>(caseFileDefendant);
            await _caseFileDefendantDal.AddAsync(casefileDefendant);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessDataResult<int>(casefileDefendant.ID, CommonMessages.EntityAdded);
        }

        public async Task<IResult> AddDefendat(DefendantAddDto defendantAddDto)
        {
            await _defendantDal.AddAsync(_mapper.Map<Defendant>(defendantAddDto));
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityAdded);
        }

        public async Task<IDataResult<List<CaseFileDefendantListDto>>> GetAllByCaseFileId(int caseFileID)
        {
            List<CaseFileDefendant> caseFileDefendants = _caseFileDefendantDal
                .GetAllQueryable()
                .Where(d => d.CaseFileID.Equals(caseFileID) && d.Status.Equals(true))
                .Include(d => d.Defendant)
                .Include(d => d.CaseFile)
                .ToList();

            return new SuccessDataResult<List<CaseFileDefendantListDto>>(_mapper.Map<List<CaseFileDefendantListDto>>(caseFileDefendants));
        }

        public async Task<IDataResult<List<DefendantListDto>>> GetAllDefendant()
        {
            List<DefendantListDto> list = _mapper.Map<List<DefendantListDto>>(_defendantDal.GetAllQueryable().ToList());
            return new SuccessDataResult<List<DefendantListDto>>(list);
        }

        public async Task<IDataResult<CaseFileDefendant>> GetById(int caseFileDefendantID)
        {
            CaseFileDefendant? caseFileDefendant = await _caseFileDefendantDal.GetByIdAsync(caseFileDefendantID);

            if (caseFileDefendant == null)
            {
                return new ErrorDataResult<CaseFileDefendant>("Dosya davalısı bulunamadı.");
            }

            return new SuccessDataResult<CaseFileDefendant>(caseFileDefendant);
        }

        public async Task<IResult> DeleteCaseFileDefendantAsync(int id)
        {
            CaseFileDefendant? caseFileDefendant = _caseFileDefendantDal
                .Where(d => d.ID == id && d.Status.Equals(true))
                .SingleOrDefault();

            if (caseFileDefendant == null)
                throw new InvalidCaseFileException();

            caseFileDefendant.DeletedDate = DateTime.Now;
            caseFileDefendant.Status = false;
            _caseFileDefendantDal.Update(caseFileDefendant);

            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityDeleted);
        }

        /// <summary>
        /// Tüm dosya davalılarını getirir (aktif olanlar)
        /// </summary>
        public async Task<IDataResult<List<CaseFileDefendant>>> GetAll()
        {
            try
            {
                var caseFileDefendants = await _caseFileDefendantDal
                    .GetAllQueryable()
                    .Where(x => x.Status == true)
                    .Include(x => x.Defendant)
                    .Include(x => x.CaseFile)
                    .OrderByDescending(x => x.CreatedDate)
                    .ToListAsync();

                return new SuccessDataResult<List<CaseFileDefendant>>(caseFileDefendants);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<CaseFileDefendant>>($"Dosya davalıları alınırken hata oluştu: {ex.Message}");
            }
        }

        /// <summary>
        /// Dosya davalısı günceller
        /// </summary>
        public async Task<IResult> Update(CaseFileDefendantUpdateDto caseFileDefendant)
        {
            try
            {
                // Mevcut kaydı kontrol et
                var existingCaseFileDefendant = await _caseFileDefendantDal
                    .Where(x => x.ID == caseFileDefendant.ID && x.Status == true)
                    .FirstOrDefaultAsync();

                if (existingCaseFileDefendant == null)
                {
                    return new ErrorResult("Dosya davalısı bulunamadı.");
                }

                // Güncelleme tarihini ayarla
                existingCaseFileDefendant.UpdatedDate = DateTime.Now;

                // Güncellenecek alanlar
                existingCaseFileDefendant.CaseFileID = caseFileDefendant.CaseFileID;
                existingCaseFileDefendant.DefendantID = caseFileDefendant.DefendantID;

                // Veritabanına kaydet
                _caseFileDefendantDal.Update(existingCaseFileDefendant);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult(CommonMessages.EntityUpdated);
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Dosya davalısı güncellenirken hata oluştu: {ex.Message}");
            }
        }
    }
}

