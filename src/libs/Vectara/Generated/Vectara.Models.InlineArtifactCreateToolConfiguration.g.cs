
#nullable enable

namespace Vectara
{
    /// <summary>
    /// An artifact create tool configuration defined inline in the agent for creating artifacts from text or structured data content.
    /// </summary>
    public sealed partial class InlineArtifactCreateToolConfiguration
    {
        /// <summary>
        /// The type of tool configuration, which is always 'artifact_create' for inline artifact create tool configurations.<br/>
        /// Default Value: artifact_create
        /// </summary>
        /// <default>"artifact_create"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "artifact_create";

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineArtifactCreateToolConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'artifact_create' for inline artifact create tool configurations.<br/>
        /// Default Value: artifact_create
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineArtifactCreateToolConfiguration(
            string type,
            string? descriptionTemplate)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DescriptionTemplate = descriptionTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineArtifactCreateToolConfiguration" /> class.
        /// </summary>
        public InlineArtifactCreateToolConfiguration()
        {
        }
    }
}