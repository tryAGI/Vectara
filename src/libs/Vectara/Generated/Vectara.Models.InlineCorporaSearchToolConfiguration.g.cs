#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A corpora search tool configuration defined inline in the agent.
    /// </summary>
    public readonly partial struct InlineCorporaSearchToolConfiguration : global::System.IEquatable<InlineCorporaSearchToolConfiguration>
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
#if NET6_0_OR_GREATER
        public global::Vectara.InlineCorporaSearchToolConfigurationVariant2? InlineCorporaSearchToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineCorporaSearchToolConfigurationVariant2? InlineCorporaSearchToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineCorporaSearchToolConfigurationVariant2))]
#endif
        public bool IsInlineCorporaSearchToolConfigurationVariant2 => InlineCorporaSearchToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineCorporaSearchToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineCorporaSearchToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineCorporaSearchToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineCorporaSearchToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineCorporaSearchToolConfiguration(global::Vectara.InlineCorporaSearchToolConfigurationVariant2 value) => new InlineCorporaSearchToolConfiguration((global::Vectara.InlineCorporaSearchToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineCorporaSearchToolConfigurationVariant2?(InlineCorporaSearchToolConfiguration @this) => @this.InlineCorporaSearchToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineCorporaSearchToolConfiguration(global::Vectara.InlineCorporaSearchToolConfigurationVariant2? value)
        {
            InlineCorporaSearchToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineCorporaSearchToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineCorporaSearchToolConfigurationVariant2? inlineCorporaSearchToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineCorporaSearchToolConfigurationVariant2 = inlineCorporaSearchToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineCorporaSearchToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineCorporaSearchToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineCorporaSearchToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineCorporaSearchToolConfigurationVariant2?, TResult>? inlineCorporaSearchToolConfigurationVariant2 = null,
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
            else if (IsInlineCorporaSearchToolConfigurationVariant2 && inlineCorporaSearchToolConfigurationVariant2 != null)
            {
                return inlineCorporaSearchToolConfigurationVariant2(InlineCorporaSearchToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase?>? agentBase = null,
            global::System.Action<global::Vectara.InlineCorporaSearchToolConfigurationVariant2?>? inlineCorporaSearchToolConfigurationVariant2 = null,
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
            else if (IsInlineCorporaSearchToolConfigurationVariant2)
            {
                inlineCorporaSearchToolConfigurationVariant2?.Invoke(InlineCorporaSearchToolConfigurationVariant2!);
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
                InlineCorporaSearchToolConfigurationVariant2,
                typeof(global::Vectara.InlineCorporaSearchToolConfigurationVariant2),
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
        public bool Equals(InlineCorporaSearchToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineCorporaSearchToolConfigurationVariant2?>.Default.Equals(InlineCorporaSearchToolConfigurationVariant2, other.InlineCorporaSearchToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineCorporaSearchToolConfiguration obj1, InlineCorporaSearchToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineCorporaSearchToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineCorporaSearchToolConfiguration obj1, InlineCorporaSearchToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineCorporaSearchToolConfiguration o && Equals(o);
        }
    }
}
