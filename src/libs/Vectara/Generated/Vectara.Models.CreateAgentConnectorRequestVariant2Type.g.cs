
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Optional confirmation of the connector type. When supplied it must match `configuration.type`; when omitted the type is taken from `configuration.type`.<br/>
    /// Example: slack
    /// </summary>
    public enum CreateAgentConnectorRequestVariant2Type
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
    public static class CreateAgentConnectorRequestVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentConnectorRequestVariant2Type value)
        {
            return value switch
            {
                CreateAgentConnectorRequestVariant2Type.Gchat => "gchat",
                CreateAgentConnectorRequestVariant2Type.Slack => "slack",
                CreateAgentConnectorRequestVariant2Type.Widget => "widget",
                CreateAgentConnectorRequestVariant2Type.Zoom => "zoom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentConnectorRequestVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "gchat" => CreateAgentConnectorRequestVariant2Type.Gchat,
                "slack" => CreateAgentConnectorRequestVariant2Type.Slack,
                "widget" => CreateAgentConnectorRequestVariant2Type.Widget,
                "zoom" => CreateAgentConnectorRequestVariant2Type.Zoom,
                _ => null,
            };
        }
    }
}