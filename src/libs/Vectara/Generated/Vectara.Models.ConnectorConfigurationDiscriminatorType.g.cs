
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
        Gchat,
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
                ConnectorConfigurationDiscriminatorType.Gchat => "gchat",
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
                "gchat" => ConnectorConfigurationDiscriminatorType.Gchat,
                "slack" => ConnectorConfigurationDiscriminatorType.Slack,
                _ => null,
            };
        }
    }
}