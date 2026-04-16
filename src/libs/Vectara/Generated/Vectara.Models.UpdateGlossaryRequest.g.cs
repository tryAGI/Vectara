
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to update glossary metadata.
    /// </summary>
    public sealed partial class UpdateGlossaryRequest
    {
        /// <summary>
        /// Updated name for the glossary.<br/>
        /// Example: Platform Acronyms
        /// </summary>
        /// <example>Platform Acronyms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGlossaryRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated name for the glossary.<br/>
        /// Example: Platform Acronyms
        /// </param>
        /// <param name="description">
        /// Updated description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGlossaryRequest(
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGlossaryRequest" /> class.
        /// </summary>
        public UpdateGlossaryRequest()
        {
        }
    }
}