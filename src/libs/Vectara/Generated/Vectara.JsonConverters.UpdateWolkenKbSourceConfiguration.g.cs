#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class UpdateWolkenKbSourceConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.UpdateWolkenKbSourceConfiguration>
    {
        /// <inheritdoc />
        public override global::Vectara.UpdateWolkenKbSourceConfiguration Read(
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
            if (__jsonProps.Contains("api_endpoint")) __score0++;
            if (__jsonProps.Contains("article_url_template")) __score0++;
            if (__jsonProps.Contains("auth_code")) __score0++;
            if (__jsonProps.Contains("client_id")) __score0++;
            if (__jsonProps.Contains("domain")) __score0++;
            if (__jsonProps.Contains("level_id")) __score0++;
            if (__jsonProps.Contains("refresh_token")) __score0++;
            if (__jsonProps.Contains("service_account")) __score0++;
            if (__jsonProps.Contains("status_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("update_upper_bound_operator")) __score0++;
            if (__jsonProps.Contains("validation_status_id")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::Vectara.BaseWolkenKbSourceConfiguration? @base = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BaseWolkenKbSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BaseWolkenKbSourceConfiguration> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BaseWolkenKbSourceConfiguration).Name}");
                        @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BaseWolkenKbSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BaseWolkenKbSourceConfiguration> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BaseWolkenKbSourceConfiguration).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vectara.UpdateWolkenKbSourceConfiguration(
                @base
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.UpdateWolkenKbSourceConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.BaseWolkenKbSourceConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.BaseWolkenKbSourceConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.BaseWolkenKbSourceConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
        }
    }
}