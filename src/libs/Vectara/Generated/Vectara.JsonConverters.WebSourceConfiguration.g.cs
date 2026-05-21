#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class WebSourceConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.WebSourceConfiguration>
    {
        /// <inheritdoc />
        public override global::Vectara.WebSourceConfiguration Read(
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
            if (__jsonProps.Contains("auth")) __score0++;
            if (__jsonProps.Contains("excluded_content_types")) __score0++;
            if (__jsonProps.Contains("js_rendering")) __score0++;
            if (__jsonProps.Contains("max_concurrent")) __score0++;
            if (__jsonProps.Contains("max_page_bytes")) __score0++;
            if (__jsonProps.Contains("max_pages")) __score0++;
            if (__jsonProps.Contains("requests_per_second")) __score0++;
            if (__jsonProps.Contains("respect_robots_txt")) __score0++;
            if (__jsonProps.Contains("user_agent")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("pages_source")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vectara.BaseWebSource? @base = default;
            global::Vectara.WebSourceConfigurationVariant2? webSourceConfigurationVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BaseWebSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BaseWebSource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BaseWebSource).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebSourceConfigurationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebSourceConfigurationVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebSourceConfigurationVariant2).Name}");
                        webSourceConfigurationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && webSourceConfigurationVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BaseWebSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BaseWebSource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BaseWebSource).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (@base == null && webSourceConfigurationVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebSourceConfigurationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebSourceConfigurationVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebSourceConfigurationVariant2).Name}");
                    webSourceConfigurationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vectara.WebSourceConfiguration(
                @base,

                webSourceConfigurationVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.WebSourceConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BaseWebSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BaseWebSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BaseWebSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsWebSourceConfigurationVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WebSourceConfigurationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WebSourceConfigurationVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WebSourceConfigurationVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSourceConfigurationVariant2!, typeInfo);
            }
        }
    }
}