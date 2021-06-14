using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.TargetHours.Response
{
    public class TargetHoursMonthlyResponse
    {

        /// <summary>
        /// Monthly target hours to attain
        /// </summary>
        [JsonPropertyName("monthly_target")]
        [AliasAs("monthly_target")]
        public float? MonthlyTarget { get; set; }


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

    }
}
