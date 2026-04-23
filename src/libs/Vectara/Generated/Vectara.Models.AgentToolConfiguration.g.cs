#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool configuration that can be used by an agent, defined inline with a specific configuration type.<br/>
    /// Example: [{"type":"web_search","argument_override":{"limit":5,"include_domains":["github.com","stackoverflow.com"],"exclude_domains":["spam.com"]}}]
    /// </summary>
    public readonly partial struct AgentToolConfiguration : global::System.IEquatable<AgentToolConfiguration>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentToolConfigurationDiscriminatorType? Type { get; }

        /// <summary>
        /// An inline configuration for built-in Vectara tools that have implementations within the platform but do not have a dedicated configuration type schema. Use the List Tools endpoint to discover available tools and obtain the `tool_id` required for this configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineDynamicVectaraToolConfiguration? DynamicVectara { get; init; }
#else
        public global::Vectara.InlineDynamicVectaraToolConfiguration? DynamicVectara { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVectara))]
#endif
        public bool IsDynamicVectara => DynamicVectara != null;

        /// <summary>
        /// An MCP tool configuration defined inline in the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineMcpToolConfiguration? Mcp { get; init; }
#else
        public global::Vectara.InlineMcpToolConfiguration? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// A corpora search tool configuration defined inline in the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineCorporaSearchToolConfiguration? CorporaSearch { get; init; }
#else
        public global::Vectara.InlineCorporaSearchToolConfiguration? CorporaSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CorporaSearch))]
#endif
        public bool IsCorporaSearch => CorporaSearch != null;

        /// <summary>
        /// A web search tool configuration defined inline in the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineWebSearchToolConfiguration? WebSearch { get; init; }
#else
        public global::Vectara.InlineWebSearchToolConfiguration? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        /// A web get tool configuration defined inline in the agent for fetching content from URLs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineWebGetToolConfiguration? WebGet { get; init; }
#else
        public global::Vectara.InlineWebGetToolConfiguration? WebGet { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebGet))]
#endif
        public bool IsWebGet => WebGet != null;

        /// <summary>
        /// A lambda tool configuration defined inline in the agent for executing user-defined functions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineLambdaToolConfiguration? Lambda { get; init; }
#else
        public global::Vectara.InlineLambdaToolConfiguration? Lambda { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lambda))]
#endif
        public bool IsLambda => Lambda != null;

        /// <summary>
        /// A sub-agent tool configuration defined inline in the agent for invoking specialized sub-agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineSubAgentToolConfiguration? SubAgent { get; init; }
#else
        public global::Vectara.InlineSubAgentToolConfiguration? SubAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubAgent))]
#endif
        public bool IsSubAgent => SubAgent != null;

        /// <summary>
        /// An artifact read tool configuration defined inline in the agent for reading artifacts from the session workspace.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineArtifactReadToolConfiguration? ArtifactRead { get; init; }
#else
        public global::Vectara.InlineArtifactReadToolConfiguration? ArtifactRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactRead))]
#endif
        public bool IsArtifactRead => ArtifactRead != null;

        /// <summary>
        /// An artifact grep tool configuration defined inline in the agent for searching through artifact content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineArtifactGrepToolConfiguration? ArtifactGrep { get; init; }
#else
        public global::Vectara.InlineArtifactGrepToolConfiguration? ArtifactGrep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactGrep))]
#endif
        public bool IsArtifactGrep => ArtifactGrep != null;

        /// <summary>
        /// An image read tool configuration defined inline in the agent for loading images into the conversation context.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineImageReadToolConfiguration? ImageRead { get; init; }
#else
        public global::Vectara.InlineImageReadToolConfiguration? ImageRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageRead))]
#endif
        public bool IsImageRead => ImageRead != null;

        /// <summary>
        /// A document conversion tool configuration defined inline in the agent for converting document artifacts to various formats.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineDocumentConversionToolConfiguration? DocumentConversion { get; init; }
#else
        public global::Vectara.InlineDocumentConversionToolConfiguration? DocumentConversion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentConversion))]
#endif
        public bool IsDocumentConversion => DocumentConversion != null;

        /// <summary>
        /// A get document text tool configuration defined inline in the agent for fetching document text content from a corpus.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineGetDocumentTextToolConfiguration? GetDocumentText { get; init; }
