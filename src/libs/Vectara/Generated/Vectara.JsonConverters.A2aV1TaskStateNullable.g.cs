#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class A2aV1TaskStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.A2aV1TaskState?>
    {
        /// <inheritdoc />
        public override global::Vectara.A2aV1TaskState? Read(
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
                        return global::Vectara.A2aV1TaskStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.A2aV1TaskState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vectara.A2aV1TaskState?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.A2aV1TaskState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vectara.A2aV1TaskStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
