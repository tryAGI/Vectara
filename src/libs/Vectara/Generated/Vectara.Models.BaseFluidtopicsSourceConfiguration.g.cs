
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base Fluid Topics source configuration. Ingests content from a Fluid Topics tenant via the<br/>
    /// Knowledge Hub REST API. `content_scope` selects which layer to ingest:<br/>
    /// - `documents`: standalone items.<br/>
    /// - `topics`: the sections inside maps, each carrying its parent map's identity and classification.<br/>
    /// - `maps`: whole maps, one record each.<br/>
    /// Every record carries its full Fluid Topics metadata, including classification and entitlement<br/>
    /// fields, as document metadata for attribute-based filtering and access control. Requires a<br/>
    /// Fluid Topics API key with read access to the configured content.
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
        /// Which Fluid Topics content layer to ingest:<br/>
        /// - `documents`: enumerates standalone documents.<br/>
        /// - `topics`: enumerates the topics within maps, iterating map by map so each topic carries<br/>
        ///   its parent map's identity and classification.<br/>
        /// - `maps`: enumerates maps, emitting one record each.<br/>
        /// Under `maps`, `query` is ignored. `filters`, `locale`, `include_sources`, and<br/>
        /// `exclude_sources` apply, matched against each map's metadata.<br/>
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
        /// public content. When unset, no metadata filter is applied. Under `content_scope: maps` the<br/>
        /// reserved key `id` matches the map's own identifier, so `{"id": ["&lt;map_id&gt;"]}` restricts a run<br/>
        /// to a single map.<br/>
        /// Example: {"Disclosure":["Public"]}
        /// </summary>
        /// <example>{"Disclosure":["Public"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Filters { get; set; }

        /// <summary>
        /// Fluid Topics source ids (`ft:sourceId`) to ingest. A record whose source is not listed is<br/>
        /// skipped. Applied to every ingestion path regardless of `query` or `filters`. Empty (the<br/>
        /// default) ingests every source.<br/>
        /// Example: [ud]
        /// </summary>
        /// <example>[ud]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_sources")]
        public global::System.Collections.Generic.IList<string>? IncludeSources { get; set; }

        /// <summary>
        /// Fluid Topics source ids (`ft:sourceId`, for example `drupal` or `khoros`) whose records are<br/>
        /// excluded from ingestion, even when they also match `include_sources`. Applied to every<br/>
        /// ingestion path regardless of `query` or `filters`. Empty (the default) excludes nothing.<br/>
        /// Example: [drupal, khoros]
        /// </summary>
        /// <example>[drupal, khoros]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_sources")]
        public global::System.Collections.Generic.IList<string>? ExcludeSources { get; set; }

        /// <summary>
        /// How document bodies are fetched in the `documents` scope, as a map of MIME type to fetch<br/>
        /// mode. Keys match a document's MIME type (`ft:mimeType`) exactly (`application/pdf`), by<br/>
        /// prefix (`image/*`), or `*` as the catch-all default. Types matching no key use<br/>
        /// `extracted_text`, the behavior when this map is unset. Ignored when `content_scope` is<br/>
        /// `topics`.<br/>
        /// Example: {"application/pdf":"original_file","video/*":"metadata_only"}
        /// </summary>
        /// <example>{"application/pdf":"original_file","video/*":"metadata_only"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_fetch_modes")]
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.FluidtopicsDocumentFetchMode>? DocumentFetchModes { get; set; }

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
        /// Which Fluid Topics content layer to ingest:<br/>
        /// - `documents`: enumerates standalone documents.<br/>
        /// - `topics`: enumerates the topics within maps, iterating map by map so each topic carries<br/>
        ///   its parent map's identity and classification.<br/>
        /// - `maps`: enumerates maps, emitting one record each.<br/>
        /// Under `maps`, `query` is ignored. `filters`, `locale`, `include_sources`, and<br/>
        /// `exclude_sources` apply, matched against each map's metadata.<br/>
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
        /// public content. When unset, no metadata filter is applied. Under `content_scope: maps` the<br/>
        /// reserved key `id` matches the map's own identifier, so `{"id": ["&lt;map_id&gt;"]}` restricts a run<br/>
        /// to a single map.<br/>
        /// Example: {"Disclosure":["Public"]}
        /// </param>
        /// <param name="includeSources">
        /// Fluid Topics source ids (`ft:sourceId`) to ingest. A record whose source is not listed is<br/>
        /// skipped. Applied to every ingestion path regardless of `query` or `filters`. Empty (the<br/>
        /// default) ingests every source.<br/>
        /// Example: [ud]
        /// </param>
        /// <param name="excludeSources">
        /// Fluid Topics source ids (`ft:sourceId`, for example `drupal` or `khoros`) whose records are<br/>
        /// excluded from ingestion, even when they also match `include_sources`. Applied to every<br/>
        /// ingestion path regardless of `query` or `filters`. Empty (the default) excludes nothing.<br/>
        /// Example: [drupal, khoros]
        /// </param>
        /// <param name="documentFetchModes">
        /// How document bodies are fetched in the `documents` scope, as a map of MIME type to fetch<br/>
        /// mode. Keys match a document's MIME type (`ft:mimeType`) exactly (`application/pdf`), by<br/>
        /// prefix (`image/*`), or `*` as the catch-all default. Types matching no key use<br/>
        /// `extracted_text`, the behavior when this map is unset. Ignored when `content_scope` is<br/>
        /// `topics`.<br/>
        /// Example: {"application/pdf":"original_file","video/*":"metadata_only"}
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
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters,
            global::System.Collections.Generic.IList<string>? includeSources,
            global::System.Collections.Generic.IList<string>? excludeSources,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.FluidtopicsDocumentFetchMode>? documentFetchModes)
        {
            this.Type = type;
            this.BaseUrl = baseUrl;
            this.ApiKey = apiKey;
            this.ContentScope = contentScope;
            this.Query = query;
            this.Locale = locale;
            this.Filters = filters;
            this.IncludeSources = includeSources;
            this.ExcludeSources = excludeSources;
            this.DocumentFetchModes = documentFetchModes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFluidtopicsSourceConfiguration" /> class.
        /// </summary>
        public BaseFluidtopicsSourceConfiguration()
        {
        }

    }
}