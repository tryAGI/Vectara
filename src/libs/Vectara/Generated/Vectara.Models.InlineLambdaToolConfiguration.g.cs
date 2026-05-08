#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A lambda tool configuration defined inline in the agent for executing user-defined functions.
    /// </summary>
    public readonly partial struct InlineLambdaToolConfiguration : global::System.IEquatable<InlineLambdaToolConfiguration>
    {
        /// <summary>
        /// Base properties shared by all inline tool configurations on an agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentToolConfigurationBase? AgentBase { get; init; }
#else
        public global::Vectara.AgentToolConfigurationBase? AgentBase { get; }
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
            out global::Vectara.AgentToolConfigurationBase? value)
        {
            value = AgentBase;
            return IsAgentBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineLambdaToolConfigurationVariant2? InlineLambdaToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineLambdaToolConfigurationVariant2? InlineLambdaToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineLambdaToolConfigurationVariant2))]
#endif
        public bool IsInlineLambdaToolConfigurationVariant2 => InlineLambdaToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInlineLambdaToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineLambdaToolConfigurationVariant2? value)
        {
            value = InlineLambdaToolConfigurationVariant2;
            return IsInlineLambdaToolConfigurationVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineLambdaToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineLambdaToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineLambdaToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineLambdaToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineLambdaToolConfiguration(global::Vectara.InlineLambdaToolConfigurationVariant2 value) => new InlineLambdaToolConfiguration((global::Vectara.InlineLambdaToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineLambdaToolConfigurationVariant2?(InlineLambdaToolConfiguration @this) => @this.InlineLambdaToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineLambdaToolConfiguration(global::Vectara.InlineLambdaToolConfigurationVariant2? value)
        {
            InlineLambdaToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineLambdaToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineLambdaToolConfigurationVariant2? inlineLambdaToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineLambdaToolConfigurationVariant2 = inlineLambdaToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineLambdaToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineLambdaToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineLambdaToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineLambdaToolConfigurationVariant2, TResult>? inlineLambdaToolConfigurationVariant2 = null,
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
            else if (IsInlineLambdaToolConfigurationVariant2 && inlineLambdaToolConfigurationVariant2 != null)
            {
                return inlineLambdaToolConfigurationVariant2(InlineLambdaToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,

            global::System.Action<global::Vectara.InlineLambdaToolConfigurationVariant2>? inlineLambdaToolConfigurationVariant2 = null,
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
            else if (IsInlineLambdaToolConfigurationVariant2)
            {
                inlineLambdaToolConfigurationVariant2?.Invoke(InlineLambdaToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,
            global::System.Action<global::Vectara.InlineLambdaToolConfigurationVariant2>? inlineLambdaToolConfigurationVariant2 = null,
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
            else if (IsInlineLambdaToolConfigurationVariant2)
            {
                inlineLambdaToolConfigurationVariant2?.Invoke(InlineLambdaToolConfigurationVariant2!);
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
                typeof(global::Vectara.AgentToolConfigurationBase),
                InlineLambdaToolConfigurationVariant2,
                typeof(global::Vectara.InlineLambdaToolConfigurationVariant2),
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
        public bool Equals(InlineLambdaToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineLambdaToolConfigurationVariant2?>.Default.Equals(InlineLambdaToolConfigurationVariant2, other.InlineLambdaToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineLambdaToolConfiguration obj1, InlineLambdaToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineLambdaToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineLambdaToolConfiguration obj1, InlineLambdaToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineLambdaToolConfiguration o && Equals(o);
        }
    }
}
