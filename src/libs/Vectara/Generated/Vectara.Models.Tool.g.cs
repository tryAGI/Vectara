#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool that can be used by agents to perform specific actions or operations.
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A tool type for built-in Vectara tools that have implementations within the platform but do not have a dedicated tool type schema. Examples include tools like `sub_agent`, `corpora_search`, `web_search`, and similar platform-provided capabilities. Use the List Tools endpoint to discover available tools and obtain the `tool_id` required for configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DynamicVectaraTool? DynamicVectara { get; init; }
#else
        public global::Vectara.DynamicVectaraTool? DynamicVectara { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVectara))]
#endif
        public bool IsDynamicVectara => DynamicVectara != null;

        /// <summary>
        /// An MCP (Model Context Protocol) tool that connects to external MCP servers for extended functionality.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.McpTool? Mcp { get; init; }
#else
        public global::Vectara.McpTool? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// A corpora search tool that searches through Vectara corpora to find relevant information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CorporaSearchTool? CorporaSearch { get; init; }
#else
        public global::Vectara.CorporaSearchTool? CorporaSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CorporaSearch))]
#endif
        public bool IsCorporaSearch => CorporaSearch != null;

        /// <summary>
        /// A web search tool that searches the internet for relevant information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebSearchTool? WebSearch { get; init; }
#else
        public global::Vectara.WebSearchTool? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        /// A web get tool that fetches content from URLs using HTTP requests.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebGetTool? WebGet { get; init; }
#else
        public global::Vectara.WebGetTool? WebGet { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebGet))]
#endif
        public bool IsWebGet => WebGet != null;

        /// <summary>
        /// A user-defined function that can be executed as a tool by agents.<br/>
        /// Lambda tools run in a secure, sandboxed environment with resource limits.<br/>
        /// Currently supports Python 3.12 with a curated set of libraries.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.LambdaTool? Lambda { get; init; }
#else
        public global::Vectara.LambdaTool? Lambda { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lambda))]
#endif
        public bool IsLambda => Lambda != null;

        /// <summary>
        /// A tool that indexes structured documents into the Vectara platform with full control over document structure, sections, metadata, tables, and images.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StructuredIndexingTool? StructuredIndexing { get; init; }
#else
        public global::Vectara.StructuredIndexingTool? StructuredIndexing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StructuredIndexing))]
#endif
        public bool IsStructuredIndexing => StructuredIndexing != null;

        /// <summary>
        /// A tool that spawns a specialized sub-agent to handle complex, multi-step tasks autonomously.<br/>
        /// Sub-agents maintain separate context from the main agent and can be specialized for specific types of tasks like code review, general research, or output styling.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SubAgentTool? SubAgent { get; init; }
#else
        public global::Vectara.SubAgentTool? SubAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubAgent))]
#endif
        public bool IsSubAgent => SubAgent != null;

        /// <summary>
        /// A tool that creates artifacts from text or structured data content that can be stored and referenced later.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ArtifactCreateTool? ArtifactCreate { get; init; }
#else
        public global::Vectara.ArtifactCreateTool? ArtifactCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactCreate))]
#endif
        public bool IsArtifactCreate => ArtifactCreate != null;

        /// <summary>
        /// A tool that reads artifact content from the agent session workspace with flexible size and range options.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ArtifactReadTool? ArtifactRead { get; init; }
#else
        public global::Vectara.ArtifactReadTool? ArtifactRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactRead))]
#endif
        public bool IsArtifactRead => ArtifactRead != null;

        /// <summary>
        /// A tool that searches through an artifact's content using grep with support for all standard grep options.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ArtifactGrepTool? ArtifactGrep { get; init; }
#else
        public global::Vectara.ArtifactGrepTool? ArtifactGrep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactGrep))]
#endif
        public bool IsArtifactGrep => ArtifactGrep != null;

        /// <summary>
        /// A tool that loads image artifacts into the conversation context for viewing and analysis.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ImageReadTool? ImageRead { get; init; }
#else
        public global::Vectara.ImageReadTool? ImageRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageRead))]
#endif
        public bool IsImageRead => ImageRead != null;

        /// <summary>
        /// A tool that converts document artifacts (PDF, Word, PowerPoint, etc.) to various formats.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DocumentConversionTool? DocumentConversion { get; init; }
#else
        public global::Vectara.DocumentConversionTool? DocumentConversion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentConversion))]
#endif
        public bool IsDocumentConversion => DocumentConversion != null;

        /// <summary>
        /// A tool that fetches the full text content of a document from a corpus and stores it as an artifact.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GetDocumentTextTool? GetDocumentText { get; init; }
