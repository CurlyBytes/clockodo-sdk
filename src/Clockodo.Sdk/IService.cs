using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.Services.Request;
using Clockodo.Contracts.V1.Services.Requests;
using Clockodo.Contracts.V1.Services.Response;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface IService
    {
        [Get(ApiRoutes.Services.GetListServices)]
        Task<ApiResponse<WrapperServiceResponse>> GetAllServices();

        [Get(ApiRoutes.Services.GetServices)]
        Task<ApiResponse<WrapperServiceRowResponse>> GetllServicesById(int id);

        [Post(ApiRoutes.Services.PostServices)]
        Task<ApiResponse<WrapperServiceRowResponse>> PostServicesAsync([Body(BodySerializationMethod.UrlEncoded)] PostServiceRequest postServiceRequest);

        [Put(ApiRoutes.Services.PutServices)]
        Task<ApiResponse<WrapperServiceRowResponse>> PutServicesAsync(int id, [Body(BodySerializationMethod.UrlEncoded)] PutServiceRequest putServiceRequest);

        [Delete(ApiRoutes.Services.DeleteteServices)]
        Task<ApiResponse<string>> DeleteServicesAsync(int id);
    }
}
