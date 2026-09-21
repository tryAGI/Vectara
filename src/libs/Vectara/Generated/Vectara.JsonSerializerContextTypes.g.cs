
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
        public global::Vectara.BedrockStaticIAMAuth? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BedrockApiKeyAuth? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexServiceAccountAuth? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAccessTokenAuth? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiApiKeyAuth? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiServiceAccountAuth? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMAuth? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMAuthDiscriminator? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMAuthDiscriminatorType? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Prompt? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Llm? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Prompt>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListLLMsResponse? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Llm>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RemoteAuth? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RemoteAuthDiscriminator? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RemoteAuthDiscriminatorType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OpenAILLMRequestBase? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAILLMRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAILLMRequestVariant2? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAIResponsesLLMRequest? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAIResponsesLLMRequestVariant2? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiAuth? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiAuthDiscriminator? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiAuthDiscriminatorType? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateVertexAILLMRequest? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AnthropicAuth? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AnthropicAuthDiscriminator? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AnthropicAuthDiscriminatorType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAnthropicLLMRequest? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLLMRequest? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLLMRequestDiscriminator? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLLMRequestDiscriminatorType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DiscoverLLMsRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DiscoveredLLM? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DiscoverLLMsResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DiscoveredLLM>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OpenAILLMUpdateBase? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAILLMRequest? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAILLMRequestVariant2? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAIResponsesLLMRequest? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateVertexAILLMRequest? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAnthropicLLMRequest? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLLMRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLLMRequestDiscriminator? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLLMRequestDiscriminatorType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionRequestMessage? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaBase? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaDefinition? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaObject? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaValue? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaDefinitionDiscriminator? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaDefinitionDiscriminatorType? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaObjectVariant2? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.JsonSchemaDefinition>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaValueVariant2? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.JsonSchemaDefinition>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaSpec? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ResponseFormat? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ResponseFormatType? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ChatCompletionRequestMessage>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionResponseMessage? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionResponseChoice? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionResponse? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionResponseObject? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ChatCompletionResponseChoice>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionStreamResponseDelta? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionStreamResponseChoice? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionStreamResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionStreamResponseObject? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ChatCompletionStreamResponseChoice>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationPresetOwnership? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationPreset? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListGenerationPresetsResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.GenerationPreset>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGenerationPresetRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EvaluateFactualConsistencyRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EvaluateFactualConsistencyRequestModelParameters? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EvaluateFactualConsistencyResponse? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Encoder? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListEncodersResponse? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Encoder>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAIEncoderRequest? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateVLlmEncoderRequest? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEncoderRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEncoderRequestDiscriminator? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEncoderRequestDiscriminatorType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Reranker? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListRerankersResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Reranker>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TableExtractor? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTableExtractorsResponse? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.TableExtractor>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HallucinationCorrector? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListHallucinationCorrectorsResponse? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.HallucinationCorrector>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HcmSourceDocument? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HallucinationCorrectionRequest? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.HcmSourceDocument>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorrectionItem? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HallucinationCorrectionResponse? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CorrectionItem>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobState? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobProgress? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobProgressPhase? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Job? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListJobsResponse? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Job>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiRole? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorpusRole? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorpusRoleRole? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentRole? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentRoleRole? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiOperationPolicy? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiPolicy? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.ApiOperationPolicy>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.User? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ApiRole>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CorpusRole>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentRole>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListUsersResponse? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.User>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateUserRequest? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateUserRequest? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiKeyRole? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiKey? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListApiKeysResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ApiKey>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateApiKeyRequest? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateApiKeyRequest? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AppClient? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAppClientsResponse? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AppClient>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateClientCredentialsRequest? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAppClientRequest? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAppClientRequestDiscriminator? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAppClientRequestDiscriminatorType? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAppClientRequest? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolServerType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolServerTransport? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolServer? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolServersResponse? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ToolServer>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolServerRequest? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolServerRequest? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolBase? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraTool? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraToolVariant2? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolAnnotations? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpTool? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolVariant2? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchTool? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolVariant2? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchTool? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolVariant2? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetTool? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolVariant2? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecutionConfiguration? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FunctionDefinition? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FunctionDefinitionLanguage? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FunctionDefinitionValidationStatus? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputOffloadingConfiguration? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputOffloadingConfigurationMode? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolConfigurationBase? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolConfigurationReference? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolConfigurationReferenceVariant2? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraToolConfiguration? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraToolConfigurationVariant2? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolConfiguration? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolConfigurationVariant2? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolParameters? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EagerReference? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentKeyedSearchCorpus? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<string, global::Vectara.EagerReference>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSearchCorporaParameters? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentKeyedSearchCorpus>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentCorporaSearchQueryConfiguration? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolConfiguration? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolConfigurationVariant2? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolParameters? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolParametersProvider? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolConfiguration? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolConfigurationVariant2? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetHeaderValue? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.WebGetHeaderValue>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetNoAuth? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetBearerAuth? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetHeaderAuth? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthClientCredentialsAuth? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthRefreshTokenAuth? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthTokenExchangeAuth? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAwsSigV4Auth? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAuth? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAuthDiscriminator? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAuthDiscriminatorType? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolParameters? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolParametersMethod? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<global::System.Collections.Generic.Dictionary<string, global::Vectara.WebGetHeaderValue>, global::Vectara.EagerReference>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<bool?, global::Vectara.EagerReference>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<int?, global::Vectara.EagerReference>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<long?, global::Vectara.EagerReference>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolParametersResponseMode? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolConfiguration? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolConfigurationVariant2? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolConfiguration? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolConfigurationVariant2? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolConfiguration? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolConfigurationVariant2? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolParameters? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentSessionMode? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentConfiguration? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolConfiguration? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolConfigurationVariant2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolParameters? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolParametersEncoding? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadConfiguration? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolConfiguration? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolConfigurationVariant2? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolParameters? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolConfiguration? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolConfigurationVariant2? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolParameters? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolParametersDetail? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolConfiguration? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolConfigurationVariant2? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolParameters? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolParametersOutputFormat? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolConfiguration? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolConfigurationVariant2? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextParameters? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextConfiguration? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextConfigurationMetadata? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextToolConfiguration? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextToolConfigurationVariant2? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentToolConfiguration? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentToolConfigurationDiscriminator? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentToolConfigurationDiscriminatorType? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaTool? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolVariant2? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolVariant2Language? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentToolConfiguration>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentTool? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolVariant2? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactCreateTool? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactCreateToolVariant2? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadTool? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolVariant2? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepTool? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolVariant2? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadTool? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolVariant2? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionTool? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolVariant2? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextTool? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextToolVariant2? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientTool? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolVariant2? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Tool? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolDiscriminator? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolDiscriminatorType? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolsResponse? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Tool>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLambdaToolRequest? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLambdaToolRequestLanguage? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateClientToolRequest? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolRequest? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolRequestDiscriminator? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolRequestDiscriminatorType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolContextAgent? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolContextSession? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolContext? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolRequest? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolRequestLanguage? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponse? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseValidation? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseValidationStatus? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseExecution? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseExecutionError? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseExecutionValidationResults? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolHeartbeatEvent? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResultEvent? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolStreamedResponse? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolStreamedResponseDiscriminator? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolStreamedResponseDiscriminatorType? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateMcpToolRequest? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLambdaToolRequest? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateClientToolRequest? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolRequest? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolRequestDiscriminator? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolRequestDiscriminatorType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolRequest? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolSuccessResponse? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolSuccessResponseValidationResults? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolErrorResponse? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolErrorResponseError? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResponse? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResponseDiscriminator? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResponseDiscriminatorType? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResultEvent? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolStreamedResponse? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolStreamedResponseDiscriminator? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolStreamedResponseDiscriminatorType? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TemplateType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InitialInstruction? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Instruction? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionDiscriminator? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionDiscriminatorType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListInstructionsResponse? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Instruction>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionRequestBase? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInitialInstructionRequest? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInitialInstructionRequestVariant2? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInstructionRequest? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInstructionRequestDiscriminator? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInstructionRequestDiscriminatorType? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInitialInstructionRequest? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInstructionRequest? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInstructionRequestDiscriminator? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInstructionRequestDiscriminatorType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestInstructionRequest? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestInstructionResponse? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSkill? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RetryConfiguration? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentModel? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionReference? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReferenceInstruction? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReferenceInstructionVariant2? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InlineInstruction? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InlineInstructionVariant2? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepInstruction? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepInstructionDiscriminator? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepInstructionDiscriminatorType? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DefaultOutputParser? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredOutputParser? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputParser? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputParserDiscriminator? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputParserDiscriminatorType? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TemplatedReminder? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.TemplatedReminderHook>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TemplatedReminderHook? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GlossaryExpansionReminder? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepReminder? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepReminderDiscriminator? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepReminderDiscriminatorType? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.NextStep? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FirstAgentStep? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentStepInstruction>? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentStepReminder>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.NextStep>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStep? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionConfig? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionConfigToolEventPolicy? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionEnrichmentToolCall? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionEnrichmentConfig? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.SessionEnrichmentToolCall>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Agent? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentSkill>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentStep>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentsResponse? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Agent>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentRequest? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAgentRequest? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAgentRequestVariant2? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateFirstAgentStep? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentStep? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentRequest? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.UpdateAgentStep>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputTokens? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputTokens? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionContextUsage? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSession? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSessionStatus? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentSessionsResponse? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentSession>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentSessionRequest? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentSessionRequestFromSession? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentSessionRequest? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEventBase? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTextInput? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSkillInput? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentInput? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentInputDiscriminator? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentInputDiscriminatorType? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputMessageEvent? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputMessageEventVariant2? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentInput>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SkillLoadEvent? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SkillLoadEventVariant2? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReference? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactUploadEvent? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactUploadEventVariant2? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ArtifactReference>? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolInputEvent? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolInputEventVariant2? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputEvent? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputEventVariant2? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingEvent? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingEventVariant2? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputEvent? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputEventVariant2? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredOutputEvent? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredOutputEventVariant2? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextLimitExceededEvent? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextLimitExceededEventVariant2? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionLimitExceededEvent? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionLimitExceededEventVariant2? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionInterruptedEvent? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionInterruptedEventVariant2? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentErrorEvent? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolPendingCall? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolPendingEvent? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolPendingEventVariant2? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ClientToolPendingCall>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadEvent? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadEventVariant2? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadEventVariant2Detail? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionEvent? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionEventVariant2? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionEvent? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionEventVariant2? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEvent? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEventDiscriminator? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEventDiscriminatorType? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentEventsResponse? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentEvent>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SurfaceDescription? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequestBase? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputBehavior? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputMessageRequest? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputMessageRequestVariant2? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInterruptRequest? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInterruptRequestVariant2? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCompactRequest? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCompactRequestVariant2? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputBase? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputSuccess? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputSuccessVariant2? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputError? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputErrorVariant2? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputRequest? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputRequestDiscriminator? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputRequestDiscriminatorType? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolOutputRequest? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolOutputRequestVariant2? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CreateToolOutputRequest>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequest? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequestDiscriminator? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequestDiscriminatorType? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MultipartInputEvent? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentResponse? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingAgentOutput? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingAgentOutputEnd? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingThinking? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingThinkingEnd? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextConsumedEvent? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionStartedEvent? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionStartedEventVariant2? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEventBase? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenericToolActivityEvent? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenericToolActivityEventVariant2? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolActivityEvent? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolActivityEventVariant2? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEvent? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEventDiscriminator? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEventDiscriminatorActivityType? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStreamedResponse? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStreamedResponseDiscriminator? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStreamedResponseDiscriminatorType? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutstandingClientToolCallsResponse? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionArtifact? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListSessionArtifactsResponse? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.SessionArtifact>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IntervalScheduleConfiguration? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IntervalScheduleConfigurationType? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CronScheduleConfiguration? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CronScheduleConfigurationType? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScheduleConfiguration? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSchedule? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentSchedulesResponse? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentSchedule>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentScheduleRequest? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentScheduleRequest? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentScheduleExecution? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentScheduleExecutionStatus? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentScheduleExecutionsResponse? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentScheduleExecution>? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentIdentityMode? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentIdentity? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentIdentityRequest? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSecrets? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAgentSecretsRequest? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentSecretsRequest? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorStatus? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputType? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfigurationBase? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SlackConnectorConfiguration? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SlackConnectorConfigurationVariant2? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GchatConnectorConfiguration? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GchatConnectorConfigurationVariant2? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ZoomConnectorConfiguration? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ZoomConnectorConfigurationVariant2? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetPresentation? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetSignIn? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetConnectorConfiguration? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetConnectorConfigurationVariant2? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfiguration? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfigurationDiscriminator? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfigurationDiscriminatorType? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorWebhookStatus? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentConnector? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentConnectorType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentConnectorsResponse? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentConnector>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestBase? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationBase? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateSlackConnectorConfiguration? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateSlackConnectorConfigurationVariant2? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGchatConnectorConfiguration? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGchatConnectorConfigurationVariant2? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateZoomConnectorConfiguration? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateZoomConnectorConfigurationVariant2? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateWidgetConnectorConfiguration? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateWidgetConnectorConfigurationVariant2? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfiguration? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationDiscriminator? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationDiscriminatorType? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequest? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestVariant2? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestVariant2Type? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PublicSignIn? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PublicConnector? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWidgetConnectorConfiguration? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConnectorConfiguration? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConnectorConfigurationDiscriminator? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConnectorConfigurationDiscriminatorType? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentConnectorRequest? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateVisitorResponse? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentInterface? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentProvider? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentExtension? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentCapabilities? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentExtension>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03ApiKeySecurityScheme? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03HttpAuthSecurityScheme? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AuthorizationCodeOAuthFlow? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03ClientCredentialsOAuthFlow? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03ImplicitOAuthFlow? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03PasswordOAuthFlow? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03OAuthFlows? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03OAuth2SecurityScheme? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03OpenIdConnectSecurityScheme? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03MutualTlsSecurityScheme? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SecurityScheme? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentSkill? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentCardSignature? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentCard? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentInterface>? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.A2aV03SecurityScheme>? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentSkill>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentCardSignature>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Role? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03FilePart? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03DataPart? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Part? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Message? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03Part>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AuthenticationInfo? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03PushNotificationConfig? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SendMessageConfiguration? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SendMessageRequest? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskState? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskStatus? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Artifact? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Task? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03Artifact>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03Message>? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SendMessageResponse? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskStatusUpdateEvent? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskArtifactUpdateEvent? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03StreamResponse? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentInterface? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentProvider? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentExtension? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentCapabilities? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentExtension>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentSkill? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentCardSignature? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentCard? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentInterface>? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentSkill>? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentCardSignature>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Role? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Part? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Message? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Part>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AuthenticationInfo? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskPushNotificationConfig? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1SendMessageConfiguration? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1SendMessageRequest? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskState? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskStatus? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Artifact? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Task? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Artifact>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Message>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1SendMessageResponse? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskStatusUpdateEvent? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskArtifactUpdateEvent? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1StreamResponse? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1ListTasksResponse? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Task>? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SingleRuleTargets? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WeightedTarget? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WeightedRuleTargets? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.WeightedTarget>? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RuleTargets? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RuleTargetsDiscriminator? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RuleTargetsDiscriminatorType? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasRule? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RoutedAliasPolicy? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AliasRule>? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasPolicy? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasPolicyDiscriminator? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasPolicyDiscriminatorType? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentAlias? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentAliasesResponse? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentAlias>? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentAliasRequest? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentAliasRequest? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAliasPolicyRequest? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserSession? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserSessionStatus? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListEndUserSessionsResponse? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.EndUserSession>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserSessionRequest? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEventBase? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserInputMessageEvent? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserInputMessageEventVariant2? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentOutputEvent? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentOutputEventVariant2? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserErrorEvent? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserErrorEventVariant2? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEvent? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEventDiscriminator? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEventDiscriminatorType? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListEndUserEventsResponse? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.EndUserEvent>? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestBase? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputMessageRequest? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputMessageRequestVariant2? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInterruptRequest? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInterruptRequestVariant2? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequest? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestDiscriminator? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestDiscriminatorType? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserMultipartInputEvent? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentResponse? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentStreamedResponse? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentStreamedResponseDiscriminator? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentStreamedResponseDiscriminatorType? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TrustedTokenIssuer? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTrustedTokenIssuersResponse? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.TrustedTokenIssuer>? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateTrustedTokenIssuerRequest? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceTrustedTokenIssuerRequest? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineStatus? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AclAccessLevel? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AclMetadata? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SourceRecordMetadata? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseSharepointSourceConfiguration? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SharepointSourceConfiguration? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseS3SourceConfiguration? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.S3SourceConfiguration? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SharedGoogleDriveScope? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MyGoogleDriveScope? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveScope? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveScopeDiscriminator? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveScopeDiscriminatorType? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseGoogleDriveSourceConfiguration? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.GoogleDriveScope>? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveSourceConfiguration? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BoxCcgAuth? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseBoxSourceConfiguration? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BoxSourceConfiguration? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenArticleStatus? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfiguration? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfigurationKbApi? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.WolkenArticleStatus>? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenKbSourceConfiguration? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenFormsSourceConfiguration? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenFormsSourceConfiguration? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenTicketRequestType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenTicketsSourceConfiguration? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.WolkenTicketRequestType>? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenTicketsSourceConfiguration? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceAttachmentsConfiguration? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceEmbeddedImagesConfiguration? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceEmbeddedImagesConfigurationHandling? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseConfluenceSourceConfiguration? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseConfluenceSourceConfigurationDeployment? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceSourceConfiguration? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FluidtopicsDocumentFetchMode? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseFluidtopicsSourceConfiguration? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseFluidtopicsSourceConfigurationContentScope? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.FluidtopicsDocumentFetchMode>? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FluidtopicsSourceConfiguration? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseScimSourceConfiguration? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseScimSourceConfigurationIncrementalStrategy? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScimSourceConfiguration? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseDoceboSourceConfiguration? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DoceboSourceConfiguration? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWebSource? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SitemapPagesSource? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseCrawlPagesSource? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CrawlPagesSource? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CrawlPagesSourceVariant2? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SitemapCrawlPagesSource? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SitemapCrawlPagesSourceVariant2? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebPagesSource? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebPagesSourceDiscriminator? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebPagesSourceDiscriminatorType? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSourceConfiguration? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSourceConfigurationVariant2? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSource? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSourceDiscriminator? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSourceDiscriminatorType? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CronTriggerConfiguration? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IntervalTriggerConfiguration? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ManualTriggerConfiguration? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTrigger? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTriggerDiscriminator? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTriggerDiscriminatorType? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConditionVerification? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentVerification? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineVerification? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineVerificationDiscriminator? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineVerificationDiscriminatorType? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTransformConfiguration? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTransform? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTransformDiscriminator? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTransformDiscriminatorType? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSyncMode? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineProcessingOptions? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineWatermark? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Pipeline? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelinesResponse? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Pipeline>? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreatePipelineRequest? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateSharepointSourceConfiguration? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateS3SourceConfiguration? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateGoogleDriveSourceConfiguration? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateBoxSourceConfiguration? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWolkenKbSourceConfiguration? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWolkenFormsSourceConfiguration? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWolkenTicketsSourceConfiguration? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConfluenceSourceConfiguration? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateFluidtopicsSourceConfiguration? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateScimSourceConfiguration? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateDoceboSourceConfiguration? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWebSourceConfiguration? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWebSourceConfigurationVariant2? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineSource? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineSourceDiscriminator? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineSourceDiscriminatorType? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineRequest? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunStatus? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunTriggerType? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRun? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DeadLetterStatus? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DeadLetterOrigin? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineDeadLetterEntry? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelineDeadLetterEntriesResponse? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineDeadLetterEntry>? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreatePipelineDeadLetterEntryRequest? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ProcessPipelineDeadLetterEntriesRequest? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelineRunsResponse? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineRun>? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventType? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SortOrder? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventBase? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunStartedEvent? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunStartedEventVariant2? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunCompletedEventStatus? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunCompletedEvent? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunCompletedEventVariant2? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordProcessingEventStatus? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordProcessingEvent? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordProcessingEventVariant2? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WatermarkAdvancedEvent? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WatermarkAdvancedEventVariant2? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEvent? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventDiscriminator? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventDiscriminatorType? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelineRunEventsResponse? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineRunEvent>? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricOrigin? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptorBase? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricDescriptor? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricDescriptorVariant2? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricDescriptor? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricDescriptorVariant2? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentileEntry? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricDescriptor? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricDescriptorVariant2? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PercentileEntry>? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionBinDescriptor? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricDescriptor? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricDescriptorVariant2? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DistributionBinDescriptor>? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptor? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptorDiscriminator? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptorDiscriminatorType? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListMetricsResponse? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.MetricDescriptor>? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeriesBase? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScalarMetricPoint? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricSeries? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricSeriesVariant2? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ScalarMetricPoint>? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricSeries? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricSeriesVariant2? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricPoint? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricSeries? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricSeriesVariant2? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PercentilesMetricPoint>? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HistogramBin? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricPoint? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.HistogramBin>? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricSeries? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricSeriesVariant2? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DistributionMetricPoint>? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeries? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeriesDiscriminator? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeriesDiscriminatorType? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTrace? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceStatus? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentTracesResponse? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentTrace>? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanStatus? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanBase? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceInputFile? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentSpanAttributes? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentSpanAttributesOutputType? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentTraceInputFile>? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentSpanContent? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentTraceSpan? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentTraceSpanVariant2? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatSpanAttributes? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatTraceSpan? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatTraceSpanVariant2? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolSpanAttributes? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolSpanContent? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolTraceSpan? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolTraceSpanVariant2? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingSpanContent? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingTraceSpan? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingTraceSpanVariant2? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputSpanContent? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputTraceSpan? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputTraceSpanVariant2? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionSpanAttributes? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionTraceSpan? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionTraceSpanVariant2? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadSpanAttributes? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadTraceSpan? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadTraceSpanVariant2? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionSpanAttributes? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionTraceSpan? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionTraceSpanVariant2? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpan? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanDiscriminator? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanDiscriminatorOperation? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentTraceSpansResponse? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentTraceSpan>? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Glossary? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListGlossariesResponse? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Glossary>? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGlossaryRequest? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateGlossaryRequest? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GlossaryEntry? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GlossaryEntriesResponse? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.GlossaryEntry>? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpsertGlossaryEntriesRequest? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DeleteGlossaryEntriesRequest? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetOAuthTokenRequest? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCorpusDocumentWaitFor? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.JobState>? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolServersType? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolsType? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListInstructionsType? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListSessionArtifactsSortBy? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListSessionArtifactsOrderBy? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentConnectorsType? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAliasRoutedSessionArtifactsSortBy? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAliasRoutedSessionArtifactsOrderBy? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelinesSourceType? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineRunEventType>? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesStatus? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesErrorType? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesOperation? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesToolErrorType? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTraceSpansOperation? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AllOf<global::Vectara.User, global::Vectara.CreateUserResponse2>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateUserResponse2? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ResetUserPasswordResponse? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetTokenResponse? Type1113 { get; set; }

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