
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineTransformDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineTransformDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineTransformDiscriminatorType value)
        {
            return value switch
            {
                PipelineTransformDiscriminatorType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineTransformDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => PipelineTransformDiscriminatorType.Agent,
                _ => null,
            };
        }
    }
}