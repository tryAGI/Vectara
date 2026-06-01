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
        /// 
        /// </summary>
        public bool TryPickDynamicVectara(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineDynamicVectaraToolConfiguration? value)
        {
            value = DynamicVectara;
            return IsDynamicVectara;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineDynamicVectaraToolConfiguration PickDynamicVectara() => IsDynamicVectara
            ? DynamicVectara!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DynamicVectara' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineMcpToolConfiguration? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineMcpToolConfiguration PickMcp() => IsMcp
            ? Mcp!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickCorporaSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineCorporaSearchToolConfiguration? value)
        {
            value = CorporaSearch;
            return IsCorporaSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineCorporaSearchToolConfiguration PickCorporaSearch() => IsCorporaSearch
            ? CorporaSearch!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CorporaSearch' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineWebSearchToolConfiguration? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineWebSearchToolConfiguration PickWebSearch() => IsWebSearch
            ? WebSearch!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickWebGet(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineWebGetToolConfiguration? value)
        {
            value = WebGet;
            return IsWebGet;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineWebGetToolConfiguration PickWebGet() => IsWebGet
            ? WebGet!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebGet' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickLambda(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineLambdaToolConfiguration? value)
        {
            value = Lambda;
            return IsLambda;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineLambdaToolConfiguration PickLambda() => IsLambda
            ? Lambda!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Lambda' but the value was {ToString()}.");

        /// <summary>
        /// A client tool configuration defined inline in the agent. When invoked, the agent emits a `tool_input` event and waits for the calling client to submit a matching tool output via `createAgentInput`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineClientToolConfiguration? Client { get; init; }
#else
        public global::Vectara.InlineClientToolConfiguration? Client { get; }
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
            out global::Vectara.InlineClientToolConfiguration? value)
        {
            value = Client;
            return IsClient;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineClientToolConfiguration PickClient() => IsClient
            ? Client!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Client' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickSubAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineSubAgentToolConfiguration? value)
        {
            value = SubAgent;
            return IsSubAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineSubAgentToolConfiguration PickSubAgent() => IsSubAgent
            ? SubAgent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubAgent' but the value was {ToString()}.");

        /// <summary>
        /// An artifact create tool configuration defined inline in the agent for creating artifacts on-the-fly from text or structured data content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineArtifactCreateToolConfiguration? ArtifactCreate { get; init; }
#else
        public global::Vectara.InlineArtifactCreateToolConfiguration? ArtifactCreate { get; }
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
            out global::Vectara.InlineArtifactCreateToolConfiguration? value)
        {
            value = ArtifactCreate;
            return IsArtifactCreate;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineArtifactCreateToolConfiguration PickArtifactCreate() => IsArtifactCreate
            ? ArtifactCreate!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactCreate' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickArtifactRead(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineArtifactReadToolConfiguration? value)
        {
            value = ArtifactRead;
            return IsArtifactRead;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineArtifactReadToolConfiguration PickArtifactRead() => IsArtifactRead
            ? ArtifactRead!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactRead' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickArtifactGrep(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineArtifactGrepToolConfiguration? value)
        {
            value = ArtifactGrep;
            return IsArtifactGrep;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineArtifactGrepToolConfiguration PickArtifactGrep() => IsArtifactGrep
            ? ArtifactGrep!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactGrep' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickImageRead(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineImageReadToolConfiguration? value)
        {
            value = ImageRead;
            return IsImageRead;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineImageReadToolConfiguration PickImageRead() => IsImageRead
            ? ImageRead!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageRead' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickDocumentConversion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineDocumentConversionToolConfiguration? value)
        {
            value = DocumentConversion;
            return IsDocumentConversion;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineDocumentConversionToolConfiguration PickDocumentConversion() => IsDocumentConversion
            ? DocumentConversion!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DocumentConversion' but the value was {ToString()}.");

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
        public bool TryPickGetDocumentText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineGetDocumentTextToolConfiguration? value)
        {
            value = GetDocumentText;
            return IsGetDocumentText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineGetDocumentTextToolConfiguration PickGetDocumentText() => IsGetDocumentText
            ? GetDocumentText!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetDocumentText' but the value was {ToString()}.");
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
        public static AgentToolConfiguration FromDynamicVectara(global::Vectara.InlineDynamicVectaraToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromMcp(global::Vectara.InlineMcpToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromCorporaSearch(global::Vectara.InlineCorporaSearchToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromWebSearch(global::Vectara.InlineWebSearchToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromWebGet(global::Vectara.InlineWebGetToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromLambda(global::Vectara.InlineLambdaToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineClientToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineClientToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineClientToolConfiguration?(AgentToolConfiguration @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineClientToolConfiguration? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromClient(global::Vectara.InlineClientToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromSubAgent(global::Vectara.InlineSubAgentToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.InlineArtifactCreateToolConfiguration value) => new AgentToolConfiguration((global::Vectara.InlineArtifactCreateToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineArtifactCreateToolConfiguration?(AgentToolConfiguration @this) => @this.ArtifactCreate;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.InlineArtifactCreateToolConfiguration? value)
        {
            ArtifactCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromArtifactCreate(global::Vectara.InlineArtifactCreateToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromArtifactRead(global::Vectara.InlineArtifactReadToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromArtifactGrep(global::Vectara.InlineArtifactGrepToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromImageRead(global::Vectara.InlineImageReadToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromDocumentConversion(global::Vectara.InlineDocumentConversionToolConfiguration? value) => new AgentToolConfiguration(value);

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
        public static AgentToolConfiguration FromGetDocumentText(global::Vectara.InlineGetDocumentTextToolConfiguration? value) => new AgentToolConfiguration(value);

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
            global::Vectara.InlineClientToolConfiguration? client,
            global::Vectara.InlineSubAgentToolConfiguration? subAgent,
            global::Vectara.InlineArtifactCreateToolConfiguration? artifactCreate,
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
            Client = client;
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
            Client as object ??
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
            Client?.ToString() ??
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
            return IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactCreate && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && IsGetDocumentText;
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
            global::System.Func<global::Vectara.InlineClientToolConfiguration?, TResult>? client = null,
            global::System.Func<global::Vectara.InlineSubAgentToolConfiguration?, TResult>? subAgent = null,
            global::System.Func<global::Vectara.InlineArtifactCreateToolConfiguration?, TResult>? artifactCreate = null,
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
            else if (IsClient && client != null)
            {
                return client(Client!);
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
            global::System.Action<global::Vectara.InlineDynamicVectaraToolConfiguration?>? dynamicVectara = null,

            global::System.Action<global::Vectara.InlineMcpToolConfiguration?>? mcp = null,

            global::System.Action<global::Vectara.InlineCorporaSearchToolConfiguration?>? corporaSearch = null,

            global::System.Action<global::Vectara.InlineWebSearchToolConfiguration?>? webSearch = null,

            global::System.Action<global::Vectara.InlineWebGetToolConfiguration?>? webGet = null,

            global::System.Action<global::Vectara.InlineLambdaToolConfiguration?>? lambda = null,

            global::System.Action<global::Vectara.InlineClientToolConfiguration?>? client = null,

            global::System.Action<global::Vectara.InlineSubAgentToolConfiguration?>? subAgent = null,

            global::System.Action<global::Vectara.InlineArtifactCreateToolConfiguration?>? artifactCreate = null,

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
            else if (IsClient)
            {
                client?.Invoke(Client!);
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
        public void Switch(
            global::System.Action<global::Vectara.InlineDynamicVectaraToolConfiguration?>? dynamicVectara = null,
            global::System.Action<global::Vectara.InlineMcpToolConfiguration?>? mcp = null,
            global::System.Action<global::Vectara.InlineCorporaSearchToolConfiguration?>? corporaSearch = null,
            global::System.Action<global::Vectara.InlineWebSearchToolConfiguration?>? webSearch = null,
            global::System.Action<global::Vectara.InlineWebGetToolConfiguration?>? webGet = null,
            global::System.Action<global::Vectara.InlineLambdaToolConfiguration?>? lambda = null,
            global::System.Action<global::Vectara.InlineClientToolConfiguration?>? client = null,
            global::System.Action<global::Vectara.InlineSubAgentToolConfiguration?>? subAgent = null,
            global::System.Action<global::Vectara.InlineArtifactCreateToolConfiguration?>? artifactCreate = null,
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
            else if (IsClient)
            {
                client?.Invoke(Client!);
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
                Client,
                typeof(global::Vectara.InlineClientToolConfiguration),
                SubAgent,
                typeof(global::Vectara.InlineSubAgentToolConfiguration),
                ArtifactCreate,
                typeof(global::Vectara.InlineArtifactCreateToolConfiguration),
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineClientToolConfiguration?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineSubAgentToolConfiguration?>.Default.Equals(SubAgent, other.SubAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineArtifactCreateToolConfiguration?>.Default.Equals(ArtifactCreate, other.ArtifactCreate) &&
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
