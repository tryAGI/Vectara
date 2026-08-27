#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class AgentConnectorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentConnector>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentConnector Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentConnectorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentConnectorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentConnectorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.SlackAgentConnector? slack = default;
            if (discriminator?.Type == global::Vectara.AgentConnectorDiscriminatorType.Slack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SlackAgentConnector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SlackAgentConnector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SlackAgentConnector)}");
                slack = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.GchatAgentConnector? gchat = default;
            if (discriminator?.Type == global::Vectara.AgentConnectorDiscriminatorType.Gchat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GchatAgentConnector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GchatAgentConnector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GchatAgentConnector)}");
                gchat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ZoomAgentConnector? zoom = default;
            if (discriminator?.Type == global::Vectara.AgentConnectorDiscriminatorType.Zoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ZoomAgentConnector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ZoomAgentConnector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ZoomAgentConnector)}");
                zoom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WidgetAgentConnector? widget = default;
            if (discriminator?.Type == global::Vectara.AgentConnectorDiscriminatorType.Widget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WidgetAgentConnector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WidgetAgentConnector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WidgetAgentConnector)}");
                widget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AgentConnector(
                discriminator?.Type,
                slack,

                gchat,

                zoom,

                widget
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AgentConnector value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSlack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SlackAgentConnector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SlackAgentConnector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SlackAgentConnector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Slack!.Value, typeInfo);
            }
            else if (value.IsGchat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GchatAgentConnector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GchatAgentConnector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GchatAgentConnector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gchat!.Value, typeInfo);
            }
            else if (value.IsZoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ZoomAgentConnector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ZoomAgentConnector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ZoomAgentConnector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Zoom!.Value, typeInfo);
            }
            else if (value.IsWidget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WidgetAgentConnector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WidgetAgentConnector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WidgetAgentConnector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Widget!.Value, typeInfo);
            }
        }
    }
}