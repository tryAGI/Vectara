#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateChatCompletionStreamResponseObjectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CreateChatCompletionStreamResponseObject?>
    {
        /// <inheritdoc />
        public override global::Vectara.CreateChatCompletionStreamResponseObject? Read(
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
                        return global::Vectara.CreateChatCompletionStreamResponseObjectExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.CreateChatCompletionStreamResponseObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vectara.CreateChatCompletionStreamResponseObject?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.CreateChatCompletionStreamResponseObject? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vectara.CreateChatCompletionStreamResponseObjectExtensions.ToValueString(value.Value));
            }
        }
    }
}
