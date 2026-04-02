#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A transient event indicating the current request exceeded the LLM's context limit.<br/>
    /// This event is not persisted to the session history.
    /// </summary>
    public readonly partial struct ContextLimitExceededEvent : global::System.IEquatable<ContextLimitExceededEvent>
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
        public global::Vectara.ContextLimitExceededEventVariant2? ContextLimitExceededEventVariant2 { get; init; }
#else
        public global::Vectara.ContextLimitExceededEventVariant2? ContextLimitExceededEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextLimitExceededEventVariant2))]
#endif
        public bool IsContextLimitExceededEventVariant2 => ContextLimitExceededEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContextLimitExceededEvent(global::Vectara.AgentEventBase value) => new ContextLimitExceededEvent((global::Vectara.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentEventBase?(ContextLimitExceededEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ContextLimitExceededEvent(global::Vectara.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContextLimitExceededEvent(global::Vectara.ContextLimitExceededEventVariant2 value) => new ContextLimitExceededEvent((global::Vectara.ContextLimitExceededEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ContextLimitExceededEventVariant2?(ContextLimitExceededEvent @this) => @this.ContextLimitExceededEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ContextLimitExceededEvent(global::Vectara.ContextLimitExceededEventVariant2? value)
        {
            ContextLimitExceededEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContextLimitExceededEvent(
            global::Vectara.AgentEventBase? agentBase,
            global::Vectara.ContextLimitExceededEventVariant2? contextLimitExceededEventVariant2
            )
        {
            AgentBase = agentBase;
            ContextLimitExceededEventVariant2 = contextLimitExceededEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContextLimitExceededEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ContextLimitExceededEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsContextLimitExceededEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.ContextLimitExceededEventVariant2?, TResult>? contextLimitExceededEventVariant2 = null,
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
            else if (IsContextLimitExceededEventVariant2 && contextLimitExceededEventVariant2 != null)
            {
                return contextLimitExceededEventVariant2(ContextLimitExceededEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentEventBase?>? agentBase = null,
            global::System.Action<global::Vectara.ContextLimitExceededEventVariant2?>? contextLimitExceededEventVariant2 = null,
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
            else if (IsContextLimitExceededEventVariant2)
            {
                contextLimitExceededEventVariant2?.Invoke(ContextLimitExceededEventVariant2!);
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
                ContextLimitExceededEventVariant2,
                typeof(global::Vectara.ContextLimitExceededEventVariant2),
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
        public bool Equals(ContextLimitExceededEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ContextLimitExceededEventVariant2?>.Default.Equals(ContextLimitExceededEventVariant2, other.ContextLimitExceededEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContextLimitExceededEvent obj1, ContextLimitExceededEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContextLimitExceededEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContextLimitExceededEvent obj1, ContextLimitExceededEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContextLimitExceededEvent o && Equals(o);
        }
    }
}
