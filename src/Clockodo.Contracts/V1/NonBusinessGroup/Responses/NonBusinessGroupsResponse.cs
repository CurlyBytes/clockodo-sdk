using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.NonBusinessGroup.Responses
{
    public class NonBusinessGroupsResponse
    {
        /// <summary>
        /// The ID of the nonbusiness group
        /// </summary>
        [JsonPropertyName("id")]
        [AliasAs("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the nonbusiness group
        /// </summary>
        [JsonPropertyName("name")]
        [AliasAs("name")]
        public string Name { get; set; }
    }
}
