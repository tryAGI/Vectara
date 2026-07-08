
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base Fluid Topics source configuration. Ingests content from a Fluid Topics tenant via the<br/>
    /// Knowledge Hub REST API. `content_scope` selects which layer to ingest — `documents` (standalone<br/>
    /// items) or `topics` (the sections inside publications, each carrying its parent map's identity and<br/>
    /// classification). Every record carries its full Fluid Topics metadata, including classification and<br/>
    /// entitlement fields, as document metadata for attribute-based filtering and access control. Requires<br/>
    /// a Fluid Topics API key with read access to the configured content.
    /// </summary>
    public sealed partial class BaseFluidtopicsSourceConfiguration
    {
        /// <summary>
        /// Default Value: fluidtopics<br/>
        /// Example: fluidtopics
        /// </summary>
        /// <example>fluidtopics</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Base URL of the Fluid Topics tenant.<br/>
        /// Example: https://example.fluidtopics.net
        /// </summary>
        /// <example>https://example.fluidtopics.net</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Fluid Topics API key, sent as an HTTP Bearer authorization token. Generate one in the Fluid<br/>
        /// Topics administration interface under Integrations, API keys — see<br/>
        /// https://doc.fluidtopics.com/r/Fluid-Topics-Configuration-and-Administration-Guide/Configure-a-Fluid-Topics-tenant/Integrations/API-keys.<br/>
        /// Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Which Fluid Topics content layer to ingest. `documents` enumerates standalone documents;<br/>
        /// `topics` enumerates the topics within publications, iterating map by map so each topic carries<br/>
        /// its parent map's identity and classification.<br/>
        /// Default Value: documents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.BaseFluidtopicsSourceConfigurationContentScopeJsonConverter))]
        public global::Vectara.BaseFluidtopicsSourceConfigurationContentScope? ContentScope { get; set; }

        /// <summary>
        /// Search query used to select the content to ingest. Defaults to `*` (all content).<br/>
        /// Default Value: *<br/>
        /// Example: *
        /// </summary>
        /// <example>*</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Restricts ingestion to a single content locale (Fluid Topics `contentLocale`), for example `en-US`. When unset, all locales are ingested.<br/>
        /// Example: en-US
        /// </summary>
        /// <example>en-US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Restricts ingestion to records matching the given Fluid Topics metadata, as a map of metadata<br/>
        /// key to the list of accepted values. For example `{"Disclosure": ["Public"]}` ingests only<br/>
        /// public content. When unset, no metadata filter is applied.<br/>
        /// Example: {"Disclosure":["Public"]}
        /// </summary>
        /// <example>{"Disclosure":["Public"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFluidtopicsSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: fluidtopics<br/>
        /// Example: fluidtopics
        /// </param>
        /// <param name="baseUrl">
        /// Base URL of the Fluid Topics tenant.<br/>
        /// Example: https://example.fluidtopics.net
        /// </param>
        /// <param name="apiKey">
        /// Fluid Topics API key, sent as an HTTP Bearer authorization token. Generate one in the Fluid<br/>
        /// Topics administration interface under Integrations, API keys — see<br/>
        /// https://doc.fluidtopics.com/r/Fluid-Topics-Configuration-and-Administration-Guide/Configure-a-Fluid-Topics-tenant/Integrations/API-keys.<br/>
        /// Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="contentScope">
        /// Which Fluid Topics content layer to ingest. `documents` enumerates standalone documents;<br/>
        /// `topics` enumerates the topics within publications, iterating map by map so each topic carries<br/>
        /// its parent map's identity and classification.<br/>
        /// Default Value: documents
        /// </param>
        /// <param name="query">
        /// Search query used to select the content to ingest. Defaults to `*` (all content).<br/>
        /// Default Value: *<br/>
        /// Example: *
        /// </param>
        /// <param name="locale">
        /// Restricts ingestion to a single content locale (Fluid Topics `contentLocale`), for example `en-US`. When unset, all locales are ingested.<br/>
        /// Example: en-US
        /// </param>
        /// <param name="filters">
        /// Restricts ingestion to records matching the given Fluid Topics metadata, as a map of metadata<br/>
        /// key to the list of accepted values. For example `{"Disclosure": ["Public"]}` ingests only<br/>
        /// public content. When unset, no metadata filter is applied.<br/>
        /// Example: {"Disclosure":["Public"]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseFluidtopicsSourceConfiguration(
            string? type,
            string? baseUrl,
            string? apiKey,
            global::Vectara.BaseFluidtopicsSourceConfigurationContentScope? contentScope,
            string? query,
            string? locale,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters)
        {
            this.Type = type;
            this.BaseUrl = baseUrl;
            this.ApiKey = apiKey;
            this.ContentScope = contentScope;
            this.Query = query;
            this.Locale = locale;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFluidtopicsSourceConfiguration" /> class.
        /// </summary>
        public BaseFluidtopicsSourceConfiguration()
        {
        }

    }
}