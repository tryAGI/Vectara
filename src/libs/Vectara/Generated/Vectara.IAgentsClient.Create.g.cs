#nullable enable

namespace Vectara
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create agent<br/>
        /// Creates an agent. An agent is defined by three things: the **instructions** it follows, the **steps** it executes when it receives an input, and the **tools** it can call. Instructions are attached to each step and determine the agent's behavior on that step.<br/>
        /// Only a single step is currently supported. Set `first_step` to that step; additional step types will be added later.<br/>
        /// To invoke an agent, create a session and send events to it. Each event produces a response from the agent.<br/>
        /// ## LLM configuration<br/>
        /// Each agent is bound to one LLM, configured under `llm`:<br/>
        /// - `llm_name`: the LLM resource to use (see `GET /v2/llms`).<br/>
        /// - model parameters such as temperature and max tokens.<br/>
        /// - retry configuration applied to LLM calls.<br/>
        /// ## Retry configuration<br/>
        /// The agent retries failed LLM calls using exponential backoff:<br/>
        /// - `max_retries`: maximum number of retries after the initial call.<br/>
        /// - `initial_backoff_ms`: delay in milliseconds before the first retry.<br/>
        /// - `backoff_factor`: multiplier applied to the delay after each retry.<br/>
        /// - `max_backoff_ms`: upper bound on the delay between retries.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Agent> CreateAsync(

            global::Vectara.CreateAgentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent<br/>
        /// Creates an agent. An agent is defined by three things: the **instructions** it follows, the **steps** it executes when it receives an input, and the **tools** it can call. Instructions are attached to each step and determine the agent's behavior on that step.<br/>
        /// Only a single step is currently supported. Set `first_step` to that step; additional step types will be added later.<br/>
        /// To invoke an agent, create a session and send events to it. Each event produces a response from the agent.<br/>
        /// ## LLM configuration<br/>
        /// Each agent is bound to one LLM, configured under `llm`:<br/>
        /// - `llm_name`: the LLM resource to use (see `GET /v2/llms`).<br/>
        /// - model parameters such as temperature and max tokens.<br/>
        /// - retry configuration applied to LLM calls.<br/>
        /// ## Retry configuration<br/>
        /// The agent retries failed LLM calls using exponential backoff:<br/>
        /// - `max_retries`: maximum number of retries after the initial call.<br/>
        /// - `initial_backoff_ms`: delay in milliseconds before the first retry.<br/>
        /// - `backoff_factor`: multiplier applied to the delay after each retry.<br/>
        /// - `max_backoff_ms`: upper bound on the delay between retries.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.Agent>> CreateAsResponseAsync(

            global::Vectara.CreateAgentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent<br/>
        /// Creates an agent. An agent is defined by three things: the **instructions** it follows, the **steps** it executes when it receives an input, and the **tools** it can call. Instructions are attached to each step and determine the agent's behavior on that step.<br/>
        /// Only a single step is currently supported. Set `first_step` to that step; additional step types will be added later.<br/>
        /// To invoke an agent, create a session and send events to it. Each event produces a response from the agent.<br/>
        /// ## LLM configuration<br/>
        /// Each agent is bound to one LLM, configured under `llm`:<br/>
        /// - `llm_name`: the LLM resource to use (see `GET /v2/llms`).<br/>
        /// - model parameters such as temperature and max tokens.<br/>
        /// - retry configuration applied to LLM calls.<br/>
        /// ## Retry configuration<br/>
        /// The agent retries failed LLM calls using exponential backoff:<br/>
        /// - `max_retries`: maximum number of retries after the initial call.<br/>
        /// - `initial_backoff_ms`: delay in milliseconds before the first retry.<br/>
        /// - `backoff_factor`: multiplier applied to the delay after each retry.<br/>
        /// - `max_backoff_ms`: upper bound on the delay between retries.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="key">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="name">
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </param>
        /// <param name="description">
        /// A detailed description of the agent's purpose and capabilities.<br/>
        /// Example: An AI agent specialized in handling customer support inquiries using company documentation and support tools.
        /// </param>
        /// <param name="toolConfigurations">
        /// A map of tool configurations available to the agent. The key is the name of the tool configuration and the value is the AgentToolConfiguration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </param>
        /// <param name="skills">
        /// A map of skills available to the agent, keyed by skill name.<br/>
        /// Skills provide specialized instructions that can be invoked during agent execution.<br/>
        /// Example: {"code_review":{"description":"Reviews code for best practices.","content":"When reviewing code..."}}
        /// </param>
        /// <param name="model">
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </param>
        /// <param name="firstStep">
        /// The entry point step for an agent, with a unique name.<br/>
        /// See AgentStep for full step documentation.
        /// </param>
        /// <param name="firstStepName">
        /// Name of a step in the steps map to use as the entry point. This is the preferred<br/>
        /// way to define the entry point - define all steps in the steps map and reference<br/>
        /// the entry point by name here.<br/>
        /// Example: classifier
        /// </param>
        /// <param name="steps">
        /// A map of named steps keyed by step name.<br/>
        /// Steps can transition to other steps defined here via next_steps.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}],"output_parser":{"type":"default"}},"support_handler":{"instructions":[{"type":"inline","template":"Handle support requests"}],"output_parser":{"type":"default"}}}
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the agent for customization and configuration.<br/>
        /// Default Value: {}<br/>
        /// Example: {"department":"customer_service","version":"1.0.0","owner":"support-team"}
        /// </param>
        /// <param name="enabled">
        /// Whether the agent should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="compaction">
        /// Configuration for automatic context compaction.
        /// </param>
        /// <param name="toolOutputOffloading">
        /// Controls how large tool outputs are kept from overwhelming the agent context window.<br/>
        /// Tool outputs are inspected as they are produced. A small output is always passed through<br/>
        /// unchanged. A larger output is handled in one of two cases: when the output on its own is<br/>
        /// big enough to dominate the context, or when adding it to the conversation would leave<br/>
        /// too little room for the agent to continue. In either case the output is handled according<br/>
        /// to `mode` — stored as an artifact and replaced with a compact reference, or truncated in<br/>
        /// place with the head and tail preserved and the middle omitted. When stored as an artifact,<br/>
        /// the agent is expected to have artifact_read, artifact_grep, or artifact_jq configured so<br/>
        /// it can retrieve the full content on demand.<br/>
        /// All fields are optional; omitted fields fall back to defaults.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Agent> CreateAsync(
            string name,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentToolConfiguration> toolConfigurations,
            global::Vectara.AgentModel model,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? key = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentSkill>? skills = default,
            global::Vectara.FirstAgentStep? firstStep = default,
            string? firstStepName = default,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentStep>? steps = default,
            object? metadata = default,
            bool? enabled = default,
            global::Vectara.CompactionConfig? compaction = default,
            global::Vectara.ToolOutputOffloadingConfiguration? toolOutputOffloading = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}