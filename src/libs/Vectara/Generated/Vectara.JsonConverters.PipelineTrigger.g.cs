#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class PipelineTriggerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.PipelineTrigger>
    {
        /// <inheritdoc />
        public override global::Vectara.PipelineTrigger Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PipelineTriggerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PipelineTriggerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.PipelineTriggerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CronTriggerConfiguration? cron = default;
            if (discriminator?.Type == global::Vectara.PipelineTriggerDiscriminatorType.Cron)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CronTriggerConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CronTriggerConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CronTriggerConfiguration)}");
                cron = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.IntervalTriggerConfiguration? interval = default;
            if (discriminator?.Type == global::Vectara.PipelineTriggerDiscriminatorType.Interval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.IntervalTriggerConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.IntervalTriggerConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.IntervalTriggerConfiguration)}");
                interval = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ManualTriggerConfiguration? manual = default;
            if (discriminator?.Type == global::Vectara.PipelineTriggerDiscriminatorType.Manual)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ManualTriggerConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ManualTriggerConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ManualTriggerConfiguration)}");
                manual = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.PipelineTrigger(
                discriminator?.Type,
                cron,

                interval,

                manual
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.PipelineTrigger value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCron)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CronTriggerConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CronTriggerConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CronTriggerConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cron!, typeInfo);
            }
            else if (value.IsInterval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.IntervalTriggerConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.IntervalTriggerConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.IntervalTriggerConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Interval!, typeInfo);
            }
            else if (value.IsManual)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ManualTriggerConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ManualTriggerConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ManualTriggerConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Manual!, typeInfo);
            }
        }
    }
}