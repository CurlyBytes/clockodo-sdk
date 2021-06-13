using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.Entries.Requests;
using Clockodo.Contracts.V1.Entries.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface IEntries
    {
        [Get(ApiRoutes.Entries.GetListEntries)]
        Task<ApiResponse<WrapperEntriesResponse>> GetAllEntries([Query]GetEntriesRequest getEntriesRequest);

        [Get(ApiRoutes.Entries.GetEntriesById)]
        Task<ApiResponse<WrapperEntryResponse>> GetllEntriesById(int id);

        [Post(ApiRoutes.Entries.PostEntries)]
        Task<ApiResponse<WrapperEntryResponse>> PostEntriesAsync([Body(BodySerializationMethod.UrlEncoded)] PostEntriesRequest postEntriesRequest);


        [Post(ApiRoutes.Entries.PostLumpSumEntries)]
        Task<ApiResponse<WrapperEntryResponse>> PostLumpSumEntries([Body(BodySerializationMethod.UrlEncoded)] PostLumpSumEntriesRequest postLumpSumEntriesRequest);


        [Post(ApiRoutes.Entries.PostLumpSumServiceEntries)]
        Task<ApiResponse<WrapperEntryResponse>> PostLumpSumServiceEntries([Body(BodySerializationMethod.UrlEncoded)] PostLumpSumServiceEntriesRequest postLumpSumServiceEntriesRequest);

        [Put(ApiRoutes.Entries.PutEntries)]
        Task<ApiResponse<WrapperAbsenceResponse>> PutEntriesAsync(int id, [Body(BodySerializationMethod.UrlEncoded)] PutEntriesRequests putEntries);

        [Delete(ApiRoutes.Entries.DeleteEntries)]
        Task<ApiResponse<string>> DeleteEntriesAsync(int id);
    }
}
