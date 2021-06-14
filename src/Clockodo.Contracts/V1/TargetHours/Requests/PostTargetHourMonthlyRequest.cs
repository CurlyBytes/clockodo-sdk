using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.TargetHours.Requests
{
    public class PostTargetHourMonthlyRequest
    {
        /// <summary>
        /// The related employee's ID
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 	Type of target hours:
        /// 	'weekly': weekly target hours
        /// 	'monthly': monthly target hours
        /// </summary>
        [JsonPropertyName("type")]
        [AliasAs("type")]
        public string Type { get; set; }


        /// <summary>
        /// Is Tuesday a work day?
        /// </summary>
        [JsonPropertyName("workday_tuesday")]
        [AliasAs("workday_tuesday")]
        public bool? WorkdayTuesday { get; set; }


        /// <summary>
        /// Is Wednesday a work day?
        /// </summary>
        [JsonPropertyName("workday_wednesday")]
        [AliasAs("workday_wednesday")]
        public bool? WorkdayWednesday { get; set; }


        /// <summary>
        /// Is Thursday a work day?
        /// </summary>
        [JsonPropertyName("workday_thursday")]
        [AliasAs("workday_thursday")]
        public bool? WorkdayThursday { get; set; }


        /// <summary>
        /// Is Friday a work day?
        /// </summary>
        [JsonPropertyName("workday_friday")]
        [AliasAs("workday_friday")]
        public bool? WorkdayFriday { get; set; }


        /// <summary>
        /// Is Saturday a work day?
        /// </summary>
        [JsonPropertyName("workday_saturday")]
        [AliasAs("workday_saturday")]
        public bool? WorkdaySaturday { get; set; }


        /// <summary>
        /// Is Sunday a work day?
        /// </summary>
        [JsonPropertyName("workday_sunday")]
        [AliasAs("workday_sunday")]
        public bool? WorkdaySunday { get; set; }


        /// <summary>
        /// Is Monday a work day?
        /// </summary>
        [JsonPropertyName("workday_monday")]
        [AliasAs("workday_monday")]
        public bool? WorkdayMonday { get; set; }

        /// <summary>
        /// Monthly target hours to attain
        /// </summary>
        [JsonPropertyName("monthly_target")]
        [AliasAs("monthly_target")]
        public float? MonthlyTarget { get; set; }

        /// <summary>
        /// Automatic time compensation per month in hours
        /// </summary>
        [JsonPropertyName("compensation_monthly")]
        [AliasAs("compensation_monthly")]
        public float? CompensationMonthly { get; set; }

        /// <summary>
        /// End date in YYYY-MM-DD format
        /// </summary>
        [JsonPropertyName("date_until")]
        [AliasAs("date_until")]
        public string DateUntil { get; set; }
    }
}
