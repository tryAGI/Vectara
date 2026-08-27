
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Properties shared by every connector create request.
    /// </summary>
    public sealed partial class CreateAgentConnectorRequestBase
    {
        /// <summary>
        /// The human-readable name of the connector.<br/>
        /// Example: Customer Support Slack Channel
        /// </summary>
        /// <example>Customer Support Slack Channel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A detailed description of what this connector does.<br/>
        /// Example: Receives customer support messages from the
        /// </summary>
        /// <example>Receives customer support messages from the</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the connector.<br/>
        /// Default Value: {}<br/>
        /// Example: {"priority":"high","department":"customer_service"}
        /// </summary>
        /// <example>{"priority":"high","department":"customer_service"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the connector should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConnectorRequestBase" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of the connector.<br/>
        /// Example: Customer Support Slack Channel
        /// </param>
        /// <param name="description">
        /// A detailed description of what this connector does.<br/>
        /// Example: Receives customer support messages from the
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the connector.<br/>
        /// Default Value: {}<br/>
        /// Example: {"priority":"high","department":"customer_service"}
        /// </param>
        /// <param name="enabled">
        /// Whether the connector should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentConnectorRequestBase(
            string name,
            string? description,
            object? metadata,
            bool? enabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Metadata = metadata;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConnectorRequestBase" /> class.
        /// </summary>
        public CreateAgentConnectorRequestBase()
        {
        }

    }
}