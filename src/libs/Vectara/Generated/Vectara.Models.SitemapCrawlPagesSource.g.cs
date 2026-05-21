#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read pages from sitemaps AND crawl outward via link-following. Sitemap entries themselves<br/>
    /// serve as crawl seeds; `urls` is optional and provides additional explicit seeds.
    /// </summary>
    public readonly partial struct SitemapCrawlPagesSource : global::System.IEquatable<SitemapCrawlPagesSource>
    {
        /// <summary>
        /// Shared BFS knobs for crawl-mode page-source variants (CrawlPagesSource, SitemapCrawlPagesSource).<br/>
        /// Depth and URL filters; seed lists differ per variant and live on the leaf types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseCrawlPagesSource? Base { get; init; }
#else
        public global::Vectara.BaseCrawlPagesSource? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.BaseCrawlPagesSource? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseCrawlPagesSource PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SitemapCrawlPagesSourceVariant2? SitemapCrawlPagesSourceVariant2 { get; init; }
#else
        public global::Vectara.SitemapCrawlPagesSourceVariant2? SitemapCrawlPagesSourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SitemapCrawlPagesSourceVariant2))]
#endif
        public bool IsSitemapCrawlPagesSourceVariant2 => SitemapCrawlPagesSourceVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSitemapCrawlPagesSourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SitemapCrawlPagesSourceVariant2? value)
        {
            value = SitemapCrawlPagesSourceVariant2;
            return IsSitemapCrawlPagesSourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SitemapCrawlPagesSourceVariant2 PickSitemapCrawlPagesSourceVariant2() => IsSitemapCrawlPagesSourceVariant2
            ? SitemapCrawlPagesSourceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SitemapCrawlPagesSourceVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SitemapCrawlPagesSource(global::Vectara.BaseCrawlPagesSource value) => new SitemapCrawlPagesSource((global::Vectara.BaseCrawlPagesSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseCrawlPagesSource?(SitemapCrawlPagesSource @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SitemapCrawlPagesSource(global::Vectara.BaseCrawlPagesSource? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SitemapCrawlPagesSource FromBase(global::Vectara.BaseCrawlPagesSource? value) => new SitemapCrawlPagesSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SitemapCrawlPagesSource(global::Vectara.SitemapCrawlPagesSourceVariant2 value) => new SitemapCrawlPagesSource((global::Vectara.SitemapCrawlPagesSourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SitemapCrawlPagesSourceVariant2?(SitemapCrawlPagesSource @this) => @this.SitemapCrawlPagesSourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SitemapCrawlPagesSource(global::Vectara.SitemapCrawlPagesSourceVariant2? value)
        {
            SitemapCrawlPagesSourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SitemapCrawlPagesSource FromSitemapCrawlPagesSourceVariant2(global::Vectara.SitemapCrawlPagesSourceVariant2? value) => new SitemapCrawlPagesSource(value);

        /// <summary>
        /// 
        /// </summary>
        public SitemapCrawlPagesSource(
            global::Vectara.BaseCrawlPagesSource? @base,
            global::Vectara.SitemapCrawlPagesSourceVariant2? sitemapCrawlPagesSourceVariant2
            )
        {
            Base = @base;
            SitemapCrawlPagesSourceVariant2 = sitemapCrawlPagesSourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SitemapCrawlPagesSourceVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SitemapCrawlPagesSourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSitemapCrawlPagesSourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseCrawlPagesSource, TResult>? @base = null,
            global::System.Func<global::Vectara.SitemapCrawlPagesSourceVariant2, TResult>? sitemapCrawlPagesSourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsSitemapCrawlPagesSourceVariant2 && sitemapCrawlPagesSourceVariant2 != null)
            {
                return sitemapCrawlPagesSourceVariant2(SitemapCrawlPagesSourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseCrawlPagesSource>? @base = null,

            global::System.Action<global::Vectara.SitemapCrawlPagesSourceVariant2>? sitemapCrawlPagesSourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsSitemapCrawlPagesSourceVariant2)
            {
                sitemapCrawlPagesSourceVariant2?.Invoke(SitemapCrawlPagesSourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseCrawlPagesSource>? @base = null,
            global::System.Action<global::Vectara.SitemapCrawlPagesSourceVariant2>? sitemapCrawlPagesSourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsSitemapCrawlPagesSourceVariant2)
            {
                sitemapCrawlPagesSourceVariant2?.Invoke(SitemapCrawlPagesSourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Vectara.BaseCrawlPagesSource),
                SitemapCrawlPagesSourceVariant2,
                typeof(global::Vectara.SitemapCrawlPagesSourceVariant2),
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
        public bool Equals(SitemapCrawlPagesSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseCrawlPagesSource?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SitemapCrawlPagesSourceVariant2?>.Default.Equals(SitemapCrawlPagesSourceVariant2, other.SitemapCrawlPagesSourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SitemapCrawlPagesSource obj1, SitemapCrawlPagesSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SitemapCrawlPagesSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SitemapCrawlPagesSource obj1, SitemapCrawlPagesSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SitemapCrawlPagesSource o && Equals(o);
        }
    }
}
