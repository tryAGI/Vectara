
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailTraceSpanVariant2
    {
        /// <summary>
        /// The operation type for this span.<br/>
        /// Default Value: guardrail<br/>
        /// Example: guardrail
        /// </summary>
        /// <default>"guardrail"</default>
        /// <example>guardrail</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; } = "guardrail";

        /// <summary>
        /// Attributes for a guardrail span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::Vectara.GuardrailSpanAttributes? Attributes { get; set; }

        /// <summary>
        /// Span content, only included when include_content=true is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Vectara.GuardrailSpanContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailTraceSpanVariant2" /> class.
        /// </summary>
        /// <param name="operation">
        /// The operation type for this span.<br/>
        /// Default Value: guardrail<br/>
        /// Example: guardrail
        /// </param>
        /// <param name="attributes">
        /// Attributes for a guardrail span.
        /// </param>
        /// <param name="content">
        /// Span content, only included when include_content=true is requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailTraceSpanVariant2(
            string operation,
            global::Vectara.GuardrailSpanAttributes? attributes,
            global::Vectara.GuardrailSpanContent? content)
        {
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.Attributes = attributes;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailTraceSpanVariant2" /> class.
        /// </summary>
        public GuardrailTraceSpanVariant2()
        {
        }
    }
}