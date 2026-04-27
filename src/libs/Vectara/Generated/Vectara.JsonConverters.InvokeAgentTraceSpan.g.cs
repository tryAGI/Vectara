#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class InvokeAgentTraceSpanJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.InvokeAgentTraceSpan>
    {
        /// <inheritdoc />
        public override global::Vectara.InvokeAgentTraceSpan Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("duration_ms")) __score0++;
            if (__jsonProps.Contains("error_message")) __score0++;
            if (__jsonProps.Contains("parent_span_id")) __score0++;
            if (__jsonProps.Contains("span_id")) __score0++;
            if (__jsonProps.Contains("started_at")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("step_name")) __score0++;
            if (__jsonProps.Contains("trace_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("attributes")) __score1++;
            if (__jsonProps.Contains("attributes.agent_description")) __score1++;
            if (__jsonProps.Contains("attributes.agent_name")) __score1++;
            if (__jsonProps.Contains("attributes.cache_read_input_tokens")) __score1++;
            if (__jsonProps.Contains("attributes.input_event_id")) __score1++;
            if (__jsonProps.Contains("attributes.input_files")) __score1++;
            if (__jsonProps.Contains("attributes.input_tokens")) __score1++;
            if (__jsonProps.Contains("attributes.max_tokens")) __score1++;
            if (__jsonProps.Contains("attributes.model")) __score1++;
            if (__jsonProps.Contains("attributes.output_event_id")) __score1++;
            if (__jsonProps.Contains("attributes.output_tokens")) __score1++;
            if (__jsonProps.Contains("attributes.output_type")) __score1++;
            if (__jsonProps.Contains("attributes.provider_name")) __score1++;
            if (__jsonProps.Contains("attributes.temperature")) __score1++;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("operation")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vectara.AgentTraceSpanBase? @base = default;
            global::Vectara.InvokeAgentTraceSpanVariant2? invokeAgentTraceSpanVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentTraceSpanBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentTraceSpanBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentTraceSpanBase).Name}");
                        @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InvokeAgentTraceSpanVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InvokeAgentTraceSpanVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InvokeAgentTraceSpanVariant2).Name}");
                        invokeAgentTraceSpanVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && invokeAgentTraceSpanVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentTraceSpanBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentTraceSpanBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentTraceSpanBase).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InvokeAgentTraceSpanVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InvokeAgentTraceSpanVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InvokeAgentTraceSpanVariant2).Name}");
                    invokeAgentTraceSpanVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vectara.InvokeAgentTraceSpan(
                @base,

                invokeAgentTraceSpanVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.InvokeAgentTraceSpan value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentTraceSpanBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentTraceSpanBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentTraceSpanBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsInvokeAgentTraceSpanVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.InvokeAgentTraceSpanVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.InvokeAgentTraceSpanVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.InvokeAgentTraceSpanVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvokeAgentTraceSpanVariant2!, typeInfo);
            }
        }
    }
}