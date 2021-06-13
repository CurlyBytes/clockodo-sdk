using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.LumpSumServices.Requests
{
    public class PutLumpSumServicesRequest
    {
        /// <summary>
        /// Name of the lump sum service
        /// </summary>
        [JsonPropertyName("name")]
        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Price of the lump sum service
        /// </summary>
        [JsonPropertyName("price")]
        [AliasAs("price")]
        public float? Price { get; set; }


        /// <summary>
        /// Unit of the lump sum service
        /// </summary>
        [JsonPropertyName("unit")]
        [AliasAs("unit")]
        public string Unit { get; set; }


        /// <summary>
        /// Lump sum service number
        /// </summary>
        [JsonPropertyName("number")]
        [AliasAs("number")]
        public string Number { get; set; }


        /// <summary>
        /// Is the lump sum service active?
        /// </summary>
        [JsonPropertyName("active")]
        [AliasAs("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Note for the lump sum service
        /// </summary>
        [JsonPropertyName("note")]
        [AliasAs("note")]
        public string Note { get; set; }
    }
}
