#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationPresetOwnershipNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.GenerationPresetOwnership?>
    {
        /// <inheritdoc />
        public override global::Vectara.GenerationPresetOwnership? Read(
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
                        return global::Vectara.GenerationPresetOwnershipExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.GenerationPresetOwnership)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vectara.GenerationPresetOwnership?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.GenerationPresetOwnership? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vectara.GenerationPresetOwnershipExtensions.ToValueString(value.Value));
            }
        }
    }
}
