using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.OvertimeCarry.Response
{
    public class OvertimeCarryResponse
    {
        /// <summary>
        /// The related employee's ID
        /// </summary>
        [JsonPropertyName("users_id")]
        [AliasAs("users_id")]
        public int UsersId { get; set; }

        /// <summary>
        /// Year for which the overtime carryover applies
        /// Format YYYY
        /// </summary>
        [JsonPropertyName("year")]
        [AliasAs("year")]
        public int? Year { get; set; }


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
