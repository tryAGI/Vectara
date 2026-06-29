
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base Confluence source configuration. Ingests pages from the configured spaces<br/>
    /// and inherits each page's read restrictions and space permissions as document ACL. Works against<br/>
    /// both Confluence Cloud and Data Center.
    /// </summary>
    public sealed partial class BaseConfluenceSourceConfiguration
    {
        /// <summary>
        /// Default Value: confluence<br/>
        /// Example: confluence
        /// </summary>
        /// <default>"confluence"</default>
        /// <example>confluence</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "confluence";

        /// <summary>
        /// Base URL of your Confluence instance, e.g. `https://your-domain.atlassian.net` for Cloud or<br/>
        /// `https://confluence.example.com` for Data Center. The Cloud `/wiki` context path is added<br/>
        /// automatically, so it does not need to be included.<br/>
        /// Example: https://your-domain.atlassian.net
        /// </summary>
        /// <example>https://your-domain.atlassian.net</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Confluence deployment type. `cloud` for Atlassian-hosted Confluence Cloud. `data_center`<br/>
        /// for a self-hosted Confluence Data Center or legacy Server instance.<br/>
        /// Default Value: cloud
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.BaseConfluenceSourceConfigurationDeploymentJsonConverter))]
        public global::Vectara.BaseConfluenceSourceConfigurationDeployment? Deployment { get; set; }

        /// <summary>
        /// Space keys to ingest. When omitted, every global space the authenticated account can read is ingested.<br/>
        /// Example: [ENG, SUPPORT]
        /// </summary>
        /// <example>[ENG, SUPPORT]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("space_keys")]
        public global::System.Collections.Generic.IList<string>? SpaceKeys { get; set; }

        /// <summary>
        /// Authentication configuration for connecting to a remote service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RemoteAuthJsonConverter))]
        public global::Vectara.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseConfluenceSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: confluence<br/>
        /// Example: confluence
        /// </param>
        /// <param name="baseUrl">
        /// Base URL of your Confluence instance, e.g. `https://your-domain.atlassian.net` for Cloud or<br/>
        /// `https://confluence.example.com` for Data Center. The Cloud `/wiki` context path is added<br/>
        /// automatically, so it does not need to be included.<br/>
        /// Example: https://your-domain.atlassian.net
        /// </param>
        /// <param name="deployment">
        /// Confluence deployment type. `cloud` for Atlassian-hosted Confluence Cloud. `data_center`<br/>
        /// for a self-hosted Confluence Data Center or legacy Server instance.<br/>
        /// Default Value: cloud
        /// </param>
        /// <param name="spaceKeys">
        /// Space keys to ingest. When omitted, every global space the authenticated account can read is ingested.<br/>
        /// Example: [ENG, SUPPORT]
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for connecting to a remote service.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseConfluenceSourceConfiguration(
            string type,
            string? baseUrl,
            global::Vectara.BaseConfluenceSourceConfigurationDeployment? deployment,
            global::System.Collections.Generic.IList<string>? spaceKeys,
            global::Vectara.RemoteAuth? auth)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.BaseUrl = baseUrl;
            this.Deployment = deployment;
            this.SpaceKeys = spaceKeys;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseConfluenceSourceConfiguration" /> class.
        /// </summary>
        public BaseConfluenceSourceConfiguration()
        {
        }

    }
}