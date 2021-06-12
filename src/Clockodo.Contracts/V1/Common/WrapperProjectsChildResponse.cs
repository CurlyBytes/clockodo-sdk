using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Common
{
    public class WrapperProjectsChildResponse
    {
        [JsonPropertyName("projects")]
        public List<ProjectsChildResponse> Projects
        {
            get; set;
        }
    }
}
