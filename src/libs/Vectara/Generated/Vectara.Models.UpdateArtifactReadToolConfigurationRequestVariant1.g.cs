
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateArtifactReadToolConfigurationRequestVariant1
    {
        /// <summary>
        /// This should always be `artifact_read`.<br/>
        /// Default Value: artifact_read<br/>
        /// Example: artifact_read
        /// </summary>
        /// <default>"artifact_read"</default>
        /// <example>artifact_read</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "artifact_read";

        /// <summary>
        /// Configurable parameters for the artifact read tool. If not overridden, they will be required by the LLM to fill in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::Vectara.ArtifactReadToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// User-configurable settings for the artifact read tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration")]
        public global::Vectara.ArtifactReadConfiguration? ToolConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateArtifactReadToolConfigurationRequestVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `artifact_read`.<br/>
        /// Default Value: artifact_read<br/>
        /// Example: artifact_read
        /// </param>
        /// <param name="argumentOverride">
        /// Configurable parameters for the artifact read tool. If not overridden, they will be required by the LLM to fill in.
        /// </param>
        /// <param name="toolConfiguration">
        /// User-configurable settings for the artifact read tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateArtifactReadToolConfigurationRequestVariant1(
            string type,
            global::Vectara.ArtifactReadToolParameters? argumentOverride,
            global::Vectara.ArtifactReadConfiguration? toolConfiguration)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
            this.ToolConfiguration = toolConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateArtifactReadToolConfigurationRequestVariant1" /> class.
        /// </summary>
        public UpdateArtifactReadToolConfigurationRequestVariant1()
        {
        }
    }
}