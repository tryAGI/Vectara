#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class ToolInputEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.ToolInputEvent>
    {
        /// <inheritdoc />
        public override global::Vectara.ToolInputEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Vectara.AgentEventBase? agentBase = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentEventBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentEventBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentEventBase).Name}");
                agentBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Vectara.ToolInputEventVariant2? toolInputEventVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolInputEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolInputEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ToolInputEventVariant2).Name}");
                toolInputEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Vectara.ToolInputEvent(
                agentBase,

                toolInputEventVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.ToolInputEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsAgentBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentEventBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentEventBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentEventBase).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.AgentBase!, typeInfo);
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
            if (value.IsToolInputEventVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolInputEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolInputEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ToolInputEventVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ToolInputEventVariant2!, typeInfo);
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