using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Customer.Requests
{
    public class PostCustomersRequest
    {
        /// <summary>
        /// Name of the customer
        /// </summary>
        [JsonPropertyName("name")]
        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Customer number
        /// </summary>
        [JsonPropertyName("number")]
        [AliasAs("number")]
        public int? number { get; set; }


        /// <summary>
        /// Is the customer active?
        /// </summary>
        [JsonPropertyName("active")]
        [AliasAs("active")]
        public bool Active { get; set; }


        /// <summary>
        /// 	Is the customer billable by default? (1 or 0)
        /// </summary>
        [JsonPropertyName("billable_default")]
        [AliasAs("billable_default")]
        public bool BillableDefault { get; set; }

        /// <summary>
        /// ID of the Customer
        /// </summary>
        [JsonPropertyName("note")]
        [AliasAs("note")]
        public string Note { get; set; }
    }
}
