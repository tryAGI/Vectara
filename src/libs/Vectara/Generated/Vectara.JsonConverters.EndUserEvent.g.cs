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

            var __value = new global::Vectara.EndUserEvent(
                discriminator?.Type,
                inputMessage,

                agentOutput,

                error
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
        }
    }
}