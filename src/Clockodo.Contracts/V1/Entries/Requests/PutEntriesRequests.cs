using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Entries.Requests
{
    public class PutEntriesRequests
    {
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
        /// IDID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UsersId { get; set; }

     
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
