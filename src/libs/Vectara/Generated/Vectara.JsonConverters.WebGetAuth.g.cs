#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class WebGetAuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.WebGetAuth>
    {
        /// <inheritdoc />
        public override global::Vectara.WebGetAuth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetAuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetAuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebGetAuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.WebGetNoAuth? none = default;
            if (discriminator?.Type == global::Vectara.WebGetAuthDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetNoAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetNoAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebGetNoAuth)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WebGetBearerAuth? bearer = default;
            if (discriminator?.Type == global::Vectara.WebGetAuthDiscriminatorType.Bearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetBearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetBearerAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebGetBearerAuth)}");
                bearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WebGetHeaderAuth? header = default;
            if (discriminator?.Type == global::Vectara.WebGetAuthDiscriminatorType.Header)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetHeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetHeaderAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebGetHeaderAuth)}");
                header = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WebGetOAuthClientCredentialsAuth? oauthClientCredentials = default;
            if (discriminator?.Type == global::Vectara.WebGetAuthDiscriminatorType.OauthClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetOAuthClientCredentialsAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetOAuthClientCredentialsAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebGetOAuthClientCredentialsAuth)}");
                oauthClientCredentials = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WebGetOAuthRefreshTokenAuth? oauthRefreshToken = default;
            if (discriminator?.Type == global::Vectara.WebGetAuthDiscriminatorType.OauthRefreshToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetOAuthRefreshTokenAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetOAuthRefreshTokenAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebGetOAuthRefreshTokenAuth)}");
                oauthRefreshToken = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.WebGetAuth(
                discriminator?.Type,
                none,

                bearer,

                header,

                oauthClientCredentials,

                oauthRefreshToken
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.WebGetAuth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetNoAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetNoAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebGetNoAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None!, typeInfo);
            }
            else if (value.IsBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetBearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetBearerAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebGetBearerAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer!, typeInfo);
            }
            else if (value.IsHeader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetHeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetHeaderAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebGetHeaderAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header!, typeInfo);
            }
            else if (value.IsOauthClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetOAuthClientCredentialsAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetOAuthClientCredentialsAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebGetOAuthClientCredentialsAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OauthClientCredentials!, typeInfo);
            }
            else if (value.IsOauthRefreshToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetOAuthRefreshTokenAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetOAuthRefreshTokenAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebGetOAuthRefreshTokenAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OauthRefreshToken!, typeInfo);
            }
        }
    }
}