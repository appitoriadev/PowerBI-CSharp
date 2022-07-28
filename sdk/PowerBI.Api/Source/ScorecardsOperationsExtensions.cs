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
    /// Extension methods for ScorecardsOperations.
    /// </summary>
    public static partial class ScorecardsOperationsExtensions
    {
            /// <summary>
            /// Returns a list of scorecards from a workspace.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            public static Scorecards Get(this IScorecardsOperations operations, int? top = default(int?))
            {
                return operations.GetAsync(top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of scorecards from a workspace.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Scorecards> GetAsync(this IScorecardsOperations operations, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new scorecard.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scorecard'>
            /// The new scorecard properties.
            /// </param>
            public static Scorecard Post(this IScorecardsOperations operations, ScorecardCreateRequest scorecard)
            {
                return operations.PostAsync(scorecard).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new scorecard.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scorecard'>
            /// The new scorecard properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Scorecard> PostAsync(this IScorecardsOperations operations, ScorecardCreateRequest scorecard, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(scorecard, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a scorecard with ID.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `goals`, `goalValues`, `aggregations`, and
            /// `notes`.
            /// </param>
            public static Scorecard GetByID(this IScorecardsOperations operations, string expand = default(string))
            {
                return operations.GetByIDAsync(expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a scorecard with ID.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `goals`, `goalValues`, `aggregations`, and
            /// `notes`.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Scorecard> GetByIDAsync(this IScorecardsOperations operations, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIDWithHttpMessagesAsync(expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a scorecard by its ID
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scorecard'>
            /// The scorecard properties to patch
            /// </param>
            public static Scorecard PatchByID(this IScorecardsOperations operations, Scorecard scorecard)
            {
                return operations.PatchByIDAsync(scorecard).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a scorecard by its ID
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scorecard'>
            /// The scorecard properties to patch
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Scorecard> PatchByIDAsync(this IScorecardsOperations operations, Scorecard scorecard, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchByIDWithHttpMessagesAsync(scorecard, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a scorecard by its ID.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void DeleteByID(this IScorecardsOperations operations)
            {
                operations.DeleteByIDAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a scorecard by its ID.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIDAsync(this IScorecardsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIDWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Reads a scorecard associated with an internal report ID.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reportId'>
            /// The ID of the internal report associated with the scorecard
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `goals`, `goalValues`, and `aggregations`.
            /// </param>
            public static Scorecard GetScorecardByReportId(this IScorecardsOperations operations, System.Guid reportId, string expand = default(string))
            {
                return operations.GetScorecardByReportIdAsync(reportId, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reads a scorecard associated with an internal report ID.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.Read.All or Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reportId'>
            /// The ID of the internal report associated with the scorecard
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `goals`, `goalValues`, and `aggregations`.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Scorecard> GetScorecardByReportIdAsync(this IScorecardsOperations operations, System.Guid reportId, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetScorecardByReportIdWithHttpMessagesAsync(reportId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Moves goals within the scorecard. Changes their ranks and parents.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='moveGoalsRequest'>
            /// The request describing the move operation.
            /// </param>
            public static void MoveGoals(this IScorecardsOperations operations, GoalsMoveRequest moveGoalsRequest)
            {
                operations.MoveGoalsAsync(moveGoalsRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Moves goals within the scorecard. Changes their ranks and parents.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Dataset.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='moveGoalsRequest'>
            /// The request describing the move operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task MoveGoalsAsync(this IScorecardsOperations operations, GoalsMoveRequest moveGoalsRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.MoveGoalsWithHttpMessagesAsync(moveGoalsRequest, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}