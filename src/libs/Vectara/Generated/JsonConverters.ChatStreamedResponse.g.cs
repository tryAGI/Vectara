#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class ChatStreamedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.ChatStreamedResponse>
    {
        /// <inheritdoc />
        public override global::Vectara.ChatStreamedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ChatStreamedResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ChatStreamedResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ChatStreamedResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.StreamSearchResponse? streamSearch = default;
            if (discriminator?.Type == global::Vectara.ChatStreamedResponseDiscriminatorType.SearchResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamSearchResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamSearchResponse)}");
                streamSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ChatInfoResponse? info = default;
            if (discriminator?.Type == global::Vectara.ChatStreamedResponseDiscriminatorType.ChatInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ChatInfoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ChatInfoResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ChatInfoResponse)}");
                info = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StreamGenerationChunk? streamGenerationChunk = default;
            if (discriminator?.Type == global::Vectara.ChatStreamedResponseDiscriminatorType.GenerationChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamGenerationChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamGenerationChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamGenerationChunk)}");
                streamGenerationChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StreamGenerationEnd? streamGenerationEnd = default;
            if (discriminator?.Type == global::Vectara.ChatStreamedResponseDiscriminatorType.GenerationEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamGenerationEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamGenerationEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamGenerationEnd)}");
                streamGenerationEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.FactualConsistencyScore? factualConsistencyScore = default;
            if (discriminator?.Type == global::Vectara.ChatStreamedResponseDiscriminatorType.FactualConsistencyScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.FactualConsistencyScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.FactualConsistencyScore> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.FactualConsistencyScore)}");
                factualConsistencyScore = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StreamResponseEnd? streamEnd = default;
            if (discriminator?.Type == global::Vectara.ChatStreamedResponseDiscriminatorType.End)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamResponseEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamResponseEnd)}");
                streamEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.GenerationInfo? generationInfo = default;
            if (discriminator?.Type == global::Vectara.ChatStreamedResponseDiscriminatorType.GenerationInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenerationInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenerationInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GenerationInfo)}");
                generationInfo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StreamError? streamError = default;
            if (discriminator?.Type == global::Vectara.ChatStreamedResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamError)}");
                streamError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Vectara.ChatStreamedResponse(
                discriminator?.Type,
                streamSearch,
                info,
                streamGenerationChunk,
                streamGenerationEnd,
                factualConsistencyScore,
                streamEnd,
                generationInfo,
                streamError
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.ChatStreamedResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamSearchResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamSearchResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamSearch, typeInfo);
            }
            else if (value.IsInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ChatInfoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ChatInfoResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ChatInfoResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Info, typeInfo);
            }
            else if (value.IsStreamGenerationChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamGenerationChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamGenerationChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamGenerationChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamGenerationChunk, typeInfo);
            }
            else if (value.IsStreamGenerationEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamGenerationEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamGenerationEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamGenerationEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamGenerationEnd, typeInfo);
            }
            else if (value.IsFactualConsistencyScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.FactualConsistencyScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.FactualConsistencyScore?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.FactualConsistencyScore).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FactualConsistencyScore, typeInfo);
            }
            else if (value.IsStreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamResponseEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamResponseEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEnd, typeInfo);
            }
            else if (value.IsGenerationInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenerationInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenerationInfo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GenerationInfo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerationInfo, typeInfo);
            }
            else if (value.IsStreamError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamError, typeInfo);
            }
        }
    }
}