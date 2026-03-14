#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class AgentStepInstructionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentStepInstruction>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentStepInstruction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentStepInstructionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentStepInstructionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentStepInstructionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.ReferenceInstruction? reference = default;
            if (discriminator?.Type == global::Vectara.AgentStepInstructionDiscriminatorType.Reference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ReferenceInstruction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ReferenceInstruction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ReferenceInstruction)}");
                reference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineInstruction? inline = default;
            if (discriminator?.Type == global::Vectara.AgentStepInstructionDiscriminatorType.Inline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineInstruction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineInstruction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineInstruction)}");
                inline = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AgentStepInstruction(
                discriminator?.Type,
                reference,

                inline
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AgentStepInstruction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ReferenceInstruction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ReferenceInstruction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ReferenceInstruction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reference, typeInfo);
            }
            else if (value.IsInline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineInstruction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineInstruction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineInstruction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Inline, typeInfo);
            }
        }
    }
}