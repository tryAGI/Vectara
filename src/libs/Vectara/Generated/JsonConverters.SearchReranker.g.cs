#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class SearchRerankerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.SearchReranker>
    {
        /// <inheritdoc />
        public override global::Vectara.SearchReranker Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SearchRerankerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SearchRerankerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SearchRerankerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.CustomerSpecificReranker? customerSpecific = default;
            if (discriminator?.Type == global::Vectara.SearchRerankerDiscriminatorType.CustomerReranker)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CustomerSpecificReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CustomerSpecificReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.CustomerSpecificReranker)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.UserFunctionReranker? userFunction = default;
            if (discriminator?.Type == global::Vectara.SearchRerankerDiscriminatorType.Userfn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UserFunctionReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UserFunctionReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.UserFunctionReranker)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.MMRReranker? mR = default;
            if (discriminator?.Type == global::Vectara.SearchRerankerDiscriminatorType.Mmr)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MMRReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MMRReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.MMRReranker)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.ChainReranker? chain = default;
            if (discriminator?.Type == global::Vectara.SearchRerankerDiscriminatorType.Chain)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ChainReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ChainReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.ChainReranker)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.NoneReranker? none = default;
            if (discriminator?.Type == global::Vectara.SearchRerankerDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.NoneReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.NoneReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.NoneReranker)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Vectara.SearchReranker(
                discriminator?.Type,
                customerSpecific,
                userFunction,
                mR,
                chain,
                none
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.SearchReranker value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCustomerSpecific)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.CustomerSpecificReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.CustomerSpecificReranker?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.CustomerSpecificReranker).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomerSpecific, typeInfo);
            }
            else if (value.IsUserFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.UserFunctionReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.UserFunctionReranker?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.UserFunctionReranker).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserFunction, typeInfo);
            }
            else if (value.IsMR)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MMRReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MMRReranker?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.MMRReranker).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MR, typeInfo);
            }
            else if (value.IsChain)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.ChainReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.ChainReranker?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.ChainReranker).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chain, typeInfo);
            }
            else if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.NoneReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.NoneReranker?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.NoneReranker).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None, typeInfo);
            }
        }
    }
}