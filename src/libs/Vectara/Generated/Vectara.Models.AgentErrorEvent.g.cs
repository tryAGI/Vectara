#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A turn-ending event emitted when the turn failed because of an unexpected error — for example a<br/>
    /// model configuration problem, a blocked LLM endpoint, or an internal failure. It is a `StreamError`<br/>
    /// carrying the same `messages`, plus the event id, session key, and timestamp. It is streamed as the<br/>
    /// `error` frame. When the failure happens while the agent is running, it is also recorded on the session,<br/>
    /// so the reason the agent stopped stays visible when inspecting the session later. The next input<br/>
    /// starts the agent again.
    /// </summary>
    public readonly partial struct AgentErrorEvent : global::System.IEquatable<AgentErrorEvent>
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
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.AgentEventBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentEventBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// Event signaling there was an error with the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamError? Stream { get; init; }
#else
        public global::Vectara.StreamError? Stream { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stream))]
#endif
        public bool IsStream => Stream != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStream(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StreamError? value)
        {
            value = Stream;
            return IsStream;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.StreamError PickStream() => IsStream
            ? Stream!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stream' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentErrorEvent(global::Vectara.AgentEventBase value) => new AgentErrorEvent((global::Vectara.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentEventBase?(AgentErrorEvent @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public AgentErrorEvent(global::Vectara.AgentEventBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentErrorEvent FromBase(global::Vectara.AgentEventBase? value) => new AgentErrorEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentErrorEvent(global::Vectara.StreamError value) => new AgentErrorEvent((global::Vectara.StreamError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamError?(AgentErrorEvent @this) => @this.Stream;

        /// <summary>
        /// 
        /// </summary>
        public AgentErrorEvent(global::Vectara.StreamError? value)
        {
            Stream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentErrorEvent FromStream(global::Vectara.StreamError? value) => new AgentErrorEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public AgentErrorEvent(
            global::Vectara.AgentEventBase? @base,
            global::Vectara.StreamError? stream
            )
        {
            Base = @base;
            Stream = stream;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Stream as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            Stream?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsStream;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentEventBase, TResult>? @base = null,
            global::System.Func<global::Vectara.StreamError, TResult>? stream = null,
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
            else if (IsStream && stream != null)
            {
                return stream(Stream!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentEventBase>? @base = null,

            global::System.Action<global::Vectara.StreamError>? stream = null,
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
            else if (IsStream)
            {
                stream?.Invoke(Stream!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentEventBase>? @base = null,
            global::System.Action<global::Vectara.StreamError>? stream = null,
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
            else if (IsStream)
            {
                stream?.Invoke(Stream!);
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
                Stream,
                typeof(global::Vectara.StreamError),
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
        public bool Equals(AgentErrorEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentEventBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamError?>.Default.Equals(Stream, other.Stream) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentErrorEvent obj1, AgentErrorEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentErrorEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentErrorEvent obj1, AgentErrorEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentErrorEvent o && Equals(o);
        }
    }
}
