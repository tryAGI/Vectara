#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An individual event sent with Server-sent Events (SSE) when the agent response is streamed.
    /// </summary>
    public readonly partial struct AgentStreamedResponse : global::System.IEquatable<AgentStreamedResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentStreamedResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// An input message event from a user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InputMessageEvent? InputMessage { get; init; }
#else
        public global::Vectara.InputMessageEvent? InputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

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
        /// An event representing a complete agent response with structured JSON content conforming to a schema.<br/>
        /// This event is published instead of AgentOutputEvent when the agent's output_parser is configured<br/>
        /// with type "structured". It contains the LLM's final response parsed as validated JSON that<br/>
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
        /// A transient event indicating the current request exceeded the LLM's context limit.<br/>
        /// This event is not persisted to the session history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ContextLimitExceededEvent? ContextLimitExceeded { get; init; }
#else
        public global::Vectara.ContextLimitExceededEvent? ContextLimitExceeded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextLimitExceeded))]
#endif
        public bool IsContextLimitExceeded => ContextLimitExceeded != null;

        /// <summary>
        /// A transient event indicating the agent exceeded the maximum number of step transitions,<br/>
        /// which may indicate an infinite loop between steps.<br/>
        /// This event is not persisted to the session history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StepTransitionLimitExceededEvent? StepTransitionLimitExceeded { get; init; }
#else
        public global::Vectara.StepTransitionLimitExceededEvent? StepTransitionLimitExceeded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepTransitionLimitExceeded))]
#endif
        public bool IsStepTransitionLimitExceeded => StepTransitionLimitExceeded != null;

        /// <summary>
        /// A transient event indicating the agent session was interrupted by a user request.<br/>
        /// This event is not persisted to the session history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SessionInterruptedEvent? SessionInterrupted { get; init; }
#else
        public global::Vectara.SessionInterruptedEvent? SessionInterrupted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInterrupted))]
#endif
        public bool IsSessionInterrupted => SessionInterrupted != null;

        /// <summary>
        /// An event representing an image being loaded into the conversation context for viewing and analysis.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ImageReadEvent? ImageRead { get; init; }
#else
        public global::Vectara.ImageReadEvent? ImageRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageRead))]
#endif
        public bool IsImageRead => ImageRead != null;

        /// <summary>
        /// An event representing a transition between agent steps.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StepTransitionEvent? StepTransition { get; init; }
#else
        public global::Vectara.StepTransitionEvent? StepTransition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepTransition))]
#endif
        public bool IsStepTransition => StepTransition != null;

        /// <summary>
        /// Token usage event reporting context window consumption.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ContextConsumedEvent? ContextConsumed { get; init; }
#else
        public global::Vectara.ContextConsumedEvent? ContextConsumed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextConsumed))]
#endif
        public bool IsContextConsumed => ContextConsumed != null;

        /// <summary>
        /// An event indicating that context compaction has started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CompactionStartedEvent? CompactionStarted { get; init; }
#else
        public global::Vectara.CompactionStartedEvent? CompactionStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompactionStarted))]
#endif
        public bool IsCompactionStarted => CompactionStarted != null;

        /// <summary>
        /// An event indicating that context compaction has completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CompactionEvent? Compaction { get; init; }
#else
        public global::Vectara.CompactionEvent? Compaction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compaction))]
#endif
        public bool IsCompaction => Compaction != null;

        /// <summary>
        /// Event signaling there was an error with the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamError? Error { get; init; }
