
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public enum JsonSchemaDefinitionDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Array,
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Integer,
        /// <summary>
        ///
        /// </summary>
        Null,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        Object,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JsonSchemaDefinitionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JsonSchemaDefinitionDiscriminatorType value)
        {
            return value switch
            {
                JsonSchemaDefinitionDiscriminatorType.Array => "array",
                JsonSchemaDefinitionDiscriminatorType.Boolean => "boolean",
                JsonSchemaDefinitionDiscriminatorType.Integer => "integer",
                JsonSchemaDefinitionDiscriminatorType.Null => "null",
                JsonSchemaDefinitionDiscriminatorType.Number => "number",
                JsonSchemaDefinitionDiscriminatorType.Object => "object",
                JsonSchemaDefinitionDiscriminatorType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JsonSchemaDefinitionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "array" => JsonSchemaDefinitionDiscriminatorType.Array,
                "boolean" => JsonSchemaDefinitionDiscriminatorType.Boolean,
                "integer" => JsonSchemaDefinitionDiscriminatorType.Integer,
                "null" => JsonSchemaDefinitionDiscriminatorType.Null,
                "number" => JsonSchemaDefinitionDiscriminatorType.Number,
                "object" => JsonSchemaDefinitionDiscriminatorType.Object,
                "string" => JsonSchemaDefinitionDiscriminatorType.String,
                _ => null,
            };
        }
    }
}