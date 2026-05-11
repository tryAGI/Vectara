#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Discover pages by breadth-first link-following starting from one or more seed URLs.<br/>
    /// Per-URL change detection uses conditional GET (added in a follow-up PR).
    /// </summary>
    public readonly partial struct CrawlPagesSource : global::System.IEquatable<CrawlPagesSource>
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
        public global::Vectara.CrawlPagesSourceVariant2? CrawlPagesSourceVariant2 { get; init; }
#else
        public global::Vectara.CrawlPagesSourceVariant2? CrawlPagesSourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CrawlPagesSourceVariant2))]
#endif
        public bool IsCrawlPagesSourceVariant2 => CrawlPagesSourceVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCrawlPagesSourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CrawlPagesSourceVariant2? value)
        {
            value = CrawlPagesSourceVariant2;
            return IsCrawlPagesSourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CrawlPagesSourceVariant2 PickCrawlPagesSourceVariant2() => IsCrawlPagesSourceVariant2
            ? CrawlPagesSourceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CrawlPagesSourceVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CrawlPagesSource(global::Vectara.BaseCrawlPagesSource value) => new CrawlPagesSource((global::Vectara.BaseCrawlPagesSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseCrawlPagesSource?(CrawlPagesSource @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CrawlPagesSource(global::Vectara.BaseCrawlPagesSource? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CrawlPagesSource FromBase(global::Vectara.BaseCrawlPagesSource? value) => new CrawlPagesSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CrawlPagesSource(global::Vectara.CrawlPagesSourceVariant2 value) => new CrawlPagesSource((global::Vectara.CrawlPagesSourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CrawlPagesSourceVariant2?(CrawlPagesSource @this) => @this.CrawlPagesSourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CrawlPagesSource(global::Vectara.CrawlPagesSourceVariant2? value)
        {
            CrawlPagesSourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CrawlPagesSource FromCrawlPagesSourceVariant2(global::Vectara.CrawlPagesSourceVariant2? value) => new CrawlPagesSource(value);

        /// <summary>
        /// 
        /// </summary>
        public CrawlPagesSource(
            global::Vectara.BaseCrawlPagesSource? @base,
            global::Vectara.CrawlPagesSourceVariant2? crawlPagesSourceVariant2
            )
        {
            Base = @base;
            CrawlPagesSourceVariant2 = crawlPagesSourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CrawlPagesSourceVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CrawlPagesSourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCrawlPagesSourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseCrawlPagesSource, TResult>? @base = null,
            global::System.Func<global::Vectara.CrawlPagesSourceVariant2, TResult>? crawlPagesSourceVariant2 = null,
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
            else if (IsCrawlPagesSourceVariant2 && crawlPagesSourceVariant2 != null)
            {
                return crawlPagesSourceVariant2(CrawlPagesSourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseCrawlPagesSource>? @base = null,

            global::System.Action<global::Vectara.CrawlPagesSourceVariant2>? crawlPagesSourceVariant2 = null,
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
            else if (IsCrawlPagesSourceVariant2)
            {
                crawlPagesSourceVariant2?.Invoke(CrawlPagesSourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseCrawlPagesSource>? @base = null,
            global::System.Action<global::Vectara.CrawlPagesSourceVariant2>? crawlPagesSourceVariant2 = null,
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
            else if (IsCrawlPagesSourceVariant2)
            {
                crawlPagesSourceVariant2?.Invoke(CrawlPagesSourceVariant2!);
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
                CrawlPagesSourceVariant2,
                typeof(global::Vectara.CrawlPagesSourceVariant2),
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
        public bool Equals(CrawlPagesSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseCrawlPagesSource?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CrawlPagesSourceVariant2?>.Default.Equals(CrawlPagesSourceVariant2, other.CrawlPagesSourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CrawlPagesSource obj1, CrawlPagesSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CrawlPagesSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CrawlPagesSource obj1, CrawlPagesSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CrawlPagesSource o && Equals(o);
        }
    }
}
