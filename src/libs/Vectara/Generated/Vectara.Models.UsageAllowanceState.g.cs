
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Where the account stands against the allowance:<br/>
    /// * `ok`: below `warn_at`, or below the whole allowance when it does not warn.<br/>
    /// * `warning`: from `warn_at`, below the whole allowance.<br/>
    /// * `exceeded`: the whole allowance or more. Requests that add to the usage may be refused until it falls or the allowance is raised.<br/>
    /// Example: warning
    /// </summary>
    public enum UsageAllowanceState
    {
        /// <summary>
        /// the whole allowance or more. Requests that add to the usage may be refused until it falls or the allowance is raised.
        /// </summary>
        Exceeded,
        /// <summary>
        /// below `warn_at`, or below the whole allowance when it does not warn.
        /// </summary>
        Ok,
        /// <summary>
        /// from `warn_at`, below the whole allowance.
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageAllowanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageAllowanceState value)
        {
            return value switch
            {
                UsageAllowanceState.Exceeded => "exceeded",
                UsageAllowanceState.Ok => "ok",
                UsageAllowanceState.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageAllowanceState? ToEnum(string value)
        {
            return value switch
            {
                "exceeded" => UsageAllowanceState.Exceeded,
                "ok" => UsageAllowanceState.Ok,
                "warning" => UsageAllowanceState.Warning,
                _ => null,
            };
        }
    }
}