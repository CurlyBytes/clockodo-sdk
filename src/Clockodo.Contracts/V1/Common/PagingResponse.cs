using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Common
{
    public class PagingResponse
    {
        /// <summary>
        /// IDID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("items_per_page")]
        [AliasAs("items_per_page")]
        public int ItemsPerPage { get; set; }

        /// <summary>
        /// IDID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("current_page")]
        [AliasAs("current_page")]
        public int CurrentPage { get; set; }

        /// <summary>
        /// IDID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("count_pages")]
        [AliasAs("count_pages")]
        public int CountPages { get; set; }

        /// <summary>
        /// IDID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("count_items")]
        [AliasAs("count_items")]
        public int CountItems { get; set; }
    }
}
