using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.TargetHours.Requests
{
    public class PutTargetHourWeeklyRequest
    {
        /// <summary>
        /// The related employee's ID
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// 	Type of target hours:
        /// 	'weekly': weekly target hours
        /// 	'monthly': monthly target hours
        /// </summary>
        [JsonPropertyName("type")]
        [AliasAs("type")]
        public string Type { get; set; }

        /// <summary>
        /// target hours for Monday
        /// </summary>
        [JsonPropertyName("monday")]
        [AliasAs("monday")]
        public float? Monday { get; set; }

        /// <summary>
        /// target hours for Tuesday
        /// </summary>
        [JsonPropertyName("tuesday")]
        [AliasAs("tuesday")]
        public float? Tuesday { get; set; }


        /// <summary>
        /// target hours for Wednesday
        /// </summary>
        [JsonPropertyName("wednesday")]
        [AliasAs("wednesday")]
        public float? Wednesday { get; set; }


        /// <summary>
        /// target hours for thursday
        /// </summary>
        [JsonPropertyName("thursday")]
        [AliasAs("thursday")]
        public float? Thursday { get; set; }


        /// <summary>
        /// target hours for Friday
        /// </summary>
        [JsonPropertyName("friday")]
        [AliasAs("friday")]
        public float? Friday { get; set; }


        /// <summary>
        /// target hours for Monday
        /// </summary>
        [JsonPropertyName("saturday")]
        [AliasAs("saturday")]
        public float? Saturday { get; set; }

        /// <summary>
        /// target hours for Monday
        /// </summary>
        [JsonPropertyName("sunday")]
        [AliasAs("sunday")]
        public float? Sunday { get; set; }

        /// <summary>
        /// Monthly target hours to attain
        /// </summary>
        [JsonPropertyName("monthly_target")]
        [AliasAs("monthly_target")]
        public float? MonthlyTarget { get; set; }

        /// <summary>
        /// Automatic time compensation per day in minutes
        /// </summary>
        [JsonPropertyName("compensation_daily")]
        [AliasAs("compensation_daily")]
        public float? CompensationDaily { get; set; }


        /// <summary>
        /// End date in YYYY-MM-DD format
        /// </summary>
        [JsonPropertyName("date_until")]
        [AliasAs("date_until")]
        public string DateUntil { get; set; }
    }
}
