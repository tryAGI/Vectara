#nullable enable

namespace Vectara
{
    public partial interface IGlossariesClient
    {
        /// <summary>
        /// List glossary entries<br/>
        /// List the entries in a glossary.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="glossaryKey">
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.GlossaryEntriesResponse> ListEntriesAsync(
            string glossaryKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}