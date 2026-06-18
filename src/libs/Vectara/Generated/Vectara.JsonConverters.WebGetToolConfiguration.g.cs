#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class WebGetToolConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.WebGetToolConfiguration>
    {
        /// <inheritdoc />
        public override global::Vectara.WebGetToolConfiguration Read(
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
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("description_template")) __score0++;
            if (__jsonProps.Contains("enabled")) __score0++;
            if (__jsonProps.Contains("input_transform")) __score0++;
            if (__jsonProps.Contains("key")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("output_transform")) __score0++;
            if (__jsonProps.Contains("updated_at")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("argument_override")) __score1++;
            if (__jsonProps.Contains("argument_override.auth")) __score1++;
            if (__jsonProps.Contains("argument_override.body")) __score1++;
            if (__jsonProps.Contains("argument_override.follow_redirects")) __score1++;
            if (__jsonProps.Contains("argument_override.head_lines")) __score1++;
            if (__jsonProps.Contains("argument_override.headers")) __score1++;
            if (__jsonProps.Contains("argument_override.max_content_bytes")) __score1++;
            if (__jsonProps.Contains("argument_override.method")) __score1++;
            if (__jsonProps.Contains("argument_override.ssl_verify")) __score1++;
            if (__jsonProps.Contains("argument_override.tail_lines")) __score1++;
            if (__jsonProps.Contains("argument_override.timeout_seconds")) __score1++;
            if (__jsonProps.Contains("argument_override.url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vectara.ToolConfigurationBase? @base = default;
            global::Vectara.WebGetToolConfigurationVariant2? webGetToolConfigurationVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolConfigurationBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolConfigurationBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ToolConfigurationBase).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetToolConfigurationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetToolConfigurationVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebGetToolConfigurationVariant2).Name}");
                        webGetToolConfigurationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && webGetToolConfigurationVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolConfigurationBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolConfigurationBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ToolConfigurationBase).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (@base == null && webGetToolConfigurationVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetToolConfigurationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetToolConfigurationVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebGetToolConfigurationVariant2).Name}");
                    webGetToolConfigurationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vectara.WebGetToolConfiguration(
                @base,

                webGetToolConfigurationVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.WebGetToolConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ToolConfigurationBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ToolConfigurationBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ToolConfigurationBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsWebGetToolConfigurationVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebGetToolConfigurationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebGetToolConfigurationVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebGetToolConfigurationVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebGetToolConfigurationVariant2!, typeInfo);
            }
        }
    }
}