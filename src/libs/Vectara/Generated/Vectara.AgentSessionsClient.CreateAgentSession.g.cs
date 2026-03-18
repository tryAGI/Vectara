
#nullable enable

namespace Vectara
{
    public partial class AgentSessionsClient
    {
        partial void PrepareCreateAgentSessionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string agentKey,
            global::Vectara.CreateAgentSessionRequest request);
        partial void PrepareCreateAgentSessionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            string agentKey,
            global::Vectara.CreateAgentSessionRequest request);
        partial void ProcessCreateAgentSessionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAgentSessionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create agent session<br/>
        /// Create a new session for interacting with an agent. A session is the conversation container that maintains state across all messages, events, tool use, and agent responses.<br/>
        /// This endpoint initializes the session and enables you to configure its initial properties, including optional metadata. Metadata can influence agent behavior, personalize responses, or apply access controls. Instructions and tools can also reference metadata using `${\session.metadata.field}` or `$\ref` syntax.<br/>
        /// A session also serves as the workspace for artifacts, enabling file uploads and multi-step workflows. For more information, see [Working with artifacts in sessions](https://docs.vectara.com/docs/agent-os/sessions#working-with-artifacts-in-sessions).<br/>
        /// ## Example request<br/>
        /// ```json<br/>
        /// \$ curl -X POST https://api.vectara.io/v2/agents/support-agent/sessions \<br/>
        /// -H "Authorization: Bearer YOUR_API_KEY" \<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -d '{<br/>
        ///   "key": "user_12345_session",<br/>
        ///   "name": "Customer Support Session",<br/>
        ///   "metadata": {<br/>
        ///     "user_role": "premium",<br/>
        ///     "language": "en"<br/>
        ///   }<br/>
        /// }'<br/>
        /// ```<br/>
        /// A successful response includes the unique session key, configuration metadata, and timestamps for creation and last update.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.AgentSession> CreateAgentSessionAsync(
            string agentKey,

            global::Vectara.CreateAgentSessionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateAgentSessionArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                agentKey: ref agentKey,
                request: request);

            var __pathBuilder = new global::Vectara.PathBuilder(
                path: $"/v2/agents/{agentKey}/sessions",
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
            PrepareCreateAgentSessionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                agentKey: agentKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateAgentSessionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Session creation request was malformed or references invalid agent.
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
            // Permissions do not allow creating sessions for this agent.
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
            // Referenced agent not found.
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
                ProcessCreateAgentSessionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vectara.AgentSession.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vectara.AgentSession.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create agent session<br/>
        /// Create a new session for interacting with an agent. A session is the conversation container that maintains state across all messages, events, tool use, and agent responses.<br/>
        /// This endpoint initializes the session and enables you to configure its initial properties, including optional metadata. Metadata can influence agent behavior, personalize responses, or apply access controls. Instructions and tools can also reference metadata using `${\session.metadata.field}` or `$\ref` syntax.<br/>
        /// A session also serves as the workspace for artifacts, enabling file uploads and multi-step workflows. For more information, see [Working with artifacts in sessions](https://docs.vectara.com/docs/agent-os/sessions#working-with-artifacts-in-sessions).<br/>
        /// ## Example request<br/>
        /// ```json<br/>
        /// \$ curl -X POST https://api.vectara.io/v2/agents/support-agent/sessions \<br/>
        /// -H "Authorization: Bearer YOUR_API_KEY" \<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -d '{<br/>
        ///   "key": "user_12345_session",<br/>
        ///   "name": "Customer Support Session",<br/>
        ///   "metadata": {<br/>
        ///     "user_role": "premium",<br/>
        ///     "language": "en"<br/>
        ///   }<br/>
        /// }'<br/>
        /// ```<br/>
        /// A successful response includes the unique session key, configuration metadata, and timestamps for creation and last update.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="key">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="name">
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </param>
        /// <param name="description">
        /// Optional description of the session purpose or context.<br/>
        /// Example: Helping customer troubleshoot issues
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the session.<br/>
        /// Default Value: {}<br/>
        /// Example: {"customer_id":"12345","priority":"medium","channel":"web_chat"}
        /// </param>
        /// <param name="enabled">
        /// Whether the session should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="ttiMinutes">
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If set to 0, the session will not expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 60
        /// </param>
        /// <param name="fromSession">
        /// Create a new session by forking an existing one. By default, copies all visible events<br/>
        /// and artifacts from the source session without compaction. Optionally specify exactly one of<br/>
        /// include_up_to_event_id or compact_up_to_event_id to control which events are included<br/>
        /// and whether they are compacted. These two fields are mutually exclusive.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vectara.AgentSession> CreateAgentSessionAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? key = default,
            string? name = default,
            string? description = default,
            object? metadata = default,
            bool? enabled = default,
            long? ttiMinutes = default,
            global::Vectara.CreateAgentSessionRequestFromSession? fromSession = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vectara.CreateAgentSessionRequest
            {
                Key = key,
                Name = name,
                Description = description,
                Metadata = metadata,
                Enabled = enabled,
                TtiMinutes = ttiMinutes,
                FromSession = fromSession,
            };

            return await CreateAgentSessionAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                agentKey: agentKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}