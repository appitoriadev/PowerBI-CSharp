// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI refresh schedule request
    /// </summary>
    public partial class RefreshScheduleRequest
    {
        /// <summary>
        /// Initializes a new instance of the RefreshScheduleRequest class.
        /// </summary>
        public RefreshScheduleRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RefreshScheduleRequest class.
        /// </summary>
        /// <param name="value">An object that contains the details of a
        /// refresh schedule</param>
        public RefreshScheduleRequest(RefreshSchedule value)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an object that contains the details of a refresh
        /// schedule
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public RefreshSchedule Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
