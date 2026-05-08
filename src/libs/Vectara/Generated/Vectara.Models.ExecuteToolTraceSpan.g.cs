#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A span representing a tool execution within an agent turn.
    /// </summary>
    public readonly partial struct ExecuteToolTraceSpan : global::System.IEquatable<ExecuteToolTraceSpan>
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
        public global::Vectara.ExecuteToolTraceSpanVariant2? ExecuteToolTraceSpanVariant2 { get; init; }
#else
        public global::Vectara.ExecuteToolTraceSpanVariant2? ExecuteToolTraceSpanVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecuteToolTraceSpanVariant2))]
#endif
        public bool IsExecuteToolTraceSpanVariant2 => ExecuteToolTraceSpanVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickExecuteToolTraceSpanVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ExecuteToolTraceSpanVariant2? value)
        {
            value = ExecuteToolTraceSpanVariant2;
            return IsExecuteToolTraceSpanVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecuteToolTraceSpan(global::Vectara.AgentTraceSpanBase value) => new ExecuteToolTraceSpan((global::Vectara.AgentTraceSpanBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentTraceSpanBase?(ExecuteToolTraceSpan @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ExecuteToolTraceSpan(global::Vectara.AgentTraceSpanBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecuteToolTraceSpan(global::Vectara.ExecuteToolTraceSpanVariant2 value) => new ExecuteToolTraceSpan((global::Vectara.ExecuteToolTraceSpanVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ExecuteToolTraceSpanVariant2?(ExecuteToolTraceSpan @this) => @this.ExecuteToolTraceSpanVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ExecuteToolTraceSpan(global::Vectara.ExecuteToolTraceSpanVariant2? value)
        {
            ExecuteToolTraceSpanVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExecuteToolTraceSpan(
            global::Vectara.AgentTraceSpanBase? agentBase,
            global::Vectara.ExecuteToolTraceSpanVariant2? executeToolTraceSpanVariant2
            )
        {
            AgentBase = agentBase;
            ExecuteToolTraceSpanVariant2 = executeToolTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ExecuteToolTraceSpanVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ExecuteToolTraceSpanVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsExecuteToolTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentTraceSpanBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.ExecuteToolTraceSpanVariant2, TResult>? executeToolTraceSpanVariant2 = null,
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
            else if (IsExecuteToolTraceSpanVariant2 && executeToolTraceSpanVariant2 != null)
            {
                return executeToolTraceSpanVariant2(ExecuteToolTraceSpanVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,

            global::System.Action<global::Vectara.ExecuteToolTraceSpanVariant2>? executeToolTraceSpanVariant2 = null,
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
            else if (IsExecuteToolTraceSpanVariant2)
            {
                executeToolTraceSpanVariant2?.Invoke(ExecuteToolTraceSpanVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,
            global::System.Action<global::Vectara.ExecuteToolTraceSpanVariant2>? executeToolTraceSpanVariant2 = null,
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
            else if (IsExecuteToolTraceSpanVariant2)
            {
                executeToolTraceSpanVariant2?.Invoke(ExecuteToolTraceSpanVariant2!);
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
                ExecuteToolTraceSpanVariant2,
                typeof(global::Vectara.ExecuteToolTraceSpanVariant2),
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
        public bool Equals(ExecuteToolTraceSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentTraceSpanBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ExecuteToolTraceSpanVariant2?>.Default.Equals(ExecuteToolTraceSpanVariant2, other.ExecuteToolTraceSpanVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExecuteToolTraceSpan obj1, ExecuteToolTraceSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExecuteToolTraceSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExecuteToolTraceSpan obj1, ExecuteToolTraceSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExecuteToolTraceSpan o && Equals(o);
        }
    }
}
