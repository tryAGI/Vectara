
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Decrypted content of a guardrail span.
    /// </summary>
    public sealed partial class GuardrailSpanContent
    {
        /// <summary>
        /// Details of guardrail violations found, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_issues")]
        public string? GuardrailIssues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailSpanContent" /> class.
        /// </summary>
        /// <param name="guardrailIssues">
        /// Details of guardrail violations found, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailSpanContent(
            string? guardrailIssues)
        {
            this.GuardrailIssues = guardrailIssues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailSpanContent" /> class.
        /// </summary>
        public GuardrailSpanContent()
        {
        }
    }
}