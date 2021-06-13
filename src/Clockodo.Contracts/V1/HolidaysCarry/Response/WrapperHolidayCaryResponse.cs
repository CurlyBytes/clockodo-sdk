﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.HolidaysCarry.Response
{
    public class WrapperHolidayCaryResponse
    {
        [JsonPropertyName("holidayscarry")]
        [AliasAs("holidayscarry")]
        public List<HolidayCarryResponse> HolidaysCarry
        {
            get; set;
        }
    }
}
