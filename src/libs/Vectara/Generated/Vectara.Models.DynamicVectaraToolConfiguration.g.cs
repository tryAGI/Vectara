#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A configuration for built-in Vectara tools that have implementations within the platform but do not have a dedicated configuration type schema. Use the List Tools endpoint to discover available tools and obtain the `tool_id` required when creating this configuration.
    /// </summary>
    public readonly partial struct DynamicVectaraToolConfiguration : global::System.IEquatable<DynamicVectaraToolConfiguration>
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
        public global::Vectara.DynamicVectaraToolConfigurationVariant2? DynamicVectaraToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.DynamicVectaraToolConfigurationVariant2? DynamicVectaraToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVectaraToolConfigurationVariant2))]
#endif
        public bool IsDynamicVectaraToolConfigurationVariant2 => DynamicVectaraToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVectaraToolConfiguration(global::Vectara.ToolConfigurationBase value) => new DynamicVectaraToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(DynamicVectaraToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVectaraToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVectaraToolConfiguration(global::Vectara.DynamicVectaraToolConfigurationVariant2 value) => new DynamicVectaraToolConfiguration((global::Vectara.DynamicVectaraToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DynamicVectaraToolConfigurationVariant2?(DynamicVectaraToolConfiguration @this) => @this.DynamicVectaraToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVectaraToolConfiguration(global::Vectara.DynamicVectaraToolConfigurationVariant2? value)
        {
            DynamicVectaraToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DynamicVectaraToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.DynamicVectaraToolConfigurationVariant2? dynamicVectaraToolConfigurationVariant2
            )
        {
            Base = @base;
            DynamicVectaraToolConfigurationVariant2 = dynamicVectaraToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DynamicVectaraToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            DynamicVectaraToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsDynamicVectaraToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.DynamicVectaraToolConfigurationVariant2?, TResult>? dynamicVectaraToolConfigurationVariant2 = null,
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
            else if (IsDynamicVectaraToolConfigurationVariant2 && dynamicVectaraToolConfigurationVariant2 != null)
            {
                return dynamicVectaraToolConfigurationVariant2(DynamicVectaraToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase?>? @base = null,
            global::System.Action<global::Vectara.DynamicVectaraToolConfigurationVariant2?>? dynamicVectaraToolConfigurationVariant2 = null,
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
            else if (IsDynamicVectaraToolConfigurationVariant2)
            {
                dynamicVectaraToolConfigurationVariant2?.Invoke(DynamicVectaraToolConfigurationVariant2!);
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
                DynamicVectaraToolConfigurationVariant2,
                typeof(global::Vectara.DynamicVectaraToolConfigurationVariant2),
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
        public bool Equals(DynamicVectaraToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DynamicVectaraToolConfigurationVariant2?>.Default.Equals(DynamicVectaraToolConfigurationVariant2, other.DynamicVectaraToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DynamicVectaraToolConfiguration obj1, DynamicVectaraToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DynamicVectaraToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DynamicVectaraToolConfiguration obj1, DynamicVectaraToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DynamicVectaraToolConfiguration o && Equals(o);
        }
    }
}
