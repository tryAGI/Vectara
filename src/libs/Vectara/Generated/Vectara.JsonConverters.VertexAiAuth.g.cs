#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class VertexAiAuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.VertexAiAuth>
    {
        /// <inheritdoc />
        public override global::Vectara.VertexAiAuth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAiAuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAiAuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.VertexAiAuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.VertexAiApiKeyAuth? apiKey = default;
            if (discriminator?.Type == global::Vectara.VertexAiAuthDiscriminatorType.ApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAiApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAiApiKeyAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.VertexAiApiKeyAuth)}");
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.VertexAiServiceAccountAuth? serviceAccount = default;
            if (discriminator?.Type == global::Vectara.VertexAiAuthDiscriminatorType.ServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAiServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAiServiceAccountAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.VertexAiServiceAccountAuth)}");
                serviceAccount = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Vectara.VertexAiAuth(
                discriminator?.Type,
                apiKey,
                serviceAccount
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.VertexAiAuth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAiApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAiApiKeyAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.VertexAiApiKeyAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey, typeInfo);
            }
            else if (value.IsServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAiServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAiServiceAccountAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.VertexAiServiceAccountAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServiceAccount, typeInfo);
            }
        }
    }
}