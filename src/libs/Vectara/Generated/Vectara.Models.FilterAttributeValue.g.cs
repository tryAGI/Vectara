
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single distinct value and its occurrence count within the faceted field.
    /// </summary>
    public sealed partial class FilterAttributeValue
    {
        /// <summary>
        /// The actual value from the metadata field. Type depends on the filter attribute type (string for text, number for integer/real_number, boolean for boolean).<br/>
        /// Example: contract
        /// </summary>
        /// <example>contract</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Number of document parts (chunks) that contain this value. Document-level attribute values are stored on every part of their document, so a document with multiple parts contributes once per part, not once per document. For list-type attributes, each list element is counted independently.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttributeValue" /> class.
        /// </summary>
        /// <param name="value">
        /// The actual value from the metadata field. Type depends on the filter attribute type (string for text, number for integer/real_number, boolean for boolean).<br/>
        /// Example: contract
        /// </param>
        /// <param name="count">
        /// Number of document parts (chunks) that contain this value. Document-level attribute values are stored on every part of their document, so a document with multiple parts contributes once per part, not once per document. For list-type attributes, each list element is counted independently.<br/>
        /// Example: 42
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterAttributeValue(
            object value,
            long count)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttributeValue" /> class.
        /// </summary>
        public FilterAttributeValue()
        {
        }

    }
}