#nullable enable

namespace Vectara
{
    public partial interface IUploadClient
    {
        /// <summary>
        /// Upload a file to the corpus<br/>
        /// Upload a file, such as a PDF or Word document, to the specified corpus for automatic text extraction and metadata parsing.  <br/>
        /// This endpoint expects a `multipart/form-data` request with the following fields:  <br/>
        /// - **metadata**: An optional JSON object containing additional metadata to associate with the document.  <br/>
        ///   Example: `metadata={"key": "value"}`<br/>
        /// - **chunking_strategy**: An optional JSON object that sets the chunking method for text extraction.  <br/>
        ///   - By default, the platform uses sentence-based chunking (one chunk per sentence).<br/>
        ///   - Example for explicit sentence chunking: `chunking_strategy={"type":"sentence_chunking_strategy"}`<br/>
        ///   - Example for max chars chunking: `chunking_strategy={"type":"max_chars_chunking_strategy","max_chars_per_chunk":512}`<br/>
        /// - **table_extraction_config**: An optional JSON object to control table extraction from supported file types (e.g., PDF).  <br/>
        ///   Example: `table_extraction_config={"extract_tables": true}`<br/>
        /// - **file**: The file to upload. Attach your file as the value for this field.<br/>
        /// - **filename**: The desired name for the uploaded file. Specify as part of the file field in your request.
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
        global::System.Threading.Tasks.Task<global::Vectara.Document> UploadFileAsync(
            string corpusKey,
            global::Vectara.UploadFileRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file to the corpus<br/>
        /// Upload a file, such as a PDF or Word document, to the specified corpus for automatic text extraction and metadata parsing.  <br/>
        /// This endpoint expects a `multipart/form-data` request with the following fields:  <br/>
        /// - **metadata**: An optional JSON object containing additional metadata to associate with the document.  <br/>
        ///   Example: `metadata={"key": "value"}`<br/>
        /// - **chunking_strategy**: An optional JSON object that sets the chunking method for text extraction.  <br/>
        ///   - By default, the platform uses sentence-based chunking (one chunk per sentence).<br/>
        ///   - Example for explicit sentence chunking: `chunking_strategy={"type":"sentence_chunking_strategy"}`<br/>
        ///   - Example for max chars chunking: `chunking_strategy={"type":"max_chars_chunking_strategy","max_chars_per_chunk":512}`<br/>
        /// - **table_extraction_config**: An optional JSON object to control table extraction from supported file types (e.g., PDF).  <br/>
        ///   Example: `table_extraction_config={"extract_tables": true}`<br/>
        /// - **file**: The file to upload. Attach your file as the value for this field.<br/>
        /// - **filename**: The desired name for the uploaded file. Specify as part of the file field in your request.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="metadata">
        /// Arbitrary object that will be attached as document metadata to the extracted document.
        /// </param>
        /// <param name="chunkingStrategy">
        /// Choose how to split documents into chunks during indexing. This is optional - if you do not set a chunking strategy, the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </param>
        /// <param name="tableExtractionConfig">
        /// Configuration for table extraction from the document. This is optional and if not provided, the platform does not extract tables from PDF files.
        /// </param>
        /// <param name="filename">
        /// Optional multipart section to override the filename.<br/>
        /// Example: system_design_v1.pdf
        /// </param>
        /// <param name="file">
        /// Binary file contents. The file name of the file will be used as the document ID.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Document> UploadFileAsync(
            string corpusKey,
            byte[] file,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            object? metadata = default,
            global::Vectara.ChunkingStrategy? chunkingStrategy = default,
            global::Vectara.TableExtractionConfig? tableExtractionConfig = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}