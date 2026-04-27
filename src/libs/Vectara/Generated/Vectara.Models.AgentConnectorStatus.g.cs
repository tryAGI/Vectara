
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The current status of the connector.<br/>
    /// Default Value: active<br/>
    /// Example: active
    /// </summary>
    public enum AgentConnectorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConnectorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConnectorStatus value)
        {
            return value switch
            {
                AgentConnectorStatus.Active => "active",
                AgentConnectorStatus.Error => "error",
                AgentConnectorStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConnectorStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AgentConnectorStatus.Active,
                "error" => AgentConnectorStatus.Error,
                "inactive" => AgentConnectorStatus.Inactive,
                _ => null,
            };
        }
    }
}