using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Entries.Requests;
using Clockodo.Contracts.V1.Entries.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{

    [Headers("Authorization: Basic")]
    public interface IClock
    {
        [Get(ApiRoutes.Clock.GetClock)]
        Task<ApiResponse<WrapperRunningResponse>> GetAllClock();

        [Get(ApiRoutes.Clock.GetClockUpdate)]
        Task<ApiResponse<ClockUpdateResponse>>  GetClockStatusInformation();

        [Get(ApiRoutes.Clock.GetSearchText)]
        Task<ApiResponse<dynamic>> GetSearchText();

        [Post(ApiRoutes.Clock.PostStartClock)]
        Task<ApiResponse<WrapperRunningResponse>> PostClockAsync([Body(BodySerializationMethod.UrlEncoded)] PostStartClock postClock);
        
        [Delete(ApiRoutes.Clock.DeleteStopClock)]
        Task<ApiResponse<WrapperStopRunningResponse>> DeleteAbsencesAsync([Body(BodySerializationMethod.UrlEncoded)] DeleteStopClock deleteStopClock);

        [Put(ApiRoutes.Clock.PutClock)]
        Task<ApiResponse<WrapperUpdatingClockResponse>> PutAbsencesAsync(int id, [Body(BodySerializationMethod.UrlEncoded)] PutUpdateClock putUpdateClock);

    }
}
