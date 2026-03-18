#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable tool configuration that stores user-defined argument overrides and settings for a specific tool.
    /// </summary>
    public readonly partial struct ToolConfiguration : global::System.IEquatable<ToolConfiguration>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ToolConfigurationDiscriminatorType? Type { get; }

        /// <summary>
        /// A configuration for built-in Vectara tools that have implementations within the platform but do not have a dedicated configuration type schema. Use the List Tools endpoint to discover available tools and obtain the `tool_id` required when creating this configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DynamicVectaraToolConfiguration? DynamicVectara { get; init; }
#else
        public global::Vectara.DynamicVectaraToolConfiguration? DynamicVectara { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVectara))]
#endif
        public bool IsDynamicVectara => DynamicVectara != null;

        /// <summary>
        /// A reusable configuration for an MCP tool that stores predefined argument overrides and settings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.McpToolConfiguration? Mcp { get; init; }
#else
        public global::Vectara.McpToolConfiguration? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// A reusable configuration for a corpora search tool that stores predefined search parameters and overrides.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CorporaSearchToolConfiguration? CorporaSearch { get; init; }
#else
        public global::Vectara.CorporaSearchToolConfiguration? CorporaSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CorporaSearch))]
#endif
        public bool IsCorporaSearch => CorporaSearch != null;

        /// <summary>
        /// A reusable configuration for a web search tool that stores predefined search parameters and settings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebSearchToolConfiguration? WebSearch { get; init; }
#else
        public global::Vectara.WebSearchToolConfiguration? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        /// A reusable configuration for a Lambda tool that executes user-defined functions in a sandboxed environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.LambdaToolConfiguration? Lambda { get; init; }
#else
        public global::Vectara.LambdaToolConfiguration? Lambda { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lambda))]
#endif
        public bool IsLambda => Lambda != null;

        /// <summary>
        /// A reusable configuration for a structured indexing tool that stores predefined indexing parameters for indexing documents into the Vectara platform.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StructuredIndexingToolConfiguration? StructuredIndexing { get; init; }
#else
        public global::Vectara.StructuredIndexingToolConfiguration? StructuredIndexing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StructuredIndexing))]
#endif
        public bool IsStructuredIndexing => StructuredIndexing != null;

        /// <summary>
        /// A reusable configuration for a sub-agent tool that invokes specialized agents for complex tasks.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SubAgentToolConfiguration? SubAgent { get; init; }
#else
        public global::Vectara.SubAgentToolConfiguration? SubAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubAgent))]
#endif
        public bool IsSubAgent => SubAgent != null;

        /// <summary>
        /// A reusable configuration for an artifact read tool that reads artifacts from the session workspace.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ArtifactReadToolConfiguration? ArtifactRead { get; init; }
#else
        public global::Vectara.ArtifactReadToolConfiguration? ArtifactRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactRead))]
#endif
        public bool IsArtifactRead => ArtifactRead != null;

        /// <summary>
        /// A reusable configuration for an artifact grep tool that searches through artifact content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ArtifactGrepToolConfiguration? ArtifactGrep { get; init; }
#else
        public global::Vectara.ArtifactGrepToolConfiguration? ArtifactGrep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactGrep))]
#endif
        public bool IsArtifactGrep => ArtifactGrep != null;

        /// <summary>
        /// A reusable configuration for an image read tool that loads images into the conversation context.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ImageReadToolConfiguration? ImageRead { get; init; }
#else
        public global::Vectara.ImageReadToolConfiguration? ImageRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageRead))]
#endif
        public bool IsImageRead => ImageRead != null;

        /// <summary>
        /// A reusable configuration for a document conversion tool that converts document artifacts to various formats.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DocumentConversionToolConfiguration? DocumentConversion { get; init; }
#else
        public global::Vectara.DocumentConversionToolConfiguration? DocumentConversion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentConversion))]
#endif
        public bool IsDocumentConversion => DocumentConversion != null;

        /// <summary>
        /// A reusable configuration for a get document text tool that fetches document text content from a corpus.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GetDocumentTextToolConfiguration? GetDocumentText { get; init; }
#else
        public global::Vectara.GetDocumentTextToolConfiguration? GetDocumentText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetDocumentText))]
