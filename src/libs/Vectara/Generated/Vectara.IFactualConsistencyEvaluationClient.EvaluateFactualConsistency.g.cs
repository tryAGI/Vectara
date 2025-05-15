#nullable enable

namespace Vectara
{
    public partial interface IFactualConsistencyEvaluationClient
    {
        /// <summary>
        /// Evaluate factual consistency<br/>
        /// Evaluate the factual consistency of a generated text (like a summary) against source documents. This determines how accurately the generated text reflects the information in the source documents, helping identify potential hallucinations or misrepresentations.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.EvaluateFactualConsistencyResponse> EvaluateFactualConsistencyAsync(
            global::Vectara.EvaluateFactualConsistencyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Evaluate factual consistency<br/>
        /// Evaluate the factual consistency of a generated text (like a summary) against source documents. This determines how accurately the generated text reflects the information in the source documents, helping identify potential hallucinations or misrepresentations.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="modelParameters">
        /// The model parameters for the evaluation.
        /// </param>
        /// <param name="generatedText">
        /// The generated text (e.g., summary or answer) to evaluate for factual consistency.
        /// </param>
        /// <param name="sourceTexts">
        /// The source documents or text snippets against which to evaluate factual consistency.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.EvaluateFactualConsistencyResponse> EvaluateFactualConsistencyAsync(
            string generatedText,
            global::System.Collections.Generic.IList<string> sourceTexts,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.EvaluateFactualConsistencyRequestModelParameters? modelParameters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}