using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.HolidaysCarry.Requests
{
    public class PutHolidayCaryRequest
    {

        /// <summary>
        /// Float (only full and half values allowed) Day count
        /// </summary>
        [JsonPropertyName("count")]
        [AliasAs("count")]
        public float? Count { get; set; }


        /// <summary>
        /// Note
        /// </summary>
        [JsonPropertyName("note")]
        [AliasAs("note")]
        public string Note { get; set; }

    }
}
