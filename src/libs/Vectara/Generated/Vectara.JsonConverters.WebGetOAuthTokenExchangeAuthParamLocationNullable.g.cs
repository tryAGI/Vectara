#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebGetOAuthTokenExchangeAuthParamLocationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation?>
    {
        /// <inheritdoc />
        public override global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation? Read(
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
                        return global::Vectara.WebGetOAuthTokenExchangeAuthParamLocationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vectara.WebGetOAuthTokenExchangeAuthParamLocationExtensions.ToValueString(value.Value));
            }
        }
    }
}
