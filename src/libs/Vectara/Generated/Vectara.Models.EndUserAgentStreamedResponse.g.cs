#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An individual frame on the end-user live SSE stream. Frames include every `EndUserEvent` variant, plus two transient chunk types<br/>
    /// that are not persisted: `streaming_agent_output` and `streaming_agent_output_end`. These chunk types let a client render the<br/>
    /// agent's reply incrementally instead of waiting for the complete `agent_output` event.
    /// </summary>
    public readonly partial struct EndUserAgentStreamedResponse : global::System.IEquatable<EndUserAgentStreamedResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.EndUserAgentStreamedResponseDiscriminatorType? Type { get; }

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
        /// A streaming chunk of agent output (SSE only, not stored).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamingAgentOutput? StreamingAgentOutput { get; init; }
#else
        public global::Vectara.StreamingAgentOutput? StreamingAgentOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingAgentOutput))]
#endif
        public bool IsStreamingAgentOutput => StreamingAgentOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStreamingAgentOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StreamingAgentOutput? value)
        {
            value = StreamingAgentOutput;
            return IsStreamingAgentOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.StreamingAgentOutput PickStreamingAgentOutput() => IsStreamingAgentOutput
            ? StreamingAgentOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamingAgentOutput' but the value was {ToString()}.");

        /// <summary>
        /// Signals the end of streaming agent output (SSE only, not stored).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamingAgentOutputEnd? StreamingAgentOutputEnd { get; init; }
#else
        public global::Vectara.StreamingAgentOutputEnd? StreamingAgentOutputEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingAgentOutputEnd))]
