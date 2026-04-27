
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteToolTraceSpanVariant2
    {
        /// <summary>
        /// The operation type for this span.<br/>
        /// Default Value: execute_tool<br/>
        /// Example: execute_tool
        /// </summary>
        /// <default>"execute_tool"</default>
        /// <example>execute_tool</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; } = "execute_tool";

        /// <summary>
        /// Attributes for an execute_tool span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::Vectara.ExecuteToolSpanAttributes? Attributes { get; set; }

        /// <summary>
        /// Span content, only included when include_content=true is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Vectara.ExecuteToolSpanContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteToolTraceSpanVariant2" /> class.
        /// </summary>
        /// <param name="operation">
        /// The operation type for this span.<br/>
        /// Default Value: execute_tool<br/>
        /// Example: execute_tool
        /// </param>
        /// <param name="attributes">
        /// Attributes for an execute_tool span.
        /// </param>
        /// <param name="content">
        /// Span content, only included when include_content=true is requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteToolTraceSpanVariant2(
            string operation,
            global::Vectara.ExecuteToolSpanAttributes? attributes,
            global::Vectara.ExecuteToolSpanContent? content)
        {
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.Attributes = attributes;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteToolTraceSpanVariant2" /> class.
        /// </summary>
        public ExecuteToolTraceSpanVariant2()
        {
        }
    }
}