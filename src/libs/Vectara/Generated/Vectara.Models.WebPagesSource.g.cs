#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// How a `web` source discovers URLs. Discriminated by `type`:<br/>
    /// `sitemap` reads sitemap.xml only; `crawl` does BFS link-following from seed URLs;<br/>
    /// `sitemap_crawl` reads a sitemap and crawls outward from its entries.
    /// </summary>
    public readonly partial struct WebPagesSource : global::System.IEquatable<WebPagesSource>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.WebPagesSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Read pages enumerated by one or more sitemaps (`sitemap.xml`, `sitemap-index.xml`, or gzipped<br/>
        /// variants). Per-URL change detection uses the sitemap's `&lt;lastmod&gt;`. No link-following.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SitemapPagesSource? Sitemap { get; init; }
#else
        public global::Vectara.SitemapPagesSource? Sitemap { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sitemap))]
#endif
        public bool IsSitemap => Sitemap != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSitemap(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SitemapPagesSource? value)
        {
            value = Sitemap;
            return IsSitemap;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SitemapPagesSource PickSitemap() => IsSitemap
            ? Sitemap!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sitemap' but the value was {ToString()}.");

        /// <summary>
        /// Discover pages by breadth-first link-following starting from one or more seed URLs.<br/>
        /// Per-URL change detection uses conditional GET (added in a follow-up PR).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CrawlPagesSource? Crawl { get; init; }
#else
        public global::Vectara.CrawlPagesSource? Crawl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Crawl))]
#endif
        public bool IsCrawl => Crawl != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCrawl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CrawlPagesSource? value)
        {
            value = Crawl;
            return IsCrawl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CrawlPagesSource PickCrawl() => IsCrawl
            ? Crawl!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Crawl' but the value was {ToString()}.");

        /// <summary>
        /// Read pages from sitemaps AND crawl outward via link-following. Sitemap entries themselves<br/>
        /// serve as crawl seeds; `urls` is optional and provides additional explicit seeds.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SitemapCrawlPagesSource? SitemapCrawl { get; init; }
#else
        public global::Vectara.SitemapCrawlPagesSource? SitemapCrawl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SitemapCrawl))]
#endif
        public bool IsSitemapCrawl => SitemapCrawl != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSitemapCrawl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SitemapCrawlPagesSource? value)
        {
            value = SitemapCrawl;
            return IsSitemapCrawl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SitemapCrawlPagesSource PickSitemapCrawl() => IsSitemapCrawl
            ? SitemapCrawl!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SitemapCrawl' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebPagesSource(global::Vectara.SitemapPagesSource value) => new WebPagesSource((global::Vectara.SitemapPagesSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SitemapPagesSource?(WebPagesSource @this) => @this.Sitemap;

        /// <summary>
        /// 
        /// </summary>
        public WebPagesSource(global::Vectara.SitemapPagesSource? value)
        {
            Sitemap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebPagesSource FromSitemap(global::Vectara.SitemapPagesSource? value) => new WebPagesSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebPagesSource(global::Vectara.CrawlPagesSource value) => new WebPagesSource((global::Vectara.CrawlPagesSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CrawlPagesSource?(WebPagesSource @this) => @this.Crawl;

        /// <summary>
        /// 
        /// </summary>
        public WebPagesSource(global::Vectara.CrawlPagesSource? value)
        {
            Crawl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebPagesSource FromCrawl(global::Vectara.CrawlPagesSource? value) => new WebPagesSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebPagesSource(global::Vectara.SitemapCrawlPagesSource value) => new WebPagesSource((global::Vectara.SitemapCrawlPagesSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SitemapCrawlPagesSource?(WebPagesSource @this) => @this.SitemapCrawl;

        /// <summary>
        /// 
        /// </summary>
        public WebPagesSource(global::Vectara.SitemapCrawlPagesSource? value)
        {
            SitemapCrawl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebPagesSource FromSitemapCrawl(global::Vectara.SitemapCrawlPagesSource? value) => new WebPagesSource(value);

        /// <summary>
        /// 
        /// </summary>
        public WebPagesSource(
            global::Vectara.WebPagesSourceDiscriminatorType? type,
            global::Vectara.SitemapPagesSource? sitemap,
            global::Vectara.CrawlPagesSource? crawl,
            global::Vectara.SitemapCrawlPagesSource? sitemapCrawl
            )
        {
            Type = type;

            Sitemap = sitemap;
            Crawl = crawl;
            SitemapCrawl = sitemapCrawl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SitemapCrawl as object ??
            Crawl as object ??
            Sitemap as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Sitemap?.ToString() ??
            Crawl?.ToString() ??
            SitemapCrawl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSitemap && !IsCrawl && !IsSitemapCrawl || !IsSitemap && IsCrawl && !IsSitemapCrawl || !IsSitemap && !IsCrawl && IsSitemapCrawl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SitemapPagesSource, TResult>? sitemap = null,
            global::System.Func<global::Vectara.CrawlPagesSource?, TResult>? crawl = null,
            global::System.Func<global::Vectara.SitemapCrawlPagesSource?, TResult>? sitemapCrawl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSitemap && sitemap != null)
            {
                return sitemap(Sitemap!);
            }
            else if (IsCrawl && crawl != null)
            {
                return crawl(Crawl!);
            }
            else if (IsSitemapCrawl && sitemapCrawl != null)
            {
                return sitemapCrawl(SitemapCrawl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.SitemapPagesSource>? sitemap = null,

            global::System.Action<global::Vectara.CrawlPagesSource?>? crawl = null,

            global::System.Action<global::Vectara.SitemapCrawlPagesSource?>? sitemapCrawl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSitemap)
            {
                sitemap?.Invoke(Sitemap!);
            }
            else if (IsCrawl)
            {
                crawl?.Invoke(Crawl!);
            }
            else if (IsSitemapCrawl)
            {
                sitemapCrawl?.Invoke(SitemapCrawl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.SitemapPagesSource>? sitemap = null,
            global::System.Action<global::Vectara.CrawlPagesSource?>? crawl = null,
            global::System.Action<global::Vectara.SitemapCrawlPagesSource?>? sitemapCrawl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSitemap)
            {
                sitemap?.Invoke(Sitemap!);
            }
            else if (IsCrawl)
            {
                crawl?.Invoke(Crawl!);
            }
            else if (IsSitemapCrawl)
            {
                sitemapCrawl?.Invoke(SitemapCrawl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sitemap,
                typeof(global::Vectara.SitemapPagesSource),
                Crawl,
                typeof(global::Vectara.CrawlPagesSource),
                SitemapCrawl,
                typeof(global::Vectara.SitemapCrawlPagesSource),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(WebPagesSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SitemapPagesSource?>.Default.Equals(Sitemap, other.Sitemap) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CrawlPagesSource?>.Default.Equals(Crawl, other.Crawl) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SitemapCrawlPagesSource?>.Default.Equals(SitemapCrawl, other.SitemapCrawl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebPagesSource obj1, WebPagesSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebPagesSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebPagesSource obj1, WebPagesSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebPagesSource o && Equals(o);
        }
    }
}
