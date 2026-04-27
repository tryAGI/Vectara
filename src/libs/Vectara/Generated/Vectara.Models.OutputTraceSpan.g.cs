#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A span representing the final text output of an agent turn.
    /// </summary>
    public readonly partial struct OutputTraceSpan : global::System.IEquatable<OutputTraceSpan>
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
#if NET6_0_OR_GREATER
        public global::Vectara.OutputTraceSpanVariant2? OutputTraceSpanVariant2 { get; init; }
#else
        public global::Vectara.OutputTraceSpanVariant2? OutputTraceSpanVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputTraceSpanVariant2))]
#endif
        public bool IsOutputTraceSpanVariant2 => OutputTraceSpanVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputTraceSpan(global::Vectara.AgentTraceSpanBase value) => new OutputTraceSpan((global::Vectara.AgentTraceSpanBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentTraceSpanBase?(OutputTraceSpan @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public OutputTraceSpan(global::Vectara.AgentTraceSpanBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputTraceSpan(global::Vectara.OutputTraceSpanVariant2 value) => new OutputTraceSpan((global::Vectara.OutputTraceSpanVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.OutputTraceSpanVariant2?(OutputTraceSpan @this) => @this.OutputTraceSpanVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OutputTraceSpan(global::Vectara.OutputTraceSpanVariant2? value)
        {
            OutputTraceSpanVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputTraceSpan(
            global::Vectara.AgentTraceSpanBase? agentBase,
            global::Vectara.OutputTraceSpanVariant2? outputTraceSpanVariant2
            )
        {
            AgentBase = agentBase;
            OutputTraceSpanVariant2 = outputTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputTraceSpanVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            OutputTraceSpanVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsOutputTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentTraceSpanBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.OutputTraceSpanVariant2?, TResult>? outputTraceSpanVariant2 = null,
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
            else if (IsOutputTraceSpanVariant2 && outputTraceSpanVariant2 != null)
            {
                return outputTraceSpanVariant2(OutputTraceSpanVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentTraceSpanBase?>? agentBase = null,
            global::System.Action<global::Vectara.OutputTraceSpanVariant2?>? outputTraceSpanVariant2 = null,
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
            else if (IsOutputTraceSpanVariant2)
            {
                outputTraceSpanVariant2?.Invoke(OutputTraceSpanVariant2!);
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
                OutputTraceSpanVariant2,
                typeof(global::Vectara.OutputTraceSpanVariant2),
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
        public bool Equals(OutputTraceSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentTraceSpanBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.OutputTraceSpanVariant2?>.Default.Equals(OutputTraceSpanVariant2, other.OutputTraceSpanVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputTraceSpan obj1, OutputTraceSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputTraceSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputTraceSpan obj1, OutputTraceSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputTraceSpan o && Equals(o);
        }
    }
}
