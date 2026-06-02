
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorConfigurationDiscriminatorType
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
    public static class CreateConnectorConfigurationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorConfigurationDiscriminatorType value)
        {
            return value switch
            {
                CreateConnectorConfigurationDiscriminatorType.Gchat => "gchat",
                CreateConnectorConfigurationDiscriminatorType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorConfigurationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gchat" => CreateConnectorConfigurationDiscriminatorType.Gchat,
                "slack" => CreateConnectorConfigurationDiscriminatorType.Slack,
                _ => null,
            };
        }
    }
}