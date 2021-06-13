using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.HolidaysQuota.Responses
{
    public class WrapperHolidaysQuotaRowResponse
    {
        [JsonPropertyName("holidaysquotaRow")]
        [AliasAs("holidaysquotaRow")]
        public HolidaysQuotaResponse HolidaysQuotaRow { get; set; }
    }
}
