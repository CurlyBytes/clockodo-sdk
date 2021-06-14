﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.TargetHours.Response
{
    public class WrapperTargetHoursRowResponse
    {

        [JsonPropertyName("targethours")]
        [AliasAs("targethours")]
        public List<TargetHoursRowResponse> TargetHours { get; set; }
     
    }
}
