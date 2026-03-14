#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class AgentStreamedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentStreamedResponse>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentStreamedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentStreamedResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentStreamedResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentStreamedResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.InputMessageEvent? inputMessage = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.InputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InputMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InputMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InputMessageEvent)}");
                inputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StreamingAgentOutput? streamingAgentOutput = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.StreamingAgentOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamingAgentOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamingAgentOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamingAgentOutput)}");
                streamingAgentOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StreamingAgentOutputEnd? streamingAgentOutputEnd = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.StreamingAgentOutputEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamingAgentOutputEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamingAgentOutputEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamingAgentOutputEnd)}");
                streamingAgentOutputEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StreamingThinking? streamingThinking = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.StreamingThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamingThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamingThinking> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamingThinking)}");
                streamingThinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StreamingThinkingEnd? streamingThinkingEnd = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.StreamingThinkingEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamingThinkingEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamingThinkingEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamingThinkingEnd)}");
                streamingThinkingEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ToolInputEvent? toolInput = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.ToolInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolInputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ToolInputEvent)}");
                toolInput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ToolOutputEvent? toolOutput = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.ToolOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ToolOutputEvent)}");
                toolOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StructuredOutputEvent? structuredOutput = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.StructuredOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StructuredOutputEvent)}");
                structuredOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ContextLimitExceededEvent? contextLimitExceeded = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.ContextLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ContextLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ContextLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ContextLimitExceededEvent)}");
                contextLimitExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StepTransitionLimitExceededEvent? stepTransitionLimitExceeded = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.StepTransitionLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepTransitionLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepTransitionLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StepTransitionLimitExceededEvent)}");
                stepTransitionLimitExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.SessionInterruptedEvent? sessionInterrupted = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.SessionInterrupted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SessionInterruptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SessionInterruptedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SessionInterruptedEvent)}");
                sessionInterrupted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ImageReadEvent? imageRead = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ImageReadEvent)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StepTransitionEvent? stepTransition = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.StepTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepTransitionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepTransitionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StepTransitionEvent)}");
                stepTransition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ContextConsumedEvent? contextConsumed = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.ContextConsumed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ContextConsumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ContextConsumedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ContextConsumedEvent)}");
                contextConsumed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CompactionStartedEvent? compactionStarted = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.CompactionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CompactionStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CompactionStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CompactionStartedEvent)}");
                compactionStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CompactionEvent? compaction = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.Compaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CompactionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CompactionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CompactionEvent)}");
                compaction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StreamError? error = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StreamResponseEnd? end = default;
            if (discriminator?.Type == global::Vectara.AgentStreamedResponseDiscriminatorType.End)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamResponseEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StreamResponseEnd)}");
                end = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AgentStreamedResponse(
                discriminator?.Type,
                inputMessage,

                streamingAgentOutput,

                streamingAgentOutputEnd,

                streamingThinking,

                streamingThinkingEnd,

                toolInput,

                toolOutput,

                structuredOutput,

                contextLimitExceeded,

                stepTransitionLimitExceeded,

                sessionInterrupted,

                imageRead,

                stepTransition,

                contextConsumed,

                compactionStarted,

                compaction,

                error,

                end
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AgentStreamedResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InputMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InputMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InputMessageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessage, typeInfo);
            }
            else if (value.IsStreamingAgentOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamingAgentOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamingAgentOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamingAgentOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamingAgentOutput, typeInfo);
            }
            else if (value.IsStreamingAgentOutputEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamingAgentOutputEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamingAgentOutputEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamingAgentOutputEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamingAgentOutputEnd, typeInfo);
            }
            else if (value.IsStreamingThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamingThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamingThinking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamingThinking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamingThinking, typeInfo);
            }
            else if (value.IsStreamingThinkingEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamingThinkingEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamingThinkingEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamingThinkingEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamingThinkingEnd, typeInfo);
            }
            else if (value.IsToolInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolInputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ToolInputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolInput, typeInfo);
            }
            else if (value.IsToolOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ToolOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolOutput, typeInfo);
            }
            else if (value.IsStructuredOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StructuredOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StructuredOutput, typeInfo);
            }
            else if (value.IsContextLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ContextLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ContextLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ContextLimitExceededEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContextLimitExceeded, typeInfo);
            }
            else if (value.IsStepTransitionLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepTransitionLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepTransitionLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StepTransitionLimitExceededEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepTransitionLimitExceeded, typeInfo);
            }
            else if (value.IsSessionInterrupted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SessionInterruptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SessionInterruptedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SessionInterruptedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInterrupted, typeInfo);
            }
            else if (value.IsImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ImageReadEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageRead, typeInfo);
            }
            else if (value.IsStepTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepTransitionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepTransitionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StepTransitionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepTransition, typeInfo);
            }
            else if (value.IsContextConsumed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ContextConsumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ContextConsumedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ContextConsumedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContextConsumed, typeInfo);
            }
            else if (value.IsCompactionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CompactionStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CompactionStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CompactionStartedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompactionStarted, typeInfo);
            }
            else if (value.IsCompaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CompactionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CompactionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CompactionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StreamResponseEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StreamResponseEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StreamResponseEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeInfo);
            }
        }
    }
}