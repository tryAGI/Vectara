#nullable enable

namespace Vectara
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update agent<br/>
        /// The Update Agent API enables you to modify an existing agent configuration, including tool assignments, behavioral instructions, model parameters, and operational metadata.<br/>
        /// Use this API to evolve agent capabilities over time, adding new tools as they become available, refining behavioral instructions based on user feedback, adjusting model parameters for optimal performance, and updating metadata for better organization across your agent ecosystem.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Agent> UpdateAsync(
            string agentKey,

            global::Vectara.UpdateAgentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent<br/>
        /// The Update Agent API enables you to modify an existing agent configuration, including tool assignments, behavioral instructions, model parameters, and operational metadata.<br/>
        /// Use this API to evolve agent capabilities over time, adding new tools as they become available, refining behavioral instructions based on user feedback, adjusting model parameters for optimal performance, and updating metadata for better organization across your agent ecosystem.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.Agent>> UpdateAsResponseAsync(
            string agentKey,

            global::Vectara.UpdateAgentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent<br/>
        /// The Update Agent API enables you to modify an existing agent configuration, including tool assignments, behavioral instructions, model parameters, and operational metadata.<br/>
        /// Use this API to evolve agent capabilities over time, adding new tools as they become available, refining behavioral instructions based on user feedback, adjusting model parameters for optimal performance, and updating metadata for better organization across your agent ecosystem.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="name">
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </param>
        /// <param name="description">
        /// A detailed description of the agent's purpose and capabilities. Set to null to clear.<br/>
        /// Example: An enhanced AI agent specialized in handling customer support inquiries.
        /// </param>
        /// <param name="toolConfigurations">
        /// A map of tool configurations available to the agent. Set to null to clear all tools.<br/>
        /// Individual map values set to null will delete that tool configuration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </param>
        /// <param name="skills">
        /// A map of skills available to the agent. Set to null to clear all skills.<br/>
        /// Individual map values set to null will delete that skill.
        /// </param>
        /// <param name="model">
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </param>
        /// <param name="firstStep">
        /// Partial update for the first (entry point) step. Omitted fields are preserved.<br/>
        /// Includes an optional name field to rename the first step.
        /// </param>
        /// <param name="firstStepName">
        /// Reassign the entry point to an existing step by name. This is the preferred way<br/>
        /// to change the entry point. The named step must exist in the steps map.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the agent. Set to null to clear.<br/>
        /// Example: {"department":"customer_service","version":"1.1.0","owner":"support-team","last_reviewed":"2024-01-15"}
        /// </param>
        /// <param name="enabled">
        /// Whether the agent is enabled. Set to null to reset to default (true).<br/>
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
        /// <param name="steps">
        /// A map of additional named steps keyed by step name for partial update.<br/>
        /// Only provided keys are modified; missing keys are preserved.<br/>
        /// Set a key's value to null to delete that step.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}]}}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Agent> UpdateAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentToolConfiguration>? toolConfigurations = default,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentSkill>? skills = default,
            global::Vectara.AgentModel? model = default,
            global::Vectara.UpdateFirstAgentStep? firstStep = default,
            string? firstStepName = default,
            object? metadata = default,
            bool? enabled = default,
            global::Vectara.CompactionConfig? compaction = default,
            global::Vectara.ToolOutputOffloadingConfiguration? toolOutputOffloading = default,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.UpdateAgentStep>? steps = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}