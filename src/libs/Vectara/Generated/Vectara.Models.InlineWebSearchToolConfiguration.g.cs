#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A web search tool configuration defined inline in the agent.
    /// </summary>
    public readonly partial struct InlineWebSearchToolConfiguration : global::System.IEquatable<InlineWebSearchToolConfiguration>
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
        public global::Vectara.InlineWebSearchToolConfigurationVariant2? InlineWebSearchToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineWebSearchToolConfigurationVariant2? InlineWebSearchToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineWebSearchToolConfigurationVariant2))]
#endif
        public bool IsInlineWebSearchToolConfigurationVariant2 => InlineWebSearchToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineWebSearchToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineWebSearchToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineWebSearchToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineWebSearchToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineWebSearchToolConfiguration(global::Vectara.InlineWebSearchToolConfigurationVariant2 value) => new InlineWebSearchToolConfiguration((global::Vectara.InlineWebSearchToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineWebSearchToolConfigurationVariant2?(InlineWebSearchToolConfiguration @this) => @this.InlineWebSearchToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineWebSearchToolConfiguration(global::Vectara.InlineWebSearchToolConfigurationVariant2? value)
        {
            InlineWebSearchToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineWebSearchToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineWebSearchToolConfigurationVariant2? inlineWebSearchToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineWebSearchToolConfigurationVariant2 = inlineWebSearchToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineWebSearchToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineWebSearchToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineWebSearchToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineWebSearchToolConfigurationVariant2?, TResult>? inlineWebSearchToolConfigurationVariant2 = null,
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
            else if (IsInlineWebSearchToolConfigurationVariant2 && inlineWebSearchToolConfigurationVariant2 != null)
            {
                return inlineWebSearchToolConfigurationVariant2(InlineWebSearchToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase?>? agentBase = null,
            global::System.Action<global::Vectara.InlineWebSearchToolConfigurationVariant2?>? inlineWebSearchToolConfigurationVariant2 = null,
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
            else if (IsInlineWebSearchToolConfigurationVariant2)
            {
                inlineWebSearchToolConfigurationVariant2?.Invoke(InlineWebSearchToolConfigurationVariant2!);
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
                InlineWebSearchToolConfigurationVariant2,
                typeof(global::Vectara.InlineWebSearchToolConfigurationVariant2),
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
        public bool Equals(InlineWebSearchToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineWebSearchToolConfigurationVariant2?>.Default.Equals(InlineWebSearchToolConfigurationVariant2, other.InlineWebSearchToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineWebSearchToolConfiguration obj1, InlineWebSearchToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineWebSearchToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineWebSearchToolConfiguration obj1, InlineWebSearchToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineWebSearchToolConfiguration o && Equals(o);
        }
    }
}
