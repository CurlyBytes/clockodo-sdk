using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.HolidaysQuota.Requests
{
    public class PutHolidaysQuotaRequest
    {
    

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
