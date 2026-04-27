#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class AgentTraceSpanJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentTraceSpan>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentTraceSpan Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentTraceSpanDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentTraceSpanDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentTraceSpanDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.InvokeAgentTraceSpan? invokeAgent = default;
            if (discriminator?.Operation == global::Vectara.AgentTraceSpanDiscriminatorOperation.InvokeAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InvokeAgentTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InvokeAgentTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.InvokeAgentTraceSpan)}");
                invokeAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ChatTraceSpan? chat = default;
            if (discriminator?.Operation == global::Vectara.AgentTraceSpanDiscriminatorOperation.Chat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ChatTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ChatTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ChatTraceSpan)}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ExecuteToolTraceSpan? executeTool = default;
            if (discriminator?.Operation == global::Vectara.AgentTraceSpanDiscriminatorOperation.ExecuteTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ExecuteToolTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ExecuteToolTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ExecuteToolTraceSpan)}");
                executeTool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ThinkingTraceSpan? thinking = default;
            if (discriminator?.Operation == global::Vectara.AgentTraceSpanDiscriminatorOperation.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ThinkingTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ThinkingTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ThinkingTraceSpan)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.OutputTraceSpan? output = default;
            if (discriminator?.Operation == global::Vectara.AgentTraceSpanDiscriminatorOperation.Output)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.OutputTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.OutputTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.OutputTraceSpan)}");
                output = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.GuardrailTraceSpan? guardrail = default;
            if (discriminator?.Operation == global::Vectara.AgentTraceSpanDiscriminatorOperation.Guardrail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GuardrailTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GuardrailTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GuardrailTraceSpan)}");
                guardrail = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StepTransitionTraceSpan? stepTransition = default;
            if (discriminator?.Operation == global::Vectara.AgentTraceSpanDiscriminatorOperation.StepTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepTransitionTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepTransitionTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StepTransitionTraceSpan)}");
                stepTransition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ImageReadTraceSpan? imageRead = default;
            if (discriminator?.Operation == global::Vectara.AgentTraceSpanDiscriminatorOperation.ImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ImageReadTraceSpan)}");
                imageRead = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CompactionTraceSpan? compaction = default;
            if (discriminator?.Operation == global::Vectara.AgentTraceSpanDiscriminatorOperation.Compaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CompactionTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CompactionTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CompactionTraceSpan)}");
                compaction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AgentTraceSpan(
                discriminator?.Operation,
                invokeAgent,

                chat,

                executeTool,

                thinking,

                output,

                guardrail,

                stepTransition,

                imageRead,

                compaction
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AgentTraceSpan value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInvokeAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InvokeAgentTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InvokeAgentTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InvokeAgentTraceSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvokeAgent!.Value, typeInfo);
            }
            else if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ChatTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ChatTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ChatTraceSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat!.Value, typeInfo);
            }
            else if (value.IsExecuteTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ExecuteToolTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ExecuteToolTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ExecuteToolTraceSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecuteTool!.Value, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ThinkingTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ThinkingTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ThinkingTraceSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking!.Value, typeInfo);
            }
            else if (value.IsOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.OutputTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.OutputTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.OutputTraceSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Output!.Value, typeInfo);
            }
            else if (value.IsGuardrail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GuardrailTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GuardrailTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GuardrailTraceSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Guardrail!.Value, typeInfo);
            }
            else if (value.IsStepTransition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepTransitionTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepTransitionTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StepTransitionTraceSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepTransition!.Value, typeInfo);
            }
            else if (value.IsImageRead)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageReadTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageReadTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ImageReadTraceSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageRead!.Value, typeInfo);
            }
            else if (value.IsCompaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CompactionTraceSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CompactionTraceSpan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CompactionTraceSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction!.Value, typeInfo);
            }
        }
    }
}