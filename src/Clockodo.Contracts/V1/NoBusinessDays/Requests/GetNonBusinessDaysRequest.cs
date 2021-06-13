using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.NoBusinessDays.Requests
{
    public class GetNonBusinessDaysRequest
    {
        /// <summary>
        /// ID of the NonBusinessDays
        /// </summary>
        [JsonPropertyName("nonbusinessgroups_id")]
        [AliasAs("nonbusinessgroups_id")]
        public int NonBusinessGroupsid { get; set; }

        /// <summary>
        /// Year of the NonBusiness Days
        /// </summary>
        [JsonPropertyName("year")]
        [AliasAs("year")]
        public int Year { get; set; }
    }
}
