#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class IndividualSearchResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.IndividualSearchResult>
    {
        /// <inheritdoc />
        public override global::Vectara.IndividualSearchResult Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.IndividualSearchResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.IndividualSearchResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.IndividualSearchResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.TextSearchResult? text = default;
            if (discriminator?.ResultType == global::Vectara.IndividualSearchResultDiscriminatorResultType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TextSearchResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TextSearchResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.TextSearchResult)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ImageSearchResult? image = default;
            if (discriminator?.ResultType == global::Vectara.IndividualSearchResultDiscriminatorResultType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageSearchResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageSearchResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ImageSearchResult)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.IndividualSearchResult(
                discriminator?.ResultType,
                text,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.IndividualSearchResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.TextSearchResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.TextSearchResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.TextSearchResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!.Value, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ImageSearchResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ImageSearchResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ImageSearchResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!.Value, typeInfo);
            }
        }
    }
}