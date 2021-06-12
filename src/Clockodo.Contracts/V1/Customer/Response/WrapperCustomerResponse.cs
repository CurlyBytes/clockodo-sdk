using Clockodo.Contracts.V1.Customer.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Clockodo.Contracts.V1.Absence.Responses
{
    public class WrapperCustomerResponse
    {
     
        [JsonPropertyName("customer")]
        public CustomersResponse Customer { get; set; }
    }
}
