
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single transport binding endpoint advertised by the v1 agent card. The card lists every supported transport in `supportedInterfaces`; the first entry is the preferred binding.
    /// </summary>
    public sealed partial class A2aV1AgentInterface
    {
        /// <summary>
        /// URL of this transport endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The transport binding for this interface. Open string; one of `JSONRPC`, `GRPC`, or `HTTP+JSON`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolBinding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProtocolBinding { get; set; }

        /// <summary>
        /// Tenant identifier substituted into the URL on requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public string? Tenant { get; set; }

        /// <summary>
        /// A2A protocol version this interface exposes (e.g. `0.3`, `1.0`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProtocolVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentInterface" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of this transport endpoint.
        /// </param>
        /// <param name="protocolBinding">
        /// The transport binding for this interface. Open string; one of `JSONRPC`, `GRPC`, or `HTTP+JSON`.
        /// </param>
        /// <param name="protocolVersion">
        /// A2A protocol version this interface exposes (e.g. `0.3`, `1.0`).
        /// </param>
        /// <param name="tenant">
        /// Tenant identifier substituted into the URL on requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1AgentInterface(
            string url,
            string protocolBinding,
            string protocolVersion,
            string? tenant)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ProtocolBinding = protocolBinding ?? throw new global::System.ArgumentNullException(nameof(protocolBinding));
            this.Tenant = tenant;
            this.ProtocolVersion = protocolVersion ?? throw new global::System.ArgumentNullException(nameof(protocolVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentInterface" /> class.
        /// </summary>
        public A2aV1AgentInterface()
        {
        }

    }
}