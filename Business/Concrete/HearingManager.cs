using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.HearingDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HearingManager : Manager<Hearing>, IHearingService
    {
        private readonly IHearingDal _hearingDal;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public HearingManager(IHearingDal hearingDal, IMapper mapper, IUnitOfWork unitOfWork) : base(hearingDal)
        {
            _hearingDal = hearingDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> Add(HearingAddDto hearing)
        {
            Hearing hearingAdd = _mapper.Map<HearingAddDto, Hearing>(hearing);

            // Aynı tarihte aynı mahkemede başka duruşma var mı kontrol et
            var conflictHearing = _hearingDal.Where(h =>
                h.CourtID == hearing.CourtID &&
                h.HearingDate.Date == hearing.HearingDate.Date &&
                h.HearingTime == hearing.HearingTime &&
                h.Status == true).Any();

            if (conflictHearing)
                throw new Exception("Bu tarih ve saatte aynı mahkemede başka bir duruşma var!");

            // Geçmiş tarihte duruşma oluşturulamaz
            if (hearing.HearingDate < DateTime.Now.Date)
                throw new Exception("Geçmiş tarihte duruşma oluşturamazsınız!");

            hearingAdd.HearingStatus = 1; // Planlandı
            hearingAdd.Status = true;
            

            await _hearingDal.AddAsync(hearingAdd);
            await _unitOfWork.SaveChangesAsync();

            return new SuccessDataResult<int>(hearingAdd.ID, CommonMessages.EntityAdded);
        }
      
        public async Task<IResult> Delete(int hearingID)
        {
            Hearing? hearing = _hearingDal.Where(h => h.ID == hearingID && h.Status.Equals(true)).SingleOrDefault();

            if (hearing == null)
                throw new Exception("Duruşma bulunamadı!");

            // Geçmiş duruşma silinemez
            if (hearing.HearingDate < DateTime.Now.Date)
                throw new Exception("Geçmiş duruşmaları silemezsiniz!");

            // Yapılmış duruşma silinemez
            if (hearing.HearingStatus == 2)
                throw new Exception("Yapılmış duruşmaları silemezsiniz!");

            hearing.DeletedDate = DateTime.Now;
            hearing.Status = false;
            _hearingDal.Update(hearing);

            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityDeleted);
        }

        public async Task<IDataResult<List<HearingListDto>>> GetAllAsync()
        {
            var list = _hearingDal.GetAllQueryable()
                .Include(h => h.CaseFile)
                .Include(h => h.Court)
                .Where(h => h.Status == true)
                .OrderBy(h => h.HearingDate)
                .ToList();

            return new SuccessDataResult<List<HearingListDto>>(_mapper.Map<List<HearingListDto>>(list));
        }

        public async Task<IDataResult<List<HearingListDto>>> GetFilteredAsync(HearingFilterDto filter)
        {
            var query = _hearingDal.GetAllQueryable()
                .Include(h => h.CaseFile)
                .Include(h => h.Court)
                .Where(h => h.Status == true)
                .AsQueryable();

            // Dinamik filtreler
            if (filter.CaseFileID.HasValue)
                query = query.Where(h => h.CaseFileID == filter.CaseFileID.Value);

            if (filter.CourtID.HasValue)
                query = query.Where(h => h.CourtID == filter.CourtID.Value);

            if (filter.StartDate.HasValue)
                query = query.Where(h => h.HearingDate >= filter.StartDate.Value);

            if (filter.EndDate.HasValue)
                query = query.Where(h => h.HearingDate <= filter.EndDate.Value);

            if (!string.IsNullOrEmpty(filter.Judge))
                query = query.Where(h => h.Judge.Contains(filter.Judge));

            if (filter.HearingStatus.HasValue)
                query = query.Where(h => h.HearingStatus == filter.HearingStatus.Value);

            var list = await query.OrderBy(h => h.HearingDate).ToListAsync();
            return new SuccessDataResult<List<HearingListDto>>(_mapper.Map<List<HearingListDto>>(list));
        }

        public async Task<IDataResult<HearingDetailDto>> GetById(int hearingID)
        {
            Hearing? hearing = _hearingDal.Where(h => h.ID == hearingID && h.Status.Equals(true))
                .Include(h => h.CaseFile)
                .Include(h => h.Court)
                .ThenInclude(c => c.City)
                .Include(h => h.Court)
                .ThenInclude(c => c.District)
                .SingleOrDefault();

            if (hearing == null)
                throw new Exception($"ID: {hearingID} olan duruşma bulunamadı!");

            return new SuccessDataResult<HearingDetailDto>(_mapper.Map<HearingDetailDto>(hearing), CommonMessages.EntityListed);
        }

        public async Task<IDataResult<List<HearingListDto>>> GetByCaseFileId(int caseFileID)
        {
            var list = _hearingDal.GetAllQueryable()
                .Include(h => h.CaseFile)
                .Include(h => h.Court)
                .Where(h => h.CaseFileID == caseFileID && h.Status == true)
                .OrderBy(h => h.HearingDate)
                .ToList();

            return new SuccessDataResult<List<HearingListDto>>(_mapper.Map<List<HearingListDto>>(list));
        }

        public async Task<IDataResult<List<HearingListDto>>> GetByCourtId(int courtID)
        {
            var list = _hearingDal.GetAllQueryable()
                .Include(h => h.CaseFile)
                .Include(h => h.Court)
                .Where(h => h.CourtID == courtID && h.Status == true)
                .OrderBy(h => h.HearingDate)
                .ToList();

            return new SuccessDataResult<List<HearingListDto>>(_mapper.Map<List<HearingListDto>>(list));
        }

        public async Task<IDataResult<List<HearingListDto>>> GetTodayHearings()
        {
            var today = DateTime.Now.Date;
            var list = _hearingDal.GetAllQueryable()
                .Include(h => h.CaseFile)
                .Include(h => h.Court)
                .Where(h => h.HearingDate.Date == today && h.Status == true)
                .OrderBy(h => h.HearingTime)
                .ToList();

            return new SuccessDataResult<List<HearingListDto>>(_mapper.Map<List<HearingListDto>>(list));
        }

        public async Task<IDataResult<List<HearingListDto>>> GetUpcomingHearings(int days = 7)
        {
            var startDate = DateTime.Now.Date;
            var endDate = startDate.AddDays(days);

            var list = _hearingDal.GetAllQueryable()
                .Include(h => h.CaseFile)
                .Include(h => h.Court)
                .Where(h => h.HearingDate.Date >= startDate &&
                           h.HearingDate.Date <= endDate &&
                           h.Status == true &&
                           h.HearingStatus == 1) // Sadece planlanmış duruşmalar
                .OrderBy(h => h.HearingDate)
                .ThenBy(h => h.HearingTime)
                .ToList();

            return new SuccessDataResult<List<HearingListDto>>(_mapper.Map<List<HearingListDto>>(list));
        }

        public async Task<IResult> Update(int hearingID, HearingUpdateDto hearingUpdate)
        {
            Hearing? hearing = _hearingDal.Where(h => h.ID == hearingID && h.Status.Equals(true)).SingleOrDefault();

            if (hearing == null)
                throw new Exception("Duruşma bulunamadı!");

            // Aynı tarihte aynı mahkemede başka duruşma var mı kontrol et
            var conflictHearing = _hearingDal.Where(h =>
                h.CourtID == hearingUpdate.CourtID &&
                h.HearingDate.Date == hearingUpdate.HearingDate.Date &&
                h.HearingTime == hearingUpdate.HearingTime &&
                h.ID != hearingID &&
                h.Status == true).Any();

            if (conflictHearing)
                throw new Exception("Bu tarih ve saatte aynı mahkemede başka bir duruşma var!");

            _mapper.Map(hearingUpdate, hearing);
            hearing.UpdatedDate = DateTime.Now;
            _hearingDal.Update(hearing);

            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityUpdated);
        }
    }
}