#endif
        public bool IsStreamingAgentOutputEnd => StreamingAgentOutputEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStreamingAgentOutputEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StreamingAgentOutputEnd? value)
        {
            value = StreamingAgentOutputEnd;
            return IsStreamingAgentOutputEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.StreamingAgentOutputEnd PickStreamingAgentOutputEnd() => IsStreamingAgentOutputEnd
            ? StreamingAgentOutputEnd!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamingAgentOutputEnd' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.EndUserInputMessageEvent value) => new EndUserAgentStreamedResponse((global::Vectara.EndUserInputMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.EndUserInputMessageEvent?(EndUserAgentStreamedResponse @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.EndUserInputMessageEvent? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EndUserAgentStreamedResponse FromInputMessage(global::Vectara.EndUserInputMessageEvent? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.EndUserAgentOutputEvent value) => new EndUserAgentStreamedResponse((global::Vectara.EndUserAgentOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.EndUserAgentOutputEvent?(EndUserAgentStreamedResponse @this) => @this.AgentOutput;

        /// <summary>
        /// 
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.EndUserAgentOutputEvent? value)
        {
            AgentOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EndUserAgentStreamedResponse FromAgentOutput(global::Vectara.EndUserAgentOutputEvent? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.EndUserErrorEvent value) => new EndUserAgentStreamedResponse((global::Vectara.EndUserErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.EndUserErrorEvent?(EndUserAgentStreamedResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.EndUserErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EndUserAgentStreamedResponse FromError(global::Vectara.EndUserErrorEvent? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.StreamingAgentOutput value) => new EndUserAgentStreamedResponse((global::Vectara.StreamingAgentOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamingAgentOutput?(EndUserAgentStreamedResponse @this) => @this.StreamingAgentOutput;

        /// <summary>
        /// 
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.StreamingAgentOutput? value)
        {
            StreamingAgentOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EndUserAgentStreamedResponse FromStreamingAgentOutput(global::Vectara.StreamingAgentOutput? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.StreamingAgentOutputEnd value) => new EndUserAgentStreamedResponse((global::Vectara.StreamingAgentOutputEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamingAgentOutputEnd?(EndUserAgentStreamedResponse @this) => @this.StreamingAgentOutputEnd;

        /// <summary>
        /// 
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.StreamingAgentOutputEnd? value)
        {
            StreamingAgentOutputEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EndUserAgentStreamedResponse FromStreamingAgentOutputEnd(global::Vectara.StreamingAgentOutputEnd? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public EndUserAgentStreamedResponse(
            global::Vectara.EndUserAgentStreamedResponseDiscriminatorType? type,
            global::Vectara.EndUserInputMessageEvent? inputMessage,
            global::Vectara.EndUserAgentOutputEvent? agentOutput,
            global::Vectara.EndUserErrorEvent? error,
            global::Vectara.StreamingAgentOutput? streamingAgentOutput,
            global::Vectara.StreamingAgentOutputEnd? streamingAgentOutputEnd
            )
        {
            Type = type;

            InputMessage = inputMessage;
            AgentOutput = agentOutput;
            Error = error;
            StreamingAgentOutput = streamingAgentOutput;
            StreamingAgentOutputEnd = streamingAgentOutputEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamingAgentOutputEnd as object ??
            StreamingAgentOutput as object ??
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
            Error?.ToString() ??
            StreamingAgentOutput?.ToString() ??
            StreamingAgentOutputEnd?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsAgentOutput && !IsError && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd || !IsInputMessage && IsAgentOutput && !IsError && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd || !IsInputMessage && !IsAgentOutput && IsError && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd || !IsInputMessage && !IsAgentOutput && !IsError && IsStreamingAgentOutput && !IsStreamingAgentOutputEnd || !IsInputMessage && !IsAgentOutput && !IsError && !IsStreamingAgentOutput && IsStreamingAgentOutputEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.EndUserInputMessageEvent?, TResult>? inputMessage = null,
            global::System.Func<global::Vectara.EndUserAgentOutputEvent?, TResult>? agentOutput = null,
            global::System.Func<global::Vectara.EndUserErrorEvent?, TResult>? error = null,
            global::System.Func<global::Vectara.StreamingAgentOutput, TResult>? streamingAgentOutput = null,
            global::System.Func<global::Vectara.StreamingAgentOutputEnd, TResult>? streamingAgentOutputEnd = null,
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
            else if (IsStreamingAgentOutput && streamingAgentOutput != null)
            {
                return streamingAgentOutput(StreamingAgentOutput!);
            }
            else if (IsStreamingAgentOutputEnd && streamingAgentOutputEnd != null)
            {
                return streamingAgentOutputEnd(StreamingAgentOutputEnd!);
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

            global::System.Action<global::Vectara.StreamingAgentOutput>? streamingAgentOutput = null,

            global::System.Action<global::Vectara.StreamingAgentOutputEnd>? streamingAgentOutputEnd = null,
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
            else if (IsStreamingAgentOutput)
            {
                streamingAgentOutput?.Invoke(StreamingAgentOutput!);
            }
            else if (IsStreamingAgentOutputEnd)
            {
                streamingAgentOutputEnd?.Invoke(StreamingAgentOutputEnd!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.EndUserInputMessageEvent?>? inputMessage = null,
            global::System.Action<global::Vectara.EndUserAgentOutputEvent?>? agentOutput = null,
            global::System.Action<global::Vectara.EndUserErrorEvent?>? error = null,
            global::System.Action<global::Vectara.StreamingAgentOutput>? streamingAgentOutput = null,
            global::System.Action<global::Vectara.StreamingAgentOutputEnd>? streamingAgentOutputEnd = null,
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
            else if (IsStreamingAgentOutput)
            {
                streamingAgentOutput?.Invoke(StreamingAgentOutput!);
            }
            else if (IsStreamingAgentOutputEnd)
            {
                streamingAgentOutputEnd?.Invoke(StreamingAgentOutputEnd!);
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
                StreamingAgentOutput,
                typeof(global::Vectara.StreamingAgentOutput),
                StreamingAgentOutputEnd,
                typeof(global::Vectara.StreamingAgentOutputEnd),
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
        public bool Equals(EndUserAgentStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserInputMessageEvent?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserAgentOutputEvent?>.Default.Equals(AgentOutput, other.AgentOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamingAgentOutput?>.Default.Equals(StreamingAgentOutput, other.StreamingAgentOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamingAgentOutputEnd?>.Default.Equals(StreamingAgentOutputEnd, other.StreamingAgentOutputEnd) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EndUserAgentStreamedResponse obj1, EndUserAgentStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EndUserAgentStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EndUserAgentStreamedResponse obj1, EndUserAgentStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EndUserAgentStreamedResponse o && Equals(o);
        }
    }
}
