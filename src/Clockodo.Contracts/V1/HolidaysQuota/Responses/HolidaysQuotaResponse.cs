using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.HolidaysQuota.Responses
{
    public class HolidaysQuotaResponse
    {
        /// <summary>
        /// TheThe ID of the holiday quota settings
        /// </summary>
        [JsonPropertyName("id")]
        [AliasAs("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The related employee's ID
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UsersId { get; set; }


        /// <summary>
        /// Year from which on the holiday quota setting apply
        /// Format YYYY
        /// </summary>
        [JsonPropertyName("year_since")]
        [AliasAs("year_since")]
        public int? YearSince { get; set; }


        /// <summary>
        /// Year until which the holiday quota setting apply
        /// Format YYYY
        /// </summary>
        [JsonPropertyName("year_until")]
        [AliasAs("year_until")]
        public int? YearUntil { get; set; }


        /// <summary>
        /// Count of holidays
        /// </summary>
        [JsonPropertyName("count")]
        [AliasAs("count")]
        public float? Count { get; set; }
    }
}
