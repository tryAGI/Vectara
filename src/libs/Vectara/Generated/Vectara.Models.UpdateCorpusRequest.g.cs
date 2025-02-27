
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Corpus properties that are modifiable after creation.
    /// </summary>
    public sealed partial class UpdateCorpusRequest
    {
        /// <summary>
        /// Set whether or not the corpus is enabled. If unset then the corpus will remain in the same state.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The name for the corpus. If unset or null, then the corpus will remain in the same state.<br/>
        /// Example: new-name
        /// </summary>
        /// <example>new-name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the corpus. If unset or null, then the corpus will remain in the same state.<br/>
        /// Example: New description of the corpus.
        /// </summary>
        /// <example>New description of the corpus.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether to save corpus queries to query history by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_history")]
        public bool? SaveHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCorpusRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Set whether or not the corpus is enabled. If unset then the corpus will remain in the same state.<br/>
        /// Example: false
        /// </param>
        /// <param name="name">
        /// The name for the corpus. If unset or null, then the corpus will remain in the same state.<br/>
        /// Example: new-name
        /// </param>
        /// <param name="description">
        /// Description of the corpus. If unset or null, then the corpus will remain in the same state.<br/>
        /// Example: New description of the corpus.
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save corpus queries to query history by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCorpusRequest(
            bool? enabled,
            string? name,
            string? description,
            bool? saveHistory)
        {
            this.Enabled = enabled;
            this.Name = name;
            this.Description = description;
            this.SaveHistory = saveHistory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCorpusRequest" /> class.
        /// </summary>
        public UpdateCorpusRequest()
        {
        }
    }
}