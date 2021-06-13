using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.EntryGroup.Response
{
    public class EntryGroupResponse
    {

        /// <summary>
        /// Group criterion of the current group
        /// </summary>
        [JsonPropertyName("groupedBy")]
        [AliasAs("groupedBy")]
        public string GroupedBy { get; set; }


        /// <summary>
        /// Identificator of the current group
        /// </summary>
        [JsonPropertyName("group")]
        [AliasAs("group")]
        public string Group { get; set; }



        /// <summary>
        /// Data number of the group (customers number, personnel number, ..)
        /// </summary>
        [JsonPropertyName("name")]
        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Note of the current group
        /// </summary>
        [JsonPropertyName("note")]
        [AliasAs("note")]
        public string Note { get; set; }


        /// <summary>
        /// ID of the absence
        /// </summary>
        [JsonPropertyName("restrictions")]
        [AliasAs("restrictions")]
        public string[] Restrictions { get; set; }


   


        /// <summary>
        /// ID of the absence
        /// </summary>
        [JsonPropertyName("duration")]
        [AliasAs("duration")]
        public int? Duration { get; set; }
    }
}
