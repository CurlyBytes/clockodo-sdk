using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Entries.Requests
{
    public class GetEntriesRequest
    {

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
    }
}
