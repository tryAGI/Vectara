#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class IndividualSearchResultDiscriminatorResultTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.IndividualSearchResultDiscriminatorResultType?>
    {
        /// <inheritdoc />
        public override global::Vectara.IndividualSearchResultDiscriminatorResultType? Read(
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
                        return global::Vectara.IndividualSearchResultDiscriminatorResultTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.IndividualSearchResultDiscriminatorResultType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vectara.IndividualSearchResultDiscriminatorResultType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.IndividualSearchResultDiscriminatorResultType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vectara.IndividualSearchResultDiscriminatorResultTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
