using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.NoBusinessDays.Response
{
    public class WrapperNonBusinessDaysResponse
    {
        [JsonPropertyName("nonbusinessdays")]
        [AliasAs("nonbusinessdays")]
        public List<NonBusinessDaysResponse> NonBusinessDaysResponse { get; set; }
    }
}
