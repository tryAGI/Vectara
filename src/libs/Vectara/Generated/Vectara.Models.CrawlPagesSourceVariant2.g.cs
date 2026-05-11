
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrawlPagesSourceVariant2
    {
        /// <summary>
        /// Default Value: crawl<br/>
        /// Example: crawl
        /// </summary>
        /// <default>"crawl"</default>
        /// <example>crawl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "crawl";

        /// <summary>
        /// Seed URLs for link-following crawl. BFS expands from these.<br/>
        /// Example: [https://docs.example.com/]
        /// </summary>
        /// <example>[https://docs.example.com/]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlPagesSourceVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: crawl<br/>
        /// Example: crawl
        /// </param>
        /// <param name="urls">
        /// Seed URLs for link-following crawl. BFS expands from these.<br/>
        /// Example: [https://docs.example.com/]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrawlPagesSourceVariant2(
            string type,
            global::System.Collections.Generic.IList<string> urls)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlPagesSourceVariant2" /> class.
        /// </summary>
        public CrawlPagesSourceVariant2()
        {
        }

    }
}