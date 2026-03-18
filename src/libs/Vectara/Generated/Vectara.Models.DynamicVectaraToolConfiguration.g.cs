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
        public global::Vectara.ToolConfigurationBase? Value1 { get; init; }
#else
        public global::Vectara.ToolConfigurationBase? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DynamicVectaraToolConfigurationVariant2? Value2 { get; init; }
#else
        public global::Vectara.DynamicVectaraToolConfigurationVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVectaraToolConfiguration(global::Vectara.ToolConfigurationBase value) => new DynamicVectaraToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(DynamicVectaraToolConfiguration @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVectaraToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVectaraToolConfiguration(global::Vectara.DynamicVectaraToolConfigurationVariant2 value) => new DynamicVectaraToolConfiguration((global::Vectara.DynamicVectaraToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DynamicVectaraToolConfigurationVariant2?(DynamicVectaraToolConfiguration @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVectaraToolConfiguration(global::Vectara.DynamicVectaraToolConfigurationVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DynamicVectaraToolConfiguration(
            global::Vectara.ToolConfigurationBase? value1,
            global::Vectara.DynamicVectaraToolConfigurationVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase?, TResult>? value1 = null,
            global::System.Func<global::Vectara.DynamicVectaraToolConfigurationVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase?>? value1 = null,
            global::System.Action<global::Vectara.DynamicVectaraToolConfigurationVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Vectara.ToolConfigurationBase),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DynamicVectaraToolConfigurationVariant2?>.Default.Equals(Value2, other.Value2) 
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
