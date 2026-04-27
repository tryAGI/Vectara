
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Attributes for a guardrail span.
    /// </summary>
    public sealed partial class GuardrailSpanAttributes
    {
        /// <summary>
        /// Whether the guardrail check passed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_passed")]
        public bool? GuardrailPassed { get; set; }

        /// <summary>
        /// The retry attempt number, if this span was retried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_attempt")]
        public int? RetryAttempt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailSpanAttributes" /> class.
        /// </summary>
        /// <param name="guardrailPassed">
        /// Whether the guardrail check passed.
        /// </param>
        /// <param name="retryAttempt">
        /// The retry attempt number, if this span was retried.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailSpanAttributes(
            bool? guardrailPassed,
            int? retryAttempt)
        {
            this.GuardrailPassed = guardrailPassed;
            this.RetryAttempt = retryAttempt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailSpanAttributes" /> class.
        /// </summary>
        public GuardrailSpanAttributes()
        {
        }
    }
}