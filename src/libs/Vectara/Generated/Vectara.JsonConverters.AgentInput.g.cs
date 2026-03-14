#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class AgentInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.AgentInput>
    {
        /// <inheritdoc />
        public override global::Vectara.AgentInput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentInputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentInputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentInputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.AgentTextInput? text = default;
            if (discriminator?.Type == global::Vectara.AgentInputDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentTextInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentTextInput)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.AgentSkillInput? skill = default;
            if (discriminator?.Type == global::Vectara.AgentInputDiscriminatorType.Skill)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentSkillInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentSkillInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.AgentSkillInput)}");
                skill = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.AgentInput(
                discriminator?.Type,
                text,

                skill
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.AgentInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentTextInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentTextInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsSkill)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.AgentSkillInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.AgentSkillInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.AgentSkillInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Skill, typeInfo);
            }
        }
    }
}