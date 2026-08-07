
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A specification wrapper for a named JSON schema.
    /// </summary>
    public sealed partial class JsonSchemaSpec
    {
        /// <summary>
        /// A description of the purpose of the response format. The model uses this description to determine how to respond in the format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A unique name for this schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// When true, enforces strict schema adherence. The model always follows the exact schema structure.<br/>
        /// In strict mode, the schema must follow these rules:<br/>
        /// - Set `additionalProperties: false` on all object types<br/>
        /// - List all properties in the `required` array<br/>
        /// - Maximum 100 properties total, with max 5 levels of nesting<br/>
        /// - Unsupported keywords: minLength, maxLength, pattern, minimum, maximum, minItems, maxItems<br/>
        /// - The root schema cannot use the `anyOf` type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// A JSON Schema definition that describes a data structure. Covers the smallest subset of JSON Schema that all LLM providers support. Unknown keywords are kept and passed through to the provider.<br/>
        /// `properties`, `required`, and `additionalProperties` are valid only when `type` is `object`. `enum`, `format`, `items`, and `anyOf` are valid for every other `type`, and for an element with no `type`, such as one that only combines schemas with `anyOf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.JsonSchemaDefinitionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.JsonSchemaDefinition Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaSpec" /> class.
        /// </summary>
        /// <param name="name">
        /// A unique name for this schema.
        /// </param>
        /// <param name="schema">
        /// A JSON Schema definition that describes a data structure. Covers the smallest subset of JSON Schema that all LLM providers support. Unknown keywords are kept and passed through to the provider.<br/>
        /// `properties`, `required`, and `additionalProperties` are valid only when `type` is `object`. `enum`, `format`, `items`, and `anyOf` are valid for every other `type`, and for an element with no `type`, such as one that only combines schemas with `anyOf`.
        /// </param>
        /// <param name="description">
        /// A description of the purpose of the response format. The model uses this description to determine how to respond in the format.
        /// </param>
        /// <param name="strict">
        /// When true, enforces strict schema adherence. The model always follows the exact schema structure.<br/>
        /// In strict mode, the schema must follow these rules:<br/>
        /// - Set `additionalProperties: false` on all object types<br/>
        /// - List all properties in the `required` array<br/>
        /// - Maximum 100 properties total, with max 5 levels of nesting<br/>
        /// - Unsupported keywords: minLength, maxLength, pattern, minimum, maximum, minItems, maxItems<br/>
        /// - The root schema cannot use the `anyOf` type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchemaSpec(
            string name,
            global::Vectara.JsonSchemaDefinition schema,
            string? description,
            bool? strict)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Strict = strict;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaSpec" /> class.
        /// </summary>
        public JsonSchemaSpec()
        {
        }

    }
}