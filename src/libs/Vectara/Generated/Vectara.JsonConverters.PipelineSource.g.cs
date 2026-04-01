#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class PipelineSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.PipelineSource>
    {
        /// <inheritdoc />
        public override global::Vectara.PipelineSource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PipelineSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PipelineSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.PipelineSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.SharepointSourceConfiguration? sharepoint = default;
            if (discriminator?.Type == global::Vectara.PipelineSourceDiscriminatorType.Sharepoint)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SharepointSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SharepointSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SharepointSourceConfiguration)}");
                sharepoint = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.DocumentumSourceConfiguration? documentum = default;
            if (discriminator?.Type == global::Vectara.PipelineSourceDiscriminatorType.Documentum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DocumentumSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DocumentumSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.DocumentumSourceConfiguration)}");
                documentum = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.S3SourceConfiguration? s3 = default;
            if (discriminator?.Type == global::Vectara.PipelineSourceDiscriminatorType.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.S3SourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.S3SourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.S3SourceConfiguration)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.PipelineSource(
                discriminator?.Type,
                sharepoint,

                documentum,

                s3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.PipelineSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSharepoint)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SharepointSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SharepointSourceConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SharepointSourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sharepoint!, typeInfo);
            }
            else if (value.IsDocumentum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DocumentumSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DocumentumSourceConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DocumentumSourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Documentum!, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.S3SourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.S3SourceConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.S3SourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!, typeInfo);
            }
        }
    }
}