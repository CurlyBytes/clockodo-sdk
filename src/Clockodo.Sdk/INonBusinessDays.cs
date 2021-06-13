using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.NoBusinessDays.Requests;
using Clockodo.Contracts.V1.NoBusinessDays.Response;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface INonBusinessDays
    {
        [Get(ApiRoutes.NonBusinessDays.GetListNonBusinessDays)]
        Task<ApiResponse<WrapperNonBusinessDaysResponse>> GetAllAbsences([Query] GetNonBusinessDaysRequest getNonBusinessDaysRequest);

    }
}
