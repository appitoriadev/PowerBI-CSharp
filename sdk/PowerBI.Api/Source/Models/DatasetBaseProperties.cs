// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Power BI dataset. The API returns a subset of the following list of
    /// dataset properties. The subset depends on the API called, caller
    /// permissions, and the availability of the data in the Power BI database.
    /// </summary>
    public partial class DatasetBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the DatasetBaseProperties class.
        /// </summary>
        public DatasetBaseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetBaseProperties class.
        /// </summary>
        /// <param name="id">The dataset ID</param>
        /// <param name="name">The dataset name</param>
        /// <param name="configuredBy">The dataset owner</param>
        /// <param name="createdDate">The dataset creation date and
        /// time</param>
        /// <param name="contentProviderType">The content provider type for the
        /// dataset</param>
        /// <param name="description">The dataset description</param>
        /// <param name="upstreamDataflows">The list of all the dataflows this
        /// item depends on</param>
        public DatasetBaseProperties(string id, string name = default(string), string configuredBy = default(string), System.DateTime? createdDate = default(System.DateTime?), string contentProviderType = default(string), string description = default(string), IList<DependentDataflow> upstreamDataflows = default(IList<DependentDataflow>))
        {
            Id = id;
            Name = name;
            ConfiguredBy = configuredBy;
            CreatedDate = createdDate;
            ContentProviderType = contentProviderType;
            Description = description;
            UpstreamDataflows = upstreamDataflows;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dataset ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the dataset name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the dataset owner
        /// </summary>
        [JsonProperty(PropertyName = "configuredBy")]
        public string ConfiguredBy { get; set; }

        /// <summary>
        /// Gets or sets the dataset creation date and time
        /// </summary>
        [JsonProperty(PropertyName = "CreatedDate")]
        public System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the content provider type for the dataset
        /// </summary>
        [JsonProperty(PropertyName = "ContentProviderType")]
        public string ContentProviderType { get; set; }

        /// <summary>
        /// Gets or sets the dataset description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the list of all the dataflows this item depends on
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDataflows")]
        public IList<DependentDataflow> UpstreamDataflows { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
