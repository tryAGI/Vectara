#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class ReplaceAgentRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.ReplaceAgentRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.ReplaceAgentRequest Read(
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
            if (__jsonProps.Contains("compaction")) __score0++;
            if (__jsonProps.Contains("compaction.compaction_message")) __score0++;
            if (__jsonProps.Contains("compaction.enabled")) __score0++;
            if (__jsonProps.Contains("compaction.keep_recent_inputs")) __score0++;
            if (__jsonProps.Contains("compaction.threshold_percent")) __score0++;
            if (__jsonProps.Contains("compaction.tool_event_policy")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("enabled")) __score0++;
            if (__jsonProps.Contains("first_step")) __score0++;
            if (__jsonProps.Contains("first_step.allowed_skills")) __score0++;
            if (__jsonProps.Contains("first_step.allowed_tools")) __score0++;
            if (__jsonProps.Contains("first_step.instructions")) __score0++;
            if (__jsonProps.Contains("first_step.name")) __score0++;
            if (__jsonProps.Contains("first_step.next_steps")) __score0++;
            if (__jsonProps.Contains("first_step.output_parser")) __score0++;
            if (__jsonProps.Contains("first_step.reentry_step")) __score0++;
            if (__jsonProps.Contains("first_step.reminders")) __score0++;
            if (__jsonProps.Contains("first_step.type")) __score0++;
            if (__jsonProps.Contains("first_step_name")) __score0++;
            if (__jsonProps.Contains("key")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("model.name")) __score0++;
            if (__jsonProps.Contains("model.parameters")) __score0++;
            if (__jsonProps.Contains("model.retry_configuration")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("session_enrichment")) __score0++;
            if (__jsonProps.Contains("session_enrichment.enabled")) __score0++;
            if (__jsonProps.Contains("session_enrichment.tool_calls")) __score0++;
            if (__jsonProps.Contains("skills")) __score0++;
            if (__jsonProps.Contains("steps")) __score0++;
            if (__jsonProps.Contains("tool_configurations")) __score0++;
            if (__jsonProps.Contains("tool_output_offloading")) __score0++;
            if (__jsonProps.Contains("tool_output_offloading.context_percentage")) __score0++;
            if (__jsonProps.Contains("tool_output_offloading.enabled")) __score0++;
            if (__jsonProps.Contains("tool_output_offloading.headroom_percentage")) __score0++;
            if (__jsonProps.Contains("tool_output_offloading.max_threshold_bytes")) __score0++;
            if (__jsonProps.Contains("tool_output_offloading.min_threshold_bytes")) __score0++;
            if (__jsonProps.Contains("tool_output_offloading.mode")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("updated_at")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vectara.CreateAgentRequest? create = default;
            global::Vectara.ReplaceAgentRequestVariant2? replaceAgentRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateAgentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateAgentRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateAgentRequest).Name}");
                        create = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ReplaceAgentRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ReplaceAgentRequestVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ReplaceAgentRequestVariant2).Name}");
                        replaceAgentRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (create == null && replaceAgentRequestVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateAgentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateAgentRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateAgentRequest).Name}");
                    create = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (create == null && replaceAgentRequestVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ReplaceAgentRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ReplaceAgentRequestVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ReplaceAgentRequestVariant2).Name}");
                    replaceAgentRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vectara.ReplaceAgentRequest(
                create,

                replaceAgentRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.ReplaceAgentRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateAgentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateAgentRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CreateAgentRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Create!, typeInfo);
            }
            else if (value.IsReplaceAgentRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ReplaceAgentRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ReplaceAgentRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ReplaceAgentRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReplaceAgentRequestVariant2!, typeInfo);
            }
        }
    }
}