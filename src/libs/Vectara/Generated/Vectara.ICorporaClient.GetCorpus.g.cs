#nullable enable

namespace Vectara
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Retrieve metadata about a corpus<br/>
        /// Get metadata about a corpus. This operation does not search the corpus contents. <br/>
        /// Specify the `corpus_key` to identify the corpus whose metadata you want to <br/>
        /// retrieve. The `corpus_key` is created when the corpus is set up, either through<br/>
        /// the Vectara Console UI or the Create Corpus API. For more information, <br/>
        /// see [Corpus Key Definition](https://docs.vectara.com/docs/api-reference/search-apis/search#corpus-key-definition).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Corpus> GetCorpusAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}