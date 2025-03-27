#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class CreateEncoderRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CreateEncoderRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.CreateEncoderRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateEncoderRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateEncoderRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateEncoderRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CreateOpenAIEncoderRequest? openaiCompatible = default;
            if (discriminator?.Type == global::Vectara.CreateEncoderRequestDiscriminatorType.OpenaiCompatible)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateOpenAIEncoderRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateOpenAIEncoderRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateOpenAIEncoderRequest)}");
                openaiCompatible = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Vectara.CreateEncoderRequest(
                discriminator?.Type,
                openaiCompatible
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.CreateEncoderRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenaiCompatible)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateOpenAIEncoderRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateOpenAIEncoderRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateOpenAIEncoderRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenaiCompatible, typeInfo);
            }
        }
    }
}