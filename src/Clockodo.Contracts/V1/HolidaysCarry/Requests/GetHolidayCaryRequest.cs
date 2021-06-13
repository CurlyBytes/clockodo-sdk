using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.HolidaysCarry.Requests
{
    public class GetHolidayCaryRequest
    {
        /// <summary>
        /// The related employee's ID
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Year for which the holiday carryover applie
        /// </summary>
        [JsonPropertyName("year")]
        [AliasAs("year")]
        public int? Year { get; set; }

    }
}
