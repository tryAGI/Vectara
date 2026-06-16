
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Vectara.JsonConverters.FilterAttributeLevelJsonConverter),

            typeof(global::Vectara.JsonConverters.FilterAttributeLevelNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.FilterAttributeTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.FilterAttributeTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.FilterAttributeStatTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.FilterAttributeStatTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ChunkingStrategyDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ChunkingStrategyDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CoreDocumentPartImagePartModeJsonConverter),

            typeof(global::Vectara.JsonConverters.CoreDocumentPartImagePartModeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateDocumentRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateDocumentRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorResponseTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorResponseTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.MetadataQueryRequestLevelJsonConverter),

            typeof(global::Vectara.JsonConverters.MetadataQueryRequestLevelNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.LanguageJsonConverter),

            typeof(global::Vectara.JsonConverters.LanguageNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.IndividualSearchResultDiscriminatorResultTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.IndividualSearchResultDiscriminatorResultTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryWarningJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryWarningNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchSemanticsJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchSemanticsNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchParametersMaxByJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchParametersMaxByNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CitationParametersStyleJsonConverter),

            typeof(global::Vectara.JsonConverters.CitationParametersStyleNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryStreamedResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryStreamedResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.RewrittenQueryWarningJsonConverter),

            typeof(global::Vectara.JsonConverters.RewrittenQueryWarningNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryHistorySpanDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryHistorySpanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ChatStreamedResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ChatStreamedResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.LLMOwnershipJsonConverter),

            typeof(global::Vectara.JsonConverters.LLMOwnershipNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.LLMAuthDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.LLMAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.LlmTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.LlmTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.RemoteAuthDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.RemoteAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.VertexAiAuthDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.VertexAiAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AnthropicAuthDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AnthropicAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateLLMRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateLLMRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateLLMRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateLLMRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.JsonSchemaDefinitionTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.JsonSchemaDefinitionTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ResponseFormatTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ResponseFormatTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateChatCompletionResponseObjectJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.GenerationPresetOwnershipJsonConverter),

            typeof(global::Vectara.JsonConverters.GenerationPresetOwnershipNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateEncoderRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateEncoderRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.JobStateJsonConverter),

            typeof(global::Vectara.JsonConverters.JobStateNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.JobTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.JobTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ApiRoleJsonConverter),

            typeof(global::Vectara.JsonConverters.ApiRoleNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CorpusRoleRoleJsonConverter),

            typeof(global::Vectara.JsonConverters.CorpusRoleRoleNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentRoleRoleJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentRoleRoleNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ApiKeyRoleJsonConverter),

            typeof(global::Vectara.JsonConverters.ApiKeyRoleNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateAppClientRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateAppClientRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolServerTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolServerTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolServerTransportJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolServerTransportNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.FunctionDefinitionLanguageJsonConverter),

            typeof(global::Vectara.JsonConverters.FunctionDefinitionLanguageNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.FunctionDefinitionValidationStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.FunctionDefinitionValidationStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.LambdaToolVariant2LanguageJsonConverter),

            typeof(global::Vectara.JsonConverters.LambdaToolVariant2LanguageNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateLambdaToolRequestLanguageJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateLambdaToolRequestLanguageNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.TestLambdaToolRequestLanguageJsonConverter),

            typeof(global::Vectara.JsonConverters.TestLambdaToolRequestLanguageNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.TestLambdaToolResponseValidationStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.TestLambdaToolResponseValidationStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateToolRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateToolRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.TestToolResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.TestToolResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.TemplateTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.TemplateTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.InstructionDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.InstructionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInstructionRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInstructionRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateInstructionRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateInstructionRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.WebSearchToolParametersProviderJsonConverter),

            typeof(global::Vectara.JsonConverters.WebSearchToolParametersProviderNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetAuthDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetToolParametersMethodJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetToolParametersMethodNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SubAgentSessionModeJsonConverter),

            typeof(global::Vectara.JsonConverters.SubAgentSessionModeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactReadToolParametersEncodingJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactReadToolParametersEncodingNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadToolParametersDetailJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadToolParametersDetailNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.DocumentConversionToolParametersOutputFormatJsonConverter),

            typeof(global::Vectara.JsonConverters.DocumentConversionToolParametersOutputFormatNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentToolConfigurationDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentToolConfigurationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepInstructionDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepInstructionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputParserDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputParserDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.TemplatedReminderHookJsonConverter),

            typeof(global::Vectara.JsonConverters.TemplatedReminderHookNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepReminderDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepReminderDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionConfigToolEventPolicyJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionConfigToolEventPolicyNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolOutputOffloadingConfigurationModeJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolOutputOffloadingConfigurationModeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentSessionStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentSessionStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentInputDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentInputDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadEventVariant2DetailJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadEventVariant2DetailNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentEventDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.InputBehaviorJsonConverter),

            typeof(global::Vectara.JsonConverters.InputBehaviorNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolOutputRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolOutputRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolActivityEventDiscriminatorActivityTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolActivityEventDiscriminatorActivityTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStreamedResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStreamedResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.IntervalScheduleConfigurationTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.IntervalScheduleConfigurationTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CronScheduleConfigurationTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CronScheduleConfigurationTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentScheduleExecutionStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentScheduleExecutionStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentIdentityModeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentIdentityModeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ConnectorConfigurationDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ConnectorConfigurationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorLastWebhookStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorLastWebhookStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateConnectorConfigurationDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateConnectorConfigurationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.RuleTargetsDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.RuleTargetsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AliasPolicyDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AliasPolicyDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.GoogleDriveScopeDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.GoogleDriveScopeDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.WebPagesSourceDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.WebPagesSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineSourceDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineTriggerDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineTriggerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineVerificationDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineVerificationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineTransformDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineTransformDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineSyncModeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineSyncModeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdatePipelineSourceDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdatePipelineSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunTriggerTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunTriggerTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.DeadLetterStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.DeadLetterStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.DeadLetterOriginJsonConverter),

            typeof(global::Vectara.JsonConverters.DeadLetterOriginNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunEventTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunEventTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SortOrderJsonConverter),

            typeof(global::Vectara.JsonConverters.SortOrderNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.RunCompletedEventStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.RunCompletedEventStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.RecordProcessingEventStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.RecordProcessingEventStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunEventDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricDescriptorDiscriminatorKindJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricDescriptorDiscriminatorKindNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricSeriesDiscriminatorKindJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricSeriesDiscriminatorKindNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceSpanStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceSpanStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.InvokeAgentSpanAttributesOutputTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.InvokeAgentSpanAttributesOutputTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceSpanDiscriminatorOperationJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceSpanDiscriminatorOperationNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateCorpusDocumentWaitForJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateCorpusDocumentWaitForNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListToolServersTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListToolServersTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListToolsTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListToolsTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListInstructionsTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListInstructionsTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListSessionArtifactsSortByJsonConverter),

            typeof(global::Vectara.JsonConverters.ListSessionArtifactsSortByNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListSessionArtifactsOrderByJsonConverter),

            typeof(global::Vectara.JsonConverters.ListSessionArtifactsOrderByNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAgentConnectorsTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAgentConnectorsTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsSortByJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsSortByNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsOrderByJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsOrderByNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListPipelinesSourceTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListPipelinesSourceTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesErrorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesErrorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesOperationJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesOperationNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesToolErrorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesToolErrorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTraceSpansOperationJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTraceSpansOperationNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ChunkingStrategyJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateDocumentRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.BulkDeleteDocumentsResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.TextSearchResultJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageSearchResultJsonConverter),

            typeof(global::Vectara.JsonConverters.IndividualSearchResultJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchRerankerJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.KeyedSearchCorpusJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchCorporaParametersJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryHistorySpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ChatStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.LLMAuthJsonConverter),

            typeof(global::Vectara.JsonConverters.RemoteAuthJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateOpenAILLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateOpenAIResponsesLLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.VertexAiAuthJsonConverter),

            typeof(global::Vectara.JsonConverters.AnthropicAuthJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateLLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateOpenAILLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateOpenAIResponsesLLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateLLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateGenerationPresetRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateEncoderRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateAppClientRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.DynamicVectaraToolJsonConverter),

            typeof(global::Vectara.JsonConverters.McpToolJsonConverter),

            typeof(global::Vectara.JsonConverters.CorporaSearchToolJsonConverter),

            typeof(global::Vectara.JsonConverters.WebSearchToolJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetToolJsonConverter),

            typeof(global::Vectara.JsonConverters.LambdaToolJsonConverter),

            typeof(global::Vectara.JsonConverters.SubAgentToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactCreateToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactReadToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactGrepToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadToolJsonConverter),

            typeof(global::Vectara.JsonConverters.DocumentConversionToolJsonConverter),

            typeof(global::Vectara.JsonConverters.GetDocumentTextToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ClientToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateToolRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.TestToolResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.InstructionJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInitialInstructionRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInstructionRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateInstructionRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineDynamicVectaraToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineMcpToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineCorporaSearchToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineWebSearchToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetHeaderValueJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetAuthJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineWebGetToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineLambdaToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineClientToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineSubAgentToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineArtifactCreateToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineArtifactReadToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineArtifactGrepToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineImageReadToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineDocumentConversionToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineGetDocumentTextToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.ReferenceInstructionJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineInstructionJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepInstructionJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputParserJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepReminderJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentInputJsonConverter),

            typeof(global::Vectara.JsonConverters.InputMessageEventJsonConverter),

            typeof(global::Vectara.JsonConverters.SkillLoadEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactUploadEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolInputEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolOutputEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ThinkingEventJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputEventJsonConverter),

            typeof(global::Vectara.JsonConverters.StructuredOutputEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ContextLimitExceededEventJsonConverter),

            typeof(global::Vectara.JsonConverters.StepTransitionLimitExceededEventJsonConverter),

            typeof(global::Vectara.JsonConverters.SessionInterruptedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ClientToolPendingEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadEventJsonConverter),

            typeof(global::Vectara.JsonConverters.StepTransitionEventJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionEventJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentEventJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputMessageRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInterruptRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateCompactRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolOutputSuccessJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolOutputErrorJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolOutputRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.ClientToolOutputRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionStartedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.GenericToolActivityEventJsonConverter),

            typeof(global::Vectara.JsonConverters.SubAgentToolActivityEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolActivityEventJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.ScheduleConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.SlackConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.GchatConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.ConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateSlackConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateGchatConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.RuleTargetsJsonConverter),

            typeof(global::Vectara.JsonConverters.AliasPolicyJsonConverter),

            typeof(global::Vectara.JsonConverters.SharepointSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.S3SourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.GoogleDriveScopeJsonConverter),

            typeof(global::Vectara.JsonConverters.GoogleDriveSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.CrawlPagesSourceJsonConverter),

            typeof(global::Vectara.JsonConverters.SitemapCrawlPagesSourceJsonConverter),

            typeof(global::Vectara.JsonConverters.WebPagesSourceJsonConverter),

            typeof(global::Vectara.JsonConverters.WebSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineSourceJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineTriggerJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineVerificationJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateSharepointSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateS3SourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateGoogleDriveSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateWebSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdatePipelineSourceJsonConverter),

            typeof(global::Vectara.JsonConverters.RunStartedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.RunCompletedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.RecordProcessingEventJsonConverter),

            typeof(global::Vectara.JsonConverters.WatermarkAdvancedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunEventJsonConverter),

            typeof(global::Vectara.JsonConverters.CounterMetricDescriptorJsonConverter),

            typeof(global::Vectara.JsonConverters.GaugeMetricDescriptorJsonConverter),

            typeof(global::Vectara.JsonConverters.PercentilesMetricDescriptorJsonConverter),

            typeof(global::Vectara.JsonConverters.DistributionMetricDescriptorJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricDescriptorJsonConverter),

            typeof(global::Vectara.JsonConverters.CounterMetricSeriesJsonConverter),

            typeof(global::Vectara.JsonConverters.GaugeMetricSeriesJsonConverter),

            typeof(global::Vectara.JsonConverters.PercentilesMetricSeriesJsonConverter),

            typeof(global::Vectara.JsonConverters.DistributionMetricSeriesJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricSeriesJsonConverter),

            typeof(global::Vectara.JsonConverters.InvokeAgentTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ChatTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ExecuteToolTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ThinkingTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.OutputTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.GuardrailTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.StepTransitionTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.AllOfJsonConverter<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<global::Vectara.WebGetHeadersMap, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<bool?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<bool?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<long?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.AllOfJsonConverter<global::Vectara.User, global::Vectara.CreateUserResponse2>),

            typeof(global::Vectara.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterAttribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterAttributeLevel), TypeInfoPropertyName = "FilterAttributeLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterAttributeType), TypeInfoPropertyName = "FilterAttributeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorpusCustomDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Corpus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.FilterAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.CorpusCustomDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorpusLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListCorporaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Corpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateCorpusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.NotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateCorpusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReplaceFilterAttributesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReplaceFilterAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ComputeCorpusSizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterAttributeValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterAttributeNumericStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterAttributeStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterAttributeStatType), TypeInfoPropertyName = "FilterAttributeStatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.FilterAttributeValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetFilterAttributeStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.FilterAttributeStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MaxCharsChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SentenceChunkingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChunkingStrategy), TypeInfoPropertyName = "ChunkingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChunkingStrategyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChunkingStrategyDiscriminatorType), TypeInfoPropertyName = "ChunkingStrategyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TableExtractorSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TableGenerationSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TableExtractionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Cell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Cell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Vectara.Cell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Table))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentStorageUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ExtractionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ImageMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.DocumentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CoreDocumentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CoreDocumentPartImagePartMode), TypeInfoPropertyName = "CoreDocumentPartImagePartMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CoreDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.CoreDocumentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StructuredDocumentSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.StructuredDocumentSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StructuredDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateDocumentRequest), TypeInfoPropertyName = "CreateDocumentRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateDocumentRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateDocumentRequestDiscriminatorType), TypeInfoPropertyName = "CreateDocumentRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteAsyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteSyncSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteDocumentsResponse), TypeInfoPropertyName = "BulkDeleteDocumentsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteDocumentsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteDocumentsResponseDiscriminatorResponseType), TypeInfoPropertyName = "BulkDeleteDocumentsResponseDiscriminatorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SummarizeDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SummarizeDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamGenerationChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GenerationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamGenerationEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamResponseEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SummarizeDocumentStreamedResponse), TypeInfoPropertyName = "SummarizeDocumentStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SummarizeDocumentStreamedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType), TypeInfoPropertyName = "SummarizeDocumentStreamedResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FieldQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetadataQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetadataQueryRequestLevel), TypeInfoPropertyName = "MetadataQueryRequestLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.FieldQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ScoredDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetadataQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ScoredDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Language), TypeInfoPropertyName = "Language2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchResultBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TextSearchResult), TypeInfoPropertyName = "TextSearchResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TextSearchResultVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageSearchResult), TypeInfoPropertyName = "ImageSearchResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageSearchResultVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.IndividualSearchResult), TypeInfoPropertyName = "IndividualSearchResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.IndividualSearchResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.IndividualSearchResultDiscriminatorResultType), TypeInfoPropertyName = "IndividualSearchResultDiscriminatorResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryWarning), TypeInfoPropertyName = "QueryWarning2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterExtraction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RewrittenQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryFullResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.IndividualSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.QueryWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.RewrittenQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchSemantics), TypeInfoPropertyName = "SearchSemantics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchCorpus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ContextConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CustomerSpecificReranker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UserFunctionReranker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MMRReranker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchReranker), TypeInfoPropertyName = "SearchReranker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChainReranker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.NoneReranker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchRerankerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchRerankerDiscriminatorType), TypeInfoPropertyName = "SearchRerankerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.SearchReranker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchParametersMaxBy), TypeInfoPropertyName = "SearchParametersMaxBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CitationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CitationParametersStyle), TypeInfoPropertyName = "CitationParametersStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GenerationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GenerationParametersModelParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryCorpusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AllOf<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>), TypeInfoPropertyName = "AllOfSearchCorpusSearchParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FactualConsistencyScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryStreamedResponse), TypeInfoPropertyName = "QueryStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryStreamedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryStreamedResponseDiscriminatorType), TypeInfoPropertyName = "QueryStreamedResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.KeyedSearchCorpus), TypeInfoPropertyName = "KeyedSearchCorpus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.KeyedSearchCorpusVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchCorporaParameters), TypeInfoPropertyName = "SearchCorporaParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchCorporaParametersVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.KeyedSearchCorpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RephraseSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RerankedSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RerankSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.RerankedSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GenerationSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FactualConsistencyScoreSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RewrittenQueryWarning), TypeInfoPropertyName = "RewrittenQueryWarning2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RewrittenQuerySpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.RewrittenQueryWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryHistorySpan), TypeInfoPropertyName = "QueryHistorySpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryHistorySpanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryHistorySpanDiscriminatorType), TypeInfoPropertyName = "QueryHistorySpanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.QueryHistorySpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryHistorySummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListQueryHistoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.QueryHistorySummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListQueryHistoriesResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Chat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListChatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Chat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatFullResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatStreamedResponse), TypeInfoPropertyName = "ChatStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatStreamedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatStreamedResponseDiscriminatorType), TypeInfoPropertyName = "ChatStreamedResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Turn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListChatTurnsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Turn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateTurnRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LLMCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LLMOwnership), TypeInfoPropertyName = "LLMOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BearerAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.HeaderAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OAuthClientCredentialsAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BedrockStaticIAMAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BedrockApiKeyAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexServiceAccountAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAccessTokenAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiApiKeyAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiServiceAccountAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LLMAuth), TypeInfoPropertyName = "LLMAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LLMAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LLMAuthDiscriminatorType), TypeInfoPropertyName = "LLMAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Llm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LlmType), TypeInfoPropertyName = "LlmType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListLLMsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Llm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RemoteAuth), TypeInfoPropertyName = "RemoteAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RemoteAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RemoteAuthDiscriminatorType), TypeInfoPropertyName = "RemoteAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OpenAILLMRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAILLMRequest), TypeInfoPropertyName = "CreateOpenAILLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAILLMRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAIResponsesLLMRequest), TypeInfoPropertyName = "CreateOpenAIResponsesLLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAIResponsesLLMRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiAuth), TypeInfoPropertyName = "VertexAiAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiAuthDiscriminatorType), TypeInfoPropertyName = "VertexAiAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateVertexAILLMRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AnthropicAuth), TypeInfoPropertyName = "AnthropicAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AnthropicAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AnthropicAuthDiscriminatorType), TypeInfoPropertyName = "AnthropicAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAnthropicLLMRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateLLMRequest), TypeInfoPropertyName = "CreateLLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateLLMRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateLLMRequestDiscriminatorType), TypeInfoPropertyName = "CreateLLMRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OpenAILLMUpdateBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateOpenAILLMRequest), TypeInfoPropertyName = "UpdateOpenAILLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateOpenAILLMRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateOpenAIResponsesLLMRequest), TypeInfoPropertyName = "UpdateOpenAIResponsesLLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateVertexAILLMRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAnthropicLLMRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateLLMRequest), TypeInfoPropertyName = "UpdateLLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateLLMRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateLLMRequestDiscriminatorType), TypeInfoPropertyName = "UpdateLLMRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatCompletionRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaDefinitionType), TypeInfoPropertyName = "JsonSchemaDefinitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.JsonSchemaDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.JsonSchemaDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ResponseFormatType), TypeInfoPropertyName = "ResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatCompletionResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatCompletionResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateChatCompletionResponseObject), TypeInfoPropertyName = "CreateChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatCompletionStreamResponseDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatCompletionStreamResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateChatCompletionStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateChatCompletionStreamResponseObject), TypeInfoPropertyName = "CreateChatCompletionStreamResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ChatCompletionStreamResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GenerationPresetOwnership), TypeInfoPropertyName = "GenerationPresetOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GenerationPreset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListGenerationPresetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.GenerationPreset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGenerationPresetRequest), TypeInfoPropertyName = "CreateGenerationPresetRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EvaluateFactualConsistencyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EvaluateFactualConsistencyRequestModelParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EvaluateFactualConsistencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Encoder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListEncodersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Encoder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAIEncoderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateVLlmEncoderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEncoderRequest), TypeInfoPropertyName = "CreateEncoderRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEncoderRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEncoderRequestDiscriminatorType), TypeInfoPropertyName = "CreateEncoderRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Reranker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListRerankersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Reranker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TableExtractor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTableExtractorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.TableExtractor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.HallucinationCorrector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListHallucinationCorrectorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.HallucinationCorrector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.HcmSourceDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.HallucinationCorrectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.HcmSourceDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorrectionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.HallucinationCorrectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.CorrectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JobState), TypeInfoPropertyName = "JobState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Job))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JobType), TypeInfoPropertyName = "JobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ApiRole), TypeInfoPropertyName = "ApiRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorpusRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorpusRoleRole), TypeInfoPropertyName = "CorpusRoleRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentRoleRole), TypeInfoPropertyName = "AgentRoleRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ApiOperationPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ApiPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.ApiOperationPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ApiRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.CorpusRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ApiKeyRole), TypeInfoPropertyName = "ApiKeyRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AppClient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAppClientsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AppClient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateClientCredentialsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAppClientRequest), TypeInfoPropertyName = "CreateAppClientRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAppClientRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAppClientRequestDiscriminatorType), TypeInfoPropertyName = "CreateAppClientRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAppClientRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolServerType), TypeInfoPropertyName = "ToolServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolServerTransport), TypeInfoPropertyName = "ToolServerTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListToolServersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ToolServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolServerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateToolServerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DynamicVectaraTool), TypeInfoPropertyName = "DynamicVectaraTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DynamicVectaraToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.McpToolAnnotations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.McpTool), TypeInfoPropertyName = "McpTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.McpToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorporaSearchTool), TypeInfoPropertyName = "CorporaSearchTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorporaSearchToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchTool), TypeInfoPropertyName = "WebSearchTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetTool), TypeInfoPropertyName = "WebGetTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ExecutionConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FunctionDefinitionLanguage), TypeInfoPropertyName = "FunctionDefinitionLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FunctionDefinitionValidationStatus), TypeInfoPropertyName = "FunctionDefinitionValidationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaTool), TypeInfoPropertyName = "LambdaTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaToolVariant2Language), TypeInfoPropertyName = "LambdaToolVariant2Language2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentTool), TypeInfoPropertyName = "SubAgentTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactCreateTool), TypeInfoPropertyName = "ArtifactCreateTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactCreateToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadTool), TypeInfoPropertyName = "ArtifactReadTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactGrepTool), TypeInfoPropertyName = "ArtifactGrepTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactGrepToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadTool), TypeInfoPropertyName = "ImageReadTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionTool), TypeInfoPropertyName = "DocumentConversionTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextTool), TypeInfoPropertyName = "GetDocumentTextTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientTool), TypeInfoPropertyName = "ClientTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolDiscriminatorType), TypeInfoPropertyName = "ToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateLambdaToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateLambdaToolRequestLanguage), TypeInfoPropertyName = "CreateLambdaToolRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateClientToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolRequest), TypeInfoPropertyName = "CreateToolRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolRequestDiscriminatorType), TypeInfoPropertyName = "CreateToolRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolRequestLanguage), TypeInfoPropertyName = "TestLambdaToolRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolResponseValidation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolResponseValidationStatus), TypeInfoPropertyName = "TestLambdaToolResponseValidationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolResponseExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolResponseExecutionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolResponseExecutionValidationResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateMcpToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateLambdaToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateClientToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateToolRequest), TypeInfoPropertyName = "UpdateToolRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateToolRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateToolRequestDiscriminatorType), TypeInfoPropertyName = "UpdateToolRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestToolSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestToolSuccessResponseValidationResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestToolErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestToolErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestToolResponse), TypeInfoPropertyName = "TestToolResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestToolResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestToolResponseDiscriminatorType), TypeInfoPropertyName = "TestToolResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TemplateType), TypeInfoPropertyName = "TemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InitialInstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Instruction), TypeInfoPropertyName = "Instruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InstructionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InstructionDiscriminatorType), TypeInfoPropertyName = "InstructionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListInstructionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Instruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InstructionRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInitialInstructionRequest), TypeInfoPropertyName = "CreateInitialInstructionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInitialInstructionRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInstructionRequest), TypeInfoPropertyName = "CreateInstructionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInstructionRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInstructionRequestDiscriminatorType), TypeInfoPropertyName = "CreateInstructionRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateInitialInstructionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateInstructionRequest), TypeInfoPropertyName = "UpdateInstructionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateInstructionRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateInstructionRequestDiscriminatorType), TypeInfoPropertyName = "UpdateInstructionRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestInstructionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestInstructionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentToolConfigurationBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineDynamicVectaraToolConfiguration), TypeInfoPropertyName = "InlineDynamicVectaraToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineDynamicVectaraToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineMcpToolConfiguration), TypeInfoPropertyName = "InlineMcpToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineMcpToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorporaSearchToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EagerReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentKeyedSearchCorpus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<string, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfStringEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentSearchCorporaParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentKeyedSearchCorpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentCorporaSearchQueryConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineCorporaSearchToolConfiguration), TypeInfoPropertyName = "InlineCorporaSearchToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineCorporaSearchToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolParametersProvider), TypeInfoPropertyName = "WebSearchToolParametersProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineWebSearchToolConfiguration), TypeInfoPropertyName = "InlineWebSearchToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineWebSearchToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetHeaderValue), TypeInfoPropertyName = "WebGetHeaderValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetHeadersMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetNoAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetBearerAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetHeaderAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetOAuthClientCredentialsAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetOAuthRefreshTokenAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetAuth), TypeInfoPropertyName = "WebGetAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetAuthDiscriminatorType), TypeInfoPropertyName = "WebGetAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolParametersMethod), TypeInfoPropertyName = "WebGetToolParametersMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<global::Vectara.WebGetHeadersMap, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfWebGetHeadersMapEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<bool?, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfBooleanEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<int?, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfInt32EagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<long?, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfInt64EagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineWebGetToolConfiguration), TypeInfoPropertyName = "InlineWebGetToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineWebGetToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineLambdaToolConfiguration), TypeInfoPropertyName = "InlineLambdaToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineLambdaToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineClientToolConfiguration), TypeInfoPropertyName = "InlineClientToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineClientToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentSessionMode), TypeInfoPropertyName = "SubAgentSessionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineSubAgentToolConfiguration), TypeInfoPropertyName = "InlineSubAgentToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineSubAgentToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineArtifactCreateToolConfiguration), TypeInfoPropertyName = "InlineArtifactCreateToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineArtifactCreateToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolParametersEncoding), TypeInfoPropertyName = "ArtifactReadToolParametersEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineArtifactReadToolConfiguration), TypeInfoPropertyName = "InlineArtifactReadToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineArtifactReadToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactGrepToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineArtifactGrepToolConfiguration), TypeInfoPropertyName = "InlineArtifactGrepToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineArtifactGrepToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolParametersDetail), TypeInfoPropertyName = "ImageReadToolParametersDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineImageReadToolConfiguration), TypeInfoPropertyName = "InlineImageReadToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineImageReadToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolParametersOutputFormat), TypeInfoPropertyName = "DocumentConversionToolParametersOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineDocumentConversionToolConfiguration), TypeInfoPropertyName = "InlineDocumentConversionToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineDocumentConversionToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextConfigurationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineGetDocumentTextToolConfiguration), TypeInfoPropertyName = "InlineGetDocumentTextToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineGetDocumentTextToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentToolConfiguration), TypeInfoPropertyName = "AgentToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentToolConfigurationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentToolConfigurationDiscriminatorType), TypeInfoPropertyName = "AgentToolConfigurationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RetryConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InstructionReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReferenceInstruction), TypeInfoPropertyName = "ReferenceInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReferenceInstructionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineInstruction), TypeInfoPropertyName = "InlineInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineInstructionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStepInstruction), TypeInfoPropertyName = "AgentStepInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStepInstructionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStepInstructionDiscriminatorType), TypeInfoPropertyName = "AgentStepInstructionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DefaultOutputParser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StructuredOutputParser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputParser), TypeInfoPropertyName = "AgentOutputParser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputParserDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputParserDiscriminatorType), TypeInfoPropertyName = "AgentOutputParserDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TemplatedReminder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.TemplatedReminderHook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TemplatedReminderHook), TypeInfoPropertyName = "TemplatedReminderHook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GlossaryExpansionReminder))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Vectara.JsonConverters.FilterAttributeLevelJsonConverter),

            typeof(global::Vectara.JsonConverters.FilterAttributeLevelNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.FilterAttributeTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.FilterAttributeTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.FilterAttributeStatTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.FilterAttributeStatTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ChunkingStrategyDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ChunkingStrategyDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CoreDocumentPartImagePartModeJsonConverter),

            typeof(global::Vectara.JsonConverters.CoreDocumentPartImagePartModeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateDocumentRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateDocumentRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorResponseTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorResponseTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.MetadataQueryRequestLevelJsonConverter),

            typeof(global::Vectara.JsonConverters.MetadataQueryRequestLevelNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.LanguageJsonConverter),

            typeof(global::Vectara.JsonConverters.LanguageNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.IndividualSearchResultDiscriminatorResultTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.IndividualSearchResultDiscriminatorResultTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryWarningJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryWarningNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchSemanticsJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchSemanticsNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchParametersMaxByJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchParametersMaxByNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CitationParametersStyleJsonConverter),

            typeof(global::Vectara.JsonConverters.CitationParametersStyleNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryStreamedResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryStreamedResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.RewrittenQueryWarningJsonConverter),

            typeof(global::Vectara.JsonConverters.RewrittenQueryWarningNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryHistorySpanDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryHistorySpanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ChatStreamedResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ChatStreamedResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.LLMOwnershipJsonConverter),

            typeof(global::Vectara.JsonConverters.LLMOwnershipNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.LLMAuthDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.LLMAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.LlmTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.LlmTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.RemoteAuthDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.RemoteAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.VertexAiAuthDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.VertexAiAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AnthropicAuthDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AnthropicAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateLLMRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateLLMRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateLLMRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateLLMRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.JsonSchemaDefinitionTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.JsonSchemaDefinitionTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ResponseFormatTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ResponseFormatTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateChatCompletionResponseObjectJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.GenerationPresetOwnershipJsonConverter),

            typeof(global::Vectara.JsonConverters.GenerationPresetOwnershipNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateEncoderRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateEncoderRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.JobStateJsonConverter),

            typeof(global::Vectara.JsonConverters.JobStateNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.JobTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.JobTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ApiRoleJsonConverter),

            typeof(global::Vectara.JsonConverters.ApiRoleNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CorpusRoleRoleJsonConverter),

            typeof(global::Vectara.JsonConverters.CorpusRoleRoleNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentRoleRoleJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentRoleRoleNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ApiKeyRoleJsonConverter),

            typeof(global::Vectara.JsonConverters.ApiKeyRoleNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateAppClientRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateAppClientRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolServerTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolServerTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolServerTransportJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolServerTransportNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.FunctionDefinitionLanguageJsonConverter),

            typeof(global::Vectara.JsonConverters.FunctionDefinitionLanguageNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.FunctionDefinitionValidationStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.FunctionDefinitionValidationStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.LambdaToolVariant2LanguageJsonConverter),

            typeof(global::Vectara.JsonConverters.LambdaToolVariant2LanguageNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateLambdaToolRequestLanguageJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateLambdaToolRequestLanguageNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.TestLambdaToolRequestLanguageJsonConverter),

            typeof(global::Vectara.JsonConverters.TestLambdaToolRequestLanguageNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.TestLambdaToolResponseValidationStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.TestLambdaToolResponseValidationStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateToolRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateToolRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.TestToolResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.TestToolResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.TemplateTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.TemplateTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.InstructionDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.InstructionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInstructionRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInstructionRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateInstructionRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateInstructionRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.WebSearchToolParametersProviderJsonConverter),

            typeof(global::Vectara.JsonConverters.WebSearchToolParametersProviderNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetAuthDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetToolParametersMethodJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetToolParametersMethodNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SubAgentSessionModeJsonConverter),

            typeof(global::Vectara.JsonConverters.SubAgentSessionModeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactReadToolParametersEncodingJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactReadToolParametersEncodingNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadToolParametersDetailJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadToolParametersDetailNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.DocumentConversionToolParametersOutputFormatJsonConverter),

            typeof(global::Vectara.JsonConverters.DocumentConversionToolParametersOutputFormatNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentToolConfigurationDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentToolConfigurationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepInstructionDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepInstructionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputParserDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputParserDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.TemplatedReminderHookJsonConverter),

            typeof(global::Vectara.JsonConverters.TemplatedReminderHookNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepReminderDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepReminderDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionConfigToolEventPolicyJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionConfigToolEventPolicyNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolOutputOffloadingConfigurationModeJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolOutputOffloadingConfigurationModeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentSessionStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentSessionStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentInputDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentInputDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadEventVariant2DetailJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadEventVariant2DetailNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentEventDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.InputBehaviorJsonConverter),

            typeof(global::Vectara.JsonConverters.InputBehaviorNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolOutputRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolOutputRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolActivityEventDiscriminatorActivityTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolActivityEventDiscriminatorActivityTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStreamedResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStreamedResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.IntervalScheduleConfigurationTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.IntervalScheduleConfigurationTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CronScheduleConfigurationTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CronScheduleConfigurationTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentScheduleExecutionStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentScheduleExecutionStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentIdentityModeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentIdentityModeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ConnectorConfigurationDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ConnectorConfigurationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorLastWebhookStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentConnectorLastWebhookStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateConnectorConfigurationDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateConnectorConfigurationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.RuleTargetsDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.RuleTargetsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AliasPolicyDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AliasPolicyDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.GoogleDriveScopeDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.GoogleDriveScopeDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.WebPagesSourceDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.WebPagesSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineSourceDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineTriggerDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineTriggerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineVerificationDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineVerificationDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineTransformDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineTransformDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineSyncModeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineSyncModeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdatePipelineSourceDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdatePipelineSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunTriggerTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunTriggerTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.DeadLetterStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.DeadLetterStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.DeadLetterOriginJsonConverter),

            typeof(global::Vectara.JsonConverters.DeadLetterOriginNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunEventTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunEventTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SortOrderJsonConverter),

            typeof(global::Vectara.JsonConverters.SortOrderNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.RunCompletedEventStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.RunCompletedEventStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.RecordProcessingEventStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.RecordProcessingEventStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunEventDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricDescriptorDiscriminatorKindJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricDescriptorDiscriminatorKindNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricSeriesDiscriminatorKindJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricSeriesDiscriminatorKindNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceSpanStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceSpanStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.InvokeAgentSpanAttributesOutputTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.InvokeAgentSpanAttributesOutputTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceSpanDiscriminatorOperationJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceSpanDiscriminatorOperationNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateCorpusDocumentWaitForJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateCorpusDocumentWaitForNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListToolServersTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListToolServersTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListToolsTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListToolsTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListInstructionsTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListInstructionsTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListSessionArtifactsSortByJsonConverter),

            typeof(global::Vectara.JsonConverters.ListSessionArtifactsSortByNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListSessionArtifactsOrderByJsonConverter),

            typeof(global::Vectara.JsonConverters.ListSessionArtifactsOrderByNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAgentConnectorsTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAgentConnectorsTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsSortByJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsSortByNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsOrderByJsonConverter),

            typeof(global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsOrderByNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListPipelinesSourceTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListPipelinesSourceTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesStatusJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesStatusNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesErrorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesErrorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesOperationJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesOperationNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesToolErrorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTracesToolErrorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTraceSpansOperationJsonConverter),

            typeof(global::Vectara.JsonConverters.ListTraceSpansOperationNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ChunkingStrategyJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateDocumentRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.BulkDeleteDocumentsResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.TextSearchResultJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageSearchResultJsonConverter),

            typeof(global::Vectara.JsonConverters.IndividualSearchResultJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchRerankerJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.KeyedSearchCorpusJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchCorporaParametersJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryHistorySpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ChatStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.LLMAuthJsonConverter),

            typeof(global::Vectara.JsonConverters.RemoteAuthJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateOpenAILLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateOpenAIResponsesLLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.VertexAiAuthJsonConverter),

            typeof(global::Vectara.JsonConverters.AnthropicAuthJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateLLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateOpenAILLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateOpenAIResponsesLLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateLLMRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateGenerationPresetRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateEncoderRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateAppClientRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.DynamicVectaraToolJsonConverter),

            typeof(global::Vectara.JsonConverters.McpToolJsonConverter),

            typeof(global::Vectara.JsonConverters.CorporaSearchToolJsonConverter),

            typeof(global::Vectara.JsonConverters.WebSearchToolJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetToolJsonConverter),

            typeof(global::Vectara.JsonConverters.LambdaToolJsonConverter),

            typeof(global::Vectara.JsonConverters.SubAgentToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactCreateToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactReadToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactGrepToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadToolJsonConverter),

            typeof(global::Vectara.JsonConverters.DocumentConversionToolJsonConverter),

            typeof(global::Vectara.JsonConverters.GetDocumentTextToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ClientToolJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateToolRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.TestToolResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.InstructionJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInitialInstructionRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInstructionRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateInstructionRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineDynamicVectaraToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineMcpToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineCorporaSearchToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineWebSearchToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetHeaderValueJsonConverter),

            typeof(global::Vectara.JsonConverters.WebGetAuthJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineWebGetToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineLambdaToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineClientToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineSubAgentToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineArtifactCreateToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineArtifactReadToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineArtifactGrepToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineImageReadToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineDocumentConversionToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineGetDocumentTextToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentToolConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.ReferenceInstructionJsonConverter),

            typeof(global::Vectara.JsonConverters.InlineInstructionJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepInstructionJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputParserJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStepReminderJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentInputJsonConverter),

            typeof(global::Vectara.JsonConverters.InputMessageEventJsonConverter),

            typeof(global::Vectara.JsonConverters.SkillLoadEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ArtifactUploadEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolInputEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolOutputEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ThinkingEventJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentOutputEventJsonConverter),

            typeof(global::Vectara.JsonConverters.StructuredOutputEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ContextLimitExceededEventJsonConverter),

            typeof(global::Vectara.JsonConverters.StepTransitionLimitExceededEventJsonConverter),

            typeof(global::Vectara.JsonConverters.SessionInterruptedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ClientToolPendingEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadEventJsonConverter),

            typeof(global::Vectara.JsonConverters.StepTransitionEventJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionEventJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentEventJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputMessageRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInterruptRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateCompactRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolOutputSuccessJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolOutputErrorJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolOutputRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.ClientToolOutputRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionStartedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.GenericToolActivityEventJsonConverter),

            typeof(global::Vectara.JsonConverters.SubAgentToolActivityEventJsonConverter),

            typeof(global::Vectara.JsonConverters.ToolActivityEventJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.ScheduleConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.SlackConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.GchatConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.ConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateSlackConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateGchatConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateConnectorConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.RuleTargetsJsonConverter),

            typeof(global::Vectara.JsonConverters.AliasPolicyJsonConverter),

            typeof(global::Vectara.JsonConverters.SharepointSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.S3SourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.GoogleDriveScopeJsonConverter),

            typeof(global::Vectara.JsonConverters.GoogleDriveSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.CrawlPagesSourceJsonConverter),

            typeof(global::Vectara.JsonConverters.SitemapCrawlPagesSourceJsonConverter),

            typeof(global::Vectara.JsonConverters.WebPagesSourceJsonConverter),

            typeof(global::Vectara.JsonConverters.WebSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineSourceJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineTriggerJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineVerificationJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateSharepointSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateS3SourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateGoogleDriveSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateWebSourceConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdatePipelineSourceJsonConverter),

            typeof(global::Vectara.JsonConverters.RunStartedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.RunCompletedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.RecordProcessingEventJsonConverter),

            typeof(global::Vectara.JsonConverters.WatermarkAdvancedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.PipelineRunEventJsonConverter),

            typeof(global::Vectara.JsonConverters.CounterMetricDescriptorJsonConverter),

            typeof(global::Vectara.JsonConverters.GaugeMetricDescriptorJsonConverter),

            typeof(global::Vectara.JsonConverters.PercentilesMetricDescriptorJsonConverter),

            typeof(global::Vectara.JsonConverters.DistributionMetricDescriptorJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricDescriptorJsonConverter),

            typeof(global::Vectara.JsonConverters.CounterMetricSeriesJsonConverter),

            typeof(global::Vectara.JsonConverters.GaugeMetricSeriesJsonConverter),

            typeof(global::Vectara.JsonConverters.PercentilesMetricSeriesJsonConverter),

            typeof(global::Vectara.JsonConverters.DistributionMetricSeriesJsonConverter),

            typeof(global::Vectara.JsonConverters.MetricSeriesJsonConverter),

            typeof(global::Vectara.JsonConverters.InvokeAgentTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ChatTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ExecuteToolTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ThinkingTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.OutputTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.GuardrailTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.StepTransitionTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentTraceSpanJsonConverter),

            typeof(global::Vectara.JsonConverters.AllOfJsonConverter<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<global::Vectara.WebGetHeadersMap, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<bool?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<bool?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<long?, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.AllOfJsonConverter<global::Vectara.User, global::Vectara.CreateUserResponse2>),

            typeof(global::Vectara.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStepReminder), TypeInfoPropertyName = "AgentStepReminder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStepReminderDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStepReminderDiscriminatorType), TypeInfoPropertyName = "AgentStepReminderDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.NextStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FirstAgentStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentStepInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentStepReminder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.NextStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionConfigToolEventPolicy), TypeInfoPropertyName = "CompactionConfigToolEventPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolOutputOffloadingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolOutputOffloadingConfigurationMode), TypeInfoPropertyName = "ToolOutputOffloadingConfigurationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentToolConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateFirstAgentStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.UpdateAgentStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OutputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SessionContextUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentSessionStatus), TypeInfoPropertyName = "AgentSessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentSessionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentSessionRequestFromSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentEventBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTextInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentSkillInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentInput), TypeInfoPropertyName = "AgentInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentInputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentInputDiscriminatorType), TypeInfoPropertyName = "AgentInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InputMessageEvent), TypeInfoPropertyName = "InputMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InputMessageEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SkillLoadEvent), TypeInfoPropertyName = "SkillLoadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SkillLoadEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactUploadEvent), TypeInfoPropertyName = "ArtifactUploadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactUploadEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ArtifactReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolInputEvent), TypeInfoPropertyName = "ToolInputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolInputEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolOutputEvent), TypeInfoPropertyName = "ToolOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolOutputEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ThinkingEvent), TypeInfoPropertyName = "ThinkingEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ThinkingEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputEvent), TypeInfoPropertyName = "AgentOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StructuredOutputEvent), TypeInfoPropertyName = "StructuredOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StructuredOutputEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ContextLimitExceededEvent), TypeInfoPropertyName = "ContextLimitExceededEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ContextLimitExceededEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StepTransitionLimitExceededEvent), TypeInfoPropertyName = "StepTransitionLimitExceededEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StepTransitionLimitExceededEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SessionInterruptedEvent), TypeInfoPropertyName = "SessionInterruptedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SessionInterruptedEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolPendingCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolPendingEvent), TypeInfoPropertyName = "ClientToolPendingEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolPendingEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ClientToolPendingCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadEvent), TypeInfoPropertyName = "ImageReadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadEventVariant2Detail), TypeInfoPropertyName = "ImageReadEventVariant2Detail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StepTransitionEvent), TypeInfoPropertyName = "StepTransitionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StepTransitionEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionEvent), TypeInfoPropertyName = "CompactionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentEvent), TypeInfoPropertyName = "AgentEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentEventDiscriminatorType), TypeInfoPropertyName = "AgentEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InputBehavior), TypeInfoPropertyName = "InputBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputMessageRequest), TypeInfoPropertyName = "CreateInputMessageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputMessageRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInterruptRequest), TypeInfoPropertyName = "CreateInterruptRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInterruptRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateCompactRequest), TypeInfoPropertyName = "CreateCompactRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateCompactRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputSuccess), TypeInfoPropertyName = "CreateToolOutputSuccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputSuccessVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputError), TypeInfoPropertyName = "CreateToolOutputError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputRequest), TypeInfoPropertyName = "CreateToolOutputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputRequestDiscriminatorType), TypeInfoPropertyName = "CreateToolOutputRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolOutputRequest), TypeInfoPropertyName = "ClientToolOutputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolOutputRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.CreateToolOutputRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputRequest), TypeInfoPropertyName = "CreateInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputRequestDiscriminatorType), TypeInfoPropertyName = "CreateInputRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MultipartInputEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamingAgentOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamingAgentOutputEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamingThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamingThinkingEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ContextConsumedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionStartedEvent), TypeInfoPropertyName = "CompactionStartedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionStartedEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolActivityEventBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GenericToolActivityEvent), TypeInfoPropertyName = "GenericToolActivityEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GenericToolActivityEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentToolActivityEvent), TypeInfoPropertyName = "SubAgentToolActivityEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentToolActivityEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolActivityEvent), TypeInfoPropertyName = "ToolActivityEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolActivityEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolActivityEventDiscriminatorActivityType), TypeInfoPropertyName = "ToolActivityEventDiscriminatorActivityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStreamedResponse), TypeInfoPropertyName = "AgentStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStreamedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStreamedResponseDiscriminatorType), TypeInfoPropertyName = "AgentStreamedResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OutstandingClientToolCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SessionArtifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListSessionArtifactsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.SessionArtifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.IntervalScheduleConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.IntervalScheduleConfigurationType), TypeInfoPropertyName = "IntervalScheduleConfigurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CronScheduleConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CronScheduleConfigurationType), TypeInfoPropertyName = "CronScheduleConfigurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ScheduleConfiguration), TypeInfoPropertyName = "ScheduleConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentSchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentSchedulesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentSchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentScheduleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentScheduleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentScheduleExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentScheduleExecutionStatus), TypeInfoPropertyName = "AgentScheduleExecutionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentScheduleExecutionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentScheduleExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentIdentityMode), TypeInfoPropertyName = "AgentIdentityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentIdentityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentSecrets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReplaceAgentSecretsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentSecretsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentMemoryMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentMemory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentMemoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentMemoryVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentMemoryHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentMemoryVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputType), TypeInfoPropertyName = "AgentOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorConfigurationBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SlackConnectorConfiguration), TypeInfoPropertyName = "SlackConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SlackConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GchatConnectorConfiguration), TypeInfoPropertyName = "GchatConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GchatConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorConfiguration), TypeInfoPropertyName = "ConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorConfigurationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorConfigurationDiscriminatorType), TypeInfoPropertyName = "ConnectorConfigurationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentConnectorType), TypeInfoPropertyName = "AgentConnectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentConnectorStatus), TypeInfoPropertyName = "AgentConnectorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentConnectorLastWebhookStatus), TypeInfoPropertyName = "AgentConnectorLastWebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentConnectorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateConnectorConfigurationBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateSlackConnectorConfiguration), TypeInfoPropertyName = "CreateSlackConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateSlackConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGchatConnectorConfiguration), TypeInfoPropertyName = "CreateGchatConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGchatConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateConnectorConfiguration), TypeInfoPropertyName = "CreateConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateConnectorConfigurationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateConnectorConfigurationDiscriminatorType), TypeInfoPropertyName = "CreateConnectorConfigurationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentConnectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentConnectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SingleRuleTargets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WeightedTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WeightedRuleTargets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.WeightedTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RuleTargets), TypeInfoPropertyName = "RuleTargets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RuleTargetsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RuleTargetsDiscriminatorType), TypeInfoPropertyName = "RuleTargetsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AliasRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RoutedAliasPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AliasRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AliasPolicy), TypeInfoPropertyName = "AliasPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AliasPolicyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AliasPolicyDiscriminatorType), TypeInfoPropertyName = "AliasPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentAlias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentAliasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentAlias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentAliasRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentAliasRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReplaceAliasPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineStatus), TypeInfoPropertyName = "PipelineStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseSharepointSourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SharepointSourceConfiguration), TypeInfoPropertyName = "SharepointSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseS3SourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.S3SourceConfiguration), TypeInfoPropertyName = "S3SourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SharedGoogleDriveScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MyGoogleDriveScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GoogleDriveScope), TypeInfoPropertyName = "GoogleDriveScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GoogleDriveScopeDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GoogleDriveScopeDiscriminatorType), TypeInfoPropertyName = "GoogleDriveScopeDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseGoogleDriveSourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.GoogleDriveScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GoogleDriveSourceConfiguration), TypeInfoPropertyName = "GoogleDriveSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseWebSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SitemapPagesSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseCrawlPagesSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CrawlPagesSource), TypeInfoPropertyName = "CrawlPagesSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CrawlPagesSourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SitemapCrawlPagesSource), TypeInfoPropertyName = "SitemapCrawlPagesSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SitemapCrawlPagesSourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebPagesSource), TypeInfoPropertyName = "WebPagesSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebPagesSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebPagesSourceDiscriminatorType), TypeInfoPropertyName = "WebPagesSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSourceConfiguration), TypeInfoPropertyName = "WebSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSourceConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineSource), TypeInfoPropertyName = "PipelineSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineSourceDiscriminatorType), TypeInfoPropertyName = "PipelineSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CronTriggerConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.IntervalTriggerConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ManualTriggerConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineTrigger), TypeInfoPropertyName = "PipelineTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineTriggerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineTriggerDiscriminatorType), TypeInfoPropertyName = "PipelineTriggerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConditionVerification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentVerification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineVerification), TypeInfoPropertyName = "PipelineVerification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineVerificationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineVerificationDiscriminatorType), TypeInfoPropertyName = "PipelineVerificationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTransformConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineTransform))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineTransformDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineTransformDiscriminatorType), TypeInfoPropertyName = "PipelineTransformDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineSyncMode), TypeInfoPropertyName = "PipelineSyncMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineWatermark))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Pipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListPipelinesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Pipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreatePipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateSharepointSourceConfiguration), TypeInfoPropertyName = "UpdateSharepointSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateS3SourceConfiguration), TypeInfoPropertyName = "UpdateS3SourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateGoogleDriveSourceConfiguration), TypeInfoPropertyName = "UpdateGoogleDriveSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateWebSourceConfiguration), TypeInfoPropertyName = "UpdateWebSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateWebSourceConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdatePipelineSource), TypeInfoPropertyName = "UpdatePipelineSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdatePipelineSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdatePipelineSourceDiscriminatorType), TypeInfoPropertyName = "UpdatePipelineSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdatePipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunStatus), TypeInfoPropertyName = "PipelineRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunTriggerType), TypeInfoPropertyName = "PipelineRunTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DeadLetterStatus), TypeInfoPropertyName = "DeadLetterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DeadLetterOrigin), TypeInfoPropertyName = "DeadLetterOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineDeadLetterEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListPipelineDeadLetterEntriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.PipelineDeadLetterEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreatePipelineDeadLetterEntryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ProcessPipelineDeadLetterEntriesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListPipelineRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.PipelineRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunEventType), TypeInfoPropertyName = "PipelineRunEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SortOrder), TypeInfoPropertyName = "SortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunEventBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RunStartedEvent), TypeInfoPropertyName = "RunStartedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RunStartedEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RunCompletedEventStatus), TypeInfoPropertyName = "RunCompletedEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RunCompletedEvent), TypeInfoPropertyName = "RunCompletedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RunCompletedEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RecordProcessingEventStatus), TypeInfoPropertyName = "RecordProcessingEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RecordProcessingEvent), TypeInfoPropertyName = "RecordProcessingEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RecordProcessingEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WatermarkAdvancedEvent), TypeInfoPropertyName = "WatermarkAdvancedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WatermarkAdvancedEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunEvent), TypeInfoPropertyName = "PipelineRunEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunEventDiscriminatorType), TypeInfoPropertyName = "PipelineRunEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListPipelineRunEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.PipelineRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricDescriptorBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CounterMetricDescriptor), TypeInfoPropertyName = "CounterMetricDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CounterMetricDescriptorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GaugeMetricDescriptor), TypeInfoPropertyName = "GaugeMetricDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GaugeMetricDescriptorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PercentileEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PercentilesMetricDescriptor), TypeInfoPropertyName = "PercentilesMetricDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PercentilesMetricDescriptorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.PercentileEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DistributionBinDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DistributionMetricDescriptor), TypeInfoPropertyName = "DistributionMetricDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DistributionMetricDescriptorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.DistributionBinDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricDescriptor), TypeInfoPropertyName = "MetricDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricDescriptorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricDescriptorDiscriminatorKind), TypeInfoPropertyName = "MetricDescriptorDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.MetricDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricSeriesBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ScalarMetricPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CounterMetricSeries), TypeInfoPropertyName = "CounterMetricSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CounterMetricSeriesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.ScalarMetricPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GaugeMetricSeries), TypeInfoPropertyName = "GaugeMetricSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GaugeMetricSeriesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PercentilesMetricPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PercentilesMetricSeries), TypeInfoPropertyName = "PercentilesMetricSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PercentilesMetricSeriesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.PercentilesMetricPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.HistogramBin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DistributionMetricPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.HistogramBin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DistributionMetricSeries), TypeInfoPropertyName = "DistributionMetricSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DistributionMetricSeriesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.DistributionMetricPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricSeries), TypeInfoPropertyName = "MetricSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricSeriesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricSeriesDiscriminatorKind), TypeInfoPropertyName = "MetricSeriesDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceStatus), TypeInfoPropertyName = "AgentTraceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentTracesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentTrace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceSpanStatus), TypeInfoPropertyName = "AgentTraceSpanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceSpanBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceInputFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InvokeAgentSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InvokeAgentSpanAttributesOutputType), TypeInfoPropertyName = "InvokeAgentSpanAttributesOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentTraceInputFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InvokeAgentSpanContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InvokeAgentTraceSpan), TypeInfoPropertyName = "InvokeAgentTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InvokeAgentTraceSpanVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatTraceSpan), TypeInfoPropertyName = "ChatTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatTraceSpanVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ExecuteToolSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ExecuteToolSpanContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ExecuteToolTraceSpan), TypeInfoPropertyName = "ExecuteToolTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ExecuteToolTraceSpanVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ThinkingSpanContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ThinkingTraceSpan), TypeInfoPropertyName = "ThinkingTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ThinkingTraceSpanVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OutputSpanContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OutputTraceSpan), TypeInfoPropertyName = "OutputTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OutputTraceSpanVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GuardrailSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GuardrailSpanContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GuardrailTraceSpan), TypeInfoPropertyName = "GuardrailTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GuardrailTraceSpanVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StepTransitionSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StepTransitionTraceSpan), TypeInfoPropertyName = "StepTransitionTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StepTransitionTraceSpanVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadTraceSpan), TypeInfoPropertyName = "ImageReadTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadTraceSpanVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionTraceSpan), TypeInfoPropertyName = "CompactionTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionTraceSpanVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceSpan), TypeInfoPropertyName = "AgentTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceSpanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceSpanDiscriminatorOperation), TypeInfoPropertyName = "AgentTraceSpanDiscriminatorOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentTraceSpansResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentTraceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Glossary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListGlossariesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Glossary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGlossaryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateGlossaryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GlossaryEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GlossaryEntriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.GlossaryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpsertGlossaryEntriesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DeleteGlossaryEntriesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetOAuthTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateCorpusDocumentWaitFor), TypeInfoPropertyName = "CreateCorpusDocumentWaitFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.JobState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListToolServersType), TypeInfoPropertyName = "ListToolServersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListToolsType), TypeInfoPropertyName = "ListToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListInstructionsType), TypeInfoPropertyName = "ListInstructionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListSessionArtifactsSortBy), TypeInfoPropertyName = "ListSessionArtifactsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListSessionArtifactsOrderBy), TypeInfoPropertyName = "ListSessionArtifactsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentConnectorsType), TypeInfoPropertyName = "ListAgentConnectorsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAliasRoutedSessionArtifactsSortBy), TypeInfoPropertyName = "ListAliasRoutedSessionArtifactsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAliasRoutedSessionArtifactsOrderBy), TypeInfoPropertyName = "ListAliasRoutedSessionArtifactsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListPipelinesSourceType), TypeInfoPropertyName = "ListPipelinesSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.PipelineRunEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTracesStatus), TypeInfoPropertyName = "ListTracesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTracesErrorType), TypeInfoPropertyName = "ListTracesErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTracesOperation), TypeInfoPropertyName = "ListTracesOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTracesToolErrorType), TypeInfoPropertyName = "ListTracesToolErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTraceSpansOperation), TypeInfoPropertyName = "ListTraceSpansOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AllOf<global::Vectara.User, global::Vectara.CreateUserResponse2>), TypeInfoPropertyName = "AllOfUserCreateUserResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ResetUserPasswordResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.FilterAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.CorpusCustomDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Corpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.FilterAttributeValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.FilterAttributeStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Cell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Vectara.Cell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ImageMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.DocumentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.CoreDocumentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.StructuredDocumentSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.FieldQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ScoredDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.IndividualSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.QueryWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.RewrittenQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.SearchReranker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.KeyedSearchCorpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.RerankedSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.RewrittenQueryWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.QueryHistorySpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.QueryHistorySummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Chat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Turn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Llm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.JsonSchemaDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ChatCompletionRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ChatCompletionResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ChatCompletionStreamResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.GenerationPreset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Encoder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Reranker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.TableExtractor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.HallucinationCorrector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.HcmSourceDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.CorrectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ApiRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.CorpusRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AppClient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ToolServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Instruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentKeyedSearchCorpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.TemplatedReminderHook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentStepInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentStepReminder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.NextStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ArtifactReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ClientToolPendingCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.CreateToolOutputRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.SessionArtifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentSchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentScheduleExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentMemoryVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentOutputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.WeightedTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AliasRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentAlias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.GoogleDriveScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Pipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.PipelineDeadLetterEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.PipelineRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.PipelineRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.PercentileEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.DistributionBinDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.MetricDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.ScalarMetricPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.PercentilesMetricPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.HistogramBin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.DistributionMetricPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentTrace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentTraceInputFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentTraceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Glossary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.GlossaryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.JobState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.PipelineRunEventType>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Vectara.JsonConverters.FilterAttributeLevelJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.FilterAttributeLevelNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.FilterAttributeTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.FilterAttributeTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.FilterAttributeStatTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.FilterAttributeStatTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ChunkingStrategyDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ChunkingStrategyDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CoreDocumentPartImagePartModeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CoreDocumentPartImagePartModeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateDocumentRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateDocumentRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorResponseTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorResponseTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.MetadataQueryRequestLevelJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.MetadataQueryRequestLevelNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LanguageJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LanguageNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.IndividualSearchResultDiscriminatorResultTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.IndividualSearchResultDiscriminatorResultTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.QueryWarningJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.QueryWarningNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SearchSemanticsJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SearchSemanticsNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SearchParametersMaxByJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SearchParametersMaxByNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CitationParametersStyleJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CitationParametersStyleNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.QueryStreamedResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.QueryStreamedResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RewrittenQueryWarningJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RewrittenQueryWarningNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.QueryHistorySpanDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.QueryHistorySpanDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ChatStreamedResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ChatStreamedResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LLMOwnershipJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LLMOwnershipNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LLMAuthDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LLMAuthDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LlmTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LlmTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RemoteAuthDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RemoteAuthDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.VertexAiAuthDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.VertexAiAuthDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AnthropicAuthDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AnthropicAuthDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateLLMRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateLLMRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateLLMRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateLLMRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.JsonSchemaDefinitionTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.JsonSchemaDefinitionTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ResponseFormatTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ResponseFormatTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateChatCompletionResponseObjectJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GenerationPresetOwnershipJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GenerationPresetOwnershipNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateEncoderRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateEncoderRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.JobStateJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.JobStateNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.JobTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.JobTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ApiRoleJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ApiRoleNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CorpusRoleRoleJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CorpusRoleRoleNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentRoleRoleJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentRoleRoleNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ApiKeyRoleJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ApiKeyRoleNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateAppClientRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateAppClientRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolServerTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolServerTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolServerTransportJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolServerTransportNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.FunctionDefinitionLanguageJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.FunctionDefinitionLanguageNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.FunctionDefinitionValidationStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.FunctionDefinitionValidationStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LambdaToolVariant2LanguageJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LambdaToolVariant2LanguageNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateLambdaToolRequestLanguageJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateLambdaToolRequestLanguageNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateToolRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateToolRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TestLambdaToolRequestLanguageJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TestLambdaToolRequestLanguageNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TestLambdaToolResponseValidationStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TestLambdaToolResponseValidationStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateToolRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateToolRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TestToolResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TestToolResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TemplateTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TemplateTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InstructionDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InstructionDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateInstructionRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateInstructionRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateInstructionRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateInstructionRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebSearchToolParametersProviderJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebSearchToolParametersProviderNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetAuthDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetAuthDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetToolParametersMethodJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetToolParametersMethodNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SubAgentSessionModeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SubAgentSessionModeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ArtifactReadToolParametersEncodingJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ArtifactReadToolParametersEncodingNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ImageReadToolParametersDetailJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ImageReadToolParametersDetailNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DocumentConversionToolParametersOutputFormatJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DocumentConversionToolParametersOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentToolConfigurationDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentToolConfigurationDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStepInstructionDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStepInstructionDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentOutputParserDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentOutputParserDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TemplatedReminderHookJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TemplatedReminderHookNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStepReminderDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStepReminderDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CompactionConfigToolEventPolicyJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CompactionConfigToolEventPolicyNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolOutputOffloadingConfigurationModeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolOutputOffloadingConfigurationModeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentSessionStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentSessionStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentInputDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentInputDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ImageReadEventVariant2DetailJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ImageReadEventVariant2DetailNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentEventDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentEventDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InputBehaviorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InputBehaviorNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateToolOutputRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateToolOutputRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateInputRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateInputRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolActivityEventDiscriminatorActivityTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolActivityEventDiscriminatorActivityTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStreamedResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStreamedResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.IntervalScheduleConfigurationTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.IntervalScheduleConfigurationTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CronScheduleConfigurationTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CronScheduleConfigurationTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentScheduleExecutionStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentScheduleExecutionStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentIdentityModeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentIdentityModeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentOutputTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ConnectorConfigurationDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ConnectorConfigurationDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentConnectorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentConnectorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentConnectorStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentConnectorStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentConnectorLastWebhookStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentConnectorLastWebhookStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateConnectorConfigurationDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateConnectorConfigurationDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RuleTargetsDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RuleTargetsDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AliasPolicyDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AliasPolicyDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GoogleDriveScopeDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GoogleDriveScopeDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebPagesSourceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebPagesSourceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineSourceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineSourceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineTriggerDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineTriggerDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineVerificationDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineVerificationDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineTransformDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineTransformDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineSyncModeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineSyncModeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdatePipelineSourceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdatePipelineSourceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineRunStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineRunStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineRunTriggerTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineRunTriggerTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DeadLetterStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DeadLetterStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DeadLetterOriginJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DeadLetterOriginNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineRunEventTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineRunEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SortOrderJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SortOrderNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RunCompletedEventStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RunCompletedEventStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RecordProcessingEventStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RecordProcessingEventStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineRunEventDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineRunEventDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.MetricDescriptorDiscriminatorKindJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.MetricDescriptorDiscriminatorKindNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.MetricSeriesDiscriminatorKindJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.MetricSeriesDiscriminatorKindNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentTraceStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentTraceStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentTraceSpanStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentTraceSpanStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InvokeAgentSpanAttributesOutputTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InvokeAgentSpanAttributesOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentTraceSpanDiscriminatorOperationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentTraceSpanDiscriminatorOperationNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateCorpusDocumentWaitForJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateCorpusDocumentWaitForNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListToolServersTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListToolServersTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListToolsTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListToolsTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListInstructionsTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListInstructionsTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListSessionArtifactsSortByJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListSessionArtifactsSortByNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListSessionArtifactsOrderByJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListSessionArtifactsOrderByNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListAgentConnectorsTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListAgentConnectorsTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsSortByJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsSortByNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsOrderByJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsOrderByNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListPipelinesSourceTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListPipelinesSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListTracesStatusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListTracesStatusNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListTracesErrorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListTracesErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListTracesOperationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListTracesOperationNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListTracesToolErrorTypeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListTracesToolErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListTraceSpansOperationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ListTraceSpansOperationNullableJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ChunkingStrategyJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateDocumentRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.BulkDeleteDocumentsResponseJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TextSearchResultJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ImageSearchResultJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.IndividualSearchResultJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SearchRerankerJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.QueryStreamedResponseJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.KeyedSearchCorpusJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SearchCorporaParametersJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.QueryHistorySpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ChatStreamedResponseJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LLMAuthJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RemoteAuthJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateOpenAILLMRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateOpenAIResponsesLLMRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.VertexAiAuthJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AnthropicAuthJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateLLMRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateOpenAILLMRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateOpenAIResponsesLLMRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateLLMRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateGenerationPresetRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateEncoderRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateAppClientRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DynamicVectaraToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.McpToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CorporaSearchToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebSearchToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LambdaToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SubAgentToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ArtifactCreateToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ArtifactReadToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ArtifactGrepToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ImageReadToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DocumentConversionToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GetDocumentTextToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ClientToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateToolRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateToolRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.TestToolResponseJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InstructionJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateInitialInstructionRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateInstructionRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateInstructionRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineDynamicVectaraToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineMcpToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineCorporaSearchToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineWebSearchToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetHeaderValueJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetAuthJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineWebGetToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineLambdaToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineClientToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineSubAgentToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineArtifactCreateToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineArtifactReadToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineArtifactGrepToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineImageReadToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineDocumentConversionToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineGetDocumentTextToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ReferenceInstructionJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineInstructionJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStepInstructionJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentOutputParserJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStepReminderJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentInputJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InputMessageEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SkillLoadEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ArtifactUploadEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolInputEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolOutputEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ThinkingEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentOutputEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.StructuredOutputEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ContextLimitExceededEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.StepTransitionLimitExceededEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SessionInterruptedEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ClientToolPendingEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ImageReadEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.StepTransitionEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CompactionEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateInputMessageRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateInterruptRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateCompactRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateToolOutputSuccessJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateToolOutputErrorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateToolOutputRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ClientToolOutputRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateInputRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CompactionStartedEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GenericToolActivityEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SubAgentToolActivityEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolActivityEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStreamedResponseJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ScheduleConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SlackConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GchatConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateSlackConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateGchatConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RuleTargetsJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AliasPolicyJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SharepointSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.S3SourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GoogleDriveScopeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GoogleDriveSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CrawlPagesSourceJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SitemapCrawlPagesSourceJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebPagesSourceJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineSourceJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineTriggerJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineVerificationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateSharepointSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateS3SourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateGoogleDriveSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateWebSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdatePipelineSourceJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RunStartedEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RunCompletedEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RecordProcessingEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WatermarkAdvancedEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PipelineRunEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CounterMetricDescriptorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GaugeMetricDescriptorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PercentilesMetricDescriptorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DistributionMetricDescriptorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.MetricDescriptorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CounterMetricSeriesJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GaugeMetricSeriesJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.PercentilesMetricSeriesJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DistributionMetricSeriesJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.MetricSeriesJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InvokeAgentTraceSpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ChatTraceSpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ExecuteToolTraceSpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ThinkingTraceSpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.OutputTraceSpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GuardrailTraceSpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.StepTransitionTraceSpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ImageReadTraceSpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CompactionTraceSpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentTraceSpanJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AllOfJsonConverter<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<global::Vectara.WebGetHeadersMap, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<bool?, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<int?, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<bool?, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<long?, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.AllOfJsonConverter<global::Vectara.User, global::Vectara.CreateUserResponse2>());
            options.Converters.Add(new global::Vectara.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}