#nullable enable

namespace Vectara
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Create a corpus<br/>
        /// Create a corpus, which is a container to store documents and associated metadata. Here, you define the unique `corpus_key` that identifies the corpus. The `corpus_key` can be custom-defined following your preferred naming convention, allowing you to easily manage the corpus's data and reference it in queries. For more information, see [Corpus Key Definition](https://docs.vectara.com/docs/api-reference/search-apis/search#corpus-key-definition).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Corpus> CreateCorpusAsync(
            global::Vectara.CreateCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a corpus<br/>
        /// Create a corpus, which is a container to store documents and associated metadata. Here, you define the unique `corpus_key` that identifies the corpus. The `corpus_key` can be custom-defined following your preferred naming convention, allowing you to easily manage the corpus's data and reference it in queries. For more information, see [Corpus Key Definition](https://docs.vectara.com/docs/api-reference/search-apis/search#corpus-key-definition).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="key">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="name">
        /// The name for the corpus. This value defaults to the key.<br/>
        /// Example: My corpus
        /// </param>
        /// <param name="description">
        /// Description of the corpus.<br/>
        /// Example: Documents with important information for my prompt.
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save corpus queries to query history by default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="queriesAreAnswers">
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="documentsAreQuestions">
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encoderName">
        /// The encoder used by the corpus, `boomerang-2023-q3`.<br/>
        /// Example: boomerang-2023-q3
        /// </param>
        /// <param name="filterAttributes">
        /// The new filter attributes of the corpus. If unset then the corpus will not have filter attributes.
        /// </param>
        /// <param name="customDimensions">
        /// A custom dimension is an additional numerical field attached to a document part. You can then multiply this numerical field with a query time custom dimension of the same name. This allows boosting (or burying) document parts for arbitrary reasons. This feature is only enabled for Pro and Enterprise customers.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Corpus> CreateCorpusAsync(
            string key,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            bool? saveHistory = default,
            bool? queriesAreAnswers = default,
            bool? documentsAreQuestions = default,
            string? encoderName = default,
            global::System.Collections.Generic.IList<global::Vectara.FilterAttribute>? filterAttributes = default,
            global::System.Collections.Generic.IList<global::Vectara.CorpusCustomDimension>? customDimensions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}