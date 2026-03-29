
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base properties shared by all tool configuration types.
    /// </summary>
    public sealed partial class ToolConfigurationBase
    {
        /// <summary>
        /// Unique identifier for a tool configuration.<br/>
        /// Example: tcf_123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>tcf_123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The human-readable name of a tool configuration.<br/>
        /// Example: Customer Support Search Config
        /// </summary>
        /// <example>Customer Support Search Config</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A detailed description of what this tool configuration is for and how it should be used.<br/>
        /// Example: Configuration for searching customer support documentation with optimized parameters
        /// </summary>
        /// <example>Configuration for searching customer support documentation with optimized parameters</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Velocity template for generating dynamic tool descriptions. When set, this template is rendered at runtime to produce the tool description.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// Example: "Search tool configured for agent $agent.name on $currentDate"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description_template")]
        public string? DescriptionTemplate { get; set; }

        /// <summary>
        /// The version identifier for this tool configuration. This is automatically incremented when the configuration is updated.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Whether the tool configuration is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Optional metadata associated with this tool configuration.<br/>
        /// Example: {"tags":["production","v2"],"owner":"team-platform"}
        /// </summary>
        /// <example>{"tags":["production","v2"],"owner":"team-platform"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Timestamp when the tool configuration was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the tool configuration was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfigurationBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for a tool configuration.<br/>
        /// Example: tcf_123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="version">
        /// The version identifier for this tool configuration. This is automatically incremented when the configuration is updated.<br/>
        /// Example: 1
        /// </param>
        /// <param name="name">
        /// The human-readable name of a tool configuration.<br/>
        /// Example: Customer Support Search Config
        /// </param>
        /// <param name="description">
        /// A detailed description of what this tool configuration is for and how it should be used.<br/>
        /// Example: Configuration for searching customer support documentation with optimized parameters
        /// </param>
        /// <param name="descriptionTemplate">
        /// Velocity template for generating dynamic tool descriptions. When set, this template is rendered at runtime to produce the tool description.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// Example: "Search tool configured for agent $agent.name on $currentDate"
        /// </param>
        /// <param name="enabled">
        /// Whether the tool configuration is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// Optional metadata associated with this tool configuration.<br/>
        /// Example: {"tags":["production","v2"],"owner":"team-platform"}
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the tool configuration was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the tool configuration was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolConfigurationBase(
            string id,
            int version,
            string? name,
            string? description,
            string? descriptionTemplate,
            bool? enabled,
            object? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Description = description;
            this.DescriptionTemplate = descriptionTemplate;
            this.Version = version;
            this.Enabled = enabled;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfigurationBase" /> class.
        /// </summary>
        public ToolConfigurationBase()
        {
        }
    }
}