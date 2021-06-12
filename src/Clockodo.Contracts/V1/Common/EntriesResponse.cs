using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Common.Responses
{
    public class EntriesResponse
    {
        /// <summary>
        /// ID of the entry
        /// </summary>
        [JsonPropertyName("id")]
        [AliasAs("id")]
        public int Id { get; set; }


        /// <summary>
        /// ID of the corresponding customer
        /// </summary>
        [JsonPropertyName("customers_id")]
        [AliasAs("customers_id")]
        public int? CustomersId { get; set; }


        /// <summary>
        /// ID of the corresponding project
        /// </summary>
        [JsonPropertyName("projects_id")]
        [AliasAs("projects_id")]
        public int? ProjectsId { get; set; }

        /// <summary>
        /// IDID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UsersId { get; set; }

        /// <summary>
        /// ID of the corresponding service
        /// </summary>
        [JsonPropertyName("services_id")]
        [AliasAs("services_id")]
        public int? ServicesId { get; set; }

        /// <summary>
        /// 	ID of the corresponding lump sum
        /// </summary>
        [JsonPropertyName("lumpSums_id")]
        [AliasAs("lumpSums_id")]
        public int? LumpSumsId { get; set; }

        /// <summary>
        /// Is the entry billable? (1 or 0)
        /// </summary>
        [JsonPropertyName("billable")]
        [AliasAs("billable")]
        public int? Billable { get; set; }

        /// <summary>
        /// Is the entry billable and already billed?
        /// In order to set an entry to billed, you have to set "billable = 2" in the edit request.
        /// </summary>
        [JsonPropertyName("billed")]
        [AliasAs("billed")]
        public bool Billed { get; set; }

        /// <summary>
        /// ID  of the description text
        /// </summary>
        [JsonPropertyName("texts_id")]
        [AliasAs("texts_id")]
        public int? TextsId { get; set; }

        /// <summary>
        /// description text
        /// </summary>
        [JsonPropertyName("text")]
        [AliasAs("text")]
        public string Text { get; set; }

        /// <summary>
        /// Duration of the entry in seconds
        /// </summary>
        [JsonPropertyName("duration")]
        [AliasAs("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Duration of the entry in HH:MM:SS format
        /// </summary>
        [JsonPropertyName("duration_time")]
        [AliasAs("duration_time")]
        public string DurationTime { get; set; }

        /// <summary>
        /// The time correction of the entry in seconds. Is set if the duration differs from the period between start and end.
        /// </summary>
        [JsonPropertyName("offset")]
        [AliasAs("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// The time correction of the entry in HH:MM:SS format. Is set if the duration differs from the period between start and end.
        /// </summary>
        [JsonPropertyName("offset_time")]
        [AliasAs("offset_time")]
        public string OffsetTime { get; set; }


        /// <summary>
        /// Starting time
        /// </summary>
        [JsonPropertyName("time_since")]
        [AliasAs("time_since")]
        public string TimeSince { get; set; }

        /// <summary>
        /// End time, NULL if entry is running
        /// </summary>
        [JsonPropertyName("time_until")]
        [AliasAs("time_until")]
        public string TimeUntil { get; set; }

        /// <summary>
        /// 	Insert time
        /// </summary>
        [JsonPropertyName("time_insert")]
        [AliasAs("time_insert")]
        public string TimeInsert { get; set; }

        /// <summary>
        /// 	Time at which the entry has been changed the last time
        /// (e.g. in format “YYYY-MM-DD HH:MM:SS”; see section “Localisation”)
        /// </summary>
        [JsonPropertyName("time_last_change")]
        [AliasAs("time_last_change")]
        public string TimeLastChange    { get; set; }

        /// <summary>
        /// Time at which worktime relevant details have been changed the last time
        /// (e.g. in format “YYYY-MM-DD HH:MM:SS”; see section “Localisation”)
        /// </summary>
        [JsonPropertyName("time_last_change_worktime")]
        [AliasAs("time_last_change_worktime")]
        public string TimeLastChangeWorktime { get; set; }

        /// <summary>
        /// Entry was stopped with the clock
        /// </summary>
        [JsonPropertyName("clocked")]
        [AliasAs("clocked")]
        public bool Clocked { get; set; }

        /// <summary>
        /// Entry is running
        /// </summary>
        [JsonPropertyName("is_clocking")]
        [AliasAs("is_clocking")]
        public bool IsClocking { get; set; }

        /// <summary>
        /// Returns the lump sum if the entry is a lump sum entry with no amount allocated to a lump sum
        /// </summary>
        [JsonPropertyName("lumpSum")]
        [AliasAs("lumpSum")]
        public float? LumpSum { get; set; }

        /// <summary>
        /// The lump sum amount, if the entry is a entry with allocation to a lump sum
        /// </summary>
        [JsonPropertyName("lumpSums_amount")]
        [AliasAs("lumpSums_amount")]
        public float? LumpSumsAmount { get; set; }
    }
}
