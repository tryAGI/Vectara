#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class CreateGenerationPresetRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CreateGenerationPresetRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.CreateGenerationPresetRequest Read(
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
            if (__jsonProps.Contains("additional_model_params")) __score0++;
            if (__jsonProps.Contains("default")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("enabled")) __score0++;
            if (__jsonProps.Contains("frequency_penalty")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("llm_name")) __score0++;
            if (__jsonProps.Contains("max_tokens")) __score0++;
            if (__jsonProps.Contains("max_used_search_results")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("presence_penalty")) __score0++;
            if (__jsonProps.Contains("prompt_template")) __score0++;
            if (__jsonProps.Contains("temperature")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vectara.GenerationPreset? generationPreset = default;
            object? createGenerationPresetRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenerationPreset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenerationPreset> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GenerationPreset).Name}");
                        generationPreset = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        createGenerationPresetRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (generationPreset == null && createGenerationPresetRequestVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenerationPreset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenerationPreset> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GenerationPreset).Name}");
                    generationPreset = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    createGenerationPresetRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vectara.CreateGenerationPresetRequest(
                generationPreset,

                createGenerationPresetRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.CreateGenerationPresetRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGenerationPreset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GenerationPreset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GenerationPreset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GenerationPreset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerationPreset!, typeInfo);
            }
            else if (value.IsCreateGenerationPresetRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateGenerationPresetRequestVariant2!, typeInfo);
            }
        }
    }
}