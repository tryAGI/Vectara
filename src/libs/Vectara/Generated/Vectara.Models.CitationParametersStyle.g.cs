
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The citation style to be used in summary. Can be one of: * `numeric` - Citations formatted as simple numerals: \[1\], \[2\] ... * `none` - Citations removed from text. * `html` - Citation formatted as a URL like `&lt;a href="url_pattern"&gt;text_pattern&lt;/a&gt;`. * `markdown` - Formatted as `[text_pattern](url_pattern)`.
    /// </summary>
    public enum CitationParametersStyle
    {
        /// <summary>
        /// * `numeric` - Citations formatted as simple numerals: \[1\], \[2\] ... * `none` - Citations removed from text. * `html` - Citation formatted as a URL like `&lt;a href="url_pattern"&gt;text_pattern&lt;/a&gt;`. * `markdown` - Formatted as `[text_pattern](url_pattern)`.
        /// </summary>
        None,
        /// <summary>
        /// * `numeric` - Citations formatted as simple numerals: \[1\], \[2\] ... * `none` - Citations removed from text. * `html` - Citation formatted as a URL like `&lt;a href="url_pattern"&gt;text_pattern&lt;/a&gt;`. * `markdown` - Formatted as `[text_pattern](url_pattern)`.
        /// </summary>
        Numeric,
        /// <summary>
        /// * `numeric` - Citations formatted as simple numerals: \[1\], \[2\] ... * `none` - Citations removed from text. * `html` - Citation formatted as a URL like `&lt;a href="url_pattern"&gt;text_pattern&lt;/a&gt;`. * `markdown` - Formatted as `[text_pattern](url_pattern)`.
        /// </summary>
        Html,
        /// <summary>
        /// * `numeric` - Citations formatted as simple numerals: \[1\], \[2\] ... * `none` - Citations removed from text. * `html` - Citation formatted as a URL like `&lt;a href="url_pattern"&gt;text_pattern&lt;/a&gt;`. * `markdown` - Formatted as `[text_pattern](url_pattern)`.
        /// </summary>
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationParametersStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationParametersStyle value)
        {
            return value switch
            {
                CitationParametersStyle.None => "none",
                CitationParametersStyle.Numeric => "numeric",
                CitationParametersStyle.Html => "html",
                CitationParametersStyle.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationParametersStyle? ToEnum(string value)
        {
            return value switch
            {
                "none" => CitationParametersStyle.None,
                "numeric" => CitationParametersStyle.Numeric,
                "html" => CitationParametersStyle.Html,
                "markdown" => CitationParametersStyle.Markdown,
                _ => null,
            };
        }
    }
}