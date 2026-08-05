#nullable enable

namespace Vectara
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Retrieve metadata about a corpus<br/>
        /// Returns metadata about a corpus without performing a search. This operation does not search the corpus contents. Specify the `corpus_key` to identify the corpus whose metadata you want to retrieve.<br/>
        /// This endpoint helps administrators review access control details and monitor the size of a corpus, such as the amount of quota consumed. You can also use this information to optimize search and storage use.<br/>
        /// For example, you can track the read and write activity of a corpus and adjust your security strategy proactively. If a corpus has an API key with read/write access that only serves high volume reads, you may decide to switch to a read-only key.<br/>
        /// You can also respond to a security incident by disabling a corpus based on information returned by this endpoint.<br/>
        /// ## Get the number of documents or document parts in a corpus<br/>
        /// Document usage metrics help administrators manage resource allocation, keep data usage within allocated quotas, and identify trends in document growth and document segmentation.<br/>
        /// The `limits` object in the response describes the current usage and limits of a corpus. This includes the number of stored documents, document parts, and the character count.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Corpus> GetAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve metadata about a corpus<br/>
        /// Returns metadata about a corpus without performing a search. This operation does not search the corpus contents. Specify the `corpus_key` to identify the corpus whose metadata you want to retrieve.<br/>
        /// This endpoint helps administrators review access control details and monitor the size of a corpus, such as the amount of quota consumed. You can also use this information to optimize search and storage use.<br/>
        /// For example, you can track the read and write activity of a corpus and adjust your security strategy proactively. If a corpus has an API key with read/write access that only serves high volume reads, you may decide to switch to a read-only key.<br/>
        /// You can also respond to a security incident by disabling a corpus based on information returned by this endpoint.<br/>
        /// ## Get the number of documents or document parts in a corpus<br/>
        /// Document usage metrics help administrators manage resource allocation, keep data usage within allocated quotas, and identify trends in document growth and document segmentation.<br/>
        /// The `limits` object in the response describes the current usage and limits of a corpus. This includes the number of stored documents, document parts, and the character count.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.Corpus>> GetAsResponseAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}