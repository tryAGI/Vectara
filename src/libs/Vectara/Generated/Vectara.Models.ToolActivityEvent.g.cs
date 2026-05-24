#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A sideband event emitted by a tool during its execution (streaming only, not stored). Always falls between the tool's tool_input and tool_output events for the same tool_call_id. Polymorphic on `activity_type` — see GenericToolActivityEvent (free-form text) and SubAgentToolActivityEvent (relayed inner AgentEvent).
    /// </summary>
    public readonly partial struct ToolActivityEvent : global::System.IEquatable<ToolActivityEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ToolActivityEventDiscriminatorActivityType? ActivityType { get; }

        /// <summary>
        /// A free-form progress update from a tool. The only payload is a human-readable message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GenericToolActivityEvent? Generic { get; init; }
#else
        public global::Vectara.GenericToolActivityEvent? Generic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Generic))]
#endif
        public bool IsGeneric => Generic != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGeneric(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GenericToolActivityEvent? value)
        {
            value = Generic;
            return IsGeneric;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GenericToolActivityEvent PickGeneric() => IsGeneric
            ? Generic!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Generic' but the value was {ToString()}.");

        /// <summary>
        /// A relayed event from a sub-agent's inner execution stream, emitted by the sub_agent tool while it runs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SubAgentToolActivityEvent? SubAgent { get; init; }
#else
        public global::Vectara.SubAgentToolActivityEvent? SubAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubAgent))]
#endif
        public bool IsSubAgent => SubAgent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SubAgentToolActivityEvent? value)
        {
            value = SubAgent;
            return IsSubAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SubAgentToolActivityEvent PickSubAgent() => IsSubAgent
            ? SubAgent!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubAgent' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolActivityEvent(global::Vectara.GenericToolActivityEvent value) => new ToolActivityEvent((global::Vectara.GenericToolActivityEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GenericToolActivityEvent?(ToolActivityEvent @this) => @this.Generic;

        /// <summary>
        /// 
        /// </summary>
        public ToolActivityEvent(global::Vectara.GenericToolActivityEvent? value)
        {
            Generic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolActivityEvent FromGeneric(global::Vectara.GenericToolActivityEvent? value) => new ToolActivityEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolActivityEvent(global::Vectara.SubAgentToolActivityEvent value) => new ToolActivityEvent((global::Vectara.SubAgentToolActivityEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SubAgentToolActivityEvent?(ToolActivityEvent @this) => @this.SubAgent;

        /// <summary>
        /// 
        /// </summary>
        public ToolActivityEvent(global::Vectara.SubAgentToolActivityEvent? value)
        {
            SubAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolActivityEvent FromSubAgent(global::Vectara.SubAgentToolActivityEvent? value) => new ToolActivityEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ToolActivityEvent(
            global::Vectara.ToolActivityEventDiscriminatorActivityType? activityType,
            global::Vectara.GenericToolActivityEvent? generic,
            global::Vectara.SubAgentToolActivityEvent? subAgent
            )
        {
            ActivityType = activityType;

            Generic = generic;
            SubAgent = subAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SubAgent as object ??
            Generic as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Generic?.ToString() ??
            SubAgent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGeneric && !IsSubAgent || !IsGeneric && IsSubAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.GenericToolActivityEvent?, TResult>? generic = null,
            global::System.Func<global::Vectara.SubAgentToolActivityEvent?, TResult>? subAgent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGeneric && generic != null)
            {
                return generic(Generic!);
            }
            else if (IsSubAgent && subAgent != null)
            {
                return subAgent(SubAgent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.GenericToolActivityEvent?>? generic = null,

            global::System.Action<global::Vectara.SubAgentToolActivityEvent?>? subAgent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGeneric)
            {
                generic?.Invoke(Generic!);
            }
            else if (IsSubAgent)
            {
                subAgent?.Invoke(SubAgent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.GenericToolActivityEvent?>? generic = null,
            global::System.Action<global::Vectara.SubAgentToolActivityEvent?>? subAgent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGeneric)
            {
                generic?.Invoke(Generic!);
            }
            else if (IsSubAgent)
            {
                subAgent?.Invoke(SubAgent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Generic,
                typeof(global::Vectara.GenericToolActivityEvent),
                SubAgent,
                typeof(global::Vectara.SubAgentToolActivityEvent),
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
        public bool Equals(ToolActivityEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GenericToolActivityEvent?>.Default.Equals(Generic, other.Generic) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SubAgentToolActivityEvent?>.Default.Equals(SubAgent, other.SubAgent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolActivityEvent obj1, ToolActivityEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolActivityEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolActivityEvent obj1, ToolActivityEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolActivityEvent o && Equals(o);
        }
    }
}
