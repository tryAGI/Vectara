#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class ToolActivityEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.ToolActivityEvent>
    {
        /// <inheritdoc />
        public override global::Vectara.ToolActivityEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolActivityEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolActivityEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ToolActivityEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.GenericToolActivityEvent? generic = default;
            if (discriminator?.ActivityType == global::Vectara.ToolActivityEventDiscriminatorActivityType.Generic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenericToolActivityEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenericToolActivityEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GenericToolActivityEvent)}");
                generic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.SubAgentToolActivityEvent? subAgent = default;
            if (discriminator?.ActivityType == global::Vectara.ToolActivityEventDiscriminatorActivityType.SubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SubAgentToolActivityEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SubAgentToolActivityEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SubAgentToolActivityEvent)}");
                subAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.ToolActivityEvent(
                discriminator?.ActivityType,
                generic,

                subAgent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.ToolActivityEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGeneric)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenericToolActivityEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenericToolActivityEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GenericToolActivityEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Generic!.Value, typeInfo);
            }
            else if (value.IsSubAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SubAgentToolActivityEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SubAgentToolActivityEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SubAgentToolActivityEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubAgent!.Value, typeInfo);
            }
        }
    }
}