
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWebSourceConfigurationVariant2
    {
        /// <summary>
        /// Default Value: web<br/>
        /// Example: web
        /// </summary>
        /// <default>"web"</default>
        /// <example>web</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "web";

        /// <summary>
        /// How a `web` source discovers URLs. Discriminated by `type`:<br/>
        /// `sitemap` reads sitemap.xml only; `crawl` does BFS link-following from seed URLs;<br/>
        /// `sitemap_crawl` reads a sitemap and crawls outward from its entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.WebPagesSourceJsonConverter))]
        public global::Vectara.WebPagesSource? PagesSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebSourceConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: web<br/>
        /// Example: web
        /// </param>
        /// <param name="pagesSource">
        /// How a `web` source discovers URLs. Discriminated by `type`:<br/>
        /// `sitemap` reads sitemap.xml only; `crawl` does BFS link-following from seed URLs;<br/>
        /// `sitemap_crawl` reads a sitemap and crawls outward from its entries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWebSourceConfigurationVariant2(
            string type,
            global::Vectara.WebPagesSource? pagesSource)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PagesSource = pagesSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebSourceConfigurationVariant2" /> class.
        /// </summary>
        public UpdateWebSourceConfigurationVariant2()
        {
        }

    }
}