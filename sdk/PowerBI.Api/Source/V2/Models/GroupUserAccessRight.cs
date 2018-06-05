// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Power BI user access right entry for group
    /// </summary>
    public partial class GroupUserAccessRight
    {
        /// <summary>
        /// Initializes a new instance of the GroupUserAccessRight class.
        /// </summary>
        public GroupUserAccessRight()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupUserAccessRight class.
        /// </summary>
        /// <param name="groupUserAccessRightProperty">Access rights user has
        /// for the group. Possible values include: 'None', 'Member', 'Admin',
        /// 'Contributor'</param>
        /// <param name="emailAddress">Email address of the user</param>
        public GroupUserAccessRight(string groupUserAccessRightProperty = default(string), string emailAddress = default(string))
        {
            GroupUserAccessRightProperty = groupUserAccessRightProperty;
            EmailAddress = emailAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets access rights user has for the group. Possible values
        /// include: 'None', 'Member', 'Admin', 'Contributor'
        /// </summary>
        [JsonProperty(PropertyName = "groupUserAccessRight")]
        public string GroupUserAccessRightProperty { get; set; }

        /// <summary>
        /// Gets or sets email address of the user
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

    }
}
