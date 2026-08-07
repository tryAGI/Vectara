
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The stage of the rebuild that is currently running. A rebuild scans the corpus and imports it into the new indices, then cuts the corpus over to them and replays everything written while it ran. New phases may be added; treat unrecognized values as opaque.
    /// </summary>
    public enum JobProgressPhase
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        CuttingOver,
        /// <summary>
        /// 
        /// </summary>
        Importing,
        /// <summary>
        /// 
        /// </summary>
        Preparing,
        /// <summary>
        /// 
        /// </summary>
        ReplayingJournals,
        /// <summary>
        /// 
        /// </summary>
        Scanning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobProgressPhaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobProgressPhase value)
        {
            return value switch
            {
                JobProgressPhase.Completed => "completed",
                JobProgressPhase.CuttingOver => "cutting_over",
                JobProgressPhase.Importing => "importing",
                JobProgressPhase.Preparing => "preparing",
                JobProgressPhase.ReplayingJournals => "replaying_journals",
                JobProgressPhase.Scanning => "scanning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobProgressPhase? ToEnum(string value)
        {
            return value switch
            {
                "completed" => JobProgressPhase.Completed,
                "cutting_over" => JobProgressPhase.CuttingOver,
                "importing" => JobProgressPhase.Importing,
                "preparing" => JobProgressPhase.Preparing,
                "replaying_journals" => JobProgressPhase.ReplayingJournals,
                "scanning" => JobProgressPhase.Scanning,
                _ => null,
            };
        }
    }
}