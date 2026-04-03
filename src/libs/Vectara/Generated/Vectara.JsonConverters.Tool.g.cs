#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.Tool>
    {
        /// <inheritdoc />
        public override global::Vectara.Tool Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.DynamicVectaraTool? dynamicVectara = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.DynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DynamicVectaraTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DynamicVectaraTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.DynamicVectaraTool)}");
                dynamicVectara = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.McpTool? mcp = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.McpTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.McpTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.McpTool)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CorporaSearchTool? corporaSearch = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.CorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CorporaSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CorporaSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CorporaSearchTool)}");
                corporaSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WebSearchTool? webSearch = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebSearchTool)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WebGetTool? webGet = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.WebGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebGetTool)}");
                webGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.LambdaTool? lambda = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.Lambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.LambdaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.LambdaTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.LambdaTool)}");
                lambda = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.SubAgentTool? subAgent = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.SubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SubAgentTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SubAgentTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SubAgentTool)}");
                subAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ArtifactCreateTool? artifactCreate = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.ArtifactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactCreateTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ArtifactCreateTool)}");
                artifactCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ArtifactReadTool? artifactRead = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.ArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactReadTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactReadTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ArtifactReadTool)}");
                artifactRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ArtifactGrepTool? artifactGrep = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.ArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactGrepTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactGrepTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ArtifactGrepTool)}");
                artifactGrep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ImageReadTool? imageRead = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ImageReadTool)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.DocumentConversionTool? documentConversion = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.DocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DocumentConversionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DocumentConversionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.DocumentConversionTool)}");
                documentConversion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.GetDocumentTextTool? getDocumentText = default;
            if (discriminator?.Type == global::Vectara.ToolDiscriminatorType.GetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GetDocumentTextTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GetDocumentTextTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GetDocumentTextTool)}");
                getDocumentText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.Tool(
                discriminator?.Type,
                dynamicVectara,

                mcp,

                corporaSearch,

                webSearch,

                webGet,

                lambda,

                subAgent,

                artifactCreate,

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
            global::Vectara.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDynamicVectara)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DynamicVectaraTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DynamicVectaraTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DynamicVectaraTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVectara!.Value, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.McpTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.McpTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.McpTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!.Value, typeInfo);
            }
            else if (value.IsCorporaSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CorporaSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CorporaSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CorporaSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CorporaSearch!.Value, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch!.Value, typeInfo);
            }
            else if (value.IsWebGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebGetTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebGet!.Value, typeInfo);
            }
            else if (value.IsLambda)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.LambdaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.LambdaTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.LambdaTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lambda!.Value, typeInfo);
            }
            else if (value.IsSubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SubAgentTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SubAgentTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SubAgentTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubAgent!.Value, typeInfo);
            }
            else if (value.IsArtifactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactCreateTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ArtifactCreateTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactCreate!.Value, typeInfo);
            }
            else if (value.IsArtifactRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactReadTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactReadTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ArtifactReadTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactRead!.Value, typeInfo);
            }
            else if (value.IsArtifactGrep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactGrepTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactGrepTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ArtifactGrepTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactGrep!.Value, typeInfo);
            }
            else if (value.IsImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ImageReadTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageRead!.Value, typeInfo);
            }
            else if (value.IsDocumentConversion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DocumentConversionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DocumentConversionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DocumentConversionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentConversion!.Value, typeInfo);
            }
            else if (value.IsGetDocumentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GetDocumentTextTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GetDocumentTextTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GetDocumentTextTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetDocumentText!.Value, typeInfo);
            }
        }
    }
}