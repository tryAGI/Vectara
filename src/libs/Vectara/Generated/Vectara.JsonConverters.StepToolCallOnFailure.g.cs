#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class StepToolCallOnFailureJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.StepToolCallOnFailure>
    {
        /// <inheritdoc />
        public override global::Vectara.StepToolCallOnFailure Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepToolCallOnFailureDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepToolCallOnFailureDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StepToolCallOnFailureDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.StepToolCallEndTurn? endTurn = default;
            if (discriminator?.Type == global::Vectara.StepToolCallOnFailureDiscriminatorType.EndTurn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepToolCallEndTurn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepToolCallEndTurn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StepToolCallEndTurn)}");
                endTurn = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StepToolCallContinue? @continue = default;
            if (discriminator?.Type == global::Vectara.StepToolCallOnFailureDiscriminatorType.Continue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepToolCallContinue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepToolCallContinue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StepToolCallContinue)}");
                @continue = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StepToolCallNextStep? nextStep = default;
            if (discriminator?.Type == global::Vectara.StepToolCallOnFailureDiscriminatorType.NextStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepToolCallNextStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepToolCallNextStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StepToolCallNextStep)}");
                nextStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.StepToolCallOnFailure(
                discriminator?.Type,
                endTurn,

                @continue,

                nextStep
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.StepToolCallOnFailure value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEndTurn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepToolCallEndTurn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepToolCallEndTurn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StepToolCallEndTurn).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEndTurn(), typeInfo);
            }
            else if (value.IsContinue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepToolCallContinue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepToolCallContinue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StepToolCallContinue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContinue(), typeInfo);
            }
            else if (value.IsNextStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StepToolCallNextStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StepToolCallNextStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StepToolCallNextStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNextStep(), typeInfo);
            }
        }
    }
}