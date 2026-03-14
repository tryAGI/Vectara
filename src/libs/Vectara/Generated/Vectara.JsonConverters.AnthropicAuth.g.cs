#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicAuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AnthropicAuth>
    {
        /// <inheritdoc />
        public override global::Vectara.AnthropicAuth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AnthropicAuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AnthropicAuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AnthropicAuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.BearerAuth? bearer = default;
            if (discriminator?.Type == global::Vectara.AnthropicAuthDiscriminatorType.Bearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BearerAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BearerAuth)}");
                bearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.HeaderAuth? header = default;
            if (discriminator?.Type == global::Vectara.AnthropicAuthDiscriminatorType.Header)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.HeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.HeaderAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.HeaderAuth)}");
                header = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.BedrockStaticIAMAuth? bedrockStaticIam = default;
            if (discriminator?.Type == global::Vectara.AnthropicAuthDiscriminatorType.BedrockStaticIam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BedrockStaticIAMAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BedrockStaticIAMAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BedrockStaticIAMAuth)}");
                bedrockStaticIam = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.BedrockApiKeyAuth? bedrockApiKey = default;
            if (discriminator?.Type == global::Vectara.AnthropicAuthDiscriminatorType.BedrockApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BedrockApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BedrockApiKeyAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BedrockApiKeyAuth)}");
                bedrockApiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.VertexServiceAccountAuth? vertexServiceAccount = default;
            if (discriminator?.Type == global::Vectara.AnthropicAuthDiscriminatorType.VertexServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexServiceAccountAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.VertexServiceAccountAuth)}");
                vertexServiceAccount = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.VertexAccessTokenAuth? vertexAccessToken = default;
            if (discriminator?.Type == global::Vectara.AnthropicAuthDiscriminatorType.VertexAccessToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAccessTokenAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAccessTokenAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.VertexAccessTokenAuth)}");
                vertexAccessToken = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AnthropicAuth(
                discriminator?.Type,
                bearer,

                header,

                bedrockStaticIam,

                bedrockApiKey,

                vertexServiceAccount,

                vertexAccessToken
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AnthropicAuth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BearerAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BearerAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer, typeInfo);
            }
            else if (value.IsHeader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.HeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.HeaderAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.HeaderAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header, typeInfo);
            }
            else if (value.IsBedrockStaticIam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BedrockStaticIAMAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BedrockStaticIAMAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BedrockStaticIAMAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BedrockStaticIam, typeInfo);
            }
            else if (value.IsBedrockApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BedrockApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BedrockApiKeyAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BedrockApiKeyAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BedrockApiKey, typeInfo);
            }
            else if (value.IsVertexServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexServiceAccountAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.VertexServiceAccountAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexServiceAccount, typeInfo);
            }
            else if (value.IsVertexAccessToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAccessTokenAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAccessTokenAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.VertexAccessTokenAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexAccessToken, typeInfo);
            }
        }
    }
}