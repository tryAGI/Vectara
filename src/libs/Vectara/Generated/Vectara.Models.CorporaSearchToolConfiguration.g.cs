#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for a corpora search tool that stores predefined search parameters and overrides.
    /// </summary>
    public readonly partial struct CorporaSearchToolConfiguration : global::System.IEquatable<CorporaSearchToolConfiguration>
    {
        /// <summary>
        /// Base properties shared by all tool configuration types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ToolConfigurationBase? Base { get; init; }
#else
        public global::Vectara.ToolConfigurationBase? Base { get; }
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
#if NET6_0_OR_GREATER
        public global::Vectara.CorporaSearchToolConfigurationVariant2? CorporaSearchToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.CorporaSearchToolConfigurationVariant2? CorporaSearchToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CorporaSearchToolConfigurationVariant2))]
#endif
        public bool IsCorporaSearchToolConfigurationVariant2 => CorporaSearchToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CorporaSearchToolConfiguration(global::Vectara.ToolConfigurationBase value) => new CorporaSearchToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(CorporaSearchToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CorporaSearchToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CorporaSearchToolConfiguration(global::Vectara.CorporaSearchToolConfigurationVariant2 value) => new CorporaSearchToolConfiguration((global::Vectara.CorporaSearchToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CorporaSearchToolConfigurationVariant2?(CorporaSearchToolConfiguration @this) => @this.CorporaSearchToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CorporaSearchToolConfiguration(global::Vectara.CorporaSearchToolConfigurationVariant2? value)
        {
            CorporaSearchToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CorporaSearchToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.CorporaSearchToolConfigurationVariant2? corporaSearchToolConfigurationVariant2
            )
        {
            Base = @base;
            CorporaSearchToolConfigurationVariant2 = corporaSearchToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CorporaSearchToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CorporaSearchToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCorporaSearchToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.CorporaSearchToolConfigurationVariant2?, TResult>? corporaSearchToolConfigurationVariant2 = null,
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
            else if (IsCorporaSearchToolConfigurationVariant2 && corporaSearchToolConfigurationVariant2 != null)
            {
                return corporaSearchToolConfigurationVariant2(CorporaSearchToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase?>? @base = null,
            global::System.Action<global::Vectara.CorporaSearchToolConfigurationVariant2?>? corporaSearchToolConfigurationVariant2 = null,
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
            else if (IsCorporaSearchToolConfigurationVariant2)
            {
                corporaSearchToolConfigurationVariant2?.Invoke(CorporaSearchToolConfigurationVariant2!);
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
                typeof(global::Vectara.ToolConfigurationBase),
                CorporaSearchToolConfigurationVariant2,
                typeof(global::Vectara.CorporaSearchToolConfigurationVariant2),
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
        public bool Equals(CorporaSearchToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CorporaSearchToolConfigurationVariant2?>.Default.Equals(CorporaSearchToolConfigurationVariant2, other.CorporaSearchToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CorporaSearchToolConfiguration obj1, CorporaSearchToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CorporaSearchToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CorporaSearchToolConfiguration obj1, CorporaSearchToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CorporaSearchToolConfiguration o && Equals(o);
        }
    }
}
