
#nullable enable

namespace Vectara
{
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
    public partial class AgentsClient
    {
        partial void PrepareGetAgentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string agentKey);
        partial void PrepareGetAgentRequest(
========
    public partial class ToolServersClient
    {
        partial void PrepareGetToolServerArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string toolServerId);
        partial void PrepareGetToolServerRequest(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
            string agentKey);
        partial void ProcessGetAgentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAgentResponseContent(
========
            string toolServerId);
        partial void ProcessGetToolServerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetToolServerResponseContent(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
        /// Get agent<br/>
        /// The Get Agent API enables you to retrieve the complete configuration and operational details of a specific AI agent, providing comprehensive visibility into agent capabilities, tool integrations, behavioral instructions, and metadata.<br/>
        /// Use this API to inspect agent configurations before creating sessions, troubleshoot agent behavior issues, clone agent configurations for new deployments, and maintain documentation of agent capabilities across your enterprise AI infrastructure.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.Agent> GetAgentAsync(
            string agentKey,
========
        /// Get tool Server<br/>
        /// Retrieve details about a specific tool server by its Id.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolServerId">
        /// Example: tsr_rag_search
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.ToolServer> GetToolServerAsync(
            string toolServerId,
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
            PrepareGetAgentArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                agentKey: ref agentKey);

            var __pathBuilder = new global::Vectara.PathBuilder(
                path: $"/v2/agents/{agentKey}",
========
            PrepareGetToolServerArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                toolServerId: ref toolServerId);

            var __pathBuilder = new global::Vectara.PathBuilder(
                path: $"/v2/tool_servers/{toolServerId}",
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
            PrepareGetAgentRequest(
========
            PrepareGetToolServerRequest(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
                agentKey: agentKey);
========
                toolServerId: toolServerId);
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
            ProcessGetAgentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Permissions do not allow accessing this agent.
========
            ProcessGetToolServerResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Permissions do not allow accessing this tool.
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs
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
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
            // Agent not found.
========
            // Tool Server not found.
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs
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
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
                ProcessGetAgentResponseContent(
========
                ProcessGetToolServerResponseContent(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
                        global::Vectara.Agent.FromJson(__content, JsonSerializerContext) ??
========
                        global::Vectara.ToolServer.FromJson(__content, JsonSerializerContext) ??
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs
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
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.AgentsClient.GetAgent.g.cs
                        await global::Vectara.Agent.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
========
                        await global::Vectara.ToolServer.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.ToolServersClient.GetToolServer.g.cs
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
    }
}