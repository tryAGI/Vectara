#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class CreateAgentConnectorRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CreateAgentConnectorRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.CreateAgentConnectorRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateAgentConnectorRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateAgentConnectorRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateAgentConnectorRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CreateSlackAgentConnectorRequest? slack = default;
            if (discriminator?.Type == global::Vectara.CreateAgentConnectorRequestDiscriminatorType.Slack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateSlackAgentConnectorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateSlackAgentConnectorRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateSlackAgentConnectorRequest)}");
                slack = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CreateGchatAgentConnectorRequest? gchat = default;
            if (discriminator?.Type == global::Vectara.CreateAgentConnectorRequestDiscriminatorType.Gchat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateGchatAgentConnectorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateGchatAgentConnectorRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateGchatAgentConnectorRequest)}");
                gchat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CreateZoomAgentConnectorRequest? zoom = default;
            if (discriminator?.Type == global::Vectara.CreateAgentConnectorRequestDiscriminatorType.Zoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateZoomAgentConnectorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateZoomAgentConnectorRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateZoomAgentConnectorRequest)}");
                zoom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CreateWidgetAgentConnectorRequest? widget = default;
            if (discriminator?.Type == global::Vectara.CreateAgentConnectorRequestDiscriminatorType.Widget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateWidgetAgentConnectorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateWidgetAgentConnectorRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateWidgetAgentConnectorRequest)}");
                widget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.CreateAgentConnectorRequest(
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
            global::Vectara.CreateAgentConnectorRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSlack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateSlackAgentConnectorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateSlackAgentConnectorRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateSlackAgentConnectorRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Slack!.Value, typeInfo);
            }
            else if (value.IsGchat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateGchatAgentConnectorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateGchatAgentConnectorRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateGchatAgentConnectorRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gchat!.Value, typeInfo);
            }
            else if (value.IsZoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateZoomAgentConnectorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateZoomAgentConnectorRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateZoomAgentConnectorRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Zoom!.Value, typeInfo);
            }
            else if (value.IsWidget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateWidgetAgentConnectorRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateWidgetAgentConnectorRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateWidgetAgentConnectorRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Widget!.Value, typeInfo);
            }
        }
    }
}