#else
        public global::Vectara.InlineGetDocumentTextToolConfiguration? GetDocumentText { get; }
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
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineDynamicVectaraToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineDynamicVectaraToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineDynamicVectaraToolConfiguration?(AgentToolConfiguration @this) => @this.DynamicVectara;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineDynamicVectaraToolConfiguration? value)
        {
            DynamicVectara = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineMcpToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineMcpToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineMcpToolConfiguration?(AgentToolConfiguration @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineMcpToolConfiguration? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineCorporaSearchToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineCorporaSearchToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineCorporaSearchToolConfiguration?(AgentToolConfiguration @this) => @this.CorporaSearch;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineCorporaSearchToolConfiguration? value)
        {
            CorporaSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineWebSearchToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineWebSearchToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineWebSearchToolConfiguration?(AgentToolConfiguration @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineWebSearchToolConfiguration? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineWebGetToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineWebGetToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineWebGetToolConfiguration?(AgentToolConfiguration @this) => @this.WebGet;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineWebGetToolConfiguration? value)
        {
            WebGet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineLambdaToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineLambdaToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineLambdaToolConfiguration?(AgentToolConfiguration @this) => @this.Lambda;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineLambdaToolConfiguration? value)
        {
            Lambda = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineSubAgentToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineSubAgentToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineSubAgentToolConfiguration?(AgentToolConfiguration @this) => @this.SubAgent;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineSubAgentToolConfiguration? value)
        {
            SubAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineArtifactReadToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineArtifactReadToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineArtifactReadToolConfiguration?(AgentToolConfiguration @this) => @this.ArtifactRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineArtifactReadToolConfiguration? value)
        {
            ArtifactRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineArtifactGrepToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineArtifactGrepToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineArtifactGrepToolConfiguration?(AgentToolConfiguration @this) => @this.ArtifactGrep;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineArtifactGrepToolConfiguration? value)
        {
            ArtifactGrep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineImageReadToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineImageReadToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineImageReadToolConfiguration?(AgentToolConfiguration @this) => @this.ImageRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineImageReadToolConfiguration? value)
        {
            ImageRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineDocumentConversionToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineDocumentConversionToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineDocumentConversionToolConfiguration?(AgentToolConfiguration @this) => @this.DocumentConversion;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineDocumentConversionToolConfiguration? value)
        {
            DocumentConversion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineGetDocumentTextToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineGetDocumentTextToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineGetDocumentTextToolConfiguration?(AgentToolConfiguration @this) => @this.GetDocumentText;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineGetDocumentTextToolConfiguration? value)
        {
            GetDocumentText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(
            global::Vectara.AgentToolConfigurationDiscriminatorType? type,
            global::Vectara.InlineDynamicVectaraToolConfiguration? dynamicVectara,
            global::Vectara.InlineMcpToolConfiguration? mcp,
            global::Vectara.InlineCorporaSearchToolConfiguration? corporaSearch,
            global::Vectara.InlineWebSearchToolConfiguration? webSearch,
            global::Vectara.InlineWebGetToolConfiguration? webGet,
            global::Vectara.InlineLambdaToolConfiguration? lambda,
            global::Vectara.InlineSubAgentToolConfiguration? subAgent,
            global::Vectara.InlineArtifactReadToolConfiguration? artifactRead,
            global::Vectara.InlineArtifactGrepToolConfiguration? artifactGrep,
            global::Vectara.InlineImageReadToolConfiguration? imageRead,
            global::Vectara.InlineDocumentConversionToolConfiguration? documentConversion,
            global::Vectara.InlineGetDocumentTextToolConfiguration? getDocumentText
            )
        {
            Type = type;

            DynamicVectara = dynamicVectara;
            Mcp = mcp;
            CorporaSearch = corporaSearch;
            WebSearch = webSearch;
            WebGet = webGet;
            Lambda = lambda;
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
            Lambda as object ??
            WebGet as object ??
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
            WebGet?.ToString() ??
            Lambda?.ToString() ??
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
            return IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && IsLambda && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactRead && IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && IsGetDocumentText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.InlineDynamicVectaraToolConfiguration?, TResult>? dynamicVectara = null,
            global::System.Func<global::Vectara.InlineMcpToolConfiguration?, TResult>? mcp = null,
            global::System.Func<global::Vectara.InlineCorporaSearchToolConfiguration?, TResult>? corporaSearch = null,
            global::System.Func<global::Vectara.InlineWebSearchToolConfiguration?, TResult>? webSearch = null,
            global::System.Func<global::Vectara.InlineWebGetToolConfiguration?, TResult>? webGet = null,
            global::System.Func<global::Vectara.InlineLambdaToolConfiguration?, TResult>? lambda = null,
            global::System.Func<global::Vectara.InlineSubAgentToolConfiguration?, TResult>? subAgent = null,
            global::System.Func<global::Vectara.InlineArtifactReadToolConfiguration?, TResult>? artifactRead = null,
            global::System.Func<global::Vectara.InlineArtifactGrepToolConfiguration?, TResult>? artifactGrep = null,
            global::System.Func<global::Vectara.InlineImageReadToolConfiguration?, TResult>? imageRead = null,
            global::System.Func<global::Vectara.InlineDocumentConversionToolConfiguration?, TResult>? documentConversion = null,
            global::System.Func<global::Vectara.InlineGetDocumentTextToolConfiguration?, TResult>? getDocumentText = null,
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
            else if (IsWebGet && webGet != null)
            {
                return webGet(WebGet!);
            }
            else if (IsLambda && lambda != null)
            {
                return lambda(Lambda!);
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
            global::System.Action<global::Vectara.InlineDynamicVectaraToolConfiguration?>? dynamicVectara = null,
            global::System.Action<global::Vectara.InlineMcpToolConfiguration?>? mcp = null,
            global::System.Action<global::Vectara.InlineCorporaSearchToolConfiguration?>? corporaSearch = null,
            global::System.Action<global::Vectara.InlineWebSearchToolConfiguration?>? webSearch = null,
            global::System.Action<global::Vectara.InlineWebGetToolConfiguration?>? webGet = null,
            global::System.Action<global::Vectara.InlineLambdaToolConfiguration?>? lambda = null,
            global::System.Action<global::Vectara.InlineSubAgentToolConfiguration?>? subAgent = null,
            global::System.Action<global::Vectara.InlineArtifactReadToolConfiguration?>? artifactRead = null,
            global::System.Action<global::Vectara.InlineArtifactGrepToolConfiguration?>? artifactGrep = null,
            global::System.Action<global::Vectara.InlineImageReadToolConfiguration?>? imageRead = null,
            global::System.Action<global::Vectara.InlineDocumentConversionToolConfiguration?>? documentConversion = null,
            global::System.Action<global::Vectara.InlineGetDocumentTextToolConfiguration?>? getDocumentText = null,
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
            else if (IsWebGet)
            {
                webGet?.Invoke(WebGet!);
            }
            else if (IsLambda)
            {
                lambda?.Invoke(Lambda!);
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
                typeof(global::Vectara.InlineDynamicVectaraToolConfiguration),
                Mcp,
                typeof(global::Vectara.InlineMcpToolConfiguration),
                CorporaSearch,
                typeof(global::Vectara.InlineCorporaSearchToolConfiguration),
                WebSearch,
                typeof(global::Vectara.InlineWebSearchToolConfiguration),
                WebGet,
                typeof(global::Vectara.InlineWebGetToolConfiguration),
                Lambda,
                typeof(global::Vectara.InlineLambdaToolConfiguration),
                SubAgent,
                typeof(global::Vectara.InlineSubAgentToolConfiguration),
                ArtifactRead,
                typeof(global::Vectara.InlineArtifactReadToolConfiguration),
                ArtifactGrep,
                typeof(global::Vectara.InlineArtifactGrepToolConfiguration),
                ImageRead,
                typeof(global::Vectara.InlineImageReadToolConfiguration),
                DocumentConversion,
                typeof(global::Vectara.InlineDocumentConversionToolConfiguration),
                GetDocumentText,
                typeof(global::Vectara.InlineGetDocumentTextToolConfiguration),
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
        public bool Equals(AgentToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineDynamicVectaraToolConfiguration?>.Default.Equals(DynamicVectara, other.DynamicVectara) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineMcpToolConfiguration?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineCorporaSearchToolConfiguration?>.Default.Equals(CorporaSearch, other.CorporaSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineWebSearchToolConfiguration?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineWebGetToolConfiguration?>.Default.Equals(WebGet, other.WebGet) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineLambdaToolConfiguration?>.Default.Equals(Lambda, other.Lambda) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineSubAgentToolConfiguration?>.Default.Equals(SubAgent, other.SubAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineArtifactReadToolConfiguration?>.Default.Equals(ArtifactRead, other.ArtifactRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineArtifactGrepToolConfiguration?>.Default.Equals(ArtifactGrep, other.ArtifactGrep) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineImageReadToolConfiguration?>.Default.Equals(ImageRead, other.ImageRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineDocumentConversionToolConfiguration?>.Default.Equals(DocumentConversion, other.DocumentConversion) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineGetDocumentTextToolConfiguration?>.Default.Equals(GetDocumentText, other.GetDocumentText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentToolConfiguration obj1, AgentToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentToolConfiguration obj1, AgentToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentToolConfiguration o && Equals(o);
        }
    }
}
