using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.OvertimeCarry.Response
{
    public class WrapperOvertimeCarryRowResponse
    {
        /// <summary>
        /// The related employee's ID
        /// </summary>
        [JsonPropertyName("overtimecarryRow")]
        [AliasAs("overtimecarryRow")]

        public OvertimeCarryResponse OvertimeCarryResponse { get; set; }
    }
}
