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
    /// A Power BI service principal profile. Only relevant for [Power BI
    /// Embedded multi-tenancy
    /// solution](/power-bi/developer/embedded/embed-multi-tenancy).
    /// </summary>
    public partial class AdminServicePrincipalProfile : ServicePrincipalProfile
    {
        /// <summary>
        /// Initializes a new instance of the AdminServicePrincipalProfile
        /// class.
        /// </summary>
        public AdminServicePrincipalProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdminServicePrincipalProfile
        /// class.
        /// </summary>
        /// <param name="id">The service principal profile ID</param>
        /// <param name="displayName">The service principal profile
        /// name</param>
        /// <param name="servicePrincipalId">The service principal ID</param>
        public AdminServicePrincipalProfile(System.Guid id, string displayName = default(string), System.Guid? servicePrincipalId = default(System.Guid?))
            : base(id, displayName)
        {
            ServicePrincipalId = servicePrincipalId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the service principal ID
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipalId")]
        public System.Guid? ServicePrincipalId { get; set; }

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
