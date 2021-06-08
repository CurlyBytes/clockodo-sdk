using Clockodo.Contracts.V1.Absence.Enums;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Clockodo.Contracts.V1.Absence.Requests
{
    public class PostAbsencesRequest
    {

        /// <summary>
        /// Start date in YYYY-MM-DD format
        /// </summary>|
        [JsonPropertyName("date_since")]
        [AliasAs("date_since")]
        public string DateSince { get; set; }

        /// <summary>
        /// End date in YYYY-MM-DD format
        /// </summary>
        [JsonPropertyName("date_until")]
        [AliasAs("date_until")]
        public string DateUntil { get; set; }

 
        /// <summary>
        /// Type of the absence:
        ////1: Regular holiday
        ////2: Special leaves
        ////3: Reduction of overtime
        ////4: Sick day
        ////5: Sick day of a child
        ////6: School / further education
        ////7: Maternity protection
        ////8: Home office(planned hours are applied)
        ////9: Work out of office(planned hours are applied)
        ////10: Special leaves(unpaid)
        ////11: Sick day(unpaid)
        ////12: Sick day of a child(unpaid)
        ////13: Quarantine(only full days)
        ////14: Military / alternative service(only full days)
        ////Only with access rights for absence administration or in case of own absences
        /// </summary>
        [JsonPropertyName("type")]
        [AliasAs("type")]
        public int Type { get; set; }

        /// <summary>
        /// ID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UsersId { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        [JsonPropertyName("note")]
        [AliasAs("note")]
        public string Note { get; set; }


        /// <summary>
        /// Amount of absence days (null for overtime reduction)
        ////Only with access rights for absence administration or in case of own absences
        /// </summary>
        [JsonPropertyName("count_days")]
        [AliasAs("count_days")]
        public float? CountDays { get; set; }


        /// <summary>
        /// 	Amount of hours of overtime reduction (null in other cases)
        ////Only with access rights for absence administration or in case of own absences
        /// </summary>
        [JsonPropertyName("count_hours")]
        [AliasAs("count_hours")]
        public float? CountHours { get; set; }
    }
}
