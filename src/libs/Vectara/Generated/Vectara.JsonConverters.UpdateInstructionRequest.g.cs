#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class UpdateInstructionRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.UpdateInstructionRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.UpdateInstructionRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateInstructionRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateInstructionRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdateInstructionRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.UpdateInitialInstructionRequest? initial = default;
            if (discriminator?.Type == global::Vectara.UpdateInstructionRequestDiscriminatorType.Initial)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateInitialInstructionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateInitialInstructionRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UpdateInitialInstructionRequest)}");
                initial = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.UpdateInstructionRequest(
                discriminator?.Type,
                initial
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.UpdateInstructionRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInitial)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateInitialInstructionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateInitialInstructionRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateInitialInstructionRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Initial, typeInfo);
            }
        }
    }
}