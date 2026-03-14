#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class AgentEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentEvent>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.InputMessageEvent? inputMessage = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.InputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InputMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InputMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InputMessageEvent)}");
                inputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.SkillLoadEvent? skillLoad = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.SkillLoad)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SkillLoadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SkillLoadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SkillLoadEvent)}");
                skillLoad = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ArtifactUploadEvent? artifactUpload = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.ArtifactUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactUploadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactUploadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ArtifactUploadEvent)}");
                artifactUpload = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ToolInputEvent? toolInput = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.ToolInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolInputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ToolInputEvent)}");
                toolInput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ToolOutputEvent? toolOutput = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.ToolOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ToolOutputEvent)}");
                toolOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ThinkingEvent? thinking = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ThinkingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ThinkingEvent)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.AgentOutputEvent? agentOutput = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.AgentOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentOutputEvent)}");
                agentOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StructuredOutputEvent? structuredOutput = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.StructuredOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StructuredOutputEvent)}");
                structuredOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ContextLimitExceededEvent? contextLimitExceeded = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.ContextLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ContextLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ContextLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ContextLimitExceededEvent)}");
                contextLimitExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StepTransitionLimitExceededEvent? stepTransitionLimitExceeded = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.StepTransitionLimitExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepTransitionLimitExceededEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepTransitionLimitExceededEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StepTransitionLimitExceededEvent)}");
                stepTransitionLimitExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.SessionInterruptedEvent? sessionInterrupted = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.SessionInterrupted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SessionInterruptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SessionInterruptedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SessionInterruptedEvent)}");
                sessionInterrupted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ImageReadEvent? imageRead = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ImageReadEvent)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StepTransitionEvent? stepTransition = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.StepTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepTransitionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepTransitionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StepTransitionEvent)}");
                stepTransition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CompactionEvent? compaction = default;
            if (discriminator?.Type == global::Vectara.AgentEventDiscriminatorType.Compaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CompactionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CompactionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CompactionEvent)}");
                compaction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AgentEvent(
                discriminator?.Type,
                inputMessage,

                skillLoad,

                artifactUpload,

                toolInput,

                toolOutput,

                thinking,

                agentOutput,

                structuredOutput,

                contextLimitExceeded,

                stepTransitionLimitExceeded,

                sessionInterrupted,

                imageRead,

                stepTransition,

                compaction
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AgentEvent value,
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
            else if (value.IsSkillLoad)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SkillLoadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SkillLoadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SkillLoadEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkillLoad, typeInfo);
            }
            else if (value.IsArtifactUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ArtifactUploadEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ArtifactUploadEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ArtifactUploadEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactUpload, typeInfo);
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
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ThinkingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ThinkingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeInfo);
            }
            else if (value.IsAgentOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentOutput, typeInfo);
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
            else if (value.IsCompaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CompactionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CompactionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CompactionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction, typeInfo);
            }
        }
    }
}