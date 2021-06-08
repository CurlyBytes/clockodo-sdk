using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Clockodo.Contracts.V1.Absence.Requests
{
    public class GetAbsenceRequest
    {
        /// <summary>
        /// Year filter query
        /// </summary>
        [JsonPropertyName("year")]
        [AliasAs("year")]
        public int Year { get; set; }

        /// <summary>
        /// ID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UsersId { get; set; }
    }
}
