#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A span representing context compaction (summarization of older conversation turns).
    /// </summary>
    public readonly partial struct CompactionTraceSpan : global::System.IEquatable<CompactionTraceSpan>
    {
        /// <summary>
        /// Common properties shared by all agent trace span types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentTraceSpanBase? AgentBase { get; init; }
#else
        public global::Vectara.AgentTraceSpanBase? AgentBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentBase))]
#endif
        public bool IsAgentBase => AgentBase != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.AgentTraceSpanBase? value)
        {
            value = AgentBase;
            return IsAgentBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentTraceSpanBase PickAgentBase() => IsAgentBase
            ? AgentBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentBase' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CompactionTraceSpanVariant2? CompactionTraceSpanVariant2 { get; init; }
#else
        public global::Vectara.CompactionTraceSpanVariant2? CompactionTraceSpanVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompactionTraceSpanVariant2))]
#endif
        public bool IsCompactionTraceSpanVariant2 => CompactionTraceSpanVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompactionTraceSpanVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CompactionTraceSpanVariant2? value)
        {
            value = CompactionTraceSpanVariant2;
            return IsCompactionTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CompactionTraceSpanVariant2 PickCompactionTraceSpanVariant2() => IsCompactionTraceSpanVariant2
            ? CompactionTraceSpanVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompactionTraceSpanVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompactionTraceSpan(global::Vectara.AgentTraceSpanBase value) => new CompactionTraceSpan((global::Vectara.AgentTraceSpanBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentTraceSpanBase?(CompactionTraceSpan @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public CompactionTraceSpan(global::Vectara.AgentTraceSpanBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompactionTraceSpan FromAgentBase(global::Vectara.AgentTraceSpanBase? value) => new CompactionTraceSpan(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompactionTraceSpan(global::Vectara.CompactionTraceSpanVariant2 value) => new CompactionTraceSpan((global::Vectara.CompactionTraceSpanVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CompactionTraceSpanVariant2?(CompactionTraceSpan @this) => @this.CompactionTraceSpanVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CompactionTraceSpan(global::Vectara.CompactionTraceSpanVariant2? value)
        {
            CompactionTraceSpanVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CompactionTraceSpan FromCompactionTraceSpanVariant2(global::Vectara.CompactionTraceSpanVariant2? value) => new CompactionTraceSpan(value);

        /// <summary>
        /// 
        /// </summary>
        public CompactionTraceSpan(
            global::Vectara.AgentTraceSpanBase? agentBase,
            global::Vectara.CompactionTraceSpanVariant2? compactionTraceSpanVariant2
            )
        {
            AgentBase = agentBase;
            CompactionTraceSpanVariant2 = compactionTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompactionTraceSpanVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            CompactionTraceSpanVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsCompactionTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentTraceSpanBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.CompactionTraceSpanVariant2, TResult>? compactionTraceSpanVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentBase && agentBase != null)
            {
                return agentBase(AgentBase!);
            }
            else if (IsCompactionTraceSpanVariant2 && compactionTraceSpanVariant2 != null)
            {
                return compactionTraceSpanVariant2(CompactionTraceSpanVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,

            global::System.Action<global::Vectara.CompactionTraceSpanVariant2>? compactionTraceSpanVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentBase)
            {
                agentBase?.Invoke(AgentBase!);
            }
            else if (IsCompactionTraceSpanVariant2)
            {
                compactionTraceSpanVariant2?.Invoke(CompactionTraceSpanVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,
            global::System.Action<global::Vectara.CompactionTraceSpanVariant2>? compactionTraceSpanVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentBase)
            {
                agentBase?.Invoke(AgentBase!);
            }
            else if (IsCompactionTraceSpanVariant2)
            {
                compactionTraceSpanVariant2?.Invoke(CompactionTraceSpanVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentBase,
                typeof(global::Vectara.AgentTraceSpanBase),
                CompactionTraceSpanVariant2,
                typeof(global::Vectara.CompactionTraceSpanVariant2),
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
        public bool Equals(CompactionTraceSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentTraceSpanBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CompactionTraceSpanVariant2?>.Default.Equals(CompactionTraceSpanVariant2, other.CompactionTraceSpanVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompactionTraceSpan obj1, CompactionTraceSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompactionTraceSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompactionTraceSpan obj1, CompactionTraceSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompactionTraceSpan o && Equals(o);
        }
    }
}
