#nullable enable

namespace Vectara
{
    public partial interface IIndexClient
    {
        /// <summary>
        /// Add a document to a corpus<br/>
        /// Add a document to a corpus. This endpoint supports two document formats, structured and core.<br/>
        /// * **Structured** documents have a more conventional structure that provide document sections and parts in a format created by Vectara's proprietary strategy automatically. You provide a logical document structure, and Vectara handles the partitioning. * **Core** documents differ in that they follow an advanced, granular structure that explicitly defines each document part in an array. Each part becomes a distinct, searchable item in query results. You have precise control over the document structure and content.<br/>
        /// For more details, see [Indexing](https://docs.vectara.com/docs/learn/select-ideal-indexing-api).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Document> CreateCorpusDocumentAsync(
            string corpusKey,
            global::Vectara.CreateDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a document to a corpus<br/>
        /// Add a document to a corpus. This endpoint supports two document formats, structured and core.<br/>
        /// * **Structured** documents have a more conventional structure that provide document sections and parts in a format created by Vectara's proprietary strategy automatically. You provide a logical document structure, and Vectara handles the partitioning. * **Core** documents differ in that they follow an advanced, granular structure that explicitly defines each document part in an array. Each part becomes a distinct, searchable item in query results. You have precise control over the document structure and content.<br/>
        /// For more details, see [Indexing](https://docs.vectara.com/docs/learn/select-ideal-indexing-api).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Document> CreateCorpusDocumentAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}