using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Entries.Requests
{
    public class DeleteStopClock
    {

       

        /// <summary>
        /// ID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UsersId { get; set; }

        /// <summary>
        /// Duration of the entry in seconds
        /// </summary>
        [JsonPropertyName("duration")]
        [AliasAs("duration")]
        public int? Duration { get; set; }

    }
}
