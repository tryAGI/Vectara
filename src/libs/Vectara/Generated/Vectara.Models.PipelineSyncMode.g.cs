
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How the pipeline syncs data from the source.<br/>
    /// - `incremental`: Only process records that are new, changed, or deleted since the last watermark.<br/>
    /// - `full_refresh`: Process all records the source lists on each run. Source-reported deletions are not processed.<br/>
    /// Default Value: incremental
    /// </summary>
    public enum PipelineSyncMode
    {
        /// <summary>
        /// Process all records the source lists on each run. Source-reported deletions are not processed.
        /// </summary>
        FullRefresh,
        /// <summary>
        /// Only process records that are new, changed, or deleted since the last watermark.
        /// </summary>
        Incremental,
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
                PipelineSyncMode.FullRefresh => "full_refresh",
                PipelineSyncMode.Incremental => "incremental",
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
                "full_refresh" => PipelineSyncMode.FullRefresh,
                "incremental" => PipelineSyncMode.Incremental,
                _ => null,
            };
        }
    }
}