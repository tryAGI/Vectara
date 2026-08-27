#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting end-user-facing service catalog forms from a Wolken ServiceDesk instance.
    /// </summary>
    public readonly partial struct WolkenFormsSourceConfiguration : global::System.IEquatable<WolkenFormsSourceConfiguration>
    {
        /// <summary>
        /// Base Wolken ServiceDesk forms source configuration. Ingests the end-user-facing service catalog<br/>
        /// forms of a Wolken ServiceDesk instance, covering both incident forms and service request forms.<br/>
        /// Each form becomes one document carrying the form's title, description, and category. When<br/>
        /// `include_form_details` is true, the document also carries the form's FAQs, field definitions,<br/>
        /// and option values. Requires Wolken credentials with read access to the service catalog listing<br/>
        /// endpoint. When `include_form_details` is true, the credentials also need read access to the<br/>
        /// form metadata, special instructions, and lookup value endpoints.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseWolkenFormsSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseWolkenFormsSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseWolkenFormsSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenFormsSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? WolkenFormsSourceConfigurationVariant2 { get; init; }
#else
        public object? WolkenFormsSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WolkenFormsSourceConfigurationVariant2))]
#endif
        public bool IsWolkenFormsSourceConfigurationVariant2 => WolkenFormsSourceConfigurationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWolkenFormsSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = WolkenFormsSourceConfigurationVariant2;
            return IsWolkenFormsSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickWolkenFormsSourceConfigurationVariant2() => IsWolkenFormsSourceConfigurationVariant2
            ? WolkenFormsSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WolkenFormsSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WolkenFormsSourceConfiguration(global::Vectara.BaseWolkenFormsSourceConfiguration value) => new WolkenFormsSourceConfiguration((global::Vectara.BaseWolkenFormsSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.BaseWolkenFormsSourceConfiguration?(WolkenFormsSourceConfiguration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public WolkenFormsSourceConfiguration(global::Vectara.BaseWolkenFormsSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WolkenFormsSourceConfiguration FromBase(global::Vectara.BaseWolkenFormsSourceConfiguration? value) => new WolkenFormsSourceConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public WolkenFormsSourceConfiguration(
            global::Vectara.BaseWolkenFormsSourceConfiguration? @base,
            object? wolkenFormsSourceConfigurationVariant2
            )
        {
            Base = @base;
            WolkenFormsSourceConfigurationVariant2 = wolkenFormsSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WolkenFormsSourceConfigurationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WolkenFormsSourceConfigurationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWolkenFormsSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseWolkenFormsSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? wolkenFormsSourceConfigurationVariant2 = null,
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
            else if (IsWolkenFormsSourceConfigurationVariant2 && wolkenFormsSourceConfigurationVariant2 != null)
            {
                return wolkenFormsSourceConfigurationVariant2(WolkenFormsSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseWolkenFormsSourceConfiguration>? @base = null,

            global::System.Action<object>? wolkenFormsSourceConfigurationVariant2 = null,
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
            else if (IsWolkenFormsSourceConfigurationVariant2)
            {
                wolkenFormsSourceConfigurationVariant2?.Invoke(WolkenFormsSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseWolkenFormsSourceConfiguration>? @base = null,
            global::System.Action<object>? wolkenFormsSourceConfigurationVariant2 = null,
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
            else if (IsWolkenFormsSourceConfigurationVariant2)
            {
                wolkenFormsSourceConfigurationVariant2?.Invoke(WolkenFormsSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseWolkenFormsSourceConfiguration),
                WolkenFormsSourceConfigurationVariant2,
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
        public bool Equals(WolkenFormsSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseWolkenFormsSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(WolkenFormsSourceConfigurationVariant2, other.WolkenFormsSourceConfigurationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WolkenFormsSourceConfiguration obj1, WolkenFormsSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WolkenFormsSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WolkenFormsSourceConfiguration obj1, WolkenFormsSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WolkenFormsSourceConfiguration o && Equals(o);
        }
    }
}
