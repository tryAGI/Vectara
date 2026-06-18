
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Explicitly disables authentication.<br/>
    /// Useful in argument_override to force a tool config to clear any auth the agent would otherwise supply, since merge semantics ignore null patches.
    /// </summary>
    public sealed partial class WebGetNoAuth
    {
        /// <summary>
        /// Default Value: none<br/>
        /// Example: none
        /// </summary>
        /// <default>"none"</default>
        /// <example>none</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "none";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetNoAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: none<br/>
        /// Example: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebGetNoAuth(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetNoAuth" /> class.
        /// </summary>
        public WebGetNoAuth()
        {
        }

    }
}