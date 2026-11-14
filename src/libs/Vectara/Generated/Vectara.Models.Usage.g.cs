
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How much of one thing the account uses, and its use of the allowance on it, when one applies.
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// What is measured or counted. New types may be added. Today:<br/>
        /// * `storage_content_bytes`: the bytes of data the account has given, including the search indexes built from it and its agents' sessions and artifacts, before compression or copies. Measured once an hour.<br/>
        /// * `storage_stored_bytes`: the bytes the platform keeps for the account, compressed and with every copy. Measured once an hour.<br/>
        /// Example: storage_stored_bytes
        /// </summary>
        /// <example>storage_stored_bytes</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// What `amount` counts. New units may be added.<br/>
        /// Example: bytes
        /// </summary>
        /// <example>bytes</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.UsageUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.UsageUnit Unit { get; set; }

        /// <summary>
        /// How much the account uses, in `unit`.<br/>
        /// Example: 61733402118
        /// </summary>
        /// <example>61733402118</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Amount { get; set; }

        /// <summary>
        /// When `amount` was taken. A total measured at intervals, such as storage, reports the start of the hour it was measured in; one counted over a `window` reports when it was read.<br/>
        /// Example: 2026-11-05T09:00:00Z
        /// </summary>
        /// <example>2026-11-05T09:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("measured_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime MeasuredAt { get; set; }

        /// <summary>
        /// The period `amount` is counted over, which starts again at `resets_at`. Absent for a total that is measured rather than counted, such as storage. New windows may be added.<br/>
        /// Example: day
        /// </summary>
        /// <example>day</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.UsageWindowJsonConverter))]
        public global::Vectara.UsageWindow? Window { get; set; }

        /// <summary>
        /// When the current `window` ends and `amount` starts again from zero. Absent when there is no `window`.<br/>
        /// Example: 2026-11-06T00:00:00Z
        /// </summary>
        /// <example>2026-11-06T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resets_at")]
        public global::System.DateTime? ResetsAt { get; set; }

        /// <summary>
        /// The allowance that applies to one usage, and how much of it the account uses. Absent when no allowance applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowance")]
        public global::Vectara.UsageAllowance? Allowance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="type">
        /// What is measured or counted. New types may be added. Today:<br/>
        /// * `storage_content_bytes`: the bytes of data the account has given, including the search indexes built from it and its agents' sessions and artifacts, before compression or copies. Measured once an hour.<br/>
        /// * `storage_stored_bytes`: the bytes the platform keeps for the account, compressed and with every copy. Measured once an hour.<br/>
        /// Example: storage_stored_bytes
        /// </param>
        /// <param name="unit">
        /// What `amount` counts. New units may be added.<br/>
        /// Example: bytes
        /// </param>
        /// <param name="amount">
        /// How much the account uses, in `unit`.<br/>
        /// Example: 61733402118
        /// </param>
        /// <param name="measuredAt">
        /// When `amount` was taken. A total measured at intervals, such as storage, reports the start of the hour it was measured in; one counted over a `window` reports when it was read.<br/>
        /// Example: 2026-11-05T09:00:00Z
        /// </param>
        /// <param name="window">
        /// The period `amount` is counted over, which starts again at `resets_at`. Absent for a total that is measured rather than counted, such as storage. New windows may be added.<br/>
        /// Example: day
        /// </param>
        /// <param name="resetsAt">
        /// When the current `window` ends and `amount` starts again from zero. Absent when there is no `window`.<br/>
        /// Example: 2026-11-06T00:00:00Z
        /// </param>
        /// <param name="allowance">
        /// The allowance that applies to one usage, and how much of it the account uses. Absent when no allowance applies.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            string type,
            global::Vectara.UsageUnit unit,
            long amount,
            global::System.DateTime measuredAt,
            global::Vectara.UsageWindow? window,
            global::System.DateTime? resetsAt,
            global::Vectara.UsageAllowance? allowance)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Unit = unit;
            this.Amount = amount;
            this.MeasuredAt = measuredAt;
            this.Window = window;
            this.ResetsAt = resetsAt;
            this.Allowance = allowance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }

    }
}