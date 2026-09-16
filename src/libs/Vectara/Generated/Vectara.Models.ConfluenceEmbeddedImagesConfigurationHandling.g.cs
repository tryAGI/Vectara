
#nullable enable

namespace Vectara
{
    /// <summary>
    /// `inline` fetches each image attached to the page or to one of its ancestors using the source's<br/>
    /// credentials and embeds it in the page so it is indexed with the page. Images attached to any other<br/>
    /// page, images hosted outside the instance, images larger than `max_bytes`, and images that fail to<br/>
    /// download are left as Confluence URLs; a failed image never fails the page. `omit` leaves every image<br/>
    /// as a Confluence URL, which is not fetched and so is not indexed.<br/>
    /// Default Value: inline
    /// </summary>
    public enum ConfluenceEmbeddedImagesConfigurationHandling
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
        /// <summary>
        ///
        /// </summary>
        Omit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfluenceEmbeddedImagesConfigurationHandlingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfluenceEmbeddedImagesConfigurationHandling value)
        {
            return value switch
            {
                ConfluenceEmbeddedImagesConfigurationHandling.Inline => "inline",
                ConfluenceEmbeddedImagesConfigurationHandling.Omit => "omit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfluenceEmbeddedImagesConfigurationHandling? ToEnum(string value)
        {
            return value switch
            {
                "inline" => ConfluenceEmbeddedImagesConfigurationHandling.Inline,
                "omit" => ConfluenceEmbeddedImagesConfigurationHandling.Omit,
                _ => null,
            };
        }
    }
}