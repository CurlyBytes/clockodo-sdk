using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.TargetHours.Response
{
    public class TargetHoursRowResponse
    {
        /// <summary>
        /// The ID of the target hour settings
        /// </summary>
        [JsonPropertyName("id")]
        [AliasAs("id")]
        public int Id { get; set; }


        /// <summary>
        /// 	Type of target hours:
        /// 	'weekly': weekly target hours
        /// 	'monthly': monthly target hours
        /// </summary>
        [JsonPropertyName("type")]
        [AliasAs("type")]
        public string Type { get; set; }


        /// <summary>
        /// Date from which on the target hours apply
        /// Format YYYY-MM-DD
        /// </summary>
        [JsonPropertyName("date_since")]
        [AliasAs("date_since")]
        public string DateSince { get; set; }


        /// <summary>
        /// Date until which the target hours apply
        /// Format YYYY-MM-DD
        /// </summary>
        [JsonPropertyName("date_until")]
        [AliasAs("date_until")]
        public string DateUntil { get; set; }


        /// <summary>
        /// Automatic time compensation per month in hours
        /// </summary>
        [JsonPropertyName("compensation_monthly")]
        [AliasAs("compensation_monthly")]
        public float? CompensationMonthly { get; set; }


        /// <summary>
        /// The related employee's ID
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UserId { get; set; }
    }
}
