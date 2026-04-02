#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool type for built-in Vectara tools that have implementations within the platform but do not have a dedicated tool type schema. Examples include tools like `sub_agent`, `corpora_search`, `web_search`, and similar platform-provided capabilities. Use the List Tools endpoint to discover available tools and obtain the `tool_id` required for configuration.
    /// </summary>
    public readonly partial struct DynamicVectaraTool : global::System.IEquatable<DynamicVectaraTool>
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
        public global::Vectara.DynamicVectaraToolVariant2? DynamicVectaraToolVariant2 { get; init; }
#else
        public global::Vectara.DynamicVectaraToolVariant2? DynamicVectaraToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVectaraToolVariant2))]
#endif
        public bool IsDynamicVectaraToolVariant2 => DynamicVectaraToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVectaraTool(global::Vectara.ToolBase value) => new DynamicVectaraTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(DynamicVectaraTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVectaraTool(global::Vectara.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVectaraTool(global::Vectara.DynamicVectaraToolVariant2 value) => new DynamicVectaraTool((global::Vectara.DynamicVectaraToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DynamicVectaraToolVariant2?(DynamicVectaraTool @this) => @this.DynamicVectaraToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVectaraTool(global::Vectara.DynamicVectaraToolVariant2? value)
        {
            DynamicVectaraToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DynamicVectaraTool(
            global::Vectara.ToolBase? @base,
            global::Vectara.DynamicVectaraToolVariant2? dynamicVectaraToolVariant2
            )
        {
            Base = @base;
            DynamicVectaraToolVariant2 = dynamicVectaraToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DynamicVectaraToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            DynamicVectaraToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsDynamicVectaraToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.DynamicVectaraToolVariant2?, TResult>? dynamicVectaraToolVariant2 = null,
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
            else if (IsDynamicVectaraToolVariant2 && dynamicVectaraToolVariant2 != null)
            {
                return dynamicVectaraToolVariant2(DynamicVectaraToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolBase?>? @base = null,
            global::System.Action<global::Vectara.DynamicVectaraToolVariant2?>? dynamicVectaraToolVariant2 = null,
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
            else if (IsDynamicVectaraToolVariant2)
            {
                dynamicVectaraToolVariant2?.Invoke(DynamicVectaraToolVariant2!);
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
                DynamicVectaraToolVariant2,
                typeof(global::Vectara.DynamicVectaraToolVariant2),
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
        public bool Equals(DynamicVectaraTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DynamicVectaraToolVariant2?>.Default.Equals(DynamicVectaraToolVariant2, other.DynamicVectaraToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DynamicVectaraTool obj1, DynamicVectaraTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DynamicVectaraTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DynamicVectaraTool obj1, DynamicVectaraTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DynamicVectaraTool o && Equals(o);
        }
    }
}
