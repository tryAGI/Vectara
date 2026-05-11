
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Shared knobs for all web-based sources (sitemap, crawl, sitemap+crawl). Politeness, limits, auth.<br/>
    /// Mode-specific fields (urls, sitemap_urls, BFS knobs, page count cap) live on the concrete subtypes.
    /// </summary>
    public sealed partial class BaseWebSource
    {
        /// <summary>
        /// If true (default and strongly recommended), `robots.txt` rules and `Crawl-delay` directives are honored.<br/>
        /// Set to false only if you have explicit authorization to crawl the target site without robots.txt<br/>
        /// restrictions (e.g., your own domain).<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respect_robots_txt")]
        public bool? RespectRobotsTxt { get; set; }

        /// <summary>
        /// Maximum sustained requests per second per host.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_second")]
        public double? RequestsPerSecond { get; set; }

        /// <summary>
        /// Maximum concurrent in-flight requests per host.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent")]
        public int? MaxConcurrent { get; set; }

        /// <summary>
        /// Hard cap on the number of pages fetched per run. The default is a safety rail to prevent<br/>
        /// unbounded crawls — both in BFS mode (high-branching-factor sites like wikis where `max_depth`<br/>
        /// alone is not a meaningful bound) and in sitemap mode (a `&lt;sitemap-index&gt;` can chain<br/>
        /// 50,000 child sitemaps × 50,000 URLs each per the sitemaps.org limits).<br/>
        /// Default Value: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// If true, pages are rendered with a headless browser (slower, but required for JavaScript-heavy SPAs).<br/>
        /// Defaults to false; turn on if pages return empty content without rendering.<br/>
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
        /// prevents accidentally capping every page below the size of a typical HTML document;<br/>
        /// the 100 MiB ceiling is far above any plausible single-page payload.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWebSource" /> class.
        /// </summary>
        /// <param name="respectRobotsTxt">
        /// If true (default and strongly recommended), `robots.txt` rules and `Crawl-delay` directives are honored.<br/>
        /// Set to false only if you have explicit authorization to crawl the target site without robots.txt<br/>
        /// restrictions (e.g., your own domain).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestsPerSecond">
        /// Maximum sustained requests per second per host.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="maxConcurrent">
        /// Maximum concurrent in-flight requests per host.<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="maxPages">
        /// Hard cap on the number of pages fetched per run. The default is a safety rail to prevent<br/>
        /// unbounded crawls — both in BFS mode (high-branching-factor sites like wikis where `max_depth`<br/>
        /// alone is not a meaningful bound) and in sitemap mode (a `&lt;sitemap-index&gt;` can chain<br/>
        /// 50,000 child sitemaps × 50,000 URLs each per the sitemaps.org limits).<br/>
        /// Default Value: 10000
        /// </param>
        /// <param name="jsRendering">
        /// If true, pages are rendered with a headless browser (slower, but required for JavaScript-heavy SPAs).<br/>
        /// Defaults to false; turn on if pages return empty content without rendering.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="userAgent">
        /// User-Agent header sent with every request. Must not contain CR or LF.<br/>
        /// Default Value: Vectara-Crawler/1.0 (+https://www.vectara.com/crawler)
        /// </param>
        /// <param name="maxPageBytes">
        /// Maximum page body bytes to download. Larger pages are truncated. The 64 KB floor<br/>
        /// prevents accidentally capping every page below the size of a typical HTML document;<br/>
        /// the 100 MiB ceiling is far above any plausible single-page payload.<br/>
        /// Default Value: 10485760
        /// </param>
        /// <param name="excludedContentTypes">
        /// MIME types to skip in addition to always-skipped media types (image/*, video/*, audio/*).<br/>
        /// Useful to skip e.g. application/zip if a site links to large archives.
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for connecting to a remote service.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseWebSource(
            bool? respectRobotsTxt,
            double? requestsPerSecond,
            int? maxConcurrent,
            int? maxPages,
            bool? jsRendering,
            string? userAgent,
            long? maxPageBytes,
            global::System.Collections.Generic.IList<string>? excludedContentTypes,
            global::Vectara.RemoteAuth? auth)
        {
            this.RespectRobotsTxt = respectRobotsTxt;
            this.RequestsPerSecond = requestsPerSecond;
            this.MaxConcurrent = maxConcurrent;
            this.MaxPages = maxPages;
            this.JsRendering = jsRendering;
            this.UserAgent = userAgent;
            this.MaxPageBytes = maxPageBytes;
            this.ExcludedContentTypes = excludedContentTypes;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWebSource" /> class.
        /// </summary>
        public BaseWebSource()
        {
        }

    }
}