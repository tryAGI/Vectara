#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class ScheduleConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.ScheduleConfiguration>
    {
        /// <inheritdoc />
        public override global::Vectara.ScheduleConfiguration Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Vectara.IntervalScheduleConfiguration? interval = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.IntervalScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.IntervalScheduleConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.IntervalScheduleConfiguration).Name}");
                interval = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Vectara.CronScheduleConfiguration? cron = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CronScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CronScheduleConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CronScheduleConfiguration).Name}");
                cron = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Vectara.ScheduleConfiguration(
                interval,

                cron
                );

            if (interval != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.IntervalScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.IntervalScheduleConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.IntervalScheduleConfiguration).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (cron != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CronScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CronScheduleConfiguration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CronScheduleConfiguration).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.ScheduleConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInterval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.IntervalScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.IntervalScheduleConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.IntervalScheduleConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Interval, typeInfo);
            }
            else if (value.IsCron)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CronScheduleConfiguration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CronScheduleConfiguration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CronScheduleConfiguration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cron, typeInfo);
            }
        }
    }
}