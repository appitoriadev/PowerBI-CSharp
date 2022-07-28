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
    /// Power BI datamart common properties. The API returns a subset of the
    /// following list of datamart properties. The subset depends on the API
    /// called, caller permissions, and the availability of data in the Power
    /// BI database.
    /// </summary>
    public partial class DatamartBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the DatamartBaseProperties class.
        /// </summary>
        public DatamartBaseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatamartBaseProperties class.
        /// </summary>
        /// <param name="id">The datamart ID</param>
        /// <param name="name">The datamart name</param>
        /// <param name="description">The datamart description</param>
        /// <param name="suspendedBatchId">datamart suspended batch id</param>
        public DatamartBaseProperties(System.Guid id, string name = default(string), string description = default(string), DatamartType type = default(DatamartType), DatamartStatus1 status = default(DatamartStatus1), DatamartState state = default(DatamartState), string suspendedBatchId = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Status = status;
            State = state;
            SuspendedBatchId = suspendedBatchId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the datamart ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the datamart name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the datamart description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public DatamartType Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public DatamartStatus1 Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public DatamartState State { get; set; }

        /// <summary>
        /// Gets or sets datamart suspended batch id
        /// </summary>
        [JsonProperty(PropertyName = "suspendedBatchId")]
        public string SuspendedBatchId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}