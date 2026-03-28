
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The operational status of the customer account.<br/>
    /// Example: ACTIVE
    /// </summary>
    public enum CustomerConfigurationOperationalStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        MarkedForDeletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerConfigurationOperationalStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerConfigurationOperationalStatus value)
        {
            return value switch
            {
                CustomerConfigurationOperationalStatus.Active => "ACTIVE",
                CustomerConfigurationOperationalStatus.Deleted => "DELETED",
                CustomerConfigurationOperationalStatus.Expired => "EXPIRED",
                CustomerConfigurationOperationalStatus.MarkedForDeletion => "MARKED_FOR_DELETION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerConfigurationOperationalStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => CustomerConfigurationOperationalStatus.Active,
                "DELETED" => CustomerConfigurationOperationalStatus.Deleted,
                "EXPIRED" => CustomerConfigurationOperationalStatus.Expired,
                "MARKED_FOR_DELETION" => CustomerConfigurationOperationalStatus.MarkedForDeletion,
                _ => null,
            };
        }
    }
}