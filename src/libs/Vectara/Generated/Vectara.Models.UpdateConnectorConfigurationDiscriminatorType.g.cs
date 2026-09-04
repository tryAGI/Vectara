
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConnectorConfigurationDiscriminatorType
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
    public static class UpdateConnectorConfigurationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConnectorConfigurationDiscriminatorType value)
        {
            return value switch
            {
                UpdateConnectorConfigurationDiscriminatorType.Gchat => "gchat",
                UpdateConnectorConfigurationDiscriminatorType.Slack => "slack",
                UpdateConnectorConfigurationDiscriminatorType.Widget => "widget",
                UpdateConnectorConfigurationDiscriminatorType.Zoom => "zoom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConnectorConfigurationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gchat" => UpdateConnectorConfigurationDiscriminatorType.Gchat,
                "slack" => UpdateConnectorConfigurationDiscriminatorType.Slack,
                "widget" => UpdateConnectorConfigurationDiscriminatorType.Widget,
                "zoom" => UpdateConnectorConfigurationDiscriminatorType.Zoom,
                _ => null,
            };
        }
    }
}