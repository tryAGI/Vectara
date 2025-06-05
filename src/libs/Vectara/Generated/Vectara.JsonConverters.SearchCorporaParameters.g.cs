#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class SearchCorporaParametersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.SearchCorporaParameters>
    {
        /// <inheritdoc />
        public override global::Vectara.SearchCorporaParameters Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Vectara.SearchCorporaParametersVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SearchCorporaParametersVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SearchCorporaParametersVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SearchCorporaParametersVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Vectara.SearchParameters? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SearchParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SearchParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SearchParameters).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Vectara.SearchCorporaParameters(
                value1,
                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SearchCorporaParametersVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SearchCorporaParametersVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SearchCorporaParametersVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SearchParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SearchParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SearchParameters).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.SearchCorporaParameters value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SearchCorporaParametersVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SearchCorporaParametersVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SearchCorporaParametersVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SearchParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SearchParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SearchParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}