
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGchatConnectorConfigurationVariant2
    {
        /// <summary>
        /// The type of connector configuration.<br/>
        /// Default Value: gchat<br/>
        /// Example: gchat
        /// </summary>
        /// <default>"gchat"</default>
        /// <example>gchat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "gchat";

        /// <summary>
        /// Service account JSON key used to authenticate outbound calls to the<br/>
        /// Google Chat API. Encrypted at rest. `client_email` is parsed out of this<br/>
        /// key for display in the read view.<br/>
        /// Example: {"type":"service_account","project_id":"my-gchat-app", ...}
        /// </summary>
        /// <example>{"type":"service_account","project_id":"my-gchat-app", ...}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGchatConnectorConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector configuration.<br/>
        /// Default Value: gchat<br/>
        /// Example: gchat
        /// </param>
        /// <param name="serviceAccountKey">
        /// Service account JSON key used to authenticate outbound calls to the<br/>
        /// Google Chat API. Encrypted at rest. `client_email` is parsed out of this<br/>
        /// key for display in the read view.<br/>
        /// Example: {"type":"service_account","project_id":"my-gchat-app", ...}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGchatConnectorConfigurationVariant2(
            string type,
            string serviceAccountKey)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ServiceAccountKey = serviceAccountKey ?? throw new global::System.ArgumentNullException(nameof(serviceAccountKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGchatConnectorConfigurationVariant2" /> class.
        /// </summary>
        public CreateGchatConnectorConfigurationVariant2()
        {
        }

    }
}