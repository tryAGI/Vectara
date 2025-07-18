
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Vectara provides an end-to-end platform for creating GenAI products using a simple to use API.<br/>
    /// You can [sign up for an account](https://console.vectara.com/console/signup) and then view several [API Recipes](https://docs.vectara.com/docs/api-recipes) with example queries and parameter values.<br/>
    /// The Vectara API Playground lets you experiment with REST endpoints from your browser. Select an endpoint to view its definition, including the required or optional headers, body, responses, and sample commands. On the right side of each endpoint page, like [Get Corpus](/docs/rest-api/get-corpus), you manually enter your API Key or OAuth Bearer Token, `customer_id`, and then any required body parameters like the `corpusID` before sending the API request.<br/>
    /// :::note<br/>
    /// Vectara supports two primary methods of authentication: API keys and OAuth 2.0, which are applicable to all endpoints. Query API Keys are used for read-only querying operations, while Index API Keys provide read and write access. The OAuth 2.0 operations authenticate with a Bearer Token via the OAuth 2.0 client credentials grant. Review the [**OAuth 2.0 section**](https://docs.vectara.com/docs/learn/authentication/oauth-2) about how to generate the token.<br/>
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
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Vectara.SourceGenerationContext.Default;


        /// <summary>
        /// Authenticate with the API using OAuth 2.0 or API keys
        /// </summary>
        public AuthenticationClient Authentication => new AuthenticationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Perform search and Retrieval Augmented Generation (RAG) operations on one or more corpora
        /// </summary>
        public QueriesClient Queries => new QueriesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Upload files to a corpus for automatic parsing, text extraction, chunking, and indexing
        /// </summary>
        public UploadClient Upload => new UploadClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Index and manage both core and structured documents to enable efficient search and retrieval
        /// </summary>
        public IndexClient Index => new IndexClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Create, manage, and update corpora and their associated settings
        /// </summary>
        public CorporaClient Corpora => new CorporaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Retrieve and manage documents stored in a corpus for administrative tasks
        /// </summary>
        public DocumentsClient Documents => new DocumentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Create, manage, and interact with chat sessions for conversational AI
        /// </summary>
        public ChatsClient Chats => new ChatsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Manage generation presets for controlling the behavior of generative AI responses
        /// </summary>
        public GenerationPresetsClient GenerationPresets => new GenerationPresetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Retrieve and manage the history of previous queries for analytics and auditing
        /// </summary>
        public QueryHistoryClient QueryHistory => new QueryHistoryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Create, manage, and revoke API keys for secure access to the platform
        /// </summary>
        public APIKeysClient APIKeys => new APIKeysClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Configure and manage application clients for OAuth authentication
        /// </summary>
        public ApplicationClientsClient ApplicationClients => new ApplicationClientsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// List LLMs for text summarization, chat, and other generation tasks
        /// </summary>
        public LargeLanguageModelsClient LargeLanguageModels => new LargeLanguageModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// List available encoders (such as Boomerang) that turn text into vectors
        /// </summary>
        public EncodersClient Encoders => new EncodersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// List rerankers for reranking search results
        /// </summary>
        public RerankersClient Rerankers => new RerankersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Monitor background jobs such as rebuilding indexes or updating corpus settings
        /// </summary>
        public JobsClient Jobs => new JobsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Create, manage, and authenticate users within the platform for user administration
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// List available extractors for tabular data from documents
        /// </summary>
        public TableExtractorsClient TableExtractors => new TableExtractorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// API for managing hallucination correction, including listing available models and correcting hallucinated content in generated text
        /// </summary>
        public HallucinationCorrectorsClient HallucinationCorrectors => new HallucinationCorrectorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Create model responses for chat conversations using OpenAI-compatible endpoints
        /// </summary>
        public LLMChatCompletionsClient LLMChatCompletions => new LLMChatCompletionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Evaluate text quality metrics like factual consistency and hallucination detection
        /// </summary>
        public FactualConsistencyEvaluationClient FactualConsistencyEvaluation => new FactualConsistencyEvaluationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
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