using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.NonBusinessGroup.Responses
{
    public class WrapperNonBusinessGroupsResponse
    {
        [JsonPropertyName("nonbusinessgroups")]
        public List<NonBusinessGroupsResponse> NonBusinessGroupsResponse { get; set; }
    }
}
