
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSchemaObjectVariant2
    {
        /// <summary>
        /// The JSON type of this schema element. Always `object`.<br/>
        /// Default Value: object<br/>
        /// Example: object
        /// </summary>
        /// <default>"object"</default>
        /// <example>object</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "object";

        /// <summary>
        /// The object's properties. Each key maps to a nested schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// The property names that must be present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Whether the object may have properties beyond those listed in `properties`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalProperties")]
        public bool? AdditionalProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaObjectVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The JSON type of this schema element. Always `object`.<br/>
        /// Default Value: object<br/>
        /// Example: object
        /// </param>
        /// <param name="properties">
        /// The object's properties. Each key maps to a nested schema.
        /// </param>
        /// <param name="required">
        /// The property names that must be present.
        /// </param>
        /// <param name="additionalProperties">
        /// Whether the object may have properties beyond those listed in `properties`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchemaObjectVariant2(
            string type,
            object? properties,
            global::System.Collections.Generic.IList<string>? required,
            bool? additionalProperties)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Properties = properties;
            this.Required = required;
            this.AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaObjectVariant2" /> class.
        /// </summary>
        public JsonSchemaObjectVariant2()
        {
        }

    }
}