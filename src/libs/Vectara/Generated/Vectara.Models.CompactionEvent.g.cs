#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An event indicating that context compaction has completed.
    /// </summary>
    public readonly partial struct CompactionEvent : global::System.IEquatable<CompactionEvent>
    {
        /// <summary>
        /// Base properties shared by all agent event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentEventBase? AgentBase { get; init; }
#else
        public global::Vectara.AgentEventBase? AgentBase { get; }
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
#if NET6_0_OR_GREATER
        public global::Vectara.CompactionEventVariant2? CompactionEventVariant2 { get; init; }
#else
        public global::Vectara.CompactionEventVariant2? CompactionEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompactionEventVariant2))]
#endif
        public bool IsCompactionEventVariant2 => CompactionEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompactionEvent(global::Vectara.AgentEventBase value) => new CompactionEvent((global::Vectara.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentEventBase?(CompactionEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public CompactionEvent(global::Vectara.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompactionEvent(global::Vectara.CompactionEventVariant2 value) => new CompactionEvent((global::Vectara.CompactionEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CompactionEventVariant2?(CompactionEvent @this) => @this.CompactionEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CompactionEvent(global::Vectara.CompactionEventVariant2? value)
        {
            CompactionEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CompactionEvent(
            global::Vectara.AgentEventBase? agentBase,
            global::Vectara.CompactionEventVariant2? compactionEventVariant2
            )
        {
            AgentBase = agentBase;
            CompactionEventVariant2 = compactionEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompactionEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            CompactionEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsCompactionEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.CompactionEventVariant2?, TResult>? compactionEventVariant2 = null,
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
            else if (IsCompactionEventVariant2 && compactionEventVariant2 != null)
            {
                return compactionEventVariant2(CompactionEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentEventBase?>? agentBase = null,
            global::System.Action<global::Vectara.CompactionEventVariant2?>? compactionEventVariant2 = null,
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
            else if (IsCompactionEventVariant2)
            {
                compactionEventVariant2?.Invoke(CompactionEventVariant2!);
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
                typeof(global::Vectara.AgentEventBase),
                CompactionEventVariant2,
                typeof(global::Vectara.CompactionEventVariant2),
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
        public bool Equals(CompactionEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CompactionEventVariant2?>.Default.Equals(CompactionEventVariant2, other.CompactionEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompactionEvent obj1, CompactionEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompactionEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompactionEvent obj1, CompactionEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompactionEvent o && Equals(o);
        }
    }
}
