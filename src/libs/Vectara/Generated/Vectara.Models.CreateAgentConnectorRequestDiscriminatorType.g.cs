
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentConnectorRequestDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Gchat,
        /// <summary>
        ///
        /// </summary>
        Slack,
        /// <summary>
        ///
        /// </summary>
        Widget,
        /// <summary>
        ///
        /// </summary>
        Zoom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgentConnectorRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentConnectorRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateAgentConnectorRequestDiscriminatorType.Gchat => "gchat",
                CreateAgentConnectorRequestDiscriminatorType.Slack => "slack",
                CreateAgentConnectorRequestDiscriminatorType.Widget => "widget",
                CreateAgentConnectorRequestDiscriminatorType.Zoom => "zoom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentConnectorRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gchat" => CreateAgentConnectorRequestDiscriminatorType.Gchat,
                "slack" => CreateAgentConnectorRequestDiscriminatorType.Slack,
                "widget" => CreateAgentConnectorRequestDiscriminatorType.Widget,
                "zoom" => CreateAgentConnectorRequestDiscriminatorType.Zoom,
                _ => null,
            };
        }
    }
}