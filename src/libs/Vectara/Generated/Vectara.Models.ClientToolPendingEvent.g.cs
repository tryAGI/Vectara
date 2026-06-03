#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Signals that the agent is waiting for the client to deliver outputs for the listed client tool<br/>
    /// calls before it continues. Not persisted to session history. Resume by submitting a `tool_output`<br/>
    /// input containing one entry per `event_id` in `pending_calls`.<br/>
    /// Only client tools awaiting output are listed. Each call carries its fully materialized arguments —<br/>
    /// the agent-supplied arguments already merged with the tool configuration's argument overrides and<br/>
    /// literals, with `$ref`s resolved against the session — so the client can dispatch the call without<br/>
    /// cross-referencing the corresponding `tool_input` event. Secret-derived values are delivered unmasked<br/>
    /// because the client needs them to execute the tool.
    /// </summary>
    public readonly partial struct ClientToolPendingEvent : global::System.IEquatable<ClientToolPendingEvent>
    {
        /// <summary>
        /// Base properties shared by all agent event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentEventBase? AgentBase { get; init; }
#else
        public global::Vectara.AgentEventBase? AgentBase { get; }
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
            out global::Vectara.AgentEventBase? value)
        {
            value = AgentBase;
            return IsAgentBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentEventBase PickAgentBase() => IsAgentBase
            ? AgentBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentBase' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ClientToolPendingEventVariant2? ClientToolPendingEventVariant2 { get; init; }
#else
        public global::Vectara.ClientToolPendingEventVariant2? ClientToolPendingEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolPendingEventVariant2))]
#endif
        public bool IsClientToolPendingEventVariant2 => ClientToolPendingEventVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickClientToolPendingEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ClientToolPendingEventVariant2? value)
        {
            value = ClientToolPendingEventVariant2;
            return IsClientToolPendingEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ClientToolPendingEventVariant2 PickClientToolPendingEventVariant2() => IsClientToolPendingEventVariant2
            ? ClientToolPendingEventVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientToolPendingEventVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClientToolPendingEvent(global::Vectara.AgentEventBase value) => new ClientToolPendingEvent((global::Vectara.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentEventBase?(ClientToolPendingEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ClientToolPendingEvent(global::Vectara.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ClientToolPendingEvent FromAgentBase(global::Vectara.AgentEventBase? value) => new ClientToolPendingEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClientToolPendingEvent(global::Vectara.ClientToolPendingEventVariant2 value) => new ClientToolPendingEvent((global::Vectara.ClientToolPendingEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ClientToolPendingEventVariant2?(ClientToolPendingEvent @this) => @this.ClientToolPendingEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ClientToolPendingEvent(global::Vectara.ClientToolPendingEventVariant2? value)
        {
            ClientToolPendingEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ClientToolPendingEvent FromClientToolPendingEventVariant2(global::Vectara.ClientToolPendingEventVariant2? value) => new ClientToolPendingEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ClientToolPendingEvent(
            global::Vectara.AgentEventBase? agentBase,
            global::Vectara.ClientToolPendingEventVariant2? clientToolPendingEventVariant2
            )
        {
            AgentBase = agentBase;
            ClientToolPendingEventVariant2 = clientToolPendingEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClientToolPendingEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ClientToolPendingEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsClientToolPendingEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentEventBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.ClientToolPendingEventVariant2, TResult>? clientToolPendingEventVariant2 = null,
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
            else if (IsClientToolPendingEventVariant2 && clientToolPendingEventVariant2 != null)
            {
                return clientToolPendingEventVariant2(ClientToolPendingEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentEventBase>? agentBase = null,

            global::System.Action<global::Vectara.ClientToolPendingEventVariant2>? clientToolPendingEventVariant2 = null,
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
            else if (IsClientToolPendingEventVariant2)
            {
                clientToolPendingEventVariant2?.Invoke(ClientToolPendingEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentEventBase>? agentBase = null,
            global::System.Action<global::Vectara.ClientToolPendingEventVariant2>? clientToolPendingEventVariant2 = null,
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
            else if (IsClientToolPendingEventVariant2)
            {
                clientToolPendingEventVariant2?.Invoke(ClientToolPendingEventVariant2!);
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
                typeof(global::Vectara.AgentEventBase),
                ClientToolPendingEventVariant2,
                typeof(global::Vectara.ClientToolPendingEventVariant2),
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
        public bool Equals(ClientToolPendingEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ClientToolPendingEventVariant2?>.Default.Equals(ClientToolPendingEventVariant2, other.ClientToolPendingEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ClientToolPendingEvent obj1, ClientToolPendingEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ClientToolPendingEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ClientToolPendingEvent obj1, ClientToolPendingEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ClientToolPendingEvent o && Equals(o);
        }
    }
}
