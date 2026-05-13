#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class PipelineRunEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.PipelineRunEvent>
    {
        /// <inheritdoc />
        public override global::Vectara.PipelineRunEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PipelineRunEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PipelineRunEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.PipelineRunEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.RunStartedEvent? runStarted = default;
            if (discriminator?.Type == global::Vectara.PipelineRunEventDiscriminatorType.RunStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RunStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RunStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.RunStartedEvent)}");
                runStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.RunCompletedEvent? runCompleted = default;
            if (discriminator?.Type == global::Vectara.PipelineRunEventDiscriminatorType.RunCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RunCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RunCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.RunCompletedEvent)}");
                runCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.RecordProcessingEvent? recordProcessing = default;
            if (discriminator?.Type == global::Vectara.PipelineRunEventDiscriminatorType.RecordProcessing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RecordProcessingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RecordProcessingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.RecordProcessingEvent)}");
                recordProcessing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WatermarkAdvancedEvent? watermarkAdvanced = default;
            if (discriminator?.Type == global::Vectara.PipelineRunEventDiscriminatorType.WatermarkAdvanced)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WatermarkAdvancedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WatermarkAdvancedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WatermarkAdvancedEvent)}");
                watermarkAdvanced = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.PipelineRunEvent(
                discriminator?.Type,
                runStarted,

                runCompleted,

                recordProcessing,

                watermarkAdvanced
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.PipelineRunEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RunStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RunStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.RunStartedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStarted!.Value, typeInfo);
            }
            else if (value.IsRunCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RunCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RunCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.RunCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunCompleted!.Value, typeInfo);
            }
            else if (value.IsRecordProcessing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RecordProcessingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RecordProcessingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.RecordProcessingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RecordProcessing!.Value, typeInfo);
            }
            else if (value.IsWatermarkAdvanced)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WatermarkAdvancedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WatermarkAdvancedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WatermarkAdvancedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WatermarkAdvanced!.Value, typeInfo);
            }
        }
    }
}