
#nullable enable

namespace Vectara
{
    public partial class QueriesClient
    {
        partial void PrepareQueryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            global::Vectara.QueryRequest request);
        partial void PrepareQueryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            global::Vectara.QueryRequest request);
        partial void ProcessQueryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQueryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Multiple Corpora Query<br/>
        /// Perform a multipurpose query across to retrieve relevant information from one or more corpora and generate a response using Retrieval Augmented Generation (RAG).<br/>
        /// * Specify the unique `corpus_key` identifying the corpus to query. The `corpus_key` is [created in the Vectara Console UI](https://docs.vectara.com/docs/console-ui/creating-a-corpus) or the [Create Corpus API definition](https://docs.vectara.com/docs/api-reference/admin-apis/create-corpus). When creating a new corpus, you have the option to assign a custom `corpus_key` following your preferred naming convention. This key serves as a unique identifier for the corpus, allowing it to be referenced in search requests. For more information, see [Corpus Key Definition](https://docs.vectara.com/docs/api-reference/search-apis/search#corpus-key-definition).<br/>
        /// * Customize your search by specifying the query text (`query`), pagination details (`offset` and `limit`), and metadata filters (`metadata_filter`) to tailor your search results. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#query-definition)<br/>
        /// * Leverage advanced search capabilities like reranking (`reranker`) and opt-in Retrieval Augmented Generation (RAG) (`generation`) for enhanced query performance. Generation is opt in by setting the `generation` property. By excluding the property or by setting it to null, the response<br/>
        /// will not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Specify Vectara's RAG-focused LLM (Mockingbird) for the `generation_preset_name`. [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Use advanced summarization options that utilize detailed summarization parameters such as `max_response_characters`, `temperature`, and `frequency_penalty` for generating precise and relevant summaries. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries using the `citations` object to include numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#citation-format-in-summary)<br/>
        /// For more detailed information, see this [Query API guide](https://docs.vectara.com/docs/api-reference/search-apis/search).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.QueryFullResponse> QueryAsync(
            global::Vectara.QueryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQueryArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v2/query",
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

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareQueryRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessQueryResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Query request was malformed.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::Vectara.BadRequestError? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::Vectara.BadRequestError.FromJson(__content_400, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::Vectara.BadRequestError.FromJsonStreamAsync(__contentStream_400, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Vectara.ApiException<global::Vectara.BadRequestError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Permissions do not allow querying one or more corpora in the request.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::Vectara.Error? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::Vectara.Error.FromJson(__content_403, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::Vectara.Error.FromJsonStreamAsync(__contentStream_403, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Vectara.ApiException<global::Vectara.Error>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // One or more of the corpora were not found.
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::Vectara.NotFoundError? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::Vectara.NotFoundError.FromJson(__content_404, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::Vectara.NotFoundError.FromJsonStreamAsync(__contentStream_404, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Vectara.ApiException<global::Vectara.NotFoundError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessQueryResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Vectara.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Vectara.QueryFullResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Vectara.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::Vectara.QueryFullResponse.FromJsonStreamAsync(__responseStream, JsonSerializerContext).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Multiple Corpora Query<br/>
        /// Perform a multipurpose query across to retrieve relevant information from one or more corpora and generate a response using Retrieval Augmented Generation (RAG).<br/>
        /// * Specify the unique `corpus_key` identifying the corpus to query. The `corpus_key` is [created in the Vectara Console UI](https://docs.vectara.com/docs/console-ui/creating-a-corpus) or the [Create Corpus API definition](https://docs.vectara.com/docs/api-reference/admin-apis/create-corpus). When creating a new corpus, you have the option to assign a custom `corpus_key` following your preferred naming convention. This key serves as a unique identifier for the corpus, allowing it to be referenced in search requests. For more information, see [Corpus Key Definition](https://docs.vectara.com/docs/api-reference/search-apis/search#corpus-key-definition).<br/>
        /// * Customize your search by specifying the query text (`query`), pagination details (`offset` and `limit`), and metadata filters (`metadata_filter`) to tailor your search results. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#query-definition)<br/>
        /// * Leverage advanced search capabilities like reranking (`reranker`) and opt-in Retrieval Augmented Generation (RAG) (`generation`) for enhanced query performance. Generation is opt in by setting the `generation` property. By excluding the property or by setting it to null, the response<br/>
        /// will not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Specify Vectara's RAG-focused LLM (Mockingbird) for the `generation_preset_name`. [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Use advanced summarization options that utilize detailed summarization parameters such as `max_response_characters`, `temperature`, and `frequency_penalty` for generating precise and relevant summaries. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries using the `citations` object to include numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#citation-format-in-summary)<br/>
        /// For more detailed information, see this [Query API guide](https://docs.vectara.com/docs/api-reference/search-apis/search).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="query">
        /// The search query string, which is the question the user is asking.<br/>
        /// Example: Am I allowed to bring pets to work?
        /// </param>
        /// <param name="search">
        /// The parameters to search one or more corpora.
        /// </param>
        /// <param name="generation">
        /// The parameters to control generation.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.QueryFullResponse> QueryAsync(
            string query,
            global::Vectara.SearchCorporaParameters search,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.GenerationParameters? generation = default,
            bool? streamResponse = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vectara.QueryRequest
            {
                Query = query,
                Search = search,
                Generation = generation,
                StreamResponse = streamResponse,
            };

            return await QueryAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}