
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordProcessingInput? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordOperation? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttribute? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttributeLevel? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttributeType? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorpusCustomDimension? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Corpus? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.FilterAttribute>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CorpusCustomDimension>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorpusLimits? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListMetadata? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListCorporaResponse? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Corpus>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Error? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCorpusRequest? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BadRequestError? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.NotFoundError? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateCorpusRequest? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceFilterAttributesRequest? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceFilterAttributesResponse? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ComputeCorpusSizeResponse? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttributeValue? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttributeNumericStats? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttributeStat? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttributeStatType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.FilterAttributeValue>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetFilterAttributeStatsResponse? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.FilterAttributeStat>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MaxCharsChunkingStrategy? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SentenceChunkingStrategy? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChunkingStrategy? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChunkingStrategyDiscriminator? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChunkingStrategyDiscriminatorType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TableExtractorSpec? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TableGenerationSpec? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TableExtractionConfig? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UploadFileRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Cell? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Cell>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Data? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Vectara.Cell>>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Table? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageMetadata? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentPart? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentStorageUsage? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExtractionUsage? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Document? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Table>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ImageMetadata>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DocumentPart>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListDocumentsResponse? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Document>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageData? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Image? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CoreDocumentPart? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CoreDocumentPartImagePartMode? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CoreDocument? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Image>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CoreDocumentPart>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredDocumentSection? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.StructuredDocumentSection>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredDocument? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateDocumentRequest? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateDocumentRequestDiscriminator? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateDocumentRequestDiscriminatorType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteAsyncResponse? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteAsyncResponseResponseType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteSyncSuccessResponse? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteSyncSuccessResponseResponseType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteDocumentsResponse? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteDocumentsResponseDiscriminator? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteDocumentsResponseDiscriminatorType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataRequestStrategy? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataResponseBase? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataAsyncResponse? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataResponse? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminator? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateDocumentRequest? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SummarizeDocumentRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SummarizeDocumentResponse? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamGenerationChunk? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationInfo? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamGenerationEnd? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamError? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamResponseEnd? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SummarizeDocumentStreamedResponse? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SummarizeDocumentStreamedResponseDiscriminator? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FieldQuery? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetadataQueryRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetadataQueryRequestLevel? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.FieldQuery>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScoredDocument? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetadataQueryResponse? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ScoredDocument>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Language? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchResultBase? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TextSearchResult? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TextSearchResultVariant2? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageSearchResult? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageSearchResultVariant2? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IndividualSearchResult? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IndividualSearchResultDiscriminator? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IndividualSearchResultDiscriminatorResultType? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryWarning? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterExtraction? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RewrittenQuery? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryFullResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.IndividualSearchResult>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.QueryWarning>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.RewrittenQuery>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchSemantics? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchCorpus? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextConfiguration? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CustomerSpecificReranker? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UserFunctionReranker? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MMRReranker? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchReranker? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChainReranker? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.NoneReranker? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchRerankerDiscriminator? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchRerankerDiscriminatorType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.SearchReranker>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchParameters? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchParametersMaxBy? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CitationParameters? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CitationParametersStyle? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationParameters? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationParametersModelParameters? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryCorpusRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AllOf<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamSearchResponse? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FactualConsistencyScore? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryStreamedResponse? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryStreamedResponseDiscriminator? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryStreamedResponseDiscriminatorType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.KeyedSearchCorpus? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.KeyedSearchCorpusVariant2? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchCorporaParameters? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchCorporaParametersVariant1? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.KeyedSearchCorpus>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryRequest? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RephraseSpan? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchSpan? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RerankedSearchResult? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RerankSpan? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.RerankedSearchResult>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationSpan? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FactualConsistencyScoreSpan? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RewrittenQueryWarning? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RewrittenQuerySpan? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.RewrittenQueryWarning>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryHistorySpan? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryHistorySpanDiscriminator? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryHistorySpanDiscriminatorType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryHistory? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.QueryHistorySpan>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryHistorySummary? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListQueryHistoriesResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.QueryHistorySummary>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListQueryHistoriesResponseMetadata? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Chat? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListChatsResponse? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Chat>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatParameters? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatRequest? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatFullResponse? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatInfoResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatStreamedResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatStreamedResponseDiscriminator? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatStreamedResponseDiscriminatorType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Turn? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListChatTurnsResponse? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Turn>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateTurnRequest? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMCapabilities? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMOwnership? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BearerAuth? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HeaderAuth? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OAuthClientCredentialsAuth? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OAuthClientCredentialsAuthClientAuthMethod? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BedrockStaticIAMAuth? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BedrockApiKeyAuth? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexServiceAccountAuth? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAccessTokenAuth? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiApiKeyAuth? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiServiceAccountAuth? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMAuth? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMAuthDiscriminator? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMAuthDiscriminatorType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Prompt? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Llm? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Prompt>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListLLMsResponse? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Llm>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RemoteAuth? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RemoteAuthDiscriminator? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RemoteAuthDiscriminatorType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OpenAILLMRequestBase? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAILLMRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAILLMRequestVariant2? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAIResponsesLLMRequest? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAIResponsesLLMRequestVariant2? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiAuth? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiAuthDiscriminator? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiAuthDiscriminatorType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateVertexAILLMRequest? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AnthropicAuth? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AnthropicAuthDiscriminator? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AnthropicAuthDiscriminatorType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAnthropicLLMRequest? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLLMRequest? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLLMRequestDiscriminator? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLLMRequestDiscriminatorType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DiscoverLLMsRequest? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DiscoveredLLM? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DiscoverLLMsResponse? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DiscoveredLLM>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OpenAILLMUpdateBase? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAILLMRequest? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAILLMRequestVariant2? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAIResponsesLLMRequest? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateVertexAILLMRequest? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAnthropicLLMRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLLMRequest? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLLMRequestDiscriminator? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLLMRequestDiscriminatorType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionRequestMessage? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaBase? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaDefinition? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaObject? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaValue? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaDefinitionDiscriminator? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaDefinitionDiscriminatorType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaObjectVariant2? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.JsonSchemaDefinition>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaValueVariant2? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.JsonSchemaDefinition>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaSpec? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ResponseFormat? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ResponseFormatType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ChatCompletionRequestMessage>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionResponseMessage? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionResponseChoice? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionResponse? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionResponseObject? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ChatCompletionResponseChoice>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionStreamResponseDelta? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionStreamResponseChoice? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionStreamResponse? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionStreamResponseObject? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ChatCompletionStreamResponseChoice>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationPresetOwnership? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationPreset? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListGenerationPresetsResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.GenerationPreset>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGenerationPresetRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EvaluateFactualConsistencyRequest? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EvaluateFactualConsistencyRequestModelParameters? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EvaluateFactualConsistencyResponse? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Encoder? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListEncodersResponse? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Encoder>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAIEncoderRequest? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateVLlmEncoderRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEncoderRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEncoderRequestDiscriminator? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEncoderRequestDiscriminatorType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Reranker? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListRerankersResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Reranker>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TableExtractor? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTableExtractorsResponse? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.TableExtractor>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HallucinationCorrector? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListHallucinationCorrectorsResponse? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.HallucinationCorrector>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HcmSourceDocument? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HallucinationCorrectionRequest? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.HcmSourceDocument>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorrectionItem? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HallucinationCorrectionResponse? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CorrectionItem>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobState? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobProgress? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobProgressPhase? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Job? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobType? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListJobsResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Job>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiRole? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorpusRole? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorpusRoleRole? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentRole? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentRoleRole? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiOperationPolicy? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiPolicy? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.ApiOperationPolicy>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.User? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ApiRole>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CorpusRole>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentRole>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListUsersResponse? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.User>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateUserRequest? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateUserRequest? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiKeyRole? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiKey? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListApiKeysResponse? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ApiKey>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateApiKeyRequest? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateApiKeyRequest? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AppClient? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAppClientsResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AppClient>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateClientCredentialsRequest? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAppClientRequest? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAppClientRequestDiscriminator? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAppClientRequestDiscriminatorType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAppClientRequest? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolServerType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolServerTransport? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolServer? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolServersResponse? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ToolServer>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolServerRequest? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolServerRequest? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolBase? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraTool? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraToolVariant2? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolAnnotations? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpTool? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolVariant2? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchTool? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolVariant2? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchTool? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolVariant2? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetTool? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolVariant2? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecutionConfiguration? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FunctionDefinition? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FunctionDefinitionLanguage? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FunctionDefinitionValidationStatus? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputOffloadingConfiguration? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputOffloadingConfigurationMode? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolConfigurationBase? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolConfigurationReference? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolConfigurationReferenceVariant2? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraToolConfiguration? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraToolConfigurationVariant2? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolConfiguration? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolConfigurationVariant2? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolParameters? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EagerReference? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentKeyedSearchCorpus? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<string, global::Vectara.EagerReference>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSearchCorporaParameters? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentKeyedSearchCorpus>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentCorporaSearchQueryConfiguration? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolConfiguration? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolConfigurationVariant2? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolParameters? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolParametersProvider? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolConfiguration? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolConfigurationVariant2? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetHeaderValue? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.WebGetHeaderValue>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetNoAuth? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetBearerAuth? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetHeaderAuth? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthClientCredentialsAuth? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthRefreshTokenAuth? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthTokenExchangeAuth? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAwsSigV4Auth? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAuth? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAuthDiscriminator? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAuthDiscriminatorType? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolParameters? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolParametersMethod? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<global::System.Collections.Generic.Dictionary<string, global::Vectara.WebGetHeaderValue>, global::Vectara.EagerReference>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<bool?, global::Vectara.EagerReference>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<int?, global::Vectara.EagerReference>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<long?, global::Vectara.EagerReference>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolParametersResponseMode? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolConfiguration? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolConfigurationVariant2? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolConfiguration? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolConfigurationVariant2? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolConfiguration? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolConfigurationVariant2? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolParameters? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentSessionMode? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentConfiguration? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolConfiguration? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolConfigurationVariant2? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolParameters? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolParametersEncoding? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadConfiguration? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolConfiguration? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolConfigurationVariant2? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolParameters? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolConfiguration? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolConfigurationVariant2? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolParameters? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolParametersDetail? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolConfiguration? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolConfigurationVariant2? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolParameters? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolParametersOutputFormat? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolConfiguration? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolConfigurationVariant2? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextParameters? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextConfiguration? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextConfigurationMetadata? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextToolConfiguration? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextToolConfigurationVariant2? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentToolConfiguration? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentToolConfigurationDiscriminator? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentToolConfigurationDiscriminatorType? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaTool? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolVariant2? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolVariant2Language? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentToolConfiguration>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentTool? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolVariant2? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactCreateTool? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactCreateToolVariant2? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadTool? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolVariant2? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepTool? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolVariant2? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadTool? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolVariant2? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionTool? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolVariant2? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextTool? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextToolVariant2? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientTool? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolVariant2? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Tool? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolDiscriminator? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolDiscriminatorType? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolsResponse? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Tool>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLambdaToolRequest? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLambdaToolRequestLanguage? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateClientToolRequest? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolRequest? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolRequestDiscriminator? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolRequestDiscriminatorType? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolContextAgent? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolContextSession? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolContext? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolRequest? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolRequestLanguage? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponse? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseValidation? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseValidationStatus? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseExecution? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseExecutionError? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseExecutionValidationResults? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolHeartbeatEvent? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResultEvent? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolStreamedResponse? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolStreamedResponseDiscriminator? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolStreamedResponseDiscriminatorType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateMcpToolRequest? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLambdaToolRequest? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateClientToolRequest? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolRequest? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolRequestDiscriminator? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolRequestDiscriminatorType? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolRequest? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolSuccessResponse? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolSuccessResponseValidationResults? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolErrorResponse? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolErrorResponseError? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResponse? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResponseDiscriminator? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResponseDiscriminatorType? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResultEvent? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolStreamedResponse? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolStreamedResponseDiscriminator? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolStreamedResponseDiscriminatorType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TemplateType? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InitialInstruction? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Instruction? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionDiscriminator? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionDiscriminatorType? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListInstructionsResponse? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Instruction>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionRequestBase? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInitialInstructionRequest? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInitialInstructionRequestVariant2? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInstructionRequest? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInstructionRequestDiscriminator? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInstructionRequestDiscriminatorType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInitialInstructionRequest? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInstructionRequest? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInstructionRequestDiscriminator? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInstructionRequestDiscriminatorType? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestInstructionRequest? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestInstructionResponse? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSkill? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RetryConfiguration? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentModel? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionReference? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReferenceInstruction? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReferenceInstructionVariant2? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InlineInstruction? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InlineInstructionVariant2? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepInstruction? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepInstructionDiscriminator? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepInstructionDiscriminatorType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DefaultOutputParser? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredOutputParser? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputParser? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputParserDiscriminator? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputParserDiscriminatorType? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TemplatedReminder? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.TemplatedReminderHook>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TemplatedReminderHook? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GlossaryExpansionReminder? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepReminder? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepReminderDiscriminator? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepReminderDiscriminatorType? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.NextStep? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FirstAgentStep? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentStepInstruction>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentStepReminder>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.NextStep>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStep? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionConfig? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionConfigToolEventPolicy? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionEnrichmentToolCall? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionEnrichmentConfig? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.SessionEnrichmentToolCall>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMQuota? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Agent? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentSkill>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentStep>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentsResponse? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Agent>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentRequest? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAgentRequest? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAgentRequestVariant2? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateFirstAgentStep? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentStep? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentRequest? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.UpdateAgentStep>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputTokens? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputTokens? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionContextUsage? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSession? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSessionStatus? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentSessionsResponse? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentSession>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentSessionRequest? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentSessionRequestFromSession? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentSessionRequest? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEventBase? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTextInput? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSkillInput? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentInput? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentInputDiscriminator? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentInputDiscriminatorType? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputMessageEvent? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputMessageEventVariant2? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentInput>? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SkillLoadEvent? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SkillLoadEventVariant2? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReference? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactUploadEvent? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactUploadEventVariant2? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ArtifactReference>? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolInputEvent? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolInputEventVariant2? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputEvent? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputEventVariant2? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingEvent? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingEventVariant2? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputEvent? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputEventVariant2? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredOutputEvent? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredOutputEventVariant2? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextLimitExceededEvent? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextLimitExceededEventVariant2? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionLimitExceededEvent? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionLimitExceededEventVariant2? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionInterruptedEvent? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionInterruptedEventVariant2? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentErrorEvent? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolPendingCall? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolPendingEvent? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolPendingEventVariant2? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ClientToolPendingCall>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadEvent? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadEventVariant2? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadEventVariant2Detail? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionEvent? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionEventVariant2? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionEvent? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionEventVariant2? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEvent? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEventDiscriminator? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEventDiscriminatorType? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentEventsResponse? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentEvent>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SurfaceDescription? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequestBase? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputBehavior? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputMessageRequest? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputMessageRequestVariant2? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInterruptRequest? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInterruptRequestVariant2? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCompactRequest? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCompactRequestVariant2? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputBase? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputSuccess? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputSuccessVariant2? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputError? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputErrorVariant2? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputRequest? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputRequestDiscriminator? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputRequestDiscriminatorType? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolOutputRequest? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolOutputRequestVariant2? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CreateToolOutputRequest>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequest? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequestDiscriminator? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequestDiscriminatorType? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MultipartInputEvent? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentResponse? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingAgentOutput? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingAgentOutputEnd? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingThinking? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingThinkingEnd? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextConsumedEvent? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionStartedEvent? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionStartedEventVariant2? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEventBase? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenericToolActivityEvent? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenericToolActivityEventVariant2? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolActivityEvent? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolActivityEventVariant2? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEvent? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEventDiscriminator? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEventDiscriminatorActivityType? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStreamedResponse? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStreamedResponseDiscriminator? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStreamedResponseDiscriminatorType? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutstandingClientToolCallsResponse? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionArtifact? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListSessionArtifactsResponse? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.SessionArtifact>? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IntervalScheduleConfiguration? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IntervalScheduleConfigurationType? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CronScheduleConfiguration? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CronScheduleConfigurationType? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScheduleConfiguration? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSchedule? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentSchedulesResponse? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentSchedule>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentScheduleRequest? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentScheduleRequest? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentScheduleExecution? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentScheduleExecutionStatus? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentScheduleExecutionsResponse? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentScheduleExecution>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentIdentityMode? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentIdentity? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentIdentityRequest? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSecrets? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAgentSecretsRequest? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentSecretsRequest? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorStatus? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputType? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfigurationBase? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SlackConnectorConfiguration? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SlackConnectorConfigurationVariant2? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GchatConnectorConfiguration? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GchatConnectorConfigurationVariant2? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ZoomConnectorConfiguration? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ZoomConnectorConfigurationVariant2? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetPresentation? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetSignIn? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetConnectorConfiguration? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetConnectorConfigurationVariant2? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfiguration? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfigurationDiscriminator? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfigurationDiscriminatorType? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorWebhookStatus? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentConnector? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentConnectorType? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentConnectorsResponse? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentConnector>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestBase? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationBase? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateSlackConnectorConfiguration? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateSlackConnectorConfigurationVariant2? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGchatConnectorConfiguration? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGchatConnectorConfigurationVariant2? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateZoomConnectorConfiguration? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateZoomConnectorConfigurationVariant2? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateWidgetConnectorConfiguration? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateWidgetConnectorConfigurationVariant2? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfiguration? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationDiscriminator? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationDiscriminatorType? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequest? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestVariant2? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestVariant2Type? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PublicSignIn? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PublicConnector? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWidgetConnectorConfiguration? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConnectorConfiguration? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConnectorConfigurationDiscriminator? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConnectorConfigurationDiscriminatorType? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentConnectorRequest? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateVisitorResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentInterface? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentProvider? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentExtension? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentCapabilities? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentExtension>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03ApiKeySecurityScheme? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03HttpAuthSecurityScheme? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AuthorizationCodeOAuthFlow? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03ClientCredentialsOAuthFlow? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03ImplicitOAuthFlow? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03PasswordOAuthFlow? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03OAuthFlows? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03OAuth2SecurityScheme? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03OpenIdConnectSecurityScheme? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03MutualTlsSecurityScheme? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SecurityScheme? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentSkill? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentCardSignature? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentCard? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentInterface>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.A2aV03SecurityScheme>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentSkill>? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentCardSignature>? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Role? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03FilePart? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03DataPart? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Part? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Message? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03Part>? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AuthenticationInfo? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03PushNotificationConfig? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SendMessageConfiguration? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SendMessageRequest? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskState? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskStatus? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Artifact? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Task? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03Artifact>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03Message>? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SendMessageResponse? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskStatusUpdateEvent? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskArtifactUpdateEvent? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03StreamResponse? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentInterface? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentProvider? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentExtension? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentCapabilities? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentExtension>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentSkill? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentCardSignature? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentCard? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentInterface>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentSkill>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentCardSignature>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Role? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Part? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Message? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Part>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AuthenticationInfo? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskPushNotificationConfig? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1SendMessageConfiguration? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1SendMessageRequest? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskState? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskStatus? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Artifact? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Task? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Artifact>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Message>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1SendMessageResponse? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskStatusUpdateEvent? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskArtifactUpdateEvent? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1StreamResponse? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1ListTasksResponse? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Task>? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SingleRuleTargets? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WeightedTarget? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WeightedRuleTargets? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.WeightedTarget>? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RuleTargets? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RuleTargetsDiscriminator? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RuleTargetsDiscriminatorType? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasRule? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RoutedAliasPolicy? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AliasRule>? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasPolicy? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasPolicyDiscriminator? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasPolicyDiscriminatorType? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentAlias? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentAliasesResponse? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentAlias>? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentAliasRequest? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentAliasRequest? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAliasPolicyRequest? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserSession? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserSessionStatus? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListEndUserSessionsResponse? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.EndUserSession>? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserSessionRequest? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEventBase? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserInputMessageEvent? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserInputMessageEventVariant2? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentOutputEvent? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentOutputEventVariant2? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserErrorEvent? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserErrorEventVariant2? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEvent? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEventDiscriminator? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEventDiscriminatorType? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListEndUserEventsResponse? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.EndUserEvent>? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestBase? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputMessageRequest? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputMessageRequestVariant2? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInterruptRequest? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInterruptRequestVariant2? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequest? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestDiscriminator? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestDiscriminatorType? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserMultipartInputEvent? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentResponse? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentStreamedResponse? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentStreamedResponseDiscriminator? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentStreamedResponseDiscriminatorType? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TrustedTokenIssuer? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTrustedTokenIssuersResponse? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.TrustedTokenIssuer>? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateTrustedTokenIssuerRequest? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceTrustedTokenIssuerRequest? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineStatus? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AclAccessLevel? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AclMetadata? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SourceRecordMetadata? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseSharepointSourceConfiguration? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SharepointSourceConfiguration? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseS3SourceConfiguration? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.S3SourceConfiguration? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SharedGoogleDriveScope? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MyGoogleDriveScope? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveScope? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveScopeDiscriminator? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveScopeDiscriminatorType? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseGoogleDriveSourceConfiguration? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.GoogleDriveScope>? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveSourceConfiguration? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BoxCcgAuth? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseBoxSourceConfiguration? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BoxSourceConfiguration? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenArticleStatus? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfiguration? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfigurationKbApi? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.WolkenArticleStatus>? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenKbSourceConfiguration? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenFormsSourceConfiguration? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenFormsSourceConfiguration? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenTicketRequestType? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenTicketsSourceConfiguration? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.WolkenTicketRequestType>? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenTicketsSourceConfiguration? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceAttachmentsConfiguration? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceEmbeddedImagesConfiguration? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceEmbeddedImagesConfigurationHandling? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseConfluenceSourceConfiguration? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseConfluenceSourceConfigurationDeployment? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceSourceConfiguration? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FluidtopicsDocumentFetchMode? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseFluidtopicsSourceConfiguration? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseFluidtopicsSourceConfigurationContentScope? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.FluidtopicsDocumentFetchMode>? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FluidtopicsSourceConfiguration? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseScimSourceConfiguration? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseScimSourceConfigurationIncrementalStrategy? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScimSourceConfiguration? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseDoceboSourceConfiguration? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DoceboSourceConfiguration? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWebSource? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SitemapPagesSource? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseCrawlPagesSource? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CrawlPagesSource? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CrawlPagesSourceVariant2? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SitemapCrawlPagesSource? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SitemapCrawlPagesSourceVariant2? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebPagesSource? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebPagesSourceDiscriminator? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebPagesSourceDiscriminatorType? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSourceConfiguration? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSourceConfigurationVariant2? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSource? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSourceDiscriminator? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSourceDiscriminatorType? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CronTriggerConfiguration? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IntervalTriggerConfiguration? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ManualTriggerConfiguration? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTrigger? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTriggerDiscriminator? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTriggerDiscriminatorType? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConditionVerification? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentVerification? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineVerification? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineVerificationDiscriminator? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineVerificationDiscriminatorType? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTransformConfiguration? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTransform? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTransformDiscriminator? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTransformDiscriminatorType? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSyncMode? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineProcessingOptions? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineWatermark? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Pipeline? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelinesResponse? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Pipeline>? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreatePipelineRequest? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateSharepointSourceConfiguration? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateS3SourceConfiguration? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateGoogleDriveSourceConfiguration? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateBoxSourceConfiguration? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWolkenKbSourceConfiguration? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWolkenFormsSourceConfiguration? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWolkenTicketsSourceConfiguration? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConfluenceSourceConfiguration? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateFluidtopicsSourceConfiguration? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateScimSourceConfiguration? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateDoceboSourceConfiguration? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWebSourceConfiguration? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWebSourceConfigurationVariant2? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineSource? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineSourceDiscriminator? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineSourceDiscriminatorType? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineRequest? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunStatus? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunTriggerType? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRun? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DeadLetterStatus? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DeadLetterOrigin? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineDeadLetterEntry? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelineDeadLetterEntriesResponse? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineDeadLetterEntry>? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreatePipelineDeadLetterEntryRequest? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ProcessPipelineDeadLetterEntriesRequest? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelineRunsResponse? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineRun>? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventType? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SortOrder? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventBase? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunStartedEvent? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunStartedEventVariant2? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunCompletedEventStatus? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunCompletedEvent? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunCompletedEventVariant2? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordProcessingEventStatus? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordProcessingEvent? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordProcessingEventVariant2? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WatermarkAdvancedEvent? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WatermarkAdvancedEventVariant2? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEvent? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventDiscriminator? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventDiscriminatorType? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelineRunEventsResponse? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineRunEvent>? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricOrigin? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptorBase? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricDescriptor? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricDescriptorVariant2? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricDescriptor? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricDescriptorVariant2? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentileEntry? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricDescriptor? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricDescriptorVariant2? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PercentileEntry>? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionBinDescriptor? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricDescriptor? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricDescriptorVariant2? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DistributionBinDescriptor>? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptor? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptorDiscriminator? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptorDiscriminatorType? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListMetricsResponse? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.MetricDescriptor>? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeriesBase? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScalarMetricPoint? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricSeries? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricSeriesVariant2? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ScalarMetricPoint>? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricSeries? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricSeriesVariant2? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricPoint? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricSeries? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricSeriesVariant2? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PercentilesMetricPoint>? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HistogramBin? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricPoint? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.HistogramBin>? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricSeries? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricSeriesVariant2? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DistributionMetricPoint>? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeries? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeriesDiscriminator? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeriesDiscriminatorType? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTrace? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceStatus? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentTracesResponse? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentTrace>? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanStatus? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanBase? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceInputFile? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentSpanAttributes? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentSpanAttributesOutputType? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentTraceInputFile>? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentSpanContent? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentTraceSpan? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentTraceSpanVariant2? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatSpanAttributes? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatTraceSpan? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatTraceSpanVariant2? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolSpanAttributes? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolSpanContent? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolTraceSpan? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolTraceSpanVariant2? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingSpanContent? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingTraceSpan? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingTraceSpanVariant2? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputSpanContent? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputTraceSpan? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputTraceSpanVariant2? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionSpanAttributes? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionTraceSpan? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionTraceSpanVariant2? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadSpanAttributes? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadTraceSpan? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadTraceSpanVariant2? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionSpanAttributes? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionTraceSpan? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionTraceSpanVariant2? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpan? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanDiscriminator? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanDiscriminatorOperation? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentTraceSpansResponse? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentTraceSpan>? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Glossary? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListGlossariesResponse? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Glossary>? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGlossaryRequest? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateGlossaryRequest? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GlossaryEntry? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GlossaryEntriesResponse? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.GlossaryEntry>? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpsertGlossaryEntriesRequest? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DeleteGlossaryEntriesRequest? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetOAuthTokenRequest? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCorpusDocumentWaitFor? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.JobState>? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolServersType? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolsType? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListInstructionsType? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListSessionArtifactsSortBy? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListSessionArtifactsOrderBy? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentConnectorsType? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAliasRoutedSessionArtifactsSortBy? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAliasRoutedSessionArtifactsOrderBy? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelinesSourceType? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineRunEventType>? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesStatus? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesErrorType? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesOperation? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesToolErrorType? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTraceSpansOperation? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AllOf<global::Vectara.User, global::Vectara.CreateUserResponse2>? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateUserResponse2? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ResetUserPasswordResponse? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetTokenResponse? Type1115 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.FilterAttribute>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.CorpusCustomDimension>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Corpus>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.FilterAttributeValue>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.FilterAttributeStat>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Cell>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Vectara.Cell>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Table>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ImageMetadata>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.DocumentPart>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Document>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Image>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.CoreDocumentPart>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.StructuredDocumentSection>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.FieldQuery>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ScoredDocument>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.IndividualSearchResult>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.QueryWarning>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.RewrittenQuery>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.SearchReranker>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.KeyedSearchCorpus>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.RerankedSearchResult>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.RewrittenQueryWarning>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.QueryHistorySpan>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.QueryHistorySummary>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Chat>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Turn>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Prompt>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Llm>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.DiscoveredLLM>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.JsonSchemaDefinition>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ChatCompletionRequestMessage>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ChatCompletionResponseChoice>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ChatCompletionStreamResponseChoice>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.GenerationPreset>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Encoder>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Reranker>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.TableExtractor>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.HallucinationCorrector>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.HcmSourceDocument>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.CorrectionItem>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Job>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ApiRole>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.CorpusRole>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentRole>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.User>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ApiKey>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AppClient>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ToolServer>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentKeyedSearchCorpus>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Tool>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Instruction>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.TemplatedReminderHook>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentStepInstruction>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentStepReminder>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.NextStep>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.SessionEnrichmentToolCall>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Agent>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentSession>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentInput>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ArtifactReference>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ClientToolPendingCall>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentEvent>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.CreateToolOutputRequest>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.SessionArtifact>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentSchedule>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentScheduleExecution>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentOutputType>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentConnector>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03AgentExtension>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03AgentInterface>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03AgentSkill>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03AgentCardSignature>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03Part>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03Artifact>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03Message>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1AgentExtension>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1AgentInterface>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1AgentSkill>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1AgentCardSignature>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1Part>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1Artifact>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1Message>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1Task>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.WeightedTarget>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AliasRule>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentAlias>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.EndUserSession>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.EndUserEvent>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.TrustedTokenIssuer>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.GoogleDriveScope>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.WolkenArticleStatus>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.WolkenTicketRequestType>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Pipeline>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PipelineDeadLetterEntry>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PipelineRun>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PipelineRunEvent>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PercentileEntry>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.DistributionBinDescriptor>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.MetricDescriptor>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ScalarMetricPoint>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PercentilesMetricPoint>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.HistogramBin>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.DistributionMetricPoint>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentTrace>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentTraceInputFile>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentTraceSpan>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Glossary>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.GlossaryEntry>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.JobState>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PipelineRunEventType>? ListType115 { get; set; }
    }
}