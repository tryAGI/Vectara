#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class RuleTargetsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.RuleTargets>
    {
        /// <inheritdoc />
        public override global::Vectara.RuleTargets Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.RuleTargetsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.RuleTargetsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.RuleTargetsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.SingleRuleTargets? single = default;
            if (discriminator?.Type == global::Vectara.RuleTargetsDiscriminatorType.Single)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SingleRuleTargets), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SingleRuleTargets> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SingleRuleTargets)}");
                single = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.WeightedRuleTargets? weighted = default;
            if (discriminator?.Type == global::Vectara.RuleTargetsDiscriminatorType.Weighted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WeightedRuleTargets), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WeightedRuleTargets> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.WeightedRuleTargets)}");
                weighted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.RuleTargets(
                discriminator?.Type,
                single,

                weighted
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.RuleTargets value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSingle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SingleRuleTargets), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SingleRuleTargets?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SingleRuleTargets).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Single!, typeInfo);
            }
            else if (value.IsWeighted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.WeightedRuleTargets), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.WeightedRuleTargets?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.WeightedRuleTargets).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Weighted!, typeInfo);
            }
        }
    }
}