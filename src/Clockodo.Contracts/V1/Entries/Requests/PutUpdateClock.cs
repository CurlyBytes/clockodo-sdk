using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Entries.Requests
{
    public class PutUpdateClock
    {
        /// <summary>
        /// Duration of the entry in seconds
        /// </summary>
        [JsonPropertyName("duration")]
        [AliasAs("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The time correction of the entry in seconds. Is set if the duration differs from the period between start and end.
        /// </summary>
        [JsonPropertyName("offset")]
        [AliasAs("offset")]
        public int? Offset { get; set; }
    }
}
