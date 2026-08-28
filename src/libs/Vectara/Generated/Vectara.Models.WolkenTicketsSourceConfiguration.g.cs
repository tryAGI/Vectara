#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting incidents and service requests from a Wolken ServiceDesk instance.
    /// </summary>
    public readonly partial struct WolkenTicketsSourceConfiguration : global::System.IEquatable<WolkenTicketsSourceConfiguration>
    {
        /// <summary>
        /// Base Wolken ServiceDesk tickets source configuration. Ingests incidents and service requests<br/>
        /// from a Wolken ServiceDesk instance. Each ticket becomes one document carrying the ticket<br/>
        /// subject, description, and conversation notes, with the ticket classification fields such as<br/>
        /// status, priority, category, and team as document metadata for attribute-based filtering.<br/>
        /// Requires Wolken credentials with read access to the incident and service request listing,<br/>
        /// detail, and notes endpoints.<br/>
        /// Incremental syncs read only the tickets updated since the previous run. Tickets are<br/>
        /// re-ingested when notes are added. A ticket whose notes cannot be read is not ingested.<br/>
        /// Deletions are not propagated. A ticket deleted or restricted in Wolken keeps its last<br/>
        /// indexed content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseWolkenTicketsSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseWolkenTicketsSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseWolkenTicketsSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenTicketsSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? WolkenTicketsSourceConfigurationVariant2 { get; init; }
#else
        public object? WolkenTicketsSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WolkenTicketsSourceConfigurationVariant2))]
#endif
        public bool IsWolkenTicketsSourceConfigurationVariant2 => WolkenTicketsSourceConfigurationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWolkenTicketsSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = WolkenTicketsSourceConfigurationVariant2;
            return IsWolkenTicketsSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickWolkenTicketsSourceConfigurationVariant2() => IsWolkenTicketsSourceConfigurationVariant2
            ? WolkenTicketsSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WolkenTicketsSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WolkenTicketsSourceConfiguration(global::Vectara.BaseWolkenTicketsSourceConfiguration value) => new WolkenTicketsSourceConfiguration((global::Vectara.BaseWolkenTicketsSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.BaseWolkenTicketsSourceConfiguration?(WolkenTicketsSourceConfiguration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public WolkenTicketsSourceConfiguration(global::Vectara.BaseWolkenTicketsSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WolkenTicketsSourceConfiguration FromBase(global::Vectara.BaseWolkenTicketsSourceConfiguration? value) => new WolkenTicketsSourceConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public WolkenTicketsSourceConfiguration(
            global::Vectara.BaseWolkenTicketsSourceConfiguration? @base,
            object? wolkenTicketsSourceConfigurationVariant2
            )
        {
            Base = @base;
            WolkenTicketsSourceConfigurationVariant2 = wolkenTicketsSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WolkenTicketsSourceConfigurationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WolkenTicketsSourceConfigurationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWolkenTicketsSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseWolkenTicketsSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? wolkenTicketsSourceConfigurationVariant2 = null,
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
            else if (IsWolkenTicketsSourceConfigurationVariant2 && wolkenTicketsSourceConfigurationVariant2 != null)
            {
                return wolkenTicketsSourceConfigurationVariant2(WolkenTicketsSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseWolkenTicketsSourceConfiguration>? @base = null,

            global::System.Action<object>? wolkenTicketsSourceConfigurationVariant2 = null,
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
            else if (IsWolkenTicketsSourceConfigurationVariant2)
            {
                wolkenTicketsSourceConfigurationVariant2?.Invoke(WolkenTicketsSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseWolkenTicketsSourceConfiguration>? @base = null,
            global::System.Action<object>? wolkenTicketsSourceConfigurationVariant2 = null,
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
            else if (IsWolkenTicketsSourceConfigurationVariant2)
            {
                wolkenTicketsSourceConfigurationVariant2?.Invoke(WolkenTicketsSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseWolkenTicketsSourceConfiguration),
                WolkenTicketsSourceConfigurationVariant2,
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
        public bool Equals(WolkenTicketsSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseWolkenTicketsSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(WolkenTicketsSourceConfigurationVariant2, other.WolkenTicketsSourceConfigurationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WolkenTicketsSourceConfiguration obj1, WolkenTicketsSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WolkenTicketsSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WolkenTicketsSourceConfiguration obj1, WolkenTicketsSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WolkenTicketsSourceConfiguration o && Equals(o);
        }
    }
}
