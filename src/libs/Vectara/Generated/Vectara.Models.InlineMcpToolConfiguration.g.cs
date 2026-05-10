#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An MCP tool configuration defined inline in the agent.
    /// </summary>
    public readonly partial struct InlineMcpToolConfiguration : global::System.IEquatable<InlineMcpToolConfiguration>
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
        public global::Vectara.AgentToolConfigurationBase PickAgentBase() => IsAgentBase
            ? AgentBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentBase' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineMcpToolConfigurationVariant2? InlineMcpToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineMcpToolConfigurationVariant2? InlineMcpToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineMcpToolConfigurationVariant2))]
#endif
        public bool IsInlineMcpToolConfigurationVariant2 => InlineMcpToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInlineMcpToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineMcpToolConfigurationVariant2? value)
        {
            value = InlineMcpToolConfigurationVariant2;
            return IsInlineMcpToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineMcpToolConfigurationVariant2 PickInlineMcpToolConfigurationVariant2() => IsInlineMcpToolConfigurationVariant2
            ? InlineMcpToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InlineMcpToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineMcpToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineMcpToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineMcpToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineMcpToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InlineMcpToolConfiguration FromAgentBase(global::Vectara.AgentToolConfigurationBase? value) => new InlineMcpToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineMcpToolConfiguration(global::Vectara.InlineMcpToolConfigurationVariant2 value) => new InlineMcpToolConfiguration((global::Vectara.InlineMcpToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineMcpToolConfigurationVariant2?(InlineMcpToolConfiguration @this) => @this.InlineMcpToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineMcpToolConfiguration(global::Vectara.InlineMcpToolConfigurationVariant2? value)
        {
            InlineMcpToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InlineMcpToolConfiguration FromInlineMcpToolConfigurationVariant2(global::Vectara.InlineMcpToolConfigurationVariant2? value) => new InlineMcpToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public InlineMcpToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineMcpToolConfigurationVariant2? inlineMcpToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineMcpToolConfigurationVariant2 = inlineMcpToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineMcpToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineMcpToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineMcpToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineMcpToolConfigurationVariant2, TResult>? inlineMcpToolConfigurationVariant2 = null,
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
            else if (IsInlineMcpToolConfigurationVariant2 && inlineMcpToolConfigurationVariant2 != null)
            {
                return inlineMcpToolConfigurationVariant2(InlineMcpToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,

            global::System.Action<global::Vectara.InlineMcpToolConfigurationVariant2>? inlineMcpToolConfigurationVariant2 = null,
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
            else if (IsInlineMcpToolConfigurationVariant2)
            {
                inlineMcpToolConfigurationVariant2?.Invoke(InlineMcpToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,
            global::System.Action<global::Vectara.InlineMcpToolConfigurationVariant2>? inlineMcpToolConfigurationVariant2 = null,
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
            else if (IsInlineMcpToolConfigurationVariant2)
            {
                inlineMcpToolConfigurationVariant2?.Invoke(InlineMcpToolConfigurationVariant2!);
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
                InlineMcpToolConfigurationVariant2,
                typeof(global::Vectara.InlineMcpToolConfigurationVariant2),
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
        public bool Equals(InlineMcpToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineMcpToolConfigurationVariant2?>.Default.Equals(InlineMcpToolConfigurationVariant2, other.InlineMcpToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineMcpToolConfiguration obj1, InlineMcpToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineMcpToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineMcpToolConfiguration obj1, InlineMcpToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineMcpToolConfiguration o && Equals(o);
        }
    }
}
