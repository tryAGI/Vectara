#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A web get tool configuration defined inline in the agent for fetching content from URLs.
    /// </summary>
    public readonly partial struct InlineWebGetToolConfiguration : global::System.IEquatable<InlineWebGetToolConfiguration>
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
        public global::Vectara.InlineWebGetToolConfigurationVariant2? InlineWebGetToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineWebGetToolConfigurationVariant2? InlineWebGetToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineWebGetToolConfigurationVariant2))]
#endif
        public bool IsInlineWebGetToolConfigurationVariant2 => InlineWebGetToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInlineWebGetToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineWebGetToolConfigurationVariant2? value)
        {
            value = InlineWebGetToolConfigurationVariant2;
            return IsInlineWebGetToolConfigurationVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineWebGetToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineWebGetToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineWebGetToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineWebGetToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineWebGetToolConfiguration(global::Vectara.InlineWebGetToolConfigurationVariant2 value) => new InlineWebGetToolConfiguration((global::Vectara.InlineWebGetToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineWebGetToolConfigurationVariant2?(InlineWebGetToolConfiguration @this) => @this.InlineWebGetToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineWebGetToolConfiguration(global::Vectara.InlineWebGetToolConfigurationVariant2? value)
        {
            InlineWebGetToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineWebGetToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineWebGetToolConfigurationVariant2? inlineWebGetToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineWebGetToolConfigurationVariant2 = inlineWebGetToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineWebGetToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineWebGetToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineWebGetToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineWebGetToolConfigurationVariant2, TResult>? inlineWebGetToolConfigurationVariant2 = null,
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
            else if (IsInlineWebGetToolConfigurationVariant2 && inlineWebGetToolConfigurationVariant2 != null)
            {
                return inlineWebGetToolConfigurationVariant2(InlineWebGetToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,

            global::System.Action<global::Vectara.InlineWebGetToolConfigurationVariant2>? inlineWebGetToolConfigurationVariant2 = null,
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
            else if (IsInlineWebGetToolConfigurationVariant2)
            {
                inlineWebGetToolConfigurationVariant2?.Invoke(InlineWebGetToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,
            global::System.Action<global::Vectara.InlineWebGetToolConfigurationVariant2>? inlineWebGetToolConfigurationVariant2 = null,
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
            else if (IsInlineWebGetToolConfigurationVariant2)
            {
                inlineWebGetToolConfigurationVariant2?.Invoke(InlineWebGetToolConfigurationVariant2!);
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
                InlineWebGetToolConfigurationVariant2,
                typeof(global::Vectara.InlineWebGetToolConfigurationVariant2),
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
        public bool Equals(InlineWebGetToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineWebGetToolConfigurationVariant2?>.Default.Equals(InlineWebGetToolConfigurationVariant2, other.InlineWebGetToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineWebGetToolConfiguration obj1, InlineWebGetToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineWebGetToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineWebGetToolConfiguration obj1, InlineWebGetToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineWebGetToolConfiguration o && Equals(o);
        }
    }
}
