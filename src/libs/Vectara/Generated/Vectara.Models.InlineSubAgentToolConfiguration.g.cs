#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A sub-agent tool configuration defined inline in the agent for invoking specialized sub-agents.
    /// </summary>
    public readonly partial struct InlineSubAgentToolConfiguration : global::System.IEquatable<InlineSubAgentToolConfiguration>
    {
        /// <summary>
        /// Base properties shared by all inline tool configurations on an agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentToolConfigurationBase? Base { get; init; }
#else
        public global::Vectara.AgentToolConfigurationBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.AgentToolConfigurationBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineSubAgentToolConfigurationVariant2? InlineSubAgentToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.InlineSubAgentToolConfigurationVariant2? InlineSubAgentToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineSubAgentToolConfigurationVariant2))]
#endif
        public bool IsInlineSubAgentToolConfigurationVariant2 => InlineSubAgentToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInlineSubAgentToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InlineSubAgentToolConfigurationVariant2? value)
        {
            value = InlineSubAgentToolConfigurationVariant2;
            return IsInlineSubAgentToolConfigurationVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineSubAgentToolConfiguration(global::Vectara.AgentToolConfigurationBase value) => new InlineSubAgentToolConfiguration((global::Vectara.AgentToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentToolConfigurationBase?(InlineSubAgentToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public InlineSubAgentToolConfiguration(global::Vectara.AgentToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineSubAgentToolConfiguration(global::Vectara.InlineSubAgentToolConfigurationVariant2 value) => new InlineSubAgentToolConfiguration((global::Vectara.InlineSubAgentToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineSubAgentToolConfigurationVariant2?(InlineSubAgentToolConfiguration @this) => @this.InlineSubAgentToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineSubAgentToolConfiguration(global::Vectara.InlineSubAgentToolConfigurationVariant2? value)
        {
            InlineSubAgentToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineSubAgentToolConfiguration(
            global::Vectara.AgentToolConfigurationBase? @base,
            global::Vectara.InlineSubAgentToolConfigurationVariant2? inlineSubAgentToolConfigurationVariant2
            )
        {
            Base = @base;
            InlineSubAgentToolConfigurationVariant2 = inlineSubAgentToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineSubAgentToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            InlineSubAgentToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsInlineSubAgentToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentToolConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.InlineSubAgentToolConfigurationVariant2, TResult>? inlineSubAgentToolConfigurationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsInlineSubAgentToolConfigurationVariant2 && inlineSubAgentToolConfigurationVariant2 != null)
            {
                return inlineSubAgentToolConfigurationVariant2(InlineSubAgentToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.InlineSubAgentToolConfigurationVariant2>? inlineSubAgentToolConfigurationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsInlineSubAgentToolConfigurationVariant2)
            {
                inlineSubAgentToolConfigurationVariant2?.Invoke(InlineSubAgentToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentToolConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.InlineSubAgentToolConfigurationVariant2>? inlineSubAgentToolConfigurationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsInlineSubAgentToolConfigurationVariant2)
            {
                inlineSubAgentToolConfigurationVariant2?.Invoke(InlineSubAgentToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Vectara.AgentToolConfigurationBase),
                InlineSubAgentToolConfigurationVariant2,
                typeof(global::Vectara.InlineSubAgentToolConfigurationVariant2),
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
        public bool Equals(InlineSubAgentToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineSubAgentToolConfigurationVariant2?>.Default.Equals(InlineSubAgentToolConfigurationVariant2, other.InlineSubAgentToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineSubAgentToolConfiguration obj1, InlineSubAgentToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineSubAgentToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineSubAgentToolConfiguration obj1, InlineSubAgentToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineSubAgentToolConfiguration o && Equals(o);
        }
    }
}
