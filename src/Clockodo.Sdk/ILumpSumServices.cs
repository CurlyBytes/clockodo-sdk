using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.LumpServices.Responses;
using Clockodo.Contracts.V1.LumpSumServices.Requests;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface ILumpSumServices
    {
        [Get(ApiRoutes.LumpSumServices.GetListLumpSumServices)]
        Task<ApiResponse<WrapperLumpSumServiceResponse>> GetAllLumpSumServices();

        [Get(ApiRoutes.LumpSumServices.GetLumpSumServices)]
        Task<ApiResponse<WrapperLumpSumServiceRowResponse>> GetllLumpSumServicesById(int id);

        [Post(ApiRoutes.LumpSumServices.GetListLumpSumServices)]
        Task<ApiResponse<WrapperLumpSumServiceRowResponse>> PostLumpSumServicesAsync([Body(BodySerializationMethod.UrlEncoded)] PostLumpSumServicesRequest postLumpSumServicesRequest);

        [Put(ApiRoutes.LumpSumServices.PutLumpSumServices)]
        Task<ApiResponse<WrapperLumpSumServiceRowResponse>> PutLumpSumServicesAsync(int id, [Body(BodySerializationMethod.UrlEncoded)] PutLumpSumServicesRequest putLumpSumServicesRequest);

        [Delete(ApiRoutes.LumpSumServices.DeleteLumpSumServices)]
        Task<ApiResponse<string>> DeleteLumpSumServicesAsync(int id);
    }
}
