#nullable enable

namespace Vectara
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Create a corpus<br/>
        /// Create a corpus, which is a container to store documents and associated metadata. This is where you <br/>
        /// create the unique `corpus_key` that identifies the corpus. The `corpus_key` can be custom-defined <br/>
        /// following your preferred naming convention, allowing you to easily manage the corpus's data and <br/>
        /// reference it in queries. For more information, see <br/>
        /// [Corpus Key Definition](https://docs.vectara.com/docs/api-reference/search-apis/search#corpus-key-definition).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Corpus> CreateCorpusAsync(
            global::Vectara.CreateCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a corpus<br/>
        /// Create a corpus, which is a container to store documents and associated metadata. This is where you <br/>
        /// create the unique `corpus_key` that identifies the corpus. The `corpus_key` can be custom-defined <br/>
        /// following your preferred naming convention, allowing you to easily manage the corpus's data and <br/>
        /// reference it in queries. For more information, see <br/>
        /// [Corpus Key Definition](https://docs.vectara.com/docs/api-reference/search-apis/search#corpus-key-definition).
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
        /// <param name="queriesAreAnswers">
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="documentsAreQuestions">
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encoderName">
        /// The encoder used by the corpus.<br/>
        /// Example: boomerang
        /// </param>
        /// <param name="filterAttributes">
        /// The new filter attributes of the corpus. <br/>
        /// If unset then the corpus will not have filter attributes.
        /// </param>
        /// <param name="customDimensions">
        /// A custom dimension is an additional numerical field attached to a document part. You<br/>
        /// can then multiply this numerical field with a query time custom dimension of the same<br/>
        /// name. This allows boosting (or burying) document parts for arbitrary reasons.<br/>
        /// This feature is only enabled for Scale customers.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Corpus> CreateCorpusAsync(
            string key,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            bool? queriesAreAnswers = default,
            bool? documentsAreQuestions = default,
            string? encoderName = default,
            global::System.Collections.Generic.IList<global::Vectara.FilterAttribute>? filterAttributes = default,
            global::System.Collections.Generic.IList<global::Vectara.CorpusCustomDimension>? customDimensions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}