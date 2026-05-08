#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An artifact grep tool configuration defined inline in the agent for searching through artifact content.
    /// </summary>
    public readonly partial struct InlineArtifactGrepToolConfiguration : global::System.IEquatable<InlineArtifactGrepToolConfiguration>
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
        public global::Vectara.InlineArtifactGrepToolConfigurationVariant2? InlineArtifactGrepToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineArtifactGrepToolConfigurationVariant2? InlineArtifactGrepToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineArtifactGrepToolConfigurationVariant2))]
#endif
        public bool IsInlineArtifactGrepToolConfigurationVariant2 => InlineArtifactGrepToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInlineArtifactGrepToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineArtifactGrepToolConfigurationVariant2? value)
        {
            value = InlineArtifactGrepToolConfigurationVariant2;
            return IsInlineArtifactGrepToolConfigurationVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineArtifactGrepToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineArtifactGrepToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineArtifactGrepToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineArtifactGrepToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineArtifactGrepToolConfiguration(global::Vectara.InlineArtifactGrepToolConfigurationVariant2 value) => new InlineArtifactGrepToolConfiguration((global::Vectara.InlineArtifactGrepToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineArtifactGrepToolConfigurationVariant2?(InlineArtifactGrepToolConfiguration @this) => @this.InlineArtifactGrepToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineArtifactGrepToolConfiguration(global::Vectara.InlineArtifactGrepToolConfigurationVariant2? value)
        {
            InlineArtifactGrepToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineArtifactGrepToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineArtifactGrepToolConfigurationVariant2? inlineArtifactGrepToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineArtifactGrepToolConfigurationVariant2 = inlineArtifactGrepToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineArtifactGrepToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineArtifactGrepToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineArtifactGrepToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineArtifactGrepToolConfigurationVariant2, TResult>? inlineArtifactGrepToolConfigurationVariant2 = null,
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
            else if (IsInlineArtifactGrepToolConfigurationVariant2 && inlineArtifactGrepToolConfigurationVariant2 != null)
            {
                return inlineArtifactGrepToolConfigurationVariant2(InlineArtifactGrepToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,

            global::System.Action<global::Vectara.InlineArtifactGrepToolConfigurationVariant2>? inlineArtifactGrepToolConfigurationVariant2 = null,
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
            else if (IsInlineArtifactGrepToolConfigurationVariant2)
            {
                inlineArtifactGrepToolConfigurationVariant2?.Invoke(InlineArtifactGrepToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,
            global::System.Action<global::Vectara.InlineArtifactGrepToolConfigurationVariant2>? inlineArtifactGrepToolConfigurationVariant2 = null,
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
            else if (IsInlineArtifactGrepToolConfigurationVariant2)
            {
                inlineArtifactGrepToolConfigurationVariant2?.Invoke(InlineArtifactGrepToolConfigurationVariant2!);
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
                InlineArtifactGrepToolConfigurationVariant2,
                typeof(global::Vectara.InlineArtifactGrepToolConfigurationVariant2),
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
        public bool Equals(InlineArtifactGrepToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineArtifactGrepToolConfigurationVariant2?>.Default.Equals(InlineArtifactGrepToolConfigurationVariant2, other.InlineArtifactGrepToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineArtifactGrepToolConfiguration obj1, InlineArtifactGrepToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineArtifactGrepToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineArtifactGrepToolConfiguration obj1, InlineArtifactGrepToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineArtifactGrepToolConfiguration o && Equals(o);
        }
    }
}
