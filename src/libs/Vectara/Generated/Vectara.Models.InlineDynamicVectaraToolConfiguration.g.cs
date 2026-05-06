#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An inline configuration for built-in Vectara tools that have implementations within the platform but do not have a dedicated configuration type schema. Use the List Tools endpoint to discover available tools and obtain the `tool_id` required for this configuration.
    /// </summary>
    public readonly partial struct InlineDynamicVectaraToolConfiguration : global::System.IEquatable<InlineDynamicVectaraToolConfiguration>
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
        public global::Vectara.InlineDynamicVectaraToolConfigurationVariant2? InlineDynamicVectaraToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineDynamicVectaraToolConfigurationVariant2? InlineDynamicVectaraToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineDynamicVectaraToolConfigurationVariant2))]
#endif
        public bool IsInlineDynamicVectaraToolConfigurationVariant2 => InlineDynamicVectaraToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineDynamicVectaraToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineDynamicVectaraToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineDynamicVectaraToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineDynamicVectaraToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineDynamicVectaraToolConfiguration(global::Vectara.InlineDynamicVectaraToolConfigurationVariant2 value) => new InlineDynamicVectaraToolConfiguration((global::Vectara.InlineDynamicVectaraToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineDynamicVectaraToolConfigurationVariant2?(InlineDynamicVectaraToolConfiguration @this) => @this.InlineDynamicVectaraToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineDynamicVectaraToolConfiguration(global::Vectara.InlineDynamicVectaraToolConfigurationVariant2? value)
        {
            InlineDynamicVectaraToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineDynamicVectaraToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineDynamicVectaraToolConfigurationVariant2? inlineDynamicVectaraToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineDynamicVectaraToolConfigurationVariant2 = inlineDynamicVectaraToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineDynamicVectaraToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineDynamicVectaraToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineDynamicVectaraToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineDynamicVectaraToolConfigurationVariant2?, TResult>? inlineDynamicVectaraToolConfigurationVariant2 = null,
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
            else if (IsInlineDynamicVectaraToolConfigurationVariant2 && inlineDynamicVectaraToolConfigurationVariant2 != null)
            {
                return inlineDynamicVectaraToolConfigurationVariant2(InlineDynamicVectaraToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase?>? agentBase = null,
            global::System.Action<global::Vectara.InlineDynamicVectaraToolConfigurationVariant2?>? inlineDynamicVectaraToolConfigurationVariant2 = null,
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
            else if (IsInlineDynamicVectaraToolConfigurationVariant2)
            {
                inlineDynamicVectaraToolConfigurationVariant2?.Invoke(InlineDynamicVectaraToolConfigurationVariant2!);
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
                InlineDynamicVectaraToolConfigurationVariant2,
                typeof(global::Vectara.InlineDynamicVectaraToolConfigurationVariant2),
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
        public bool Equals(InlineDynamicVectaraToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineDynamicVectaraToolConfigurationVariant2?>.Default.Equals(InlineDynamicVectaraToolConfigurationVariant2, other.InlineDynamicVectaraToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineDynamicVectaraToolConfiguration obj1, InlineDynamicVectaraToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineDynamicVectaraToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineDynamicVectaraToolConfiguration obj1, InlineDynamicVectaraToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineDynamicVectaraToolConfiguration o && Equals(o);
        }
    }
}
