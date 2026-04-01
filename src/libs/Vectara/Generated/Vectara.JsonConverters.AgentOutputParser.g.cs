#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class AgentOutputParserJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentOutputParser>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentOutputParser Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentOutputParserDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentOutputParserDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentOutputParserDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.DefaultOutputParser? @default = default;
            if (discriminator?.Type == global::Vectara.AgentOutputParserDiscriminatorType.Default)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DefaultOutputParser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DefaultOutputParser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.DefaultOutputParser)}");
                @default = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StructuredOutputParser? structured = default;
            if (discriminator?.Type == global::Vectara.AgentOutputParserDiscriminatorType.Structured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredOutputParser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredOutputParser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StructuredOutputParser)}");
                structured = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AgentOutputParser(
                discriminator?.Type,
                @default,

                structured
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AgentOutputParser value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDefault)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DefaultOutputParser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DefaultOutputParser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DefaultOutputParser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Default!, typeInfo);
            }
            else if (value.IsStructured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredOutputParser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredOutputParser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StructuredOutputParser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Structured!, typeInfo);
            }
        }
    }
}