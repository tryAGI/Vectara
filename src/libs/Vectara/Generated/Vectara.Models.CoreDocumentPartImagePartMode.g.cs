
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How this part is matched at query time.<br/>
    /// - `text` — matched on its `text`, like any text part.<br/>
    /// - `image` — matched by visual similarity against image queries for the image referenced by `image_id`; its `text`, if set, also makes the part findable through keyword search.<br/>
    /// - `image_and_text` — matched against both the referenced image and its `text` together.<br/>
    /// When omitted, the mode is inferred. On a corpus that does not support image queries, a part is always `text`. Otherwise it defaults to `image` when it references an image and has no `text`, `image_and_text` when it references an image and has `text`, and `text` otherwise.<br/>
    /// Example: image_and_text
    /// </summary>
    public enum CoreDocumentPartImagePartMode
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        ImageAndText,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CoreDocumentPartImagePartModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CoreDocumentPartImagePartMode value)
        {
            return value switch
            {
                CoreDocumentPartImagePartMode.Image => "image",
                CoreDocumentPartImagePartMode.ImageAndText => "image_and_text",
                CoreDocumentPartImagePartMode.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CoreDocumentPartImagePartMode? ToEnum(string value)
        {
            return value switch
            {
                "image" => CoreDocumentPartImagePartMode.Image,
                "image_and_text" => CoreDocumentPartImagePartMode.ImageAndText,
                "text" => CoreDocumentPartImagePartMode.Text,
                _ => null,
            };
        }
    }
}