
#nullable enable

namespace Vectara
{
    public partial class UploadClient
    {
        partial void PrepareUploadFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string corpusKey,
            global::Vectara.UploadFileRequest request);
        partial void PrepareUploadFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            string corpusKey,
            global::Vectara.UploadFileRequest request);
        partial void ProcessUploadFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload a file to the corpus<br/>
        /// Upload files such as PDFs and Word Documents for automatic text extraction and metadata parsing.<br/>
        /// The request expects a `multipart/form-data` format containing the following parts:<br/>
        /// * `metadata` - (Optional) Specifies a JSON object representing any additional metadata to be associated with the extracted document. For example, `'metadata={"key": "value"};type=application/json'`<br/>
        /// * `chunking_strategy` - (Optional) Specifies the chunking strategy for the platform to use. If you do not set this option, the platform uses the default strategy, which creates one chunk per sentence. For example, `'chunking_strategy={"type":"max_chars_chunking_strategy","max_chars_per_chunk":200};type=application/json'`<br/>
        /// * `file` - Specifies the file that you want to upload.<br/>
        /// * `filename` - Specified as part of the file field with the file name that you want to associate with the uploaded file. For a curl example, use the following syntax: `'file=@/path/to/file/file.pdf;filename=desired_filename.pdf'`<br/>
        /// For more detailed information, see this [File Upload API guide.](https://docs.vectara.com/docs/api-reference/indexing-apis/file-upload/file-upload)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.Document> UploadFileAsync(
            string corpusKey,
            global::Vectara.UploadFileRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadFileArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                corpusKey: ref corpusKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v2/corpora/{corpusKey}/upload_file",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (requestTimeout != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
            }
            if (requestTimeoutMillis != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout-Millis", requestTimeoutMillis.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (requestTimeout != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{requestTimeout}"),
                    name: "Request-Timeout");
            } 
            if (requestTimeoutMillis != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{requestTimeoutMillis}"),
                    name: "Request-Timeout-Millis");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{corpusKey}"),
                name: "corpus_key");
            if (request.Metadata != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Metadata}"),
                    name: "metadata");
            } 
            if (request.ChunkingStrategy != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ChunkingStrategy}"),
                    name: "chunking_strategy");
            } 
            if (request.Filename != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Filename}"),
                    name: "filename");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>()),
                name: "file",
                fileName: request.Filename ?? string.Empty);
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadFileRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUploadFileResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUploadFileResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Vectara.Document.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload a file to the corpus<br/>
        /// Upload files such as PDFs and Word Documents for automatic text extraction and metadata parsing.<br/>
        /// The request expects a `multipart/form-data` format containing the following parts:<br/>
        /// * `metadata` - (Optional) Specifies a JSON object representing any additional metadata to be associated with the extracted document. For example, `'metadata={"key": "value"};type=application/json'`<br/>
        /// * `chunking_strategy` - (Optional) Specifies the chunking strategy for the platform to use. If you do not set this option, the platform uses the default strategy, which creates one chunk per sentence. For example, `'chunking_strategy={"type":"max_chars_chunking_strategy","max_chars_per_chunk":200};type=application/json'`<br/>
        /// * `file` - Specifies the file that you want to upload.<br/>
        /// * `filename` - Specified as part of the file field with the file name that you want to associate with the uploaded file. For a curl example, use the following syntax: `'file=@/path/to/file/file.pdf;filename=desired_filename.pdf'`<br/>
        /// For more detailed information, see this [File Upload API guide.](https://docs.vectara.com/docs/api-reference/indexing-apis/file-upload/file-upload)
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
        /// (Optional) Choose how to split documents into chunks during indexing. If you do not set a chunking strategy,<br/>
        /// the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </param>
        /// <param name="filename">
        /// Optional multipart section to override the filename.
        /// </param>
        /// <param name="file">
        /// Binary file contents. The file name of the file will be used as the document ID.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.Document> UploadFileAsync(
            string corpusKey,
            byte[] file,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            object? metadata = default,
            global::Vectara.MaxCharsChunkingStrategy? chunkingStrategy = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vectara.UploadFileRequest
            {
                Metadata = metadata,
                ChunkingStrategy = chunkingStrategy,
                Filename = filename,
                File = file,
            };

            return await UploadFileAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}