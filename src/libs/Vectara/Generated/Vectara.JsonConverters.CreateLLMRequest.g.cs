#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class CreateLLMRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CreateLLMRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.CreateLLMRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateLLMRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateLLMRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateLLMRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CreateOpenAILLMRequest? openaiCompatible = default;
            if (discriminator?.Type == global::Vectara.CreateLLMRequestDiscriminatorType.OpenaiCompatible)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateOpenAILLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateOpenAILLMRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateOpenAILLMRequest)}");
                openaiCompatible = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Vectara.CreateLLMRequest(
                discriminator?.Type,
                openaiCompatible
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.CreateLLMRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenaiCompatible)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateOpenAILLMRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateOpenAILLMRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateOpenAILLMRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenaiCompatible, typeInfo);
            }
        }
    }
}