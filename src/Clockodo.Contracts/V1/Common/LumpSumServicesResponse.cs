using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Common
{
    public class LumpSumServicesResponse
    {   /// <summary>
        /// 	ID of the lump sum service
        /// </summary>
        [JsonPropertyName("id")]
        [AliasAs("id")]
        public int Id { get; set; }


        /// <summary>
        /// Name of the lump sum service
        /// </summary>
        [JsonPropertyName("name")]
        [AliasAs("name")]
        public int LumpServiceName { get; set; }

        /// <summary>
        /// Price of the lump sum service
        /// </summary>
        [JsonPropertyName("price")]
        [AliasAs("price")]
        public float? price { get; set; }


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
        public int Number { get; set; }


        /// <summary>
        /// Is the lump sum service active?
        /// </summary>
        [JsonPropertyName("active")]
        [AliasAs("active")]
        public bool Active { get; set; }


        /// <summary>
        /// ID of the absence
        /// </summary>
        [JsonPropertyName("note")]
        [AliasAs("note")]
        public int Note { get; set; }
    }
}
