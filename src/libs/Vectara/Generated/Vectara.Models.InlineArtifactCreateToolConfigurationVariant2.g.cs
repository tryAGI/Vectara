
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InlineArtifactCreateToolConfigurationVariant2
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineArtifactCreateToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'artifact_create' for inline artifact create tool configurations.<br/>
        /// Default Value: artifact_create
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineArtifactCreateToolConfigurationVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineArtifactCreateToolConfigurationVariant2" /> class.
        /// </summary>
        public InlineArtifactCreateToolConfigurationVariant2()
        {
        }

    }
}