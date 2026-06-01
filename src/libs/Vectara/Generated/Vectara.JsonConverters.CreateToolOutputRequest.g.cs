#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class CreateToolOutputRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CreateToolOutputRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.CreateToolOutputRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateToolOutputRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateToolOutputRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateToolOutputRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CreateToolOutputSuccess? success = default;
            if (discriminator?.Type == global::Vectara.CreateToolOutputRequestDiscriminatorType.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateToolOutputSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateToolOutputSuccess> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateToolOutputSuccess)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CreateToolOutputError? error = default;
            if (discriminator?.Type == global::Vectara.CreateToolOutputRequestDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateToolOutputError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateToolOutputError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateToolOutputError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.CreateToolOutputRequest(
                discriminator?.Type,
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.CreateToolOutputRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateToolOutputSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateToolOutputSuccess> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateToolOutputSuccess).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!.Value, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateToolOutputError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateToolOutputError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateToolOutputError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!.Value, typeInfo);
            }
        }
    }
}