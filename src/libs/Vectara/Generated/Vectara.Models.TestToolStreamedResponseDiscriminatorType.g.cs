
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public enum TestToolStreamedResponseDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Heartbeat,
        /// <summary>
        ///
        /// </summary>
        Result,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestToolStreamedResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestToolStreamedResponseDiscriminatorType value)
        {
            return value switch
            {
                TestToolStreamedResponseDiscriminatorType.Heartbeat => "heartbeat",
                TestToolStreamedResponseDiscriminatorType.Result => "result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestToolStreamedResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "heartbeat" => TestToolStreamedResponseDiscriminatorType.Heartbeat,
                "result" => TestToolStreamedResponseDiscriminatorType.Result,
                _ => null,
            };
        }
    }
}