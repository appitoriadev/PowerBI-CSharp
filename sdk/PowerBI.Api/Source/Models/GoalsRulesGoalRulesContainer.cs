// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A container for JSON definitions of status rules on a Power BI goal
    /// </summary>
    public partial class GoalsRulesGoalRulesContainer
    {
        /// <summary>
        /// Initializes a new instance of the GoalsRulesGoalRulesContainer
        /// class.
        /// </summary>
        public GoalsRulesGoalRulesContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GoalsRulesGoalRulesContainer
        /// class.
        /// </summary>
        /// <param name="scorecardObjectId">The scorecard ID</param>
        /// <param name="goalObjectId">The goal ID</param>
        /// <param name="lastModifiedTime">The UTC time at last
        /// modification</param>
        /// <param name="rules">The list of rules</param>
        public GoalsRulesGoalRulesContainer(System.Guid? scorecardObjectId = default(System.Guid?), System.Guid? goalObjectId = default(System.Guid?), System.DateTime? lastModifiedTime = default(System.DateTime?), string rules = default(string))
        {
            ScorecardObjectId = scorecardObjectId;
            GoalObjectId = goalObjectId;
            LastModifiedTime = lastModifiedTime;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the scorecard ID
        /// </summary>
        [JsonProperty(PropertyName = "scorecardObjectId")]
        public System.Guid? ScorecardObjectId { get; set; }

        /// <summary>
        /// Gets or sets the goal ID
        /// </summary>
        [JsonProperty(PropertyName = "goalObjectId")]
        public System.Guid? GoalObjectId { get; set; }

        /// <summary>
        /// Gets or sets the UTC time at last modification
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the list of rules
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public string Rules { get; set; }

    }
}