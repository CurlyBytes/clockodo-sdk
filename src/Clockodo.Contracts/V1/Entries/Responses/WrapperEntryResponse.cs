using Clockodo.Contracts.V1.Common;
using Clockodo.Contracts.V1.Common.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Entries.Responses
{
    public class WrapperEntryResponse
    {
        

        [JsonPropertyName("entry")]
        [AliasAs("entry")]
        public EntriesResponse Entry
        {
            get; set;
        }
    }
}
