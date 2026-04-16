#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class AgentStepReminderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentStepReminder>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentStepReminder Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentStepReminderDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentStepReminderDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentStepReminderDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.TemplatedReminder? templated = default;
            if (discriminator?.Type == global::Vectara.AgentStepReminderDiscriminatorType.Templated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TemplatedReminder), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TemplatedReminder> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.TemplatedReminder)}");
                templated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.GlossaryExpansionReminder? glossaryExpansion = default;
            if (discriminator?.Type == global::Vectara.AgentStepReminderDiscriminatorType.GlossaryExpansion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GlossaryExpansionReminder), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GlossaryExpansionReminder> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GlossaryExpansionReminder)}");
                glossaryExpansion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AgentStepReminder(
                discriminator?.Type,
                templated,

                glossaryExpansion
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AgentStepReminder value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTemplated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TemplatedReminder), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TemplatedReminder?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.TemplatedReminder).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Templated!, typeInfo);
            }
            else if (value.IsGlossaryExpansion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GlossaryExpansionReminder), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GlossaryExpansionReminder?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.GlossaryExpansionReminder).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GlossaryExpansion!, typeInfo);
            }
        }
    }
}