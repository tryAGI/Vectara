#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A session event visible to the end user who owns the session.
    /// </summary>
    public readonly partial struct EndUserEvent : global::System.IEquatable<EndUserEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.EndUserEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Always visible. An input message from the end user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.EndUserInputMessageEvent? InputMessage { get; init; }
#else
        public global::Vectara.EndUserInputMessageEvent? InputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.EndUserInputMessageEvent? value)
        {
            value = InputMessage;
            return IsInputMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.EndUserInputMessageEvent PickInputMessage() => IsInputMessage
            ? InputMessage!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputMessage' but the value was {ToString()}.");

        /// <summary>
        /// Always visible. A complete agent response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.EndUserAgentOutputEvent? AgentOutput { get; init; }
#else
        public global::Vectara.EndUserAgentOutputEvent? AgentOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentOutput))]
#endif
        public bool IsAgentOutput => AgentOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.EndUserAgentOutputEvent? value)
        {
            value = AgentOutput;
            return IsAgentOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.EndUserAgentOutputEvent PickAgentOutput() => IsAgentOutput
            ? AgentOutput!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentOutput' but the value was {ToString()}.");

        /// <summary>
        /// Always visible. A turn-ending event emitted when the turn fails. `message` is a generic failure string and does not identify the<br/>
        /// underlying cause.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.EndUserErrorEvent? Error { get; init; }
#else
        public global::Vectara.EndUserErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.EndUserErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.EndUserErrorEvent PickError() => IsError
            ? Error!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndUserEvent(global::Vectara.EndUserInputMessageEvent value) => new EndUserEvent((global::Vectara.EndUserInputMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.EndUserInputMessageEvent?(EndUserEvent @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public EndUserEvent(global::Vectara.EndUserInputMessageEvent? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EndUserEvent FromInputMessage(global::Vectara.EndUserInputMessageEvent? value) => new EndUserEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndUserEvent(global::Vectara.EndUserAgentOutputEvent value) => new EndUserEvent((global::Vectara.EndUserAgentOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.EndUserAgentOutputEvent?(EndUserEvent @this) => @this.AgentOutput;

        /// <summary>
        /// 
        /// </summary>
        public EndUserEvent(global::Vectara.EndUserAgentOutputEvent? value)
        {
            AgentOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EndUserEvent FromAgentOutput(global::Vectara.EndUserAgentOutputEvent? value) => new EndUserEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndUserEvent(global::Vectara.EndUserErrorEvent value) => new EndUserEvent((global::Vectara.EndUserErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.EndUserErrorEvent?(EndUserEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public EndUserEvent(global::Vectara.EndUserErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EndUserEvent FromError(global::Vectara.EndUserErrorEvent? value) => new EndUserEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public EndUserEvent(
            global::Vectara.EndUserEventDiscriminatorType? type,
            global::Vectara.EndUserInputMessageEvent? inputMessage,
            global::Vectara.EndUserAgentOutputEvent? agentOutput,
            global::Vectara.EndUserErrorEvent? error
            )
        {
            Type = type;

            InputMessage = inputMessage;
            AgentOutput = agentOutput;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            AgentOutput as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            AgentOutput?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsAgentOutput && !IsError || !IsInputMessage && IsAgentOutput && !IsError || !IsInputMessage && !IsAgentOutput && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.EndUserInputMessageEvent?, TResult>? inputMessage = null,
            global::System.Func<global::Vectara.EndUserAgentOutputEvent?, TResult>? agentOutput = null,
            global::System.Func<global::Vectara.EndUserErrorEvent?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage && inputMessage != null)
            {
                return inputMessage(InputMessage!);
            }
            else if (IsAgentOutput && agentOutput != null)
            {
                return agentOutput(AgentOutput!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.EndUserInputMessageEvent?>? inputMessage = null,

            global::System.Action<global::Vectara.EndUserAgentOutputEvent?>? agentOutput = null,

            global::System.Action<global::Vectara.EndUserErrorEvent?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsAgentOutput)
            {
                agentOutput?.Invoke(AgentOutput!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.EndUserInputMessageEvent?>? inputMessage = null,
            global::System.Action<global::Vectara.EndUserAgentOutputEvent?>? agentOutput = null,
            global::System.Action<global::Vectara.EndUserErrorEvent?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsAgentOutput)
            {
                agentOutput?.Invoke(AgentOutput!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessage,
                typeof(global::Vectara.EndUserInputMessageEvent),
                AgentOutput,
                typeof(global::Vectara.EndUserAgentOutputEvent),
                Error,
                typeof(global::Vectara.EndUserErrorEvent),
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
        public bool Equals(EndUserEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserInputMessageEvent?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserAgentOutputEvent?>.Default.Equals(AgentOutput, other.AgentOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserErrorEvent?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EndUserEvent obj1, EndUserEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EndUserEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EndUserEvent obj1, EndUserEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EndUserEvent o && Equals(o);
        }
    }
}
