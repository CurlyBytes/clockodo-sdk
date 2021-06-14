using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Services.Request
{
    public class PostServiceRequest
    {
        /// <summary>
        /// Name of the service
        /// </summary>
        [JsonPropertyName("name")]
        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Service number
        /// </summary>
        [JsonPropertyName("number")]
        [AliasAs("number")]
        public string Number { get; set; }


        /// <summary>
        /// Is the service active?
        /// </summary>
        [JsonPropertyName("active")]
        [AliasAs("active")]
        public bool? Active { get; set; }


        /// <summary>
        /// Note for the service
        /// </summary>
        [JsonPropertyName("note")]
        [AliasAs("note")]
        public string Note { get; set; }
    }
}
