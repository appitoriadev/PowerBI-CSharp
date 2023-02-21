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
    /// A Power BI dataset returned by WorkspaceInfo APIs. The API returns a
    /// subset of the following list of dataset properties. The subset depends
    /// on the API called, caller permissions, and the availability of the data
    /// in the Power BI database.
    /// </summary>
    public partial class WorkspaceInfoDataset
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoDataset class.
        /// </summary>
        public WorkspaceInfoDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoDataset class.
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
        /// <param name="tables">The dataset tables</param>
        /// <param name="schemaRetrievalError">The dataset schema retrieval
        /// error</param>
        /// <param name="schemaMayNotBeUpToDate">Whether the dataset schema
        /// might not be up to date</param>
        /// <param name="expressions">The dataset expressions</param>
        /// <param name="endorsementDetails">The endorsement details</param>
        /// <param name="sensitivityLabel">The sensitivity label</param>
        /// <param name="targetStorageMode">The dataset storage mode</param>
        /// <param name="datasourceUsages">The data source usages</param>
        /// <param name="misconfiguredDatasourceUsages">The data source
        /// misconfigured usages</param>
        /// <param name="upstreamDatamarts">The list of all the datamarts this
        /// item depends on</param>
        /// <param name="upstreamDatasets">The upstream datasets</param>
        /// <param name="users">(Empty value) The dataset user access details.
        /// This property will be removed from the payload response in an
        /// upcoming release. You can retrieve user information on a Power BI
        /// item (such as a report or a dashboard) by using the [Get Dataset
        /// Users as
        /// Admin](/rest/api/power-bi/admin/datasets-get-dataset-users-as-admin)
        /// API, or the
        /// [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API with the `getArtifactUsers` parameter.</param>
        public WorkspaceInfoDataset(string id, string name = default(string), string configuredBy = default(string), System.DateTime? createdDate = default(System.DateTime?), string contentProviderType = default(string), string description = default(string), IList<DependentDataflow> upstreamDataflows = default(IList<DependentDataflow>), IList<Table> tables = default(IList<Table>), string schemaRetrievalError = default(string), bool? schemaMayNotBeUpToDate = default(bool?), IList<Expression> expressions = default(IList<Expression>), EndorsementDetails endorsementDetails = default(EndorsementDetails), SensitivityLabel sensitivityLabel = default(SensitivityLabel), string targetStorageMode = default(string), IList<DatasourceUsage> datasourceUsages = default(IList<DatasourceUsage>), IList<DatasourceUsage> misconfiguredDatasourceUsages = default(IList<DatasourceUsage>), IList<DependentDatamart> upstreamDatamarts = default(IList<DependentDatamart>), IList<DependentDataset> upstreamDatasets = default(IList<DependentDataset>), IList<DatasetUser> users = default(IList<DatasetUser>))
        {
            Id = id;
            Name = name;
            ConfiguredBy = configuredBy;
            CreatedDate = createdDate;
            ContentProviderType = contentProviderType;
            Description = description;
            UpstreamDataflows = upstreamDataflows;
            Tables = tables;
            SchemaRetrievalError = schemaRetrievalError;
            SchemaMayNotBeUpToDate = schemaMayNotBeUpToDate;
            Expressions = expressions;
            EndorsementDetails = endorsementDetails;
            SensitivityLabel = sensitivityLabel;
            TargetStorageMode = targetStorageMode;
            DatasourceUsages = datasourceUsages;
            MisconfiguredDatasourceUsages = misconfiguredDatasourceUsages;
            UpstreamDatamarts = upstreamDatamarts;
            UpstreamDatasets = upstreamDatasets;
            Users = users;
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
        /// Gets or sets the dataset tables
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<Table> Tables { get; set; }

        /// <summary>
        /// Gets or sets the dataset schema retrieval error
        /// </summary>
        [JsonProperty(PropertyName = "schemaRetrievalError")]
        public string SchemaRetrievalError { get; set; }

        /// <summary>
        /// Gets or sets whether the dataset schema might not be up to date
        /// </summary>
        [JsonProperty(PropertyName = "schemaMayNotBeUpToDate")]
        public bool? SchemaMayNotBeUpToDate { get; set; }

        /// <summary>
        /// Gets or sets the dataset expressions
        /// </summary>
        [JsonProperty(PropertyName = "expressions")]
        public IList<Expression> Expressions { get; set; }

        /// <summary>
        /// Gets or sets the endorsement details
        /// </summary>
        [JsonProperty(PropertyName = "endorsementDetails")]
        public EndorsementDetails EndorsementDetails { get; set; }

        /// <summary>
        /// Gets or sets the sensitivity label
        /// </summary>
        [JsonProperty(PropertyName = "sensitivityLabel")]
        public SensitivityLabel SensitivityLabel { get; set; }

        /// <summary>
        /// Gets or sets the dataset storage mode
        /// </summary>
        [JsonProperty(PropertyName = "targetStorageMode")]
        public string TargetStorageMode { get; set; }

        /// <summary>
        /// Gets or sets the data source usages
        /// </summary>
        [JsonProperty(PropertyName = "datasourceUsages")]
        public IList<DatasourceUsage> DatasourceUsages { get; set; }

        /// <summary>
        /// Gets or sets the data source misconfigured usages
        /// </summary>
        [JsonProperty(PropertyName = "misconfiguredDatasourceUsages")]
        public IList<DatasourceUsage> MisconfiguredDatasourceUsages { get; set; }

        /// <summary>
        /// Gets or sets the list of all the datamarts this item depends on
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDatamarts")]
        public IList<DependentDatamart> UpstreamDatamarts { get; set; }

        /// <summary>
        /// Gets or sets the upstream datasets
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDatasets")]
        public IList<DependentDataset> UpstreamDatasets { get; set; }

        /// <summary>
        /// Gets or sets (Empty value) The dataset user access details. This
        /// property will be removed from the payload response in an upcoming
        /// release. You can retrieve user information on a Power BI item (such
        /// as a report or a dashboard) by using the [Get Dataset Users as
        /// Admin](/rest/api/power-bi/admin/datasets-get-dataset-users-as-admin)
        /// API, or the
        /// [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API with the `getArtifactUsers` parameter.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<DatasetUser> Users { get; set; }

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
            if (Tables != null)
            {
                foreach (var element in Tables)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Expressions != null)
            {
                foreach (var element1 in Expressions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (SensitivityLabel != null)
            {
                SensitivityLabel.Validate();
            }
            if (DatasourceUsages != null)
            {
                foreach (var element2 in DatasourceUsages)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (MisconfiguredDatasourceUsages != null)
            {
                foreach (var element3 in MisconfiguredDatasourceUsages)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (Users != null)
            {
                foreach (var element4 in Users)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
        }
    }
}
