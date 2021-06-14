using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Services.Response
{
    public class WrapperServiceRowResponse
    {
        /// <summary>
        /// Service Wrapper
        /// </summary>
        [JsonPropertyName("service")]
        [AliasAs("service")]

        public ServiceResponse Services { get; set; }
    }
}
