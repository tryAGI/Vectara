
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientToolConfigurationVariant2
    {
        /// <summary>
        /// This should always be `client`.<br/>
        /// Default Value: client<br/>
        /// Example: client
        /// </summary>
        /// <default>"client"</default>
        /// <example>client</example>
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
        /// Optional hardcoded arguments merged into the LLM-generated arguments before dispatch to the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public object? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `client`.<br/>
        /// Default Value: client<br/>
        /// Example: client
        /// </param>
        /// <param name="toolId">
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="argumentOverride">
        /// Optional hardcoded arguments merged into the LLM-generated arguments before dispatch to the client.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolConfigurationVariant2(
            string type,
            string toolId,
            object? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolConfigurationVariant2" /> class.
        /// </summary>
        public ClientToolConfigurationVariant2()
        {
        }

    }
}