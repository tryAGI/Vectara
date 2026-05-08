#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An artifact read tool configuration defined inline in the agent for reading artifacts from the session workspace.
    /// </summary>
    public readonly partial struct InlineArtifactReadToolConfiguration : global::System.IEquatable<InlineArtifactReadToolConfiguration>
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
        public global::Vectara.InlineArtifactReadToolConfigurationVariant2? InlineArtifactReadToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineArtifactReadToolConfigurationVariant2? InlineArtifactReadToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineArtifactReadToolConfigurationVariant2))]
#endif
        public bool IsInlineArtifactReadToolConfigurationVariant2 => InlineArtifactReadToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInlineArtifactReadToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineArtifactReadToolConfigurationVariant2? value)
        {
            value = InlineArtifactReadToolConfigurationVariant2;
            return IsInlineArtifactReadToolConfigurationVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineArtifactReadToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineArtifactReadToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineArtifactReadToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineArtifactReadToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineArtifactReadToolConfiguration(global::Vectara.InlineArtifactReadToolConfigurationVariant2 value) => new InlineArtifactReadToolConfiguration((global::Vectara.InlineArtifactReadToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineArtifactReadToolConfigurationVariant2?(InlineArtifactReadToolConfiguration @this) => @this.InlineArtifactReadToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineArtifactReadToolConfiguration(global::Vectara.InlineArtifactReadToolConfigurationVariant2? value)
        {
            InlineArtifactReadToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineArtifactReadToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineArtifactReadToolConfigurationVariant2? inlineArtifactReadToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineArtifactReadToolConfigurationVariant2 = inlineArtifactReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineArtifactReadToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineArtifactReadToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineArtifactReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineArtifactReadToolConfigurationVariant2, TResult>? inlineArtifactReadToolConfigurationVariant2 = null,
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
            else if (IsInlineArtifactReadToolConfigurationVariant2 && inlineArtifactReadToolConfigurationVariant2 != null)
            {
                return inlineArtifactReadToolConfigurationVariant2(InlineArtifactReadToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,

            global::System.Action<global::Vectara.InlineArtifactReadToolConfigurationVariant2>? inlineArtifactReadToolConfigurationVariant2 = null,
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
            else if (IsInlineArtifactReadToolConfigurationVariant2)
            {
                inlineArtifactReadToolConfigurationVariant2?.Invoke(InlineArtifactReadToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,
            global::System.Action<global::Vectara.InlineArtifactReadToolConfigurationVariant2>? inlineArtifactReadToolConfigurationVariant2 = null,
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
            else if (IsInlineArtifactReadToolConfigurationVariant2)
            {
                inlineArtifactReadToolConfigurationVariant2?.Invoke(InlineArtifactReadToolConfigurationVariant2!);
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
                InlineArtifactReadToolConfigurationVariant2,
                typeof(global::Vectara.InlineArtifactReadToolConfigurationVariant2),
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
        public bool Equals(InlineArtifactReadToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineArtifactReadToolConfigurationVariant2?>.Default.Equals(InlineArtifactReadToolConfigurationVariant2, other.InlineArtifactReadToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineArtifactReadToolConfiguration obj1, InlineArtifactReadToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineArtifactReadToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineArtifactReadToolConfiguration obj1, InlineArtifactReadToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineArtifactReadToolConfiguration o && Equals(o);
        }
    }
}
