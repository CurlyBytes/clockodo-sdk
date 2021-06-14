using Clockodo.Contracts.V1.Users.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Register.Responses
{
    public class RegisterResponse
    {
        /// <summary>
        /// status return
        /// </summary>
        [JsonPropertyName("success")]
        [AliasAs("success")]
        public bool Success { get; set; }

        /// <summary>
        /// User Object
        /// </summary>
        [JsonPropertyName("user")]
        [AliasAs("user")]
        public UserResponse User { get; set; }

        /// <summary>
        /// APIKey
        /// </summary>
        [JsonPropertyName("apikey")]
        [AliasAs("apikey")]
        public string ApiKey { get; set; }

    }
}
