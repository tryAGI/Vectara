#nullable enable

namespace Vectara
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update a user<br/>
        /// Update details about a user such as role names.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.User> UpdateUserAsync(
            string username,
            global::Vectara.UpdateUserRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a user<br/>
        /// Update details about a user such as role names.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="username"></param>
        /// <param name="enabled">
        /// Indicates whether to enable or disable the user.
        /// </param>
        /// <param name="apiRoles">
        /// The new customer-level role names of the user.
        /// </param>
        /// <param name="corpusRoles">
        /// New corpus-specific role assignments for the user.
        /// </param>
        /// <param name="agentRoles">
        /// New agent-specific role assignments for the user.
        /// </param>
        /// <param name="description">
        /// The description of the user.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.User> UpdateUserAsync(
            string username,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? enabled = default,
            global::System.Collections.Generic.IList<global::Vectara.ApiRole>? apiRoles = default,
            global::System.Collections.Generic.IList<global::Vectara.CorpusRole>? corpusRoles = default,
            global::System.Collections.Generic.IList<global::Vectara.AgentRole>? agentRoles = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}