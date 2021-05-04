// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CapacitiesOperations.
    /// </summary>
    public static partial class CapacitiesOperationsExtensions
    {
            /// <summary>
            /// Returns a list of capacities the user has access to.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Capacities GetCapacities(this ICapacitiesOperations operations)
            {
                return operations.GetCapacitiesAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of capacities the user has access to.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Capacities> GetCapacitiesAsync(this ICapacitiesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCapacitiesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the current state of the specified capacity workloads, if a
            /// workload is enabled also returns the maximum memory percentage that the
            /// workload can consume.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Note:** Workload APIs are not relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.&lt;br/&gt;**Required scope**: Capacity.Read.All or
            /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity Id
            /// </param>
            public static Workloads GetWorkloads(this ICapacitiesOperations operations, System.Guid capacityId)
            {
                return operations.GetWorkloadsAsync(capacityId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the current state of the specified capacity workloads, if a
            /// workload is enabled also returns the maximum memory percentage that the
            /// workload can consume.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Note:** Workload APIs are not relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.&lt;br/&gt;**Required scope**: Capacity.Read.All or
            /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workloads> GetWorkloadsAsync(this ICapacitiesOperations operations, System.Guid capacityId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWorkloadsWithHttpMessagesAsync(capacityId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the current state of a workload and if the workload is enabled also
            /// returns the maximum memory percentage that the workload can consume.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Note:** Workload APIs are not relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.&lt;br/&gt;**Required scope**: Capacity.Read.All or
            /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity Id
            /// </param>
            /// <param name='workloadName'>
            /// The name of the workload
            /// </param>
            public static Workload GetWorkload(this ICapacitiesOperations operations, System.Guid capacityId, string workloadName)
            {
                return operations.GetWorkloadAsync(capacityId, workloadName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the current state of a workload and if the workload is enabled also
            /// returns the maximum memory percentage that the workload can consume.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Note:** Workload APIs are not relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.&lt;br/&gt;**Required scope**: Capacity.Read.All or
            /// Capacity.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity Id
            /// </param>
            /// <param name='workloadName'>
            /// The name of the workload
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workload> GetWorkloadAsync(this ICapacitiesOperations operations, System.Guid capacityId, string workloadName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWorkloadWithHttpMessagesAsync(capacityId, workloadName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Changes the state of a specific workload to Enabled or Disabled. When
            /// enabling a workload the maximum memory percentage that the workload can
            /// consume must be set.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Note:** Workload APIs are not relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.&lt;br/&gt;**Required scope**: Capacity.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity Id
            /// </param>
            /// <param name='workloadName'>
            /// The name of the workload
            /// </param>
            /// <param name='workload'>
            /// Patch workload parameters
            /// </param>
            public static void PatchWorkload(this ICapacitiesOperations operations, System.Guid capacityId, string workloadName, PatchWorkloadRequest workload)
            {
                operations.PatchWorkloadAsync(capacityId, workloadName, workload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Changes the state of a specific workload to Enabled or Disabled. When
            /// enabling a workload the maximum memory percentage that the workload can
            /// consume must be set.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Note:** Workload APIs are not relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.&lt;br/&gt;**Required scope**: Capacity.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity Id
            /// </param>
            /// <param name='workloadName'>
            /// The name of the workload
            /// </param>
            /// <param name='workload'>
            /// Patch workload parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PatchWorkloadAsync(this ICapacitiesOperations operations, System.Guid capacityId, string workloadName, PatchWorkloadRequest workload, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PatchWorkloadWithHttpMessagesAsync(capacityId, workloadName, workload, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a list of refreshables for all capacities of which the user has
            /// access to.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline, receives a comma-separated list of data
            /// types. Supported: capacities and groups
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            public static Refreshables GetRefreshables(this ICapacitiesOperations operations, int top, string expand = default(string), string filter = default(string), int? skip = default(int?))
            {
                return operations.GetRefreshablesAsync(top, expand, filter, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of refreshables for all capacities of which the user has
            /// access to.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline, receives a comma-separated list of data
            /// types. Supported: capacities and groups
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Refreshables> GetRefreshablesAsync(this ICapacitiesOperations operations, int top, string expand = default(string), string filter = default(string), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRefreshablesWithHttpMessagesAsync(top, expand, filter, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of refreshables for the specified capacity the user has
            /// access to
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity id
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline, receives a comma-separated list of data
            /// types. Supported: capacities and groups
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            public static Refreshables GetRefreshablesForCapacity(this ICapacitiesOperations operations, System.Guid capacityId, int top, string expand = default(string), string filter = default(string), int? skip = default(int?))
            {
                return operations.GetRefreshablesForCapacityAsync(capacityId, top, expand, filter, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of refreshables for the specified capacity the user has
            /// access to
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity id
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline, receives a comma-separated list of data
            /// types. Supported: capacities and groups
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Refreshables> GetRefreshablesForCapacityAsync(this ICapacitiesOperations operations, System.Guid capacityId, int top, string expand = default(string), string filter = default(string), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRefreshablesForCapacityWithHttpMessagesAsync(capacityId, top, expand, filter, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified refreshable for the specified capacity the user has
            /// access to
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity id
            /// </param>
            /// <param name='refreshableId'>
            /// The refreshable id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline, receives a comma-separated list of data
            /// types. Supported: capacities and groups
            /// </param>
            public static Refreshables GetRefreshableForCapacity(this ICapacitiesOperations operations, System.Guid capacityId, string refreshableId, string expand = default(string))
            {
                return operations.GetRefreshableForCapacityAsync(capacityId, refreshableId, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified refreshable for the specified capacity the user has
            /// access to
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity id
            /// </param>
            /// <param name='refreshableId'>
            /// The refreshable id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline, receives a comma-separated list of data
            /// types. Supported: capacities and groups
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Refreshables> GetRefreshableForCapacityAsync(this ICapacitiesOperations operations, System.Guid capacityId, string refreshableId, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRefreshableForCapacityWithHttpMessagesAsync(capacityId, refreshableId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Assigns the provided workspaces to the specified capacity.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see [Register
            /// an app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Admin assign workspaces capacity parameters
            /// </param>
            public static void AssignWorkspacesToCapacity(this ICapacitiesOperations operations, AssignWorkspacesToCapacityRequest requestParameters)
            {
                operations.AssignWorkspacesToCapacityAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Assigns the provided workspaces to the specified capacity.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see [Register
            /// an app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Admin assign workspaces capacity parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AssignWorkspacesToCapacityAsync(this ICapacitiesOperations operations, AssignWorkspacesToCapacityRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AssignWorkspacesToCapacityWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Unassigns the provided workspaces from capacity.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see [Register
            /// an app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Admin assign workspaces to shared capacity parameters
            /// </param>
            public static void UnassignWorkspacesFromCapacity(this ICapacitiesOperations operations, UnassignWorkspacesCapacityRequest requestParameters)
            {
                operations.UnassignWorkspacesFromCapacityAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unassigns the provided workspaces from capacity.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see [Register
            /// an app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Admin assign workspaces to shared capacity parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UnassignWorkspacesFromCapacityAsync(this ICapacitiesOperations operations, UnassignWorkspacesCapacityRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UnassignWorkspacesFromCapacityWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a list of users that have access to the specified workspace
            /// (Preview).
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are supported.
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity Id
            /// </param>
            public static Refreshables GetCapacityUsersAsAdmin(this ICapacitiesOperations operations, System.Guid capacityId)
            {
                return operations.GetCapacityUsersAsAdminAsync(capacityId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of users that have access to the specified workspace
            /// (Preview).
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are supported.
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Refreshables> GetCapacityUsersAsAdminAsync(this ICapacitiesOperations operations, System.Guid capacityId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCapacityUsersAsAdminWithHttpMessagesAsync(capacityId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
