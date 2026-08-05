#nullable enable

namespace Vectara
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// List corpora<br/>
        /// Lists the corpora in your account. Results are paginated. Each corpus object contains basic information about the corpus. These objects contain less detail than the corpus returned by the Get Corpus API.<br/>
        /// Optional parameters control the pagination and filtering of the results. The limit parameter sets the maximum number of corpora to return. It defaults to 10 and has a maximum value of 100.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="filter"></param>
        /// <param name="corpusId"></param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListCorporaResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? filter = default,
            global::System.Collections.Generic.IList<string>? corpusId = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List corpora<br/>
        /// Lists the corpora in your account. Results are paginated. Each corpus object contains basic information about the corpus. These objects contain less detail than the corpus returned by the Get Corpus API.<br/>
        /// Optional parameters control the pagination and filtering of the results. The limit parameter sets the maximum number of corpora to return. It defaults to 10 and has a maximum value of 100.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="filter"></param>
        /// <param name="corpusId"></param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ListCorporaResponse>> ListAsResponseAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? filter = default,
            global::System.Collections.Generic.IList<string>? corpusId = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}