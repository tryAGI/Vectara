#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An artifact create tool configuration defined inline in the agent for creating artifacts on-the-fly from text or structured data content.
    /// </summary>
    public readonly partial struct InlineArtifactCreateToolConfiguration : global::System.IEquatable<InlineArtifactCreateToolConfiguration>
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
        public global::Vectara.InlineArtifactCreateToolConfigurationVariant2? InlineArtifactCreateToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineArtifactCreateToolConfigurationVariant2? InlineArtifactCreateToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineArtifactCreateToolConfigurationVariant2))]
#endif
        public bool IsInlineArtifactCreateToolConfigurationVariant2 => InlineArtifactCreateToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineArtifactCreateToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineArtifactCreateToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineArtifactCreateToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineArtifactCreateToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineArtifactCreateToolConfiguration(global::Vectara.InlineArtifactCreateToolConfigurationVariant2 value) => new InlineArtifactCreateToolConfiguration((global::Vectara.InlineArtifactCreateToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineArtifactCreateToolConfigurationVariant2?(InlineArtifactCreateToolConfiguration @this) => @this.InlineArtifactCreateToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineArtifactCreateToolConfiguration(global::Vectara.InlineArtifactCreateToolConfigurationVariant2? value)
        {
            InlineArtifactCreateToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineArtifactCreateToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineArtifactCreateToolConfigurationVariant2? inlineArtifactCreateToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineArtifactCreateToolConfigurationVariant2 = inlineArtifactCreateToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineArtifactCreateToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineArtifactCreateToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineArtifactCreateToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineArtifactCreateToolConfigurationVariant2?, TResult>? inlineArtifactCreateToolConfigurationVariant2 = null,
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
            else if (IsInlineArtifactCreateToolConfigurationVariant2 && inlineArtifactCreateToolConfigurationVariant2 != null)
            {
                return inlineArtifactCreateToolConfigurationVariant2(InlineArtifactCreateToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase?>? agentBase = null,
            global::System.Action<global::Vectara.InlineArtifactCreateToolConfigurationVariant2?>? inlineArtifactCreateToolConfigurationVariant2 = null,
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
            else if (IsInlineArtifactCreateToolConfigurationVariant2)
            {
                inlineArtifactCreateToolConfigurationVariant2?.Invoke(InlineArtifactCreateToolConfigurationVariant2!);
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
                InlineArtifactCreateToolConfigurationVariant2,
                typeof(global::Vectara.InlineArtifactCreateToolConfigurationVariant2),
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
        public bool Equals(InlineArtifactCreateToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineArtifactCreateToolConfigurationVariant2?>.Default.Equals(InlineArtifactCreateToolConfigurationVariant2, other.InlineArtifactCreateToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineArtifactCreateToolConfiguration obj1, InlineArtifactCreateToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineArtifactCreateToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineArtifactCreateToolConfiguration obj1, InlineArtifactCreateToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineArtifactCreateToolConfiguration o && Equals(o);
        }
    }
}
