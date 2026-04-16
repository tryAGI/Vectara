#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Defines how to verify whether a pipeline record was successfully processed by the<br/>
    /// worker agent. Two strategies are supported: a lightweight condition expression or<br/>
    /// a full judge agent.
    /// </summary>
    public readonly partial struct PipelineVerification : global::System.IEquatable<PipelineVerification>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.PipelineVerificationDiscriminatorType? Type { get; }

        /// <summary>
        /// Verify the worker agent's output using a UserFn condition expression. The expression<br/>
        /// is evaluated against the worker agent's session context (output, tools, session metadata).<br/>
        /// If the expression evaluates to true, the record is considered successfully processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ConditionVerification? Condition { get; init; }
#else
        public global::Vectara.ConditionVerification? Condition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Condition))]
#endif
        public bool IsCondition => Condition != null;

        /// <summary>
        /// Verify the worker agent's output using a separate judge agent. The judge agent receives<br/>
        /// a summary of the worker agent's session and must produce a structured output with<br/>
        /// `{ "success": boolean, "reason": string }`. The judge agent must be configured with a<br/>
        /// structured output parser matching this schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentVerification? Agent { get; init; }
#else
        public global::Vectara.AgentVerification? Agent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Agent))]
#endif
        public bool IsAgent => Agent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineVerification(global::Vectara.ConditionVerification value) => new PipelineVerification((global::Vectara.ConditionVerification?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ConditionVerification?(PipelineVerification @this) => @this.Condition;

        /// <summary>
        /// 
        /// </summary>
        public PipelineVerification(global::Vectara.ConditionVerification? value)
        {
            Condition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineVerification(global::Vectara.AgentVerification value) => new PipelineVerification((global::Vectara.AgentVerification?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentVerification?(PipelineVerification @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public PipelineVerification(global::Vectara.AgentVerification? value)
        {
            Agent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PipelineVerification(
            global::Vectara.PipelineVerificationDiscriminatorType? type,
            global::Vectara.ConditionVerification? condition,
            global::Vectara.AgentVerification? agent
            )
        {
            Type = type;

            Condition = condition;
            Agent = agent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Agent as object ??
            Condition as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Condition?.ToString() ??
            Agent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCondition && !IsAgent || !IsCondition && IsAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ConditionVerification?, TResult>? condition = null,
            global::System.Func<global::Vectara.AgentVerification?, TResult>? agent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCondition && condition != null)
            {
                return condition(Condition!);
            }
            else if (IsAgent && agent != null)
            {
                return agent(Agent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ConditionVerification?>? condition = null,
            global::System.Action<global::Vectara.AgentVerification?>? agent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCondition)
            {
                condition?.Invoke(Condition!);
            }
            else if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Condition,
                typeof(global::Vectara.ConditionVerification),
                Agent,
                typeof(global::Vectara.AgentVerification),
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
        public bool Equals(PipelineVerification other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ConditionVerification?>.Default.Equals(Condition, other.Condition) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentVerification?>.Default.Equals(Agent, other.Agent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PipelineVerification obj1, PipelineVerification obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PipelineVerification>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PipelineVerification obj1, PipelineVerification obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PipelineVerification o && Equals(o);
        }
    }
}
