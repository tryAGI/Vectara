
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The current operational status of the pipeline.
    /// </summary>
    public enum PipelineStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineStatus value)
        {
            return value switch
            {
                PipelineStatus.Initializing => "initializing",
                PipelineStatus.Active => "active",
                PipelineStatus.Paused => "paused",
                PipelineStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineStatus? ToEnum(string value)
        {
            return value switch
            {
                "initializing" => PipelineStatus.Initializing,
                "active" => PipelineStatus.Active,
                "paused" => PipelineStatus.Paused,
                "error" => PipelineStatus.Error,
                _ => null,
            };
        }
    }
}