
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

            typeof(global::Vectara.JsonConverters.QueryWarningJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryWarningNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchSemanticsJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchSemanticsNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeNullableJsonConverter),

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

            typeof(global::Vectara.JsonConverters.AgentInputDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentInputDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadEventVariant2DetailJsonConverter),

            typeof(global::Vectara.JsonConverters.ImageReadEventVariant2DetailNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentEventDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.InputBehaviorJsonConverter),

            typeof(global::Vectara.JsonConverters.InputBehaviorNullableJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputRequestDiscriminatorTypeNullableJsonConverter),

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

            typeof(global::Vectara.JsonConverters.ChunkingStrategyJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateDocumentRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.BulkDeleteDocumentsResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchRerankerJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.KeyedSearchCorpusJsonConverter),

            typeof(global::Vectara.JsonConverters.SearchCorporaParametersJsonConverter),

            typeof(global::Vectara.JsonConverters.QueryHistorySpanJsonConverter),

            typeof(global::Vectara.JsonConverters.ChatStreamedResponseJsonConverter),

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

            typeof(global::Vectara.JsonConverters.ToolJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateToolRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateToolRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.TestToolResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.InstructionJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInitialInstructionRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInstructionRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.UpdateInstructionRequestJsonConverter),

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

            typeof(global::Vectara.JsonConverters.ImageReadEventJsonConverter),

            typeof(global::Vectara.JsonConverters.StepTransitionEventJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionEventJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentEventJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputMessageRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInterruptRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateCompactRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CreateInputRequestJsonConverter),

            typeof(global::Vectara.JsonConverters.CompactionStartedEventJsonConverter),

            typeof(global::Vectara.JsonConverters.AgentStreamedResponseJsonConverter),

            typeof(global::Vectara.JsonConverters.ScheduleConfigurationJsonConverter),

            typeof(global::Vectara.JsonConverters.AllOfJsonConverter<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>),

            typeof(global::Vectara.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, global::Vectara.EagerReference>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.IndividualSearchResult))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Llm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListLLMsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Llm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BearerAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.HeaderAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RemoteAuth), TypeInfoPropertyName = "RemoteAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RemoteAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RemoteAuthDiscriminatorType), TypeInfoPropertyName = "RemoteAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OpenAILLMRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAILLMRequest), TypeInfoPropertyName = "CreateOpenAILLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAILLMRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAIResponsesLLMRequest), TypeInfoPropertyName = "CreateOpenAIResponsesLLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAIResponsesLLMRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiApiKeyAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiServiceAccountAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiAuth), TypeInfoPropertyName = "VertexAiAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiAuthDiscriminatorType), TypeInfoPropertyName = "VertexAiAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateVertexAILLMRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BedrockStaticIAMAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BedrockApiKeyAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexServiceAccountAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAccessTokenAuth))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolDiscriminatorType), TypeInfoPropertyName = "ToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateLambdaToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateLambdaToolRequestLanguage), TypeInfoPropertyName = "CreateLambdaToolRequestLanguage2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineDynamicVectaraToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineMcpToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorporaSearchToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EagerReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentKeyedSearchCorpus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<string, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfStringEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentSearchCorporaParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentKeyedSearchCorpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentCorporaSearchQueryConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineCorporaSearchToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolParametersProvider), TypeInfoPropertyName = "WebSearchToolParametersProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineWebSearchToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolParametersMethod), TypeInfoPropertyName = "WebGetToolParametersMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<global::System.Collections.Generic.Dictionary<string, string>, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfDictionaryStringStringEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<bool?, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfBooleanEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<int?, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfInt32EagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<long?, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfInt64EagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineWebGetToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineLambdaToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentSessionMode), TypeInfoPropertyName = "SubAgentSessionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineSubAgentToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolParametersEncoding), TypeInfoPropertyName = "ArtifactReadToolParametersEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineArtifactReadToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactGrepToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineArtifactGrepToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolParametersDetail), TypeInfoPropertyName = "ImageReadToolParametersDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineImageReadToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolParametersOutputFormat), TypeInfoPropertyName = "DocumentConversionToolParametersOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineDocumentConversionToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextConfigurationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineGetDocumentTextToolConfiguration))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Agent))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentSessionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentSessionRequestFromSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentSessionRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputRequest), TypeInfoPropertyName = "CreateInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputRequestDiscriminatorType), TypeInfoPropertyName = "CreateInputRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamingAgentOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamingAgentOutputEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamingThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StreamingThinkingEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ContextConsumedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionStartedEvent), TypeInfoPropertyName = "CompactionStartedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionStartedEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStreamedResponse), TypeInfoPropertyName = "AgentStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStreamedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStreamedResponseDiscriminatorType), TypeInfoPropertyName = "AgentStreamedResponseDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetOAuthTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateCorpusDocumentWaitFor), TypeInfoPropertyName = "CreateCorpusDocumentWaitFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.JobState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListToolServersType), TypeInfoPropertyName = "ListToolServersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListToolsType), TypeInfoPropertyName = "ListToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListInstructionsType), TypeInfoPropertyName = "ListInstructionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListSessionArtifactsSortBy), TypeInfoPropertyName = "ListSessionArtifactsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListSessionArtifactsOrderBy), TypeInfoPropertyName = "ListSessionArtifactsOrderBy2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.SessionArtifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentSchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentScheduleExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.JobState>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}