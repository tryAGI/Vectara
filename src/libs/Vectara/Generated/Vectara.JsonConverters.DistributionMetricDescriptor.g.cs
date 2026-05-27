#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class DistributionMetricDescriptorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.DistributionMetricDescriptor>
    {
        /// <inheritdoc />
        public override global::Vectara.DistributionMetricDescriptor Read(
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
            if (__jsonProps.Contains("category")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("display_name")) __score0++;
            if (__jsonProps.Contains("labels")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("unit")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("bins")) __score1++;
            if (__jsonProps.Contains("kind")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vectara.MetricDescriptorBase? @base = default;
            global::Vectara.DistributionMetricDescriptorVariant2? distributionMetricDescriptorVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MetricDescriptorBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MetricDescriptorBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.MetricDescriptorBase).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DistributionMetricDescriptorVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DistributionMetricDescriptorVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DistributionMetricDescriptorVariant2).Name}");
                        distributionMetricDescriptorVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && distributionMetricDescriptorVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MetricDescriptorBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MetricDescriptorBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.MetricDescriptorBase).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (@base == null && distributionMetricDescriptorVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DistributionMetricDescriptorVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DistributionMetricDescriptorVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DistributionMetricDescriptorVariant2).Name}");
                    distributionMetricDescriptorVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vectara.DistributionMetricDescriptor(
                @base,

                distributionMetricDescriptorVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.DistributionMetricDescriptor value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MetricDescriptorBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MetricDescriptorBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.MetricDescriptorBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsDistributionMetricDescriptorVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DistributionMetricDescriptorVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DistributionMetricDescriptorVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DistributionMetricDescriptorVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DistributionMetricDescriptorVariant2!, typeInfo);
            }
        }
    }
}