#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting knowledge-base articles from a Wolken ServiceDesk instance.
    /// </summary>
    public readonly partial struct WolkenSourceConfiguration : global::System.IEquatable<WolkenSourceConfiguration>
    {
        /// <summary>
        /// Base Wolken ServiceDesk knowledge-base source configuration. Ingests knowledge-base articles<br/>
        /// matching the configured filters, with each article's audience attributes carried as document<br/>
        /// metadata for attribute-based filtering. Requires Wolken data API credentials with read access<br/>
        /// to the knowledge-base listing and article-detail endpoints. Incremental sync additionally<br/>
        /// requires the listing to support update-time filters. Supported filters vary by Wolken<br/>
        /// deployment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseWolkenSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseWolkenSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseWolkenSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseWolkenSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? WolkenSourceConfigurationVariant2 { get; init; }
#else
        public object? WolkenSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WolkenSourceConfigurationVariant2))]
#endif
        public bool IsWolkenSourceConfigurationVariant2 => WolkenSourceConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWolkenSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = WolkenSourceConfigurationVariant2;
            return IsWolkenSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickWolkenSourceConfigurationVariant2() => IsWolkenSourceConfigurationVariant2
            ? WolkenSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WolkenSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WolkenSourceConfiguration(global::Vectara.BaseWolkenSourceConfiguration value) => new WolkenSourceConfiguration((global::Vectara.BaseWolkenSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseWolkenSourceConfiguration?(WolkenSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public WolkenSourceConfiguration(global::Vectara.BaseWolkenSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WolkenSourceConfiguration FromBase(global::Vectara.BaseWolkenSourceConfiguration? value) => new WolkenSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public WolkenSourceConfiguration(
            global::Vectara.BaseWolkenSourceConfiguration? @base,
            object? wolkenSourceConfigurationVariant2
            )
        {
            Base = @base;
            WolkenSourceConfigurationVariant2 = wolkenSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WolkenSourceConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WolkenSourceConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWolkenSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseWolkenSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? wolkenSourceConfigurationVariant2 = null,
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
            else if (IsWolkenSourceConfigurationVariant2 && wolkenSourceConfigurationVariant2 != null)
            {
                return wolkenSourceConfigurationVariant2(WolkenSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseWolkenSourceConfiguration>? @base = null,

            global::System.Action<object>? wolkenSourceConfigurationVariant2 = null,
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
            else if (IsWolkenSourceConfigurationVariant2)
            {
                wolkenSourceConfigurationVariant2?.Invoke(WolkenSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseWolkenSourceConfiguration>? @base = null,
            global::System.Action<object>? wolkenSourceConfigurationVariant2 = null,
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
            else if (IsWolkenSourceConfigurationVariant2)
            {
                wolkenSourceConfigurationVariant2?.Invoke(WolkenSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseWolkenSourceConfiguration),
                WolkenSourceConfigurationVariant2,
                typeof(object),
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
        public bool Equals(WolkenSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseWolkenSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(WolkenSourceConfigurationVariant2, other.WolkenSourceConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WolkenSourceConfiguration obj1, WolkenSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WolkenSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WolkenSourceConfiguration obj1, WolkenSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WolkenSourceConfiguration o && Equals(o);
        }
    }
}
