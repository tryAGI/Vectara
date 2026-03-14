#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An event in an agent session conversation.
    /// </summary>
    public readonly partial struct AgentEvent : global::System.IEquatable<AgentEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentEventDiscriminatorType? Type { get; }

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
        /// An event representing the loading of a skill's content into the conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SkillLoadEvent? SkillLoad { get; init; }
#else
        public global::Vectara.SkillLoadEvent? SkillLoad { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkillLoad))]
#endif
        public bool IsSkillLoad => SkillLoad != null;

        /// <summary>
        /// Event representing files uploaded to the agent workspace as artifacts.<br/>
        /// This event is created when users upload one or more files to an agent session using multipart requests. The event becomes part of the session's conversation history and contains references to all artifacts that were uploaded in the request. Each uploaded file is assigned a unique artifact identifier and stored in the session's workspace.<br/>
        /// When an agent processes this event, it becomes aware that new files are available in the session and can use various tools to read, analyze, or transform these artifacts. For example, after receiving an artifact upload event with a PDF, the agent might use the document conversion tool to extract and analyze the document's contents.<br/>
        /// See the `ArtifactReference` schema for comprehensive details about what artifacts are, how they are stored, their lifecycle, and how agents interact with them.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ArtifactUploadEvent? ArtifactUpload { get; init; }
#else
        public global::Vectara.ArtifactUploadEvent? ArtifactUpload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactUpload))]
#endif
        public bool IsArtifactUpload => ArtifactUpload != null;

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
        /// An event representing a complete agent response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentOutputEvent? AgentOutput { get; init; }
#else
        public global::Vectara.AgentOutputEvent? AgentOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentOutput))]
