
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSchemaValueVariant2
    {
        /// <summary>
        /// The JSON type of this schema element. One of `array`, `string`, `number`, `integer`, `boolean`, or `null`. Omit it when the element only combines other schemas with `anyOf`.<br/>
        /// Example: string
        /// </summary>
        /// <example>string</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The allowed values for this element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public byte[]? Enum { get; set; }

        /// <summary>
        /// A semantic format hint, such as date-time, date, email, uri, or uuid. Provider support varies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// A JSON Schema definition that describes a data structure. Covers the smallest subset of<br/>
        /// JSON Schema that all LLM providers support. Unknown keywords are kept and passed through<br/>
        /// to the provider.<br/>
        /// `properties`, `required`, and `additionalProperties` are valid only when `type` is<br/>
        /// `object`. `enum`, `format`, `items`, and `anyOf` are valid for every other `type`, and<br/>
        /// for an element with no `type`, such as one that only combines schemas with `anyOf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.JsonSchemaDefinitionJsonConverter))]
        public global::Vectara.JsonSchemaDefinition? Items { get; set; }

        /// <summary>
        /// A list of schemas. The value must match at least one of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anyOf")]
        public global::System.Collections.Generic.IList<global::Vectara.JsonSchemaDefinition>? AnyOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaValueVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The JSON type of this schema element. One of `array`, `string`, `number`, `integer`, `boolean`, or `null`. Omit it when the element only combines other schemas with `anyOf`.<br/>
        /// Example: string
        /// </param>
        /// <param name="enum">
        /// The allowed values for this element.
        /// </param>
        /// <param name="format">
        /// A semantic format hint, such as date-time, date, email, uri, or uuid. Provider support varies.
        /// </param>
        /// <param name="items">
        /// A JSON Schema definition that describes a data structure. Covers the smallest subset of<br/>
        /// JSON Schema that all LLM providers support. Unknown keywords are kept and passed through<br/>
        /// to the provider.<br/>
        /// `properties`, `required`, and `additionalProperties` are valid only when `type` is<br/>
        /// `object`. `enum`, `format`, `items`, and `anyOf` are valid for every other `type`, and<br/>
        /// for an element with no `type`, such as one that only combines schemas with `anyOf`.
        /// </param>
        /// <param name="anyOf">
        /// A list of schemas. The value must match at least one of them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchemaValueVariant2(
            string? type,
            byte[]? @enum,
            string? format,
            global::Vectara.JsonSchemaDefinition? items,
            global::System.Collections.Generic.IList<global::Vectara.JsonSchemaDefinition>? anyOf)
        {
            this.Type = type;
            this.Enum = @enum;
            this.Format = format;
            this.Items = items;
            this.AnyOf = anyOf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaValueVariant2" /> class.
        /// </summary>
        public JsonSchemaValueVariant2()
        {
        }

    }
}