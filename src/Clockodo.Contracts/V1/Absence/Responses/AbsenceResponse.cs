using Clockodo.Contracts.V1.Absence.Enums;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Clockodo.Contracts.V1.Absence.Responses
{
    public class AbsenceResponse
    {
        /// <summary>
        /// ID of the absence
        /// </summary>
        [JsonPropertyName("id")]
        [AliasAs("id")]
        public int Id { get; set; }

        /// <summary>
        /// ID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int UsersId { get; set; }

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
        /// 	Status of the absence:
        ///0: enquired/reported
        ///1: approved
        ///2: declined
        ///3: approval cancelled
        ///4: request cancelled
        //Only with access rights for absence administration or in case of own absences
        /// </summary>
        [JsonPropertyName("status")]
        [AliasAs("status")]
        public AbsenceStatusEnum Status { get; set; }

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
        public AbsenceTypeEnum Type { get; set; }

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

        /// <summary>
        /// 	Date at which the absence request has been enquired in YYYY-MM-DD format
        ////Only with access rights for absence administration or in case of own absences
        /// </summary>
        [JsonPropertyName("date_enquired")]
        [AliasAs("date_enquired")]
        public string DateEnquired { get; set; }

        /// <summary>
        /// ate at which the absence request has been approved, declined or cancelled in format YYYY-MM-DD
        ////Only with access rights for absence administration or in case of own absences
        /// </summary>
        [JsonPropertyName("date_approved")]
        [AliasAs("date_approved")]
        public string DateApprove { get; set; }

        /// <summary>
        /// 	The ID of the co-worker who has approved, declined or cancelled the request
        ////Only with access rights for absence administration or in case of own absences
        /// </summary>
        [JsonPropertyName("approved_by")]
        [AliasAs("approved_by")]
        public int ApproveBy { get; set; }

    }
}
