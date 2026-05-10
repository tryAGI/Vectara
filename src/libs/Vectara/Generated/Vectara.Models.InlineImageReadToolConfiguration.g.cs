#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An image read tool configuration defined inline in the agent for loading images into the conversation context.
    /// </summary>
    public readonly partial struct InlineImageReadToolConfiguration : global::System.IEquatable<InlineImageReadToolConfiguration>
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
        public global::Vectara.InlineImageReadToolConfigurationVariant2? InlineImageReadToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineImageReadToolConfigurationVariant2? InlineImageReadToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineImageReadToolConfigurationVariant2))]
#endif
        public bool IsInlineImageReadToolConfigurationVariant2 => InlineImageReadToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInlineImageReadToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineImageReadToolConfigurationVariant2? value)
        {
            value = InlineImageReadToolConfigurationVariant2;
            return IsInlineImageReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineImageReadToolConfigurationVariant2 PickInlineImageReadToolConfigurationVariant2() => IsInlineImageReadToolConfigurationVariant2
            ? InlineImageReadToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InlineImageReadToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineImageReadToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineImageReadToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineImageReadToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineImageReadToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InlineImageReadToolConfiguration FromAgentBase(global::Vectara.AgentToolConfigurationBase? value) => new InlineImageReadToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineImageReadToolConfiguration(global::Vectara.InlineImageReadToolConfigurationVariant2 value) => new InlineImageReadToolConfiguration((global::Vectara.InlineImageReadToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineImageReadToolConfigurationVariant2?(InlineImageReadToolConfiguration @this) => @this.InlineImageReadToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineImageReadToolConfiguration(global::Vectara.InlineImageReadToolConfigurationVariant2? value)
        {
            InlineImageReadToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InlineImageReadToolConfiguration FromInlineImageReadToolConfigurationVariant2(global::Vectara.InlineImageReadToolConfigurationVariant2? value) => new InlineImageReadToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public InlineImageReadToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineImageReadToolConfigurationVariant2? inlineImageReadToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineImageReadToolConfigurationVariant2 = inlineImageReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineImageReadToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineImageReadToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineImageReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineImageReadToolConfigurationVariant2, TResult>? inlineImageReadToolConfigurationVariant2 = null,
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
            else if (IsInlineImageReadToolConfigurationVariant2 && inlineImageReadToolConfigurationVariant2 != null)
            {
                return inlineImageReadToolConfigurationVariant2(InlineImageReadToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,

            global::System.Action<global::Vectara.InlineImageReadToolConfigurationVariant2>? inlineImageReadToolConfigurationVariant2 = null,
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
            else if (IsInlineImageReadToolConfigurationVariant2)
            {
                inlineImageReadToolConfigurationVariant2?.Invoke(InlineImageReadToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,
            global::System.Action<global::Vectara.InlineImageReadToolConfigurationVariant2>? inlineImageReadToolConfigurationVariant2 = null,
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
            else if (IsInlineImageReadToolConfigurationVariant2)
            {
                inlineImageReadToolConfigurationVariant2?.Invoke(InlineImageReadToolConfigurationVariant2!);
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
                InlineImageReadToolConfigurationVariant2,
                typeof(global::Vectara.InlineImageReadToolConfigurationVariant2),
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
        public bool Equals(InlineImageReadToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineImageReadToolConfigurationVariant2?>.Default.Equals(InlineImageReadToolConfigurationVariant2, other.InlineImageReadToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineImageReadToolConfiguration obj1, InlineImageReadToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineImageReadToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineImageReadToolConfiguration obj1, InlineImageReadToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineImageReadToolConfiguration o && Equals(o);
        }
    }
}
