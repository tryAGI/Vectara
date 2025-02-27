#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class RemoteAuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.RemoteAuth>
    {
        /// <inheritdoc />
        public override global::Vectara.RemoteAuth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RemoteAuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RemoteAuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.RemoteAuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.BearerAuth? bearer = default;
            if (discriminator?.Type == global::Vectara.RemoteAuthDiscriminatorType.Bearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BearerAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BearerAuth)}");
                bearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.HeaderAuth? header = default;
            if (discriminator?.Type == global::Vectara.RemoteAuthDiscriminatorType.Header)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.HeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.HeaderAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.HeaderAuth)}");
                header = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Vectara.RemoteAuth(
                discriminator?.Type,
                bearer,
                header
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.RemoteAuth value,
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
        }
    }
}