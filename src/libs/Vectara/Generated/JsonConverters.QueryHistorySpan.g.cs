#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class QueryHistorySpanJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.QueryHistorySpan>
    {
        /// <inheritdoc />
        public override global::Vectara.QueryHistorySpan Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.QueryHistorySpanDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.QueryHistorySpanDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.QueryHistorySpanDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.RephraseSpan? rephrase = default;
            if (discriminator?.Type == global::Vectara.QueryHistorySpanDiscriminatorType.Rephrase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RephraseSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RephraseSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.RephraseSpan)}");
                rephrase = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.SearchSpan? search = default;
            if (discriminator?.Type == global::Vectara.QueryHistorySpanDiscriminatorType.Search)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SearchSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SearchSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SearchSpan)}");
                search = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.RerankSpan? rerank = default;
            if (discriminator?.Type == global::Vectara.QueryHistorySpanDiscriminatorType.Rerank)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RerankSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RerankSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.RerankSpan)}");
                rerank = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.GenerationSpan? generation = default;
            if (discriminator?.Type == global::Vectara.QueryHistorySpanDiscriminatorType.Generation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenerationSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenerationSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GenerationSpan)}");
                generation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.FactualConsistencyScoreSpan? fcs = default;
            if (discriminator?.Type == global::Vectara.QueryHistorySpanDiscriminatorType.Fcs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.FactualConsistencyScoreSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.FactualConsistencyScoreSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.FactualConsistencyScoreSpan)}");
                fcs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.RewrittenQuerySpan? rewrittenQuery = default;
            if (discriminator?.Type == global::Vectara.QueryHistorySpanDiscriminatorType.RewrittenQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RewrittenQuerySpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RewrittenQuerySpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.RewrittenQuerySpan)}");
                rewrittenQuery = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Vectara.QueryHistorySpan(
                discriminator?.Type,
                rephrase,
                search,
                rerank,
                generation,
                fcs,
                rewrittenQuery
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.QueryHistorySpan value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRephrase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RephraseSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RephraseSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.RephraseSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rephrase, typeInfo);
            }
            else if (value.IsSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SearchSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SearchSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SearchSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Search, typeInfo);
            }
            else if (value.IsRerank)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RerankSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RerankSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.RerankSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rerank, typeInfo);
            }
            else if (value.IsGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenerationSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenerationSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GenerationSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Generation, typeInfo);
            }
            else if (value.IsFcs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.FactualConsistencyScoreSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.FactualConsistencyScoreSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.FactualConsistencyScoreSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Fcs, typeInfo);
            }
            else if (value.IsRewrittenQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RewrittenQuerySpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RewrittenQuerySpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.RewrittenQuerySpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RewrittenQuery, typeInfo);
            }
        }
    }
}