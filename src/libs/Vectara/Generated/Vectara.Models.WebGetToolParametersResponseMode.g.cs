
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How to return the response body. `content` (default) returns the body inline in `content`, truncated to `head_lines`/`tail_lines`/`max_content_bytes`. `artifact` streams the body into a session artifact and returns its id in `artifact_id`; `content` is then absent.<br/>
    /// Default Value: content
    /// </summary>
    public enum WebGetToolParametersResponseMode
    {
        /// <summary>
        ///
        /// </summary>
        Artifact,
        /// <summary>
        ///
        /// </summary>
        Content,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebGetToolParametersResponseModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebGetToolParametersResponseMode value)
        {
            return value switch
            {
                WebGetToolParametersResponseMode.Artifact => "artifact",
                WebGetToolParametersResponseMode.Content => "content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebGetToolParametersResponseMode? ToEnum(string value)
        {
            return value switch
            {
                "artifact" => WebGetToolParametersResponseMode.Artifact,
                "content" => WebGetToolParametersResponseMode.Content,
                _ => null,
            };
        }
    }
}