#endif
        public bool IsAgentOutput => AgentOutput != null;

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
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.InputMessageEvent value) => new AgentEvent((global::Vectara.InputMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InputMessageEvent?(AgentEvent @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.InputMessageEvent? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.SkillLoadEvent value) => new AgentEvent((global::Vectara.SkillLoadEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SkillLoadEvent?(AgentEvent @this) => @this.SkillLoad;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.SkillLoadEvent? value)
        {
            SkillLoad = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.ArtifactUploadEvent value) => new AgentEvent((global::Vectara.ArtifactUploadEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactUploadEvent?(AgentEvent @this) => @this.ArtifactUpload;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.ArtifactUploadEvent? value)
        {
            ArtifactUpload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.ToolInputEvent value) => new AgentEvent((global::Vectara.ToolInputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolInputEvent?(AgentEvent @this) => @this.ToolInput;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.ToolInputEvent? value)
        {
            ToolInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.ToolOutputEvent value) => new AgentEvent((global::Vectara.ToolOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolOutputEvent?(AgentEvent @this) => @this.ToolOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.ToolOutputEvent? value)
        {
            ToolOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.ThinkingEvent value) => new AgentEvent((global::Vectara.ThinkingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ThinkingEvent?(AgentEvent @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.ThinkingEvent? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.AgentOutputEvent value) => new AgentEvent((global::Vectara.AgentOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentOutputEvent?(AgentEvent @this) => @this.AgentOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.AgentOutputEvent? value)
        {
            AgentOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.StructuredOutputEvent value) => new AgentEvent((global::Vectara.StructuredOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StructuredOutputEvent?(AgentEvent @this) => @this.StructuredOutput;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.StructuredOutputEvent? value)
        {
            StructuredOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.ContextLimitExceededEvent value) => new AgentEvent((global::Vectara.ContextLimitExceededEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ContextLimitExceededEvent?(AgentEvent @this) => @this.ContextLimitExceeded;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.ContextLimitExceededEvent? value)
        {
            ContextLimitExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.StepTransitionLimitExceededEvent value) => new AgentEvent((global::Vectara.StepTransitionLimitExceededEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StepTransitionLimitExceededEvent?(AgentEvent @this) => @this.StepTransitionLimitExceeded;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.StepTransitionLimitExceededEvent? value)
        {
            StepTransitionLimitExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.SessionInterruptedEvent value) => new AgentEvent((global::Vectara.SessionInterruptedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SessionInterruptedEvent?(AgentEvent @this) => @this.SessionInterrupted;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.SessionInterruptedEvent? value)
        {
            SessionInterrupted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.ImageReadEvent value) => new AgentEvent((global::Vectara.ImageReadEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageReadEvent?(AgentEvent @this) => @this.ImageRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.ImageReadEvent? value)
        {
            ImageRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.StepTransitionEvent value) => new AgentEvent((global::Vectara.StepTransitionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StepTransitionEvent?(AgentEvent @this) => @this.StepTransition;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.StepTransitionEvent? value)
        {
            StepTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentEvent(global::Vectara.CompactionEvent value) => new AgentEvent((global::Vectara.CompactionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CompactionEvent?(AgentEvent @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(global::Vectara.CompactionEvent? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentEvent(
            global::Vectara.AgentEventDiscriminatorType? type,
            global::Vectara.InputMessageEvent? inputMessage,
            global::Vectara.SkillLoadEvent? skillLoad,
            global::Vectara.ArtifactUploadEvent? artifactUpload,
            global::Vectara.ToolInputEvent? toolInput,
            global::Vectara.ToolOutputEvent? toolOutput,
            global::Vectara.ThinkingEvent? thinking,
            global::Vectara.AgentOutputEvent? agentOutput,
            global::Vectara.StructuredOutputEvent? structuredOutput,
            global::Vectara.ContextLimitExceededEvent? contextLimitExceeded,
            global::Vectara.StepTransitionLimitExceededEvent? stepTransitionLimitExceeded,
            global::Vectara.SessionInterruptedEvent? sessionInterrupted,
            global::Vectara.ImageReadEvent? imageRead,
            global::Vectara.StepTransitionEvent? stepTransition,
            global::Vectara.CompactionEvent? compaction
            )
        {
            Type = type;

            InputMessage = inputMessage;
            SkillLoad = skillLoad;
            ArtifactUpload = artifactUpload;
            ToolInput = toolInput;
            ToolOutput = toolOutput;
            Thinking = thinking;
            AgentOutput = agentOutput;
            StructuredOutput = structuredOutput;
            ContextLimitExceeded = contextLimitExceeded;
            StepTransitionLimitExceeded = stepTransitionLimitExceeded;
            SessionInterrupted = sessionInterrupted;
            ImageRead = imageRead;
            StepTransition = stepTransition;
            Compaction = compaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Compaction as object ??
            StepTransition as object ??
            ImageRead as object ??
            SessionInterrupted as object ??
            StepTransitionLimitExceeded as object ??
            ContextLimitExceeded as object ??
            StructuredOutput as object ??
            AgentOutput as object ??
            Thinking as object ??
            ToolOutput as object ??
            ToolInput as object ??
            ArtifactUpload as object ??
            SkillLoad as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            SkillLoad?.ToString() ??
            ArtifactUpload?.ToString() ??
            ToolInput?.ToString() ??
            ToolOutput?.ToString() ??
            Thinking?.ToString() ??
            AgentOutput?.ToString() ??
            StructuredOutput?.ToString() ??
            ContextLimitExceeded?.ToString() ??
            StepTransitionLimitExceeded?.ToString() ??
            SessionInterrupted?.ToString() ??
            ImageRead?.ToString() ??
            StepTransition?.ToString() ??
            Compaction?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && IsSessionInterrupted && !IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && IsImageRead && !IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && IsStepTransition && !IsCompaction || !IsInputMessage && !IsSkillLoad && !IsArtifactUpload && !IsToolInput && !IsToolOutput && !IsThinking && !IsAgentOutput && !IsStructuredOutput && !IsContextLimitExceeded && !IsStepTransitionLimitExceeded && !IsSessionInterrupted && !IsImageRead && !IsStepTransition && IsCompaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.InputMessageEvent?, TResult>? inputMessage = null,
            global::System.Func<global::Vectara.SkillLoadEvent?, TResult>? skillLoad = null,
            global::System.Func<global::Vectara.ArtifactUploadEvent?, TResult>? artifactUpload = null,
            global::System.Func<global::Vectara.ToolInputEvent?, TResult>? toolInput = null,
            global::System.Func<global::Vectara.ToolOutputEvent?, TResult>? toolOutput = null,
            global::System.Func<global::Vectara.ThinkingEvent?, TResult>? thinking = null,
            global::System.Func<global::Vectara.AgentOutputEvent?, TResult>? agentOutput = null,
            global::System.Func<global::Vectara.StructuredOutputEvent?, TResult>? structuredOutput = null,
            global::System.Func<global::Vectara.ContextLimitExceededEvent?, TResult>? contextLimitExceeded = null,
            global::System.Func<global::Vectara.StepTransitionLimitExceededEvent?, TResult>? stepTransitionLimitExceeded = null,
            global::System.Func<global::Vectara.SessionInterruptedEvent?, TResult>? sessionInterrupted = null,
            global::System.Func<global::Vectara.ImageReadEvent?, TResult>? imageRead = null,
            global::System.Func<global::Vectara.StepTransitionEvent?, TResult>? stepTransition = null,
            global::System.Func<global::Vectara.CompactionEvent?, TResult>? compaction = null,
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
            else if (IsSkillLoad && skillLoad != null)
            {
                return skillLoad(SkillLoad!);
            }
            else if (IsArtifactUpload && artifactUpload != null)
            {
                return artifactUpload(ArtifactUpload!);
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
            else if (IsAgentOutput && agentOutput != null)
            {
                return agentOutput(AgentOutput!);
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
            else if (IsCompaction && compaction != null)
            {
                return compaction(Compaction!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.InputMessageEvent?>? inputMessage = null,
            global::System.Action<global::Vectara.SkillLoadEvent?>? skillLoad = null,
            global::System.Action<global::Vectara.ArtifactUploadEvent?>? artifactUpload = null,
            global::System.Action<global::Vectara.ToolInputEvent?>? toolInput = null,
            global::System.Action<global::Vectara.ToolOutputEvent?>? toolOutput = null,
            global::System.Action<global::Vectara.ThinkingEvent?>? thinking = null,
            global::System.Action<global::Vectara.AgentOutputEvent?>? agentOutput = null,
            global::System.Action<global::Vectara.StructuredOutputEvent?>? structuredOutput = null,
            global::System.Action<global::Vectara.ContextLimitExceededEvent?>? contextLimitExceeded = null,
            global::System.Action<global::Vectara.StepTransitionLimitExceededEvent?>? stepTransitionLimitExceeded = null,
            global::System.Action<global::Vectara.SessionInterruptedEvent?>? sessionInterrupted = null,
            global::System.Action<global::Vectara.ImageReadEvent?>? imageRead = null,
            global::System.Action<global::Vectara.StepTransitionEvent?>? stepTransition = null,
            global::System.Action<global::Vectara.CompactionEvent?>? compaction = null,
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
            else if (IsSkillLoad)
            {
                skillLoad?.Invoke(SkillLoad!);
            }
            else if (IsArtifactUpload)
            {
                artifactUpload?.Invoke(ArtifactUpload!);
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
            else if (IsAgentOutput)
            {
                agentOutput?.Invoke(AgentOutput!);
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
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
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
                SkillLoad,
                typeof(global::Vectara.SkillLoadEvent),
                ArtifactUpload,
                typeof(global::Vectara.ArtifactUploadEvent),
                ToolInput,
                typeof(global::Vectara.ToolInputEvent),
                ToolOutput,
                typeof(global::Vectara.ToolOutputEvent),
                Thinking,
                typeof(global::Vectara.ThinkingEvent),
                AgentOutput,
                typeof(global::Vectara.AgentOutputEvent),
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
                Compaction,
                typeof(global::Vectara.CompactionEvent),
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
        public bool Equals(AgentEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InputMessageEvent?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SkillLoadEvent?>.Default.Equals(SkillLoad, other.SkillLoad) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactUploadEvent?>.Default.Equals(ArtifactUpload, other.ArtifactUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolInputEvent?>.Default.Equals(ToolInput, other.ToolInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolOutputEvent?>.Default.Equals(ToolOutput, other.ToolOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ThinkingEvent?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentOutputEvent?>.Default.Equals(AgentOutput, other.AgentOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StructuredOutputEvent?>.Default.Equals(StructuredOutput, other.StructuredOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ContextLimitExceededEvent?>.Default.Equals(ContextLimitExceeded, other.ContextLimitExceeded) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepTransitionLimitExceededEvent?>.Default.Equals(StepTransitionLimitExceeded, other.StepTransitionLimitExceeded) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SessionInterruptedEvent?>.Default.Equals(SessionInterrupted, other.SessionInterrupted) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageReadEvent?>.Default.Equals(ImageRead, other.ImageRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepTransitionEvent?>.Default.Equals(StepTransition, other.StepTransition) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CompactionEvent?>.Default.Equals(Compaction, other.Compaction) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentEvent obj1, AgentEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentEvent obj1, AgentEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentEvent o && Equals(o);
        }
    }
}
