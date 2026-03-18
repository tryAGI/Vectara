
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactGrepToolConfigurationVariant2
    {
        /// <summary>
        /// This should always be `artifact_grep`.<br/>
        /// Default Value: artifact_grep<br/>
        /// Example: artifact_grep
        /// </summary>
        /// <default>"artifact_grep"</default>
        /// <example>artifact_grep</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "artifact_grep";

        /// <summary>
        /// Configurable parameters for the artifact grep tool. If not overridden, they will be required by the LLM to fill in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::Vectara.ArtifactGrepToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactGrepToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `artifact_grep`.<br/>
        /// Default Value: artifact_grep<br/>
        /// Example: artifact_grep
        /// </param>
        /// <param name="argumentOverride">
        /// Configurable parameters for the artifact grep tool. If not overridden, they will be required by the LLM to fill in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactGrepToolConfigurationVariant2(
            string type,
            global::Vectara.ArtifactGrepToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactGrepToolConfigurationVariant2" /> class.
        /// </summary>
        public ArtifactGrepToolConfigurationVariant2()
        {
        }
    }
}