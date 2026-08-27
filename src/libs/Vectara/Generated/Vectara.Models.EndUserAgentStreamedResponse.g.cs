#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An individual frame on the end-user live SSE stream.<br/>
    /// Frames include every `EndUserEvent` variant, plus transient chunk types that are not persisted: `streaming_agent_output` and `streaming_agent_output_end`.<br/>
    /// These chunk types let a client render the agent's reply incrementally instead of waiting for the complete `agent_output` event.<br/>
    /// When the widget connector reveals the matching output category, the stream also carries `streaming_thinking` and `streaming_thinking_end` chunks and `tool_activity` frames.<br/>
    /// Every stream terminates with a single `end` frame.
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
        /// An event representing input to a tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ToolInputEvent? ToolInput { get; init; }
#else
        public global::Vectara.ToolInputEvent? ToolInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolInput))]
#endif
        public bool IsToolInput => ToolInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ToolInputEvent? value)
        {
            value = ToolInput;
            return IsToolInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolInputEvent PickToolInput() => IsToolInput
            ? ToolInput!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolInput' but the value was {ToString()}.");

        /// <summary>
        /// An event representing output from a tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ToolOutputEvent? ToolOutput { get; init; }
#else
        public global::Vectara.ToolOutputEvent? ToolOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolOutput))]
#endif
        public bool IsToolOutput => ToolOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ToolOutputEvent? value)
        {
            value = ToolOutput;
            return IsToolOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputEvent PickToolOutput() => IsToolOutput
            ? ToolOutput!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolOutput' but the value was {ToString()}.");

        /// <summary>
        /// An event representing chain-of-thought thinking by the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ThinkingEvent? Thinking { get; init; }
#else
        public global::Vectara.ThinkingEvent? Thinking { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ThinkingEvent? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingEvent PickThinking() => IsThinking
            ? Thinking!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thinking' but the value was {ToString()}.");

        /// <summary>
        /// An event representing a complete agent response with structured JSON content conforming to a schema.<br/>
        /// The agent emits this event instead of AgentOutputEvent when its output_parser type is<br/>
        /// "structured". It contains the agent's final response parsed as validated JSON that<br/>
        /// conforms to the schema specified in the StructuredOutputParser configuration.<br/>
        /// When streaming is enabled, this event appears as a single complete event (not streamed in chunks)<br/>
        /// after any tool interactions are complete. The content field contains the parsed JSON,<br/>
        /// and schema_name identifies which schema the content was validated against.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StructuredOutputEvent? StructuredOutput { get; init; }
#else
        public global::Vectara.StructuredOutputEvent? StructuredOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StructuredOutput))]
#endif
        public bool IsStructuredOutput => StructuredOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStructuredOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StructuredOutputEvent? value)
        {
            value = StructuredOutput;
            return IsStructuredOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredOutputEvent PickStructuredOutput() => IsStructuredOutput
            ? StructuredOutput!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StructuredOutput' but the value was {ToString()}.");

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
        /// A streaming chunk of agent thinking (SSE only, not stored).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamingThinking? StreamingThinking { get; init; }
#else
        public global::Vectara.StreamingThinking? StreamingThinking { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingThinking))]
#endif
        public bool IsStreamingThinking => StreamingThinking != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamingThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StreamingThinking? value)
        {
            value = StreamingThinking;
            return IsStreamingThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingThinking PickStreamingThinking() => IsStreamingThinking
            ? StreamingThinking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamingThinking' but the value was {ToString()}.");

        /// <summary>
        /// Signals the end of streaming thinking (SSE only, not stored).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamingThinkingEnd? StreamingThinkingEnd { get; init; }
#else
        public global::Vectara.StreamingThinkingEnd? StreamingThinkingEnd { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingThinkingEnd))]
#endif
        public bool IsStreamingThinkingEnd => StreamingThinkingEnd != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamingThinkingEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StreamingThinkingEnd? value)
        {
            value = StreamingThinkingEnd;
            return IsStreamingThinkingEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingThinkingEnd PickStreamingThinkingEnd() => IsStreamingThinkingEnd
            ? StreamingThinkingEnd!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamingThinkingEnd' but the value was {ToString()}.");

        /// <summary>
        /// A sideband event emitted by a tool during its execution (streaming only, not stored). Always falls between the tool's tool_input and tool_output events for the same tool_call_id. Polymorphic on `activity_type` — see GenericToolActivityEvent (free-form text) and SubAgentToolActivityEvent (relayed inner AgentEvent).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ToolActivityEvent? ToolActivity { get; init; }
#else
        public global::Vectara.ToolActivityEvent? ToolActivity { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolActivity))]
