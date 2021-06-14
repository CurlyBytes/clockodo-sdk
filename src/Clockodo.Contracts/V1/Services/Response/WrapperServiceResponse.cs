using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Services.Response
{
    public class WrapperServiceResponse
    {
        /// <summary>
        /// Service Wrapper
        /// </summary>
        [JsonPropertyName("services")]
        [AliasAs("services")]

        public List<ServiceResponse> Services { get; set; }
    }
}
