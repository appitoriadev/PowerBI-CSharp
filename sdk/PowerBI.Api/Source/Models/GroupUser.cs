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
    /// A Power BI user with access to the workspace
    /// </summary>
    public partial class GroupUser : User
    {
        /// <summary>
        /// Initializes a new instance of the GroupUser class.
        /// </summary>
        public GroupUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupUser class.
        /// </summary>
        /// <param name="identifier">Identifier of the principal</param>
        /// <param name="principalType">Possible values include: 'None',
        /// 'User', 'Group', 'App'</param>
        /// <param name="groupUserAccessRight">The access right (permission
        /// level) that a user has on the workspace. Possible values include:
        /// 'None', 'Member', 'Admin', 'Contributor', 'Viewer'</param>
        /// <param name="emailAddress">Email address of the user</param>
        /// <param name="displayName">Display name of the principal</param>
        /// <param name="graphId">Identifier of the principal in Microsoft
        /// Graph. Only available for admin APIs.</param>
        /// <param name="userType">Type of the user.</param>
        public GroupUser(string identifier, PrincipalType principalType, GroupUserAccessRight groupUserAccessRight, string emailAddress = default(string), string displayName = default(string), string graphId = default(string), string userType = default(string), ServicePrincipalProfile profile = default(ServicePrincipalProfile))
            : base(identifier, principalType, emailAddress, displayName, graphId, userType, profile)
        {
            GroupUserAccessRight = groupUserAccessRight;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the access right (permission level) that a user has on
        /// the workspace. Possible values include: 'None', 'Member', 'Admin',
        /// 'Contributor', 'Viewer'
        /// </summary>
        [JsonProperty(PropertyName = "groupUserAccessRight")]
        public GroupUserAccessRight GroupUserAccessRight { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
