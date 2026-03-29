#nullable enable

namespace Vectara
{
    public partial interface IAppClientsClient
    {
        /// <summary>
        /// Create an App Client<br/>
        /// An App Client is used for OAuth 2.0 authentication when calling Vectara APIs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AppClient> CreateAsync(

            global::Vectara.CreateAppClientRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}