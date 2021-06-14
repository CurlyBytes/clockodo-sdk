using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.Projects.Requests;
using Clockodo.Contracts.V1.Projects.Response;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface IProject
    {
        [Get(ApiRoutes.Projects.GetListProjects)]
        Task<ApiResponse<WrapperProjectResponse>> GetAllProjects();

        [Get(ApiRoutes.Projects.GetProjects)]
        Task<ApiResponse<WrapperAbsenceResponse>> GetllProjectsById(int id);

        [Post(ApiRoutes.Projects.PostProjects)]
        Task<ApiResponse<WrapperAbsenceResponse>> PostProjectsAsync([Body(BodySerializationMethod.UrlEncoded)] PostProjectsRequest postProjectsRequest);

        [Put(ApiRoutes.Projects.PutProjects)]
        Task<ApiResponse<WrapperAbsenceResponse>> PutProjectsAsync(int id, [Body(BodySerializationMethod.UrlEncoded)] PutProjectsRequest putProjectsRequest);

        [Delete(ApiRoutes.Projects.DeleteteProjects)]
        Task<ApiResponse<string>> DeleteProjectsAsync(int id);
    }
}
