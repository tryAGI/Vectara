#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class CoreDocumentPartImagePartModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CoreDocumentPartImagePartMode?>
    {
        /// <inheritdoc />
        public override global::Vectara.CoreDocumentPartImagePartMode? Read(
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
                        return global::Vectara.CoreDocumentPartImagePartModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.CoreDocumentPartImagePartMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vectara.CoreDocumentPartImagePartMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.CoreDocumentPartImagePartMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vectara.CoreDocumentPartImagePartModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
