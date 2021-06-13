using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.LumpServices.Responses
{
    public class WrapperLumpSumServiceResponse
    {
        [JsonPropertyName("lumpSumServices")]
        [AliasAs("lumpSumServices")]
        public List<LumpSumServicesResponse> LumpSumServicesResponse { get; set; }
    }
}
