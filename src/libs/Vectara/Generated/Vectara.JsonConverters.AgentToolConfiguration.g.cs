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

            global::Vectara.ToolConfigurationReference? reference = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.Reference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolConfigurationReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolConfigurationReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ToolConfigurationReference)}");
                reference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.DynamicVectaraToolConfiguration? dynamicVectara = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.DynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DynamicVectaraToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DynamicVectaraToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.DynamicVectaraToolConfiguration)}");
                dynamicVectara = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.McpToolConfiguration? mcp = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.McpToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.McpToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.McpToolConfiguration)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CorporaSearchToolConfiguration? corporaSearch = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.CorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CorporaSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CorporaSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CorporaSearchToolConfiguration)}");
                corporaSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WebSearchToolConfiguration? webSearch = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebSearchToolConfiguration)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WebGetToolConfiguration? webGet = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.WebGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebGetToolConfiguration)}");
                webGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.LambdaToolConfiguration? lambda = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.Lambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.LambdaToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.LambdaToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.LambdaToolConfiguration)}");
                lambda = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ClientToolConfiguration? client = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ClientToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ClientToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ClientToolConfiguration)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.SubAgentToolConfiguration? subAgent = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.SubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SubAgentToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SubAgentToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SubAgentToolConfiguration)}");
                subAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ArtifactReadToolConfiguration? artifactRead = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.ArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ArtifactReadToolConfiguration)}");
                artifactRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ArtifactGrepToolConfiguration? artifactGrep = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.ArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactGrepToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactGrepToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ArtifactGrepToolConfiguration)}");
                artifactGrep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ImageReadToolConfiguration? imageRead = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ImageReadToolConfiguration)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.DocumentConversionToolConfiguration? documentConversion = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.DocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DocumentConversionToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DocumentConversionToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.DocumentConversionToolConfiguration)}");
                documentConversion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.GetDocumentTextToolConfiguration? getDocumentText = default;
            if (discriminator?.Type == global::Vectara.AgentToolConfigurationDiscriminatorType.GetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GetDocumentTextToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GetDocumentTextToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GetDocumentTextToolConfiguration)}");
                getDocumentText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AgentToolConfiguration(
                discriminator?.Type,
                reference,

                dynamicVectara,

                mcp,

                corporaSearch,

                webSearch,

                webGet,

                lambda,

                client,

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

            if (value.IsReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolConfigurationReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolConfigurationReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ToolConfigurationReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reference!.Value, typeInfo);
            }
            else if (value.IsDynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DynamicVectaraToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DynamicVectaraToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DynamicVectaraToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVectara!.Value, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.McpToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.McpToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.McpToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!.Value, typeInfo);
            }
            else if (value.IsCorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CorporaSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CorporaSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CorporaSearchToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CorporaSearch!.Value, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebSearchToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebSearchToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebSearchToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch!.Value, typeInfo);
            }
            else if (value.IsWebGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebGetToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebGet!.Value, typeInfo);
            }
            else if (value.IsLambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.LambdaToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.LambdaToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.LambdaToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lambda!.Value, typeInfo);
            }
            else if (value.IsClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ClientToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ClientToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ClientToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client!.Value, typeInfo);
            }
            else if (value.IsSubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SubAgentToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SubAgentToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SubAgentToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubAgent!.Value, typeInfo);
            }
            else if (value.IsArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ArtifactReadToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactRead!.Value, typeInfo);
            }
            else if (value.IsArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactGrepToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactGrepToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ArtifactGrepToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactGrep!.Value, typeInfo);
            }
            else if (value.IsImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ImageReadToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageRead!.Value, typeInfo);
            }
            else if (value.IsDocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DocumentConversionToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DocumentConversionToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DocumentConversionToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentConversion!.Value, typeInfo);
            }
            else if (value.IsGetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GetDocumentTextToolConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GetDocumentTextToolConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GetDocumentTextToolConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetDocumentText!.Value, typeInfo);
            }
        }
    }
}