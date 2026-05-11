#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Partial update for a `web` source configuration. Top-level fields are merged into the existing<br/>
    /// record; if `pages_source` is provided, the entire `pages_source` object is replaced (i.e.,<br/>
    /// switching modes or changing per-mode fields requires a complete `pages_source` object).
    /// </summary>
    public readonly partial struct UpdateWebSourceConfiguration : global::System.IEquatable<UpdateWebSourceConfiguration>
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
        public global::Vectara.UpdateWebSourceConfigurationVariant2? UpdateWebSourceConfigurationVariant2 { get; init; }
#else
        public global::Vectara.UpdateWebSourceConfigurationVariant2? UpdateWebSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateWebSourceConfigurationVariant2))]
#endif
        public bool IsUpdateWebSourceConfigurationVariant2 => UpdateWebSourceConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUpdateWebSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.UpdateWebSourceConfigurationVariant2? value)
        {
            value = UpdateWebSourceConfigurationVariant2;
            return IsUpdateWebSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateWebSourceConfigurationVariant2 PickUpdateWebSourceConfigurationVariant2() => IsUpdateWebSourceConfigurationVariant2
            ? UpdateWebSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateWebSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateWebSourceConfiguration(global::Vectara.BaseWebSource value) => new UpdateWebSourceConfiguration((global::Vectara.BaseWebSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseWebSource?(UpdateWebSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public UpdateWebSourceConfiguration(global::Vectara.BaseWebSource? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateWebSourceConfiguration FromBase(global::Vectara.BaseWebSource? value) => new UpdateWebSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateWebSourceConfiguration(global::Vectara.UpdateWebSourceConfigurationVariant2 value) => new UpdateWebSourceConfiguration((global::Vectara.UpdateWebSourceConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateWebSourceConfigurationVariant2?(UpdateWebSourceConfiguration @this) => @this.UpdateWebSourceConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UpdateWebSourceConfiguration(global::Vectara.UpdateWebSourceConfigurationVariant2? value)
        {
            UpdateWebSourceConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateWebSourceConfiguration FromUpdateWebSourceConfigurationVariant2(global::Vectara.UpdateWebSourceConfigurationVariant2? value) => new UpdateWebSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public UpdateWebSourceConfiguration(
            global::Vectara.BaseWebSource? @base,
            global::Vectara.UpdateWebSourceConfigurationVariant2? updateWebSourceConfigurationVariant2
            )
        {
            Base = @base;
            UpdateWebSourceConfigurationVariant2 = updateWebSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateWebSourceConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            UpdateWebSourceConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsUpdateWebSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseWebSource, TResult>? @base = null,
            global::System.Func<global::Vectara.UpdateWebSourceConfigurationVariant2, TResult>? updateWebSourceConfigurationVariant2 = null,
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
            else if (IsUpdateWebSourceConfigurationVariant2 && updateWebSourceConfigurationVariant2 != null)
            {
                return updateWebSourceConfigurationVariant2(UpdateWebSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseWebSource>? @base = null,

            global::System.Action<global::Vectara.UpdateWebSourceConfigurationVariant2>? updateWebSourceConfigurationVariant2 = null,
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
            else if (IsUpdateWebSourceConfigurationVariant2)
            {
                updateWebSourceConfigurationVariant2?.Invoke(UpdateWebSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseWebSource>? @base = null,
            global::System.Action<global::Vectara.UpdateWebSourceConfigurationVariant2>? updateWebSourceConfigurationVariant2 = null,
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
            else if (IsUpdateWebSourceConfigurationVariant2)
            {
                updateWebSourceConfigurationVariant2?.Invoke(UpdateWebSourceConfigurationVariant2!);
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
                UpdateWebSourceConfigurationVariant2,
                typeof(global::Vectara.UpdateWebSourceConfigurationVariant2),
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
        public bool Equals(UpdateWebSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseWebSource?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateWebSourceConfigurationVariant2?>.Default.Equals(UpdateWebSourceConfigurationVariant2, other.UpdateWebSourceConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateWebSourceConfiguration obj1, UpdateWebSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateWebSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateWebSourceConfiguration obj1, UpdateWebSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateWebSourceConfiguration o && Equals(o);
        }
    }
}
