
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
        Active,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        Paused,
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
                PipelineStatus.Active => "active",
                PipelineStatus.Error => "error",
                PipelineStatus.Initializing => "initializing",
                PipelineStatus.Paused => "paused",
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
                "active" => PipelineStatus.Active,
                "error" => PipelineStatus.Error,
                "initializing" => PipelineStatus.Initializing,
                "paused" => PipelineStatus.Paused,
                _ => null,
            };
        }
    }
}