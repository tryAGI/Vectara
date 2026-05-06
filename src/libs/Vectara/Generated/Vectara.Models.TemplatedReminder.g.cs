
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A templated reminder with a Velocity template that is compiled at session start and injected into messages matching the specified hooks.
    /// </summary>
    public sealed partial class TemplatedReminder
    {
        /// <summary>
        /// The type of reminder.<br/>
        /// Default Value: templated<br/>
        /// Example: templated
        /// </summary>
        /// <default>"templated"</default>
        /// <example>templated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "templated";

        /// <summary>
        /// The templating engine used for instructions.<br/>
        /// Default Value: velocity<br/>
        /// Example: velocity
        /// </summary>
        /// <example>velocity</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.TemplateTypeJsonConverter))]
        public global::Vectara.TemplateType? TemplateType { get; set; }

        /// <summary>
        /// The instruction template content using the specified template engine.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.key` - Agent key<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map (includes user-provided context from test/runtime)<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// - `$tools` - List of tool maps, each with `name` and `description` fields<br/>
        /// Example: `You are a helpful customer support agent. Agent: $agent.name. Today is $currentDate. Available tools: #foreach($tool in $tools)${tool.name}#if($foreach.hasNext), #end#end`<br/>
        /// Example: You are an expert customer support agent for $agent.name. Available tools: #foreach($tool in $tools)${tool.name}#if($foreach.hasNext), #end#end
        /// </summary>
        /// <example>You are an expert customer support agent for $agent.name. Available tools: #foreach($tool in $tools)${tool.name}#if($foreach.hasNext), #end#end</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Template { get; set; }

        /// <summary>
        /// Event types that trigger this reminder to be appended to the corresponding message.<br/>
        /// Example: [tool_output]
        /// </summary>
        /// <example>[tool_output]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.TemplatedReminderHook> Hooks { get; set; }

        /// <summary>
        /// Fire this reminder on every Nth matching hook event (counted independently per hook). Defaults to 1, which preserves the legacy<br/>
        /// behavior of firing on every matching event. Must be at least 1.<br/>
        /// Counters reset after a session compaction: the post-compaction event stream is treated as a fresh sequence (index 0), so<br/>
        /// `skip_first` warmup applies again from the first new matching event.<br/>
        /// Default Value: 1<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fire_every")]
        public int? FireEvery { get; set; }

        /// <summary>
        /// Skip the first N matching hook events at session start before firing this reminder for the first time (counted independently per hook).<br/>
        /// Defaults to 0, meaning no warmup delay. Must be non-negative.<br/>
        /// Counters reset after a session compaction: the post-compaction event stream is treated as a fresh sequence (index 0), so<br/>
        /// the warmup applies again from the first new matching event.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_first")]
        public int? SkipFirst { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatedReminder" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of reminder.<br/>
        /// Default Value: templated<br/>
        /// Example: templated
        /// </param>
        /// <param name="template">
        /// The instruction template content using the specified template engine.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.key` - Agent key<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map (includes user-provided context from test/runtime)<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// - `$tools` - List of tool maps, each with `name` and `description` fields<br/>
        /// Example: `You are a helpful customer support agent. Agent: $agent.name. Today is $currentDate. Available tools: #foreach($tool in $tools)${tool.name}#if($foreach.hasNext), #end#end`<br/>
        /// Example: You are an expert customer support agent for $agent.name. Available tools: #foreach($tool in $tools)${tool.name}#if($foreach.hasNext), #end#end
        /// </param>
        /// <param name="hooks">
        /// Event types that trigger this reminder to be appended to the corresponding message.<br/>
        /// Example: [tool_output]
        /// </param>
        /// <param name="templateType">
        /// The templating engine used for instructions.<br/>
        /// Default Value: velocity<br/>
        /// Example: velocity
        /// </param>
        /// <param name="fireEvery">
        /// Fire this reminder on every Nth matching hook event (counted independently per hook). Defaults to 1, which preserves the legacy<br/>
        /// behavior of firing on every matching event. Must be at least 1.<br/>
        /// Counters reset after a session compaction: the post-compaction event stream is treated as a fresh sequence (index 0), so<br/>
        /// `skip_first` warmup applies again from the first new matching event.<br/>
        /// Default Value: 1<br/>
        /// Example: 3
        /// </param>
        /// <param name="skipFirst">
        /// Skip the first N matching hook events at session start before firing this reminder for the first time (counted independently per hook).<br/>
        /// Defaults to 0, meaning no warmup delay. Must be non-negative.<br/>
        /// Counters reset after a session compaction: the post-compaction event stream is treated as a fresh sequence (index 0), so<br/>
        /// the warmup applies again from the first new matching event.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatedReminder(
            string type,
            string template,
            global::System.Collections.Generic.IList<global::Vectara.TemplatedReminderHook> hooks,
            global::Vectara.TemplateType? templateType,
            int? fireEvery,
            int? skipFirst)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.TemplateType = templateType;
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
            this.Hooks = hooks ?? throw new global::System.ArgumentNullException(nameof(hooks));
            this.FireEvery = fireEvery;
            this.SkipFirst = skipFirst;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatedReminder" /> class.
        /// </summary>
        public TemplatedReminder()
        {
        }
    }
}