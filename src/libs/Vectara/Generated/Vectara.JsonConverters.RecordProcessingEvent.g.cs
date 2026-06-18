#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class RecordProcessingEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.RecordProcessingEvent>
    {
        /// <inheritdoc />
        public override global::Vectara.RecordProcessingEvent Read(
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

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("occurred_at")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("dead_lettered")) __score1++;
            if (__jsonProps.Contains("error")) __score1++;
            if (__jsonProps.Contains("session_key")) __score1++;
            if (__jsonProps.Contains("skipped")) __score1++;
            if (__jsonProps.Contains("source_record_id")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vectara.PipelineRunEventBase? pipelineRunBase = default;
            global::Vectara.RecordProcessingEventVariant2? recordProcessingEventVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PipelineRunEventBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PipelineRunEventBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.PipelineRunEventBase).Name}");
                        pipelineRunBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RecordProcessingEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RecordProcessingEventVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.RecordProcessingEventVariant2).Name}");
                        recordProcessingEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pipelineRunBase == null && recordProcessingEventVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PipelineRunEventBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PipelineRunEventBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.PipelineRunEventBase).Name}");
                    pipelineRunBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (pipelineRunBase == null && recordProcessingEventVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RecordProcessingEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RecordProcessingEventVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.RecordProcessingEventVariant2).Name}");
                    recordProcessingEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vectara.RecordProcessingEvent(
                pipelineRunBase,

                recordProcessingEventVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.RecordProcessingEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPipelineRunBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PipelineRunEventBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PipelineRunEventBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.PipelineRunEventBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PipelineRunBase!, typeInfo);
            }
            else if (value.IsRecordProcessingEventVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RecordProcessingEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RecordProcessingEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.RecordProcessingEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RecordProcessingEventVariant2!, typeInfo);
            }
        }
    }
}