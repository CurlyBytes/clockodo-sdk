using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Clockodo.Contracts.V1.Absence.Responses
{
    public class WrapperAbsenceResponse
    {
     
        [JsonPropertyName("absence")]
        public AbsenceResponse Absence { get; set; }
    }
}
