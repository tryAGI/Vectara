
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public enum TestLambdaToolStreamedResponseDiscriminatorType
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
    public static class TestLambdaToolStreamedResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestLambdaToolStreamedResponseDiscriminatorType value)
        {
            return value switch
            {
                TestLambdaToolStreamedResponseDiscriminatorType.Heartbeat => "heartbeat",
                TestLambdaToolStreamedResponseDiscriminatorType.Result => "result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestLambdaToolStreamedResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "heartbeat" => TestLambdaToolStreamedResponseDiscriminatorType.Heartbeat,
                "result" => TestLambdaToolStreamedResponseDiscriminatorType.Result,
                _ => null,
            };
        }
    }
}