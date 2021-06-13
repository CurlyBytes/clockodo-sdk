using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.EntryGroup.Response
{
    public class WrapperEntryGroupsResponse
    {
        [JsonPropertyName("groups")]
        [AliasAs("groups")]
        public List<EntryGroupResponse> Groups
        {
            get; set;
        }
    }
}
