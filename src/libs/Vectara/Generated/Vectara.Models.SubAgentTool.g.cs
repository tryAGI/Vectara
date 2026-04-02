#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool that spawns a specialized sub-agent to handle complex, multi-step tasks autonomously.<br/>
    /// Sub-agents maintain separate context from the main agent and can be specialized for specific types of tasks like code review, general research, or output styling.
    /// </summary>
    public readonly partial struct SubAgentTool : global::System.IEquatable<SubAgentTool>
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
        public global::Vectara.SubAgentToolVariant2? SubAgentToolVariant2 { get; init; }
#else
        public global::Vectara.SubAgentToolVariant2? SubAgentToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubAgentToolVariant2))]
#endif
        public bool IsSubAgentToolVariant2 => SubAgentToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubAgentTool(global::Vectara.ToolBase value) => new SubAgentTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(SubAgentTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SubAgentTool(global::Vectara.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubAgentTool(global::Vectara.SubAgentToolVariant2 value) => new SubAgentTool((global::Vectara.SubAgentToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SubAgentToolVariant2?(SubAgentTool @this) => @this.SubAgentToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SubAgentTool(global::Vectara.SubAgentToolVariant2? value)
        {
            SubAgentToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SubAgentTool(
            global::Vectara.ToolBase? @base,
            global::Vectara.SubAgentToolVariant2? subAgentToolVariant2
            )
        {
            Base = @base;
            SubAgentToolVariant2 = subAgentToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SubAgentToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SubAgentToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSubAgentToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.SubAgentToolVariant2?, TResult>? subAgentToolVariant2 = null,
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
            else if (IsSubAgentToolVariant2 && subAgentToolVariant2 != null)
            {
                return subAgentToolVariant2(SubAgentToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolBase?>? @base = null,
            global::System.Action<global::Vectara.SubAgentToolVariant2?>? subAgentToolVariant2 = null,
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
            else if (IsSubAgentToolVariant2)
            {
                subAgentToolVariant2?.Invoke(SubAgentToolVariant2!);
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
                SubAgentToolVariant2,
                typeof(global::Vectara.SubAgentToolVariant2),
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
        public bool Equals(SubAgentTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SubAgentToolVariant2?>.Default.Equals(SubAgentToolVariant2, other.SubAgentToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SubAgentTool obj1, SubAgentTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SubAgentTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SubAgentTool obj1, SubAgentTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SubAgentTool o && Equals(o);
        }
    }
}
