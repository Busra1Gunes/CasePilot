using Core.Utilities.Results;
using Entities.Dto.HearingDto;

namespace Business.Abstract
{
    public interface IHearingService 
    {
        Task<IResult> Add(HearingAddDto hearing);
        Task<IResult> Update(int hearingID, HearingUpdateDto hearingUpdate);
        Task<IResult> Delete(int hearingID);
        Task<IDataResult<HearingDetailDto>> GetById(int hearingID);
        Task<IDataResult<List<HearingListDto>>> GetAllAsync();
        Task<IDataResult<List<HearingListDto>>> GetFilteredAsync(HearingFilterDto filter);
        Task<IDataResult<List<HearingListDto>>> GetByCaseFileId(int caseFileID);
        Task<IDataResult<List<HearingListDto>>> GetByCourtId(int courtID);
        Task<IDataResult<List<HearingListDto>>> GetTodayHearings();
        Task<IDataResult<List<HearingListDto>>> GetUpcomingHearings(int days = 7);
    }

}
