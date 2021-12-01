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

    public partial class WorkspaceInfoDataflowProperties
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoDataflowProperties
        /// class.
        /// </summary>
        public WorkspaceInfoDataflowProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoDataflowProperties
        /// class.
        /// </summary>
        /// <param name="datasourceUsages">The datasource usages</param>
        /// <param name="upstreamDataflows">Upstream Dataflows</param>
        public WorkspaceInfoDataflowProperties(IList<DatasourceUsage> datasourceUsages = default(IList<DatasourceUsage>), IList<DependentDataflow> upstreamDataflows = default(IList<DependentDataflow>))
        {
            DatasourceUsages = datasourceUsages;
            UpstreamDataflows = upstreamDataflows;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the datasource usages
        /// </summary>
        [JsonProperty(PropertyName = "datasourceUsages")]
        public IList<DatasourceUsage> DatasourceUsages { get; set; }

        /// <summary>
        /// Gets or sets upstream Dataflows
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDataflows")]
        public IList<DependentDataflow> UpstreamDataflows { get; set; }

    }
}