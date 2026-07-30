
#nullable enable

namespace Vectara
{
    /// <summary>
    /// An additional transport endpoint advertised by the agent card beyond `url`.
    /// </summary>
    public sealed partial class A2aV03AgentInterface
    {
        /// <summary>
        /// URL of the transport endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Transport name. Open string; common values include `JSONRPC`, `GRPC`, `HTTP+JSON`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03AgentInterface" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the transport endpoint.
        /// </param>
        /// <param name="transport">
        /// Transport name. Open string; common values include `JSONRPC`, `GRPC`, `HTTP+JSON`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03AgentInterface(
            string url,
            string transport)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03AgentInterface" /> class.
        /// </summary>
        public A2aV03AgentInterface()
        {
        }

    }
}