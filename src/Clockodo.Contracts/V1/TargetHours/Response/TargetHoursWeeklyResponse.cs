using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.TargetHours.Response
{
    public class TargetHoursWeeklyResponse
    {
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
        /// true if credited absence hours are applied against the average target hours, false if credited absence hours match the target hours of the specific day
        /// </summary>
        [JsonPropertyName("absence_fixed_credit")]
        [AliasAs("absence_fixed_credit")]
        public bool? AbsenceFixedCredit { get; set; }

        /// <summary>
        /// Automatic time compensation per day in minutes
        /// </summary>
        [JsonPropertyName("compensation_daily")]
        [AliasAs("compensation_daily")]
        public float? CompensationDaily { get; set; }

    }
}
