#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A user-defined function that can be executed as a tool by agents.<br/>
    /// Lambda tools run in a secure, sandboxed environment with resource limits.<br/>
    /// Currently supports Python 3.12 with a curated set of libraries.
    /// </summary>
    public readonly partial struct LambdaTool : global::System.IEquatable<LambdaTool>
    {
        /// <summary>
        /// Base properties shared by all tool types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ToolBase? Value1 { get; init; }
#else
        public global::Vectara.ToolBase? Value1 { get; }
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
        public global::Vectara.LambdaToolVariant2? Value2 { get; init; }
#else
        public global::Vectara.LambdaToolVariant2? Value2 { get; }
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
        public static implicit operator LambdaTool(global::Vectara.ToolBase value) => new LambdaTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(LambdaTool @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public LambdaTool(global::Vectara.ToolBase? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LambdaTool(global::Vectara.LambdaToolVariant2 value) => new LambdaTool((global::Vectara.LambdaToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.LambdaToolVariant2?(LambdaTool @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public LambdaTool(global::Vectara.LambdaToolVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LambdaTool(
            global::Vectara.ToolBase? value1,
            global::Vectara.LambdaToolVariant2? value2
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
            global::System.Func<global::Vectara.ToolBase?, TResult>? value1 = null,
            global::System.Func<global::Vectara.LambdaToolVariant2?, TResult>? value2 = null,
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
            global::System.Action<global::Vectara.ToolBase?>? value1 = null,
            global::System.Action<global::Vectara.LambdaToolVariant2?>? value2 = null,
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
                typeof(global::Vectara.ToolBase),
                Value2,
                typeof(global::Vectara.LambdaToolVariant2),
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
        public bool Equals(LambdaTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.LambdaToolVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LambdaTool obj1, LambdaTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LambdaTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LambdaTool obj1, LambdaTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LambdaTool o && Equals(o);
        }
    }
}
