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
        public global::Vectara.ToolBase? Base { get; init; }
#else
        public global::Vectara.ToolBase? Base { get; }
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
        public global::Vectara.LambdaToolVariant2? LambdaToolVariant2 { get; init; }
#else
        public global::Vectara.LambdaToolVariant2? LambdaToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LambdaToolVariant2))]
#endif
        public bool IsLambdaToolVariant2 => LambdaToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LambdaTool(global::Vectara.ToolBase value) => new LambdaTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(LambdaTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public LambdaTool(global::Vectara.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LambdaTool(global::Vectara.LambdaToolVariant2 value) => new LambdaTool((global::Vectara.LambdaToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.LambdaToolVariant2?(LambdaTool @this) => @this.LambdaToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LambdaTool(global::Vectara.LambdaToolVariant2? value)
        {
            LambdaToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LambdaTool(
            global::Vectara.ToolBase? @base,
            global::Vectara.LambdaToolVariant2? lambdaToolVariant2
            )
        {
            Base = @base;
            LambdaToolVariant2 = lambdaToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LambdaToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            LambdaToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsLambdaToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.LambdaToolVariant2?, TResult>? lambdaToolVariant2 = null,
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
            else if (IsLambdaToolVariant2 && lambdaToolVariant2 != null)
            {
                return lambdaToolVariant2(LambdaToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolBase?>? @base = null,
            global::System.Action<global::Vectara.LambdaToolVariant2?>? lambdaToolVariant2 = null,
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
            else if (IsLambdaToolVariant2)
            {
                lambdaToolVariant2?.Invoke(LambdaToolVariant2!);
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
                typeof(global::Vectara.ToolBase),
                LambdaToolVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.LambdaToolVariant2?>.Default.Equals(LambdaToolVariant2, other.LambdaToolVariant2) 
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
