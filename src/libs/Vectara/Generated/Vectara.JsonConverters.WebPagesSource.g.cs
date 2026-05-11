#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class WebPagesSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.WebPagesSource>
    {
        /// <inheritdoc />
        public override global::Vectara.WebPagesSource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebPagesSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebPagesSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WebPagesSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.SitemapPagesSource? sitemap = default;
            if (discriminator?.Type == global::Vectara.WebPagesSourceDiscriminatorType.Sitemap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SitemapPagesSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SitemapPagesSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SitemapPagesSource)}");
                sitemap = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CrawlPagesSource? crawl = default;
            if (discriminator?.Type == global::Vectara.WebPagesSourceDiscriminatorType.Crawl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CrawlPagesSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CrawlPagesSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CrawlPagesSource)}");
                crawl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.SitemapCrawlPagesSource? sitemapCrawl = default;
            if (discriminator?.Type == global::Vectara.WebPagesSourceDiscriminatorType.SitemapCrawl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SitemapCrawlPagesSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SitemapCrawlPagesSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SitemapCrawlPagesSource)}");
                sitemapCrawl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.WebPagesSource(
                discriminator?.Type,
                sitemap,

                crawl,

                sitemapCrawl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.WebPagesSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSitemap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SitemapPagesSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SitemapPagesSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SitemapPagesSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sitemap!, typeInfo);
            }
            else if (value.IsCrawl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CrawlPagesSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CrawlPagesSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CrawlPagesSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Crawl!.Value, typeInfo);
            }
            else if (value.IsSitemapCrawl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SitemapCrawlPagesSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SitemapCrawlPagesSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SitemapCrawlPagesSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SitemapCrawl!.Value, typeInfo);
            }
        }
    }
}