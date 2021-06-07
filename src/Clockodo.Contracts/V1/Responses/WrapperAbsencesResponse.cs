using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Clockodo.Contracts.V1.Responses
{
    public class WrapperAbsencesResponse
    {
     
        [JsonPropertyName("absences")]
        public List<AbsenceResponse> Absences { get; set; }
    }
}
