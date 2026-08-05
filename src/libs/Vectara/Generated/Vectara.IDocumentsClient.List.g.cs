#nullable enable

namespace Vectara
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// List the documents in the corpus<br/>
        /// Lists the documents stored in a corpus. The response includes an overview of document metadata, including document IDs, tables (if table extraction is enabled), and pagination details.<br/>
        /// Use this endpoint to review the documents indexed so far and to decide which documents to remove. It helps you manage the document lifecycle in your environment.<br/>
        /// You can catalog and inventory large amounts of data, and retrieve lists of documents for further analysis. For example, developers can use the metadata to build custom search and filtering capabilities into their applications.<br/>
        /// Currently, the Document Admin APIs do not allow you to access the text of your documents.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListDocumentsResponse> ListAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? metadataFilter = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the documents in the corpus<br/>
        /// Lists the documents stored in a corpus. The response includes an overview of document metadata, including document IDs, tables (if table extraction is enabled), and pagination details.<br/>
        /// Use this endpoint to review the documents indexed so far and to decide which documents to remove. It helps you manage the document lifecycle in your environment.<br/>
        /// You can catalog and inventory large amounts of data, and retrieve lists of documents for further analysis. For example, developers can use the metadata to build custom search and filtering capabilities into their applications.<br/>
        /// Currently, the Document Admin APIs do not allow you to access the text of your documents.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ListDocumentsResponse>> ListAsResponseAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? metadataFilter = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}