// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// GatewaysOperations operations.
    /// </summary>
    public partial interface IGatewaysOperations
    {
        /// <summary>
        /// Returns a list of gateways for which the user is an admin.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have gateway admin permissions.
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All or Dataset.Read.All
        ///
        /// ## Limitations
        ///
        /// Virtual network (VNet) gateways aren't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Gateways>> GetGatewaysWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified gateway.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have gateway admin permissions.
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All or Dataset.Read.All
        ///
        /// ## Limitations
        ///
        /// Virtual network (VNet) gateways aren't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='gatewayId'>
        /// The gateway ID. When using a gateway cluster, the gateway ID refers
        /// to the primary (first) gateway in the cluster. In such cases,
        /// gateway ID is similar to gateway cluster ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Gateway>> GetGatewayWithHttpMessagesAsync(System.Guid gatewayId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of data sources from the specified gateway.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have gateway admin permissions.
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All or Dataset.Read.All
        ///
        /// ## Limitations
        ///
        /// Virtual network (VNet) gateways aren't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='gatewayId'>
        /// The gateway ID. When using a gateway cluster, the gateway ID refers
        /// to the primary (first) gateway in the cluster. In such cases,
        /// gateway ID is similar to gateway cluster ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<GatewayDatasources>> GetDatasourcesWithHttpMessagesAsync(System.Guid gatewayId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new data source on the specified on-premises gateway.
        /// </summary>
        /// <remarks>
        ///
        /// &lt;br&gt;On premises data source credentials must be encrypted.
        /// The `encryptedConnection` parameter must be set to `Encrypted` and
        /// the credentials should be encrypted using the gateway public key.
        ///
        /// See the
        /// [CreateGatewayDataSource](https://github.com/microsoft/PowerBI-Developer-Samples/blob/master/PowerShell%20Scripts/CreateGatewayDataSource)
        /// PowerShell script for an example of using this API.
        ///
        /// &gt; [!NOTE]
        /// &gt; To encrypt credentials, see [Configure credentials
        /// programmatically](/power-bi/developer/embedded/configure-credentials)
        /// for Power BI and review the EncryptCredentials [.NET
        /// Core](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/.NET%20Core/EncryptCredentials),
        /// [Java](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/Java/EncryptCredentials)
        /// and
        /// [Python](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/Python/Encrypt%20credentials)
        /// examples.
        ///
        /// ## Permissions
        ///
        /// Supports only on-premises gateways and the user must have gateway
        /// admin permissions
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// - Virtual network (VNet) and Cloud gateways aren't supported.
        /// - OAuth2 as a credential type isn't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='gatewayId'>
        /// The gateway ID. When using a gateway cluster, the gateway ID refers
        /// to the primary (first) gateway in the cluster. In such cases,
        /// gateway ID is similar to gateway cluster ID.
        /// </param>
        /// <param name='datasourceToGatewayRequest'>
        /// A request to create a new data source on a gateway
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<GatewayDatasource>> CreateDatasourceWithHttpMessagesAsync(System.Guid gatewayId, PublishDatasourceToGatewayRequest datasourceToGatewayRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified data source from the specified gateway.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have gateway admin permissions.
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All or Dataset.Read.All
        ///
        /// ## Limitations
        ///
        /// Virtual network (VNet) gateways aren't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='gatewayId'>
        /// The gateway ID. When using a gateway cluster, the gateway ID refers
        /// to the primary (first) gateway in the cluster. In such cases,
        /// gateway ID is similar to gateway cluster ID.
        /// </param>
        /// <param name='datasourceId'>
        /// The data source ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<GatewayDatasource>> GetDatasourceWithHttpMessagesAsync(System.Guid gatewayId, System.Guid datasourceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified data source from the specified gateway.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have gateway admin permissions.
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Virtual network (VNet) gateways aren't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='gatewayId'>
        /// The gateway ID. When using a gateway cluster, the gateway ID refers
        /// to the primary (first) gateway in the cluster. In such cases,
        /// gateway ID is similar to gateway cluster ID.
        /// </param>
        /// <param name='datasourceId'>
        /// The data source ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DeleteDatasourceWithHttpMessagesAsync(System.Guid gatewayId, System.Guid datasourceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the credentials of the specified data source from the
        /// specified gateway.
        /// </summary>
        /// <remarks>
        ///
        /// On Premises data source credentials must be encrypted, as described
        /// in the [On-premise encrypted credentials
        /// example](/rest/api/power-bi/gateways/update-datasource#on-premise-encrypted-credentials-example).
        ///
        /// &gt; [!NOTE]
        /// &gt; - To encrypt credentials, see [Configure credentials
        /// programmatically](/power-bi/developer/embedded/configure-credentials)
        /// for Power BI and review the EncryptCredentials [.NET
        /// Core](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/.NET%20Core/EncryptCredentials),
        /// [Java](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/Java/EncryptCredentials)
        /// and
        /// [Python](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/Python/Encrypt%20credentials)
        /// examples.
        /// &gt; - Windows credentials before encryption look like the
        /// credentials in the credentials of [Basic credentials
        /// example](/rest/api/power-bi/gateways/update-datasource#basic-credentials-example).
        ///
        /// When changing from single sign-on to other credential types, such
        /// as `Basic` or `OAuth2`, set the parameter
        /// `useEndUserOAuth2Credentials` to `false` as described in the [Basic
        /// credentials
        /// example](/rest/api/power-bi/gateways/update-datasource#basic-credentials-example).
        ///
        /// OAuth 2.0 credentials are valid as long as the provided token is
        /// valid. When using the OAuth 2.0 credential type, do the following:
        /// - Set the OAuth 2.0 token audience correctly, according to the data
        /// source type.
        /// - Send the OAuth 2.0 token in the payload as shown in the [OAuth
        /// 2.0 credentials
        /// example](/rest/api/power-bi/gateways/update-datasource#oauth-2.0-credentials-example).
        /// - If you're using **Extension** data sources, don't set
        /// `useCallerAADIdentity` to `true`.
        ///
        /// ## Permissions
        ///
        /// - With on-premises gateways, the user must have gateway admin
        /// permissions.
        /// - With cloud data sources, user must be the data source owner. Use
        /// [Datasets - Take Over
        /// API](/rest/api/power-bi/datasets/take-over-in-group) to transfer
        /// ownership over the specified dataset or [Paginated reports - Take
        /// Over API](/rest/api/power-bi/reports/take-over-in-group) to
        /// transfer ownership of the data sources over the specified paginated
        /// report.
        /// - This API call can be called by a service principal profile. For
        /// more information see: [Service principal profiles in Power BI
        /// Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Virtual network (VNet) gateways aren't supported.
        /// SAS Token credentials are supported only with AzureBlobStorage and
        /// AzureDataLakeStorage.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='gatewayId'>
        /// The gateway ID. When using a gateway cluster, the gateway ID refers
        /// to the primary (first) gateway in the cluster. In such cases,
        /// gateway ID is similar to gateway cluster ID.
        /// </param>
        /// <param name='datasourceId'>
        /// The data source ID
        /// </param>
        /// <param name='updateDatasourceRequest'>
        /// The update data source request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateDatasourceWithHttpMessagesAsync(System.Guid gatewayId, System.Guid datasourceId, UpdateDatasourceRequest updateDatasourceRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks the connectivity status of the specified data source from
        /// the specified gateway.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have gateway admin permissions.
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Virtual network (VNet) gateways aren't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='gatewayId'>
        /// The gateway ID. When using a gateway cluster, the gateway ID refers
        /// to the primary (first) gateway in the cluster. In such cases,
        /// gateway ID is similar to gateway cluster ID.
        /// </param>
        /// <param name='datasourceId'>
        /// The data source ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> GetDatasourceStatusWithHttpMessagesAsync(System.Guid gatewayId, System.Guid datasourceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of users who have access to the specified data
        /// source.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have gateway admin permissions.
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All or Dataset.Read.All
        ///
        /// ## Limitations
        ///
        /// Virtual network (VNet) gateways aren't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='gatewayId'>
        /// The gateway ID. When using a gateway cluster, the gateway ID refers
        /// to the primary (first) gateway in the cluster. In such cases,
        /// gateway ID is similar to gateway cluster ID.
        /// </param>
        /// <param name='datasourceId'>
        /// The data source ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DatasourceUsers>> GetDatasourceUsersWithHttpMessagesAsync(System.Guid gatewayId, System.Guid datasourceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Grants or updates the permissions required to use the specified
        /// data source for the specified user.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have gateway admin permissions.
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Virtual network (VNet) gateways aren't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='gatewayId'>
        /// The gateway ID. When using a gateway cluster, the gateway ID refers
        /// to the primary (first) gateway in the cluster. In such cases,
        /// gateway ID is similar to gateway cluster ID.
        /// </param>
        /// <param name='datasourceId'>
        /// The data source ID
        /// </param>
        /// <param name='addUserToDatasourceRequest'>
        /// The add user to data source request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AddDatasourceUserWithHttpMessagesAsync(System.Guid gatewayId, System.Guid datasourceId, DatasourceUser addUserToDatasourceRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes the specified user from the specified data source.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have gateway admin permissions.
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Virtual network (VNet) gateways aren't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='gatewayId'>
        /// The gateway ID. When using a gateway cluster, the gateway ID refers
        /// to the primary (first) gateway in the cluster. In such cases,
        /// gateway ID is similar to gateway cluster ID.
        /// </param>
        /// <param name='datasourceId'>
        /// The data source ID
        /// </param>
        /// <param name='emailAdress'>
        /// The user's email address or the object ID of the service principal
        /// </param>
        /// <param name='profileId'>
        /// The service principal profile ID to delete
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteDatasourceUserWithHttpMessagesAsync(System.Guid gatewayId, System.Guid datasourceId, string emailAdress, System.Guid? profileId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