#endif
        public bool IsGetDocumentText => GetDocumentText != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.DynamicVectaraToolConfiguration value) => new ToolConfiguration((global::Vectara.DynamicVectaraToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DynamicVectaraToolConfiguration?(ToolConfiguration @this) => @this.DynamicVectara;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.DynamicVectaraToolConfiguration? value)
        {
            DynamicVectara = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.McpToolConfiguration value) => new ToolConfiguration((global::Vectara.McpToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.McpToolConfiguration?(ToolConfiguration @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.McpToolConfiguration? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.CorporaSearchToolConfiguration value) => new ToolConfiguration((global::Vectara.CorporaSearchToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CorporaSearchToolConfiguration?(ToolConfiguration @this) => @this.CorporaSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.CorporaSearchToolConfiguration? value)
        {
            CorporaSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.WebSearchToolConfiguration value) => new ToolConfiguration((global::Vectara.WebSearchToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WebSearchToolConfiguration?(ToolConfiguration @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.WebSearchToolConfiguration? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.LambdaToolConfiguration value) => new ToolConfiguration((global::Vectara.LambdaToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.LambdaToolConfiguration?(ToolConfiguration @this) => @this.Lambda;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.LambdaToolConfiguration? value)
        {
            Lambda = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.StructuredIndexingToolConfiguration value) => new ToolConfiguration((global::Vectara.StructuredIndexingToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StructuredIndexingToolConfiguration?(ToolConfiguration @this) => @this.StructuredIndexing;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.StructuredIndexingToolConfiguration? value)
        {
            StructuredIndexing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.SubAgentToolConfiguration value) => new ToolConfiguration((global::Vectara.SubAgentToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SubAgentToolConfiguration?(ToolConfiguration @this) => @this.SubAgent;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.SubAgentToolConfiguration? value)
        {
            SubAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.ArtifactReadToolConfiguration value) => new ToolConfiguration((global::Vectara.ArtifactReadToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactReadToolConfiguration?(ToolConfiguration @this) => @this.ArtifactRead;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.ArtifactReadToolConfiguration? value)
        {
            ArtifactRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.ArtifactGrepToolConfiguration value) => new ToolConfiguration((global::Vectara.ArtifactGrepToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactGrepToolConfiguration?(ToolConfiguration @this) => @this.ArtifactGrep;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.ArtifactGrepToolConfiguration? value)
        {
            ArtifactGrep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.ImageReadToolConfiguration value) => new ToolConfiguration((global::Vectara.ImageReadToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageReadToolConfiguration?(ToolConfiguration @this) => @this.ImageRead;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.ImageReadToolConfiguration? value)
        {
            ImageRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.DocumentConversionToolConfiguration value) => new ToolConfiguration((global::Vectara.DocumentConversionToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DocumentConversionToolConfiguration?(ToolConfiguration @this) => @this.DocumentConversion;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.DocumentConversionToolConfiguration? value)
        {
            DocumentConversion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfiguration(global::Vectara.GetDocumentTextToolConfiguration value) => new ToolConfiguration((global::Vectara.GetDocumentTextToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GetDocumentTextToolConfiguration?(ToolConfiguration @this) => @this.GetDocumentText;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(global::Vectara.GetDocumentTextToolConfiguration? value)
        {
            GetDocumentText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolConfiguration(
            global::Vectara.ToolConfigurationDiscriminatorType? type,
            global::Vectara.DynamicVectaraToolConfiguration? dynamicVectara,
            global::Vectara.McpToolConfiguration? mcp,
            global::Vectara.CorporaSearchToolConfiguration? corporaSearch,
            global::Vectara.WebSearchToolConfiguration? webSearch,
            global::Vectara.LambdaToolConfiguration? lambda,
            global::Vectara.StructuredIndexingToolConfiguration? structuredIndexing,
            global::Vectara.SubAgentToolConfiguration? subAgent,
            global::Vectara.ArtifactReadToolConfiguration? artifactRead,
            global::Vectara.ArtifactGrepToolConfiguration? artifactGrep,
            global::Vectara.ImageReadToolConfiguration? imageRead,
            global::Vectara.DocumentConversionToolConfiguration? documentConversion,
            global::Vectara.GetDocumentTextToolConfiguration? getDocumentText
            )
        {
            Type = type;

            DynamicVectara = dynamicVectara;
            Mcp = mcp;
            CorporaSearch = corporaSearch;
            WebSearch = webSearch;
            Lambda = lambda;
            StructuredIndexing = structuredIndexing;
            SubAgent = subAgent;
            ArtifactRead = artifactRead;
            ArtifactGrep = artifactGrep;
            ImageRead = imageRead;
            DocumentConversion = documentConversion;
            GetDocumentText = getDocumentText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetDocumentText as object ??
            DocumentConversion as object ??
            ImageRead as object ??
            ArtifactGrep as object ??
            ArtifactRead as object ??
            SubAgent as object ??
            StructuredIndexing as object ??
            Lambda as object ??
            WebSearch as object ??
            CorporaSearch as object ??
            Mcp as object ??
            DynamicVectara as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DynamicVectara?.ToString() ??
            Mcp?.ToString() ??
            CorporaSearch?.ToString() ??
            WebSearch?.ToString() ??
            Lambda?.ToString() ??
            StructuredIndexing?.ToString() ??
            SubAgent?.ToString() ??
            ArtifactRead?.ToString() ??
            ArtifactGrep?.ToString() ??
            ImageRead?.ToString() ??
            DocumentConversion?.ToString() ??
            GetDocumentText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && IsMcp && !IsCorporaSearch && !IsWebSearch && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && IsCorporaSearch && !IsWebSearch && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && IsWebSearch && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsLambda && IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsLambda && !IsStructuredIndexing && IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsLambda && !IsStructuredIndexing && !IsSubAgent && IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && IsGetDocumentText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.DynamicVectaraToolConfiguration?, TResult>? dynamicVectara = null,
            global::System.Func<global::Vectara.McpToolConfiguration?, TResult>? mcp = null,
            global::System.Func<global::Vectara.CorporaSearchToolConfiguration?, TResult>? corporaSearch = null,
            global::System.Func<global::Vectara.WebSearchToolConfiguration?, TResult>? webSearch = null,
            global::System.Func<global::Vectara.LambdaToolConfiguration?, TResult>? lambda = null,
            global::System.Func<global::Vectara.StructuredIndexingToolConfiguration?, TResult>? structuredIndexing = null,
            global::System.Func<global::Vectara.SubAgentToolConfiguration?, TResult>? subAgent = null,
            global::System.Func<global::Vectara.ArtifactReadToolConfiguration?, TResult>? artifactRead = null,
            global::System.Func<global::Vectara.ArtifactGrepToolConfiguration?, TResult>? artifactGrep = null,
            global::System.Func<global::Vectara.ImageReadToolConfiguration?, TResult>? imageRead = null,
            global::System.Func<global::Vectara.DocumentConversionToolConfiguration?, TResult>? documentConversion = null,
            global::System.Func<global::Vectara.GetDocumentTextToolConfiguration?, TResult>? getDocumentText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVectara && dynamicVectara != null)
            {
                return dynamicVectara(DynamicVectara!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsCorporaSearch && corporaSearch != null)
            {
                return corporaSearch(CorporaSearch!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }
            else if (IsLambda && lambda != null)
            {
                return lambda(Lambda!);
            }
            else if (IsStructuredIndexing && structuredIndexing != null)
            {
                return structuredIndexing(StructuredIndexing!);
            }
            else if (IsSubAgent && subAgent != null)
            {
                return subAgent(SubAgent!);
            }
            else if (IsArtifactRead && artifactRead != null)
            {
                return artifactRead(ArtifactRead!);
            }
            else if (IsArtifactGrep && artifactGrep != null)
            {
                return artifactGrep(ArtifactGrep!);
            }
            else if (IsImageRead && imageRead != null)
            {
                return imageRead(ImageRead!);
            }
            else if (IsDocumentConversion && documentConversion != null)
            {
                return documentConversion(DocumentConversion!);
            }
            else if (IsGetDocumentText && getDocumentText != null)
            {
                return getDocumentText(GetDocumentText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.DynamicVectaraToolConfiguration?>? dynamicVectara = null,
            global::System.Action<global::Vectara.McpToolConfiguration?>? mcp = null,
            global::System.Action<global::Vectara.CorporaSearchToolConfiguration?>? corporaSearch = null,
            global::System.Action<global::Vectara.WebSearchToolConfiguration?>? webSearch = null,
            global::System.Action<global::Vectara.LambdaToolConfiguration?>? lambda = null,
            global::System.Action<global::Vectara.StructuredIndexingToolConfiguration?>? structuredIndexing = null,
            global::System.Action<global::Vectara.SubAgentToolConfiguration?>? subAgent = null,
            global::System.Action<global::Vectara.ArtifactReadToolConfiguration?>? artifactRead = null,
            global::System.Action<global::Vectara.ArtifactGrepToolConfiguration?>? artifactGrep = null,
            global::System.Action<global::Vectara.ImageReadToolConfiguration?>? imageRead = null,
            global::System.Action<global::Vectara.DocumentConversionToolConfiguration?>? documentConversion = null,
            global::System.Action<global::Vectara.GetDocumentTextToolConfiguration?>? getDocumentText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVectara)
            {
                dynamicVectara?.Invoke(DynamicVectara!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsCorporaSearch)
            {
                corporaSearch?.Invoke(CorporaSearch!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
            else if (IsLambda)
            {
                lambda?.Invoke(Lambda!);
            }
            else if (IsStructuredIndexing)
            {
                structuredIndexing?.Invoke(StructuredIndexing!);
            }
            else if (IsSubAgent)
            {
                subAgent?.Invoke(SubAgent!);
            }
            else if (IsArtifactRead)
            {
                artifactRead?.Invoke(ArtifactRead!);
            }
            else if (IsArtifactGrep)
            {
                artifactGrep?.Invoke(ArtifactGrep!);
            }
            else if (IsImageRead)
            {
                imageRead?.Invoke(ImageRead!);
            }
            else if (IsDocumentConversion)
            {
                documentConversion?.Invoke(DocumentConversion!);
            }
            else if (IsGetDocumentText)
            {
                getDocumentText?.Invoke(GetDocumentText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DynamicVectara,
                typeof(global::Vectara.DynamicVectaraToolConfiguration),
                Mcp,
                typeof(global::Vectara.McpToolConfiguration),
                CorporaSearch,
                typeof(global::Vectara.CorporaSearchToolConfiguration),
                WebSearch,
                typeof(global::Vectara.WebSearchToolConfiguration),
                Lambda,
                typeof(global::Vectara.LambdaToolConfiguration),
                StructuredIndexing,
                typeof(global::Vectara.StructuredIndexingToolConfiguration),
                SubAgent,
                typeof(global::Vectara.SubAgentToolConfiguration),
                ArtifactRead,
                typeof(global::Vectara.ArtifactReadToolConfiguration),
                ArtifactGrep,
                typeof(global::Vectara.ArtifactGrepToolConfiguration),
                ImageRead,
                typeof(global::Vectara.ImageReadToolConfiguration),
                DocumentConversion,
                typeof(global::Vectara.DocumentConversionToolConfiguration),
                GetDocumentText,
                typeof(global::Vectara.GetDocumentTextToolConfiguration),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DynamicVectaraToolConfiguration?>.Default.Equals(DynamicVectara, other.DynamicVectara) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.McpToolConfiguration?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CorporaSearchToolConfiguration?>.Default.Equals(CorporaSearch, other.CorporaSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebSearchToolConfiguration?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.LambdaToolConfiguration?>.Default.Equals(Lambda, other.Lambda) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StructuredIndexingToolConfiguration?>.Default.Equals(StructuredIndexing, other.StructuredIndexing) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SubAgentToolConfiguration?>.Default.Equals(SubAgent, other.SubAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactReadToolConfiguration?>.Default.Equals(ArtifactRead, other.ArtifactRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactGrepToolConfiguration?>.Default.Equals(ArtifactGrep, other.ArtifactGrep) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageReadToolConfiguration?>.Default.Equals(ImageRead, other.ImageRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DocumentConversionToolConfiguration?>.Default.Equals(DocumentConversion, other.DocumentConversion) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GetDocumentTextToolConfiguration?>.Default.Equals(GetDocumentText, other.GetDocumentText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolConfiguration obj1, ToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolConfiguration obj1, ToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolConfiguration o && Equals(o);
        }
    }
}
