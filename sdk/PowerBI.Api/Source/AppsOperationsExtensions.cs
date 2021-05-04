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
    /// Extension methods for AppsOperations.
    /// </summary>
    public static partial class AppsOperationsExtensions
    {
            /// <summary>
            /// Returns a list of installed apps.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: App.Read.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Apps GetApps(this IAppsOperations operations)
            {
                return operations.GetAppsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of installed apps.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: App.Read.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Apps> GetAppsAsync(this IAppsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAppsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified installed app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: App.Read.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            public static App GetApp(this IAppsOperations operations, System.Guid appId)
            {
                return operations.GetAppAsync(appId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified installed app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: App.Read.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<App> GetAppAsync(this IAppsOperations operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAppWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of reports from the specified app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or Report.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            public static Reports GetReports(this IAppsOperations operations, System.Guid appId)
            {
                return operations.GetReportsAsync(appId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of reports from the specified app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or Report.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Reports> GetReportsAsync(this IAppsOperations operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReportsWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified report from the specified app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or Report.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='reportId'>
            /// The report id
            /// </param>
            public static Report GetReport(this IAppsOperations operations, System.Guid appId, System.Guid reportId)
            {
                return operations.GetReportAsync(appId, reportId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified report from the specified app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Report.ReadWrite.All or Report.Read.All
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='reportId'>
            /// The report id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Report> GetReportAsync(this IAppsOperations operations, System.Guid appId, System.Guid reportId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReportWithHttpMessagesAsync(appId, reportId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of dashboards from the specified app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
            /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see [Register
            /// an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            public static Dashboards GetDashboards(this IAppsOperations operations, System.Guid appId)
            {
                return operations.GetDashboardsAsync(appId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of dashboards from the specified app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
            /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see [Register
            /// an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Dashboards> GetDashboardsAsync(this IAppsOperations operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDashboardsWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified dashboard from the specified app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
            /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see [Register
            /// an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard id
            /// </param>
            public static Dashboard GetDashboard(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId)
            {
                return operations.GetDashboardAsync(appId, dashboardId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified dashboard from the specified app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
            /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see [Register
            /// an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Dashboard> GetDashboardAsync(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDashboardWithHttpMessagesAsync(appId, dashboardId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of tiles within the specified dashboard from the specified
            /// app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
            /// Dashboard.Read.All&lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard id
            /// </param>
            public static Tiles GetTiles(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId)
            {
                return operations.GetTilesAsync(appId, dashboardId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of tiles within the specified dashboard from the specified
            /// app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
            /// Dashboard.Read.All&lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Tiles> GetTilesAsync(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTilesWithHttpMessagesAsync(appId, dashboardId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified tile within the specified dashboard from the
            /// specified app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Note**: All tile types are supported except for "model tiles",
            /// which include datasets and live tiles that contain an entire report page.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
            /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see [Register
            /// an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard id
            /// </param>
            /// <param name='tileId'>
            /// The tile id
            /// </param>
            public static Tile GetTile(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId, System.Guid tileId)
            {
                return operations.GetTileAsync(appId, dashboardId, tileId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified tile within the specified dashboard from the
            /// specified app.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Note**: All tile types are supported except for "model tiles",
            /// which include datasets and live tiles that contain an entire report page.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Dashboard.ReadWrite.All or
            /// Dashboard.Read.All &lt;br/&gt;To set the permissions scope, see [Register
            /// an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;&lt;br/&gt;**Limitations:**
            /// Service principal authentication is not supported.&lt;br/&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard id
            /// </param>
            /// <param name='tileId'>
            /// The tile id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Tile> GetTileAsync(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId, System.Guid tileId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTileWithHttpMessagesAsync(appId, dashboardId, tileId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of apps in the orginization (Preview).
            /// </summary>
            /// <remarks>
            /// This API allows 200 requests per hour at maximum.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are supported.
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            public static Apps GetAppsAsAdmin(this IAppsOperations operations, System.Guid appId)
            {
                return operations.GetAppsAsAdminAsync(appId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of apps in the orginization (Preview).
            /// </summary>
            /// <remarks>
            /// This API allows 200 requests per hour at maximum.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are supported.
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Apps> GetAppsAsAdminAsync(this IAppsOperations operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAppsAsAdminWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of users that have access to the specified app (Preview).
            /// </summary>
            /// <remarks>
            /// This API allows 200 requests per hour at maximum.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are supported.
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            public static AppUsers GetAppUsersAsAdmin(this IAppsOperations operations, System.Guid appId)
            {
                return operations.GetAppUsersAsAdminAsync(appId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of users that have access to the specified app (Preview).
            /// </summary>
            /// <remarks>
            /// This API allows 200 requests per hour at maximum.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All. &lt;br/&gt;Delegated permissions are supported.
            /// &lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppUsers> GetAppUsersAsAdminAsync(this IAppsOperations operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAppUsersAsAdminWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
