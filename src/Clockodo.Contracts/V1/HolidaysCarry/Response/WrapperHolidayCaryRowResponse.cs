using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.HolidaysCarry.Response
{
    public class WrapperHolidayCaryRowResponse
    {
        [JsonPropertyName("holidayscarryRow")]
        [AliasAs("holidayscarryRow")]
        public HolidayCarryResponse HolidaysCarryRow
        {
            get; set;
        }
    }
}
