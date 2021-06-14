using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

        [Post(ApiRoutes.Absences.GetListAbsences)]
        Task<ApiResponse<WrapperAbsenceResponse>> PostAbsencesAsync([Body(BodySerializationMethod.UrlEncoded)] PostAbsencesRequest postAbsences);

        [Put(ApiRoutes.Absences.Put)]
        Task<ApiResponse<WrapperAbsenceResponse>> PutAbsencesAsync(int id, [Body(BodySerializationMethod.UrlEncoded)] PutAbsencesRequest putAbsences);

        [Delete(ApiRoutes.Absences.Delete)]
        Task<ApiResponse<string>> DeleteAbsencesAsync(int id);
    }
}
