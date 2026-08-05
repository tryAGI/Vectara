#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class JsonSchemaDefinitionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.JsonSchemaDefinition>
    {
        /// <inheritdoc />
        public override global::Vectara.JsonSchemaDefinition Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.JsonSchemaDefinitionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.JsonSchemaDefinitionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.JsonSchemaDefinitionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.JsonSchemaObject? objectValue = default;
            if (discriminator?.Type == global::Vectara.JsonSchemaDefinitionDiscriminatorType.Object)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.JsonSchemaObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.JsonSchemaObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.JsonSchemaObject)}");
                objectValue = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.JsonSchemaValue? array = default;
            if (discriminator?.Type == global::Vectara.JsonSchemaDefinitionDiscriminatorType.Array)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.JsonSchemaValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.JsonSchemaValue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.JsonSchemaValue)}");
                array = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.JsonSchemaDefinition(
                discriminator?.Type,
                objectValue,

                array
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.JsonSchemaDefinition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsObjectValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.JsonSchemaObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.JsonSchemaObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.JsonSchemaObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ObjectValue!.Value, typeInfo);
            }
            else if (value.IsArray)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.JsonSchemaValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.JsonSchemaValue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.JsonSchemaValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Array!.Value, typeInfo);
            }
        }
    }
}