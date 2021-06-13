using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clockodo.Contracts.V1.EntryGroup.Requests
{
    public class GetEntryGroupRequest
    {
        /// <summary>
        /// Starting time
        /// e.g. in format “YYYY-MM-DD HH:MM:SS”; see section “Localisation”
        /// </summary>
        [JsonPropertyName("time_since")]
        [AliasAs("time_since")]
        public string TimeSince { get; set; }

        /// <summary>
        /// End time, NULL if entry is running
        /// e.g. in format “YYYY-MM-DD HH:MM:SS”; see section “Localisation
        /// </summary>
        [JsonPropertyName("time_until")]
        [AliasAs("time_until")]
        public string TimeUntil { get; set; }


        /// <summary>
        /// Grouping of the entries; groups will be nested of multiple
        /// grouping option are selected
        /// Selected values of this set: [customers_id, projects_id, services_id, users_id, texts_id, lumpSums_id, billable, is_lumpSum, year, week, month, day
        /// </summary>
        [JsonPropertyName("grouping")]
        [AliasAs("grouping")]
        public string[] Grouping { get; set; }

        /// <summary>
        /// 	Activation of rounding of time durations to the given count of minutes; e.g. "15" for rounding to quarter hours
        /// </summary>
        [JsonPropertyName("round_to_minutes")]
        [AliasAs("round_to_minutes")]
        public int? RoundToMinutes { get; set; } = 0;


        /// <summary>
        /// 	Project names will be prefixed with customer names
        /// </summary>
        [JsonPropertyName("prepend_customer_to_project_name")]
        [AliasAs("prepend_customer_to_project_name")]
        public bool PrependCustomerToProjectName { get; set; } = true;

        /// <summary>
        /// By default, revenues for projects with hard budgets will no be calculated. If you activate this option, the sum of all revenues to this project can be more than the project budget
        /// </summary>
        [JsonPropertyName("calc_also_revenues_for_projects_with_hard_budget")]
        [AliasAs("calc_also_revenues_for_projects_with_hard_budget")]
        public bool CalcAlsoRevenuesForProjectsWithHardBudget { get; set; } = false;
    }
}
