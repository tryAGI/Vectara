
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndUserAgentStreamedResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentOutput,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        StreamingAgentOutput,
        /// <summary>
        /// 
        /// </summary>
        StreamingAgentOutputEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserAgentStreamedResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserAgentStreamedResponseDiscriminatorType value)
        {
            return value switch
            {
                EndUserAgentStreamedResponseDiscriminatorType.AgentOutput => "agent_output",
                EndUserAgentStreamedResponseDiscriminatorType.Error => "error",
                EndUserAgentStreamedResponseDiscriminatorType.InputMessage => "input_message",
                EndUserAgentStreamedResponseDiscriminatorType.StreamingAgentOutput => "streaming_agent_output",
                EndUserAgentStreamedResponseDiscriminatorType.StreamingAgentOutputEnd => "streaming_agent_output_end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserAgentStreamedResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_output" => EndUserAgentStreamedResponseDiscriminatorType.AgentOutput,
                "error" => EndUserAgentStreamedResponseDiscriminatorType.Error,
                "input_message" => EndUserAgentStreamedResponseDiscriminatorType.InputMessage,
                "streaming_agent_output" => EndUserAgentStreamedResponseDiscriminatorType.StreamingAgentOutput,
                "streaming_agent_output_end" => EndUserAgentStreamedResponseDiscriminatorType.StreamingAgentOutputEnd,
                _ => null,
            };
        }
    }
}