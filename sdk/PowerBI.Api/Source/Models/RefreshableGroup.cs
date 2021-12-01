// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using System.Linq;

    /// <summary>
    /// A Power BI group associated to a Refreshable item
    /// </summary>
    public partial class RefreshableGroup : GroupBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the RefreshableGroup class.
        /// </summary>
        public RefreshableGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RefreshableGroup class.
        /// </summary>
        /// <param name="id">The workspace ID</param>
        /// <param name="name">The group name</param>
        public RefreshableGroup(System.Guid id, string name = default(string))
            : base(id, name)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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