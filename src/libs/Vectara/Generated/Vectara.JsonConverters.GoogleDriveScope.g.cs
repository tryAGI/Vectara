#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara.JsonConverters
{
    /// <inheritdoc />
    public class GoogleDriveScopeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vectara.GoogleDriveScope>
    {
        /// <inheritdoc />
        public override global::Vectara.GoogleDriveScope Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.GoogleDriveScopeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.GoogleDriveScopeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.GoogleDriveScopeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vectara.SharedGoogleDriveScope? shared = default;
            if (discriminator?.Type == global::Vectara.GoogleDriveScopeDiscriminatorType.Shared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SharedGoogleDriveScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SharedGoogleDriveScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.SharedGoogleDriveScope)}");
                shared = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vectara.MyGoogleDriveScope? myDrive = default;
            if (discriminator?.Type == global::Vectara.GoogleDriveScopeDiscriminatorType.MyDrive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MyGoogleDriveScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MyGoogleDriveScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vectara.MyGoogleDriveScope)}");
                myDrive = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vectara.GoogleDriveScope(
                discriminator?.Type,
                shared,

                myDrive
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vectara.GoogleDriveScope value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.SharedGoogleDriveScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.SharedGoogleDriveScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.SharedGoogleDriveScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared!, typeInfo);
            }
            else if (value.IsMyDrive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vectara.MyGoogleDriveScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vectara.MyGoogleDriveScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vectara.MyGoogleDriveScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MyDrive!, typeInfo);
            }
        }
    }
}