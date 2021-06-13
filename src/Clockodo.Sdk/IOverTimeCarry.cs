using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.OvertimeCarry.Requests;
using Clockodo.Contracts.V1.OvertimeCarry.Response;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface IOverTimeCarry
    {
        [Get(ApiRoutes.OverTimeCarry.GetListOverTimeCarry)]
        Task<ApiResponse<WrapperOvertimeCarryResponse>> GetAllOvertimeCarry([Query] GetOvertimeCarryRequest getOvertimeCarryRequest);

        [Get(ApiRoutes.OverTimeCarry.GetOverTimeCarry)]
        Task<ApiResponse<WrapperOvertimeCarryRowResponse>> GetllOvertimeCarryById(int id, int year);

        [Post(ApiRoutes.OverTimeCarry.PostOverTimeCarry)]
        Task<ApiResponse<WrapperOvertimeCarryRowResponse>> PostOvertimeCarryAsync([Body(BodySerializationMethod.UrlEncoded)] PostOvertimeCarryRequest postOvertimeCarryRequest);

        [Put(ApiRoutes.OverTimeCarry.PutOverTimeCarry)]
        Task<ApiResponse<WrapperOvertimeCarryRowResponse>> PutOvertimeCarryAsync(int id,int year, [Body(BodySerializationMethod.UrlEncoded)] PutOvertimeCarryRequest putOvertimeCarryRequest);

        [Delete(ApiRoutes.OverTimeCarry.DeleteOverTimeCarry)]
        Task<ApiResponse<string>> DeleteOvertimeCarryAsync(int id);
    }
}
