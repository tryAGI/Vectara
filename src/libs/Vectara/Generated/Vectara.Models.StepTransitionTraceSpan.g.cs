#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A span representing a transition between agent steps.
    /// </summary>
    public readonly partial struct StepTransitionTraceSpan : global::System.IEquatable<StepTransitionTraceSpan>
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
#if NET6_0_OR_GREATER
        public global::Vectara.StepTransitionTraceSpanVariant2? StepTransitionTraceSpanVariant2 { get; init; }
#else
        public global::Vectara.StepTransitionTraceSpanVariant2? StepTransitionTraceSpanVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepTransitionTraceSpanVariant2))]
#endif
        public bool IsStepTransitionTraceSpanVariant2 => StepTransitionTraceSpanVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStepTransitionTraceSpanVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StepTransitionTraceSpanVariant2? value)
        {
            value = StepTransitionTraceSpanVariant2;
            return IsStepTransitionTraceSpanVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepTransitionTraceSpan(global::Vectara.AgentTraceSpanBase value) => new StepTransitionTraceSpan((global::Vectara.AgentTraceSpanBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentTraceSpanBase?(StepTransitionTraceSpan @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public StepTransitionTraceSpan(global::Vectara.AgentTraceSpanBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepTransitionTraceSpan(global::Vectara.StepTransitionTraceSpanVariant2 value) => new StepTransitionTraceSpan((global::Vectara.StepTransitionTraceSpanVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StepTransitionTraceSpanVariant2?(StepTransitionTraceSpan @this) => @this.StepTransitionTraceSpanVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StepTransitionTraceSpan(global::Vectara.StepTransitionTraceSpanVariant2? value)
        {
            StepTransitionTraceSpanVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StepTransitionTraceSpan(
            global::Vectara.AgentTraceSpanBase? agentBase,
            global::Vectara.StepTransitionTraceSpanVariant2? stepTransitionTraceSpanVariant2
            )
        {
            AgentBase = agentBase;
            StepTransitionTraceSpanVariant2 = stepTransitionTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StepTransitionTraceSpanVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            StepTransitionTraceSpanVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsStepTransitionTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentTraceSpanBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.StepTransitionTraceSpanVariant2, TResult>? stepTransitionTraceSpanVariant2 = null,
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
            else if (IsStepTransitionTraceSpanVariant2 && stepTransitionTraceSpanVariant2 != null)
            {
                return stepTransitionTraceSpanVariant2(StepTransitionTraceSpanVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,

            global::System.Action<global::Vectara.StepTransitionTraceSpanVariant2>? stepTransitionTraceSpanVariant2 = null,
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
            else if (IsStepTransitionTraceSpanVariant2)
            {
                stepTransitionTraceSpanVariant2?.Invoke(StepTransitionTraceSpanVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,
            global::System.Action<global::Vectara.StepTransitionTraceSpanVariant2>? stepTransitionTraceSpanVariant2 = null,
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
            else if (IsStepTransitionTraceSpanVariant2)
            {
                stepTransitionTraceSpanVariant2?.Invoke(StepTransitionTraceSpanVariant2!);
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
                StepTransitionTraceSpanVariant2,
                typeof(global::Vectara.StepTransitionTraceSpanVariant2),
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
        public bool Equals(StepTransitionTraceSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentTraceSpanBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepTransitionTraceSpanVariant2?>.Default.Equals(StepTransitionTraceSpanVariant2, other.StepTransitionTraceSpanVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StepTransitionTraceSpan obj1, StepTransitionTraceSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepTransitionTraceSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StepTransitionTraceSpan obj1, StepTransitionTraceSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepTransitionTraceSpan o && Equals(o);
        }
    }
}
