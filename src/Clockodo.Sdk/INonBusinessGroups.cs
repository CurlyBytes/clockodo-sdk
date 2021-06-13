using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.NonBusinessGroups.Requests;
using Clockodo.Contracts.V1.NonBusinessGroups.Responses;
using Clockodo.Contracts.V1.NoBusinessDays.Requests;
using Clockodo.Contracts.V1.NoBusinessDays.Response;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Clockodo.Contracts.V1.NonBusinessGroup.Responses;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface INonBusinessGroups
    {
        [Get(ApiRoutes.NonBusinessGroups.GetListNonBusinessGroups)]
        Task<ApiResponse<WrapperNonBusinessGroupsResponse>> GetAllNonBusinessGroupss();

    }
}
