
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A JSON Schema definition for describing data structure. Defines the minimum subset generally supported across LLM providers. Unknown keywords are passed through for forward compatibility.
    /// </summary>
    public sealed partial class JsonSchemaDefinition
    {
        /// <summary>
        /// The JSON type for this schema element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.JsonSchemaDefinitionTypeJsonConverter))]
        public global::Vectara.JsonSchemaDefinitionType? Type { get; set; }

        /// <summary>
        /// Short human-readable label for this schema element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Human-readable description of this schema element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default value when none is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public object? Default { get; set; }

        /// <summary>
        /// Allowed values for this schema element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public byte[]? Enum { get; set; }

        /// <summary>
        /// Semantic format hint (e.g. date-time, date, email, uri, uuid). Provider support varies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Property definitions when type is 'object'. Each key maps to a nested schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.JsonSchemaDefinition>? Properties { get; set; }

        /// <summary>
        /// List of required property names when type is 'object'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Whether to allow additional properties beyond those defined.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalProperties")]
        public bool? AdditionalProperties { get; set; }

        /// <summary>
        /// A JSON Schema definition for describing data structure. Defines the minimum subset generally supported across LLM providers. Unknown keywords are passed through for forward compatibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::Vectara.JsonSchemaDefinition? Items { get; set; }

        /// <summary>
        /// Value must match at least one of the listed schemas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anyOf")]
        public global::System.Collections.Generic.IList<global::Vectara.JsonSchemaDefinition>? AnyOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaDefinition" /> class.
        /// </summary>
        /// <param name="type">
        /// The JSON type for this schema element.
        /// </param>
        /// <param name="title">
        /// Short human-readable label for this schema element.
        /// </param>
        /// <param name="description">
        /// Human-readable description of this schema element.
        /// </param>
        /// <param name="default">
        /// Default value when none is provided.
        /// </param>
        /// <param name="enum">
        /// Allowed values for this schema element.
        /// </param>
        /// <param name="format">
        /// Semantic format hint (e.g. date-time, date, email, uri, uuid). Provider support varies.
        /// </param>
        /// <param name="properties">
        /// Property definitions when type is 'object'. Each key maps to a nested schema.
        /// </param>
        /// <param name="required">
        /// List of required property names when type is 'object'.
        /// </param>
        /// <param name="additionalProperties">
        /// Whether to allow additional properties beyond those defined.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="items">
        /// A JSON Schema definition for describing data structure. Defines the minimum subset generally supported across LLM providers. Unknown keywords are passed through for forward compatibility.
        /// </param>
        /// <param name="anyOf">
        /// Value must match at least one of the listed schemas.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchemaDefinition(
            global::Vectara.JsonSchemaDefinitionType? type,
            string? title,
            string? description,
            object? @default,
            byte[]? @enum,
            string? format,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.JsonSchemaDefinition>? properties,
            global::System.Collections.Generic.IList<string>? required,
            bool? additionalProperties,
            global::Vectara.JsonSchemaDefinition? items,
            global::System.Collections.Generic.IList<global::Vectara.JsonSchemaDefinition>? anyOf)
        {
            this.Type = type;
            this.Title = title;
            this.Description = description;
            this.Default = @default;
            this.Enum = @enum;
            this.Format = format;
            this.Properties = properties;
            this.Required = required;
            this.AdditionalProperties = additionalProperties;
            this.Items = items;
            this.AnyOf = anyOf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaDefinition" /> class.
        /// </summary>
        public JsonSchemaDefinition()
        {
        }

    }
}