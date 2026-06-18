#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class MetricDescriptorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.MetricDescriptor>
    {
        /// <inheritdoc />
        public override global::Vectara.MetricDescriptor Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MetricDescriptorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MetricDescriptorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.MetricDescriptorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CounterMetricDescriptor? counter = default;
            if (discriminator?.Type == global::Vectara.MetricDescriptorDiscriminatorType.Counter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CounterMetricDescriptor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CounterMetricDescriptor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CounterMetricDescriptor)}");
                counter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.GaugeMetricDescriptor? gauge = default;
            if (discriminator?.Type == global::Vectara.MetricDescriptorDiscriminatorType.Gauge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GaugeMetricDescriptor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GaugeMetricDescriptor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GaugeMetricDescriptor)}");
                gauge = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.PercentilesMetricDescriptor? percentiles = default;
            if (discriminator?.Type == global::Vectara.MetricDescriptorDiscriminatorType.Percentiles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PercentilesMetricDescriptor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PercentilesMetricDescriptor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.PercentilesMetricDescriptor)}");
                percentiles = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.DistributionMetricDescriptor? distribution = default;
            if (discriminator?.Type == global::Vectara.MetricDescriptorDiscriminatorType.Distribution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DistributionMetricDescriptor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DistributionMetricDescriptor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.DistributionMetricDescriptor)}");
                distribution = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.MetricDescriptor(
                discriminator?.Type,
                counter,

                gauge,

                percentiles,

                distribution
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.MetricDescriptor value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCounter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CounterMetricDescriptor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CounterMetricDescriptor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CounterMetricDescriptor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Counter!.Value, typeInfo);
            }
            else if (value.IsGauge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GaugeMetricDescriptor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GaugeMetricDescriptor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GaugeMetricDescriptor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gauge!.Value, typeInfo);
            }
            else if (value.IsPercentiles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PercentilesMetricDescriptor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PercentilesMetricDescriptor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.PercentilesMetricDescriptor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Percentiles!.Value, typeInfo);
            }
            else if (value.IsDistribution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DistributionMetricDescriptor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DistributionMetricDescriptor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DistributionMetricDescriptor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Distribution!.Value, typeInfo);
            }
        }
    }
}