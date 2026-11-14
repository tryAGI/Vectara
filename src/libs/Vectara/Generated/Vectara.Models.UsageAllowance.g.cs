
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The allowance that applies to one usage, and how much of it the account uses. Absent when no allowance applies.
    /// </summary>
    public sealed partial class UsageAllowance
    {
        /// <summary>
        /// How much the allowance permits, in the usage's `unit`.<br/>
        /// Example: 75000000000
        /// </summary>
        /// <example>75000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Amount { get; set; }

        /// <summary>
        /// The fraction of the allowance, above 0 and at most 1, from which the account is in `warning`. Absent when the allowance does not warn.<br/>
        /// Example: 0.8
        /// </summary>
        /// <example>0.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("warn_at")]
        public double? WarnAt { get; set; }

        /// <summary>
        /// The usage as a fraction of the allowance. It is above 1 once the account has used more than the allowance permits.<br/>
        /// Example: 0.82
        /// </summary>
        /// <example>0.82</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Used { get; set; }

        /// <summary>
        /// Where the account stands against the allowance:<br/>
        /// * `ok`: below `warn_at`, or below the whole allowance when it does not warn.<br/>
        /// * `warning`: from `warn_at`, below the whole allowance.<br/>
        /// * `exceeded`: the whole allowance or more. Requests that add to the usage may be refused until it falls or the allowance is raised.<br/>
        /// Example: warning
        /// </summary>
        /// <example>warning</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.UsageAllowanceStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.UsageAllowanceState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAllowance" /> class.
        /// </summary>
        /// <param name="amount">
        /// How much the allowance permits, in the usage's `unit`.<br/>
        /// Example: 75000000000
        /// </param>
        /// <param name="used">
        /// The usage as a fraction of the allowance. It is above 1 once the account has used more than the allowance permits.<br/>
        /// Example: 0.82
        /// </param>
        /// <param name="state">
        /// Where the account stands against the allowance:<br/>
        /// * `ok`: below `warn_at`, or below the whole allowance when it does not warn.<br/>
        /// * `warning`: from `warn_at`, below the whole allowance.<br/>
        /// * `exceeded`: the whole allowance or more. Requests that add to the usage may be refused until it falls or the allowance is raised.<br/>
        /// Example: warning
        /// </param>
        /// <param name="warnAt">
        /// The fraction of the allowance, above 0 and at most 1, from which the account is in `warning`. Absent when the allowance does not warn.<br/>
        /// Example: 0.8
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageAllowance(
            long amount,
            double used,
            global::Vectara.UsageAllowanceState state,
            double? warnAt)
        {
            this.Amount = amount;
            this.WarnAt = warnAt;
            this.Used = used;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAllowance" /> class.
        /// </summary>
        public UsageAllowance()
        {
        }

    }
}