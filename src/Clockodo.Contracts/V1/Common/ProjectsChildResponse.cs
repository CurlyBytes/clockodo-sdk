﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.Common
{
    public class ProjectsChildResponse
    {
        /// <summary>
        /// ID of the entry
        /// </summary>
        [JsonPropertyName("id")]
        [AliasAs("id")]
        public int Id { get; set; }

        /// <summary>
        /// Project Name
        /// </summary>
        [JsonPropertyName("name")]
        [AliasAs("name")]
        public string Name { get; set; }


        [JsonPropertyName("access")]
        public AccessChildResponse Access { get; set; }

    }
}
