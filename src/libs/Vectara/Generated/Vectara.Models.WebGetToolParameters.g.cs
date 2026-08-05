
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configurable parameters for the web get tool. If not provided, the agent fills them in.
    /// </summary>
    public sealed partial class WebGetToolParameters
    {
        /// <summary>
        /// The URL to fetch content from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<string, global::Vectara.EagerReference>? Url { get; set; }

        /// <summary>
        /// HTTP method to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.WebGetToolParametersMethodJsonConverter))]
        public global::Vectara.WebGetToolParametersMethod? Method { get; set; }

        /// <summary>
        /// HTTP headers to include in the request. One of:<br/>
        /// - A literal `{name: value}` map. Each value may be a string or an EagerReference for per-header secret lookup.<br/>
        /// - An EagerReference ({"$ref": "agent.secrets"}) that resolves at session start to a `Map&lt;String, String&gt;`. Use this to source the whole header set from agent secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<global::Vectara.WebGetHeadersMap, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<global::Vectara.WebGetHeadersMap, global::Vectara.EagerReference>? Headers { get; set; }

        /// <summary>
        /// Request body for POST/PUT/PATCH requests. Its UTF-8 byte length must not exceed `max_body_bytes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<string, global::Vectara.EagerReference>? Body { get; set; }

        /// <summary>
        /// Whether to follow HTTP redirects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follow_redirects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<bool?, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<bool?, global::Vectara.EagerReference>? FollowRedirects { get; set; }

        /// <summary>
        /// Request timeout in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<int?, global::Vectara.EagerReference>? TimeoutSeconds { get; set; }

        /// <summary>
        /// Number of lines from start to include in response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_lines")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<int?, global::Vectara.EagerReference>? HeadLines { get; set; }

        /// <summary>
        /// Number of lines from end to include in response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tail_lines")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<int?, global::Vectara.EagerReference>? TailLines { get; set; }

        /// <summary>
        /// Whether to verify SSL certificates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssl_verify")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<bool?, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<bool?, global::Vectara.EagerReference>? SslVerify { get; set; }

        /// <summary>
        /// Maximum response size in bytes before truncation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_content_bytes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<long?, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<long?, global::Vectara.EagerReference>? MaxContentBytes { get; set; }

        /// <summary>
        /// Maximum UTF-8 byte length of `body`; a request whose body exceeds this is rejected without being sent. Must be between 1024 (1 KB) and 4194304 (4 MB). Defaults to 65536 (64 KB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_body_bytes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<long?, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<long?, global::Vectara.EagerReference>? MaxBodyBytes { get; set; }

        /// <summary>
        /// How to return the response body. `content` (default) returns the body inline in `content`, truncated to `head_lines`/`tail_lines`/`max_content_bytes`. `artifact` streams the body into a session artifact and returns its id in `artifact_id`; `content` is then absent.<br/>
        /// Default Value: content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.WebGetToolParametersResponseModeJsonConverter))]
        public global::Vectara.WebGetToolParametersResponseMode? ResponseMode { get; set; }

        /// <summary>
        /// Authentication configuration for the outgoing HTTP request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.WebGetAuthJsonConverter))]
        public global::Vectara.WebGetAuth? Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetToolParameters" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to fetch content from.
        /// </param>
        /// <param name="method">
        /// HTTP method to use.
        /// </param>
        /// <param name="headers">
        /// HTTP headers to include in the request. One of:<br/>
        /// - A literal `{name: value}` map. Each value may be a string or an EagerReference for per-header secret lookup.<br/>
        /// - An EagerReference ({"$ref": "agent.secrets"}) that resolves at session start to a `Map&lt;String, String&gt;`. Use this to source the whole header set from agent secrets.
        /// </param>
        /// <param name="body">
        /// Request body for POST/PUT/PATCH requests. Its UTF-8 byte length must not exceed `max_body_bytes`.
        /// </param>
        /// <param name="followRedirects">
        /// Whether to follow HTTP redirects.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Request timeout in seconds.
        /// </param>
        /// <param name="headLines">
        /// Number of lines from start to include in response.
        /// </param>
        /// <param name="tailLines">
        /// Number of lines from end to include in response.
        /// </param>
        /// <param name="sslVerify">
        /// Whether to verify SSL certificates.
        /// </param>
        /// <param name="maxContentBytes">
        /// Maximum response size in bytes before truncation.
        /// </param>
        /// <param name="maxBodyBytes">
        /// Maximum UTF-8 byte length of `body`; a request whose body exceeds this is rejected without being sent. Must be between 1024 (1 KB) and 4194304 (4 MB). Defaults to 65536 (64 KB).
        /// </param>
        /// <param name="responseMode">
        /// How to return the response body. `content` (default) returns the body inline in `content`, truncated to `head_lines`/`tail_lines`/`max_content_bytes`. `artifact` streams the body into a session artifact and returns its id in `artifact_id`; `content` is then absent.<br/>
        /// Default Value: content
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for the outgoing HTTP request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebGetToolParameters(
            global::Vectara.OneOf<string, global::Vectara.EagerReference>? url,
            global::Vectara.WebGetToolParametersMethod? method,
            global::Vectara.OneOf<global::Vectara.WebGetHeadersMap, global::Vectara.EagerReference>? headers,
            global::Vectara.OneOf<string, global::Vectara.EagerReference>? body,
            global::Vectara.OneOf<bool?, global::Vectara.EagerReference>? followRedirects,
            global::Vectara.OneOf<int?, global::Vectara.EagerReference>? timeoutSeconds,
            global::Vectara.OneOf<int?, global::Vectara.EagerReference>? headLines,
            global::Vectara.OneOf<int?, global::Vectara.EagerReference>? tailLines,
            global::Vectara.OneOf<bool?, global::Vectara.EagerReference>? sslVerify,
            global::Vectara.OneOf<long?, global::Vectara.EagerReference>? maxContentBytes,
            global::Vectara.OneOf<long?, global::Vectara.EagerReference>? maxBodyBytes,
            global::Vectara.WebGetToolParametersResponseMode? responseMode,
            global::Vectara.WebGetAuth? auth)
        {
            this.Url = url;
            this.Method = method;
            this.Headers = headers;
            this.Body = body;
            this.FollowRedirects = followRedirects;
            this.TimeoutSeconds = timeoutSeconds;
            this.HeadLines = headLines;
            this.TailLines = tailLines;
            this.SslVerify = sslVerify;
            this.MaxContentBytes = maxContentBytes;
            this.MaxBodyBytes = maxBodyBytes;
            this.ResponseMode = responseMode;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetToolParameters" /> class.
        /// </summary>
        public WebGetToolParameters()
        {
        }

    }
}