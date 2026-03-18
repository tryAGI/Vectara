#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class UpdateArtifactReadToolConfigurationRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.UpdateArtifactReadToolConfigurationRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.UpdateArtifactReadToolConfigurationRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Vectara.UpdateArtifactReadToolConfigurationRequest(
                value1
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.UpdateArtifactReadToolConfigurationRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
        }
    }
}