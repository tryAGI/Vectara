#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentConnectorLastWebhookStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentConnectorLastWebhookStatus>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentConnectorLastWebhookStatus Read(
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
                        return global::Vectara.AgentConnectorLastWebhookStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.AgentConnectorLastWebhookStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vectara.AgentConnectorLastWebhookStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AgentConnectorLastWebhookStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vectara.AgentConnectorLastWebhookStatusExtensions.ToValueString(value));
        }
    }
}
