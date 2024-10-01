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

            var
            readerCopy = reader;
            global::Vectara.StreamSearchResponse? streamSearch = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamSearchResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamSearchResponse).Name}");
                streamSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Vectara.ChatInfoResponse? info = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ChatInfoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ChatInfoResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ChatInfoResponse).Name}");
                info = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Vectara.StreamGenerationChunk? streamGenerationChunk = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamGenerationChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamGenerationChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamGenerationChunk).Name}");
                streamGenerationChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Vectara.StreamGenerationEnd? streamGenerationEnd = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamGenerationEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamGenerationEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamGenerationEnd).Name}");
                streamGenerationEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Vectara.FactualConsistencyScore? factualConsistencyScore = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.FactualConsistencyScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.FactualConsistencyScore> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.FactualConsistencyScore).Name}");
                factualConsistencyScore = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Vectara.StreamResponseEnd? streamEnd = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamResponseEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamResponseEnd).Name}");
                streamEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Vectara.GenerationInfo? generationInfo = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenerationInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenerationInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GenerationInfo).Name}");
                generationInfo = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Vectara.StreamError? streamError = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamError).Name}");
                streamError = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Vectara.ChatStreamedResponse(
                streamSearch,
                info,
                streamGenerationChunk,
                streamGenerationEnd,
                factualConsistencyScore,
                streamEnd,
                generationInfo,
                streamError
                );

            if (streamSearch != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamSearchResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamSearchResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (info != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ChatInfoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ChatInfoResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ChatInfoResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (streamGenerationChunk != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamGenerationChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamGenerationChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamGenerationChunk).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (streamGenerationEnd != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamGenerationEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamGenerationEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamGenerationEnd).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (factualConsistencyScore != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.FactualConsistencyScore), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.FactualConsistencyScore> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.FactualConsistencyScore).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (streamEnd != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamResponseEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamResponseEnd).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (generationInfo != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenerationInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenerationInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GenerationInfo).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (streamError != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamError).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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