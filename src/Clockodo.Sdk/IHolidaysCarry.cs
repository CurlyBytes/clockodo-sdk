using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.HolidaysCarry.Requests;
using Clockodo.Contracts.V1.HolidaysCarry.Response;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface IHolidaysCarry
    {
        [Get(ApiRoutes.HolidaysCarry.GetListHolidaysCarry)]
        Task<ApiResponse<WrapperHolidayCaryResponse>> GetAllHolidaysCarry([Query] GetHolidayCaryRequest getHolidayCaryRequest);

        [Get(ApiRoutes.HolidaysCarry.GetHolidaysCarryByUserIdYear)]
        Task<ApiResponse<WrapperHolidayCaryResponse>> GetllHolidaysCarryById(int id, int year);

        [Post(ApiRoutes.HolidaysCarry.PostHolidaysCarry)]
        Task<ApiResponse<WrapperHolidayCaryResponse>> PostHolidaysCarryAsync([Body(BodySerializationMethod.UrlEncoded)] PostHolidayCaryRequest postHolidayCaryRequest);

        [Put(ApiRoutes.HolidaysCarry.PuttHolidaysCarry)]
        Task<ApiResponse<WrapperHolidayCaryResponse>> PutHolidaysCarryAsync(int id,int year, [Body(BodySerializationMethod.UrlEncoded)] PutHolidayCaryRequest putHolidayCaryRequest);

        [Delete(ApiRoutes.HolidaysCarry.DeleteHolidaysCarry)]
        Task<ApiResponse<string>> DeleteHolidaysCarryAsync(int id, int year);
    }
}
