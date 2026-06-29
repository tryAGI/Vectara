
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The templating engine used to render the instruction's template.<br/>
    /// - `velocity`: render the template with the Velocity engine, substituting agent, session, and tool variables.<br/>
    /// - `text`: use the template verbatim as plain text, with no variable substitution.<br/>
    /// Default Value: velocity<br/>
    /// Example: velocity
    /// </summary>
    public enum TemplateType
    {
        /// <summary>
        /// use the template verbatim as plain text, with no variable substitution.
        /// </summary>
        Text,
        /// <summary>
        /// render the template with the Velocity engine, substituting agent, session, and tool variables.
        /// </summary>
        Velocity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateType value)
        {
            return value switch
            {
                TemplateType.Text => "text",
                TemplateType.Velocity => "velocity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateType? ToEnum(string value)
        {
            return value switch
            {
                "text" => TemplateType.Text,
                "velocity" => TemplateType.Velocity,
                _ => null,
            };
        }
    }
}