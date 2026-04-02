#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An event representing a transition between agent steps.
    /// </summary>
    public readonly partial struct StepTransitionEvent : global::System.IEquatable<StepTransitionEvent>
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
        public global::Vectara.StepTransitionEventVariant2? StepTransitionEventVariant2 { get; init; }
#else
        public global::Vectara.StepTransitionEventVariant2? StepTransitionEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepTransitionEventVariant2))]
#endif
        public bool IsStepTransitionEventVariant2 => StepTransitionEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepTransitionEvent(global::Vectara.AgentEventBase value) => new StepTransitionEvent((global::Vectara.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentEventBase?(StepTransitionEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public StepTransitionEvent(global::Vectara.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepTransitionEvent(global::Vectara.StepTransitionEventVariant2 value) => new StepTransitionEvent((global::Vectara.StepTransitionEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StepTransitionEventVariant2?(StepTransitionEvent @this) => @this.StepTransitionEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StepTransitionEvent(global::Vectara.StepTransitionEventVariant2? value)
        {
            StepTransitionEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StepTransitionEvent(
            global::Vectara.AgentEventBase? agentBase,
            global::Vectara.StepTransitionEventVariant2? stepTransitionEventVariant2
            )
        {
            AgentBase = agentBase;
            StepTransitionEventVariant2 = stepTransitionEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StepTransitionEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            StepTransitionEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsStepTransitionEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.StepTransitionEventVariant2?, TResult>? stepTransitionEventVariant2 = null,
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
            else if (IsStepTransitionEventVariant2 && stepTransitionEventVariant2 != null)
            {
                return stepTransitionEventVariant2(StepTransitionEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentEventBase?>? agentBase = null,
            global::System.Action<global::Vectara.StepTransitionEventVariant2?>? stepTransitionEventVariant2 = null,
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
            else if (IsStepTransitionEventVariant2)
            {
                stepTransitionEventVariant2?.Invoke(StepTransitionEventVariant2!);
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
                StepTransitionEventVariant2,
                typeof(global::Vectara.StepTransitionEventVariant2),
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
        public bool Equals(StepTransitionEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepTransitionEventVariant2?>.Default.Equals(StepTransitionEventVariant2, other.StepTransitionEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StepTransitionEvent obj1, StepTransitionEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepTransitionEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StepTransitionEvent obj1, StepTransitionEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepTransitionEvent o && Equals(o);
        }
    }
}
