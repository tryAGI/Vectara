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
        /// 
        /// </summary>
        public bool TryPickDynamicVectara(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.DynamicVectaraTool? value)
        {
            value = DynamicVectara;
            return IsDynamicVectara;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.DynamicVectaraTool PickDynamicVectara() => IsDynamicVectara
            ? DynamicVectara!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DynamicVectara' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.McpTool? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.McpTool PickMcp() => IsMcp
            ? Mcp!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickCorporaSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CorporaSearchTool? value)
        {
            value = CorporaSearch;
            return IsCorporaSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CorporaSearchTool PickCorporaSearch() => IsCorporaSearch
            ? CorporaSearch!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CorporaSearch' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WebSearchTool? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.WebSearchTool PickWebSearch() => IsWebSearch
            ? WebSearch!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickWebGet(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WebGetTool? value)
        {
            value = WebGet;
            return IsWebGet;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.WebGetTool PickWebGet() => IsWebGet
            ? WebGet!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebGet' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickLambda(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.LambdaTool? value)
        {
            value = Lambda;
            return IsLambda;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.LambdaTool PickLambda() => IsLambda
            ? Lambda!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Lambda' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickSubAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SubAgentTool? value)
        {
            value = SubAgent;
            return IsSubAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SubAgentTool PickSubAgent() => IsSubAgent
            ? SubAgent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubAgent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickArtifactCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ArtifactCreateTool? value)
        {
            value = ArtifactCreate;
            return IsArtifactCreate;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ArtifactCreateTool PickArtifactCreate() => IsArtifactCreate
            ? ArtifactCreate!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactCreate' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickArtifactRead(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ArtifactReadTool? value)
        {
            value = ArtifactRead;
            return IsArtifactRead;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ArtifactReadTool PickArtifactRead() => IsArtifactRead
            ? ArtifactRead!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactRead' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickArtifactGrep(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ArtifactGrepTool? value)
        {
            value = ArtifactGrep;
            return IsArtifactGrep;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ArtifactGrepTool PickArtifactGrep() => IsArtifactGrep
            ? ArtifactGrep!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactGrep' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickImageRead(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ImageReadTool? value)
        {
            value = ImageRead;
            return IsImageRead;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ImageReadTool PickImageRead() => IsImageRead
            ? ImageRead!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageRead' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickDocumentConversion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.DocumentConversionTool? value)
        {
            value = DocumentConversion;
            return IsDocumentConversion;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.DocumentConversionTool PickDocumentConversion() => IsDocumentConversion
            ? DocumentConversion!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DocumentConversion' but the value was {ToString()}.");

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
        public bool TryPickGetDocumentText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GetDocumentTextTool? value)
        {
            value = GetDocumentText;
            return IsGetDocumentText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GetDocumentTextTool PickGetDocumentText() => IsGetDocumentText
            ? GetDocumentText!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetDocumentText' but the value was {ToString()}.");

        /// <summary>
        /// A tool whose execution is performed by the calling client. When invoked, the platform emits a `tool_input` event with the tool call arguments. The client submits the result as a `tool_output` input via `createAgentInput`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ClientTool? Client { get; init; }
#else
        public global::Vectara.ClientTool? Client { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Client))]
#endif
        public bool IsClient => Client != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickClient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ClientTool? value)
        {
            value = Client;
            return IsClient;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ClientTool PickClient() => IsClient
            ? Client!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Client' but the value was {ToString()}.");
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
        public static Tool FromDynamicVectara(global::Vectara.DynamicVectaraTool? value) => new Tool(value);

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
        public static Tool FromMcp(global::Vectara.McpTool? value) => new Tool(value);

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
        public static Tool FromCorporaSearch(global::Vectara.CorporaSearchTool? value) => new Tool(value);

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
        public static Tool FromWebSearch(global::Vectara.WebSearchTool? value) => new Tool(value);

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
        public static Tool FromWebGet(global::Vectara.WebGetTool? value) => new Tool(value);

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
        public static Tool FromLambda(global::Vectara.LambdaTool? value) => new Tool(value);

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
        public static Tool FromSubAgent(global::Vectara.SubAgentTool? value) => new Tool(value);

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
        public static Tool FromArtifactCreate(global::Vectara.ArtifactCreateTool? value) => new Tool(value);

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
        public static Tool FromArtifactRead(global::Vectara.ArtifactReadTool? value) => new Tool(value);

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
        public static Tool FromArtifactGrep(global::Vectara.ArtifactGrepTool? value) => new Tool(value);

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
        public static Tool FromImageRead(global::Vectara.ImageReadTool? value) => new Tool(value);

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
        public static Tool FromDocumentConversion(global::Vectara.DocumentConversionTool? value) => new Tool(value);

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
        public static Tool FromGetDocumentText(global::Vectara.GetDocumentTextTool? value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Vectara.ClientTool value) => new Tool((global::Vectara.ClientTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ClientTool?(Tool @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Vectara.ClientTool? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Tool FromClient(global::Vectara.ClientTool? value) => new Tool(value);

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
            global::Vectara.SubAgentTool? subAgent,
            global::Vectara.ArtifactCreateTool? artifactCreate,
            global::Vectara.ArtifactReadTool? artifactRead,
            global::Vectara.ArtifactGrepTool? artifactGrep,
            global::Vectara.ImageReadTool? imageRead,
            global::Vectara.DocumentConversionTool? documentConversion,
            global::Vectara.GetDocumentTextTool? getDocumentText,
            global::Vectara.ClientTool? client
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
            ArtifactCreate = artifactCreate;
            ArtifactRead = artifactRead;
            ArtifactGrep = artifactGrep;
            ImageRead = imageRead;
            DocumentConversion = documentConversion;
            GetDocumentText = getDocumentText;
            Client = client;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Client as object ??
            GetDocumentText as object ??
            DocumentConversion as object ??
            ImageRead as object ??
            ArtifactGrep as object ??
            ArtifactRead as object ??
            ArtifactCreate as object ??
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
            ArtifactCreate?.ToString() ??
            ArtifactRead?.ToString() ??
            ArtifactGrep?.ToString() ??
            ImageRead?.ToString() ??
            DocumentConversion?.ToString() ??
            GetDocumentText?.ToString() ??
            Client?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && IsImageRead && !IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && IsDocumentConversion && !IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && IsGetDocumentText && !IsClient || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText && IsClient;
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
            global::System.Func<global::Vectara.SubAgentTool?, TResult>? subAgent = null,
            global::System.Func<global::Vectara.ArtifactCreateTool?, TResult>? artifactCreate = null,
            global::System.Func<global::Vectara.ArtifactReadTool?, TResult>? artifactRead = null,
            global::System.Func<global::Vectara.ArtifactGrepTool?, TResult>? artifactGrep = null,
            global::System.Func<global::Vectara.ImageReadTool?, TResult>? imageRead = null,
            global::System.Func<global::Vectara.DocumentConversionTool?, TResult>? documentConversion = null,
            global::System.Func<global::Vectara.GetDocumentTextTool?, TResult>? getDocumentText = null,
            global::System.Func<global::Vectara.ClientTool?, TResult>? client = null,
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
            else if (IsClient && client != null)
            {
                return client(Client!);
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

            global::System.Action<global::Vectara.SubAgentTool?>? subAgent = null,

            global::System.Action<global::Vectara.ArtifactCreateTool?>? artifactCreate = null,

            global::System.Action<global::Vectara.ArtifactReadTool?>? artifactRead = null,

            global::System.Action<global::Vectara.ArtifactGrepTool?>? artifactGrep = null,

            global::System.Action<global::Vectara.ImageReadTool?>? imageRead = null,

            global::System.Action<global::Vectara.DocumentConversionTool?>? documentConversion = null,

            global::System.Action<global::Vectara.GetDocumentTextTool?>? getDocumentText = null,

            global::System.Action<global::Vectara.ClientTool?>? client = null,
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
            else if (IsClient)
            {
                client?.Invoke(Client!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.DynamicVectaraTool?>? dynamicVectara = null,
            global::System.Action<global::Vectara.McpTool?>? mcp = null,
            global::System.Action<global::Vectara.CorporaSearchTool?>? corporaSearch = null,
            global::System.Action<global::Vectara.WebSearchTool?>? webSearch = null,
            global::System.Action<global::Vectara.WebGetTool?>? webGet = null,
            global::System.Action<global::Vectara.LambdaTool?>? lambda = null,
            global::System.Action<global::Vectara.SubAgentTool?>? subAgent = null,
            global::System.Action<global::Vectara.ArtifactCreateTool?>? artifactCreate = null,
            global::System.Action<global::Vectara.ArtifactReadTool?>? artifactRead = null,
            global::System.Action<global::Vectara.ArtifactGrepTool?>? artifactGrep = null,
            global::System.Action<global::Vectara.ImageReadTool?>? imageRead = null,
            global::System.Action<global::Vectara.DocumentConversionTool?>? documentConversion = null,
            global::System.Action<global::Vectara.GetDocumentTextTool?>? getDocumentText = null,
            global::System.Action<global::Vectara.ClientTool?>? client = null,
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
            else if (IsClient)
            {
                client?.Invoke(Client!);
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
                Client,
                typeof(global::Vectara.ClientTool),
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SubAgentTool?>.Default.Equals(SubAgent, other.SubAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactCreateTool?>.Default.Equals(ArtifactCreate, other.ArtifactCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactReadTool?>.Default.Equals(ArtifactRead, other.ArtifactRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactGrepTool?>.Default.Equals(ArtifactGrep, other.ArtifactGrep) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageReadTool?>.Default.Equals(ImageRead, other.ImageRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DocumentConversionTool?>.Default.Equals(DocumentConversion, other.DocumentConversion) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GetDocumentTextTool?>.Default.Equals(GetDocumentText, other.GetDocumentText) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ClientTool?>.Default.Equals(Client, other.Client) 
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
