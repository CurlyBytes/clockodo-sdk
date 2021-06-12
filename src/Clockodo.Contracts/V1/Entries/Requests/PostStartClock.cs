using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Entries.Requests
{
    public class PostStartClock
    {

        /// <summary>
        /// ID of the corresponding customer
        /// </summary>
        [JsonPropertyName("customers_id")]
        [AliasAs("customers_id")]
        public int CustomersId { get; set; }

        /// <summary>
        /// ID of the corresponding service
        /// </summary>
        [JsonPropertyName("services_id")]
        [AliasAs("services_id")]
        public int ServicesId { get; set; }


        /// <summary>
        /// Is the entry billable? (1 or 0)
        /// </summary>
        [JsonPropertyName("billable")]
        [AliasAs("billable")]
        public int Billable { get; set; }

        /// <summary>
        /// ID of the entry
        /// </summary>
        [JsonPropertyName("id")]
        [AliasAs("id")]
        public int? Id { get; set; }


        /// <summary>
        /// ID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UsersId { get; set; }


        /// <summary>
        /// description text
        /// </summary>
        [JsonPropertyName("text")]
        [AliasAs("text")]
        public string Text { get; set; }


    }
}
