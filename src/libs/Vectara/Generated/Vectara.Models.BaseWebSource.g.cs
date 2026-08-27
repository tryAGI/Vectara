
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Shared configuration for all web-based sources (sitemap, crawl, sitemap+crawl). Contains<br/>
    /// politeness settings, limits including the `max_pages` page count cap, and authentication.<br/>
    /// Mode-specific fields (urls, sitemap_urls, BFS settings) live on the page source types<br/>
    /// under `pages_source`.
    /// </summary>
    public sealed partial class BaseWebSource
    {
        /// <summary>
        /// If true (default and strongly recommended), the crawler honors `robots.txt` rules and<br/>
        /// `Crawl-delay` directives. Set to false only if you have explicit authorization to crawl<br/>
        /// the target site without robots.txt restrictions (e.g., your own domain).<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respect_robots_txt")]
        public bool? RespectRobotsTxt { get; set; }

        /// <summary>
        /// Maximum sustained requests per second, applied to each concurrent fetch<br/>
        /// independently — the worst-case rate against a host is this value multiplied by<br/>
        /// `max_concurrent_fetches`.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_second")]
        public double? RequestsPerSecond { get; set; }

        /// <summary>
        /// Ignored. Use `max_concurrent_fetches`.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxConcurrent { get; set; }

        /// <summary>
        /// Maximum number of pages fetched concurrently from a single host. Each concurrent<br/>
        /// fetch is paced by `requests_per_second` independently.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_fetches")]
        public int? MaxConcurrentFetches { get; set; }

        /// <summary>
        /// Hard cap on the number of pages fetched per run. The default is a safety rail to prevent<br/>
        /// unbounded crawls. In BFS mode, `max_depth` alone is not a meaningful bound on<br/>
        /// high-branching-factor sites like wikis. In sitemap mode, a `&lt;sitemap-index&gt;` can chain<br/>
        /// 50,000 child sitemaps × 50,000 URLs each per the sitemaps.org limits.<br/>
        /// Default Value: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// If true, a headless browser renders each page. This is slower, but required for<br/>
        /// JavaScript-heavy SPAs. Defaults to false. Turn it on if pages return empty content<br/>
        /// without rendering.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("js_rendering")]
        public bool? JsRendering { get; set; }

        /// <summary>
        /// User-Agent header sent with every request. Must not contain CR or LF.<br/>
        /// Default Value: Vectara-Crawler/1.0 (+https://www.vectara.com/crawler)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// Maximum page body bytes to download. Larger pages are truncated. The 64 KB floor<br/>
        /// prevents accidentally capping every page below the size of a typical HTML document.<br/>
        /// The 100 MiB ceiling is far above any plausible single-page payload.<br/>
        /// Default Value: 10485760
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_page_bytes")]
        public long? MaxPageBytes { get; set; }

        /// <summary>
        /// MIME types to skip in addition to always-skipped media types (image/*, video/*, audio/*).<br/>
        /// Useful to skip e.g. application/zip if a site links to large archives.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_content_types")]
        public global::System.Collections.Generic.IList<string>? ExcludedContentTypes { get; set; }

        /// <summary>
        /// Authentication configuration for connecting to a remote service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RemoteAuthJsonConverter))]
        public global::Vectara.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Metadata recorded on each ingested record: source-system fields, owner-attached fields, and<br/>
        /// access-control grants. It is set as the `source_record_metadata` field in each record's session<br/>
        /// metadata, where the pipeline agent can access it. When supplied on a source configuration,<br/>
        /// user-provided values take precedence over connector-derived ones. `system_metadata` and<br/>
        /// `user_metadata` entries override derived entries key by key. Derived keys not named are kept.<br/>
        /// A provided `acl_metadata` replaces ACL extraction entirely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_record_metadata")]
        public global::Vectara.SourceRecordMetadata? SourceRecordMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWebSource" /> class.
        /// </summary>
        /// <param name="respectRobotsTxt">
        /// If true (default and strongly recommended), the crawler honors `robots.txt` rules and<br/>
        /// `Crawl-delay` directives. Set to false only if you have explicit authorization to crawl<br/>
        /// the target site without robots.txt restrictions (e.g., your own domain).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestsPerSecond">
        /// Maximum sustained requests per second, applied to each concurrent fetch<br/>
        /// independently — the worst-case rate against a host is this value multiplied by<br/>
        /// `max_concurrent_fetches`.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="maxConcurrentFetches">
        /// Maximum number of pages fetched concurrently from a single host. Each concurrent<br/>
        /// fetch is paced by `requests_per_second` independently.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="maxPages">
        /// Hard cap on the number of pages fetched per run. The default is a safety rail to prevent<br/>
        /// unbounded crawls. In BFS mode, `max_depth` alone is not a meaningful bound on<br/>
        /// high-branching-factor sites like wikis. In sitemap mode, a `&lt;sitemap-index&gt;` can chain<br/>
        /// 50,000 child sitemaps × 50,000 URLs each per the sitemaps.org limits.<br/>
        /// Default Value: 10000
        /// </param>
        /// <param name="jsRendering">
        /// If true, a headless browser renders each page. This is slower, but required for<br/>
        /// JavaScript-heavy SPAs. Defaults to false. Turn it on if pages return empty content<br/>
        /// without rendering.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="userAgent">
        /// User-Agent header sent with every request. Must not contain CR or LF.<br/>
        /// Default Value: Vectara-Crawler/1.0 (+https://www.vectara.com/crawler)
        /// </param>
        /// <param name="maxPageBytes">
        /// Maximum page body bytes to download. Larger pages are truncated. The 64 KB floor<br/>
        /// prevents accidentally capping every page below the size of a typical HTML document.<br/>
        /// The 100 MiB ceiling is far above any plausible single-page payload.<br/>
        /// Default Value: 10485760
        /// </param>
        /// <param name="excludedContentTypes">
        /// MIME types to skip in addition to always-skipped media types (image/*, video/*, audio/*).<br/>
        /// Useful to skip e.g. application/zip if a site links to large archives.
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for connecting to a remote service.
        /// </param>
        /// <param name="sourceRecordMetadata">
        /// Metadata recorded on each ingested record: source-system fields, owner-attached fields, and<br/>
        /// access-control grants. It is set as the `source_record_metadata` field in each record's session<br/>
        /// metadata, where the pipeline agent can access it. When supplied on a source configuration,<br/>
        /// user-provided values take precedence over connector-derived ones. `system_metadata` and<br/>
        /// `user_metadata` entries override derived entries key by key. Derived keys not named are kept.<br/>
        /// A provided `acl_metadata` replaces ACL extraction entirely.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseWebSource(
            bool? respectRobotsTxt,
            double? requestsPerSecond,
            int? maxConcurrentFetches,
            int? maxPages,
            bool? jsRendering,
            string? userAgent,
            long? maxPageBytes,
            global::System.Collections.Generic.IList<string>? excludedContentTypes,
            global::Vectara.RemoteAuth? auth,
            global::Vectara.SourceRecordMetadata? sourceRecordMetadata)
        {
            this.RespectRobotsTxt = respectRobotsTxt;
            this.RequestsPerSecond = requestsPerSecond;
            this.MaxConcurrentFetches = maxConcurrentFetches;
            this.MaxPages = maxPages;
            this.JsRendering = jsRendering;
            this.UserAgent = userAgent;
            this.MaxPageBytes = maxPageBytes;
            this.ExcludedContentTypes = excludedContentTypes;
            this.Auth = auth;
            this.SourceRecordMetadata = sourceRecordMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWebSource" /> class.
        /// </summary>
        public BaseWebSource()
        {
        }

    }
}