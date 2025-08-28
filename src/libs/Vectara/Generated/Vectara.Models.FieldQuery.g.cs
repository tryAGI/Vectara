
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Defines a field-specific query for fuzzy matching.
    /// </summary>
    public sealed partial class FieldQuery
    {
        /// <summary>
        /// Name of the metadata field to search (without doc/part prefix).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// The text to search for in this field. Fuzzy matching is applied automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Weight to apply to this field during scoring (higher values increase importance of this field).<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldQuery" /> class.
        /// </summary>
        /// <param name="field">
        /// Name of the metadata field to search (without doc/part prefix).
        /// </param>
        /// <param name="query">
        /// The text to search for in this field. Fuzzy matching is applied automatically.
        /// </param>
        /// <param name="weight">
        /// Weight to apply to this field during scoring (higher values increase importance of this field).<br/>
        /// Default Value: 1F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldQuery(
            string field,
            string query,
            float? weight)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldQuery" /> class.
        /// </summary>
        public FieldQuery()
        {
        }
    }
}