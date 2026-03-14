#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentToolConfigurationDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentToolConfigurationDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentToolConfigurationDiscriminatorType Read(
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
                        return global::Vectara.AgentToolConfigurationDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.AgentToolConfigurationDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vectara.AgentToolConfigurationDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AgentToolConfigurationDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vectara.AgentToolConfigurationDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
