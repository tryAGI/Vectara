
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteAsyncResponseResponseType), TypeInfoPropertyName = "BulkDeleteAsyncResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteSyncSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteSyncSuccessResponseResponseType), TypeInfoPropertyName = "BulkDeleteSyncSuccessResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteDocumentsResponse), TypeInfoPropertyName = "BulkDeleteDocumentsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteDocumentsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteDocumentsResponseDiscriminatorType), TypeInfoPropertyName = "BulkDeleteDocumentsResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataRequestStrategy), TypeInfoPropertyName = "BulkUpdateDocumentMetadataRequestStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataAsyncResponse), TypeInfoPropertyName = "BulkUpdateDocumentMetadataAsyncResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse), TypeInfoPropertyName = "BulkUpdateDocumentMetadataSyncSuccessResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataResponse), TypeInfoPropertyName = "BulkUpdateDocumentMetadataResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType), TypeInfoPropertyName = "BulkUpdateDocumentMetadataResponseDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LLMType), TypeInfoPropertyName = "LLMType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DiscoverLLMsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DiscoveredLLM))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DiscoverLLMsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.DiscoveredLLM>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaDefinition), TypeInfoPropertyName = "JsonSchemaDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaObject), TypeInfoPropertyName = "JsonSchemaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaValue), TypeInfoPropertyName = "JsonSchemaValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaDefinitionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaDefinitionDiscriminatorType), TypeInfoPropertyName = "JsonSchemaDefinitionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaObjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaValueVariant2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JobProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JobProgressPhase), TypeInfoPropertyName = "JobProgressPhase2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolOutputOffloadingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolOutputOffloadingConfigurationMode), TypeInfoPropertyName = "ToolOutputOffloadingConfigurationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolConfigurationBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolConfigurationReference), TypeInfoPropertyName = "ToolConfigurationReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolConfigurationReferenceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DynamicVectaraToolConfiguration), TypeInfoPropertyName = "DynamicVectaraToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DynamicVectaraToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.McpToolConfiguration), TypeInfoPropertyName = "McpToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.McpToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorporaSearchToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EagerReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentKeyedSearchCorpus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<string, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfStringEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentSearchCorporaParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentKeyedSearchCorpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentCorporaSearchQueryConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorporaSearchToolConfiguration), TypeInfoPropertyName = "CorporaSearchToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorporaSearchToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolParametersProvider), TypeInfoPropertyName = "WebSearchToolParametersProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolConfiguration), TypeInfoPropertyName = "WebSearchToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetHeaderValue), TypeInfoPropertyName = "WebGetHeaderValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetHeadersMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetNoAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetBearerAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetHeaderAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetOAuthClientCredentialsAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetOAuthRefreshTokenAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetOAuthTokenExchangeAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement), TypeInfoPropertyName = "WebGetOAuthTokenExchangeAuthSubjectPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation), TypeInfoPropertyName = "WebGetOAuthTokenExchangeAuthParamLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetAwsSigV4Auth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetAuth), TypeInfoPropertyName = "WebGetAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetAuthDiscriminatorType), TypeInfoPropertyName = "WebGetAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolParametersMethod), TypeInfoPropertyName = "WebGetToolParametersMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<global::Vectara.WebGetHeadersMap, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfWebGetHeadersMapEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<bool?, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfBooleanEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<int?, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfInt32EagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<long?, global::Vectara.EagerReference>), TypeInfoPropertyName = "OneOfInt64EagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolParametersResponseMode), TypeInfoPropertyName = "WebGetToolParametersResponseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolConfiguration), TypeInfoPropertyName = "WebGetToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaToolConfiguration), TypeInfoPropertyName = "LambdaToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolConfiguration), TypeInfoPropertyName = "ClientToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentSessionMode), TypeInfoPropertyName = "SubAgentSessionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentToolConfiguration), TypeInfoPropertyName = "SubAgentToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolParametersEncoding), TypeInfoPropertyName = "ArtifactReadToolParametersEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolConfiguration), TypeInfoPropertyName = "ArtifactReadToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactGrepToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactGrepToolConfiguration), TypeInfoPropertyName = "ArtifactGrepToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactGrepToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolParametersDetail), TypeInfoPropertyName = "ImageReadToolParametersDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolConfiguration), TypeInfoPropertyName = "ImageReadToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolParametersOutputFormat), TypeInfoPropertyName = "DocumentConversionToolParametersOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolConfiguration), TypeInfoPropertyName = "DocumentConversionToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextConfigurationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextToolConfiguration), TypeInfoPropertyName = "GetDocumentTextToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextToolConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentToolConfiguration), TypeInfoPropertyName = "AgentToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentToolConfigurationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentToolConfigurationDiscriminatorType), TypeInfoPropertyName = "AgentToolConfigurationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaTool), TypeInfoPropertyName = "LambdaTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaToolVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaToolVariant2Language), TypeInfoPropertyName = "LambdaToolVariant2Language2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentToolConfiguration>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolContextAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolContextSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolContext))]
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
        })]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SessionEnrichmentToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SessionEnrichmentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.SessionEnrichmentToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReplaceAgentRequest), TypeInfoPropertyName = "ReplaceAgentRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReplaceAgentRequestVariant2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentErrorEvent), TypeInfoPropertyName = "AgentErrorEvent2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SurfaceDescription))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorStatus), TypeInfoPropertyName = "ConnectorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputType), TypeInfoPropertyName = "AgentOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorConfigurationBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SlackConnectorConfiguration), TypeInfoPropertyName = "SlackConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SlackConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GchatConnectorConfiguration), TypeInfoPropertyName = "GchatConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GchatConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ZoomConnectorConfiguration), TypeInfoPropertyName = "ZoomConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ZoomConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WidgetPresentation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WidgetSignIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WidgetConnectorConfiguration), TypeInfoPropertyName = "WidgetConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WidgetConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorConfiguration), TypeInfoPropertyName = "ConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorConfigurationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorConfigurationDiscriminatorType), TypeInfoPropertyName = "ConnectorConfigurationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorWebhookStatus), TypeInfoPropertyName = "ConnectorWebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentConnectorBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SlackAgentConnector), TypeInfoPropertyName = "SlackAgentConnector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SlackAgentConnectorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GchatAgentConnector), TypeInfoPropertyName = "GchatAgentConnector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GchatAgentConnectorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ZoomAgentConnector), TypeInfoPropertyName = "ZoomAgentConnector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ZoomAgentConnectorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WidgetAgentConnector), TypeInfoPropertyName = "WidgetAgentConnector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WidgetAgentConnectorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentConnector), TypeInfoPropertyName = "AgentConnector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentConnectorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentConnectorDiscriminatorType), TypeInfoPropertyName = "AgentConnectorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentConnectorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.AgentConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentConnectorRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateConnectorConfigurationBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateSlackConnectorConfiguration), TypeInfoPropertyName = "CreateSlackConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateSlackConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateSlackAgentConnectorRequest), TypeInfoPropertyName = "CreateSlackAgentConnectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateSlackAgentConnectorRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGchatConnectorConfiguration), TypeInfoPropertyName = "CreateGchatConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGchatConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGchatAgentConnectorRequest), TypeInfoPropertyName = "CreateGchatAgentConnectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGchatAgentConnectorRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateZoomConnectorConfiguration), TypeInfoPropertyName = "CreateZoomConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateZoomConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateZoomAgentConnectorRequest), TypeInfoPropertyName = "CreateZoomAgentConnectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateZoomAgentConnectorRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateWidgetConnectorConfiguration), TypeInfoPropertyName = "CreateWidgetConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateWidgetConnectorConfigurationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateWidgetAgentConnectorRequest), TypeInfoPropertyName = "CreateWidgetAgentConnectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateWidgetAgentConnectorRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentConnectorRequest), TypeInfoPropertyName = "CreateAgentConnectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentConnectorRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentConnectorRequestDiscriminatorType), TypeInfoPropertyName = "CreateAgentConnectorRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateConnectorConfiguration), TypeInfoPropertyName = "CreateConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateConnectorConfigurationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateConnectorConfigurationDiscriminatorType), TypeInfoPropertyName = "CreateConnectorConfigurationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateAgentConnectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03AgentInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03AgentProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03AgentExtension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03AgentCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentExtension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03ApiKeySecurityScheme))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03HttpAuthSecurityScheme))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03AuthorizationCodeOAuthFlow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03ClientCredentialsOAuthFlow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03ImplicitOAuthFlow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03PasswordOAuthFlow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03OAuthFlows))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03OAuth2SecurityScheme))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03OpenIdConnectSecurityScheme))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03MutualTlsSecurityScheme))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03SecurityScheme))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03AgentSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03AgentCardSignature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03AgentCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentInterface>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.A2aV03SecurityScheme>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentCardSignature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03Role), TypeInfoPropertyName = "A2aV03Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03FilePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03DataPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03Part))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV03Part>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03AuthenticationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03PushNotificationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03SendMessageConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03SendMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03TaskState), TypeInfoPropertyName = "A2aV03TaskState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03TaskStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03Artifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03Task))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV03Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV03Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03SendMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03TaskStatusUpdateEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03TaskArtifactUpdateEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03StreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1AgentInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1AgentProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1AgentExtension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1AgentCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentExtension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1AgentSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1AgentCardSignature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1AgentCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentInterface>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentCardSignature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1Role), TypeInfoPropertyName = "A2aV1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1Part))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV1Part>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1AuthenticationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1TaskPushNotificationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1SendMessageConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1SendMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1TaskState), TypeInfoPropertyName = "A2aV1TaskState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1TaskStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1Artifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1Task))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV1Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV1Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1SendMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1TaskStatusUpdateEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1TaskArtifactUpdateEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1StreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1ListTasksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.A2aV1Task>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserSessionStatus), TypeInfoPropertyName = "EndUserSessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListEndUserSessionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.EndUserSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserEventBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserInputMessageEvent), TypeInfoPropertyName = "EndUserInputMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserInputMessageEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserAgentOutputEvent), TypeInfoPropertyName = "EndUserAgentOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserAgentOutputEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserErrorEvent), TypeInfoPropertyName = "EndUserErrorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserErrorEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserEvent), TypeInfoPropertyName = "EndUserEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserEventDiscriminatorType), TypeInfoPropertyName = "EndUserEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListEndUserEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.EndUserEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInputRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInputMessageRequest), TypeInfoPropertyName = "CreateEndUserInputMessageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInputMessageRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInterruptRequest), TypeInfoPropertyName = "CreateEndUserInterruptRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInterruptRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInputRequest), TypeInfoPropertyName = "CreateEndUserInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInputRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInputRequestDiscriminatorType), TypeInfoPropertyName = "CreateEndUserInputRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserMultipartInputEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserAgentStreamedResponse), TypeInfoPropertyName = "EndUserAgentStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserAgentStreamedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserAgentStreamedResponseDiscriminatorType), TypeInfoPropertyName = "EndUserAgentStreamedResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BootstrapWidgetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TrustedTokenIssuer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTrustedTokenIssuersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.TrustedTokenIssuer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateTrustedTokenIssuerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReplaceTrustedTokenIssuerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineStatus), TypeInfoPropertyName = "PipelineStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AclAccessLevel), TypeInfoPropertyName = "AclAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AclMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SourceRecordMetadata))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BoxCcgAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseBoxSourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BoxSourceConfiguration), TypeInfoPropertyName = "BoxSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WolkenArticleStatus), TypeInfoPropertyName = "WolkenArticleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseWolkenKbSourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseWolkenKbSourceConfigurationKbApi), TypeInfoPropertyName = "BaseWolkenKbSourceConfigurationKbApi2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.WolkenArticleStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator), TypeInfoPropertyName = "BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WolkenKbSourceConfiguration), TypeInfoPropertyName = "WolkenKbSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseWolkenFormsSourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WolkenFormsSourceConfiguration), TypeInfoPropertyName = "WolkenFormsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WolkenTicketRequestType), TypeInfoPropertyName = "WolkenTicketRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseWolkenTicketsSourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.WolkenTicketRequestType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WolkenTicketsSourceConfiguration), TypeInfoPropertyName = "WolkenTicketsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseConfluenceSourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseConfluenceSourceConfigurationDeployment), TypeInfoPropertyName = "BaseConfluenceSourceConfigurationDeployment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConfluenceSourceConfiguration), TypeInfoPropertyName = "ConfluenceSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FluidtopicsDocumentFetchMode), TypeInfoPropertyName = "FluidtopicsDocumentFetchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseFluidtopicsSourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseFluidtopicsSourceConfigurationContentScope), TypeInfoPropertyName = "BaseFluidtopicsSourceConfigurationContentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vectara.FluidtopicsDocumentFetchMode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FluidtopicsSourceConfiguration), TypeInfoPropertyName = "FluidtopicsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseScimSourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseScimSourceConfigurationIncrementalStrategy), TypeInfoPropertyName = "BaseScimSourceConfigurationIncrementalStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ScimSourceConfiguration), TypeInfoPropertyName = "ScimSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseDoceboSourceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DoceboSourceConfiguration), TypeInfoPropertyName = "DoceboSourceConfiguration2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineProcessingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineWatermark))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Pipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListPipelinesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vectara.Pipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreatePipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateSharepointSourceConfiguration), TypeInfoPropertyName = "UpdateSharepointSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateS3SourceConfiguration), TypeInfoPropertyName = "UpdateS3SourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateGoogleDriveSourceConfiguration), TypeInfoPropertyName = "UpdateGoogleDriveSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateBoxSourceConfiguration), TypeInfoPropertyName = "UpdateBoxSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateWolkenKbSourceConfiguration), TypeInfoPropertyName = "UpdateWolkenKbSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateWolkenFormsSourceConfiguration), TypeInfoPropertyName = "UpdateWolkenFormsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateWolkenTicketsSourceConfiguration), TypeInfoPropertyName = "UpdateWolkenTicketsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateConfluenceSourceConfiguration), TypeInfoPropertyName = "UpdateConfluenceSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateFluidtopicsSourceConfiguration), TypeInfoPropertyName = "UpdateFluidtopicsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateScimSourceConfiguration), TypeInfoPropertyName = "UpdateScimSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateDoceboSourceConfiguration), TypeInfoPropertyName = "UpdateDoceboSourceConfiguration2")]
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
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricDescriptorDiscriminatorType), TypeInfoPropertyName = "MetricDescriptorDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricSeriesDiscriminatorType), TypeInfoPropertyName = "MetricSeriesDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterAttributeLevel?), TypeInfoPropertyName = "NullableFilterAttributeLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterAttributeType?), TypeInfoPropertyName = "NullableFilterAttributeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FilterAttributeStatType?), TypeInfoPropertyName = "NullableFilterAttributeStatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChunkingStrategy?), TypeInfoPropertyName = "NullableChunkingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChunkingStrategyDiscriminatorType?), TypeInfoPropertyName = "NullableChunkingStrategyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CoreDocumentPartImagePartMode?), TypeInfoPropertyName = "NullableCoreDocumentPartImagePartMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateDocumentRequest?), TypeInfoPropertyName = "NullableCreateDocumentRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateDocumentRequestDiscriminatorType?), TypeInfoPropertyName = "NullableCreateDocumentRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteAsyncResponseResponseType?), TypeInfoPropertyName = "NullableBulkDeleteAsyncResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteSyncSuccessResponseResponseType?), TypeInfoPropertyName = "NullableBulkDeleteSyncSuccessResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteDocumentsResponse?), TypeInfoPropertyName = "NullableBulkDeleteDocumentsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkDeleteDocumentsResponseDiscriminatorType?), TypeInfoPropertyName = "NullableBulkDeleteDocumentsResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataRequestStrategy?), TypeInfoPropertyName = "NullableBulkUpdateDocumentMetadataRequestStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataAsyncResponse?), TypeInfoPropertyName = "NullableBulkUpdateDocumentMetadataAsyncResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse?), TypeInfoPropertyName = "NullableBulkUpdateDocumentMetadataSyncSuccessResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataResponse?), TypeInfoPropertyName = "NullableBulkUpdateDocumentMetadataResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType?), TypeInfoPropertyName = "NullableBulkUpdateDocumentMetadataResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SummarizeDocumentStreamedResponse?), TypeInfoPropertyName = "NullableSummarizeDocumentStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType?), TypeInfoPropertyName = "NullableSummarizeDocumentStreamedResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetadataQueryRequestLevel?), TypeInfoPropertyName = "NullableMetadataQueryRequestLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Language?), TypeInfoPropertyName = "NullableLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TextSearchResult?), TypeInfoPropertyName = "NullableTextSearchResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageSearchResult?), TypeInfoPropertyName = "NullableImageSearchResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.IndividualSearchResult?), TypeInfoPropertyName = "NullableIndividualSearchResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.IndividualSearchResultDiscriminatorResultType?), TypeInfoPropertyName = "NullableIndividualSearchResultDiscriminatorResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryWarning?), TypeInfoPropertyName = "NullableQueryWarning2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchSemantics?), TypeInfoPropertyName = "NullableSearchSemantics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchReranker?), TypeInfoPropertyName = "NullableSearchReranker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchRerankerDiscriminatorType?), TypeInfoPropertyName = "NullableSearchRerankerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchParametersMaxBy?), TypeInfoPropertyName = "NullableSearchParametersMaxBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CitationParametersStyle?), TypeInfoPropertyName = "NullableCitationParametersStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AllOf<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>?), TypeInfoPropertyName = "NullableAllOfSearchCorpusSearchParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryStreamedResponse?), TypeInfoPropertyName = "NullableQueryStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryStreamedResponseDiscriminatorType?), TypeInfoPropertyName = "NullableQueryStreamedResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.KeyedSearchCorpus?), TypeInfoPropertyName = "NullableKeyedSearchCorpus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SearchCorporaParameters?), TypeInfoPropertyName = "NullableSearchCorporaParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RewrittenQueryWarning?), TypeInfoPropertyName = "NullableRewrittenQueryWarning2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryHistorySpan?), TypeInfoPropertyName = "NullableQueryHistorySpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.QueryHistorySpanDiscriminatorType?), TypeInfoPropertyName = "NullableQueryHistorySpanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatStreamedResponse?), TypeInfoPropertyName = "NullableChatStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatStreamedResponseDiscriminatorType?), TypeInfoPropertyName = "NullableChatStreamedResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LLMOwnership?), TypeInfoPropertyName = "NullableLLMOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LLMType?), TypeInfoPropertyName = "NullableLLMType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LLMAuth?), TypeInfoPropertyName = "NullableLLMAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LLMAuthDiscriminatorType?), TypeInfoPropertyName = "NullableLLMAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RemoteAuth?), TypeInfoPropertyName = "NullableRemoteAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RemoteAuthDiscriminatorType?), TypeInfoPropertyName = "NullableRemoteAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAILLMRequest?), TypeInfoPropertyName = "NullableCreateOpenAILLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateOpenAIResponsesLLMRequest?), TypeInfoPropertyName = "NullableCreateOpenAIResponsesLLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiAuth?), TypeInfoPropertyName = "NullableVertexAiAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.VertexAiAuthDiscriminatorType?), TypeInfoPropertyName = "NullableVertexAiAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AnthropicAuth?), TypeInfoPropertyName = "NullableAnthropicAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AnthropicAuthDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateLLMRequest?), TypeInfoPropertyName = "NullableCreateLLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateLLMRequestDiscriminatorType?), TypeInfoPropertyName = "NullableCreateLLMRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateOpenAILLMRequest?), TypeInfoPropertyName = "NullableUpdateOpenAILLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateOpenAIResponsesLLMRequest?), TypeInfoPropertyName = "NullableUpdateOpenAIResponsesLLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateLLMRequest?), TypeInfoPropertyName = "NullableUpdateLLMRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateLLMRequestDiscriminatorType?), TypeInfoPropertyName = "NullableUpdateLLMRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaDefinition?), TypeInfoPropertyName = "NullableJsonSchemaDefinition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaObject?), TypeInfoPropertyName = "NullableJsonSchemaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaValue?), TypeInfoPropertyName = "NullableJsonSchemaValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSchemaDefinitionDiscriminatorType?), TypeInfoPropertyName = "NullableJsonSchemaDefinitionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ResponseFormatType?), TypeInfoPropertyName = "NullableResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateChatCompletionResponseObject?), TypeInfoPropertyName = "NullableCreateChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateChatCompletionStreamResponseObject?), TypeInfoPropertyName = "NullableCreateChatCompletionStreamResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GenerationPresetOwnership?), TypeInfoPropertyName = "NullableGenerationPresetOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGenerationPresetRequest?), TypeInfoPropertyName = "NullableCreateGenerationPresetRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEncoderRequest?), TypeInfoPropertyName = "NullableCreateEncoderRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEncoderRequestDiscriminatorType?), TypeInfoPropertyName = "NullableCreateEncoderRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JobState?), TypeInfoPropertyName = "NullableJobState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JobProgressPhase?), TypeInfoPropertyName = "NullableJobProgressPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JobType?), TypeInfoPropertyName = "NullableJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ApiRole?), TypeInfoPropertyName = "NullableApiRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorpusRoleRole?), TypeInfoPropertyName = "NullableCorpusRoleRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentRoleRole?), TypeInfoPropertyName = "NullableAgentRoleRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ApiKeyRole?), TypeInfoPropertyName = "NullableApiKeyRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAppClientRequest?), TypeInfoPropertyName = "NullableCreateAppClientRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAppClientRequestDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAppClientRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolServerType?), TypeInfoPropertyName = "NullableToolServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolServerTransport?), TypeInfoPropertyName = "NullableToolServerTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DynamicVectaraTool?), TypeInfoPropertyName = "NullableDynamicVectaraTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.McpTool?), TypeInfoPropertyName = "NullableMcpTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorporaSearchTool?), TypeInfoPropertyName = "NullableCorporaSearchTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchTool?), TypeInfoPropertyName = "NullableWebSearchTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetTool?), TypeInfoPropertyName = "NullableWebGetTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FunctionDefinitionLanguage?), TypeInfoPropertyName = "NullableFunctionDefinitionLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FunctionDefinitionValidationStatus?), TypeInfoPropertyName = "NullableFunctionDefinitionValidationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolOutputOffloadingConfigurationMode?), TypeInfoPropertyName = "NullableToolOutputOffloadingConfigurationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolConfigurationReference?), TypeInfoPropertyName = "NullableToolConfigurationReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DynamicVectaraToolConfiguration?), TypeInfoPropertyName = "NullableDynamicVectaraToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.McpToolConfiguration?), TypeInfoPropertyName = "NullableMcpToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<string, global::Vectara.EagerReference>?), TypeInfoPropertyName = "NullableOneOfStringEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CorporaSearchToolConfiguration?), TypeInfoPropertyName = "NullableCorporaSearchToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolParametersProvider?), TypeInfoPropertyName = "NullableWebSearchToolParametersProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSearchToolConfiguration?), TypeInfoPropertyName = "NullableWebSearchToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetHeaderValue?), TypeInfoPropertyName = "NullableWebGetHeaderValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement?), TypeInfoPropertyName = "NullableWebGetOAuthTokenExchangeAuthSubjectPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation?), TypeInfoPropertyName = "NullableWebGetOAuthTokenExchangeAuthParamLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetAuth?), TypeInfoPropertyName = "NullableWebGetAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetAuthDiscriminatorType?), TypeInfoPropertyName = "NullableWebGetAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolParametersMethod?), TypeInfoPropertyName = "NullableWebGetToolParametersMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<global::Vectara.WebGetHeadersMap, global::Vectara.EagerReference>?), TypeInfoPropertyName = "NullableOneOfWebGetHeadersMapEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<bool?, global::Vectara.EagerReference>?), TypeInfoPropertyName = "NullableOneOfBooleanEagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<int?, global::Vectara.EagerReference>?), TypeInfoPropertyName = "NullableOneOfInt32EagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OneOf<long?, global::Vectara.EagerReference>?), TypeInfoPropertyName = "NullableOneOfInt64EagerReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolParametersResponseMode?), TypeInfoPropertyName = "NullableWebGetToolParametersResponseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebGetToolConfiguration?), TypeInfoPropertyName = "NullableWebGetToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaToolConfiguration?), TypeInfoPropertyName = "NullableLambdaToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolConfiguration?), TypeInfoPropertyName = "NullableClientToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentSessionMode?), TypeInfoPropertyName = "NullableSubAgentSessionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentToolConfiguration?), TypeInfoPropertyName = "NullableSubAgentToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolParametersEncoding?), TypeInfoPropertyName = "NullableArtifactReadToolParametersEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadToolConfiguration?), TypeInfoPropertyName = "NullableArtifactReadToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactGrepToolConfiguration?), TypeInfoPropertyName = "NullableArtifactGrepToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolParametersDetail?), TypeInfoPropertyName = "NullableImageReadToolParametersDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadToolConfiguration?), TypeInfoPropertyName = "NullableImageReadToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolParametersOutputFormat?), TypeInfoPropertyName = "NullableDocumentConversionToolParametersOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionToolConfiguration?), TypeInfoPropertyName = "NullableDocumentConversionToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextToolConfiguration?), TypeInfoPropertyName = "NullableGetDocumentTextToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentToolConfiguration?), TypeInfoPropertyName = "NullableAgentToolConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentToolConfigurationDiscriminatorType?), TypeInfoPropertyName = "NullableAgentToolConfigurationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaTool?), TypeInfoPropertyName = "NullableLambdaTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.LambdaToolVariant2Language?), TypeInfoPropertyName = "NullableLambdaToolVariant2Language2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentTool?), TypeInfoPropertyName = "NullableSubAgentTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactCreateTool?), TypeInfoPropertyName = "NullableArtifactCreateTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactReadTool?), TypeInfoPropertyName = "NullableArtifactReadTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactGrepTool?), TypeInfoPropertyName = "NullableArtifactGrepTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadTool?), TypeInfoPropertyName = "NullableImageReadTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DocumentConversionTool?), TypeInfoPropertyName = "NullableDocumentConversionTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GetDocumentTextTool?), TypeInfoPropertyName = "NullableGetDocumentTextTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientTool?), TypeInfoPropertyName = "NullableClientTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Tool?), TypeInfoPropertyName = "NullableTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolDiscriminatorType?), TypeInfoPropertyName = "NullableToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateLambdaToolRequestLanguage?), TypeInfoPropertyName = "NullableCreateLambdaToolRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolRequest?), TypeInfoPropertyName = "NullableCreateToolRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolRequestDiscriminatorType?), TypeInfoPropertyName = "NullableCreateToolRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolRequestLanguage?), TypeInfoPropertyName = "NullableTestLambdaToolRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestLambdaToolResponseValidationStatus?), TypeInfoPropertyName = "NullableTestLambdaToolResponseValidationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateToolRequest?), TypeInfoPropertyName = "NullableUpdateToolRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateToolRequestDiscriminatorType?), TypeInfoPropertyName = "NullableUpdateToolRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestToolResponse?), TypeInfoPropertyName = "NullableTestToolResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TestToolResponseDiscriminatorType?), TypeInfoPropertyName = "NullableTestToolResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TemplateType?), TypeInfoPropertyName = "NullableTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.Instruction?), TypeInfoPropertyName = "NullableInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InstructionDiscriminatorType?), TypeInfoPropertyName = "NullableInstructionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInitialInstructionRequest?), TypeInfoPropertyName = "NullableCreateInitialInstructionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInstructionRequest?), TypeInfoPropertyName = "NullableCreateInstructionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInstructionRequestDiscriminatorType?), TypeInfoPropertyName = "NullableCreateInstructionRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateInstructionRequest?), TypeInfoPropertyName = "NullableUpdateInstructionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateInstructionRequestDiscriminatorType?), TypeInfoPropertyName = "NullableUpdateInstructionRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReferenceInstruction?), TypeInfoPropertyName = "NullableReferenceInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InlineInstruction?), TypeInfoPropertyName = "NullableInlineInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStepInstruction?), TypeInfoPropertyName = "NullableAgentStepInstruction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStepInstructionDiscriminatorType?), TypeInfoPropertyName = "NullableAgentStepInstructionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputParser?), TypeInfoPropertyName = "NullableAgentOutputParser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputParserDiscriminatorType?), TypeInfoPropertyName = "NullableAgentOutputParserDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.TemplatedReminderHook?), TypeInfoPropertyName = "NullableTemplatedReminderHook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStepReminder?), TypeInfoPropertyName = "NullableAgentStepReminder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStepReminderDiscriminatorType?), TypeInfoPropertyName = "NullableAgentStepReminderDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionConfigToolEventPolicy?), TypeInfoPropertyName = "NullableCompactionConfigToolEventPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ReplaceAgentRequest?), TypeInfoPropertyName = "NullableReplaceAgentRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentSessionStatus?), TypeInfoPropertyName = "NullableAgentSessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentInput?), TypeInfoPropertyName = "NullableAgentInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentInputDiscriminatorType?), TypeInfoPropertyName = "NullableAgentInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InputMessageEvent?), TypeInfoPropertyName = "NullableInputMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SkillLoadEvent?), TypeInfoPropertyName = "NullableSkillLoadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ArtifactUploadEvent?), TypeInfoPropertyName = "NullableArtifactUploadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolInputEvent?), TypeInfoPropertyName = "NullableToolInputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolOutputEvent?), TypeInfoPropertyName = "NullableToolOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ThinkingEvent?), TypeInfoPropertyName = "NullableThinkingEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputEvent?), TypeInfoPropertyName = "NullableAgentOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StructuredOutputEvent?), TypeInfoPropertyName = "NullableStructuredOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ContextLimitExceededEvent?), TypeInfoPropertyName = "NullableContextLimitExceededEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StepTransitionLimitExceededEvent?), TypeInfoPropertyName = "NullableStepTransitionLimitExceededEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SessionInterruptedEvent?), TypeInfoPropertyName = "NullableSessionInterruptedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentErrorEvent?), TypeInfoPropertyName = "NullableAgentErrorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolPendingEvent?), TypeInfoPropertyName = "NullableClientToolPendingEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadEvent?), TypeInfoPropertyName = "NullableImageReadEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadEventVariant2Detail?), TypeInfoPropertyName = "NullableImageReadEventVariant2Detail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StepTransitionEvent?), TypeInfoPropertyName = "NullableStepTransitionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionEvent?), TypeInfoPropertyName = "NullableCompactionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentEvent?), TypeInfoPropertyName = "NullableAgentEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentEventDiscriminatorType?), TypeInfoPropertyName = "NullableAgentEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InputBehavior?), TypeInfoPropertyName = "NullableInputBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputMessageRequest?), TypeInfoPropertyName = "NullableCreateInputMessageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInterruptRequest?), TypeInfoPropertyName = "NullableCreateInterruptRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateCompactRequest?), TypeInfoPropertyName = "NullableCreateCompactRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputSuccess?), TypeInfoPropertyName = "NullableCreateToolOutputSuccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputError?), TypeInfoPropertyName = "NullableCreateToolOutputError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputRequest?), TypeInfoPropertyName = "NullableCreateToolOutputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateToolOutputRequestDiscriminatorType?), TypeInfoPropertyName = "NullableCreateToolOutputRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ClientToolOutputRequest?), TypeInfoPropertyName = "NullableClientToolOutputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputRequest?), TypeInfoPropertyName = "NullableCreateInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateInputRequestDiscriminatorType?), TypeInfoPropertyName = "NullableCreateInputRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionStartedEvent?), TypeInfoPropertyName = "NullableCompactionStartedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GenericToolActivityEvent?), TypeInfoPropertyName = "NullableGenericToolActivityEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SubAgentToolActivityEvent?), TypeInfoPropertyName = "NullableSubAgentToolActivityEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolActivityEvent?), TypeInfoPropertyName = "NullableToolActivityEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ToolActivityEventDiscriminatorActivityType?), TypeInfoPropertyName = "NullableToolActivityEventDiscriminatorActivityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStreamedResponse?), TypeInfoPropertyName = "NullableAgentStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentStreamedResponseDiscriminatorType?), TypeInfoPropertyName = "NullableAgentStreamedResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.IntervalScheduleConfigurationType?), TypeInfoPropertyName = "NullableIntervalScheduleConfigurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CronScheduleConfigurationType?), TypeInfoPropertyName = "NullableCronScheduleConfigurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ScheduleConfiguration?), TypeInfoPropertyName = "NullableScheduleConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentScheduleExecutionStatus?), TypeInfoPropertyName = "NullableAgentScheduleExecutionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentIdentityMode?), TypeInfoPropertyName = "NullableAgentIdentityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorStatus?), TypeInfoPropertyName = "NullableConnectorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentOutputType?), TypeInfoPropertyName = "NullableAgentOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SlackConnectorConfiguration?), TypeInfoPropertyName = "NullableSlackConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GchatConnectorConfiguration?), TypeInfoPropertyName = "NullableGchatConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ZoomConnectorConfiguration?), TypeInfoPropertyName = "NullableZoomConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WidgetConnectorConfiguration?), TypeInfoPropertyName = "NullableWidgetConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorConfiguration?), TypeInfoPropertyName = "NullableConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorConfigurationDiscriminatorType?), TypeInfoPropertyName = "NullableConnectorConfigurationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConnectorWebhookStatus?), TypeInfoPropertyName = "NullableConnectorWebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SlackAgentConnector?), TypeInfoPropertyName = "NullableSlackAgentConnector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GchatAgentConnector?), TypeInfoPropertyName = "NullableGchatAgentConnector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ZoomAgentConnector?), TypeInfoPropertyName = "NullableZoomAgentConnector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WidgetAgentConnector?), TypeInfoPropertyName = "NullableWidgetAgentConnector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentConnector?), TypeInfoPropertyName = "NullableAgentConnector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentConnectorDiscriminatorType?), TypeInfoPropertyName = "NullableAgentConnectorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateSlackConnectorConfiguration?), TypeInfoPropertyName = "NullableCreateSlackConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateSlackAgentConnectorRequest?), TypeInfoPropertyName = "NullableCreateSlackAgentConnectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGchatConnectorConfiguration?), TypeInfoPropertyName = "NullableCreateGchatConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateGchatAgentConnectorRequest?), TypeInfoPropertyName = "NullableCreateGchatAgentConnectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateZoomConnectorConfiguration?), TypeInfoPropertyName = "NullableCreateZoomConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateZoomAgentConnectorRequest?), TypeInfoPropertyName = "NullableCreateZoomAgentConnectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateWidgetConnectorConfiguration?), TypeInfoPropertyName = "NullableCreateWidgetConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateWidgetAgentConnectorRequest?), TypeInfoPropertyName = "NullableCreateWidgetAgentConnectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentConnectorRequest?), TypeInfoPropertyName = "NullableCreateAgentConnectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateAgentConnectorRequestDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAgentConnectorRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateConnectorConfiguration?), TypeInfoPropertyName = "NullableCreateConnectorConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateConnectorConfigurationDiscriminatorType?), TypeInfoPropertyName = "NullableCreateConnectorConfigurationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03Role?), TypeInfoPropertyName = "NullableA2aV03Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV03TaskState?), TypeInfoPropertyName = "NullableA2aV03TaskState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1Role?), TypeInfoPropertyName = "NullableA2aV1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.A2aV1TaskState?), TypeInfoPropertyName = "NullableA2aV1TaskState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RuleTargets?), TypeInfoPropertyName = "NullableRuleTargets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RuleTargetsDiscriminatorType?), TypeInfoPropertyName = "NullableRuleTargetsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AliasPolicy?), TypeInfoPropertyName = "NullableAliasPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AliasPolicyDiscriminatorType?), TypeInfoPropertyName = "NullableAliasPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserSessionStatus?), TypeInfoPropertyName = "NullableEndUserSessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserInputMessageEvent?), TypeInfoPropertyName = "NullableEndUserInputMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserAgentOutputEvent?), TypeInfoPropertyName = "NullableEndUserAgentOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserErrorEvent?), TypeInfoPropertyName = "NullableEndUserErrorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserEvent?), TypeInfoPropertyName = "NullableEndUserEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserEventDiscriminatorType?), TypeInfoPropertyName = "NullableEndUserEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInputMessageRequest?), TypeInfoPropertyName = "NullableCreateEndUserInputMessageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInterruptRequest?), TypeInfoPropertyName = "NullableCreateEndUserInterruptRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInputRequest?), TypeInfoPropertyName = "NullableCreateEndUserInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateEndUserInputRequestDiscriminatorType?), TypeInfoPropertyName = "NullableCreateEndUserInputRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserAgentStreamedResponse?), TypeInfoPropertyName = "NullableEndUserAgentStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.EndUserAgentStreamedResponseDiscriminatorType?), TypeInfoPropertyName = "NullableEndUserAgentStreamedResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineStatus?), TypeInfoPropertyName = "NullablePipelineStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AclAccessLevel?), TypeInfoPropertyName = "NullableAclAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SharepointSourceConfiguration?), TypeInfoPropertyName = "NullableSharepointSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.S3SourceConfiguration?), TypeInfoPropertyName = "NullableS3SourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GoogleDriveScope?), TypeInfoPropertyName = "NullableGoogleDriveScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GoogleDriveScopeDiscriminatorType?), TypeInfoPropertyName = "NullableGoogleDriveScopeDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GoogleDriveSourceConfiguration?), TypeInfoPropertyName = "NullableGoogleDriveSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BoxSourceConfiguration?), TypeInfoPropertyName = "NullableBoxSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WolkenArticleStatus?), TypeInfoPropertyName = "NullableWolkenArticleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseWolkenKbSourceConfigurationKbApi?), TypeInfoPropertyName = "NullableBaseWolkenKbSourceConfigurationKbApi2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator?), TypeInfoPropertyName = "NullableBaseWolkenKbSourceConfigurationUpdateUpperBoundOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WolkenKbSourceConfiguration?), TypeInfoPropertyName = "NullableWolkenKbSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WolkenFormsSourceConfiguration?), TypeInfoPropertyName = "NullableWolkenFormsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WolkenTicketRequestType?), TypeInfoPropertyName = "NullableWolkenTicketRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WolkenTicketsSourceConfiguration?), TypeInfoPropertyName = "NullableWolkenTicketsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseConfluenceSourceConfigurationDeployment?), TypeInfoPropertyName = "NullableBaseConfluenceSourceConfigurationDeployment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ConfluenceSourceConfiguration?), TypeInfoPropertyName = "NullableConfluenceSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FluidtopicsDocumentFetchMode?), TypeInfoPropertyName = "NullableFluidtopicsDocumentFetchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseFluidtopicsSourceConfigurationContentScope?), TypeInfoPropertyName = "NullableBaseFluidtopicsSourceConfigurationContentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.FluidtopicsSourceConfiguration?), TypeInfoPropertyName = "NullableFluidtopicsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.BaseScimSourceConfigurationIncrementalStrategy?), TypeInfoPropertyName = "NullableBaseScimSourceConfigurationIncrementalStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ScimSourceConfiguration?), TypeInfoPropertyName = "NullableScimSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DoceboSourceConfiguration?), TypeInfoPropertyName = "NullableDoceboSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CrawlPagesSource?), TypeInfoPropertyName = "NullableCrawlPagesSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SitemapCrawlPagesSource?), TypeInfoPropertyName = "NullableSitemapCrawlPagesSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebPagesSource?), TypeInfoPropertyName = "NullableWebPagesSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebPagesSourceDiscriminatorType?), TypeInfoPropertyName = "NullableWebPagesSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WebSourceConfiguration?), TypeInfoPropertyName = "NullableWebSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineSource?), TypeInfoPropertyName = "NullablePipelineSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineSourceDiscriminatorType?), TypeInfoPropertyName = "NullablePipelineSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineTrigger?), TypeInfoPropertyName = "NullablePipelineTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineTriggerDiscriminatorType?), TypeInfoPropertyName = "NullablePipelineTriggerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineVerification?), TypeInfoPropertyName = "NullablePipelineVerification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineVerificationDiscriminatorType?), TypeInfoPropertyName = "NullablePipelineVerificationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineTransformDiscriminatorType?), TypeInfoPropertyName = "NullablePipelineTransformDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineSyncMode?), TypeInfoPropertyName = "NullablePipelineSyncMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateSharepointSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateSharepointSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateS3SourceConfiguration?), TypeInfoPropertyName = "NullableUpdateS3SourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateGoogleDriveSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateGoogleDriveSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateBoxSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateBoxSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateWolkenKbSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateWolkenKbSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateWolkenFormsSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateWolkenFormsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateWolkenTicketsSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateWolkenTicketsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateConfluenceSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateConfluenceSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateFluidtopicsSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateFluidtopicsSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateScimSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateScimSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateDoceboSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateDoceboSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdateWebSourceConfiguration?), TypeInfoPropertyName = "NullableUpdateWebSourceConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdatePipelineSource?), TypeInfoPropertyName = "NullableUpdatePipelineSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.UpdatePipelineSourceDiscriminatorType?), TypeInfoPropertyName = "NullableUpdatePipelineSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunStatus?), TypeInfoPropertyName = "NullablePipelineRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunTriggerType?), TypeInfoPropertyName = "NullablePipelineRunTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DeadLetterStatus?), TypeInfoPropertyName = "NullableDeadLetterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DeadLetterOrigin?), TypeInfoPropertyName = "NullableDeadLetterOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunEventType?), TypeInfoPropertyName = "NullablePipelineRunEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.SortOrder?), TypeInfoPropertyName = "NullableSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RunStartedEvent?), TypeInfoPropertyName = "NullableRunStartedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RunCompletedEventStatus?), TypeInfoPropertyName = "NullableRunCompletedEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RunCompletedEvent?), TypeInfoPropertyName = "NullableRunCompletedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RecordProcessingEventStatus?), TypeInfoPropertyName = "NullableRecordProcessingEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.RecordProcessingEvent?), TypeInfoPropertyName = "NullableRecordProcessingEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.WatermarkAdvancedEvent?), TypeInfoPropertyName = "NullableWatermarkAdvancedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunEvent?), TypeInfoPropertyName = "NullablePipelineRunEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PipelineRunEventDiscriminatorType?), TypeInfoPropertyName = "NullablePipelineRunEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CounterMetricDescriptor?), TypeInfoPropertyName = "NullableCounterMetricDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GaugeMetricDescriptor?), TypeInfoPropertyName = "NullableGaugeMetricDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PercentilesMetricDescriptor?), TypeInfoPropertyName = "NullablePercentilesMetricDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DistributionMetricDescriptor?), TypeInfoPropertyName = "NullableDistributionMetricDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricDescriptor?), TypeInfoPropertyName = "NullableMetricDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricDescriptorDiscriminatorType?), TypeInfoPropertyName = "NullableMetricDescriptorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CounterMetricSeries?), TypeInfoPropertyName = "NullableCounterMetricSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.GaugeMetricSeries?), TypeInfoPropertyName = "NullableGaugeMetricSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.PercentilesMetricSeries?), TypeInfoPropertyName = "NullablePercentilesMetricSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.DistributionMetricSeries?), TypeInfoPropertyName = "NullableDistributionMetricSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricSeries?), TypeInfoPropertyName = "NullableMetricSeries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.MetricSeriesDiscriminatorType?), TypeInfoPropertyName = "NullableMetricSeriesDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceStatus?), TypeInfoPropertyName = "NullableAgentTraceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceSpanStatus?), TypeInfoPropertyName = "NullableAgentTraceSpanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InvokeAgentSpanAttributesOutputType?), TypeInfoPropertyName = "NullableInvokeAgentSpanAttributesOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.InvokeAgentTraceSpan?), TypeInfoPropertyName = "NullableInvokeAgentTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ChatTraceSpan?), TypeInfoPropertyName = "NullableChatTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ExecuteToolTraceSpan?), TypeInfoPropertyName = "NullableExecuteToolTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ThinkingTraceSpan?), TypeInfoPropertyName = "NullableThinkingTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.OutputTraceSpan?), TypeInfoPropertyName = "NullableOutputTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.StepTransitionTraceSpan?), TypeInfoPropertyName = "NullableStepTransitionTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ImageReadTraceSpan?), TypeInfoPropertyName = "NullableImageReadTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CompactionTraceSpan?), TypeInfoPropertyName = "NullableCompactionTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceSpan?), TypeInfoPropertyName = "NullableAgentTraceSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AgentTraceSpanDiscriminatorOperation?), TypeInfoPropertyName = "NullableAgentTraceSpanDiscriminatorOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.CreateCorpusDocumentWaitFor?), TypeInfoPropertyName = "NullableCreateCorpusDocumentWaitFor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListToolServersType?), TypeInfoPropertyName = "NullableListToolServersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListToolsType?), TypeInfoPropertyName = "NullableListToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListInstructionsType?), TypeInfoPropertyName = "NullableListInstructionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListSessionArtifactsSortBy?), TypeInfoPropertyName = "NullableListSessionArtifactsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListSessionArtifactsOrderBy?), TypeInfoPropertyName = "NullableListSessionArtifactsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAgentConnectorsType?), TypeInfoPropertyName = "NullableListAgentConnectorsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAliasRoutedSessionArtifactsSortBy?), TypeInfoPropertyName = "NullableListAliasRoutedSessionArtifactsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListAliasRoutedSessionArtifactsOrderBy?), TypeInfoPropertyName = "NullableListAliasRoutedSessionArtifactsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListPipelinesSourceType?), TypeInfoPropertyName = "NullableListPipelinesSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTracesStatus?), TypeInfoPropertyName = "NullableListTracesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTracesErrorType?), TypeInfoPropertyName = "NullableListTracesErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTracesOperation?), TypeInfoPropertyName = "NullableListTracesOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTracesToolErrorType?), TypeInfoPropertyName = "NullableListTracesToolErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.ListTraceSpansOperation?), TypeInfoPropertyName = "NullableListTraceSpansOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.AllOf<global::Vectara.User, global::Vectara.CreateUserResponse2>?), TypeInfoPropertyName = "NullableAllOfUserCreateUserResponse22")]
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
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.KeyedSearchCorpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.RerankedSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.RewrittenQueryWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.QueryHistorySpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.QueryHistorySummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Chat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Turn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Llm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.DiscoveredLLM>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentKeyedSearchCorpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.Instruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.TemplatedReminderHook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentStepInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentStepReminder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.NextStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.SessionEnrichmentToolCall>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentOutputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV03AgentExtension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV03AgentInterface>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV03AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV03AgentCardSignature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV03Part>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV03Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV03Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV1AgentExtension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV1AgentInterface>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV1AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV1AgentCardSignature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV1Part>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV1Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV1Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.A2aV1Task>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.WeightedTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AliasRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.AgentAlias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.EndUserSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.EndUserEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.TrustedTokenIssuer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.GoogleDriveScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.WolkenArticleStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vectara.WolkenTicketRequestType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
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
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

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
            options.Converters.Add(new global::Vectara.JsonConverters.ChunkingStrategyJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateDocumentRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.BulkDeleteDocumentsResponseJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.BulkUpdateDocumentMetadataAsyncResponseJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.BulkUpdateDocumentMetadataSyncSuccessResponseJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.BulkUpdateDocumentMetadataResponseJsonConverter());
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
            options.Converters.Add(new global::Vectara.JsonConverters.JsonSchemaDefinitionJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.JsonSchemaObjectJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.JsonSchemaValueJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateGenerationPresetRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateEncoderRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateAppClientRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DynamicVectaraToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.McpToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CorporaSearchToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebSearchToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetToolJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ToolConfigurationReferenceJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DynamicVectaraToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.McpToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CorporaSearchToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebSearchToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetHeaderValueJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetAuthJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WebGetToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.LambdaToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ClientToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SubAgentToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ArtifactReadToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ArtifactGrepToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ImageReadToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DocumentConversionToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GetDocumentTextToolConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentToolConfigurationJsonConverter());
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
            options.Converters.Add(new global::Vectara.JsonConverters.ReferenceInstructionJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.InlineInstructionJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStepInstructionJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentOutputParserJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentStepReminderJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ReplaceAgentRequestJsonConverter());
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
            options.Converters.Add(new global::Vectara.JsonConverters.AgentErrorEventJsonConverter());
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
            options.Converters.Add(new global::Vectara.JsonConverters.ZoomConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WidgetConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SlackAgentConnectorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GchatAgentConnectorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ZoomAgentConnectorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WidgetAgentConnectorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AgentConnectorJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateSlackConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateSlackAgentConnectorRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateGchatConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateGchatAgentConnectorRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateZoomConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateZoomAgentConnectorRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateWidgetConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateWidgetAgentConnectorRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateAgentConnectorRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateConnectorConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.RuleTargetsJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.AliasPolicyJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.EndUserInputMessageEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.EndUserAgentOutputEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.EndUserErrorEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.EndUserEventJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateEndUserInputMessageRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateEndUserInterruptRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.CreateEndUserInputRequestJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.EndUserAgentStreamedResponseJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.SharepointSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.S3SourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GoogleDriveScopeJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.GoogleDriveSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.BoxSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WolkenKbSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WolkenFormsSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.WolkenTicketsSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ConfluenceSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.FluidtopicsSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.ScimSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.DoceboSourceConfigurationJsonConverter());
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
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateBoxSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateWolkenKbSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateWolkenFormsSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateWolkenTicketsSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateConfluenceSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateFluidtopicsSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateScimSourceConfigurationJsonConverter());
            options.Converters.Add(new global::Vectara.JsonConverters.UpdateDoceboSourceConfigurationJsonConverter());
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
            options.Converters.Add(new global::Vectara.JsonConverters.OneOfJsonConverter<long?, global::Vectara.EagerReference>());
            options.Converters.Add(new global::Vectara.JsonConverters.AllOfJsonConverter<global::Vectara.User, global::Vectara.CreateUserResponse2>());
            options.Converters.Add(new global::Vectara.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vectara.FilterAttributeLevel)

                    || typeToConvert == typeof(global::Vectara.FilterAttributeLevel?)

                    || typeToConvert == typeof(global::Vectara.FilterAttributeType)

                    || typeToConvert == typeof(global::Vectara.FilterAttributeType?)

                    || typeToConvert == typeof(global::Vectara.FilterAttributeStatType)

                    || typeToConvert == typeof(global::Vectara.FilterAttributeStatType?)

                    || typeToConvert == typeof(global::Vectara.ChunkingStrategyDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.ChunkingStrategyDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.CoreDocumentPartImagePartMode)

                    || typeToConvert == typeof(global::Vectara.CoreDocumentPartImagePartMode?)

                    || typeToConvert == typeof(global::Vectara.CreateDocumentRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateDocumentRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.BulkDeleteAsyncResponseResponseType)

                    || typeToConvert == typeof(global::Vectara.BulkDeleteAsyncResponseResponseType?)

                    || typeToConvert == typeof(global::Vectara.BulkDeleteSyncSuccessResponseResponseType)

                    || typeToConvert == typeof(global::Vectara.BulkDeleteSyncSuccessResponseResponseType?)

                    || typeToConvert == typeof(global::Vectara.BulkDeleteDocumentsResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.BulkDeleteDocumentsResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.BulkUpdateDocumentMetadataRequestStrategy)

                    || typeToConvert == typeof(global::Vectara.BulkUpdateDocumentMetadataRequestStrategy?)

                    || typeToConvert == typeof(global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.MetadataQueryRequestLevel)

                    || typeToConvert == typeof(global::Vectara.MetadataQueryRequestLevel?)

                    || typeToConvert == typeof(global::Vectara.Language)

                    || typeToConvert == typeof(global::Vectara.Language?)

                    || typeToConvert == typeof(global::Vectara.IndividualSearchResultDiscriminatorResultType)

                    || typeToConvert == typeof(global::Vectara.IndividualSearchResultDiscriminatorResultType?)

                    || typeToConvert == typeof(global::Vectara.QueryWarning)

                    || typeToConvert == typeof(global::Vectara.QueryWarning?)

                    || typeToConvert == typeof(global::Vectara.SearchSemantics)

                    || typeToConvert == typeof(global::Vectara.SearchSemantics?)

                    || typeToConvert == typeof(global::Vectara.SearchRerankerDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.SearchRerankerDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.SearchParametersMaxBy)

                    || typeToConvert == typeof(global::Vectara.SearchParametersMaxBy?)

                    || typeToConvert == typeof(global::Vectara.CitationParametersStyle)

                    || typeToConvert == typeof(global::Vectara.CitationParametersStyle?)

                    || typeToConvert == typeof(global::Vectara.QueryStreamedResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.QueryStreamedResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.RewrittenQueryWarning)

                    || typeToConvert == typeof(global::Vectara.RewrittenQueryWarning?)

                    || typeToConvert == typeof(global::Vectara.QueryHistorySpanDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.QueryHistorySpanDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.ChatStreamedResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.ChatStreamedResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.LLMOwnership)

                    || typeToConvert == typeof(global::Vectara.LLMOwnership?)

                    || typeToConvert == typeof(global::Vectara.LLMType)

                    || typeToConvert == typeof(global::Vectara.LLMType?)

                    || typeToConvert == typeof(global::Vectara.LLMAuthDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.LLMAuthDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.RemoteAuthDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.RemoteAuthDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.VertexAiAuthDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.VertexAiAuthDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.AnthropicAuthDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.AnthropicAuthDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.CreateLLMRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateLLMRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.UpdateLLMRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.UpdateLLMRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.JsonSchemaDefinitionDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.JsonSchemaDefinitionDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.ResponseFormatType)

                    || typeToConvert == typeof(global::Vectara.ResponseFormatType?)

                    || typeToConvert == typeof(global::Vectara.CreateChatCompletionResponseObject)

                    || typeToConvert == typeof(global::Vectara.CreateChatCompletionResponseObject?)

                    || typeToConvert == typeof(global::Vectara.CreateChatCompletionStreamResponseObject)

                    || typeToConvert == typeof(global::Vectara.CreateChatCompletionStreamResponseObject?)

                    || typeToConvert == typeof(global::Vectara.GenerationPresetOwnership)

                    || typeToConvert == typeof(global::Vectara.GenerationPresetOwnership?)

                    || typeToConvert == typeof(global::Vectara.CreateEncoderRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateEncoderRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.JobState)

                    || typeToConvert == typeof(global::Vectara.JobState?)

                    || typeToConvert == typeof(global::Vectara.JobProgressPhase)

                    || typeToConvert == typeof(global::Vectara.JobProgressPhase?)

                    || typeToConvert == typeof(global::Vectara.JobType)

                    || typeToConvert == typeof(global::Vectara.JobType?)

                    || typeToConvert == typeof(global::Vectara.ApiRole)

                    || typeToConvert == typeof(global::Vectara.ApiRole?)

                    || typeToConvert == typeof(global::Vectara.CorpusRoleRole)

                    || typeToConvert == typeof(global::Vectara.CorpusRoleRole?)

                    || typeToConvert == typeof(global::Vectara.AgentRoleRole)

                    || typeToConvert == typeof(global::Vectara.AgentRoleRole?)

                    || typeToConvert == typeof(global::Vectara.ApiKeyRole)

                    || typeToConvert == typeof(global::Vectara.ApiKeyRole?)

                    || typeToConvert == typeof(global::Vectara.CreateAppClientRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateAppClientRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.ToolServerType)

                    || typeToConvert == typeof(global::Vectara.ToolServerType?)

                    || typeToConvert == typeof(global::Vectara.ToolServerTransport)

                    || typeToConvert == typeof(global::Vectara.ToolServerTransport?)

                    || typeToConvert == typeof(global::Vectara.FunctionDefinitionLanguage)

                    || typeToConvert == typeof(global::Vectara.FunctionDefinitionLanguage?)

                    || typeToConvert == typeof(global::Vectara.FunctionDefinitionValidationStatus)

                    || typeToConvert == typeof(global::Vectara.FunctionDefinitionValidationStatus?)

                    || typeToConvert == typeof(global::Vectara.ToolOutputOffloadingConfigurationMode)

                    || typeToConvert == typeof(global::Vectara.ToolOutputOffloadingConfigurationMode?)

                    || typeToConvert == typeof(global::Vectara.WebSearchToolParametersProvider)

                    || typeToConvert == typeof(global::Vectara.WebSearchToolParametersProvider?)

                    || typeToConvert == typeof(global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement)

                    || typeToConvert == typeof(global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement?)

                    || typeToConvert == typeof(global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation)

                    || typeToConvert == typeof(global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation?)

                    || typeToConvert == typeof(global::Vectara.WebGetAuthDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.WebGetAuthDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.WebGetToolParametersMethod)

                    || typeToConvert == typeof(global::Vectara.WebGetToolParametersMethod?)

                    || typeToConvert == typeof(global::Vectara.WebGetToolParametersResponseMode)

                    || typeToConvert == typeof(global::Vectara.WebGetToolParametersResponseMode?)

                    || typeToConvert == typeof(global::Vectara.SubAgentSessionMode)

                    || typeToConvert == typeof(global::Vectara.SubAgentSessionMode?)

                    || typeToConvert == typeof(global::Vectara.ArtifactReadToolParametersEncoding)

                    || typeToConvert == typeof(global::Vectara.ArtifactReadToolParametersEncoding?)

                    || typeToConvert == typeof(global::Vectara.ImageReadToolParametersDetail)

                    || typeToConvert == typeof(global::Vectara.ImageReadToolParametersDetail?)

                    || typeToConvert == typeof(global::Vectara.DocumentConversionToolParametersOutputFormat)

                    || typeToConvert == typeof(global::Vectara.DocumentConversionToolParametersOutputFormat?)

                    || typeToConvert == typeof(global::Vectara.AgentToolConfigurationDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.AgentToolConfigurationDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.LambdaToolVariant2Language)

                    || typeToConvert == typeof(global::Vectara.LambdaToolVariant2Language?)

                    || typeToConvert == typeof(global::Vectara.ToolDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.ToolDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.CreateLambdaToolRequestLanguage)

                    || typeToConvert == typeof(global::Vectara.CreateLambdaToolRequestLanguage?)

                    || typeToConvert == typeof(global::Vectara.CreateToolRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateToolRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.TestLambdaToolRequestLanguage)

                    || typeToConvert == typeof(global::Vectara.TestLambdaToolRequestLanguage?)

                    || typeToConvert == typeof(global::Vectara.TestLambdaToolResponseValidationStatus)

                    || typeToConvert == typeof(global::Vectara.TestLambdaToolResponseValidationStatus?)

                    || typeToConvert == typeof(global::Vectara.UpdateToolRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.UpdateToolRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.TestToolResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.TestToolResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.TemplateType)

                    || typeToConvert == typeof(global::Vectara.TemplateType?)

                    || typeToConvert == typeof(global::Vectara.InstructionDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.InstructionDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.CreateInstructionRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateInstructionRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.UpdateInstructionRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.UpdateInstructionRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.AgentStepInstructionDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.AgentStepInstructionDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.AgentOutputParserDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.AgentOutputParserDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.TemplatedReminderHook)

                    || typeToConvert == typeof(global::Vectara.TemplatedReminderHook?)

                    || typeToConvert == typeof(global::Vectara.AgentStepReminderDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.AgentStepReminderDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.CompactionConfigToolEventPolicy)

                    || typeToConvert == typeof(global::Vectara.CompactionConfigToolEventPolicy?)

                    || typeToConvert == typeof(global::Vectara.AgentSessionStatus)

                    || typeToConvert == typeof(global::Vectara.AgentSessionStatus?)

                    || typeToConvert == typeof(global::Vectara.AgentInputDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.AgentInputDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.ImageReadEventVariant2Detail)

                    || typeToConvert == typeof(global::Vectara.ImageReadEventVariant2Detail?)

                    || typeToConvert == typeof(global::Vectara.AgentEventDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.AgentEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.InputBehavior)

                    || typeToConvert == typeof(global::Vectara.InputBehavior?)

                    || typeToConvert == typeof(global::Vectara.CreateToolOutputRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateToolOutputRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.CreateInputRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateInputRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.ToolActivityEventDiscriminatorActivityType)

                    || typeToConvert == typeof(global::Vectara.ToolActivityEventDiscriminatorActivityType?)

                    || typeToConvert == typeof(global::Vectara.AgentStreamedResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.AgentStreamedResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.IntervalScheduleConfigurationType)

                    || typeToConvert == typeof(global::Vectara.IntervalScheduleConfigurationType?)

                    || typeToConvert == typeof(global::Vectara.CronScheduleConfigurationType)

                    || typeToConvert == typeof(global::Vectara.CronScheduleConfigurationType?)

                    || typeToConvert == typeof(global::Vectara.AgentScheduleExecutionStatus)

                    || typeToConvert == typeof(global::Vectara.AgentScheduleExecutionStatus?)

                    || typeToConvert == typeof(global::Vectara.AgentIdentityMode)

                    || typeToConvert == typeof(global::Vectara.AgentIdentityMode?)

                    || typeToConvert == typeof(global::Vectara.ConnectorStatus)

                    || typeToConvert == typeof(global::Vectara.ConnectorStatus?)

                    || typeToConvert == typeof(global::Vectara.AgentOutputType)

                    || typeToConvert == typeof(global::Vectara.AgentOutputType?)

                    || typeToConvert == typeof(global::Vectara.ConnectorConfigurationDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.ConnectorConfigurationDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.ConnectorWebhookStatus)

                    || typeToConvert == typeof(global::Vectara.ConnectorWebhookStatus?)

                    || typeToConvert == typeof(global::Vectara.AgentConnectorDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.AgentConnectorDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.CreateAgentConnectorRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateAgentConnectorRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.CreateConnectorConfigurationDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateConnectorConfigurationDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.A2aV03Role)

                    || typeToConvert == typeof(global::Vectara.A2aV03Role?)

                    || typeToConvert == typeof(global::Vectara.A2aV03TaskState)

                    || typeToConvert == typeof(global::Vectara.A2aV03TaskState?)

                    || typeToConvert == typeof(global::Vectara.A2aV1Role)

                    || typeToConvert == typeof(global::Vectara.A2aV1Role?)

                    || typeToConvert == typeof(global::Vectara.A2aV1TaskState)

                    || typeToConvert == typeof(global::Vectara.A2aV1TaskState?)

                    || typeToConvert == typeof(global::Vectara.RuleTargetsDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.RuleTargetsDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.AliasPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.AliasPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.EndUserSessionStatus)

                    || typeToConvert == typeof(global::Vectara.EndUserSessionStatus?)

                    || typeToConvert == typeof(global::Vectara.EndUserEventDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.EndUserEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.CreateEndUserInputRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.CreateEndUserInputRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.EndUserAgentStreamedResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.EndUserAgentStreamedResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.PipelineStatus)

                    || typeToConvert == typeof(global::Vectara.PipelineStatus?)

                    || typeToConvert == typeof(global::Vectara.AclAccessLevel)

                    || typeToConvert == typeof(global::Vectara.AclAccessLevel?)

                    || typeToConvert == typeof(global::Vectara.GoogleDriveScopeDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.GoogleDriveScopeDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.WolkenArticleStatus)

                    || typeToConvert == typeof(global::Vectara.WolkenArticleStatus?)

                    || typeToConvert == typeof(global::Vectara.BaseWolkenKbSourceConfigurationKbApi)

                    || typeToConvert == typeof(global::Vectara.BaseWolkenKbSourceConfigurationKbApi?)

                    || typeToConvert == typeof(global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator)

                    || typeToConvert == typeof(global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator?)

                    || typeToConvert == typeof(global::Vectara.WolkenTicketRequestType)

                    || typeToConvert == typeof(global::Vectara.WolkenTicketRequestType?)

                    || typeToConvert == typeof(global::Vectara.BaseConfluenceSourceConfigurationDeployment)

                    || typeToConvert == typeof(global::Vectara.BaseConfluenceSourceConfigurationDeployment?)

                    || typeToConvert == typeof(global::Vectara.FluidtopicsDocumentFetchMode)

                    || typeToConvert == typeof(global::Vectara.FluidtopicsDocumentFetchMode?)

                    || typeToConvert == typeof(global::Vectara.BaseFluidtopicsSourceConfigurationContentScope)

                    || typeToConvert == typeof(global::Vectara.BaseFluidtopicsSourceConfigurationContentScope?)

                    || typeToConvert == typeof(global::Vectara.BaseScimSourceConfigurationIncrementalStrategy)

                    || typeToConvert == typeof(global::Vectara.BaseScimSourceConfigurationIncrementalStrategy?)

                    || typeToConvert == typeof(global::Vectara.WebPagesSourceDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.WebPagesSourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.PipelineSourceDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.PipelineSourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.PipelineTriggerDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.PipelineTriggerDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.PipelineVerificationDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.PipelineVerificationDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.PipelineTransformDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.PipelineTransformDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.PipelineSyncMode)

                    || typeToConvert == typeof(global::Vectara.PipelineSyncMode?)

                    || typeToConvert == typeof(global::Vectara.UpdatePipelineSourceDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.UpdatePipelineSourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.PipelineRunStatus)

                    || typeToConvert == typeof(global::Vectara.PipelineRunStatus?)

                    || typeToConvert == typeof(global::Vectara.PipelineRunTriggerType)

                    || typeToConvert == typeof(global::Vectara.PipelineRunTriggerType?)

                    || typeToConvert == typeof(global::Vectara.DeadLetterStatus)

                    || typeToConvert == typeof(global::Vectara.DeadLetterStatus?)

                    || typeToConvert == typeof(global::Vectara.DeadLetterOrigin)

                    || typeToConvert == typeof(global::Vectara.DeadLetterOrigin?)

                    || typeToConvert == typeof(global::Vectara.PipelineRunEventType)

                    || typeToConvert == typeof(global::Vectara.PipelineRunEventType?)

                    || typeToConvert == typeof(global::Vectara.SortOrder)

                    || typeToConvert == typeof(global::Vectara.SortOrder?)

                    || typeToConvert == typeof(global::Vectara.RunCompletedEventStatus)

                    || typeToConvert == typeof(global::Vectara.RunCompletedEventStatus?)

                    || typeToConvert == typeof(global::Vectara.RecordProcessingEventStatus)

                    || typeToConvert == typeof(global::Vectara.RecordProcessingEventStatus?)

                    || typeToConvert == typeof(global::Vectara.PipelineRunEventDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.PipelineRunEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.MetricDescriptorDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.MetricDescriptorDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.MetricSeriesDiscriminatorType)

                    || typeToConvert == typeof(global::Vectara.MetricSeriesDiscriminatorType?)

                    || typeToConvert == typeof(global::Vectara.AgentTraceStatus)

                    || typeToConvert == typeof(global::Vectara.AgentTraceStatus?)

                    || typeToConvert == typeof(global::Vectara.AgentTraceSpanStatus)

                    || typeToConvert == typeof(global::Vectara.AgentTraceSpanStatus?)

                    || typeToConvert == typeof(global::Vectara.InvokeAgentSpanAttributesOutputType)

                    || typeToConvert == typeof(global::Vectara.InvokeAgentSpanAttributesOutputType?)

                    || typeToConvert == typeof(global::Vectara.AgentTraceSpanDiscriminatorOperation)

                    || typeToConvert == typeof(global::Vectara.AgentTraceSpanDiscriminatorOperation?)

                    || typeToConvert == typeof(global::Vectara.CreateCorpusDocumentWaitFor)

                    || typeToConvert == typeof(global::Vectara.CreateCorpusDocumentWaitFor?)

                    || typeToConvert == typeof(global::Vectara.ListToolServersType)

                    || typeToConvert == typeof(global::Vectara.ListToolServersType?)

                    || typeToConvert == typeof(global::Vectara.ListToolsType)

                    || typeToConvert == typeof(global::Vectara.ListToolsType?)

                    || typeToConvert == typeof(global::Vectara.ListInstructionsType)

                    || typeToConvert == typeof(global::Vectara.ListInstructionsType?)

                    || typeToConvert == typeof(global::Vectara.ListSessionArtifactsSortBy)

                    || typeToConvert == typeof(global::Vectara.ListSessionArtifactsSortBy?)

                    || typeToConvert == typeof(global::Vectara.ListSessionArtifactsOrderBy)

                    || typeToConvert == typeof(global::Vectara.ListSessionArtifactsOrderBy?)

                    || typeToConvert == typeof(global::Vectara.ListAgentConnectorsType)

                    || typeToConvert == typeof(global::Vectara.ListAgentConnectorsType?)

                    || typeToConvert == typeof(global::Vectara.ListAliasRoutedSessionArtifactsSortBy)

                    || typeToConvert == typeof(global::Vectara.ListAliasRoutedSessionArtifactsSortBy?)

                    || typeToConvert == typeof(global::Vectara.ListAliasRoutedSessionArtifactsOrderBy)

                    || typeToConvert == typeof(global::Vectara.ListAliasRoutedSessionArtifactsOrderBy?)

                    || typeToConvert == typeof(global::Vectara.ListPipelinesSourceType)

                    || typeToConvert == typeof(global::Vectara.ListPipelinesSourceType?)

                    || typeToConvert == typeof(global::Vectara.ListTracesStatus)

                    || typeToConvert == typeof(global::Vectara.ListTracesStatus?)

                    || typeToConvert == typeof(global::Vectara.ListTracesErrorType)

                    || typeToConvert == typeof(global::Vectara.ListTracesErrorType?)

                    || typeToConvert == typeof(global::Vectara.ListTracesOperation)

                    || typeToConvert == typeof(global::Vectara.ListTracesOperation?)

                    || typeToConvert == typeof(global::Vectara.ListTracesToolErrorType)

                    || typeToConvert == typeof(global::Vectara.ListTracesToolErrorType?)

                    || typeToConvert == typeof(global::Vectara.ListTraceSpansOperation)

                    || typeToConvert == typeof(global::Vectara.ListTraceSpansOperation?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vectara.FilterAttributeLevel))
                {
                    return new global::Vectara.JsonConverters.FilterAttributeLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FilterAttributeLevel?))
                {
                    return new global::Vectara.JsonConverters.FilterAttributeLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FilterAttributeType))
                {
                    return new global::Vectara.JsonConverters.FilterAttributeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FilterAttributeType?))
                {
                    return new global::Vectara.JsonConverters.FilterAttributeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FilterAttributeStatType))
                {
                    return new global::Vectara.JsonConverters.FilterAttributeStatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FilterAttributeStatType?))
                {
                    return new global::Vectara.JsonConverters.FilterAttributeStatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ChunkingStrategyDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.ChunkingStrategyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ChunkingStrategyDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.ChunkingStrategyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CoreDocumentPartImagePartMode))
                {
                    return new global::Vectara.JsonConverters.CoreDocumentPartImagePartModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CoreDocumentPartImagePartMode?))
                {
                    return new global::Vectara.JsonConverters.CoreDocumentPartImagePartModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateDocumentRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateDocumentRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateDocumentRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateDocumentRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BulkDeleteAsyncResponseResponseType))
                {
                    return new global::Vectara.JsonConverters.BulkDeleteAsyncResponseResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BulkDeleteAsyncResponseResponseType?))
                {
                    return new global::Vectara.JsonConverters.BulkDeleteAsyncResponseResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BulkDeleteSyncSuccessResponseResponseType))
                {
                    return new global::Vectara.JsonConverters.BulkDeleteSyncSuccessResponseResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BulkDeleteSyncSuccessResponseResponseType?))
                {
                    return new global::Vectara.JsonConverters.BulkDeleteSyncSuccessResponseResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BulkDeleteDocumentsResponseDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BulkDeleteDocumentsResponseDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BulkUpdateDocumentMetadataRequestStrategy))
                {
                    return new global::Vectara.JsonConverters.BulkUpdateDocumentMetadataRequestStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BulkUpdateDocumentMetadataRequestStrategy?))
                {
                    return new global::Vectara.JsonConverters.BulkUpdateDocumentMetadataRequestStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.BulkUpdateDocumentMetadataResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.BulkUpdateDocumentMetadataResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.SummarizeDocumentStreamedResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.MetadataQueryRequestLevel))
                {
                    return new global::Vectara.JsonConverters.MetadataQueryRequestLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.MetadataQueryRequestLevel?))
                {
                    return new global::Vectara.JsonConverters.MetadataQueryRequestLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.Language))
                {
                    return new global::Vectara.JsonConverters.LanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.Language?))
                {
                    return new global::Vectara.JsonConverters.LanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.IndividualSearchResultDiscriminatorResultType))
                {
                    return new global::Vectara.JsonConverters.IndividualSearchResultDiscriminatorResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.IndividualSearchResultDiscriminatorResultType?))
                {
                    return new global::Vectara.JsonConverters.IndividualSearchResultDiscriminatorResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.QueryWarning))
                {
                    return new global::Vectara.JsonConverters.QueryWarningJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.QueryWarning?))
                {
                    return new global::Vectara.JsonConverters.QueryWarningNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SearchSemantics))
                {
                    return new global::Vectara.JsonConverters.SearchSemanticsJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SearchSemantics?))
                {
                    return new global::Vectara.JsonConverters.SearchSemanticsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SearchRerankerDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SearchRerankerDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SearchParametersMaxBy))
                {
                    return new global::Vectara.JsonConverters.SearchParametersMaxByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SearchParametersMaxBy?))
                {
                    return new global::Vectara.JsonConverters.SearchParametersMaxByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CitationParametersStyle))
                {
                    return new global::Vectara.JsonConverters.CitationParametersStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CitationParametersStyle?))
                {
                    return new global::Vectara.JsonConverters.CitationParametersStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.QueryStreamedResponseDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.QueryStreamedResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.QueryStreamedResponseDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.QueryStreamedResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.RewrittenQueryWarning))
                {
                    return new global::Vectara.JsonConverters.RewrittenQueryWarningJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.RewrittenQueryWarning?))
                {
                    return new global::Vectara.JsonConverters.RewrittenQueryWarningNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.QueryHistorySpanDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.QueryHistorySpanDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.QueryHistorySpanDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.QueryHistorySpanDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ChatStreamedResponseDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.ChatStreamedResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ChatStreamedResponseDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.ChatStreamedResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.LLMOwnership))
                {
                    return new global::Vectara.JsonConverters.LLMOwnershipJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.LLMOwnership?))
                {
                    return new global::Vectara.JsonConverters.LLMOwnershipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.LLMType))
                {
                    return new global::Vectara.JsonConverters.LLMTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.LLMType?))
                {
                    return new global::Vectara.JsonConverters.LLMTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.LLMAuthDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.LLMAuthDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.LLMAuthDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.LLMAuthDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.RemoteAuthDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.RemoteAuthDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.RemoteAuthDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.RemoteAuthDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.VertexAiAuthDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.VertexAiAuthDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.VertexAiAuthDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.VertexAiAuthDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AnthropicAuthDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.AnthropicAuthDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AnthropicAuthDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.AnthropicAuthDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateLLMRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateLLMRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateLLMRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateLLMRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.UpdateLLMRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.UpdateLLMRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.UpdateLLMRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.UpdateLLMRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.JsonSchemaDefinitionDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.JsonSchemaDefinitionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.JsonSchemaDefinitionDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.JsonSchemaDefinitionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ResponseFormatType))
                {
                    return new global::Vectara.JsonConverters.ResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ResponseFormatType?))
                {
                    return new global::Vectara.JsonConverters.ResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateChatCompletionResponseObject))
                {
                    return new global::Vectara.JsonConverters.CreateChatCompletionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateChatCompletionResponseObject?))
                {
                    return new global::Vectara.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateChatCompletionStreamResponseObject))
                {
                    return new global::Vectara.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateChatCompletionStreamResponseObject?))
                {
                    return new global::Vectara.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.GenerationPresetOwnership))
                {
                    return new global::Vectara.JsonConverters.GenerationPresetOwnershipJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.GenerationPresetOwnership?))
                {
                    return new global::Vectara.JsonConverters.GenerationPresetOwnershipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateEncoderRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateEncoderRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateEncoderRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateEncoderRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.JobState))
                {
                    return new global::Vectara.JsonConverters.JobStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.JobState?))
                {
                    return new global::Vectara.JsonConverters.JobStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.JobProgressPhase))
                {
                    return new global::Vectara.JsonConverters.JobProgressPhaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.JobProgressPhase?))
                {
                    return new global::Vectara.JsonConverters.JobProgressPhaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.JobType))
                {
                    return new global::Vectara.JsonConverters.JobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.JobType?))
                {
                    return new global::Vectara.JsonConverters.JobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ApiRole))
                {
                    return new global::Vectara.JsonConverters.ApiRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ApiRole?))
                {
                    return new global::Vectara.JsonConverters.ApiRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CorpusRoleRole))
                {
                    return new global::Vectara.JsonConverters.CorpusRoleRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CorpusRoleRole?))
                {
                    return new global::Vectara.JsonConverters.CorpusRoleRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentRoleRole))
                {
                    return new global::Vectara.JsonConverters.AgentRoleRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentRoleRole?))
                {
                    return new global::Vectara.JsonConverters.AgentRoleRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ApiKeyRole))
                {
                    return new global::Vectara.JsonConverters.ApiKeyRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ApiKeyRole?))
                {
                    return new global::Vectara.JsonConverters.ApiKeyRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateAppClientRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateAppClientRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateAppClientRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateAppClientRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ToolServerType))
                {
                    return new global::Vectara.JsonConverters.ToolServerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ToolServerType?))
                {
                    return new global::Vectara.JsonConverters.ToolServerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ToolServerTransport))
                {
                    return new global::Vectara.JsonConverters.ToolServerTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ToolServerTransport?))
                {
                    return new global::Vectara.JsonConverters.ToolServerTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FunctionDefinitionLanguage))
                {
                    return new global::Vectara.JsonConverters.FunctionDefinitionLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FunctionDefinitionLanguage?))
                {
                    return new global::Vectara.JsonConverters.FunctionDefinitionLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FunctionDefinitionValidationStatus))
                {
                    return new global::Vectara.JsonConverters.FunctionDefinitionValidationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FunctionDefinitionValidationStatus?))
                {
                    return new global::Vectara.JsonConverters.FunctionDefinitionValidationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ToolOutputOffloadingConfigurationMode))
                {
                    return new global::Vectara.JsonConverters.ToolOutputOffloadingConfigurationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ToolOutputOffloadingConfigurationMode?))
                {
                    return new global::Vectara.JsonConverters.ToolOutputOffloadingConfigurationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebSearchToolParametersProvider))
                {
                    return new global::Vectara.JsonConverters.WebSearchToolParametersProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebSearchToolParametersProvider?))
                {
                    return new global::Vectara.JsonConverters.WebSearchToolParametersProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement))
                {
                    return new global::Vectara.JsonConverters.WebGetOAuthTokenExchangeAuthSubjectPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement?))
                {
                    return new global::Vectara.JsonConverters.WebGetOAuthTokenExchangeAuthSubjectPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation))
                {
                    return new global::Vectara.JsonConverters.WebGetOAuthTokenExchangeAuthParamLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation?))
                {
                    return new global::Vectara.JsonConverters.WebGetOAuthTokenExchangeAuthParamLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebGetAuthDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.WebGetAuthDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebGetAuthDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.WebGetAuthDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebGetToolParametersMethod))
                {
                    return new global::Vectara.JsonConverters.WebGetToolParametersMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebGetToolParametersMethod?))
                {
                    return new global::Vectara.JsonConverters.WebGetToolParametersMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebGetToolParametersResponseMode))
                {
                    return new global::Vectara.JsonConverters.WebGetToolParametersResponseModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebGetToolParametersResponseMode?))
                {
                    return new global::Vectara.JsonConverters.WebGetToolParametersResponseModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SubAgentSessionMode))
                {
                    return new global::Vectara.JsonConverters.SubAgentSessionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SubAgentSessionMode?))
                {
                    return new global::Vectara.JsonConverters.SubAgentSessionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ArtifactReadToolParametersEncoding))
                {
                    return new global::Vectara.JsonConverters.ArtifactReadToolParametersEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ArtifactReadToolParametersEncoding?))
                {
                    return new global::Vectara.JsonConverters.ArtifactReadToolParametersEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ImageReadToolParametersDetail))
                {
                    return new global::Vectara.JsonConverters.ImageReadToolParametersDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ImageReadToolParametersDetail?))
                {
                    return new global::Vectara.JsonConverters.ImageReadToolParametersDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.DocumentConversionToolParametersOutputFormat))
                {
                    return new global::Vectara.JsonConverters.DocumentConversionToolParametersOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.DocumentConversionToolParametersOutputFormat?))
                {
                    return new global::Vectara.JsonConverters.DocumentConversionToolParametersOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentToolConfigurationDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.AgentToolConfigurationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentToolConfigurationDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.AgentToolConfigurationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.LambdaToolVariant2Language))
                {
                    return new global::Vectara.JsonConverters.LambdaToolVariant2LanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.LambdaToolVariant2Language?))
                {
                    return new global::Vectara.JsonConverters.LambdaToolVariant2LanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ToolDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.ToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ToolDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateLambdaToolRequestLanguage))
                {
                    return new global::Vectara.JsonConverters.CreateLambdaToolRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateLambdaToolRequestLanguage?))
                {
                    return new global::Vectara.JsonConverters.CreateLambdaToolRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateToolRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateToolRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateToolRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateToolRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.TestLambdaToolRequestLanguage))
                {
                    return new global::Vectara.JsonConverters.TestLambdaToolRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.TestLambdaToolRequestLanguage?))
                {
                    return new global::Vectara.JsonConverters.TestLambdaToolRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.TestLambdaToolResponseValidationStatus))
                {
                    return new global::Vectara.JsonConverters.TestLambdaToolResponseValidationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.TestLambdaToolResponseValidationStatus?))
                {
                    return new global::Vectara.JsonConverters.TestLambdaToolResponseValidationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.UpdateToolRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.UpdateToolRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.UpdateToolRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.UpdateToolRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.TestToolResponseDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.TestToolResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.TestToolResponseDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.TestToolResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.TemplateType))
                {
                    return new global::Vectara.JsonConverters.TemplateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.TemplateType?))
                {
                    return new global::Vectara.JsonConverters.TemplateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.InstructionDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.InstructionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.InstructionDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.InstructionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateInstructionRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateInstructionRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateInstructionRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateInstructionRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.UpdateInstructionRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.UpdateInstructionRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.UpdateInstructionRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.UpdateInstructionRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentStepInstructionDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.AgentStepInstructionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentStepInstructionDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.AgentStepInstructionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentOutputParserDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.AgentOutputParserDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentOutputParserDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.AgentOutputParserDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.TemplatedReminderHook))
                {
                    return new global::Vectara.JsonConverters.TemplatedReminderHookJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.TemplatedReminderHook?))
                {
                    return new global::Vectara.JsonConverters.TemplatedReminderHookNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentStepReminderDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.AgentStepReminderDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentStepReminderDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.AgentStepReminderDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CompactionConfigToolEventPolicy))
                {
                    return new global::Vectara.JsonConverters.CompactionConfigToolEventPolicyJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CompactionConfigToolEventPolicy?))
                {
                    return new global::Vectara.JsonConverters.CompactionConfigToolEventPolicyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentSessionStatus))
                {
                    return new global::Vectara.JsonConverters.AgentSessionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentSessionStatus?))
                {
                    return new global::Vectara.JsonConverters.AgentSessionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentInputDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.AgentInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentInputDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.AgentInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ImageReadEventVariant2Detail))
                {
                    return new global::Vectara.JsonConverters.ImageReadEventVariant2DetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ImageReadEventVariant2Detail?))
                {
                    return new global::Vectara.JsonConverters.ImageReadEventVariant2DetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentEventDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.AgentEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentEventDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.AgentEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.InputBehavior))
                {
                    return new global::Vectara.JsonConverters.InputBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.InputBehavior?))
                {
                    return new global::Vectara.JsonConverters.InputBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateToolOutputRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateToolOutputRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateToolOutputRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateToolOutputRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateInputRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateInputRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateInputRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateInputRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ToolActivityEventDiscriminatorActivityType))
                {
                    return new global::Vectara.JsonConverters.ToolActivityEventDiscriminatorActivityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ToolActivityEventDiscriminatorActivityType?))
                {
                    return new global::Vectara.JsonConverters.ToolActivityEventDiscriminatorActivityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentStreamedResponseDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.AgentStreamedResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentStreamedResponseDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.AgentStreamedResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.IntervalScheduleConfigurationType))
                {
                    return new global::Vectara.JsonConverters.IntervalScheduleConfigurationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.IntervalScheduleConfigurationType?))
                {
                    return new global::Vectara.JsonConverters.IntervalScheduleConfigurationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CronScheduleConfigurationType))
                {
                    return new global::Vectara.JsonConverters.CronScheduleConfigurationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CronScheduleConfigurationType?))
                {
                    return new global::Vectara.JsonConverters.CronScheduleConfigurationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentScheduleExecutionStatus))
                {
                    return new global::Vectara.JsonConverters.AgentScheduleExecutionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentScheduleExecutionStatus?))
                {
                    return new global::Vectara.JsonConverters.AgentScheduleExecutionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentIdentityMode))
                {
                    return new global::Vectara.JsonConverters.AgentIdentityModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentIdentityMode?))
                {
                    return new global::Vectara.JsonConverters.AgentIdentityModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ConnectorStatus))
                {
                    return new global::Vectara.JsonConverters.ConnectorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ConnectorStatus?))
                {
                    return new global::Vectara.JsonConverters.ConnectorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentOutputType))
                {
                    return new global::Vectara.JsonConverters.AgentOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentOutputType?))
                {
                    return new global::Vectara.JsonConverters.AgentOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ConnectorConfigurationDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.ConnectorConfigurationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ConnectorConfigurationDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.ConnectorConfigurationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ConnectorWebhookStatus))
                {
                    return new global::Vectara.JsonConverters.ConnectorWebhookStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ConnectorWebhookStatus?))
                {
                    return new global::Vectara.JsonConverters.ConnectorWebhookStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentConnectorDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.AgentConnectorDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentConnectorDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.AgentConnectorDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateAgentConnectorRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateAgentConnectorRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateAgentConnectorRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateAgentConnectorRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateConnectorConfigurationDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateConnectorConfigurationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateConnectorConfigurationDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateConnectorConfigurationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.A2aV03Role))
                {
                    return new global::Vectara.JsonConverters.A2aV03RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.A2aV03Role?))
                {
                    return new global::Vectara.JsonConverters.A2aV03RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.A2aV03TaskState))
                {
                    return new global::Vectara.JsonConverters.A2aV03TaskStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.A2aV03TaskState?))
                {
                    return new global::Vectara.JsonConverters.A2aV03TaskStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.A2aV1Role))
                {
                    return new global::Vectara.JsonConverters.A2aV1RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.A2aV1Role?))
                {
                    return new global::Vectara.JsonConverters.A2aV1RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.A2aV1TaskState))
                {
                    return new global::Vectara.JsonConverters.A2aV1TaskStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.A2aV1TaskState?))
                {
                    return new global::Vectara.JsonConverters.A2aV1TaskStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.RuleTargetsDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.RuleTargetsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.RuleTargetsDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.RuleTargetsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AliasPolicyDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.AliasPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AliasPolicyDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.AliasPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.EndUserSessionStatus))
                {
                    return new global::Vectara.JsonConverters.EndUserSessionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.EndUserSessionStatus?))
                {
                    return new global::Vectara.JsonConverters.EndUserSessionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.EndUserEventDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.EndUserEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.EndUserEventDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.EndUserEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateEndUserInputRequestDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.CreateEndUserInputRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateEndUserInputRequestDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.CreateEndUserInputRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.EndUserAgentStreamedResponseDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.EndUserAgentStreamedResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.EndUserAgentStreamedResponseDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.EndUserAgentStreamedResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineStatus))
                {
                    return new global::Vectara.JsonConverters.PipelineStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineStatus?))
                {
                    return new global::Vectara.JsonConverters.PipelineStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AclAccessLevel))
                {
                    return new global::Vectara.JsonConverters.AclAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AclAccessLevel?))
                {
                    return new global::Vectara.JsonConverters.AclAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.GoogleDriveScopeDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.GoogleDriveScopeDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.GoogleDriveScopeDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.GoogleDriveScopeDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WolkenArticleStatus))
                {
                    return new global::Vectara.JsonConverters.WolkenArticleStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WolkenArticleStatus?))
                {
                    return new global::Vectara.JsonConverters.WolkenArticleStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BaseWolkenKbSourceConfigurationKbApi))
                {
                    return new global::Vectara.JsonConverters.BaseWolkenKbSourceConfigurationKbApiJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BaseWolkenKbSourceConfigurationKbApi?))
                {
                    return new global::Vectara.JsonConverters.BaseWolkenKbSourceConfigurationKbApiNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator))
                {
                    return new global::Vectara.JsonConverters.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator?))
                {
                    return new global::Vectara.JsonConverters.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WolkenTicketRequestType))
                {
                    return new global::Vectara.JsonConverters.WolkenTicketRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WolkenTicketRequestType?))
                {
                    return new global::Vectara.JsonConverters.WolkenTicketRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BaseConfluenceSourceConfigurationDeployment))
                {
                    return new global::Vectara.JsonConverters.BaseConfluenceSourceConfigurationDeploymentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BaseConfluenceSourceConfigurationDeployment?))
                {
                    return new global::Vectara.JsonConverters.BaseConfluenceSourceConfigurationDeploymentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FluidtopicsDocumentFetchMode))
                {
                    return new global::Vectara.JsonConverters.FluidtopicsDocumentFetchModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.FluidtopicsDocumentFetchMode?))
                {
                    return new global::Vectara.JsonConverters.FluidtopicsDocumentFetchModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BaseFluidtopicsSourceConfigurationContentScope))
                {
                    return new global::Vectara.JsonConverters.BaseFluidtopicsSourceConfigurationContentScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BaseFluidtopicsSourceConfigurationContentScope?))
                {
                    return new global::Vectara.JsonConverters.BaseFluidtopicsSourceConfigurationContentScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BaseScimSourceConfigurationIncrementalStrategy))
                {
                    return new global::Vectara.JsonConverters.BaseScimSourceConfigurationIncrementalStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.BaseScimSourceConfigurationIncrementalStrategy?))
                {
                    return new global::Vectara.JsonConverters.BaseScimSourceConfigurationIncrementalStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebPagesSourceDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.WebPagesSourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.WebPagesSourceDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.WebPagesSourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineSourceDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.PipelineSourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineSourceDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.PipelineSourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineTriggerDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.PipelineTriggerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineTriggerDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.PipelineTriggerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineVerificationDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.PipelineVerificationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineVerificationDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.PipelineVerificationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineTransformDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.PipelineTransformDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineTransformDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.PipelineTransformDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineSyncMode))
                {
                    return new global::Vectara.JsonConverters.PipelineSyncModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineSyncMode?))
                {
                    return new global::Vectara.JsonConverters.PipelineSyncModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.UpdatePipelineSourceDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.UpdatePipelineSourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.UpdatePipelineSourceDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.UpdatePipelineSourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineRunStatus))
                {
                    return new global::Vectara.JsonConverters.PipelineRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineRunStatus?))
                {
                    return new global::Vectara.JsonConverters.PipelineRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineRunTriggerType))
                {
                    return new global::Vectara.JsonConverters.PipelineRunTriggerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineRunTriggerType?))
                {
                    return new global::Vectara.JsonConverters.PipelineRunTriggerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.DeadLetterStatus))
                {
                    return new global::Vectara.JsonConverters.DeadLetterStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.DeadLetterStatus?))
                {
                    return new global::Vectara.JsonConverters.DeadLetterStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.DeadLetterOrigin))
                {
                    return new global::Vectara.JsonConverters.DeadLetterOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.DeadLetterOrigin?))
                {
                    return new global::Vectara.JsonConverters.DeadLetterOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineRunEventType))
                {
                    return new global::Vectara.JsonConverters.PipelineRunEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineRunEventType?))
                {
                    return new global::Vectara.JsonConverters.PipelineRunEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SortOrder))
                {
                    return new global::Vectara.JsonConverters.SortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.SortOrder?))
                {
                    return new global::Vectara.JsonConverters.SortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.RunCompletedEventStatus))
                {
                    return new global::Vectara.JsonConverters.RunCompletedEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.RunCompletedEventStatus?))
                {
                    return new global::Vectara.JsonConverters.RunCompletedEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.RecordProcessingEventStatus))
                {
                    return new global::Vectara.JsonConverters.RecordProcessingEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.RecordProcessingEventStatus?))
                {
                    return new global::Vectara.JsonConverters.RecordProcessingEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineRunEventDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.PipelineRunEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.PipelineRunEventDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.PipelineRunEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.MetricDescriptorDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.MetricDescriptorDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.MetricDescriptorDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.MetricDescriptorDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.MetricSeriesDiscriminatorType))
                {
                    return new global::Vectara.JsonConverters.MetricSeriesDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.MetricSeriesDiscriminatorType?))
                {
                    return new global::Vectara.JsonConverters.MetricSeriesDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentTraceStatus))
                {
                    return new global::Vectara.JsonConverters.AgentTraceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentTraceStatus?))
                {
                    return new global::Vectara.JsonConverters.AgentTraceStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentTraceSpanStatus))
                {
                    return new global::Vectara.JsonConverters.AgentTraceSpanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentTraceSpanStatus?))
                {
                    return new global::Vectara.JsonConverters.AgentTraceSpanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.InvokeAgentSpanAttributesOutputType))
                {
                    return new global::Vectara.JsonConverters.InvokeAgentSpanAttributesOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.InvokeAgentSpanAttributesOutputType?))
                {
                    return new global::Vectara.JsonConverters.InvokeAgentSpanAttributesOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentTraceSpanDiscriminatorOperation))
                {
                    return new global::Vectara.JsonConverters.AgentTraceSpanDiscriminatorOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.AgentTraceSpanDiscriminatorOperation?))
                {
                    return new global::Vectara.JsonConverters.AgentTraceSpanDiscriminatorOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateCorpusDocumentWaitFor))
                {
                    return new global::Vectara.JsonConverters.CreateCorpusDocumentWaitForJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.CreateCorpusDocumentWaitFor?))
                {
                    return new global::Vectara.JsonConverters.CreateCorpusDocumentWaitForNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListToolServersType))
                {
                    return new global::Vectara.JsonConverters.ListToolServersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListToolServersType?))
                {
                    return new global::Vectara.JsonConverters.ListToolServersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListToolsType))
                {
                    return new global::Vectara.JsonConverters.ListToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListToolsType?))
                {
                    return new global::Vectara.JsonConverters.ListToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListInstructionsType))
                {
                    return new global::Vectara.JsonConverters.ListInstructionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListInstructionsType?))
                {
                    return new global::Vectara.JsonConverters.ListInstructionsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListSessionArtifactsSortBy))
                {
                    return new global::Vectara.JsonConverters.ListSessionArtifactsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListSessionArtifactsSortBy?))
                {
                    return new global::Vectara.JsonConverters.ListSessionArtifactsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListSessionArtifactsOrderBy))
                {
                    return new global::Vectara.JsonConverters.ListSessionArtifactsOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListSessionArtifactsOrderBy?))
                {
                    return new global::Vectara.JsonConverters.ListSessionArtifactsOrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListAgentConnectorsType))
                {
                    return new global::Vectara.JsonConverters.ListAgentConnectorsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListAgentConnectorsType?))
                {
                    return new global::Vectara.JsonConverters.ListAgentConnectorsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListAliasRoutedSessionArtifactsSortBy))
                {
                    return new global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListAliasRoutedSessionArtifactsSortBy?))
                {
                    return new global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListAliasRoutedSessionArtifactsOrderBy))
                {
                    return new global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListAliasRoutedSessionArtifactsOrderBy?))
                {
                    return new global::Vectara.JsonConverters.ListAliasRoutedSessionArtifactsOrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListPipelinesSourceType))
                {
                    return new global::Vectara.JsonConverters.ListPipelinesSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListPipelinesSourceType?))
                {
                    return new global::Vectara.JsonConverters.ListPipelinesSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListTracesStatus))
                {
                    return new global::Vectara.JsonConverters.ListTracesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListTracesStatus?))
                {
                    return new global::Vectara.JsonConverters.ListTracesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListTracesErrorType))
                {
                    return new global::Vectara.JsonConverters.ListTracesErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListTracesErrorType?))
                {
                    return new global::Vectara.JsonConverters.ListTracesErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListTracesOperation))
                {
                    return new global::Vectara.JsonConverters.ListTracesOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListTracesOperation?))
                {
                    return new global::Vectara.JsonConverters.ListTracesOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListTracesToolErrorType))
                {
                    return new global::Vectara.JsonConverters.ListTracesToolErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListTracesToolErrorType?))
                {
                    return new global::Vectara.JsonConverters.ListTracesToolErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListTraceSpansOperation))
                {
                    return new global::Vectara.JsonConverters.ListTraceSpansOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vectara.ListTraceSpansOperation?))
                {
                    return new global::Vectara.JsonConverters.ListTraceSpansOperationNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[4];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new SourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}