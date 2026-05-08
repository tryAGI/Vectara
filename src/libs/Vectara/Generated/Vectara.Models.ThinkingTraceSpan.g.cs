#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A span representing extended thinking output from the LLM.
    /// </summary>
    public readonly partial struct ThinkingTraceSpan : global::System.IEquatable<ThinkingTraceSpan>
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
        public global::Vectara.ThinkingTraceSpanVariant2? ThinkingTraceSpanVariant2 { get; init; }
#else
        public global::Vectara.ThinkingTraceSpanVariant2? ThinkingTraceSpanVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingTraceSpanVariant2))]
#endif
        public bool IsThinkingTraceSpanVariant2 => ThinkingTraceSpanVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThinkingTraceSpanVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ThinkingTraceSpanVariant2? value)
        {
            value = ThinkingTraceSpanVariant2;
            return IsThinkingTraceSpanVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkingTraceSpan(global::Vectara.AgentTraceSpanBase value) => new ThinkingTraceSpan((global::Vectara.AgentTraceSpanBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentTraceSpanBase?(ThinkingTraceSpan @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ThinkingTraceSpan(global::Vectara.AgentTraceSpanBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkingTraceSpan(global::Vectara.ThinkingTraceSpanVariant2 value) => new ThinkingTraceSpan((global::Vectara.ThinkingTraceSpanVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ThinkingTraceSpanVariant2?(ThinkingTraceSpan @this) => @this.ThinkingTraceSpanVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ThinkingTraceSpan(global::Vectara.ThinkingTraceSpanVariant2? value)
        {
            ThinkingTraceSpanVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ThinkingTraceSpan(
            global::Vectara.AgentTraceSpanBase? agentBase,
            global::Vectara.ThinkingTraceSpanVariant2? thinkingTraceSpanVariant2
            )
        {
            AgentBase = agentBase;
            ThinkingTraceSpanVariant2 = thinkingTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ThinkingTraceSpanVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ThinkingTraceSpanVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsThinkingTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentTraceSpanBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.ThinkingTraceSpanVariant2, TResult>? thinkingTraceSpanVariant2 = null,
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
            else if (IsThinkingTraceSpanVariant2 && thinkingTraceSpanVariant2 != null)
            {
                return thinkingTraceSpanVariant2(ThinkingTraceSpanVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,

            global::System.Action<global::Vectara.ThinkingTraceSpanVariant2>? thinkingTraceSpanVariant2 = null,
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
            else if (IsThinkingTraceSpanVariant2)
            {
                thinkingTraceSpanVariant2?.Invoke(ThinkingTraceSpanVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,
            global::System.Action<global::Vectara.ThinkingTraceSpanVariant2>? thinkingTraceSpanVariant2 = null,
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
            else if (IsThinkingTraceSpanVariant2)
            {
                thinkingTraceSpanVariant2?.Invoke(ThinkingTraceSpanVariant2!);
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
                ThinkingTraceSpanVariant2,
                typeof(global::Vectara.ThinkingTraceSpanVariant2),
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
        public bool Equals(ThinkingTraceSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentTraceSpanBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ThinkingTraceSpanVariant2?>.Default.Equals(ThinkingTraceSpanVariant2, other.ThinkingTraceSpanVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ThinkingTraceSpan obj1, ThinkingTraceSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ThinkingTraceSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ThinkingTraceSpan obj1, ThinkingTraceSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ThinkingTraceSpan o && Equals(o);
        }
    }
}
