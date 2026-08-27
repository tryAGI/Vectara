#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting user records from a SCIM 2.0 service provider.
    /// </summary>
    public readonly partial struct ScimSourceConfiguration : global::System.IEquatable<ScimSourceConfiguration>
    {
        /// <summary>
        /// Base SCIM source configuration. Ingests user records from a SCIM 2.0 service provider<br/>
        /// through the Users endpoint. Each user becomes one document carrying profile, group<br/>
        /// membership, and enterprise attributes as document metadata for attribute-based filtering.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseScimSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseScimSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseScimSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseScimSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ScimSourceConfigurationVariant2 { get; init; }
#else
        public object? ScimSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScimSourceConfigurationVariant2))]
#endif
        public bool IsScimSourceConfigurationVariant2 => ScimSourceConfigurationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScimSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ScimSourceConfigurationVariant2;
            return IsScimSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickScimSourceConfigurationVariant2() => IsScimSourceConfigurationVariant2
            ? ScimSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScimSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScimSourceConfiguration(global::Vectara.BaseScimSourceConfiguration value) => new ScimSourceConfiguration((global::Vectara.BaseScimSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.BaseScimSourceConfiguration?(ScimSourceConfiguration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ScimSourceConfiguration(global::Vectara.BaseScimSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScimSourceConfiguration FromBase(global::Vectara.BaseScimSourceConfiguration? value) => new ScimSourceConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public ScimSourceConfiguration(
            global::Vectara.BaseScimSourceConfiguration? @base,
            object? scimSourceConfigurationVariant2
            )
        {
            Base = @base;
            ScimSourceConfigurationVariant2 = scimSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ScimSourceConfigurationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ScimSourceConfigurationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsScimSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseScimSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? scimSourceConfigurationVariant2 = null,
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
            else if (IsScimSourceConfigurationVariant2 && scimSourceConfigurationVariant2 != null)
            {
                return scimSourceConfigurationVariant2(ScimSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseScimSourceConfiguration>? @base = null,

            global::System.Action<object>? scimSourceConfigurationVariant2 = null,
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
            else if (IsScimSourceConfigurationVariant2)
            {
                scimSourceConfigurationVariant2?.Invoke(ScimSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseScimSourceConfiguration>? @base = null,
            global::System.Action<object>? scimSourceConfigurationVariant2 = null,
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
            else if (IsScimSourceConfigurationVariant2)
            {
                scimSourceConfigurationVariant2?.Invoke(ScimSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseScimSourceConfiguration),
                ScimSourceConfigurationVariant2,
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
        public bool Equals(ScimSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseScimSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ScimSourceConfigurationVariant2, other.ScimSourceConfigurationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ScimSourceConfiguration obj1, ScimSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScimSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScimSourceConfiguration obj1, ScimSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScimSourceConfiguration o && Equals(o);
        }
    }
}
