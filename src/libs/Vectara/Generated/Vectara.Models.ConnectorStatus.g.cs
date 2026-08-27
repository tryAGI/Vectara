
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The current status of the connector.<br/>
    /// Default Value: active<br/>
    /// Example: active
    /// </summary>
    public enum ConnectorStatus
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
    public static class ConnectorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectorStatus value)
        {
            return value switch
            {
                ConnectorStatus.Active => "active",
                ConnectorStatus.Error => "error",
                ConnectorStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectorStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ConnectorStatus.Active,
                "error" => ConnectorStatus.Error,
                "inactive" => ConnectorStatus.Inactive,
                _ => null,
            };
        }
    }
}