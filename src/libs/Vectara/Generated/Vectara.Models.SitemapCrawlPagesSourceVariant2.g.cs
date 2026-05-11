
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SitemapCrawlPagesSourceVariant2
    {
        /// <summary>
        /// Default Value: sitemap_crawl<br/>
        /// Example: sitemap_crawl
        /// </summary>
        /// <default>"sitemap_crawl"</default>
        /// <example>sitemap_crawl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "sitemap_crawl";

        /// <summary>
        /// Optional additional seed URLs. Sitemap entries are also used as crawl seeds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// Sitemap URLs to read; their entries become the initial crawl seeds.<br/>
        /// Example: [https://docs.example.com/sitemap.xml]
        /// </summary>
        /// <example>[https://docs.example.com/sitemap.xml]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sitemap_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SitemapUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapCrawlPagesSourceVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: sitemap_crawl<br/>
        /// Example: sitemap_crawl
        /// </param>
        /// <param name="sitemapUrls">
        /// Sitemap URLs to read; their entries become the initial crawl seeds.<br/>
        /// Example: [https://docs.example.com/sitemap.xml]
        /// </param>
        /// <param name="urls">
        /// Optional additional seed URLs. Sitemap entries are also used as crawl seeds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SitemapCrawlPagesSourceVariant2(
            string type,
            global::System.Collections.Generic.IList<string> sitemapUrls,
            global::System.Collections.Generic.IList<string>? urls)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Urls = urls;
            this.SitemapUrls = sitemapUrls ?? throw new global::System.ArgumentNullException(nameof(sitemapUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapCrawlPagesSourceVariant2" /> class.
        /// </summary>
        public SitemapCrawlPagesSourceVariant2()
        {
        }

    }
}