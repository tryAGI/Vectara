
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response containing a list of agent connectors.
    /// </summary>
    public sealed partial class ListAgentConnectorsResponse
    {
        /// <summary>
        /// List of agent connectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.AgentConnector> Connectors { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ListMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentConnectorsResponse" /> class.
        /// </summary>
        /// <param name="connectors">
        /// List of agent connectors.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentConnectorsResponse(
            global::System.Collections.Generic.IList<global::Vectara.AgentConnector> connectors,
            global::Vectara.ListMetadata metadata)
        {
            this.Connectors = connectors ?? throw new global::System.ArgumentNullException(nameof(connectors));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentConnectorsResponse" /> class.
        /// </summary>
        public ListAgentConnectorsResponse()
        {
        }
    }
}