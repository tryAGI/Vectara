#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A session event visible to the end user who owns the session.<br/>
    /// The `input_message`, `agent_output`, and `error` variants are always visible.<br/>
    /// The `tool_input`, `tool_output`, `thinking`, and `structured_output` variants appear only when the widget connector the caller entered through reveals the matching output category via `revealed_output_types`.<br/>
    /// Revealed variants carry the same payload as their operator representations.
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
        public static implicit operator EndUserEvent(global::Vectara.ToolInputEvent value) => new EndUserEvent((global::Vectara.ToolInputEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ToolInputEvent?(EndUserEvent @this) => @this.ToolInput;

        /// <summary>
        ///
        /// </summary>
        public EndUserEvent(global::Vectara.ToolInputEvent? value)
        {
            ToolInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserEvent FromToolInput(global::Vectara.ToolInputEvent? value) => new EndUserEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserEvent(global::Vectara.ToolOutputEvent value) => new EndUserEvent((global::Vectara.ToolOutputEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ToolOutputEvent?(EndUserEvent @this) => @this.ToolOutput;

        /// <summary>
        ///
        /// </summary>
        public EndUserEvent(global::Vectara.ToolOutputEvent? value)
        {
            ToolOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserEvent FromToolOutput(global::Vectara.ToolOutputEvent? value) => new EndUserEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserEvent(global::Vectara.ThinkingEvent value) => new EndUserEvent((global::Vectara.ThinkingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ThinkingEvent?(EndUserEvent @this) => @this.Thinking;

        /// <summary>
        ///
        /// </summary>
        public EndUserEvent(global::Vectara.ThinkingEvent? value)
        {
            Thinking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserEvent FromThinking(global::Vectara.ThinkingEvent? value) => new EndUserEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserEvent(global::Vectara.StructuredOutputEvent value) => new EndUserEvent((global::Vectara.StructuredOutputEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StructuredOutputEvent?(EndUserEvent @this) => @this.StructuredOutput;

        /// <summary>
        ///
        /// </summary>
        public EndUserEvent(global::Vectara.StructuredOutputEvent? value)
        {
            StructuredOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserEvent FromStructuredOutput(global::Vectara.StructuredOutputEvent? value) => new EndUserEvent(value);

        /// <summary>
        ///
        /// </summary>
        public EndUserEvent(
            global::Vectara.EndUserEventDiscriminatorType? type,
            global::Vectara.EndUserInputMessageEvent? inputMessage,
            global::Vectara.EndUserAgentOutputEvent? agentOutput,
            global::Vectara.EndUserErrorEvent? error,
            global::Vectara.ToolInputEvent? toolInput,
            global::Vectara.ToolOutputEvent? toolOutput,
            global::Vectara.ThinkingEvent? thinking,
            global::Vectara.StructuredOutputEvent? structuredOutput
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
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
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
            StructuredOutput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput || !IsInputMessage && IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput || !IsInputMessage && !IsAgentOutput && IsError && !IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput || !IsInputMessage && !IsAgentOutput && !IsError && IsToolInput && !IsToolOutput && !IsThinking && !IsStructuredOutput || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && IsToolOutput && !IsThinking && !IsStructuredOutput || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && IsThinking && !IsStructuredOutput || !IsInputMessage && !IsAgentOutput && !IsError && !IsToolInput && !IsToolOutput && !IsThinking && IsStructuredOutput;
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolInputEvent?>.Default.Equals(ToolInput, other.ToolInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolOutputEvent?>.Default.Equals(ToolOutput, other.ToolOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ThinkingEvent?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StructuredOutputEvent?>.Default.Equals(StructuredOutput, other.StructuredOutput)
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
