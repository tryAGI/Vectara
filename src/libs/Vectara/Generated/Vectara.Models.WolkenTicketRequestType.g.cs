
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A Wolken ServiceDesk request type.
    /// </summary>
    public enum WolkenTicketRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Incident,
        /// <summary>
        ///
        /// </summary>
        ServiceRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WolkenTicketRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WolkenTicketRequestType value)
        {
            return value switch
            {
                WolkenTicketRequestType.Incident => "incident",
                WolkenTicketRequestType.ServiceRequest => "service_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WolkenTicketRequestType? ToEnum(string value)
        {
            return value switch
            {
                "incident" => WolkenTicketRequestType.Incident,
                "service_request" => WolkenTicketRequestType.ServiceRequest,
                _ => null,
            };
        }
    }
}