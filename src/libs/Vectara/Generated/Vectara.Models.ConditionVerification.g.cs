
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Verifies the worker agent's output using a UserFn condition expression. The expression<br/>
    /// is evaluated against the worker agent's session context (output, tools, session metadata).<br/>
    /// If the expression evaluates to true, the record is considered successfully processed.
    /// </summary>
    public sealed partial class ConditionVerification
    {
        /// <summary>
        /// Default Value: condition<br/>
        /// Example: condition
        /// </summary>
        /// <default>"condition"</default>
        /// <example>condition</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "condition";

        /// <summary>
        /// A UserFn boolean expression evaluated against the worker agent's session context.<br/>
        /// Example: get('$.output.status') == 'success'
        /// </summary>
        /// <example>get('$.output.status') == 'success'</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expression { get; set; }

        /// <summary>
        /// Optional UserFn expression, evaluated against the same session context as `expression`, whose<br/>
        /// string result explains the outcome. Evaluated on both pass and fail and surfaced as the record<br/>
        /// event's `reason` (see `AgentVerification` for the equivalent judge-agent field). When the<br/>
        /// condition fails and this is omitted or evaluates to empty, a default message referencing the<br/>
        /// expression is used.<br/>
        /// Example: 'Status was ' + get('$.output.status')
        /// </summary>
        /// <example>'Status was ' + get('$.output.status')</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason_expression")]
        public string? ReasonExpression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionVerification" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: condition<br/>
        /// Example: condition
        /// </param>
        /// <param name="expression">
        /// A UserFn boolean expression evaluated against the worker agent's session context.<br/>
        /// Example: get('$.output.status') == 'success'
        /// </param>
        /// <param name="reasonExpression">
        /// Optional UserFn expression, evaluated against the same session context as `expression`, whose<br/>
        /// string result explains the outcome. Evaluated on both pass and fail and surfaced as the record<br/>
        /// event's `reason` (see `AgentVerification` for the equivalent judge-agent field). When the<br/>
        /// condition fails and this is omitted or evaluates to empty, a default message referencing the<br/>
        /// expression is used.<br/>
        /// Example: 'Status was ' + get('$.output.status')
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConditionVerification(
            string type,
            string expression,
            string? reasonExpression)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Expression = expression ?? throw new global::System.ArgumentNullException(nameof(expression));
            this.ReasonExpression = reasonExpression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionVerification" /> class.
        /// </summary>
        public ConditionVerification()
        {
        }

    }
}