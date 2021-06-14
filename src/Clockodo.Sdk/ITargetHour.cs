using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.TargetHours.Requests;
using Clockodo.Contracts.V1.TargetHours.Response;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface ITargetHour
    {
        [Get(ApiRoutes.TargetHours.GetListTargetHours)]
        Task<ApiResponse<WrapperTargetHoursRowResponse>> GetAllTargetHours([Query] GetTargetHoursRequest getTargetHoursRequest);

        [Get(ApiRoutes.TargetHours.GetTargetHours)]
        Task<ApiResponse<WrapperTargetHoursRowRowResponse>> GetllTargetHoursById(int id);

        [Post(ApiRoutes.TargetHours.PostTargetHoursWeekly)]
        Task<ApiResponse<WrapperTargetHoursRowRowResponse>> PostTargetHourMonthlyAsync([Body(BodySerializationMethod.UrlEncoded)] PostTargetHourMonthlyRequest postTargetHoursRequest);

        [Post(ApiRoutes.TargetHours.PostTargetHoursMonthly)]
        Task<ApiResponse<WrapperTargetHoursRowRowResponse>> postTargetHourMonthlyAsync([Body(BodySerializationMethod.UrlEncoded)] PostTargetHourMonthlyRequest postTargetHourMonthlyRequest);



        [Put(ApiRoutes.TargetHours.PutTargetHoursWeekly)]
        Task<ApiResponse<WrapperTargetHoursRowRowResponse>> PutTargetHourWeeklyAsync(int id, [Body(BodySerializationMethod.UrlEncoded)] PutTargetHourWeeklyRequest putTargetHourWeeklyRequest);

        [Put(ApiRoutes.TargetHours.PutTargetHoursMonthly)]
        Task<ApiResponse<WrapperTargetHoursRowRowResponse>> PutTargetHourMonthlyAsybc(int id, [Body(BodySerializationMethod.UrlEncoded)] PutTargetHourMonthlyRequest putTargetHourMonthlyRequest);


        [Delete(ApiRoutes.TargetHours.DeleteteTargetHours)]
        Task<ApiResponse<string>> DeleteTargetHoursAsync(int id);
    }
}
