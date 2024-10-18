#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class CreateDocumentRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.CreateDocumentRequest>
    {
        /// <inheritdoc />
        public override global::Vectara.CreateDocumentRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CreateDocumentRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CreateDocumentRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CreateDocumentRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CoreDocument? core = default;
            if (discriminator?.Type == global::Vectara.CreateDocumentRequestDiscriminatorType.Core)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CoreDocument), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CoreDocument> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CoreDocument)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.StructuredDocument? structured = default;
            if (discriminator?.Type == global::Vectara.CreateDocumentRequestDiscriminatorType.Structured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredDocument), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredDocument> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.StructuredDocument)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Vectara.CreateDocumentRequest(
                discriminator?.Type,
                core,
                structured
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.CreateDocumentRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CoreDocument), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CoreDocument?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CoreDocument).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Core, typeInfo);
            }
            else if (value.IsStructured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.StructuredDocument), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.StructuredDocument?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.StructuredDocument).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Structured, typeInfo);
            }
        }
    }
}