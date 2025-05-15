#nullable enable

namespace Vectara
{
    public partial interface IIndexClient
    {
        /// <summary>
        /// Update document, merging the metadata.<br/>
        /// Updates document identified by its unique `document_id` from a specific corpus. The request body metadata is merged with the existing metadata, adding or modifying only the specified fields.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Document> UpdateCorpusDocumentAsync(
            string corpusKey,
            string documentId,
            global::Vectara.UpdateDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update document, merging the metadata.<br/>
        /// Updates document identified by its unique `document_id` from a specific corpus. The request body metadata is merged with the existing metadata, adding or modifying only the specified fields.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="metadata">
        /// The metadata for a document as an arbitrary object. Properties of this object can be used by document level filter attributes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Document> UpdateCorpusDocumentAsync(
            string corpusKey,
            string documentId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}