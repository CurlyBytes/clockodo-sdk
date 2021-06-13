using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.EntryGroup.Requests;
using Clockodo.Contracts.V1.EntryGroup.Response;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface IEntryGroups
    {
        [Get(ApiRoutes.EntryGroups.GetRequestGroups)]
        Task<ApiResponse<WrapperEntryGroupsResponse>> GetAllEntryGroups([Query] GetEntryGroupRequest getEntryGroupsRequest);

      
  
        [Put(ApiRoutes.EntryGroups.PutEntries)]
        Task<ApiResponse<dynamic>> PutEntryGroupsAsync([Query] PutEntryGroupRequest putEntryGroupRequest);

        [Delete(ApiRoutes.EntryGroups.DeleteEntries)]
        Task<ApiResponse<dynamic>> DeleteEntryGroupsAsync([Query] DeleteEntryGroupRequest deleteEntryGroupRequest);
    }
}
