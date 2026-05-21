
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read pages enumerated by one or more sitemaps (`sitemap.xml`, `sitemap-index.xml`, or gzipped<br/>
    /// variants). Per-URL change detection uses the sitemap's `&lt;lastmod&gt;`. No link-following.
    /// </summary>
    public sealed partial class SitemapPagesSource
    {
        /// <summary>
        /// Default Value: sitemap<br/>
        /// Example: sitemap
        /// </summary>
        /// <default>"sitemap"</default>
        /// <example>sitemap</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "sitemap";

        /// <summary>
        /// Sitemap URLs to read. At least one is required.<br/>
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
        /// Initializes a new instance of the <see cref="SitemapPagesSource" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: sitemap<br/>
        /// Example: sitemap
        /// </param>
        /// <param name="sitemapUrls">
        /// Sitemap URLs to read. At least one is required.<br/>
        /// Example: [https://docs.example.com/sitemap.xml]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SitemapPagesSource(
            string type,
            global::System.Collections.Generic.IList<string> sitemapUrls)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SitemapUrls = sitemapUrls ?? throw new global::System.ArgumentNullException(nameof(sitemapUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapPagesSource" /> class.
        /// </summary>
        public SitemapPagesSource()
        {
        }

    }
}