
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebPagesSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Crawl,
        /// <summary>
        /// 
        /// </summary>
        Sitemap,
        /// <summary>
        /// 
        /// </summary>
        SitemapCrawl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebPagesSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebPagesSourceDiscriminatorType value)
        {
            return value switch
            {
                WebPagesSourceDiscriminatorType.Crawl => "crawl",
                WebPagesSourceDiscriminatorType.Sitemap => "sitemap",
                WebPagesSourceDiscriminatorType.SitemapCrawl => "sitemap_crawl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebPagesSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => WebPagesSourceDiscriminatorType.Crawl,
                "sitemap" => WebPagesSourceDiscriminatorType.Sitemap,
                "sitemap_crawl" => WebPagesSourceDiscriminatorType.SitemapCrawl,
                _ => null,
            };
        }
    }
}