#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class ZoomAgentConnectorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.ZoomAgentConnector>
    {
        /// <inheritdoc />
        public override global::Vectara.ZoomAgentConnector Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Vectara.AgentConnectorBase? @base = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentConnectorBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentConnectorBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentConnectorBase).Name}");
                @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Vectara.ZoomAgentConnectorVariant2? zoomAgentConnectorVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ZoomAgentConnectorVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ZoomAgentConnectorVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ZoomAgentConnectorVariant2).Name}");
                zoomAgentConnectorVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Vectara.ZoomAgentConnector(
                @base,

                zoomAgentConnectorVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.ZoomAgentConnector value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentConnectorBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentConnectorBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentConnectorBase).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Base!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsZoomAgentConnectorVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ZoomAgentConnectorVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ZoomAgentConnectorVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ZoomAgentConnectorVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ZoomAgentConnectorVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}