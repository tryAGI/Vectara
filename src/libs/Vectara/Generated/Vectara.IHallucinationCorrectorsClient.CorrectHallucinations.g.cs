#nullable enable

namespace Vectara
{
    public partial interface IHallucinationCorrectorsClient
    {
        /// <summary>
        /// Corrects hallucinations in generated text based on source documents<br/>
        /// This endpoint identifies information in generated text that is not supported by the provided source documents and offers corrections with minimal changes. This can be used standalone or as part of a RAG workflow where the HHEM score indicates potential hallucinations.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.HallucinationCorrectionResponse> CorrectHallucinationsAsync(
            global::Vectara.HallucinationCorrectionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Corrects hallucinations in generated text based on source documents<br/>
        /// This endpoint identifies information in generated text that is not supported by the provided source documents and offers corrections with minimal changes. This can be used standalone or as part of a RAG workflow where the HHEM score indicates potential hallucinations.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="generatedText">
        /// The generated text to be evaluated. The hallucination corrector reviews this text and applies corrections based on the provided source documents.
        /// </param>
        /// <param name="documents">
        /// The source documents that were used to generate the text.
        /// </param>
        /// <param name="model">
        /// The name of the LLM model to use for hallucination correction.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.HallucinationCorrectionResponse> CorrectHallucinationsAsync(
            string generatedText,
            global::System.Collections.Generic.IList<global::Vectara.HcmSourceDocument> documents,
            string model,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}