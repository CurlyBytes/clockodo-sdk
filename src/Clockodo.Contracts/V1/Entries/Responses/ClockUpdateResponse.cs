using Clockodo.Contracts.V1.Common;
using Clockodo.Contracts.V1.Common.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Entries.Responses
{
    public class ClockUpdateResponse
    {
        [JsonPropertyName("running")]
        public EntriesResponse Entries { get; set; }

        [JsonPropertyName("projects")]
        public List<ProjectsResponse> Projects
        {
            get; set;
        }

        [JsonPropertyName("services")]
        public List<ServiceResponse> Services { get; set; }
    }
}
