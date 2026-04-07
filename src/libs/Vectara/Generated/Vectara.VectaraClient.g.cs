
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The Vectara Platform to context engineer Enterprise Agents. The REST API gives you server-side control with enterprise-grade RBAC, multi-tenancy, and full observability. Build agents that combine Vectara's multimodal retrieval with tool use, structured instructions, and managed sessions — all through simple REST endpoints.<br/>
    /// All endpoints live at `https://api.vectara.io/v2/&lt;resource&gt;` using lowercase, hyphenated paths (e.g. `/corpora/:corpus_key/documents`).<br/>
    /// ## API conventions<br/>
    /// We follow standard REST conventions: `GET` to read, `POST` to create, `PATCH` to update, `PUT` to replace, and `DELETE` to remove. Actions that don't map to CRUD verbs use a separate `POST /&lt;resource&gt;/&lt;action&gt;` path (e.g. `POST /corpora/:corpus_key/reset`).<br/>
    /// **Backward compatibility** — New fields may be added to any response at any time. Fields are never removed, only deprecated. Clients should ignore unknown fields. We aim for strong backward compatibility, though the agentic AI space is evolving rapidly and agent-related APIs may see more frequent additions.<br/>
    /// ## Authentication methods<br/>
    /// Every API request must be authenticated using one of these methods:<br/>
    /// **API Key** — Pass your key in the `x-api-key` header. Create API keys with precise roles for least-privilege access, or use personal API keys that inherit the same roles as your user account.<br/>
    /// **OAuth 2.0** — Use the client credentials flow to obtain a JWT token from `https://auth.vectara.io/oauth2/token`, then pass it in the `Authorization: Bearer &lt;token&gt;` header. Tokens expire after 30 minutes.<br/>
    /// ## Role-based access control<br/>
    /// Each endpoint requires specific roles. The role badges on each endpoint page show which roles grant access. Vectara uses three role types:<br/>
    /// **API Roles** (account-wide, assigned to users): Roles like `owner`, `administrator`, `corpus_administrator`, `corpus_developer`, `corpus_viewer`, `agent_administrator`, `agent_developer`, `agent_viewer`, `agent_user`, `pipeline_administrator`, `pipeline_viewer`, and `viewer`. These grant access across all resources of that type.<br/>
    /// **Corpus Roles** (per-corpus, assigned on specific corpora): `owner`, `administrator`, `editor`, `viewer`. These grant access to a specific corpus only.<br/>
    /// **Agent Roles** (per-agent, assigned on specific agents): `agent_administrator`, `agent_developer`, `agent_viewer`, `agent_user`. These grant access to a specific agent only.<br/>
    /// A user's effective permissions are the union of their API roles, corpus roles, and agent roles. Higher roles in each hierarchy inherit lower role permissions. See [Role-based access control](/docs/security/authorization/role-based-access-control) for the full role hierarchy and assignment instructions.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class VectaraClient : global::Vectara.IVectaraClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.vectara.io";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Vectara.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif


        internal global::Vectara.VectaraClient.AutoSDKOAuth2Coordinator AutoSDKOAuth2State { get; set; } = new global::Vectara.VectaraClient.AutoSDKOAuth2Coordinator();
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Vectara.SourceGenerationContext.Default;


        /// <summary>
        /// 
        /// </summary>
        public AgentArtifactsClient AgentArtifacts => new AgentArtifactsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentEventsClient AgentEvents => new AgentEventsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentSchedulesClient AgentSchedules => new AgentSchedulesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentSessionsClient AgentSessions => new AgentSessionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public AppClientsClient AppClients => new AppClientsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Authenticate with the API using OAuth 2.0 or API keys.
        /// </summary>
        public AuthenticationClient Authentication => new AuthenticationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public CorporaClient Corpora => new CorporaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public DocumentsClient Documents => new DocumentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public EncodersClient Encoders => new EncodersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public FactualConsistencyClient FactualConsistency => new FactualConsistencyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public GenerationPresetsClient GenerationPresets => new GenerationPresetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public HallucinationCorrectorsClient HallucinationCorrectors => new HallucinationCorrectorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public InstructionsClient Instructions => new InstructionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public JobsClient Jobs => new JobsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public LlmClient Llm => new LlmClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public LlmsClient Llms => new LlmsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata => new MetadataClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public QueriesClient Queries => new QueriesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public QueryHistoryClient QueryHistory => new QueryHistoryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public RerankersClient Rerankers => new RerankersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public TableExtractorsClient TableExtractors => new TableExtractorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolServersClient ToolServers => new ToolServersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public UploadClient Upload => new UploadClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Creates a new instance of the VectaraClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public VectaraClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Vectara.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Vectara.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}