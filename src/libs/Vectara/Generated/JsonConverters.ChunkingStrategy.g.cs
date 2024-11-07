#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class ChunkingStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.ChunkingStrategy>
    {
        /// <inheritdoc />
        public override global::Vectara.ChunkingStrategy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ChunkingStrategyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ChunkingStrategyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ChunkingStrategyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.MaxCharsChunkingStrategy? maxCharsChunkingStrategy = default;
            if (discriminator?.Type == global::Vectara.ChunkingStrategyDiscriminatorType.MaxCharsChunkingStrategy)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MaxCharsChunkingStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MaxCharsChunkingStrategy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.MaxCharsChunkingStrategy)}");
                maxCharsChunkingStrategy = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Vectara.ChunkingStrategy(
                discriminator?.Type,
                maxCharsChunkingStrategy
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.ChunkingStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMaxCharsChunkingStrategy)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MaxCharsChunkingStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MaxCharsChunkingStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.MaxCharsChunkingStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxCharsChunkingStrategy, typeInfo);
            }
        }
    }
}