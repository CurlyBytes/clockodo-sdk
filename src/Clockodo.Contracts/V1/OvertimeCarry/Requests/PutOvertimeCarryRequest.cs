using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.OvertimeCarry.Requests
{
    public class PutOvertimeCarryRequest
    {
       

        /// <summary>
        /// Number of hours
        /// </summary>
        [JsonPropertyName("hours")]
        [AliasAs("hours")]
        public float? Hours { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        [JsonPropertyName("note")]
        [AliasAs("note")]
        public string Note { get; set; }
    }
}
