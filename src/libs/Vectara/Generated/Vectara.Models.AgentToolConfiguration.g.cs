#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool configuration available to an agent, either defined inline with a specific configuration type,<br/>
    /// or referencing a reusable tool configuration by its key (`type: reference`).<br/>
    /// Example: [{"type":"reference","tool_configuration_key":"shared_kb_search"}, {"type":"web_search","argument_override":{"limit":5,"include_domains":["github.com","stackoverflow.com"],"exclude_domains":["spam.com"]}}]
    /// </summary>
    public readonly partial struct AgentToolConfiguration : global::System.IEquatable<AgentToolConfiguration>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentToolConfigurationDiscriminatorType? Type { get; }

        /// <summary>
        /// References a reusable tool configuration by its key. The configuration is managed independently via<br/>
        /// the Tool Configurations API and can be shared across agents. The agent-facing tool name is the key<br/>
        /// of this entry in the agent's `tool_configurations` map, which may differ from the configuration's own name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ToolConfigurationReference? Reference { get; init; }
#else
        public global::Vectara.ToolConfigurationReference? Reference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reference))]
#endif
        public bool IsReference => Reference != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ToolConfigurationReference? value)
        {
            value = Reference;
            return IsReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ToolConfigurationReference PickReference() => IsReference
            ? Reference!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reference' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickDynamicVectara(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.DynamicVectaraToolConfiguration? value)
        {
            value = DynamicVectara;
            return IsDynamicVectara;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.DynamicVectaraToolConfiguration PickDynamicVectara() => IsDynamicVectara
            ? DynamicVectara!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DynamicVectara' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.McpToolConfiguration? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.McpToolConfiguration PickMcp() => IsMcp
            ? Mcp!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickCorporaSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CorporaSearchToolConfiguration? value)
        {
            value = CorporaSearch;
            return IsCorporaSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CorporaSearchToolConfiguration PickCorporaSearch() => IsCorporaSearch
            ? CorporaSearch!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CorporaSearch' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WebSearchToolConfiguration? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.WebSearchToolConfiguration PickWebSearch() => IsWebSearch
            ? WebSearch!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");

        /// <summary>
        /// A reusable configuration for a web get tool that stores predefined parameters for fetching content from URLs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebGetToolConfiguration? WebGet { get; init; }
#else
        public global::Vectara.WebGetToolConfiguration? WebGet { get; }
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
            out global::Vectara.WebGetToolConfiguration? value)
        {
            value = WebGet;
            return IsWebGet;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.WebGetToolConfiguration PickWebGet() => IsWebGet
            ? WebGet!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebGet' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickLambda(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.LambdaToolConfiguration? value)
        {
            value = Lambda;
            return IsLambda;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.LambdaToolConfiguration PickLambda() => IsLambda
            ? Lambda!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Lambda' but the value was {ToString()}.");

        /// <summary>
        /// A client tool configuration.<br/>
        /// When invoked, the agent emits a `tool_input` event and waits for the calling client to submit a matching tool output.<br/>
        /// Only valid inline on an agent; client tools are not reusable across agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ClientToolConfiguration? Client { get; init; }
#else
        public global::Vectara.ClientToolConfiguration? Client { get; }
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
            out global::Vectara.ClientToolConfiguration? value)
        {
            value = Client;
            return IsClient;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ClientToolConfiguration PickClient() => IsClient
            ? Client!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Client' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickSubAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SubAgentToolConfiguration? value)
        {
            value = SubAgent;
            return IsSubAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SubAgentToolConfiguration PickSubAgent() => IsSubAgent
            ? SubAgent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubAgent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickArtifactRead(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ArtifactReadToolConfiguration? value)
        {
            value = ArtifactRead;
            return IsArtifactRead;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ArtifactReadToolConfiguration PickArtifactRead() => IsArtifactRead
            ? ArtifactRead!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactRead' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickArtifactGrep(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ArtifactGrepToolConfiguration? value)
        {
            value = ArtifactGrep;
            return IsArtifactGrep;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ArtifactGrepToolConfiguration PickArtifactGrep() => IsArtifactGrep
            ? ArtifactGrep!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactGrep' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickImageRead(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ImageReadToolConfiguration? value)
        {
            value = ImageRead;
            return IsImageRead;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ImageReadToolConfiguration PickImageRead() => IsImageRead
            ? ImageRead!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageRead' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickDocumentConversion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.DocumentConversionToolConfiguration? value)
        {
            value = DocumentConversion;
            return IsDocumentConversion;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.DocumentConversionToolConfiguration PickDocumentConversion() => IsDocumentConversion
            ? DocumentConversion!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DocumentConversion' but the value was {ToString()}.");

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
        public bool TryPickGetDocumentText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GetDocumentTextToolConfiguration? value)
        {
            value = GetDocumentText;
            return IsGetDocumentText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GetDocumentTextToolConfiguration PickGetDocumentText() => IsGetDocumentText
            ? GetDocumentText!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetDocumentText' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.ToolConfigurationReference value) => new AgentToolConfiguration((global::Vectara.ToolConfigurationReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationReference?(AgentToolConfiguration @this) => @this.Reference;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.ToolConfigurationReference? value)
        {
            Reference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromReference(global::Vectara.ToolConfigurationReference? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.DynamicVectaraToolConfiguration value) => new AgentToolConfiguration((global::Vectara.DynamicVectaraToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DynamicVectaraToolConfiguration?(AgentToolConfiguration @this) => @this.DynamicVectara;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.DynamicVectaraToolConfiguration? value)
        {
            DynamicVectara = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromDynamicVectara(global::Vectara.DynamicVectaraToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.McpToolConfiguration value) => new AgentToolConfiguration((global::Vectara.McpToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.McpToolConfiguration?(AgentToolConfiguration @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.McpToolConfiguration? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromMcp(global::Vectara.McpToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.CorporaSearchToolConfiguration value) => new AgentToolConfiguration((global::Vectara.CorporaSearchToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CorporaSearchToolConfiguration?(AgentToolConfiguration @this) => @this.CorporaSearch;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.CorporaSearchToolConfiguration? value)
        {
            CorporaSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromCorporaSearch(global::Vectara.CorporaSearchToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.WebSearchToolConfiguration value) => new AgentToolConfiguration((global::Vectara.WebSearchToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WebSearchToolConfiguration?(AgentToolConfiguration @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.WebSearchToolConfiguration? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromWebSearch(global::Vectara.WebSearchToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.WebGetToolConfiguration value) => new AgentToolConfiguration((global::Vectara.WebGetToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WebGetToolConfiguration?(AgentToolConfiguration @this) => @this.WebGet;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.WebGetToolConfiguration? value)
        {
            WebGet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromWebGet(global::Vectara.WebGetToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.LambdaToolConfiguration value) => new AgentToolConfiguration((global::Vectara.LambdaToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.LambdaToolConfiguration?(AgentToolConfiguration @this) => @this.Lambda;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.LambdaToolConfiguration? value)
        {
            Lambda = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromLambda(global::Vectara.LambdaToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.ClientToolConfiguration value) => new AgentToolConfiguration((global::Vectara.ClientToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ClientToolConfiguration?(AgentToolConfiguration @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.ClientToolConfiguration? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromClient(global::Vectara.ClientToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.SubAgentToolConfiguration value) => new AgentToolConfiguration((global::Vectara.SubAgentToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SubAgentToolConfiguration?(AgentToolConfiguration @this) => @this.SubAgent;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.SubAgentToolConfiguration? value)
        {
            SubAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromSubAgent(global::Vectara.SubAgentToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.ArtifactReadToolConfiguration value) => new AgentToolConfiguration((global::Vectara.ArtifactReadToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactReadToolConfiguration?(AgentToolConfiguration @this) => @this.ArtifactRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.ArtifactReadToolConfiguration? value)
        {
            ArtifactRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromArtifactRead(global::Vectara.ArtifactReadToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.ArtifactGrepToolConfiguration value) => new AgentToolConfiguration((global::Vectara.ArtifactGrepToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactGrepToolConfiguration?(AgentToolConfiguration @this) => @this.ArtifactGrep;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.ArtifactGrepToolConfiguration? value)
        {
            ArtifactGrep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromArtifactGrep(global::Vectara.ArtifactGrepToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.ImageReadToolConfiguration value) => new AgentToolConfiguration((global::Vectara.ImageReadToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageReadToolConfiguration?(AgentToolConfiguration @this) => @this.ImageRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.ImageReadToolConfiguration? value)
        {
            ImageRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromImageRead(global::Vectara.ImageReadToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.DocumentConversionToolConfiguration value) => new AgentToolConfiguration((global::Vectara.DocumentConversionToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DocumentConversionToolConfiguration?(AgentToolConfiguration @this) => @this.DocumentConversion;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.DocumentConversionToolConfiguration? value)
        {
            DocumentConversion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromDocumentConversion(global::Vectara.DocumentConversionToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::Vectara.GetDocumentTextToolConfiguration value) => new AgentToolConfiguration((global::Vectara.GetDocumentTextToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GetDocumentTextToolConfiguration?(AgentToolConfiguration @this) => @this.GetDocumentText;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::Vectara.GetDocumentTextToolConfiguration? value)
        {
            GetDocumentText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentToolConfiguration FromGetDocumentText(global::Vectara.GetDocumentTextToolConfiguration? value) => new AgentToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(
            global::Vectara.AgentToolConfigurationDiscriminatorType? type,
            global::Vectara.ToolConfigurationReference? reference,
            global::Vectara.DynamicVectaraToolConfiguration? dynamicVectara,
            global::Vectara.McpToolConfiguration? mcp,
            global::Vectara.CorporaSearchToolConfiguration? corporaSearch,
            global::Vectara.WebSearchToolConfiguration? webSearch,
            global::Vectara.WebGetToolConfiguration? webGet,
            global::Vectara.LambdaToolConfiguration? lambda,
            global::Vectara.ClientToolConfiguration? client,
            global::Vectara.SubAgentToolConfiguration? subAgent,
            global::Vectara.ArtifactReadToolConfiguration? artifactRead,
            global::Vectara.ArtifactGrepToolConfiguration? artifactGrep,
            global::Vectara.ImageReadToolConfiguration? imageRead,
            global::Vectara.DocumentConversionToolConfiguration? documentConversion,
            global::Vectara.GetDocumentTextToolConfiguration? getDocumentText
            )
        {
            Type = type;

            Reference = reference;
            DynamicVectara = dynamicVectara;
            Mcp = mcp;
            CorporaSearch = corporaSearch;
            WebSearch = webSearch;
            WebGet = webGet;
            Lambda = lambda;
            Client = client;
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
            Client as object ??
            Lambda as object ??
            WebGet as object ??
            WebSearch as object ??
            CorporaSearch as object ??
            Mcp as object ??
            DynamicVectara as object ??
            Reference as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Reference?.ToString() ??
            DynamicVectara?.ToString() ??
            Mcp?.ToString() ??
            CorporaSearch?.ToString() ??
            WebSearch?.ToString() ??
            WebGet?.ToString() ??
            Lambda?.ToString() ??
            Client?.ToString() ??
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
            return IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && IsDocumentConversion && !IsGetDocumentText || !IsReference && !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsClient && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && IsGetDocumentText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationReference?, TResult>? reference = null,
            global::System.Func<global::Vectara.DynamicVectaraToolConfiguration?, TResult>? dynamicVectara = null,
            global::System.Func<global::Vectara.McpToolConfiguration?, TResult>? mcp = null,
            global::System.Func<global::Vectara.CorporaSearchToolConfiguration?, TResult>? corporaSearch = null,
            global::System.Func<global::Vectara.WebSearchToolConfiguration?, TResult>? webSearch = null,
            global::System.Func<global::Vectara.WebGetToolConfiguration?, TResult>? webGet = null,
            global::System.Func<global::Vectara.LambdaToolConfiguration?, TResult>? lambda = null,
            global::System.Func<global::Vectara.ClientToolConfiguration?, TResult>? client = null,
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

            if (IsReference && reference != null)
            {
                return reference(Reference!);
            }
            else if (IsDynamicVectara && dynamicVectara != null)
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
            global::System.Action<global::Vectara.ToolConfigurationReference?>? reference = null,

            global::System.Action<global::Vectara.DynamicVectaraToolConfiguration?>? dynamicVectara = null,

            global::System.Action<global::Vectara.McpToolConfiguration?>? mcp = null,

            global::System.Action<global::Vectara.CorporaSearchToolConfiguration?>? corporaSearch = null,

            global::System.Action<global::Vectara.WebSearchToolConfiguration?>? webSearch = null,

            global::System.Action<global::Vectara.WebGetToolConfiguration?>? webGet = null,

            global::System.Action<global::Vectara.LambdaToolConfiguration?>? lambda = null,

            global::System.Action<global::Vectara.ClientToolConfiguration?>? client = null,

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

            if (IsReference)
            {
                reference?.Invoke(Reference!);
            }
            else if (IsDynamicVectara)
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
            global::System.Action<global::Vectara.ToolConfigurationReference?>? reference = null,
            global::System.Action<global::Vectara.DynamicVectaraToolConfiguration?>? dynamicVectara = null,
            global::System.Action<global::Vectara.McpToolConfiguration?>? mcp = null,
            global::System.Action<global::Vectara.CorporaSearchToolConfiguration?>? corporaSearch = null,
            global::System.Action<global::Vectara.WebSearchToolConfiguration?>? webSearch = null,
            global::System.Action<global::Vectara.WebGetToolConfiguration?>? webGet = null,
            global::System.Action<global::Vectara.LambdaToolConfiguration?>? lambda = null,
            global::System.Action<global::Vectara.ClientToolConfiguration?>? client = null,
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

            if (IsReference)
            {
                reference?.Invoke(Reference!);
            }
            else if (IsDynamicVectara)
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
                Reference,
                typeof(global::Vectara.ToolConfigurationReference),
                DynamicVectara,
                typeof(global::Vectara.DynamicVectaraToolConfiguration),
                Mcp,
                typeof(global::Vectara.McpToolConfiguration),
                CorporaSearch,
                typeof(global::Vectara.CorporaSearchToolConfiguration),
                WebSearch,
                typeof(global::Vectara.WebSearchToolConfiguration),
                WebGet,
                typeof(global::Vectara.WebGetToolConfiguration),
                Lambda,
                typeof(global::Vectara.LambdaToolConfiguration),
                Client,
                typeof(global::Vectara.ClientToolConfiguration),
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
        public bool Equals(AgentToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationReference?>.Default.Equals(Reference, other.Reference) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DynamicVectaraToolConfiguration?>.Default.Equals(DynamicVectara, other.DynamicVectara) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.McpToolConfiguration?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CorporaSearchToolConfiguration?>.Default.Equals(CorporaSearch, other.CorporaSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebSearchToolConfiguration?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetToolConfiguration?>.Default.Equals(WebGet, other.WebGet) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.LambdaToolConfiguration?>.Default.Equals(Lambda, other.Lambda) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ClientToolConfiguration?>.Default.Equals(Client, other.Client) &&
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
