#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class AgentToolConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentToolConfiguration>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentToolConfiguration Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentToolConfigurationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentToolConfigurationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentToolConfigurationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.InlineDynamicVectaraToolConfiguration? dynamicVectara = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.DynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineDynamicVectaraToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineDynamicVectaraToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineDynamicVectaraToolConfiguration)}");
                dynamicVectara = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineMcpToolConfiguration? mcp = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineMcpToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineMcpToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineMcpToolConfiguration)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineCorporaSearchToolConfiguration? corporaSearch = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.CorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineCorporaSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineCorporaSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineCorporaSearchToolConfiguration)}");
                corporaSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineWebSearchToolConfiguration? webSearch = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineWebSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineWebSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineWebSearchToolConfiguration)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineWebGetToolConfiguration? webGet = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.WebGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineWebGetToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineWebGetToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineWebGetToolConfiguration)}");
                webGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineLambdaToolConfiguration? lambda = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.Lambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineLambdaToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineLambdaToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineLambdaToolConfiguration)}");
                lambda = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineSubAgentToolConfiguration? subAgent = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.SubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineSubAgentToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineSubAgentToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineSubAgentToolConfiguration)}");
                subAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineArtifactReadToolConfiguration? artifactRead = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.ArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineArtifactReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineArtifactReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineArtifactReadToolConfiguration)}");
                artifactRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineArtifactGrepToolConfiguration? artifactGrep = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.ArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineArtifactGrepToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineArtifactGrepToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineArtifactGrepToolConfiguration)}");
                artifactGrep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineImageReadToolConfiguration? imageRead = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineImageReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineImageReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineImageReadToolConfiguration)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineDocumentConversionToolConfiguration? documentConversion = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.DocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineDocumentConversionToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineDocumentConversionToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineDocumentConversionToolConfiguration)}");
                documentConversion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.InlineGetDocumentTextToolConfiguration? getDocumentText = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.GetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineGetDocumentTextToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineGetDocumentTextToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InlineGetDocumentTextToolConfiguration)}");
                getDocumentText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AgentToolConfiguration(
                discriminator?.Type,
                dynamicVectara,

                mcp,

                corporaSearch,

                webSearch,

                webGet,

                lambda,

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
            global::Vectara.AgentToolConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineDynamicVectaraToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineDynamicVectaraToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineDynamicVectaraToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVectara!, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineMcpToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineMcpToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineMcpToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!, typeInfo);
            }
            else if (value.IsCorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineCorporaSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineCorporaSearchToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineCorporaSearchToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CorporaSearch!, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineWebSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineWebSearchToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineWebSearchToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch!, typeInfo);
            }
            else if (value.IsWebGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineWebGetToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineWebGetToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineWebGetToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebGet!, typeInfo);
            }
            else if (value.IsLambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineLambdaToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineLambdaToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineLambdaToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lambda!, typeInfo);
            }
            else if (value.IsSubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineSubAgentToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineSubAgentToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineSubAgentToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubAgent!, typeInfo);
            }
            else if (value.IsArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineArtifactReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineArtifactReadToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineArtifactReadToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactRead!, typeInfo);
            }
            else if (value.IsArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineArtifactGrepToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineArtifactGrepToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineArtifactGrepToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactGrep!, typeInfo);
            }
            else if (value.IsImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineImageReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineImageReadToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineImageReadToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageRead!, typeInfo);
            }
            else if (value.IsDocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineDocumentConversionToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineDocumentConversionToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineDocumentConversionToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentConversion!, typeInfo);
            }
            else if (value.IsGetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InlineGetDocumentTextToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InlineGetDocumentTextToolConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InlineGetDocumentTextToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetDocumentText!, typeInfo);
            }
        }
    }
}