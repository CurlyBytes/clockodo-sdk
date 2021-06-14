using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Projects.Response
{
    public class WrapperProjectResponse
    {
        /// <summary>
        /// The related employee's ID
        /// </summary>
        [JsonPropertyName("projects")]
        [AliasAs("projects")]

        public List<ProjectResponse> ProjectResponse { get; set; }


    }
}
