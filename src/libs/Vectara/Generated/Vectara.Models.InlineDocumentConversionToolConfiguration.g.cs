#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A document conversion tool configuration defined inline in the agent for converting document artifacts to various formats.
    /// </summary>
    public readonly partial struct InlineDocumentConversionToolConfiguration : global::System.IEquatable<InlineDocumentConversionToolConfiguration>
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
        public global::Vectara.InlineDocumentConversionToolConfigurationVariant2? InlineDocumentConversionToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineDocumentConversionToolConfigurationVariant2? InlineDocumentConversionToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineDocumentConversionToolConfigurationVariant2))]
#endif
        public bool IsInlineDocumentConversionToolConfigurationVariant2 => InlineDocumentConversionToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInlineDocumentConversionToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineDocumentConversionToolConfigurationVariant2? value)
        {
            value = InlineDocumentConversionToolConfigurationVariant2;
            return IsInlineDocumentConversionToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.InlineDocumentConversionToolConfigurationVariant2 PickInlineDocumentConversionToolConfigurationVariant2() => IsInlineDocumentConversionToolConfigurationVariant2
            ? InlineDocumentConversionToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InlineDocumentConversionToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineDocumentConversionToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineDocumentConversionToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineDocumentConversionToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineDocumentConversionToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InlineDocumentConversionToolConfiguration FromAgentBase(global::Vectara.AgentToolConfigurationBase? value) => new InlineDocumentConversionToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineDocumentConversionToolConfiguration(global::Vectara.InlineDocumentConversionToolConfigurationVariant2 value) => new InlineDocumentConversionToolConfiguration((global::Vectara.InlineDocumentConversionToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineDocumentConversionToolConfigurationVariant2?(InlineDocumentConversionToolConfiguration @this) => @this.InlineDocumentConversionToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineDocumentConversionToolConfiguration(global::Vectara.InlineDocumentConversionToolConfigurationVariant2? value)
        {
            InlineDocumentConversionToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InlineDocumentConversionToolConfiguration FromInlineDocumentConversionToolConfigurationVariant2(global::Vectara.InlineDocumentConversionToolConfigurationVariant2? value) => new InlineDocumentConversionToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public InlineDocumentConversionToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineDocumentConversionToolConfigurationVariant2? inlineDocumentConversionToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineDocumentConversionToolConfigurationVariant2 = inlineDocumentConversionToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineDocumentConversionToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineDocumentConversionToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineDocumentConversionToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineDocumentConversionToolConfigurationVariant2, TResult>? inlineDocumentConversionToolConfigurationVariant2 = null,
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
            else if (IsInlineDocumentConversionToolConfigurationVariant2 && inlineDocumentConversionToolConfigurationVariant2 != null)
            {
                return inlineDocumentConversionToolConfigurationVariant2(InlineDocumentConversionToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,

            global::System.Action<global::Vectara.InlineDocumentConversionToolConfigurationVariant2>? inlineDocumentConversionToolConfigurationVariant2 = null,
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
            else if (IsInlineDocumentConversionToolConfigurationVariant2)
            {
                inlineDocumentConversionToolConfigurationVariant2?.Invoke(InlineDocumentConversionToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,
            global::System.Action<global::Vectara.InlineDocumentConversionToolConfigurationVariant2>? inlineDocumentConversionToolConfigurationVariant2 = null,
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
            else if (IsInlineDocumentConversionToolConfigurationVariant2)
            {
                inlineDocumentConversionToolConfigurationVariant2?.Invoke(InlineDocumentConversionToolConfigurationVariant2!);
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
                InlineDocumentConversionToolConfigurationVariant2,
                typeof(global::Vectara.InlineDocumentConversionToolConfigurationVariant2),
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
        public bool Equals(InlineDocumentConversionToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineDocumentConversionToolConfigurationVariant2?>.Default.Equals(InlineDocumentConversionToolConfigurationVariant2, other.InlineDocumentConversionToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineDocumentConversionToolConfiguration obj1, InlineDocumentConversionToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineDocumentConversionToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineDocumentConversionToolConfiguration obj1, InlineDocumentConversionToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineDocumentConversionToolConfiguration o && Equals(o);
        }
    }
}
