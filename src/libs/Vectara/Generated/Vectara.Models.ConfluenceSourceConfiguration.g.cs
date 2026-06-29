#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting pages from a Confluence instance.
    /// </summary>
    public readonly partial struct ConfluenceSourceConfiguration : global::System.IEquatable<ConfluenceSourceConfiguration>
    {
        /// <summary>
        /// Base Confluence source configuration. Ingests pages from the configured spaces<br/>
        /// and inherits each page's read restrictions and space permissions as document ACL. Works against<br/>
        /// both Confluence Cloud and Data Center.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseConfluenceSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseConfluenceSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseConfluenceSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseConfluenceSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ConfluenceSourceConfigurationVariant2 { get; init; }
#else
        public object? ConfluenceSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConfluenceSourceConfigurationVariant2))]
#endif
        public bool IsConfluenceSourceConfigurationVariant2 => ConfluenceSourceConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConfluenceSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ConfluenceSourceConfigurationVariant2;
            return IsConfluenceSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickConfluenceSourceConfigurationVariant2() => IsConfluenceSourceConfigurationVariant2
            ? ConfluenceSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConfluenceSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConfluenceSourceConfiguration(global::Vectara.BaseConfluenceSourceConfiguration value) => new ConfluenceSourceConfiguration((global::Vectara.BaseConfluenceSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseConfluenceSourceConfiguration?(ConfluenceSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ConfluenceSourceConfiguration(global::Vectara.BaseConfluenceSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConfluenceSourceConfiguration FromBase(global::Vectara.BaseConfluenceSourceConfiguration? value) => new ConfluenceSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public ConfluenceSourceConfiguration(
            global::Vectara.BaseConfluenceSourceConfiguration? @base,
            object? confluenceSourceConfigurationVariant2
            )
        {
            Base = @base;
            ConfluenceSourceConfigurationVariant2 = confluenceSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConfluenceSourceConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConfluenceSourceConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConfluenceSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseConfluenceSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? confluenceSourceConfigurationVariant2 = null,
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
            else if (IsConfluenceSourceConfigurationVariant2 && confluenceSourceConfigurationVariant2 != null)
            {
                return confluenceSourceConfigurationVariant2(ConfluenceSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseConfluenceSourceConfiguration>? @base = null,

            global::System.Action<object>? confluenceSourceConfigurationVariant2 = null,
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
            else if (IsConfluenceSourceConfigurationVariant2)
            {
                confluenceSourceConfigurationVariant2?.Invoke(ConfluenceSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseConfluenceSourceConfiguration>? @base = null,
            global::System.Action<object>? confluenceSourceConfigurationVariant2 = null,
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
            else if (IsConfluenceSourceConfigurationVariant2)
            {
                confluenceSourceConfigurationVariant2?.Invoke(ConfluenceSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseConfluenceSourceConfiguration),
                ConfluenceSourceConfigurationVariant2,
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
        public bool Equals(ConfluenceSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseConfluenceSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ConfluenceSourceConfigurationVariant2, other.ConfluenceSourceConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConfluenceSourceConfiguration obj1, ConfluenceSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConfluenceSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConfluenceSourceConfiguration obj1, ConfluenceSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConfluenceSourceConfiguration o && Equals(o);
        }
    }
}
