
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Shared BFS knobs for crawl-mode page-source variants (CrawlPagesSource, SitemapCrawlPagesSource).<br/>
    /// Depth and URL filters; seed lists differ per variant and live on the leaf types.
    /// </summary>
    public sealed partial class BaseCrawlPagesSource
    {
        /// <summary>
        /// Maximum link-following depth from each seed URL.<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_depth")]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// If true, the crawler does not follow links outside the seed URL's registered domain.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("same_domain_only")]
        public bool? SameDomainOnly { get; set; }

        /// <summary>
        /// Regex patterns matched against the full URL; a URL must fully match at least one to be crawled. Empty list = no positive filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pos_regex")]
        public global::System.Collections.Generic.IList<string>? PosRegex { get; set; }

        /// <summary>
        /// Regex patterns matched against the full URL; URLs fully matching any are skipped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neg_regex")]
        public global::System.Collections.Generic.IList<string>? NegRegex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseCrawlPagesSource" /> class.
        /// </summary>
        /// <param name="maxDepth">
        /// Maximum link-following depth from each seed URL.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="sameDomainOnly">
        /// If true, the crawler does not follow links outside the seed URL's registered domain.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="posRegex">
        /// Regex patterns matched against the full URL; a URL must fully match at least one to be crawled. Empty list = no positive filter.
        /// </param>
        /// <param name="negRegex">
        /// Regex patterns matched against the full URL; URLs fully matching any are skipped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseCrawlPagesSource(
            int? maxDepth,
            bool? sameDomainOnly,
            global::System.Collections.Generic.IList<string>? posRegex,
            global::System.Collections.Generic.IList<string>? negRegex)
        {
            this.MaxDepth = maxDepth;
            this.SameDomainOnly = sameDomainOnly;
            this.PosRegex = posRegex;
            this.NegRegex = negRegex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseCrawlPagesSource" /> class.
        /// </summary>
        public BaseCrawlPagesSource()
        {
        }

    }
}