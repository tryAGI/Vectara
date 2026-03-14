
#nullable enable

namespace Vectara
{
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
    public partial class LargeLanguageModelsClient
    {
        partial void PrepareUpdateLLMArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string llmId,
            global::Vectara.UpdateLLMRequest request);
        partial void PrepareUpdateLLMRequest(
========
    public partial class ToolServersClient
    {
        partial void PrepareCreateToolServerArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            global::Vectara.CreateToolServerRequest request);
        partial void PrepareCreateToolServerRequest(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
            string llmId,
            global::Vectara.UpdateLLMRequest request);
        partial void ProcessUpdateLLMResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateLLMResponseContent(
========
            global::Vectara.CreateToolServerRequest request);
        partial void ProcessCreateToolServerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateToolServerResponseContent(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
        /// Update an LLM<br/>
        /// Update an existing LLM's configuration. This endpoint allows partial updates - only provide fields you want to change. Only the name field is immutable.<br/>
        /// The updated LLM will be tested before saving to ensure credentials are valid.<br/>
        /// **Updatable fields:**<br/>
        /// - `description` - LLM description<br/>
        /// - `type` - LLM type (openai-compatible, vertex-ai, etc.)<br/>
        /// - `model` - Model identifier<br/>
        /// - `uri` - API endpoint<br/>
        /// - `auth` - Authentication credentials (including service account key_json)<br/>
        /// - `headers` - Additional HTTP headers (for openai-compatible and anthropic types)<br/>
        /// - `enabled` - Whether the LLM is enabled<br/>
        /// - `capabilities` - Model capabilities (image support, context limit, tool calling)<br/>
        /// **Immutable fields:**<br/>
        /// - `id` - System-generated identifier<br/>
        /// - `name` - LLM name<br/>
        /// Built-in LLMs (system-provided models) cannot be updated.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.Llm> UpdateLLMAsync(
            string llmId,

            global::Vectara.UpdateLLMRequest request,
========
        /// Create tool server<br/>
        /// Create a new tool server to expose tools for use by agents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.ToolServer> CreateToolServerAsync(

            global::Vectara.CreateToolServerRequest request,
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
            PrepareUpdateLLMArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                llmId: ref llmId,
                request: request);

            var __pathBuilder = new global::Vectara.PathBuilder(
                path: $"/v2/llms/{llmId}",
========
            PrepareCreateToolServerArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                request: request);

            var __pathBuilder = new global::Vectara.PathBuilder(
                path: "/v2/tool_servers",
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
            PrepareUpdateLLMRequest(
========
            PrepareCreateToolServerRequest(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
                llmId: llmId,
========
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
            ProcessUpdateLLMResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request body or connection test failed
========
            ProcessCreateToolServerResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request body.
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Vectara.BadRequestError? __value_400 = null;
                try
                {
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
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Vectara.ApiException<global::Vectara.BadRequestError>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
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
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
            // Permissions do not allow updating this LLM or LLM is built-in
========
            // Permissions do not allow creating tool servers.
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::Vectara.Error? __value_403 = null;
                try
                {
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
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::Vectara.ApiException<global::Vectara.Error>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
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
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
            // LLM not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::Vectara.NotFoundError? __value_404 = null;
                try
                {
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
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Vectara.ApiException<global::Vectara.NotFoundError>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
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
========
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
                ProcessUpdateLLMResponseContent(
========
                ProcessCreateToolServerResponseContent(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
                        global::Vectara.Llm.FromJson(__content, JsonSerializerContext) ??
========
                        global::Vectara.ToolServer.FromJson(__content, JsonSerializerContext) ??
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
                        await global::Vectara.Llm.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
========
                        await global::Vectara.ToolServer.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }

        /// <summary>
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.LargeLanguageModelsClient.UpdateLLM.g.cs
        /// Update an LLM<br/>
        /// Update an existing LLM's configuration. This endpoint allows partial updates - only provide fields you want to change. Only the name field is immutable.<br/>
        /// The updated LLM will be tested before saving to ensure credentials are valid.<br/>
        /// **Updatable fields:**<br/>
        /// - `description` - LLM description<br/>
        /// - `type` - LLM type (openai-compatible, vertex-ai, etc.)<br/>
        /// - `model` - Model identifier<br/>
        /// - `uri` - API endpoint<br/>
        /// - `auth` - Authentication credentials (including service account key_json)<br/>
        /// - `headers` - Additional HTTP headers (for openai-compatible and anthropic types)<br/>
        /// - `enabled` - Whether the LLM is enabled<br/>
        /// - `capabilities` - Model capabilities (image support, context limit, tool calling)<br/>
        /// **Immutable fields:**<br/>
        /// - `id` - System-generated identifier<br/>
        /// - `name` - LLM name<br/>
        /// Built-in LLMs (system-provided models) cannot be updated.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.Llm> UpdateLLMAsync(
            string llmId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vectara.UpdateLLMRequest
            {
            };

            return await UpdateLLMAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                llmId: llmId,
========
        /// Create tool server<br/>
        /// Create a new tool server to expose tools for use by agents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="name">
        /// The human-readable name of a tool server.<br/>
        /// Example: RAG Search Server
        /// </param>
        /// <param name="type">
        /// The type of tool server.<br/>
        /// Example: mcp
        /// </param>
        /// <param name="description">
        /// A detailed description of what this tool server does.<br/>
        /// Example: Provides RAG search capabilities for documents.
        /// </param>
        /// <param name="uri">
        /// The URI of the tool server.<br/>
        /// Example: https://api.example.com/rag_search
        /// </param>
        /// <param name="headers">
        /// Optional HTTP headers to include when connecting to the server.
        /// </param>
        /// <param name="transport">
        /// Transport protocol for MCP server connections. Both use Server-Sent Events (SSE).<br/>
        /// - `sse`: Legacy format (https://modelcontextprotocol.io/specification/2024-11-05/basic/transports)<br/>
        /// - `streamable-http`: New format (https://modelcontextprotocol.io/specification/2025-03-26/basic/transports)<br/>
        /// Example: sse
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for an LLM
        /// </param>
        /// <param name="enabled">
        /// Whether the tool server is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the tool server.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.ToolServer> CreateToolServerAsync(
            string name,
            string uri,
            global::Vectara.ToolServerTransport transport,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.ToolServerType type = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::Vectara.RemoteAuth? auth = default,
            bool? enabled = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vectara.CreateToolServerRequest
            {
                Name = name,
                Type = type,
                Description = description,
                Uri = uri,
                Headers = headers,
                Transport = transport,
                Auth = auth,
                Enabled = enabled,
                Metadata = metadata,
            };

            return await CreateToolServerAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.CreateToolServer.g.cs
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}