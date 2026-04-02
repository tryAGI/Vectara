#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An event representing chain-of-thought thinking by the agent.
    /// </summary>
    public readonly partial struct ThinkingEvent : global::System.IEquatable<ThinkingEvent>
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
        public global::Vectara.ThinkingEventVariant2? ThinkingEventVariant2 { get; init; }
#else
        public global::Vectara.ThinkingEventVariant2? ThinkingEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingEventVariant2))]
#endif
        public bool IsThinkingEventVariant2 => ThinkingEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkingEvent(global::Vectara.AgentEventBase value) => new ThinkingEvent((global::Vectara.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentEventBase?(ThinkingEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ThinkingEvent(global::Vectara.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkingEvent(global::Vectara.ThinkingEventVariant2 value) => new ThinkingEvent((global::Vectara.ThinkingEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ThinkingEventVariant2?(ThinkingEvent @this) => @this.ThinkingEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ThinkingEvent(global::Vectara.ThinkingEventVariant2? value)
        {
            ThinkingEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ThinkingEvent(
            global::Vectara.AgentEventBase? agentBase,
            global::Vectara.ThinkingEventVariant2? thinkingEventVariant2
            )
        {
            AgentBase = agentBase;
            ThinkingEventVariant2 = thinkingEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ThinkingEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ThinkingEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsThinkingEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.ThinkingEventVariant2?, TResult>? thinkingEventVariant2 = null,
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
            else if (IsThinkingEventVariant2 && thinkingEventVariant2 != null)
            {
                return thinkingEventVariant2(ThinkingEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentEventBase?>? agentBase = null,
            global::System.Action<global::Vectara.ThinkingEventVariant2?>? thinkingEventVariant2 = null,
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
            else if (IsThinkingEventVariant2)
            {
                thinkingEventVariant2?.Invoke(ThinkingEventVariant2!);
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
                ThinkingEventVariant2,
                typeof(global::Vectara.ThinkingEventVariant2),
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
        public bool Equals(ThinkingEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ThinkingEventVariant2?>.Default.Equals(ThinkingEventVariant2, other.ThinkingEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ThinkingEvent obj1, ThinkingEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ThinkingEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ThinkingEvent obj1, ThinkingEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ThinkingEvent o && Equals(o);
        }
    }
}
