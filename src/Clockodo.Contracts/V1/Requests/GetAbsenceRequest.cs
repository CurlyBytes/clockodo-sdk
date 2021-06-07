using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Clockodo.Contracts.V1.Requests
{
    public class GetAbsenceRequest
    {
        [JsonPropertyName("year")]
        [AliasAs("year")]
        public int Year { get; set; }

        [JsonPropertyName("users_id ")]
        [AliasAs("users_id")]
        public int? UsersId { get; set; }
    }
}
