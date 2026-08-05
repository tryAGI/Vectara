#nullable enable

namespace Vectara
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Summarize a document<br/>
        /// Generates a concise summary of a single document. The summary captures essential insights without requiring you to review the entire document manually. This API is a tech preview.<br/>
        /// * Enable streaming for large documents to receive summaries incrementally.<br/>
        /// * Customize `prompt_template` to fine-tune summary output for specific domains.<br/>
        /// * Use standard responses for small documents where streaming is unnecessary.<br/>
        /// * Monitor streaming events to track the progress of real-time summarization.<br/>
        /// :::note<br/>
        /// The document length is limited by the context window of your selected LLM.<br/>
        /// :::<br/>
        /// ## Response formats<br/>
        /// The platform supports two response modes:<br/>
        /// * **Standard**: Returns a complete summary in one response.<br/>
        /// * **Streaming**: Returns incremental responses using Server-Sent Events (SSE).<br/>
        /// ### Non-streaming response<br/>
        /// In standard mode, the platform returns a structured response that contains the complete summary of the document. The summary field contains the generated text.<br/>
        /// ### Streaming response<br/>
        /// For streaming responses, the platform returns Server-Sent Events (SSE). The first event begins streaming partial results as soon as they are available. The final event marks the end of the summarization process.<br/>
        /// The streamed response consists of multiple events:<br/>
        /// * `generation_info`: Contains the `rendered_prompt` which is the compiled prompt sent to the LLM for document summarization.<br/>
        /// * `generation_chunk`: Returns a partial chunk of the generated summary.<br/>
        /// * `generation_end`: Marks the completion of the summary generation.<br/>
        /// * `error`: Returns an error message if summarization fails.<br/>
        /// * `end`: Indicates the end of the streaming session.<br/>
        /// ## Prompt template example<br/>
        /// When you craft a prompt, you can access your document with the `$vectaraDocument` field. This example shows a simple prompt:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "role": "user",<br/>
        ///   "content": "Summarize the document: \$vectaraDocument.json()"<br/>
        /// }<br/>
        /// ```<br/>
        /// The document also has the following methods to support custom prompts. <br/>
        /// * `$vectaraDocument.json()`: Returns a JSON representation of the whole document.<br/>
        /// * `$vectaraDocument.id()`: Returns the unique identifier of the document (`document_id`).<br/>
        /// * `$vectaraDocument.metadata()`: Returns metadata from the document.  <br/>
        ///   For example, <br/>
        ///   `$vectaraDocument.metadata().get("key")` retrieves a specific metadata value by key.<br/>
        /// * `$vectaraDocument.parts()`: Returns an array of document parts that you can loop through.  <br/>
        ///   For example, `#foreach ($part in $vectaraDocument.parts())`.  <br/>
        /// * `$part.text()`: Returns the text of the part.<br/>
        /// * `$part.metadata()`: Returns the metadata of a part.<br/>
        /// * `$part.hasTable()`: Indicates whether the part contains a table.<br/>
        /// * `$part.table()`: Returns the table within the part. For example, use `$part.table().json()` to retrieve the table in JSON format.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.SummarizeDocumentResponse> SummarizeAsync(
            string corpusKey,
            string documentId,

            global::Vectara.SummarizeDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Summarize a document<br/>
        /// Generates a concise summary of a single document. The summary captures essential insights without requiring you to review the entire document manually. This API is a tech preview.<br/>
        /// * Enable streaming for large documents to receive summaries incrementally.<br/>
        /// * Customize `prompt_template` to fine-tune summary output for specific domains.<br/>
        /// * Use standard responses for small documents where streaming is unnecessary.<br/>
        /// * Monitor streaming events to track the progress of real-time summarization.<br/>
        /// :::note<br/>
        /// The document length is limited by the context window of your selected LLM.<br/>
        /// :::<br/>
        /// ## Response formats<br/>
        /// The platform supports two response modes:<br/>
        /// * **Standard**: Returns a complete summary in one response.<br/>
        /// * **Streaming**: Returns incremental responses using Server-Sent Events (SSE).<br/>
        /// ### Non-streaming response<br/>
        /// In standard mode, the platform returns a structured response that contains the complete summary of the document. The summary field contains the generated text.<br/>
        /// ### Streaming response<br/>
        /// For streaming responses, the platform returns Server-Sent Events (SSE). The first event begins streaming partial results as soon as they are available. The final event marks the end of the summarization process.<br/>
        /// The streamed response consists of multiple events:<br/>
        /// * `generation_info`: Contains the `rendered_prompt` which is the compiled prompt sent to the LLM for document summarization.<br/>
        /// * `generation_chunk`: Returns a partial chunk of the generated summary.<br/>
        /// * `generation_end`: Marks the completion of the summary generation.<br/>
        /// * `error`: Returns an error message if summarization fails.<br/>
        /// * `end`: Indicates the end of the streaming session.<br/>
        /// ## Prompt template example<br/>
        /// When you craft a prompt, you can access your document with the `$vectaraDocument` field. This example shows a simple prompt:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "role": "user",<br/>
        ///   "content": "Summarize the document: \$vectaraDocument.json()"<br/>
        /// }<br/>
        /// ```<br/>
        /// The document also has the following methods to support custom prompts. <br/>
        /// * `$vectaraDocument.json()`: Returns a JSON representation of the whole document.<br/>
        /// * `$vectaraDocument.id()`: Returns the unique identifier of the document (`document_id`).<br/>
        /// * `$vectaraDocument.metadata()`: Returns metadata from the document.  <br/>
        ///   For example, <br/>
        ///   `$vectaraDocument.metadata().get("key")` retrieves a specific metadata value by key.<br/>
        /// * `$vectaraDocument.parts()`: Returns an array of document parts that you can loop through.  <br/>
        ///   For example, `#foreach ($part in $vectaraDocument.parts())`.  <br/>
        /// * `$part.text()`: Returns the text of the part.<br/>
        /// * `$part.metadata()`: Returns the metadata of a part.<br/>
        /// * `$part.hasTable()`: Indicates whether the part contains a table.<br/>
        /// * `$part.table()`: Returns the table within the part. For example, use `$part.table().json()` to retrieve the table in JSON format.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.SummarizeDocumentResponse>> SummarizeAsResponseAsync(
            string corpusKey,
            string documentId,

            global::Vectara.SummarizeDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Summarize a document<br/>
        /// Generates a concise summary of a single document. The summary captures essential insights without requiring you to review the entire document manually. This API is a tech preview.<br/>
        /// * Enable streaming for large documents to receive summaries incrementally.<br/>
        /// * Customize `prompt_template` to fine-tune summary output for specific domains.<br/>
        /// * Use standard responses for small documents where streaming is unnecessary.<br/>
        /// * Monitor streaming events to track the progress of real-time summarization.<br/>
        /// :::note<br/>
        /// The document length is limited by the context window of your selected LLM.<br/>
        /// :::<br/>
        /// ## Response formats<br/>
        /// The platform supports two response modes:<br/>
        /// * **Standard**: Returns a complete summary in one response.<br/>
        /// * **Streaming**: Returns incremental responses using Server-Sent Events (SSE).<br/>
        /// ### Non-streaming response<br/>
        /// In standard mode, the platform returns a structured response that contains the complete summary of the document. The summary field contains the generated text.<br/>
        /// ### Streaming response<br/>
        /// For streaming responses, the platform returns Server-Sent Events (SSE). The first event begins streaming partial results as soon as they are available. The final event marks the end of the summarization process.<br/>
        /// The streamed response consists of multiple events:<br/>
        /// * `generation_info`: Contains the `rendered_prompt` which is the compiled prompt sent to the LLM for document summarization.<br/>
        /// * `generation_chunk`: Returns a partial chunk of the generated summary.<br/>
        /// * `generation_end`: Marks the completion of the summary generation.<br/>
        /// * `error`: Returns an error message if summarization fails.<br/>
        /// * `end`: Indicates the end of the streaming session.<br/>
        /// ## Prompt template example<br/>
        /// When you craft a prompt, you can access your document with the `$vectaraDocument` field. This example shows a simple prompt:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "role": "user",<br/>
        ///   "content": "Summarize the document: \$vectaraDocument.json()"<br/>
        /// }<br/>
        /// ```<br/>
        /// The document also has the following methods to support custom prompts. <br/>
        /// * `$vectaraDocument.json()`: Returns a JSON representation of the whole document.<br/>
        /// * `$vectaraDocument.id()`: Returns the unique identifier of the document (`document_id`).<br/>
        /// * `$vectaraDocument.metadata()`: Returns metadata from the document.  <br/>
        ///   For example, <br/>
        ///   `$vectaraDocument.metadata().get("key")` retrieves a specific metadata value by key.<br/>
        /// * `$vectaraDocument.parts()`: Returns an array of document parts that you can loop through.  <br/>
        ///   For example, `#foreach ($part in $vectaraDocument.parts())`.  <br/>
        /// * `$part.text()`: Returns the text of the part.<br/>
        /// * `$part.metadata()`: Returns the metadata of a part.<br/>
        /// * `$part.hasTable()`: Indicates whether the part contains a table.<br/>
        /// * `$part.table()`: Returns the table within the part. For example, use `$part.table().json()` to retrieve the table in JSON format.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="llmName">
        /// The name of the LLM.<br/>
        /// Example: mockingbird-2.0
        /// </param>
        /// <param name="promptTemplate">
        /// The prompt template to use when generating the summary. By default, the platform manages the system and user roles and prompts for the generative LLM. Set this field to override the default prompts. The `prompt_template` is an Apache Velocity template. For details on how to configure the `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).<br/>
        /// Example: Provide a concise summary of the document.
        /// </param>
        /// <param name="modelParameters">
        /// Optional parameters for the specified model used when generating the summary.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.SummarizeDocumentResponse> SummarizeAsync(
            string corpusKey,
            string documentId,
            string llmName,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? promptTemplate = default,
            object? modelParameters = default,
            bool? streamResponse = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}