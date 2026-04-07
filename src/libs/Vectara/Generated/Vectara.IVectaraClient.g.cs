
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
    public partial interface IVectaraClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AgentArtifactsClient AgentArtifacts { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentEventsClient AgentEvents { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentSchedulesClient AgentSchedules { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentSessionsClient AgentSessions { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentsClient Agents { get; }

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppClientsClient AppClients { get; }

        /// <summary>
        /// Authenticate with the API using OAuth 2.0 or API keys.
        /// </summary>
        public AuthenticationClient Authentication { get; }

        /// <summary>
        /// 
        /// </summary>
        public CorporaClient Corpora { get; }

        /// <summary>
        /// 
        /// </summary>
        public DocumentsClient Documents { get; }

        /// <summary>
        /// 
        /// </summary>
        public EncodersClient Encoders { get; }

        /// <summary>
        /// 
        /// </summary>
        public FactualConsistencyClient FactualConsistency { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenerationPresetsClient GenerationPresets { get; }

        /// <summary>
        /// 
        /// </summary>
        public HallucinationCorrectorsClient HallucinationCorrectors { get; }

        /// <summary>
        /// 
        /// </summary>
        public InstructionsClient Instructions { get; }

        /// <summary>
        /// 
        /// </summary>
        public JobsClient Jobs { get; }

        /// <summary>
        /// 
        /// </summary>
        public LlmClient Llm { get; }

        /// <summary>
        /// 
        /// </summary>
        public LlmsClient Llms { get; }

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata { get; }

        /// <summary>
        /// 
        /// </summary>
        public QueriesClient Queries { get; }

        /// <summary>
        /// 
        /// </summary>
        public QueryHistoryClient QueryHistory { get; }

        /// <summary>
        /// 
        /// </summary>
        public RerankersClient Rerankers { get; }

        /// <summary>
        /// 
        /// </summary>
        public TableExtractorsClient TableExtractors { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToolServersClient ToolServers { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// 
        /// </summary>
        public UploadClient Upload { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

    }
}