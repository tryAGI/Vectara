#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An event representing a complete agent response.
    /// </summary>
    public readonly partial struct AgentOutputEvent : global::System.IEquatable<AgentOutputEvent>
    {
        /// <summary>
        /// Base properties shared by all agent event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentEventBase? Base { get; init; }
#else
        public global::Vectara.AgentEventBase? Base { get; }
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
#if NET6_0_OR_GREATER
        public global::Vectara.AgentOutputEventVariant2? AgentOutputEventVariant2 { get; init; }
#else
        public global::Vectara.AgentOutputEventVariant2? AgentOutputEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentOutputEventVariant2))]
#endif
        public bool IsAgentOutputEventVariant2 => AgentOutputEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentOutputEvent(global::Vectara.AgentEventBase value) => new AgentOutputEvent((global::Vectara.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentEventBase?(AgentOutputEvent @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public AgentOutputEvent(global::Vectara.AgentEventBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentOutputEvent(global::Vectara.AgentOutputEventVariant2 value) => new AgentOutputEvent((global::Vectara.AgentOutputEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentOutputEventVariant2?(AgentOutputEvent @this) => @this.AgentOutputEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AgentOutputEvent(global::Vectara.AgentOutputEventVariant2? value)
        {
            AgentOutputEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentOutputEvent(
            global::Vectara.AgentEventBase? @base,
            global::Vectara.AgentOutputEventVariant2? agentOutputEventVariant2
            )
        {
            Base = @base;
            AgentOutputEventVariant2 = agentOutputEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentOutputEventVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AgentOutputEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAgentOutputEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentEventBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.AgentOutputEventVariant2?, TResult>? agentOutputEventVariant2 = null,
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
            else if (IsAgentOutputEventVariant2 && agentOutputEventVariant2 != null)
            {
                return agentOutputEventVariant2(AgentOutputEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentEventBase?>? @base = null,
            global::System.Action<global::Vectara.AgentOutputEventVariant2?>? agentOutputEventVariant2 = null,
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
            else if (IsAgentOutputEventVariant2)
            {
                agentOutputEventVariant2?.Invoke(AgentOutputEventVariant2!);
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
                typeof(global::Vectara.AgentEventBase),
                AgentOutputEventVariant2,
                typeof(global::Vectara.AgentOutputEventVariant2),
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
        public bool Equals(AgentOutputEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentEventBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentOutputEventVariant2?>.Default.Equals(AgentOutputEventVariant2, other.AgentOutputEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentOutputEvent obj1, AgentOutputEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentOutputEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentOutputEvent obj1, AgentOutputEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentOutputEvent o && Equals(o);
        }
    }
}
