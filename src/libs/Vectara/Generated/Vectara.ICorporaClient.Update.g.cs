#nullable enable

namespace Vectara
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Update a corpus<br/>
        /// Enables, disables, or updates the name and description of a corpus. Use this endpoint to manage the availability of data, such as taking a corpus offline without deleting it.<br/>
        /// You can also use automated scripts to control the availability of corpora based on certain conditions. For example, quickly disable a corpus for maintenance updates or in response to security incidents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Corpus> UpdateAsync(
            string corpusKey,

            global::Vectara.UpdateCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a corpus<br/>
        /// Enables, disables, or updates the name and description of a corpus. Use this endpoint to manage the availability of data, such as taking a corpus offline without deleting it.<br/>
        /// You can also use automated scripts to control the availability of corpora based on certain conditions. For example, quickly disable a corpus for maintenance updates or in response to security incidents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.Corpus>> UpdateAsResponseAsync(
            string corpusKey,

            global::Vectara.UpdateCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a corpus<br/>
        /// Enables, disables, or updates the name and description of a corpus. Use this endpoint to manage the availability of data, such as taking a corpus offline without deleting it.<br/>
        /// You can also use automated scripts to control the availability of corpora based on certain conditions. For example, quickly disable a corpus for maintenance updates or in response to security incidents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="enabled">
        /// Whether the corpus is enabled. If unset, the corpus remains in its current state.<br/>
        /// Example: false
        /// </param>
        /// <param name="name">
        /// The name for the corpus. If unset or null, the name remains unchanged.<br/>
        /// Example: new-corpus-name
        /// </param>
        /// <param name="description">
        /// Description of the corpus. If unset or null, the description remains unchanged.<br/>
        /// Example: New description of the corpus.
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save corpus queries to query history by default.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Corpus> UpdateAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? enabled = default,
            string? name = default,
            string? description = default,
            bool? saveHistory = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}