#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class CreateInputRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CreateInputRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.CreateInputRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateInputRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateInputRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateInputRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CreateInputMessageRequest? inputMessage = default;
            if (discriminator?.Type == global::Vectara.CreateInputRequestDiscriminatorType.InputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateInputMessageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateInputMessageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateInputMessageRequest)}");
                inputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CreateInterruptRequest? interrupt = default;
            if (discriminator?.Type == global::Vectara.CreateInputRequestDiscriminatorType.Interrupt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateInterruptRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateInterruptRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateInterruptRequest)}");
                interrupt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CreateCompactRequest? compact = default;
            if (discriminator?.Type == global::Vectara.CreateInputRequestDiscriminatorType.Compact)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateCompactRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateCompactRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateCompactRequest)}");
                compact = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.CreateInputRequest(
                discriminator?.Type,
                inputMessage,

                interrupt,

                compact
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.CreateInputRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateInputMessageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateInputMessageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateInputMessageRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessage!.Value, typeInfo);
            }
            else if (value.IsInterrupt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateInterruptRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateInterruptRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateInterruptRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Interrupt!.Value, typeInfo);
            }
            else if (value.IsCompact)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateCompactRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateCompactRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateCompactRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compact!.Value, typeInfo);
            }
        }
    }
}