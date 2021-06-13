using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.NoBusinessDays.Response
{
    public class NonBusinessDaysResponse
    {
        /// <summary>
        /// The date of the nonbusiness day
        /// </summary>
        [JsonPropertyName("date")]
        [AliasAs("date")]
        public string Date { get; set; }


        /// <summary>
        /// The name of the nonbusiness day
        /// </summary>
        [JsonPropertyName("name")]
        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// ID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int? UsersId { get; set; }

        /// <summary>
        /// ID of the corresponding co-worker
        /// </summary>
        [JsonPropertyName("half_day")]
        [AliasAs("half_day")]
        public bool HalfDay { get; set; }

    }

}
