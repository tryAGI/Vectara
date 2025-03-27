#nullable enable

namespace Vectara
{
    public partial interface IApplicationClientsClient
    {
        /// <summary>
        /// Update an App Client<br/>
        /// Update the configuration or settings of an existing application client.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="appClientId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AppClient> UpdateAppClientAsync(
            string appClientId,
            global::Vectara.UpdateAppClientRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an App Client<br/>
        /// Update the configuration or settings of an existing application client.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="appClientId"></param>
        /// <param name="description">
        /// The new App Client description.
        /// </param>
        /// <param name="apiRoles">
        /// The new roles attached to the App Client. These roles will replace the current roles.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AppClient> UpdateAppClientAsync(
            string appClientId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Vectara.ApiRole>? apiRoles = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}