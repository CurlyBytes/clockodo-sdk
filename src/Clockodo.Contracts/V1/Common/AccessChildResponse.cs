using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Common
{
    public class AccessChildResponse
    {
        /// <summary>
        /// Can Add in projects?
        /// </summary>
        [JsonPropertyName("add")]
        [AliasAs("add")]
        public bool Add { get; set; }

        /// <summary>
        /// Can Edit in projects?
        /// </summary>
        [JsonPropertyName("edit")]
        [AliasAs("edit")]
        public bool Edit { get; set; }

        /// <summary>
        /// Can AddProject?
        /// </summary>
        [JsonPropertyName("addProject")]
        [AliasAs("addProject")]
        public bool AddProject { get; set; }
    }
}
