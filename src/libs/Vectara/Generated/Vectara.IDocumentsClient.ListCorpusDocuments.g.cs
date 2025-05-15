#nullable enable

namespace Vectara
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// List the documents in the corpus<br/>
        /// Retrieve a list of documents stored in a specific corpus. This endpoint provides an overview of document metadata without returning the full content of each document.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="metadataFilter"></param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListDocumentsResponse> ListCorpusDocumentsAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? metadataFilter = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}