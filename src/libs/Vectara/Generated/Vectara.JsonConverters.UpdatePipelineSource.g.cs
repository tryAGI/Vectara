#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class UpdatePipelineSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.UpdatePipelineSource>
    {
        /// <inheritdoc />
        public override global::Vectara.UpdatePipelineSource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdatePipelineSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdatePipelineSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdatePipelineSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.UpdateS3SourceConfiguration? s3 = default;
            if (discriminator?.Type == global::Vectara.UpdatePipelineSourceDiscriminatorType.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateS3SourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateS3SourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdateS3SourceConfiguration)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.UpdatePipelineSource(
                discriminator?.Type,
                s3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.UpdatePipelineSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateS3SourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateS3SourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateS3SourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!.Value, typeInfo);
            }
        }
    }
}