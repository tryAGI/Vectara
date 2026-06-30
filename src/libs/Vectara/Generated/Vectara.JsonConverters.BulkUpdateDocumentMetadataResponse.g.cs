#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class BulkUpdateDocumentMetadataResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.BulkUpdateDocumentMetadataResponse>
    {
        /// <inheritdoc />
        public override global::Vectara.BulkUpdateDocumentMetadataResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.BulkUpdateDocumentMetadataAsyncResponse? async = default;
            if (discriminator?.Type == global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType.Async)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BulkUpdateDocumentMetadataAsyncResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BulkUpdateDocumentMetadataAsyncResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BulkUpdateDocumentMetadataAsyncResponse)}");
                async = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse? success = default;
            if (discriminator?.Type == global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.BulkUpdateDocumentMetadataResponse(
                discriminator?.Type,
                async,

                success
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.BulkUpdateDocumentMetadataResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAsync)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BulkUpdateDocumentMetadataAsyncResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BulkUpdateDocumentMetadataAsyncResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BulkUpdateDocumentMetadataAsyncResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Async!.Value, typeInfo);
            }
            else if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!.Value, typeInfo);
            }
        }
    }
}