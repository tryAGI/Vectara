#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class TestLambdaToolRequestLanguageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.TestLambdaToolRequestLanguage?>
    {
        /// <inheritdoc />
        public override global::Vectara.TestLambdaToolRequestLanguage? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Vectara.TestLambdaToolRequestLanguageExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.TestLambdaToolRequestLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vectara.TestLambdaToolRequestLanguage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.TestLambdaToolRequestLanguage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vectara.TestLambdaToolRequestLanguageExtensions.ToValueString(value.Value));
            }
        }
    }
}
