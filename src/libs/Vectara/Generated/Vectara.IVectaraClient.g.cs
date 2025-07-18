
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
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Authenticate with the API using OAuth 2.0 or API keys
        /// </summary>
        public AuthenticationClient Authentication { get; }

        /// <summary>
        /// Perform search and Retrieval Augmented Generation (RAG) operations on one or more corpora
        /// </summary>
        public QueriesClient Queries { get; }

        /// <summary>
        /// Upload files to a corpus for automatic parsing, text extraction, chunking, and indexing
        /// </summary>
        public UploadClient Upload { get; }

        /// <summary>
        /// Index and manage both core and structured documents to enable efficient search and retrieval
        /// </summary>
        public IndexClient Index { get; }

        /// <summary>
        /// Create, manage, and update corpora and their associated settings
        /// </summary>
        public CorporaClient Corpora { get; }

        /// <summary>
        /// Retrieve and manage documents stored in a corpus for administrative tasks
        /// </summary>
        public DocumentsClient Documents { get; }

        /// <summary>
        /// Create, manage, and interact with chat sessions for conversational AI
        /// </summary>
        public ChatsClient Chats { get; }

        /// <summary>
        /// Manage generation presets for controlling the behavior of generative AI responses
        /// </summary>
        public GenerationPresetsClient GenerationPresets { get; }

        /// <summary>
        /// Retrieve and manage the history of previous queries for analytics and auditing
        /// </summary>
        public QueryHistoryClient QueryHistory { get; }

        /// <summary>
        /// Create, manage, and revoke API keys for secure access to the platform
        /// </summary>
        public APIKeysClient APIKeys { get; }

        /// <summary>
        /// Configure and manage application clients for OAuth authentication
        /// </summary>
        public ApplicationClientsClient ApplicationClients { get; }

        /// <summary>
        /// List LLMs for text summarization, chat, and other generation tasks
        /// </summary>
        public LargeLanguageModelsClient LargeLanguageModels { get; }

        /// <summary>
        /// List available encoders (such as Boomerang) that turn text into vectors
        /// </summary>
        public EncodersClient Encoders { get; }

        /// <summary>
        /// List rerankers for reranking search results
        /// </summary>
        public RerankersClient Rerankers { get; }

        /// <summary>
        /// Monitor background jobs such as rebuilding indexes or updating corpus settings
        /// </summary>
        public JobsClient Jobs { get; }

        /// <summary>
        /// Create, manage, and authenticate users within the platform for user administration
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// List available extractors for tabular data from documents
        /// </summary>
        public TableExtractorsClient TableExtractors { get; }

        /// <summary>
        /// API for managing hallucination correction, including listing available models and correcting hallucinated content in generated text
        /// </summary>
        public HallucinationCorrectorsClient HallucinationCorrectors { get; }

        /// <summary>
        /// Create model responses for chat conversations using OpenAI-compatible endpoints
        /// </summary>
        public LLMChatCompletionsClient LLMChatCompletions { get; }

        /// <summary>
        /// Evaluate text quality metrics like factual consistency and hallucination detection
        /// </summary>
        public FactualConsistencyEvaluationClient FactualConsistencyEvaluation { get; }

    }
}