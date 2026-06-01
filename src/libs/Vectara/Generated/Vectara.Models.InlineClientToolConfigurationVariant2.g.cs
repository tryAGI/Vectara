
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InlineClientToolConfigurationVariant2
    {
        /// <summary>
        /// The type of tool configuration, which is always 'client' for inline client tool configurations.<br/>
        /// Default Value: client
        /// </summary>
        /// <default>"client"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "client";

        /// <summary>
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>tol_123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// Optional hardcoded arguments that will be merged into the LLM-generated arguments before dispatch to the client.<br/>
        /// Example: {"channel":"support"}
        /// </summary>
        /// <example>{"channel":"support"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public object? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineClientToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'client' for inline client tool configurations.<br/>
        /// Default Value: client
        /// </param>
        /// <param name="toolId">
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="argumentOverride">
        /// Optional hardcoded arguments that will be merged into the LLM-generated arguments before dispatch to the client.<br/>
        /// Example: {"channel":"support"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineClientToolConfigurationVariant2(
            string type,
            string toolId,
            object? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineClientToolConfigurationVariant2" /> class.
        /// </summary>
        public InlineClientToolConfigurationVariant2()
        {
        }

    }
}