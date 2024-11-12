
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Event containing the factual consistency score.
    /// </summary>
    public sealed partial class FactualConsistencyScore
    {
        /// <summary>
        /// When the streaming event contains the factual consistency score, the<br/>
        /// type will be `factual_consistency_score`.<br/>
        /// Default Value: factual_consistency_score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The probability that the summary is factually consistent with the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factual_consistency_score")]
        public float? FactualConsistencyScore1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FactualConsistencyScore" /> class.
        /// </summary>
        /// <param name="type">
        /// When the streaming event contains the factual consistency score, the<br/>
        /// type will be `factual_consistency_score`.<br/>
        /// Default Value: factual_consistency_score
        /// </param>
        /// <param name="factualConsistencyScore1">
        /// The probability that the summary is factually consistent with the results.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FactualConsistencyScore(
            string? type,
            float? factualConsistencyScore1)
        {
            this.Type = type;
            this.FactualConsistencyScore1 = factualConsistencyScore1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactualConsistencyScore" /> class.
        /// </summary>
        public FactualConsistencyScore()
        {
        }
    }
}