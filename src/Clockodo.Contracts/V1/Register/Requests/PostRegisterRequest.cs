using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Register.Requests
{
    public class PostRegisterRequest
    {
        /// <summary>
        /// Name of the company
        /// </summary>
        [JsonPropertyName("companies_name")]
        [AliasAs("companies_name")]
        public string CompaniesName { get; set; }


        /// <summary>
        /// Name of the owner
        /// </summary>
        [JsonPropertyName("name")]
        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// E-mail address of the owner
        /// </summary>
        [JsonPropertyName("email")]
        [AliasAs("email")]
        public string Email { get; set; }


        /// <summary>
        /// Name of the external application from which the registration is made
        /// </summary>
        [JsonPropertyName("rfs")]
        [AliasAs("rfs")]
        public string RFS { get; set; }


        /// <summary>
        /// Preselected billing application
        /// </summary>
        [JsonPropertyName("bs")]
        [AliasAs("bs")]
        public string BS { get; set; }


        /// <summary>
        /// Terms of clockodo were accepted
        /// </summary>
        [JsonPropertyName("gtc_agreed")]
        [AliasAs("gtc_agreed")]
        public bool GTCAgreed { get; set; }
    }
}
