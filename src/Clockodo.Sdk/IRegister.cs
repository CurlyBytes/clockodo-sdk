using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.Register.Requests;
using Clockodo.Contracts.V1.Register.Response;
using Clockodo.Contracts.V1.Register.Requests;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface IRegister
    {
     

        [Post(ApiRoutes.Account.PostRegisterAcount)]
        Task<ApiResponse<WrapperAbsenceResponse>> PostRegisterAsync([Body(BodySerializationMethod.UrlEncoded)] PostRegisterRequest postRegisterRequest);

    }
}
