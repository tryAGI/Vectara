#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting pages from a website. Politeness, limits, and auth are configured<br/>
    /// here; the `pages_source` field selects how URLs are discovered (sitemap, crawl, or both).
    /// </summary>
    public readonly partial struct WebSourceConfiguration : global::System.IEquatable<WebSourceConfiguration>
    {
        /// <summary>
        /// Shared knobs for all web-based sources (sitemap, crawl, sitemap+crawl). Politeness, limits, auth.<br/>
        /// Mode-specific fields (urls, sitemap_urls, BFS knobs, page count cap) live on the concrete subtypes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseWebSource? Base { get; init; }
#else
        public global::Vectara.BaseWebSource? Base { get; }
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
            out global::Vectara.BaseWebSource? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseWebSource PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebSourceConfigurationVariant2? WebSourceConfigurationVariant2 { get; init; }
#else
        public global::Vectara.WebSourceConfigurationVariant2? WebSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSourceConfigurationVariant2))]
#endif
        public bool IsWebSourceConfigurationVariant2 => WebSourceConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WebSourceConfigurationVariant2? value)
        {
            value = WebSourceConfigurationVariant2;
            return IsWebSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.WebSourceConfigurationVariant2 PickWebSourceConfigurationVariant2() => IsWebSourceConfigurationVariant2
            ? WebSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSourceConfiguration(global::Vectara.BaseWebSource value) => new WebSourceConfiguration((global::Vectara.BaseWebSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseWebSource?(WebSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public WebSourceConfiguration(global::Vectara.BaseWebSource? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebSourceConfiguration FromBase(global::Vectara.BaseWebSource? value) => new WebSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSourceConfiguration(global::Vectara.WebSourceConfigurationVariant2 value) => new WebSourceConfiguration((global::Vectara.WebSourceConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WebSourceConfigurationVariant2?(WebSourceConfiguration @this) => @this.WebSourceConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WebSourceConfiguration(global::Vectara.WebSourceConfigurationVariant2? value)
        {
            WebSourceConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebSourceConfiguration FromWebSourceConfigurationVariant2(global::Vectara.WebSourceConfigurationVariant2? value) => new WebSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public WebSourceConfiguration(
            global::Vectara.BaseWebSource? @base,
            global::Vectara.WebSourceConfigurationVariant2? webSourceConfigurationVariant2
            )
        {
            Base = @base;
            WebSourceConfigurationVariant2 = webSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSourceConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WebSourceConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWebSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseWebSource, TResult>? @base = null,
            global::System.Func<global::Vectara.WebSourceConfigurationVariant2, TResult>? webSourceConfigurationVariant2 = null,
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
            else if (IsWebSourceConfigurationVariant2 && webSourceConfigurationVariant2 != null)
            {
                return webSourceConfigurationVariant2(WebSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseWebSource>? @base = null,

            global::System.Action<global::Vectara.WebSourceConfigurationVariant2>? webSourceConfigurationVariant2 = null,
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
            else if (IsWebSourceConfigurationVariant2)
            {
                webSourceConfigurationVariant2?.Invoke(WebSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseWebSource>? @base = null,
            global::System.Action<global::Vectara.WebSourceConfigurationVariant2>? webSourceConfigurationVariant2 = null,
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
            else if (IsWebSourceConfigurationVariant2)
            {
                webSourceConfigurationVariant2?.Invoke(WebSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseWebSource),
                WebSourceConfigurationVariant2,
                typeof(global::Vectara.WebSourceConfigurationVariant2),
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
        public bool Equals(WebSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseWebSource?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebSourceConfigurationVariant2?>.Default.Equals(WebSourceConfigurationVariant2, other.WebSourceConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebSourceConfiguration obj1, WebSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebSourceConfiguration obj1, WebSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSourceConfiguration o && Equals(o);
        }
    }
}
