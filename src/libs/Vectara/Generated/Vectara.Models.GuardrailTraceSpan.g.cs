#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A span representing a guardrail safety check on tool call results.
    /// </summary>
    public readonly partial struct GuardrailTraceSpan : global::System.IEquatable<GuardrailTraceSpan>
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
        public global::Vectara.GuardrailTraceSpanVariant2? GuardrailTraceSpanVariant2 { get; init; }
#else
        public global::Vectara.GuardrailTraceSpanVariant2? GuardrailTraceSpanVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GuardrailTraceSpanVariant2))]
#endif
        public bool IsGuardrailTraceSpanVariant2 => GuardrailTraceSpanVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGuardrailTraceSpanVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GuardrailTraceSpanVariant2? value)
        {
            value = GuardrailTraceSpanVariant2;
            return IsGuardrailTraceSpanVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GuardrailTraceSpan(global::Vectara.AgentTraceSpanBase value) => new GuardrailTraceSpan((global::Vectara.AgentTraceSpanBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentTraceSpanBase?(GuardrailTraceSpan @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public GuardrailTraceSpan(global::Vectara.AgentTraceSpanBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GuardrailTraceSpan(global::Vectara.GuardrailTraceSpanVariant2 value) => new GuardrailTraceSpan((global::Vectara.GuardrailTraceSpanVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GuardrailTraceSpanVariant2?(GuardrailTraceSpan @this) => @this.GuardrailTraceSpanVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GuardrailTraceSpan(global::Vectara.GuardrailTraceSpanVariant2? value)
        {
            GuardrailTraceSpanVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GuardrailTraceSpan(
            global::Vectara.AgentTraceSpanBase? agentBase,
            global::Vectara.GuardrailTraceSpanVariant2? guardrailTraceSpanVariant2
            )
        {
            AgentBase = agentBase;
            GuardrailTraceSpanVariant2 = guardrailTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GuardrailTraceSpanVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            GuardrailTraceSpanVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsGuardrailTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentTraceSpanBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.GuardrailTraceSpanVariant2, TResult>? guardrailTraceSpanVariant2 = null,
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
            else if (IsGuardrailTraceSpanVariant2 && guardrailTraceSpanVariant2 != null)
            {
                return guardrailTraceSpanVariant2(GuardrailTraceSpanVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,

            global::System.Action<global::Vectara.GuardrailTraceSpanVariant2>? guardrailTraceSpanVariant2 = null,
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
            else if (IsGuardrailTraceSpanVariant2)
            {
                guardrailTraceSpanVariant2?.Invoke(GuardrailTraceSpanVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,
            global::System.Action<global::Vectara.GuardrailTraceSpanVariant2>? guardrailTraceSpanVariant2 = null,
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
            else if (IsGuardrailTraceSpanVariant2)
            {
                guardrailTraceSpanVariant2?.Invoke(GuardrailTraceSpanVariant2!);
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
                GuardrailTraceSpanVariant2,
                typeof(global::Vectara.GuardrailTraceSpanVariant2),
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
        public bool Equals(GuardrailTraceSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentTraceSpanBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GuardrailTraceSpanVariant2?>.Default.Equals(GuardrailTraceSpanVariant2, other.GuardrailTraceSpanVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GuardrailTraceSpan obj1, GuardrailTraceSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GuardrailTraceSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GuardrailTraceSpan obj1, GuardrailTraceSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GuardrailTraceSpan o && Equals(o);
        }
    }
}
