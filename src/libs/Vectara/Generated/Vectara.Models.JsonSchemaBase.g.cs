
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Keywords shared by every JSON Schema element.
    /// </summary>
    public sealed partial class JsonSchemaBase
    {
        /// <summary>
        /// A short label for this schema element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// A description of this schema element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The default value to use when none is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public object? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaBase" /> class.
        /// </summary>
        /// <param name="title">
        /// A short label for this schema element.
        /// </param>
        /// <param name="description">
        /// A description of this schema element.
        /// </param>
        /// <param name="default">
        /// The default value to use when none is provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchemaBase(
            string? title,
            string? description,
            object? @default)
        {
            this.Title = title;
            this.Description = description;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaBase" /> class.
        /// </summary>
        public JsonSchemaBase()
        {
        }

    }
}