
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How the pipeline syncs data from the source.<br/>
    /// - `incremental`: Only process new or changed records since the last watermark.<br/>
    /// - `full_refresh`: Process all records from the source on each run.<br/>
    /// Default Value: incremental
    /// </summary>
    public enum PipelineSyncMode
    {
        /// <summary>
        /// Only process new or changed records since the last watermark.
        /// </summary>
        Incremental,
        /// <summary>
        /// Process all records from the source on each run.
        /// </summary>
        FullRefresh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineSyncModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineSyncMode value)
        {
            return value switch
            {
                PipelineSyncMode.Incremental => "incremental",
                PipelineSyncMode.FullRefresh => "full_refresh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineSyncMode? ToEnum(string value)
        {
            return value switch
            {
                "incremental" => PipelineSyncMode.Incremental,
                "full_refresh" => PipelineSyncMode.FullRefresh,
                _ => null,
            };
        }
    }
}