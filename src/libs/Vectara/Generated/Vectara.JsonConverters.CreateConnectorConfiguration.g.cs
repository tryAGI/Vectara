#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class CreateConnectorConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CreateConnectorConfiguration>
    {
        /// <inheritdoc />
        public override global::Vectara.CreateConnectorConfiguration Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateConnectorConfigurationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateConnectorConfigurationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateConnectorConfigurationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CreateSlackConnectorConfiguration? slack = default;
            if (discriminator?.Type == global::Vectara.CreateConnectorConfigurationDiscriminatorType.Slack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateSlackConnectorConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateSlackConnectorConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateSlackConnectorConfiguration)}");
                slack = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CreateGchatConnectorConfiguration? gchat = default;
            if (discriminator?.Type == global::Vectara.CreateConnectorConfigurationDiscriminatorType.Gchat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateGchatConnectorConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateGchatConnectorConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateGchatConnectorConfiguration)}");
                gchat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.CreateZoomConnectorConfiguration? zoom = default;
            if (discriminator?.Type == global::Vectara.CreateConnectorConfigurationDiscriminatorType.Zoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateZoomConnectorConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateZoomConnectorConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateZoomConnectorConfiguration)}");
                zoom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.CreateConnectorConfiguration(
                discriminator?.Type,
                slack,

                gchat,

                zoom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.CreateConnectorConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSlack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateSlackConnectorConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateSlackConnectorConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateSlackConnectorConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Slack!.Value, typeInfo);
            }
            else if (value.IsGchat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateGchatConnectorConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateGchatConnectorConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateGchatConnectorConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gchat!.Value, typeInfo);
            }
            else if (value.IsZoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateZoomConnectorConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateZoomConnectorConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateZoomConnectorConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Zoom!.Value, typeInfo);
            }
        }
    }
}