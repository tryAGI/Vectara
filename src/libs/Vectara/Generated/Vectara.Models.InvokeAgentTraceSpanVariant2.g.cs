
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvokeAgentTraceSpanVariant2
    {
        /// <summary>
        /// The operation type for this span.<br/>
        /// Default Value: invoke_agent<br/>
        /// Example: invoke_agent
        /// </summary>
        /// <default>"invoke_agent"</default>
        /// <example>invoke_agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; } = "invoke_agent";

        /// <summary>
        /// Attributes for an invoke_agent span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::Vectara.InvokeAgentSpanAttributes? Attributes { get; set; }

        /// <summary>
        /// Span content, only included when include_content=true is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Vectara.InvokeAgentSpanContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeAgentTraceSpanVariant2" /> class.
        /// </summary>
        /// <param name="operation">
        /// The operation type for this span.<br/>
        /// Default Value: invoke_agent<br/>
        /// Example: invoke_agent
        /// </param>
        /// <param name="attributes">
        /// Attributes for an invoke_agent span.
        /// </param>
        /// <param name="content">
        /// Span content, only included when include_content=true is requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvokeAgentTraceSpanVariant2(
            string operation,
            global::Vectara.InvokeAgentSpanAttributes? attributes,
            global::Vectara.InvokeAgentSpanContent? content)
        {
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.Attributes = attributes;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeAgentTraceSpanVariant2" /> class.
        /// </summary>
        public InvokeAgentTraceSpanVariant2()
        {
        }
    }
}