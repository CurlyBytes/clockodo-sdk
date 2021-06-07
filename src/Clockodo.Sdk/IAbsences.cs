using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Requests;
using Clockodo.Contracts.V1.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface IAbsences
    {
        [Get(ApiRoutes.Absences.GetListAbsences)]
        Task<ApiResponse<WrapperAbsencesResponse>> GetAllAbsences([Query]GetAbsenceRequest getAbsence);


        [Get(ApiRoutes.Absences.Get)]
        Task<ApiResponse<WrapperAbsenceResponse>> GetllAbsencesById(int id);

        [Post(ApiRoutes.Absences.Post)]
        Task<ApiResponse<WrapperAbsenceResponse>> PostAbsencesAsync([Body] PostAbsencesRequest postAbsences);

        [Put(ApiRoutes.Absences.Put)]
        Task<ApiResponse<WrapperAbsenceResponse>> PutAbsencesAsync(int id, [Body] PutAbsencesRequest putAbsences);

        [Delete(ApiRoutes.Absences.Delete)]
        Task<ApiResponse<string>> DeleteAbsencesAsync(int id);
    }
}
