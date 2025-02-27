#nullable enable

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public sealed class SummarizeDocumentStreamedResponseDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType Read(
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
                        return global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
