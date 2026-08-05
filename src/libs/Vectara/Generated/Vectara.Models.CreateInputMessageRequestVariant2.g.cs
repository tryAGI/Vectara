
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInputMessageRequestVariant2
    {
        /// <summary>
        /// Default Value: input_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of inputs that make up this event.<br/>
        /// Example: [{"type":"text","content":"I need help with my widget installation"}]
        /// </summary>
        /// <example>[{"type":"text","content":"I need help with my widget installation"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.AgentInput> Messages { get; set; }

        /// <summary>
        /// An event ID cursor. When provided and the session is currently running, the response includes all events created after this event ID. The new input is queued and processed according to the behavior field. Use the special value "start" to receive all events from the beginning of the session, including the input message itself.<br/>
        /// Example: start
        /// </summary>
        /// <example>start</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("since")]
        public string? Since { get; set; }

        /// <summary>
        /// Controls how the input is processed when the session is already running.<br/>
        /// - `steer`: Insert the message as soon as possible on the next iteration of the agent loop.<br/>
        /// - `follow_up`: Insert the message after the current agent loop finishes, as a follow-up turn.<br/>
        ///   Follow-up inputs are consumed one at a time: after each follow-up turn completes, the next<br/>
        ///   queued follow-up is processed. This ensures each follow-up gets a full agent loop iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.InputBehaviorJsonConverter))]
        public global::Vectara.InputBehavior? Behavior { get; set; }

        /// <summary>
        /// Name of the step the agent enters before processing this input. Must be a key in the agent's `steps` map or the agent's `first_step_name`. When omitted, the session resumes at its `current_step_name`.<br/>
        /// Example: triage
        /// </summary>
        /// <example>triage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entry_step")]
        public string? EntryStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInputMessageRequestVariant2" /> class.
        /// </summary>
        /// <param name="messages">
        /// List of inputs that make up this event.<br/>
        /// Example: [{"type":"text","content":"I need help with my widget installation"}]
        /// </param>
        /// <param name="type">
        /// Default Value: input_message
        /// </param>
        /// <param name="since">
        /// An event ID cursor. When provided and the session is currently running, the response includes all events created after this event ID. The new input is queued and processed according to the behavior field. Use the special value "start" to receive all events from the beginning of the session, including the input message itself.<br/>
        /// Example: start
        /// </param>
        /// <param name="behavior">
        /// Controls how the input is processed when the session is already running.<br/>
        /// - `steer`: Insert the message as soon as possible on the next iteration of the agent loop.<br/>
        /// - `follow_up`: Insert the message after the current agent loop finishes, as a follow-up turn.<br/>
        ///   Follow-up inputs are consumed one at a time: after each follow-up turn completes, the next<br/>
        ///   queued follow-up is processed. This ensures each follow-up gets a full agent loop iteration.
        /// </param>
        /// <param name="entryStep">
        /// Name of the step the agent enters before processing this input. Must be a key in the agent's `steps` map or the agent's `first_step_name`. When omitted, the session resumes at its `current_step_name`.<br/>
        /// Example: triage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInputMessageRequestVariant2(
            global::System.Collections.Generic.IList<global::Vectara.AgentInput> messages,
            string? type,
            string? since,
            global::Vectara.InputBehavior? behavior,
            string? entryStep)
        {
            this.Type = type;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Since = since;
            this.Behavior = behavior;
            this.EntryStep = entryStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInputMessageRequestVariant2" /> class.
        /// </summary>
        public CreateInputMessageRequestVariant2()
        {
        }

    }
}