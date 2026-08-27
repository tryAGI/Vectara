#nullable enable

namespace Vectara
{
    public partial interface IFactualConsistencyClient
    {
        /// <summary>
        /// Evaluate factual consistency<br/>
        /// Evaluates the factual consistency of a generated text (like a summary) against source documents. The evaluation determines how accurately the generated text reflects the information in the source documents. This helps identify potential hallucinations or misrepresentations.<br/>
        /// Use this endpoint to validate generated content against trusted source materials, such as in legal, healthcare, scientific publishing, and enterprise knowledge systems.<br/>
        /// The request body includes the following parameters:<br/>
        /// * `model_parameters.model_name`: Optional. The evaluation model to use. `hhem_v2.3` is the default and the recommended model. `hhem_v2.2` is retired; it remains accepted for backward compatibility and is served by `hhem_v2.3`. Any other value is rejected with a `400`.<br/>
        /// * `generated_text`: The output text you want to evaluate, such as a model-generated summary, answer, or response.<br/>
        /// * `source_texts`: An array of source documents or passages used to verify the accuracy of the generated text.<br/>
        /// The endpoint scores the texts as given, in whatever language they are written. HHEM is trained on `eng`, `deu`, `fra`, `spa`, `por`, `ara`, `kor`, `zho`, `rus`, `jpn`, and `hin`; treat scores for text in other languages as unreliable.<br/>
        /// ### Example request<br/>
        /// This example evaluates whether a generated statement about the Eiffel Tower is factually accurate based on two reference documents.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "generated_text": "The Eiffel Tower is located in Berlin.",<br/>
        ///   "source_texts": [<br/>
        ///     "The Eiffel Tower is a famous landmark located in Paris, France.",<br/>
        ///     "It was built in 1889 and remains one of the most visited monuments in the world."<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes the factual consistency score.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "score": 0.23<br/>
        /// }<br/>
        /// ```<br/>
        /// * `score`: A normalized value between `0.0` and `1.0` that reflects the overall factual alignment between the generated text and the source texts. Higher scores indicate stronger consistency.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.EvaluateFactualConsistencyResponse> EvaluateAsync(

            global::Vectara.EvaluateFactualConsistencyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluate factual consistency<br/>
        /// Evaluates the factual consistency of a generated text (like a summary) against source documents. The evaluation determines how accurately the generated text reflects the information in the source documents. This helps identify potential hallucinations or misrepresentations.<br/>
        /// Use this endpoint to validate generated content against trusted source materials, such as in legal, healthcare, scientific publishing, and enterprise knowledge systems.<br/>
        /// The request body includes the following parameters:<br/>
        /// * `model_parameters.model_name`: Optional. The evaluation model to use. `hhem_v2.3` is the default and the recommended model. `hhem_v2.2` is retired; it remains accepted for backward compatibility and is served by `hhem_v2.3`. Any other value is rejected with a `400`.<br/>
        /// * `generated_text`: The output text you want to evaluate, such as a model-generated summary, answer, or response.<br/>
        /// * `source_texts`: An array of source documents or passages used to verify the accuracy of the generated text.<br/>
        /// The endpoint scores the texts as given, in whatever language they are written. HHEM is trained on `eng`, `deu`, `fra`, `spa`, `por`, `ara`, `kor`, `zho`, `rus`, `jpn`, and `hin`; treat scores for text in other languages as unreliable.<br/>
        /// ### Example request<br/>
        /// This example evaluates whether a generated statement about the Eiffel Tower is factually accurate based on two reference documents.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "generated_text": "The Eiffel Tower is located in Berlin.",<br/>
        ///   "source_texts": [<br/>
        ///     "The Eiffel Tower is a famous landmark located in Paris, France.",<br/>
        ///     "It was built in 1889 and remains one of the most visited monuments in the world."<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes the factual consistency score.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "score": 0.23<br/>
        /// }<br/>
        /// ```<br/>
        /// * `score`: A normalized value between `0.0` and `1.0` that reflects the overall factual alignment between the generated text and the source texts. Higher scores indicate stronger consistency.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.EvaluateFactualConsistencyResponse>> EvaluateAsResponseAsync(

            global::Vectara.EvaluateFactualConsistencyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluate factual consistency<br/>
        /// Evaluates the factual consistency of a generated text (like a summary) against source documents. The evaluation determines how accurately the generated text reflects the information in the source documents. This helps identify potential hallucinations or misrepresentations.<br/>
        /// Use this endpoint to validate generated content against trusted source materials, such as in legal, healthcare, scientific publishing, and enterprise knowledge systems.<br/>
        /// The request body includes the following parameters:<br/>
        /// * `model_parameters.model_name`: Optional. The evaluation model to use. `hhem_v2.3` is the default and the recommended model. `hhem_v2.2` is retired; it remains accepted for backward compatibility and is served by `hhem_v2.3`. Any other value is rejected with a `400`.<br/>
        /// * `generated_text`: The output text you want to evaluate, such as a model-generated summary, answer, or response.<br/>
        /// * `source_texts`: An array of source documents or passages used to verify the accuracy of the generated text.<br/>
        /// The endpoint scores the texts as given, in whatever language they are written. HHEM is trained on `eng`, `deu`, `fra`, `spa`, `por`, `ara`, `kor`, `zho`, `rus`, `jpn`, and `hin`; treat scores for text in other languages as unreliable.<br/>
        /// ### Example request<br/>
        /// This example evaluates whether a generated statement about the Eiffel Tower is factually accurate based on two reference documents.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "generated_text": "The Eiffel Tower is located in Berlin.",<br/>
        ///   "source_texts": [<br/>
        ///     "The Eiffel Tower is a famous landmark located in Paris, France.",<br/>
        ///     "It was built in 1889 and remains one of the most visited monuments in the world."<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes the factual consistency score.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "score": 0.23<br/>
        /// }<br/>
        /// ```<br/>
        /// * `score`: A normalized value between `0.0` and `1.0` that reflects the overall factual alignment between the generated text and the source texts. Higher scores indicate stronger consistency.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.EvaluateFactualConsistencyResponse> EvaluateAsync(
            string generatedText,
            global::System.Collections.Generic.IList<string> sourceTexts,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.EvaluateFactualConsistencyRequestModelParameters? modelParameters = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}