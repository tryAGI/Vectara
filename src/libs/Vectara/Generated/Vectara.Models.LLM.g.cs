
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A LLM can be used to enhance query results with a response, and be used as the responder during a chat.
    /// </summary>
    public sealed partial class LLM
    {
        /// <summary>
        /// The ID of the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the LLM is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// If this is the default LLM, it is used in queries when the generator is not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// List of prompts that the model can use. This is deprecated; see `/v2/generation_presets` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Vectara.Prompt>? Prompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLM" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the LLM.
        /// </param>
        /// <param name="name">
        /// Name of the LLM.
        /// </param>
        /// <param name="description">
        /// The description of the LLM.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the LLM is enabled.
        /// </param>
        /// <param name="default">
        /// If this is the default LLM, it is used in queries when the generator is not specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLM(
            string? id,
            string? name,
            string? description,
            bool? enabled,
            bool? @default)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLM" /> class.
        /// </summary>
        public LLM()
        {
        }
    }
}