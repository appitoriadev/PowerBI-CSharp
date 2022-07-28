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
    /// The datamart type
    /// </summary>
    public partial class DatamartType
    {
        /// <summary>
        /// Initializes a new instance of the DatamartType class.
        /// </summary>
        public DatamartType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatamartType class.
        /// </summary>
        /// <param name="type">The datamart type. Possible values include:
        /// 'Unset', 'Ignore', 'Sql', 'Lakehouse', 'Dataverse',
        /// 'Datawarehouse'</param>
        public DatamartType(Type? type = default(Type?))
        {
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the datamart type. Possible values include: 'Unset',
        /// 'Ignore', 'Sql', 'Lakehouse', 'Dataverse', 'Datawarehouse'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public Type? Type { get; set; }

    }
}