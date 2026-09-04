#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class TestLambdaToolStreamedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.TestLambdaToolStreamedResponse>
    {
        /// <inheritdoc />
        public override global::Vectara.TestLambdaToolStreamedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TestLambdaToolStreamedResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TestLambdaToolStreamedResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.TestLambdaToolStreamedResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.TestToolHeartbeatEvent? heartbeat = default;
            if (discriminator?.Type == global::Vectara.TestLambdaToolStreamedResponseDiscriminatorType.Heartbeat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TestToolHeartbeatEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TestToolHeartbeatEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.TestToolHeartbeatEvent)}");
                heartbeat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.TestLambdaToolResultEvent? result = default;
            if (discriminator?.Type == global::Vectara.TestLambdaToolStreamedResponseDiscriminatorType.Result)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TestLambdaToolResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TestLambdaToolResultEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.TestLambdaToolResultEvent)}");
                result = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.TestLambdaToolStreamedResponse(
                discriminator?.Type,
                heartbeat,

                result
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.TestLambdaToolStreamedResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsHeartbeat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TestToolHeartbeatEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TestToolHeartbeatEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.TestToolHeartbeatEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Heartbeat!, typeInfo);
            }
            else if (value.IsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TestLambdaToolResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TestLambdaToolResultEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.TestLambdaToolResultEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Result!, typeInfo);
            }
        }
    }
}