using Clockodo.Contracts.V1.Common.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Entries.Responses
{
    public class WrapperUpdatingClockResponse
    {
        [JsonPropertyName("updated")]
        public EntriesResponse Updated { get; set; }

        [JsonPropertyName("stopped")]
        public EntriesResponse Stopped { get; set; }
    }
}
