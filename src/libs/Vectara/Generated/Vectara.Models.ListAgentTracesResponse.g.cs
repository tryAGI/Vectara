
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A list of agent traces.
    /// </summary>
    public sealed partial class ListAgentTracesResponse
    {
        /// <summary>
        /// The list of agent traces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.AgentTrace> Traces { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Vectara.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentTracesResponse" /> class.
        /// </summary>
        /// <param name="traces">
        /// The list of agent traces.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentTracesResponse(
            global::System.Collections.Generic.IList<global::Vectara.AgentTrace> traces,
            global::Vectara.ListMetadata? metadata)
        {
            this.Traces = traces ?? throw new global::System.ArgumentNullException(nameof(traces));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentTracesResponse" /> class.
        /// </summary>
        public ListAgentTracesResponse()
        {
        }
    }
}