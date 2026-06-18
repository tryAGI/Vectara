#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class MetricSeriesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.MetricSeries>
    {
        /// <inheritdoc />
        public override global::Vectara.MetricSeries Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MetricSeriesDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MetricSeriesDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.MetricSeriesDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CounterMetricSeries? counter = default;
            if (discriminator?.Type == global::Vectara.MetricSeriesDiscriminatorType.Counter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CounterMetricSeries), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CounterMetricSeries> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CounterMetricSeries)}");
                counter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.GaugeMetricSeries? gauge = default;
            if (discriminator?.Type == global::Vectara.MetricSeriesDiscriminatorType.Gauge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GaugeMetricSeries), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GaugeMetricSeries> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GaugeMetricSeries)}");
                gauge = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.PercentilesMetricSeries? percentiles = default;
            if (discriminator?.Type == global::Vectara.MetricSeriesDiscriminatorType.Percentiles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PercentilesMetricSeries), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PercentilesMetricSeries> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.PercentilesMetricSeries)}");
                percentiles = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.DistributionMetricSeries? distribution = default;
            if (discriminator?.Type == global::Vectara.MetricSeriesDiscriminatorType.Distribution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DistributionMetricSeries), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DistributionMetricSeries> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.DistributionMetricSeries)}");
                distribution = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.MetricSeries(
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
            global::Vectara.MetricSeries value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCounter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CounterMetricSeries), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CounterMetricSeries> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CounterMetricSeries).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Counter!.Value, typeInfo);
            }
            else if (value.IsGauge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GaugeMetricSeries), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GaugeMetricSeries> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GaugeMetricSeries).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gauge!.Value, typeInfo);
            }
            else if (value.IsPercentiles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PercentilesMetricSeries), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PercentilesMetricSeries> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.PercentilesMetricSeries).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Percentiles!.Value, typeInfo);
            }
            else if (value.IsDistribution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.DistributionMetricSeries), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.DistributionMetricSeries> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.DistributionMetricSeries).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Distribution!.Value, typeInfo);
            }
        }
    }
}