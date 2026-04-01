#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class BulkDeleteDocumentsResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.BulkDeleteDocumentsResponse>
    {
        /// <inheritdoc />
        public override global::Vectara.BulkDeleteDocumentsResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BulkDeleteDocumentsResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BulkDeleteDocumentsResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BulkDeleteDocumentsResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.BulkDeleteAsyncResponse? async = default;
            if (discriminator?.ResponseType == global::Vectara.BulkDeleteDocumentsResponseDiscriminatorResponseType.Async)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BulkDeleteAsyncResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BulkDeleteAsyncResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BulkDeleteAsyncResponse)}");
                async = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.BulkDeleteSyncSuccessResponse? success = default;
            if (discriminator?.ResponseType == global::Vectara.BulkDeleteDocumentsResponseDiscriminatorResponseType.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BulkDeleteSyncSuccessResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BulkDeleteSyncSuccessResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.BulkDeleteSyncSuccessResponse)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.BulkDeleteDocumentsResponse(
                discriminator?.ResponseType,
                async,

                success
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.BulkDeleteDocumentsResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAsync)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BulkDeleteAsyncResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BulkDeleteAsyncResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BulkDeleteAsyncResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Async!, typeInfo);
            }
            else if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BulkDeleteSyncSuccessResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BulkDeleteSyncSuccessResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BulkDeleteSyncSuccessResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!, typeInfo);
            }
        }
    }
}