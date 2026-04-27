
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConnectorConfigurationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectorConfigurationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectorConfigurationDiscriminatorType value)
        {
            return value switch
            {
                ConnectorConfigurationDiscriminatorType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectorConfigurationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "slack" => ConnectorConfigurationDiscriminatorType.Slack,
                _ => null,
            };
        }
    }
}