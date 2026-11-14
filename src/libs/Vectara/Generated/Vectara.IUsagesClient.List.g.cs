#nullable enable

namespace Vectara
{
    public partial interface IUsagesClient
    {
        /// <summary>
        /// List usages<br/>
        /// Lists how much the account uses of everything the platform measures or counts for it, each with its use of the allowance on it when one applies.<br/>
        /// Storage is measured once an hour; its `measured_at` is the start of the hour reported, and bytes added or deleted since then appear after a later measurement. Storage is absent until the account has been measured, and while it has not been measured in the last two days. Each corpus and agent reports its own bytes from the same measurement in its `storage` field.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListUsagesResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List usages<br/>
        /// Lists how much the account uses of everything the platform measures or counts for it, each with its use of the allowance on it when one applies.<br/>
        /// Storage is measured once an hour; its `measured_at` is the start of the hour reported, and bytes added or deleted since then appear after a later measurement. Storage is absent until the account has been measured, and while it has not been measured in the last two days. Each corpus and agent reports its own bytes from the same measurement in its `storage` field.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ListUsagesResponse>> ListAsResponseAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}