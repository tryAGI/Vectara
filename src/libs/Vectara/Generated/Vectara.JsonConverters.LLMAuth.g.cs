#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class LLMAuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.LLMAuth>
    {
        /// <inheritdoc />
        public override global::Vectara.LLMAuth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.LLMAuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.LLMAuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.LLMAuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.BearerAuth? bearer = default;
            if (discriminator?.Type == global::Vectara.LLMAuthDiscriminatorType.Bearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BearerAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BearerAuth)}");
                bearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.HeaderAuth? header = default;
            if (discriminator?.Type == global::Vectara.LLMAuthDiscriminatorType.Header)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.HeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.HeaderAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.HeaderAuth)}");
                header = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.OAuthClientCredentialsAuth? oauthClientCredentials = default;
            if (discriminator?.Type == global::Vectara.LLMAuthDiscriminatorType.OauthClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.OAuthClientCredentialsAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.OAuthClientCredentialsAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.OAuthClientCredentialsAuth)}");
                oauthClientCredentials = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.BedrockStaticIAMAuth? bedrockStaticIam = default;
            if (discriminator?.Type == global::Vectara.LLMAuthDiscriminatorType.BedrockStaticIam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BedrockStaticIAMAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BedrockStaticIAMAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BedrockStaticIAMAuth)}");
                bedrockStaticIam = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.BedrockApiKeyAuth? bedrockApiKey = default;
            if (discriminator?.Type == global::Vectara.LLMAuthDiscriminatorType.BedrockApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BedrockApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BedrockApiKeyAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BedrockApiKeyAuth)}");
                bedrockApiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.VertexServiceAccountAuth? vertexServiceAccount = default;
            if (discriminator?.Type == global::Vectara.LLMAuthDiscriminatorType.VertexServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexServiceAccountAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.VertexServiceAccountAuth)}");
                vertexServiceAccount = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.VertexAccessTokenAuth? vertexAccessToken = default;
            if (discriminator?.Type == global::Vectara.LLMAuthDiscriminatorType.VertexAccessToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAccessTokenAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAccessTokenAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.VertexAccessTokenAuth)}");
                vertexAccessToken = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.VertexAiApiKeyAuth? apiKey = default;
            if (discriminator?.Type == global::Vectara.LLMAuthDiscriminatorType.ApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAiApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAiApiKeyAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.VertexAiApiKeyAuth)}");
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.VertexAiServiceAccountAuth? serviceAccount = default;
            if (discriminator?.Type == global::Vectara.LLMAuthDiscriminatorType.ServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAiServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAiServiceAccountAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.VertexAiServiceAccountAuth)}");
                serviceAccount = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.LLMAuth(
                discriminator?.Type,
                bearer,

                header,

                oauthClientCredentials,

                bedrockStaticIam,

                bedrockApiKey,

                vertexServiceAccount,

                vertexAccessToken,

                apiKey,

                serviceAccount
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.LLMAuth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BearerAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BearerAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer!, typeInfo);
            }
            else if (value.IsHeader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.HeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.HeaderAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.HeaderAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header!, typeInfo);
            }
            else if (value.IsOauthClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.OAuthClientCredentialsAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.OAuthClientCredentialsAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.OAuthClientCredentialsAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OauthClientCredentials!, typeInfo);
            }
            else if (value.IsBedrockStaticIam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BedrockStaticIAMAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BedrockStaticIAMAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BedrockStaticIAMAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BedrockStaticIam!, typeInfo);
            }
            else if (value.IsBedrockApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BedrockApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BedrockApiKeyAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BedrockApiKeyAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BedrockApiKey!, typeInfo);
            }
            else if (value.IsVertexServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexServiceAccountAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.VertexServiceAccountAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexServiceAccount!, typeInfo);
            }
            else if (value.IsVertexAccessToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAccessTokenAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAccessTokenAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.VertexAccessTokenAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexAccessToken!, typeInfo);
            }
            else if (value.IsApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAiApiKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAiApiKeyAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.VertexAiApiKeyAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey!, typeInfo);
            }
            else if (value.IsServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.VertexAiServiceAccountAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.VertexAiServiceAccountAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.VertexAiServiceAccountAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServiceAccount!, typeInfo);
            }
        }
    }
}