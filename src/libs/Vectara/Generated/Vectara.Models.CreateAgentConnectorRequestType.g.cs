
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The type of connector.<br/>
    /// Example: slack
    /// </summary>
    public enum CreateAgentConnectorRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgentConnectorRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentConnectorRequestType value)
        {
            return value switch
            {
                CreateAgentConnectorRequestType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentConnectorRequestType? ToEnum(string value)
        {
            return value switch
            {
                "slack" => CreateAgentConnectorRequestType.Slack,
                _ => null,
            };
        }
    }
}