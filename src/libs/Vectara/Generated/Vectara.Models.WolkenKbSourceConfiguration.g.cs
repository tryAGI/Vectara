#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting knowledge-base articles from a Wolken ServiceDesk instance.
    /// </summary>
    public readonly partial struct WolkenKbSourceConfiguration : global::System.IEquatable<WolkenKbSourceConfiguration>
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
        public global::Vectara.BaseWolkenKbSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseWolkenKbSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseWolkenKbSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? WolkenKbSourceConfigurationVariant2 { get; init; }
#else
        public object? WolkenKbSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WolkenKbSourceConfigurationVariant2))]
#endif
        public bool IsWolkenKbSourceConfigurationVariant2 => WolkenKbSourceConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWolkenKbSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = WolkenKbSourceConfigurationVariant2;
            return IsWolkenKbSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickWolkenKbSourceConfigurationVariant2() => IsWolkenKbSourceConfigurationVariant2
            ? WolkenKbSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WolkenKbSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WolkenKbSourceConfiguration(global::Vectara.BaseWolkenKbSourceConfiguration value) => new WolkenKbSourceConfiguration((global::Vectara.BaseWolkenKbSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseWolkenKbSourceConfiguration?(WolkenKbSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public WolkenKbSourceConfiguration(global::Vectara.BaseWolkenKbSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WolkenKbSourceConfiguration FromBase(global::Vectara.BaseWolkenKbSourceConfiguration? value) => new WolkenKbSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public WolkenKbSourceConfiguration(
            global::Vectara.BaseWolkenKbSourceConfiguration? @base,
            object? wolkenKbSourceConfigurationVariant2
            )
        {
            Base = @base;
            WolkenKbSourceConfigurationVariant2 = wolkenKbSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WolkenKbSourceConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WolkenKbSourceConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWolkenKbSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseWolkenKbSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? wolkenKbSourceConfigurationVariant2 = null,
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
            else if (IsWolkenKbSourceConfigurationVariant2 && wolkenKbSourceConfigurationVariant2 != null)
            {
                return wolkenKbSourceConfigurationVariant2(WolkenKbSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseWolkenKbSourceConfiguration>? @base = null,

            global::System.Action<object>? wolkenKbSourceConfigurationVariant2 = null,
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
            else if (IsWolkenKbSourceConfigurationVariant2)
            {
                wolkenKbSourceConfigurationVariant2?.Invoke(WolkenKbSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseWolkenKbSourceConfiguration>? @base = null,
            global::System.Action<object>? wolkenKbSourceConfigurationVariant2 = null,
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
            else if (IsWolkenKbSourceConfigurationVariant2)
            {
                wolkenKbSourceConfigurationVariant2?.Invoke(WolkenKbSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseWolkenKbSourceConfiguration),
                WolkenKbSourceConfigurationVariant2,
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
        public bool Equals(WolkenKbSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseWolkenKbSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(WolkenKbSourceConfigurationVariant2, other.WolkenKbSourceConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WolkenKbSourceConfiguration obj1, WolkenKbSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WolkenKbSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WolkenKbSourceConfiguration obj1, WolkenKbSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WolkenKbSourceConfiguration o && Equals(o);
        }
    }
}