#else
        public global::Vectara.StreamError? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

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
        public static implicit operator AgentStreamedResponse(global::Vectara.InputMessageEvent value) => new AgentStreamedResponse((global::Vectara.InputMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InputMessageEvent?(AgentStreamedResponse @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.InputMessageEvent? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.StreamingAgentOutput value) => new AgentStreamedResponse((global::Vectara.StreamingAgentOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamingAgentOutput?(AgentStreamedResponse @this) => @this.StreamingAgentOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.StreamingAgentOutput? value)
        {
            StreamingAgentOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.StreamingAgentOutputEnd value) => new AgentStreamedResponse((global::Vectara.StreamingAgentOutputEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamingAgentOutputEnd?(AgentStreamedResponse @this) => @this.StreamingAgentOutputEnd;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.StreamingAgentOutputEnd? value)
        {
            StreamingAgentOutputEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.StreamingThinking value) => new AgentStreamedResponse((global::Vectara.StreamingThinking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamingThinking?(AgentStreamedResponse @this) => @this.StreamingThinking;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.StreamingThinking? value)
        {
            StreamingThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.StreamingThinkingEnd value) => new AgentStreamedResponse((global::Vectara.StreamingThinkingEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamingThinkingEnd?(AgentStreamedResponse @this) => @this.StreamingThinkingEnd;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.StreamingThinkingEnd? value)
        {
            StreamingThinkingEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.ToolInputEvent value) => new AgentStreamedResponse((global::Vectara.ToolInputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolInputEvent?(AgentStreamedResponse @this) => @this.ToolInput;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.ToolInputEvent? value)
        {
            ToolInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.ToolOutputEvent value) => new AgentStreamedResponse((global::Vectara.ToolOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolOutputEvent?(AgentStreamedResponse @this) => @this.ToolOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.ToolOutputEvent? value)
        {
            ToolOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.StructuredOutputEvent value) => new AgentStreamedResponse((global::Vectara.StructuredOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StructuredOutputEvent?(AgentStreamedResponse @this) => @this.StructuredOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.StructuredOutputEvent? value)
        {
            StructuredOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.ContextLimitExceededEvent value) => new AgentStreamedResponse((global::Vectara.ContextLimitExceededEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ContextLimitExceededEvent?(AgentStreamedResponse @this) => @this.ContextLimitExceeded;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.ContextLimitExceededEvent? value)
        {
            ContextLimitExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.StepTransitionLimitExceededEvent value) => new AgentStreamedResponse((global::Vectara.StepTransitionLimitExceededEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StepTransitionLimitExceededEvent?(AgentStreamedResponse @this) => @this.StepTransitionLimitExceeded;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.StepTransitionLimitExceededEvent? value)
        {
            StepTransitionLimitExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.SessionInterruptedEvent value) => new AgentStreamedResponse((global::Vectara.SessionInterruptedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SessionInterruptedEvent?(AgentStreamedResponse @this) => @this.SessionInterrupted;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.SessionInterruptedEvent? value)
        {
            SessionInterrupted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.ImageReadEvent value) => new AgentStreamedResponse((global::Vectara.ImageReadEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageReadEvent?(AgentStreamedResponse @this) => @this.ImageRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.ImageReadEvent? value)
        {
            ImageRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.StepTransitionEvent value) => new AgentStreamedResponse((global::Vectara.StepTransitionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StepTransitionEvent?(AgentStreamedResponse @this) => @this.StepTransition;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.StepTransitionEvent? value)
        {
            StepTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.ContextConsumedEvent value) => new AgentStreamedResponse((global::Vectara.ContextConsumedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ContextConsumedEvent?(AgentStreamedResponse @this) => @this.ContextConsumed;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.ContextConsumedEvent? value)
        {
            ContextConsumed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.CompactionStartedEvent value) => new AgentStreamedResponse((global::Vectara.CompactionStartedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CompactionStartedEvent?(AgentStreamedResponse @this) => @this.CompactionStarted;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.CompactionStartedEvent? value)
        {
            CompactionStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.CompactionEvent value) => new AgentStreamedResponse((global::Vectara.CompactionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CompactionEvent?(AgentStreamedResponse @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.CompactionEvent? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.StreamError value) => new AgentStreamedResponse((global::Vectara.StreamError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamError?(AgentStreamedResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.StreamError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStreamedResponse(global::Vectara.StreamResponseEnd value) => new AgentStreamedResponse((global::Vectara.StreamResponseEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamResponseEnd?(AgentStreamedResponse @this) => @this.End;

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(global::Vectara.StreamResponseEnd? value)
        {
            End = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentStreamedResponse(
            global::Vectara.AgentStreamedResponseDiscriminatorType? type,
            global::Vectara.InputMessageEvent? inputMessage,
            global::Vectara.StreamingAgentOutput? streamingAgentOutput,
            global::Vectara.StreamingAgentOutputEnd? streamingAgentOutputEnd,
            global::Vectara.StreamingThinking? streamingThinking,
            global::Vectara.StreamingThinkingEnd? streamingThinkingEnd,
            global::Vectara.ToolInputEvent? toolInput,
            global::Vectara.ToolOutputEvent? toolOutput,
            global::Vectara.StructuredOutputEvent? structuredOutput,
            global::Vectara.ContextLimitExceededEvent? contextLimitExceeded,
            global::Vectara.StepTransitionLimitExceededEvent? stepTransitionLimitExceeded,
            global::Vectara.SessionInterruptedEvent? sessionInterrupted,
            global::Vectara.ImageReadEvent? imageRead,
            global::Vectara.StepTransitionEvent? stepTransition,
            global::Vectara.ContextConsumedEvent? contextConsumed,
            global::Vectara.CompactionStartedEvent? compactionStarted,
            global::Vectara.CompactionEvent? compaction,
            global::Vectara.StreamError? error,
            global::Vectara.StreamResponseEnd? end
            )
        {
            Type = type;

            InputMessage = inputMessage;
            StreamingAgentOutput = streamingAgentOutput;
            StreamingAgentOutputEnd = streamingAgentOutputEnd;
            StreamingThinking = streamingThinking;
            StreamingThinkingEnd = streamingThinkingEnd;
            ToolInput = toolInput;
            ToolOutput = toolOutput;
            StructuredOutput = structuredOutput;
            ContextLimitExceeded = contextLimitExceeded;
            StepTransitionLimitExceeded = stepTransitionLimitExceeded;
            SessionInterrupted = sessionInterrupted;
            ImageRead = imageRead;
            StepTransition = stepTransition;
            ContextConsumed = contextConsumed;
            CompactionStarted = compactionStarted;
            Compaction = compaction;
            Error = error;
            End = end;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            End as object ??
            Error as object ??
            Compaction as object ??
            CompactionStarted as object ??
            ContextConsumed as object ??
            StepTransition as object ??
            ImageRead as object ??
            SessionInterrupted as object ??
            StepTransitionLimitExceeded as object ??
            ContextLimitExceeded as object ??
            StructuredOutput as object ??
            ToolOutput as object ??
            ToolInput as object ??
            StreamingThinkingEnd as object ??
            StreamingThinking as object ??
            StreamingAgentOutputEnd as object ??
            StreamingAgentOutput as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            StreamingAgentOutput?.ToString() ??
            StreamingAgentOutputEnd?.ToString() ??
            StreamingThinking?.ToString() ??
            StreamingThinkingEnd?.ToString() ??
            ToolInput?.ToString() ??
            ToolOutput?.ToString() ??
            StructuredOutput?.ToString() ??
            ContextLimitExceeded?.ToString() ??
            StepTransitionLimitExceeded?.ToString() ??
            SessionInterrupted?.ToString() ??
            ImageRead?.ToString() ??
            StepTransition?.ToString() ??
            ContextConsumed?.ToString() ??
            CompactionStarted?.ToString() ??
            Compaction?.ToString() ??
            Error?.ToString() ??
            End?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && IsCompactionStarted && !IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && IsCompaction && !IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && IsError && !IsEnd || !IsInputMessage && !IsStreamingAgentOutput && !IsStreamingAgentOutputEnd && !IsStreamingThinking && !IsStreamingThinkingEnd && !IsToolInput && !IsToolOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsContextConsumed && !IsCompactionStarted && !IsCompaction && !IsError && IsEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.InputMessageEvent?, TResult>? inputMessage = null,
            global::System.Func<global::Vectara.StreamingAgentOutput?, TResult>? streamingAgentOutput = null,
            global::System.Func<global::Vectara.StreamingAgentOutputEnd?, TResult>? streamingAgentOutputEnd = null,
            global::System.Func<global::Vectara.StreamingThinking?, TResult>? streamingThinking = null,
            global::System.Func<global::Vectara.StreamingThinkingEnd?, TResult>? streamingThinkingEnd = null,
            global::System.Func<global::Vectara.ToolInputEvent?, TResult>? toolInput = null,
            global::System.Func<global::Vectara.ToolOutputEvent?, TResult>? toolOutput = null,
            global::System.Func<global::Vectara.StructuredOutputEvent?, TResult>? structuredOutput = null,
            global::System.Func<global::Vectara.ContextLimitExceededEvent?, TResult>? contextLimitExceeded = null,
            global::System.Func<global::Vectara.StepTransitionLimitExceededEvent?, TResult>? stepTransitionLimitExceeded = null,
            global::System.Func<global::Vectara.SessionInterruptedEvent?, TResult>? sessionInterrupted = null,
            global::System.Func<global::Vectara.ImageReadEvent?, TResult>? imageRead = null,
            global::System.Func<global::Vectara.StepTransitionEvent?, TResult>? stepTransition = null,
            global::System.Func<global::Vectara.ContextConsumedEvent?, TResult>? contextConsumed = null,
            global::System.Func<global::Vectara.CompactionStartedEvent?, TResult>? compactionStarted = null,
            global::System.Func<global::Vectara.CompactionEvent?, TResult>? compaction = null,
            global::System.Func<global::Vectara.StreamError?, TResult>? error = null,
            global::System.Func<global::Vectara.StreamResponseEnd?, TResult>? end = null,
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
            else if (IsToolInput && toolInput != null)
            {
                return toolInput(ToolInput!);
            }
            else if (IsToolOutput && toolOutput != null)
            {
                return toolOutput(ToolOutput!);
            }
            else if (IsStructuredOutput && structuredOutput != null)
            {
                return structuredOutput(StructuredOutput!);
            }
            else if (IsContextLimitExceeded && contextLimitExceeded != null)
            {
                return contextLimitExceeded(ContextLimitExceeded!);
            }
            else if (IsStepTransitionLimitExceeded && stepTransitionLimitExceeded != null)
            {
                return stepTransitionLimitExceeded(StepTransitionLimitExceeded!);
            }
            else if (IsSessionInterrupted && sessionInterrupted != null)
            {
                return sessionInterrupted(SessionInterrupted!);
            }
            else if (IsImageRead && imageRead != null)
            {
                return imageRead(ImageRead!);
            }
            else if (IsStepTransition && stepTransition != null)
            {
                return stepTransition(StepTransition!);
            }
            else if (IsContextConsumed && contextConsumed != null)
            {
                return contextConsumed(ContextConsumed!);
            }
            else if (IsCompactionStarted && compactionStarted != null)
            {
                return compactionStarted(CompactionStarted!);
            }
            else if (IsCompaction && compaction != null)
            {
                return compaction(Compaction!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
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
            global::System.Action<global::Vectara.InputMessageEvent?>? inputMessage = null,
            global::System.Action<global::Vectara.StreamingAgentOutput?>? streamingAgentOutput = null,
            global::System.Action<global::Vectara.StreamingAgentOutputEnd?>? streamingAgentOutputEnd = null,
            global::System.Action<global::Vectara.StreamingThinking?>? streamingThinking = null,
            global::System.Action<global::Vectara.StreamingThinkingEnd?>? streamingThinkingEnd = null,
            global::System.Action<global::Vectara.ToolInputEvent?>? toolInput = null,
            global::System.Action<global::Vectara.ToolOutputEvent?>? toolOutput = null,
            global::System.Action<global::Vectara.StructuredOutputEvent?>? structuredOutput = null,
            global::System.Action<global::Vectara.ContextLimitExceededEvent?>? contextLimitExceeded = null,
            global::System.Action<global::Vectara.StepTransitionLimitExceededEvent?>? stepTransitionLimitExceeded = null,
            global::System.Action<global::Vectara.SessionInterruptedEvent?>? sessionInterrupted = null,
            global::System.Action<global::Vectara.ImageReadEvent?>? imageRead = null,
            global::System.Action<global::Vectara.StepTransitionEvent?>? stepTransition = null,
            global::System.Action<global::Vectara.ContextConsumedEvent?>? contextConsumed = null,
            global::System.Action<global::Vectara.CompactionStartedEvent?>? compactionStarted = null,
            global::System.Action<global::Vectara.CompactionEvent?>? compaction = null,
            global::System.Action<global::Vectara.StreamError?>? error = null,
            global::System.Action<global::Vectara.StreamResponseEnd?>? end = null,
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
            else if (IsToolInput)
            {
                toolInput?.Invoke(ToolInput!);
            }
            else if (IsToolOutput)
            {
                toolOutput?.Invoke(ToolOutput!);
            }
            else if (IsStructuredOutput)
            {
                structuredOutput?.Invoke(StructuredOutput!);
            }
            else if (IsContextLimitExceeded)
            {
                contextLimitExceeded?.Invoke(ContextLimitExceeded!);
            }
            else if (IsStepTransitionLimitExceeded)
            {
                stepTransitionLimitExceeded?.Invoke(StepTransitionLimitExceeded!);
            }
            else if (IsSessionInterrupted)
            {
                sessionInterrupted?.Invoke(SessionInterrupted!);
            }
            else if (IsImageRead)
            {
                imageRead?.Invoke(ImageRead!);
            }
            else if (IsStepTransition)
            {
                stepTransition?.Invoke(StepTransition!);
            }
            else if (IsContextConsumed)
            {
                contextConsumed?.Invoke(ContextConsumed!);
            }
            else if (IsCompactionStarted)
            {
                compactionStarted?.Invoke(CompactionStarted!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
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
                typeof(global::Vectara.InputMessageEvent),
                StreamingAgentOutput,
                typeof(global::Vectara.StreamingAgentOutput),
                StreamingAgentOutputEnd,
                typeof(global::Vectara.StreamingAgentOutputEnd),
                StreamingThinking,
                typeof(global::Vectara.StreamingThinking),
                StreamingThinkingEnd,
                typeof(global::Vectara.StreamingThinkingEnd),
                ToolInput,
                typeof(global::Vectara.ToolInputEvent),
                ToolOutput,
                typeof(global::Vectara.ToolOutputEvent),
                StructuredOutput,
                typeof(global::Vectara.StructuredOutputEvent),
                ContextLimitExceeded,
                typeof(global::Vectara.ContextLimitExceededEvent),
                StepTransitionLimitExceeded,
                typeof(global::Vectara.StepTransitionLimitExceededEvent),
                SessionInterrupted,
                typeof(global::Vectara.SessionInterruptedEvent),
                ImageRead,
                typeof(global::Vectara.ImageReadEvent),
                StepTransition,
                typeof(global::Vectara.StepTransitionEvent),
                ContextConsumed,
                typeof(global::Vectara.ContextConsumedEvent),
                CompactionStarted,
                typeof(global::Vectara.CompactionStartedEvent),
                Compaction,
                typeof(global::Vectara.CompactionEvent),
                Error,
                typeof(global::Vectara.StreamError),
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
        public bool Equals(AgentStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InputMessageEvent?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamingAgentOutput?>.Default.Equals(StreamingAgentOutput, other.StreamingAgentOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamingAgentOutputEnd?>.Default.Equals(StreamingAgentOutputEnd, other.StreamingAgentOutputEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamingThinking?>.Default.Equals(StreamingThinking, other.StreamingThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamingThinkingEnd?>.Default.Equals(StreamingThinkingEnd, other.StreamingThinkingEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolInputEvent?>.Default.Equals(ToolInput, other.ToolInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolOutputEvent?>.Default.Equals(ToolOutput, other.ToolOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StructuredOutputEvent?>.Default.Equals(StructuredOutput, other.StructuredOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ContextLimitExceededEvent?>.Default.Equals(ContextLimitExceeded, other.ContextLimitExceeded) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepTransitionLimitExceededEvent?>.Default.Equals(StepTransitionLimitExceeded, other.StepTransitionLimitExceeded) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SessionInterruptedEvent?>.Default.Equals(SessionInterrupted, other.SessionInterrupted) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageReadEvent?>.Default.Equals(ImageRead, other.ImageRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepTransitionEvent?>.Default.Equals(StepTransition, other.StepTransition) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ContextConsumedEvent?>.Default.Equals(ContextConsumed, other.ContextConsumed) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CompactionStartedEvent?>.Default.Equals(CompactionStarted, other.CompactionStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CompactionEvent?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamResponseEnd?>.Default.Equals(End, other.End) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentStreamedResponse obj1, AgentStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentStreamedResponse obj1, AgentStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentStreamedResponse o && Equals(o);
        }
    }
}
