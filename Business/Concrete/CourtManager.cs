using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.CourtDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourtManager : Manager<Court>, ICourtService
    {
        private readonly ICourtDal _courtDal;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHearingDal _hearingDal;
        private readonly ICaseFileDal _caseFileDal;

        public CourtManager(ICourtDal courtDal, IMapper mapper, IUnitOfWork unitOfWork, IHearingDal hearingDal, ICaseFileDal caseFileDal) : base(courtDal)
        {
            _courtDal = courtDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _hearingDal = hearingDal;
            _caseFileDal = caseFileDal;
        }

        public async Task<IResult> Add(CourtAddDto court)
        {
            Court courtAdd = _mapper.Map<CourtAddDto, Court>(court);

            // Aynı isimde mahkeme var mı kontrol et
            if (_courtDal.Where(c => c.Name == court.Name && c.CityID == court.CityID).Any())
                throw new Exception("Bu şehirde aynı isimde mahkeme zaten var!");

            courtAdd.Status = true;
            await _courtDal.AddAsync(courtAdd);
            await _unitOfWork.SaveChangesAsync();

            return new SuccessDataResult<int>(courtAdd.ID, CommonMessages.EntityAdded);
        }

        public async Task<IResult> Delete(int courtID)
        {
            Court? court = _courtDal.Where(c => c.ID == courtID && c.Status.Equals(true)).SingleOrDefault();

            if (court == null)
                throw new Exception("Mahkeme bulunamadı!");

            // 1. Aktif duruşmaları kontrol et ve sil/güncelle
            var activeHearings = _hearingDal.Where(h => h.CourtID == courtID && h.Status == true).ToList();

            if (activeHearings.Any(h => h.HearingStatus == 1 && h.HearingDate > DateTime.Now))
                throw new Exception("Bu mahkemeye ait aktif duruşmalar var! Önce onları tamamlayın veya iptal edin.");

            // Tüm duruşmaları soft delete yap
            foreach (var hearing in activeHearings)
            {
                hearing.Status = false;
                hearing.DeletedDate = DateTime.Now;
                _hearingDal.Update(hearing);
            }

            // 2. Bu mahkemeye bağlı dosyaların CourtID'sini null yap
            var caseFiles = _caseFileDal.Where(cf => cf.CourtID == courtID && cf.Status == true).ToList();
            foreach (var caseFile in caseFiles)
            {
                caseFile.CourtID = null;
                caseFile.UpdatedDate = DateTime.Now;
                _caseFileDal.Update(caseFile);
            }

            // 3. Mahkemeyi soft delete yap
            court.DeletedDate = DateTime.Now;
            court.Status = false;
            _courtDal.Update(court);

            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityDeleted);
        }

        public async Task<IDataResult<List<CourtListDto>>> GetAllAsync()
        {
            var list = _courtDal.GetAllQueryable()
                .Include(c => c.City)
                .Include(c => c.District)
                .Where(c => c.Status == true)
                .OrderBy(c => c.Name)
                .ToList();

            return new SuccessDataResult<List<CourtListDto>>(_mapper.Map<List<CourtListDto>>(list));
        }

        public async Task<IDataResult<List<CourtListDto>>> GetFilteredAsync(CourtFilterDto filter)
        {
            var query = _courtDal.GetAllQueryable()
                .Include(c => c.City)
                .Include(c => c.District)
                .Where(c => c.Status == true)
                .AsQueryable();

            // Dinamik filtreler
            if (!string.IsNullOrEmpty(filter.Name))
                query = query.Where(c => c.Name.Contains(filter.Name));

            if (filter.CityID.HasValue)
                query = query.Where(c => c.CityID == filter.CityID.Value);

            if (filter.DistrictID.HasValue)
                query = query.Where(c => c.DistrictID == filter.DistrictID.Value);

            if (!string.IsNullOrEmpty(filter.CourtType))
                query = query.Where(c => c.CourtType.Contains(filter.CourtType));

            var list = await query.OrderBy(c => c.Name).ToListAsync();
            return new SuccessDataResult<List<CourtListDto>>(_mapper.Map<List<CourtListDto>>(list));
        }

        public async Task<IDataResult<CourtDetailDto>> GetById(int courtID)
        {
            Court? court = _courtDal.Where(c => c.ID == courtID && c.Status.Equals(true))
                .Include(c => c.City)
                .Include(c => c.District)
                .Include(c => c.Hearings.Where(h => h.Status == true))
                .ThenInclude(h => h.CaseFile)
                .SingleOrDefault();

            if (court == null)
                throw new Exception($"ID: {courtID} olan mahkeme bulunamadı!");

            return new SuccessDataResult<CourtDetailDto>(_mapper.Map<CourtDetailDto>(court), CommonMessages.EntityListed);
        }

        public async Task<IDataResult<List<CourtListDto>>> GetByCityId(int cityID)
        {
            var list = _courtDal.GetAllQueryable()
                .Include(c => c.City)
                .Include(c => c.District)
                .Where(c => c.CityID == cityID && c.Status == true)
                .OrderBy(c => c.Name)
                .ToList();

            return new SuccessDataResult<List<CourtListDto>>(_mapper.Map<List<CourtListDto>>(list));
        }

        public async Task<IResult> Update(int courtID, CourtUpdateDto courtUpdate)
        {
            Court? court = _courtDal.Where(c => c.ID == courtID && c.Status.Equals(true)).SingleOrDefault();

            if (court == null)
                throw new Exception("Mahkeme bulunamadı!");

            // Aynı isimde başka mahkeme var mı kontrol et
            if (_courtDal.Where(c => c.Name == courtUpdate.Name && c.CityID == courtUpdate.CityID && c.ID != courtID).Any())
                throw new Exception("Bu şehirde aynı isimde mahkeme zaten var!");

            _mapper.Map(courtUpdate, court);
            court.UpdatedDate = DateTime.Now;
            _courtDal.Update(court);

            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityUpdated);
        }
    }
}
