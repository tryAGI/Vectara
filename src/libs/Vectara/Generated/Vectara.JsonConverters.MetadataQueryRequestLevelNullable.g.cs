#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class MetadataQueryRequestLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.MetadataQueryRequestLevel?>
    {
        /// <inheritdoc />
        public override global::Vectara.MetadataQueryRequestLevel? Read(
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
                        return global::Vectara.MetadataQueryRequestLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.MetadataQueryRequestLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vectara.MetadataQueryRequestLevel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.MetadataQueryRequestLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vectara.MetadataQueryRequestLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
