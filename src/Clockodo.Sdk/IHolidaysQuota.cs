using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.HolidaysQuota.Requests;
using Clockodo.Contracts.V1.HolidaysQuota.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface IHolidaysQuota
    {
        [Get(ApiRoutes.HolidaysQuota.GetListHolidaysQuota)]
        Task<ApiResponse<WrapperHolidaysQuotaResponse>> GetAllHolidaysQuota([Query] GetHolidaysQuotaRequest getHolidaysQuotaRequest);

        [Get(ApiRoutes.HolidaysQuota.GetHolidaysQuotaById)]
        Task<ApiResponse<WrapperHolidaysQuotaRowResponse>> GetllHolidaysQuotaById(int id);

        [Post(ApiRoutes.HolidaysQuota.GetListHolidaysQuota)]
        Task<ApiResponse<WrapperHolidaysQuotaRowResponse>> PostHolidaysQuotaAsync([Body(BodySerializationMethod.UrlEncoded)] PostHolidaysQuotaRequest postHolidaysQuotaRequest);

        [Put(ApiRoutes.HolidaysQuota.PuttHolidaysQuota)]
        Task<ApiResponse<WrapperHolidaysQuotaRowResponse>> PutHolidaysQuotaAsync(int id, [Body(BodySerializationMethod.UrlEncoded)] PutHolidaysQuotaRequest putHolidaysQuotaRequest);

        [Delete(ApiRoutes.HolidaysQuota.DeletetHolidaysQuota)]
        Task<ApiResponse<string>> DeleteHolidaysQuotaAsync(int id);
    }
}
