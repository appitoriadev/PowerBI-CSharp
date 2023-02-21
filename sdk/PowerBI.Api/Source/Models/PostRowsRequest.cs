// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PostRowsRequest
    {
        /// <summary>
        /// Initializes a new instance of the PostRowsRequest class.
        /// </summary>
        public PostRowsRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PostRowsRequest class.
        /// </summary>
        /// <param name="rows">An array of data rows pushed to a dataset table.
        /// Each element is a collection of properties represented using
        /// key-value format.</param>
        public PostRowsRequest(IList<object> rows = default(IList<object>))
        {
            Rows = rows;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of data rows pushed to a dataset table. Each
        /// element is a collection of properties represented using key-value
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "rows")]
        public IList<object> Rows { get; set; }

    }
}
