using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using Refit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Clockodo.Contracts.V1.Projects.Requests
{
    public class PostProjectsRequest
    {
        /// <summary>
        /// ID of the corresponding customer
        /// </summary>
        [JsonPropertyName("customers_id")]
        [AliasAs("customers_id")]
        public int? CustomersId { get; set; }

        /// <summary>
        /// Name of the project
        /// </summary>
        [JsonPropertyName("name")]
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// Project number
        /// </summary>
        [JsonPropertyName("number")]
        [AliasAs("number")]
        public string Number { get; set; }

        /// <summary>
        /// Is the project active?
        /// </summary>
        [JsonPropertyName("active")]
        [AliasAs("active")]
        public bool Active { get; set; }


        /// <summary>
        /// Note for the project
        /// </summary>
        [JsonPropertyName("note")]
        [AliasAs("note")]
        public String note { get; set; }

        /// <summary>
        /// Budget for the project
        /// </summary>
        [JsonPropertyName("budget_money")]
        [AliasAs("budget_money")]
        public float? BudgetMoney { get; set; }

        /// <summary>
        /// Is the budget not strict?
        /// </summary>
        [JsonPropertyName("budget_is_not_strict")]
        [AliasAs("budget_is_not_strict")]
        public bool? BudgetIsNotStrict { get; set; }

        /// <summary>
        /// ID of the corresponding customer
        /// </summary>
        [JsonPropertyName("budget_is_hours")]
        [AliasAs("budget_is_hours")]
        public int? BudgetisHours { get; set; }
    }
}