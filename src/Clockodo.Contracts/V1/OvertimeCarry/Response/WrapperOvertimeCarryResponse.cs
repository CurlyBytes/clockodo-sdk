using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.OvertimeCarry.Response
{
    public class WrapperOvertimeCarryResponse
    {
        /// <summary>
        /// The related employee's ID
        /// </summary>
        [JsonPropertyName("overtimecarry")]
        [AliasAs("overtimecarry")]

        public List<OvertimeCarryResponse> OvertimeCarryResponse { get; set; }
    }
}