#endif
        public bool IsToolActivity => ToolActivity != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolActivity(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ToolActivityEvent? value)
        {
            value = ToolActivity;
            return IsToolActivity;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEvent PickToolActivity() => IsToolActivity
            ? ToolActivity!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolActivity' but the value was {ToString()}.");

        /// <summary>
        /// The end of a query response stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamResponseEnd? End { get; init; }
#else
        public global::Vectara.StreamResponseEnd? End { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(End))]
#endif
        public bool IsEnd => End != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StreamResponseEnd? value)
        {
            value = End;
            return IsEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamResponseEnd PickEnd() => IsEnd
            ? End!
            : throw new global::System.InvalidOperationException($"Expected union variant 'End' but the value was {ToString()}.");
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
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.ToolInputEvent value) => new EndUserAgentStreamedResponse((global::Vectara.ToolInputEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ToolInputEvent?(EndUserAgentStreamedResponse @this) => @this.ToolInput;

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.ToolInputEvent? value)
        {
            ToolInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserAgentStreamedResponse FromToolInput(global::Vectara.ToolInputEvent? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.ToolOutputEvent value) => new EndUserAgentStreamedResponse((global::Vectara.ToolOutputEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ToolOutputEvent?(EndUserAgentStreamedResponse @this) => @this.ToolOutput;

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.ToolOutputEvent? value)
        {
            ToolOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserAgentStreamedResponse FromToolOutput(global::Vectara.ToolOutputEvent? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.ThinkingEvent value) => new EndUserAgentStreamedResponse((global::Vectara.ThinkingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ThinkingEvent?(EndUserAgentStreamedResponse @this) => @this.Thinking;

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.ThinkingEvent? value)
        {
            Thinking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserAgentStreamedResponse FromThinking(global::Vectara.ThinkingEvent? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.StructuredOutputEvent value) => new EndUserAgentStreamedResponse((global::Vectara.StructuredOutputEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StructuredOutputEvent?(EndUserAgentStreamedResponse @this) => @this.StructuredOutput;

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.StructuredOutputEvent? value)
        {
            StructuredOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserAgentStreamedResponse FromStructuredOutput(global::Vectara.StructuredOutputEvent? value) => new EndUserAgentStreamedResponse(value);

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
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.StreamingThinking value) => new EndUserAgentStreamedResponse((global::Vectara.StreamingThinking?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StreamingThinking?(EndUserAgentStreamedResponse @this) => @this.StreamingThinking;

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.StreamingThinking? value)
        {
            StreamingThinking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserAgentStreamedResponse FromStreamingThinking(global::Vectara.StreamingThinking? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.StreamingThinkingEnd value) => new EndUserAgentStreamedResponse((global::Vectara.StreamingThinkingEnd?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StreamingThinkingEnd?(EndUserAgentStreamedResponse @this) => @this.StreamingThinkingEnd;

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.StreamingThinkingEnd? value)
        {
            StreamingThinkingEnd = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserAgentStreamedResponse FromStreamingThinkingEnd(global::Vectara.StreamingThinkingEnd? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.ToolActivityEvent value) => new EndUserAgentStreamedResponse((global::Vectara.ToolActivityEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ToolActivityEvent?(EndUserAgentStreamedResponse @this) => @this.ToolActivity;

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.ToolActivityEvent? value)
        {
            ToolActivity = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserAgentStreamedResponse FromToolActivity(global::Vectara.ToolActivityEvent? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserAgentStreamedResponse(global::Vectara.StreamResponseEnd value) => new EndUserAgentStreamedResponse((global::Vectara.StreamResponseEnd?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StreamResponseEnd?(EndUserAgentStreamedResponse @this) => @this.End;

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentStreamedResponse(global::Vectara.StreamResponseEnd? value)
        {
            End = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserAgentStreamedResponse FromEnd(global::Vectara.StreamResponseEnd? value) => new EndUserAgentStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentStreamedResponse(
            global::Vectara.EndUserAgentStreamedResponseDiscriminatorType? type,
            global::Vectara.EndUserInputMessageEvent? inputMessage,
            global::Vectara.EndUserAgentOutputEvent? agentOutput,
            global::Vectara.EndUserErrorEvent? error,
            global::Vectara.ToolInputEvent? toolInput,
            global::Vectara.ToolOutputEvent? toolOutput,
            global::Vectara.ThinkingEvent? thinking,
            global::Vectara.StructuredOutputEvent? structuredOutput,
            global::Vectara.StreamingAgentOutput? streamingAgentOutput,
            global::Vectara.StreamingAgentOutputEnd? streamingAgentOutputEnd,
            global::Vectara.StreamingThinking? streamingThinking,
            global::Vectara.StreamingThinkingEnd? streamingThinkingEnd,
            global::Vectara.ToolActivityEvent? toolActivity,
            global::Vectara.StreamResponseEnd? end
            )
        {
            Type = type;

            InputMessage = inputMessage;
            AgentOutput = agentOutput;
            Error = error;
            ToolInput = toolInput;
            ToolOutput = toolOutput;
            Thinking = thinking;
            StructuredOutput = structuredOutput;
            StreamingAgentOutput = streamingAgentOutput;
            StreamingAgentOutputEnd = streamingAgentOutputEnd;
            StreamingThinking = streamingThinking;
            StreamingThinkingEnd = streamingThinkingEnd;
            ToolActivity = toolActivity;
            End = end;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            End as object ??
            ToolActivity as object ??
            StreamingThinkingEnd as object ??
            StreamingThinking as object ??
            StreamingAgentOutputEnd as object ??
            StreamingAgentOutput as object ??
            StructuredOutput as object ??
            Thinking as object ??
            ToolOutput as object ??
            ToolInput as object ??
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
            ToolInput?.ToString() ??
            ToolOutput?.ToString() ??
            Thinking?.ToString() ??
            StructuredOutput?.ToString() ??
            StreamingAgentOutput?.ToString() ??
            StreamingAgentOutputEnd?.ToString() ??
            StreamingThinking?.ToString() ??
            StreamingThinkingEnd?.ToString() ??
            ToolActivity?.ToString() ??
            End?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && !IsError && IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && IsToolOutput && !IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput && IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && IsStreamingThinkingEnd && !IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && IsToolActivity && !IsEnd || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolActivity && IsEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.EndUserInputMessageEvent?, TResult>? inputMessage = null,
            global::System.Func<global::Vectara.EndUserAgentOutputEvent?, TResult>? agentOutput = null,
            global::System.Func<global::Vectara.EndUserErrorEvent?, TResult>? error = null,
            global::System.Func<global::Vectara.ToolInputEvent?, TResult>? toolInput = null,
            global::System.Func<global::Vectara.ToolOutputEvent?, TResult>? toolOutput = null,
            global::System.Func<global::Vectara.ThinkingEvent?, TResult>? thinking = null,
            global::System.Func<global::Vectara.StructuredOutputEvent?, TResult>? structuredOutput = null,
            global::System.Func<global::Vectara.StreamingAgentOutput, TResult>? streamingAgentOutput = null,
            global::System.Func<global::Vectara.StreamingAgentOutputEnd, TResult>? streamingAgentOutputEnd = null,
            global::System.Func<global::Vectara.StreamingThinking, TResult>? streamingThinking = null,
            global::System.Func<global::Vectara.StreamingThinkingEnd, TResult>? streamingThinkingEnd = null,
            global::System.Func<global::Vectara.ToolActivityEvent?, TResult>? toolActivity = null,
            global::System.Func<global::Vectara.StreamResponseEnd, TResult>? end = null,
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
            else if (IsToolInput && toolInput != null)
            {
                return toolInput(ToolInput!);
            }
            else if (IsToolOutput && toolOutput != null)
            {
                return toolOutput(ToolOutput!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsStructuredOutput && structuredOutput != null)
            {
                return structuredOutput(StructuredOutput!);
            }
            else if (IsStreamingAgentOutput && streamingAgentOutput != null)
            {
                return streamingAgentOutput(StreamingAgentOutput!);
            }
            else if (IsStreamingAgentOutputEnd && streamingAgentOutputEnd != null)
            {
                return streamingAgentOutputEnd(StreamingAgentOutputEnd!);
            }
            else if (IsStreamingThinking && streamingThinking != null)
            {
                return streamingThinking(StreamingThinking!);
            }
            else if (IsStreamingThinkingEnd && streamingThinkingEnd != null)
            {
                return streamingThinkingEnd(StreamingThinkingEnd!);
            }
            else if (IsToolActivity && toolActivity != null)
            {
                return toolActivity(ToolActivity!);
            }
            else if (IsEnd && end != null)
            {
                return end(End!);
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

            global::System.Action<global::Vectara.ToolInputEvent?>? toolInput = null,

            global::System.Action<global::Vectara.ToolOutputEvent?>? toolOutput = null,

            global::System.Action<global::Vectara.ThinkingEvent?>? thinking = null,

            global::System.Action<global::Vectara.StructuredOutputEvent?>? structuredOutput = null,

            global::System.Action<global::Vectara.StreamingAgentOutput>? streamingAgentOutput = null,

            global::System.Action<global::Vectara.StreamingAgentOutputEnd>? streamingAgentOutputEnd = null,

            global::System.Action<global::Vectara.StreamingThinking>? streamingThinking = null,

            global::System.Action<global::Vectara.StreamingThinkingEnd>? streamingThinkingEnd = null,

            global::System.Action<global::Vectara.ToolActivityEvent?>? toolActivity = null,

            global::System.Action<global::Vectara.StreamResponseEnd>? end = null,
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
            else if (IsToolInput)
            {
                toolInput?.Invoke(ToolInput!);
            }
            else if (IsToolOutput)
            {
                toolOutput?.Invoke(ToolOutput!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsStructuredOutput)
            {
                structuredOutput?.Invoke(StructuredOutput!);
            }
            else if (IsStreamingAgentOutput)
            {
                streamingAgentOutput?.Invoke(StreamingAgentOutput!);
            }
            else if (IsStreamingAgentOutputEnd)
            {
                streamingAgentOutputEnd?.Invoke(StreamingAgentOutputEnd!);
            }
            else if (IsStreamingThinking)
            {
                streamingThinking?.Invoke(StreamingThinking!);
            }
            else if (IsStreamingThinkingEnd)
            {
                streamingThinkingEnd?.Invoke(StreamingThinkingEnd!);
            }
            else if (IsToolActivity)
            {
                toolActivity?.Invoke(ToolActivity!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.EndUserInputMessageEvent?>? inputMessage = null,
            global::System.Action<global::Vectara.EndUserAgentOutputEvent?>? agentOutput = null,
            global::System.Action<global::Vectara.EndUserErrorEvent?>? error = null,
            global::System.Action<global::Vectara.ToolInputEvent?>? toolInput = null,
            global::System.Action<global::Vectara.ToolOutputEvent?>? toolOutput = null,
            global::System.Action<global::Vectara.ThinkingEvent?>? thinking = null,
            global::System.Action<global::Vectara.StructuredOutputEvent?>? structuredOutput = null,
            global::System.Action<global::Vectara.StreamingAgentOutput>? streamingAgentOutput = null,
            global::System.Action<global::Vectara.StreamingAgentOutputEnd>? streamingAgentOutputEnd = null,
            global::System.Action<global::Vectara.StreamingThinking>? streamingThinking = null,
            global::System.Action<global::Vectara.StreamingThinkingEnd>? streamingThinkingEnd = null,
            global::System.Action<global::Vectara.ToolActivityEvent?>? toolActivity = null,
            global::System.Action<global::Vectara.StreamResponseEnd>? end = null,
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
            else if (IsToolInput)
            {
                toolInput?.Invoke(ToolInput!);
            }
            else if (IsToolOutput)
            {
                toolOutput?.Invoke(ToolOutput!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsStructuredOutput)
            {
                structuredOutput?.Invoke(StructuredOutput!);
            }
            else if (IsStreamingAgentOutput)
            {
                streamingAgentOutput?.Invoke(StreamingAgentOutput!);
            }
            else if (IsStreamingAgentOutputEnd)
            {
                streamingAgentOutputEnd?.Invoke(StreamingAgentOutputEnd!);
            }
            else if (IsStreamingThinking)
            {
                streamingThinking?.Invoke(StreamingThinking!);
            }
            else if (IsStreamingThinkingEnd)
            {
                streamingThinkingEnd?.Invoke(StreamingThinkingEnd!);
            }
            else if (IsToolActivity)
            {
                toolActivity?.Invoke(ToolActivity!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
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
                ToolInput,
                typeof(global::Vectara.ToolInputEvent),
                ToolOutput,
                typeof(global::Vectara.ToolOutputEvent),
                Thinking,
                typeof(global::Vectara.ThinkingEvent),
                StructuredOutput,
                typeof(global::Vectara.StructuredOutputEvent),
                StreamingAgentOutput,
                typeof(global::Vectara.StreamingAgentOutput),
                StreamingAgentOutputEnd,
                typeof(global::Vectara.StreamingAgentOutputEnd),
                StreamingThinking,
                typeof(global::Vectara.StreamingThinking),
                StreamingThinkingEnd,
                typeof(global::Vectara.StreamingThinkingEnd),
                ToolActivity,
                typeof(global::Vectara.ToolActivityEvent),
                End,
                typeof(global::Vectara.StreamResponseEnd),
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolInputEvent?>.Default.Equals(ToolInput, other.ToolInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolOutputEvent?>.Default.Equals(ToolOutput, other.ToolOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ThinkingEvent?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StructuredOutputEvent?>.Default.Equals(StructuredOutput, other.StructuredOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamingAgentOutput?>.Default.Equals(StreamingAgentOutput, other.StreamingAgentOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamingAgentOutputEnd?>.Default.Equals(StreamingAgentOutputEnd, other.StreamingAgentOutputEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamingThinking?>.Default.Equals(StreamingThinking, other.StreamingThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamingThinkingEnd?>.Default.Equals(StreamingThinkingEnd, other.StreamingThinkingEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolActivityEvent?>.Default.Equals(ToolActivity, other.ToolActivity) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamResponseEnd?>.Default.Equals(End, other.End)
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
