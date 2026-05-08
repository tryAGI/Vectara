#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A get document text tool configuration defined inline in the agent for fetching document text content from a corpus.
    /// </summary>
    public readonly partial struct InlineGetDocumentTextToolConfiguration : global::System.IEquatable<InlineGetDocumentTextToolConfiguration>
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
        public global::Vectara.InlineGetDocumentTextToolConfigurationVariant2? InlineGetDocumentTextToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineGetDocumentTextToolConfigurationVariant2? InlineGetDocumentTextToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineGetDocumentTextToolConfigurationVariant2))]
#endif
        public bool IsInlineGetDocumentTextToolConfigurationVariant2 => InlineGetDocumentTextToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInlineGetDocumentTextToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineGetDocumentTextToolConfigurationVariant2? value)
        {
            value = InlineGetDocumentTextToolConfigurationVariant2;
            return IsInlineGetDocumentTextToolConfigurationVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineGetDocumentTextToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineGetDocumentTextToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineGetDocumentTextToolConfiguration @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineGetDocumentTextToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineGetDocumentTextToolConfiguration(global::Vectara.InlineGetDocumentTextToolConfigurationVariant2 value) => new InlineGetDocumentTextToolConfiguration((global::Vectara.InlineGetDocumentTextToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineGetDocumentTextToolConfigurationVariant2?(InlineGetDocumentTextToolConfiguration @this) => @this.InlineGetDocumentTextToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineGetDocumentTextToolConfiguration(global::Vectara.InlineGetDocumentTextToolConfigurationVariant2? value)
        {
            InlineGetDocumentTextToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineGetDocumentTextToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? agentBase,
            global::Vectara.InlineGetDocumentTextToolConfigurationVariant2? inlineGetDocumentTextToolConfigurationVariant2
            )
        {
            AgentBase = agentBase;
            InlineGetDocumentTextToolConfigurationVariant2 = inlineGetDocumentTextToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineGetDocumentTextToolConfigurationVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InlineGetDocumentTextToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInlineGetDocumentTextToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.InlineGetDocumentTextToolConfigurationVariant2, TResult>? inlineGetDocumentTextToolConfigurationVariant2 = null,
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
            else if (IsInlineGetDocumentTextToolConfigurationVariant2 && inlineGetDocumentTextToolConfigurationVariant2 != null)
            {
                return inlineGetDocumentTextToolConfigurationVariant2(InlineGetDocumentTextToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,

            global::System.Action<global::Vectara.InlineGetDocumentTextToolConfigurationVariant2>? inlineGetDocumentTextToolConfigurationVariant2 = null,
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
            else if (IsInlineGetDocumentTextToolConfigurationVariant2)
            {
                inlineGetDocumentTextToolConfigurationVariant2?.Invoke(InlineGetDocumentTextToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? agentBase = null,
            global::System.Action<global::Vectara.InlineGetDocumentTextToolConfigurationVariant2>? inlineGetDocumentTextToolConfigurationVariant2 = null,
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
            else if (IsInlineGetDocumentTextToolConfigurationVariant2)
            {
                inlineGetDocumentTextToolConfigurationVariant2?.Invoke(InlineGetDocumentTextToolConfigurationVariant2!);
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
                InlineGetDocumentTextToolConfigurationVariant2,
                typeof(global::Vectara.InlineGetDocumentTextToolConfigurationVariant2),
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
        public bool Equals(InlineGetDocumentTextToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineGetDocumentTextToolConfigurationVariant2?>.Default.Equals(InlineGetDocumentTextToolConfigurationVariant2, other.InlineGetDocumentTextToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineGetDocumentTextToolConfiguration obj1, InlineGetDocumentTextToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineGetDocumentTextToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineGetDocumentTextToolConfiguration obj1, InlineGetDocumentTextToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineGetDocumentTextToolConfiguration o && Equals(o);
        }
    }
}
