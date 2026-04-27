
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The type of connector.<br/>
    /// Example: slack
    /// </summary>
    public enum AgentConnectorType
    {
        /// <summary>
        /// 
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConnectorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConnectorType value)
        {
            return value switch
            {
                AgentConnectorType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConnectorType? ToEnum(string value)
        {
            return value switch
            {
                "slack" => AgentConnectorType.Slack,
                _ => null,
            };
        }
    }
}