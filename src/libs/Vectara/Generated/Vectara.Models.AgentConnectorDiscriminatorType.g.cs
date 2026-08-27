
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentConnectorDiscriminatorType
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
    public static class AgentConnectorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConnectorDiscriminatorType value)
        {
            return value switch
            {
                AgentConnectorDiscriminatorType.Gchat => "gchat",
                AgentConnectorDiscriminatorType.Slack => "slack",
                AgentConnectorDiscriminatorType.Widget => "widget",
                AgentConnectorDiscriminatorType.Zoom => "zoom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConnectorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gchat" => AgentConnectorDiscriminatorType.Gchat,
                "slack" => AgentConnectorDiscriminatorType.Slack,
                "widget" => AgentConnectorDiscriminatorType.Widget,
                "zoom" => AgentConnectorDiscriminatorType.Zoom,
                _ => null,
            };
        }
    }
}