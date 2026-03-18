
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebGetToolConfigurationRequestVariant1
    {
        /// <summary>
        /// This should always be `web_get`.<br/>
        /// Default Value: web_get<br/>
        /// Example: web_get
        /// </summary>
        /// <default>"web_get"</default>
        /// <example>web_get</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "web_get";

        /// <summary>
        /// Configurable parameters for the web get tool. If not provided, will be filled in by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::Vectara.WebGetToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebGetToolConfigurationRequestVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `web_get`.<br/>
        /// Default Value: web_get<br/>
        /// Example: web_get
        /// </param>
        /// <param name="argumentOverride">
        /// Configurable parameters for the web get tool. If not provided, will be filled in by the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebGetToolConfigurationRequestVariant1(
            string type,
            global::Vectara.WebGetToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebGetToolConfigurationRequestVariant1" /> class.
        /// </summary>
        public CreateWebGetToolConfigurationRequestVariant1()
        {
        }
    }
}