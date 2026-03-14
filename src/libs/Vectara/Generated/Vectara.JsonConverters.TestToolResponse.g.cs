#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class TestToolResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.TestToolResponse>
    {
        /// <inheritdoc />
        public override global::Vectara.TestToolResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TestToolResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TestToolResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.TestToolResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.TestToolSuccessResponse? success = default;
            if (discriminator?.Type == global::Vectara.TestToolResponseDiscriminatorType.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TestToolSuccessResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TestToolSuccessResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.TestToolSuccessResponse)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.TestToolErrorResponse? error = default;
            if (discriminator?.Type == global::Vectara.TestToolResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TestToolErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TestToolErrorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.TestToolErrorResponse)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.TestToolResponse(
                discriminator?.Type,
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.TestToolResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TestToolSuccessResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TestToolSuccessResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.TestToolSuccessResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TestToolErrorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TestToolErrorResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.TestToolErrorResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
        }
    }
}