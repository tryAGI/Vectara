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

            global::Vectara.UpdateSharepointSourceConfiguration? sharepoint = default;
            if (discriminator?.Type == global::Vectara.UpdatePipelineSourceDiscriminatorType.Sharepoint)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateSharepointSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateSharepointSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdateSharepointSourceConfiguration)}");
                sharepoint = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.UpdateS3SourceConfiguration? s3 = default;
            if (discriminator?.Type == global::Vectara.UpdatePipelineSourceDiscriminatorType.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateS3SourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateS3SourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdateS3SourceConfiguration)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.UpdateGoogleDriveSourceConfiguration? googleDrive = default;
            if (discriminator?.Type == global::Vectara.UpdatePipelineSourceDiscriminatorType.GoogleDrive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateGoogleDriveSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateGoogleDriveSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdateGoogleDriveSourceConfiguration)}");
                googleDrive = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.UpdateBoxSourceConfiguration? box = default;
            if (discriminator?.Type == global::Vectara.UpdatePipelineSourceDiscriminatorType.Box)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateBoxSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateBoxSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdateBoxSourceConfiguration)}");
                box = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.UpdateWolkenKbSourceConfiguration? wolkenKb = default;
            if (discriminator?.Type == global::Vectara.UpdatePipelineSourceDiscriminatorType.WolkenKb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateWolkenKbSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateWolkenKbSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdateWolkenKbSourceConfiguration)}");
                wolkenKb = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.UpdateConfluenceSourceConfiguration? confluence = default;
            if (discriminator?.Type == global::Vectara.UpdatePipelineSourceDiscriminatorType.Confluence)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateConfluenceSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateConfluenceSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdateConfluenceSourceConfiguration)}");
                confluence = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.UpdateWebSourceConfiguration? web = default;
            if (discriminator?.Type == global::Vectara.UpdatePipelineSourceDiscriminatorType.Web)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateWebSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateWebSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdateWebSourceConfiguration)}");
                web = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.UpdatePipelineSource(
                discriminator?.Type,
                sharepoint,

                s3,

                googleDrive,

                box,

                wolkenKb,

                confluence,

                web
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

            if (value.IsSharepoint)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateSharepointSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateSharepointSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateSharepointSourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sharepoint!.Value, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateS3SourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateS3SourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateS3SourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!.Value, typeInfo);
            }
            else if (value.IsGoogleDrive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateGoogleDriveSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateGoogleDriveSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateGoogleDriveSourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleDrive!.Value, typeInfo);
            }
            else if (value.IsBox)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateBoxSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateBoxSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateBoxSourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Box!.Value, typeInfo);
            }
            else if (value.IsWolkenKb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateWolkenKbSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateWolkenKbSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateWolkenKbSourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WolkenKb!.Value, typeInfo);
            }
            else if (value.IsConfluence)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateConfluenceSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateConfluenceSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateConfluenceSourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Confluence!.Value, typeInfo);
            }
            else if (value.IsWeb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateWebSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateWebSourceConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateWebSourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Web!.Value, typeInfo);
            }
        }
    }
}