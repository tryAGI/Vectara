#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A client tool configuration defined inline in the agent. When invoked, the agent emits a `tool_input` event and waits for the calling client to submit a matching tool output via `createAgentInput`.
    /// </summary>
    public readonly partial struct InlineClientToolConfiguration : global::System.IEquatable<InlineClientToolConfiguration>
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
        public global::Vectara.InlineClientToolConfigurationVariant2? InlineClientToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineClientToolConfigurationVariant2? InlineClientToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineClientToolConfigurationVariant2))]
#endif
        public bool IsInlineClientToolConfigurationVariant2 => InlineClientToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInlineClientToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineClientToolConfigurationVariant2? value)
        {
            value = InlineClientToolConfigurationVariant2;
            return IsInlineClientToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineClientToolConfigurationVariant2 PickInlineClientToolConfigurationVariant2() => IsInlineClientToolConfigurationVariant2
            ? InlineClientToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InlineClientToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineClientToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineClientToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineClientToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineClientToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InlineClientToolConfiguration FromAgentBase(global::Vectara.AgentToolConfigurationBase? value) => new InlineClientToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineClientToolConfiguration(global::Vectara.InlineClientToolConfigurationVariant2 value) => new InlineClientToolConfiguration((global::Vectara.InlineClientToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineClientToolConfigurationVariant2?(InlineClientToolConfiguration @this) => @this.InlineClientToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineClientToolConfiguration(global::Vectara.InlineClientToolConfigurationVariant2? value)
        {
            InlineClientToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InlineClientToolConfiguration FromInlineClientToolConfigurationVariant2(global::Vectara.InlineClientToolConfigurationVariant2? value) => new InlineClientToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public InlineClientToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineClientToolConfigurationVariant2? inlineClientToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineClientToolConfigurationVariant2 = inlineClientToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineClientToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineClientToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineClientToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineClientToolConfigurationVariant2, TResult>? inlineClientToolConfigurationVariant2 = null,
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
            else if (IsInlineClientToolConfigurationVariant2 && inlineClientToolConfigurationVariant2 != null)
            {
                return inlineClientToolConfigurationVariant2(InlineClientToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,

            global::System.Action<global::Vectara.InlineClientToolConfigurationVariant2>? inlineClientToolConfigurationVariant2 = null,
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
            else if (IsInlineClientToolConfigurationVariant2)
            {
                inlineClientToolConfigurationVariant2?.Invoke(InlineClientToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,
            global::System.Action<global::Vectara.InlineClientToolConfigurationVariant2>? inlineClientToolConfigurationVariant2 = null,
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
            else if (IsInlineClientToolConfigurationVariant2)
            {
                inlineClientToolConfigurationVariant2?.Invoke(InlineClientToolConfigurationVariant2!);
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
                InlineClientToolConfigurationVariant2,
                typeof(global::Vectara.InlineClientToolConfigurationVariant2),
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
        public bool Equals(InlineClientToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineClientToolConfigurationVariant2?>.Default.Equals(InlineClientToolConfigurationVariant2, other.InlineClientToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineClientToolConfiguration obj1, InlineClientToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineClientToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineClientToolConfiguration obj1, InlineClientToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineClientToolConfiguration o && Equals(o);
        }
    }
}
