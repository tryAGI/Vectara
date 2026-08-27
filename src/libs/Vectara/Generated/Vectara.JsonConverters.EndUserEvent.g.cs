#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class EndUserEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.EndUserEvent>
    {
        /// <inheritdoc />
        public override global::Vectara.EndUserEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.EndUserEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.EndUserEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.EndUserEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.EndUserInputMessageEvent? inputMessage = default;
            if (discriminator?.Type == global::Vectara.EndUserEventDiscriminatorType.InputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.EndUserInputMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.EndUserInputMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.EndUserInputMessageEvent)}");
                inputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.EndUserAgentOutputEvent? agentOutput = default;
            if (discriminator?.Type == global::Vectara.EndUserEventDiscriminatorType.AgentOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.EndUserAgentOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.EndUserAgentOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.EndUserAgentOutputEvent)}");
                agentOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.EndUserErrorEvent? error = default;
            if (discriminator?.Type == global::Vectara.EndUserEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.EndUserErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.EndUserErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.EndUserErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ToolInputEvent? toolInput = default;
            if (discriminator?.Type == global::Vectara.EndUserEventDiscriminatorType.ToolInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolInputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ToolInputEvent)}");
                toolInput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ToolOutputEvent? toolOutput = default;
            if (discriminator?.Type == global::Vectara.EndUserEventDiscriminatorType.ToolOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ToolOutputEvent)}");
                toolOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ThinkingEvent? thinking = default;
            if (discriminator?.Type == global::Vectara.EndUserEventDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ThinkingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ThinkingEvent)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StructuredOutputEvent? structuredOutput = default;
            if (discriminator?.Type == global::Vectara.EndUserEventDiscriminatorType.StructuredOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StructuredOutputEvent)}");
                structuredOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.EndUserEvent(
                discriminator?.Type,
                inputMessage,

                agentOutput,

                error,

                toolInput,

                toolOutput,

                thinking,

                structuredOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.EndUserEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.EndUserInputMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.EndUserInputMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.EndUserInputMessageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessage!.Value, typeInfo);
            }
            else if (value.IsAgentOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.EndUserAgentOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.EndUserAgentOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.EndUserAgentOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentOutput!.Value, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.EndUserErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.EndUserErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.EndUserErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!.Value, typeInfo);
            }
            else if (value.IsToolInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolInputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ToolInputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolInput!.Value, typeInfo);
            }
            else if (value.IsToolOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ToolOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolOutput!.Value, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ThinkingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ThinkingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking!.Value, typeInfo);
            }
            else if (value.IsStructuredOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StructuredOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StructuredOutput!.Value, typeInfo);
            }
        }
    }
}