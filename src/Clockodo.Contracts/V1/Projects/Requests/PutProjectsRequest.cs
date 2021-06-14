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
    public class PutProjectsRequest
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
        public bool? Active { get; set; }


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
        /// Is the project completed?
        /// </summary>
        [JsonPropertyName("completed")]
        [AliasAs("completed")]
        public bool? Completed { get; set; }

        /// <summary>
        /// Billed amount of money
        /// </summary>
        [JsonPropertyName("billed_money")]
        [AliasAs("billed_money")]
        public float? BilledMoney { get; set; }

        /// <summary>
        /// Hourly Rate
        /// </summary>
        [JsonPropertyName("hourly_rate")]
        [AliasAs("hourly_rate")]
        public float? HourlyRate { get; set; }

        /// <summary>
        /// Is the project billed completely?
        /// </summary>
        [JsonPropertyName("billed_completely")]
        [AliasAs("billed_completely")]
        public bool? BilledCompletely { get; set; }

        /// <summary>
        /// Factor with which revenues and hourly rates have to multiplicated in order to get the effective values
        /// </summary>
        [JsonPropertyName("revenue_factor")]
        [AliasAs("revenue_factor")]
        public float? RevenueFactor { get; set; }
    }
}