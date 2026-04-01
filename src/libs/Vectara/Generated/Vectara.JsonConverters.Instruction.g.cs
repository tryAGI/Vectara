#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class InstructionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.Instruction>
    {
        /// <inheritdoc />
        public override global::Vectara.Instruction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InstructionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InstructionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InstructionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.InitialInstruction? initial = default;
            if (discriminator?.Type == global::Vectara.InstructionDiscriminatorType.Initial)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InitialInstruction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InitialInstruction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InitialInstruction)}");
                initial = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.Instruction(
                discriminator?.Type,
                initial
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.Instruction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInitial)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InitialInstruction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InitialInstruction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InitialInstruction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Initial!, typeInfo);
            }
        }
    }
}