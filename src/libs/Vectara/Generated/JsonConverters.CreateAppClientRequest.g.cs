#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class CreateAppClientRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CreateAppClientRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.CreateAppClientRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Vectara.CreateClientCredentialsRequest? credentials = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateClientCredentialsRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateClientCredentialsRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateClientCredentialsRequest).Name}");
                credentials = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Vectara.CreateAppClientRequest(
                credentials
                );

            if (credentials != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateClientCredentialsRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateClientCredentialsRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateClientCredentialsRequest).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.CreateAppClientRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateClientCredentialsRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateClientCredentialsRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateClientCredentialsRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Credentials, typeInfo);
            }
        }
    }
}