#else
        public global::Vectara.GetDocumentTextTool? GetDocumentText { get; }
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
        public static implicit operator Tool(global::Vectara.DynamicVectaraTool value) => new Tool((global::Vectara.DynamicVectaraTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DynamicVectaraTool?(Tool @this) => @this.DynamicVectara;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.DynamicVectaraTool? value)
        {
            DynamicVectara = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.McpTool value) => new Tool((global::Vectara.McpTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.McpTool?(Tool @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.McpTool? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.CorporaSearchTool value) => new Tool((global::Vectara.CorporaSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CorporaSearchTool?(Tool @this) => @this.CorporaSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.CorporaSearchTool? value)
        {
            CorporaSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.WebSearchTool value) => new Tool((global::Vectara.WebSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WebSearchTool?(Tool @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.WebSearchTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.WebGetTool value) => new Tool((global::Vectara.WebGetTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WebGetTool?(Tool @this) => @this.WebGet;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.WebGetTool? value)
        {
            WebGet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.LambdaTool value) => new Tool((global::Vectara.LambdaTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.LambdaTool?(Tool @this) => @this.Lambda;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.LambdaTool? value)
        {
            Lambda = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.StructuredIndexingTool value) => new Tool((global::Vectara.StructuredIndexingTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StructuredIndexingTool?(Tool @this) => @this.StructuredIndexing;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.StructuredIndexingTool? value)
        {
            StructuredIndexing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.SubAgentTool value) => new Tool((global::Vectara.SubAgentTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SubAgentTool?(Tool @this) => @this.SubAgent;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.SubAgentTool? value)
        {
            SubAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.ArtifactCreateTool value) => new Tool((global::Vectara.ArtifactCreateTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactCreateTool?(Tool @this) => @this.ArtifactCreate;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.ArtifactCreateTool? value)
        {
            ArtifactCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.ArtifactReadTool value) => new Tool((global::Vectara.ArtifactReadTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactReadTool?(Tool @this) => @this.ArtifactRead;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.ArtifactReadTool? value)
        {
            ArtifactRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.ArtifactGrepTool value) => new Tool((global::Vectara.ArtifactGrepTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactGrepTool?(Tool @this) => @this.ArtifactGrep;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.ArtifactGrepTool? value)
        {
            ArtifactGrep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.ImageReadTool value) => new Tool((global::Vectara.ImageReadTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageReadTool?(Tool @this) => @this.ImageRead;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.ImageReadTool? value)
        {
            ImageRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.DocumentConversionTool value) => new Tool((global::Vectara.DocumentConversionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DocumentConversionTool?(Tool @this) => @this.DocumentConversion;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.DocumentConversionTool? value)
        {
            DocumentConversion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.GetDocumentTextTool value) => new Tool((global::Vectara.GetDocumentTextTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GetDocumentTextTool?(Tool @this) => @this.GetDocumentText;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.GetDocumentTextTool? value)
        {
            GetDocumentText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::Vectara.ToolDiscriminatorType? type,
            global::Vectara.DynamicVectaraTool? dynamicVectara,
            global::Vectara.McpTool? mcp,
            global::Vectara.CorporaSearchTool? corporaSearch,
            global::Vectara.WebSearchTool? webSearch,
            global::Vectara.WebGetTool? webGet,
            global::Vectara.LambdaTool? lambda,
            global::Vectara.StructuredIndexingTool? structuredIndexing,
            global::Vectara.SubAgentTool? subAgent,
            global::Vectara.ArtifactCreateTool? artifactCreate,
            global::Vectara.ArtifactReadTool? artifactRead,
            global::Vectara.ArtifactGrepTool? artifactGrep,
            global::Vectara.ImageReadTool? imageRead,
            global::Vectara.DocumentConversionTool? documentConversion,
            global::Vectara.GetDocumentTextTool? getDocumentText
            )
        {
            Type = type;

            DynamicVectara = dynamicVectara;
            Mcp = mcp;
            CorporaSearch = corporaSearch;
            WebSearch = webSearch;
            WebGet = webGet;
            Lambda = lambda;
            StructuredIndexing = structuredIndexing;
            SubAgent = subAgent;
            ArtifactCreate = artifactCreate;
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
            ArtifactCreate as object ??
            SubAgent as object ??
            StructuredIndexing as object ??
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
            StructuredIndexing?.ToString() ??
            SubAgent?.ToString() ??
            ArtifactCreate?.ToString() ??
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
            return IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && IsGetDocumentText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.DynamicVectaraTool?, TResult>? dynamicVectara = null,
            global::System.Func<global::Vectara.McpTool?, TResult>? mcp = null,
            global::System.Func<global::Vectara.CorporaSearchTool?, TResult>? corporaSearch = null,
            global::System.Func<global::Vectara.WebSearchTool?, TResult>? webSearch = null,
            global::System.Func<global::Vectara.WebGetTool?, TResult>? webGet = null,
            global::System.Func<global::Vectara.LambdaTool?, TResult>? lambda = null,
            global::System.Func<global::Vectara.StructuredIndexingTool?, TResult>? structuredIndexing = null,
            global::System.Func<global::Vectara.SubAgentTool?, TResult>? subAgent = null,
            global::System.Func<global::Vectara.ArtifactCreateTool?, TResult>? artifactCreate = null,
            global::System.Func<global::Vectara.ArtifactReadTool?, TResult>? artifactRead = null,
            global::System.Func<global::Vectara.ArtifactGrepTool?, TResult>? artifactGrep = null,
            global::System.Func<global::Vectara.ImageReadTool?, TResult>? imageRead = null,
            global::System.Func<global::Vectara.DocumentConversionTool?, TResult>? documentConversion = null,
            global::System.Func<global::Vectara.GetDocumentTextTool?, TResult>? getDocumentText = null,
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
            else if (IsStructuredIndexing && structuredIndexing != null)
            {
                return structuredIndexing(StructuredIndexing!);
            }
            else if (IsSubAgent && subAgent != null)
            {
                return subAgent(SubAgent!);
            }
            else if (IsArtifactCreate && artifactCreate != null)
            {
                return artifactCreate(ArtifactCreate!);
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
            global::System.Action<global::Vectara.DynamicVectaraTool?>? dynamicVectara = null,
            global::System.Action<global::Vectara.McpTool?>? mcp = null,
            global::System.Action<global::Vectara.CorporaSearchTool?>? corporaSearch = null,
            global::System.Action<global::Vectara.WebSearchTool?>? webSearch = null,
            global::System.Action<global::Vectara.WebGetTool?>? webGet = null,
            global::System.Action<global::Vectara.LambdaTool?>? lambda = null,
            global::System.Action<global::Vectara.StructuredIndexingTool?>? structuredIndexing = null,
            global::System.Action<global::Vectara.SubAgentTool?>? subAgent = null,
            global::System.Action<global::Vectara.ArtifactCreateTool?>? artifactCreate = null,
            global::System.Action<global::Vectara.ArtifactReadTool?>? artifactRead = null,
            global::System.Action<global::Vectara.ArtifactGrepTool?>? artifactGrep = null,
            global::System.Action<global::Vectara.ImageReadTool?>? imageRead = null,
            global::System.Action<global::Vectara.DocumentConversionTool?>? documentConversion = null,
            global::System.Action<global::Vectara.GetDocumentTextTool?>? getDocumentText = null,
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
            else if (IsStructuredIndexing)
            {
                structuredIndexing?.Invoke(StructuredIndexing!);
            }
            else if (IsSubAgent)
            {
                subAgent?.Invoke(SubAgent!);
            }
            else if (IsArtifactCreate)
            {
                artifactCreate?.Invoke(ArtifactCreate!);
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
                typeof(global::Vectara.DynamicVectaraTool),
                Mcp,
                typeof(global::Vectara.McpTool),
                CorporaSearch,
                typeof(global::Vectara.CorporaSearchTool),
                WebSearch,
                typeof(global::Vectara.WebSearchTool),
                WebGet,
                typeof(global::Vectara.WebGetTool),
                Lambda,
                typeof(global::Vectara.LambdaTool),
                StructuredIndexing,
                typeof(global::Vectara.StructuredIndexingTool),
                SubAgent,
                typeof(global::Vectara.SubAgentTool),
                ArtifactCreate,
                typeof(global::Vectara.ArtifactCreateTool),
                ArtifactRead,
                typeof(global::Vectara.ArtifactReadTool),
                ArtifactGrep,
                typeof(global::Vectara.ArtifactGrepTool),
                ImageRead,
                typeof(global::Vectara.ImageReadTool),
                DocumentConversion,
                typeof(global::Vectara.DocumentConversionTool),
                GetDocumentText,
                typeof(global::Vectara.GetDocumentTextTool),
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
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DynamicVectaraTool?>.Default.Equals(DynamicVectara, other.DynamicVectara) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.McpTool?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CorporaSearchTool?>.Default.Equals(CorporaSearch, other.CorporaSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebSearchTool?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetTool?>.Default.Equals(WebGet, other.WebGet) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.LambdaTool?>.Default.Equals(Lambda, other.Lambda) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StructuredIndexingTool?>.Default.Equals(StructuredIndexing, other.StructuredIndexing) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SubAgentTool?>.Default.Equals(SubAgent, other.SubAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactCreateTool?>.Default.Equals(ArtifactCreate, other.ArtifactCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactReadTool?>.Default.Equals(ArtifactRead, other.ArtifactRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactGrepTool?>.Default.Equals(ArtifactGrep, other.ArtifactGrep) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageReadTool?>.Default.Equals(ImageRead, other.ImageRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DocumentConversionTool?>.Default.Equals(DocumentConversion, other.DocumentConversion) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GetDocumentTextTool?>.Default.Equals(GetDocumentText, other.GetDocumentText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }
    }
}
