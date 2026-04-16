#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class PipelineVerificationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.PipelineVerification>
    {
        /// <inheritdoc />
        public override global::Vectara.PipelineVerification Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.PipelineVerificationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.PipelineVerificationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.PipelineVerificationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.ConditionVerification? condition = default;
            if (discriminator?.Type == global::Vectara.PipelineVerificationDiscriminatorType.Condition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ConditionVerification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ConditionVerification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ConditionVerification)}");
                condition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.AgentVerification? agent = default;
            if (discriminator?.Type == global::Vectara.PipelineVerificationDiscriminatorType.Agent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentVerification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentVerification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentVerification)}");
                agent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.PipelineVerification(
                discriminator?.Type,
                condition,

                agent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.PipelineVerification value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCondition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ConditionVerification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ConditionVerification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ConditionVerification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Condition!, typeInfo);
            }
            else if (value.IsAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentVerification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentVerification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentVerification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent!, typeInfo);
            }
        }
    }
}