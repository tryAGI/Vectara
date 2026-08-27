
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The model parameters for the evaluation.
    /// </summary>
    public sealed partial class EvaluateFactualConsistencyRequestModelParameters
    {
        /// <summary>
        /// The name of the model to use for evaluation. `hhem_v2.3` is the default and the recommended model. `hhem_v2.2` is retired; it remains accepted for backward compatibility and is served by `hhem_v2.3`. Any other value is rejected.<br/>
        /// Default Value: hhem_v2.3<br/>
        /// Example: hhem_v2.3
        /// </summary>
        /// <example>hhem_v2.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateFactualConsistencyRequestModelParameters" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the model to use for evaluation. `hhem_v2.3` is the default and the recommended model. `hhem_v2.2` is retired; it remains accepted for backward compatibility and is served by `hhem_v2.3`. Any other value is rejected.<br/>
        /// Default Value: hhem_v2.3<br/>
        /// Example: hhem_v2.3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluateFactualConsistencyRequestModelParameters(
            string? modelName)
        {
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateFactualConsistencyRequestModelParameters" /> class.
        /// </summary>
        public EvaluateFactualConsistencyRequestModelParameters()
        {
        }

    }
}