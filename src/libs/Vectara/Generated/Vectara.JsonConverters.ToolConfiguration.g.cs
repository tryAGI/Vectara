#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class ToolConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.ToolConfiguration>
    {
        /// <inheritdoc />
        public override global::Vectara.ToolConfiguration Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolConfigurationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolConfigurationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ToolConfigurationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.DynamicVectaraToolConfiguration? dynamicVectara = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.DynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DynamicVectaraToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DynamicVectaraToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.DynamicVectaraToolConfiguration)}");
                dynamicVectara = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.McpToolConfiguration? mcp = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.McpToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.McpToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.McpToolConfiguration)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CorporaSearchToolConfiguration? corporaSearch = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.CorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CorporaSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CorporaSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CorporaSearchToolConfiguration)}");
                corporaSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WebSearchToolConfiguration? webSearch = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebSearchToolConfiguration)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.LambdaToolConfiguration? lambda = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.Lambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.LambdaToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.LambdaToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.LambdaToolConfiguration)}");
                lambda = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StructuredIndexingToolConfiguration? structuredIndexing = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.StructuredIndexing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredIndexingToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredIndexingToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StructuredIndexingToolConfiguration)}");
                structuredIndexing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.SubAgentToolConfiguration? subAgent = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.SubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SubAgentToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SubAgentToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SubAgentToolConfiguration)}");
                subAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ArtifactReadToolConfiguration? artifactRead = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.ArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ArtifactReadToolConfiguration)}");
                artifactRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ArtifactGrepToolConfiguration? artifactGrep = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.ArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactGrepToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactGrepToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ArtifactGrepToolConfiguration)}");
                artifactGrep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ImageReadToolConfiguration? imageRead = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ImageReadToolConfiguration)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.DocumentConversionToolConfiguration? documentConversion = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.DocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DocumentConversionToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DocumentConversionToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.DocumentConversionToolConfiguration)}");
                documentConversion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.GetDocumentTextToolConfiguration? getDocumentText = default;
            if (discriminator?.Type == global::Vectara.ToolConfigurationDiscriminatorType.GetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GetDocumentTextToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GetDocumentTextToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GetDocumentTextToolConfiguration)}");
                getDocumentText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.ToolConfiguration(
                discriminator?.Type,
                dynamicVectara,

                mcp,

                corporaSearch,

                webSearch,

                lambda,

                structuredIndexing,

                subAgent,

                artifactRead,

                artifactGrep,

                imageRead,

                documentConversion,

                getDocumentText
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.ToolConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DynamicVectaraToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DynamicVectaraToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DynamicVectaraToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVectara, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.McpToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.McpToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.McpToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsCorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CorporaSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CorporaSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CorporaSearchToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CorporaSearch, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebSearchToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeInfo);
            }
            else if (value.IsLambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.LambdaToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.LambdaToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.LambdaToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lambda, typeInfo);
            }
            else if (value.IsStructuredIndexing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredIndexingToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredIndexingToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StructuredIndexingToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StructuredIndexing, typeInfo);
            }
            else if (value.IsSubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SubAgentToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SubAgentToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SubAgentToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubAgent, typeInfo);
            }
            else if (value.IsArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ArtifactReadToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactRead, typeInfo);
            }
            else if (value.IsArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactGrepToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactGrepToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ArtifactGrepToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactGrep, typeInfo);
            }
            else if (value.IsImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ImageReadToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageRead, typeInfo);
            }
            else if (value.IsDocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DocumentConversionToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DocumentConversionToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DocumentConversionToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentConversion, typeInfo);
            }
            else if (value.IsGetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GetDocumentTextToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GetDocumentTextToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GetDocumentTextToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetDocumentText, typeInfo);
            }
        }
    }
}