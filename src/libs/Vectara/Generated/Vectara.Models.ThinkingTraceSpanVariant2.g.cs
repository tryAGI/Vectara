
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThinkingTraceSpanVariant2
    {
        /// <summary>
        /// The operation type for this span.<br/>
        /// Default Value: thinking<br/>
        /// Example: thinking
        /// </summary>
        /// <default>"thinking"</default>
        /// <example>thinking</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; } = "thinking";

        /// <summary>
        /// Span content, only included when include_content=true is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Vectara.ThinkingSpanContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingTraceSpanVariant2" /> class.
        /// </summary>
        /// <param name="operation">
        /// The operation type for this span.<br/>
        /// Default Value: thinking<br/>
        /// Example: thinking
        /// </param>
        /// <param name="content">
        /// Span content, only included when include_content=true is requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkingTraceSpanVariant2(
            string operation,
            global::Vectara.ThinkingSpanContent? content)
        {
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingTraceSpanVariant2" /> class.
        /// </summary>
        public ThinkingTraceSpanVariant2()
        {
        }

    }
}