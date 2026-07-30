
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v1 protocol extension supported by the agent.
    /// </summary>
    public sealed partial class A2aV1AgentExtension
    {
        /// <summary>
        /// URI uniquely identifying the extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Human-readable description of what the extension does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// True if the client must understand this extension to interact with the agent.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Extension-specific configuration parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentExtension" /> class.
        /// </summary>
        /// <param name="uri">
        /// URI uniquely identifying the extension.
        /// </param>
        /// <param name="description">
        /// Human-readable description of what the extension does.
        /// </param>
        /// <param name="required">
        /// True if the client must understand this extension to interact with the agent.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="params">
        /// Extension-specific configuration parameters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1AgentExtension(
            string uri,
            string? description,
            bool? required,
            object? @params)
        {
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Description = description;
            this.Required = required;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentExtension" /> class.
        /// </summary>
        public A2aV1AgentExtension()
        {
        }

    }
}