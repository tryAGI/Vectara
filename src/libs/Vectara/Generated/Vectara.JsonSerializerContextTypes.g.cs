
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::Vectara.MeasuredStorage? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Corpus? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.FilterAttribute>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CorpusCustomDimension>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorpusLimits? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListMetadata? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListCorporaResponse? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Corpus>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Error? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCorpusRequest? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BadRequestError? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.NotFoundError? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateCorpusRequest? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceFilterAttributesRequest? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceFilterAttributesResponse? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ComputeCorpusSizeResponse? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttributeValue? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttributeNumericStats? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttributeStat? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterAttributeStatType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.FilterAttributeValue>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetFilterAttributeStatsResponse? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.FilterAttributeStat>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MaxCharsChunkingStrategy? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SentenceChunkingStrategy? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChunkingStrategy? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChunkingStrategyDiscriminator? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChunkingStrategyDiscriminatorType? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TableExtractorSpec? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TableGenerationSpec? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TableExtractionConfig? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UploadFileRequest? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Cell? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Cell>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Data? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Vectara.Cell>>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Table? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageMetadata? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentPart? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentStorageUsage? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExtractionUsage? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Document? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Table>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ImageMetadata>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DocumentPart>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListDocumentsResponse? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Document>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageData? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Image? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CoreDocumentPart? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CoreDocumentPartImagePartMode? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CoreDocument? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Image>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CoreDocumentPart>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredDocumentSection? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.StructuredDocumentSection>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredDocument? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateDocumentRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateDocumentRequestDiscriminator? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateDocumentRequestDiscriminatorType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteAsyncResponse? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteAsyncResponseResponseType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteSyncSuccessResponse? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteSyncSuccessResponseResponseType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteDocumentsResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteDocumentsResponseDiscriminator? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkDeleteDocumentsResponseDiscriminatorType? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataRequest? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataRequestStrategy? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataResponseBase? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataAsyncResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataResponse? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminator? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateDocumentRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SummarizeDocumentRequest? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SummarizeDocumentResponse? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamGenerationChunk? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationInfo? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamGenerationEnd? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamError? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamResponseEnd? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SummarizeDocumentStreamedResponse? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SummarizeDocumentStreamedResponseDiscriminator? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FieldQuery? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetadataQueryRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetadataQueryRequestLevel? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.FieldQuery>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScoredDocument? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetadataQueryResponse? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ScoredDocument>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Language? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchResultBase? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TextSearchResult? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TextSearchResultVariant2? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageSearchResult? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageSearchResultVariant2? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IndividualSearchResult? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IndividualSearchResultDiscriminator? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IndividualSearchResultDiscriminatorResultType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryWarning? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FilterExtraction? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RewrittenQuery? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryFullResponse? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.IndividualSearchResult>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.QueryWarning>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.RewrittenQuery>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchSemantics? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchCorpus? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextConfiguration? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CustomerSpecificReranker? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UserFunctionReranker? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MMRReranker? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchReranker? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChainReranker? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.NoneReranker? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchRerankerDiscriminator? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchRerankerDiscriminatorType? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.SearchReranker>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchParameters? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchParametersMaxBy? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CitationParameters? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CitationParametersStyle? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationParameters? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationParametersModelParameters? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryCorpusRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AllOf<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamSearchResponse? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FactualConsistencyScore? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryStreamedResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryStreamedResponseDiscriminator? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryStreamedResponseDiscriminatorType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.KeyedSearchCorpus? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.KeyedSearchCorpusVariant2? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchCorporaParameters? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchCorporaParametersVariant1? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.KeyedSearchCorpus>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryRequest? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RephraseSpan? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SearchSpan? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RerankedSearchResult? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RerankSpan? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.RerankedSearchResult>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationSpan? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FactualConsistencyScoreSpan? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RewrittenQueryWarning? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RewrittenQuerySpan? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.RewrittenQueryWarning>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryHistorySpan? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryHistorySpanDiscriminator? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryHistorySpanDiscriminatorType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryHistory? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.QueryHistorySpan>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.QueryHistorySummary? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListQueryHistoriesResponse? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.QueryHistorySummary>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListQueryHistoriesResponseMetadata? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Chat? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListChatsResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Chat>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatParameters? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatRequest? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatFullResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatInfoResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatStreamedResponse? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatStreamedResponseDiscriminator? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatStreamedResponseDiscriminatorType? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Turn? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListChatTurnsResponse? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Turn>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateTurnRequest? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UsageAllowance? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UsageAllowanceState? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Usage? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UsageUnit? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UsageWindow? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListUsagesResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Usage>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMCapabilities? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMOwnership? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BearerAuth? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HeaderAuth? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OAuthClientCredentialsAuth? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OAuthClientCredentialsAuthClientAuthMethod? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BedrockStaticIAMAuth? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BedrockApiKeyAuth? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexServiceAccountAuth? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAccessTokenAuth? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiApiKeyAuth? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiServiceAccountAuth? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMAuth? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMAuthDiscriminator? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LLMAuthDiscriminatorType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Prompt? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Llm? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Prompt>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListLLMsResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Llm>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RemoteAuth? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RemoteAuthDiscriminator? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RemoteAuthDiscriminatorType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OpenAILLMRequestBase? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAILLMRequest? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAILLMRequestVariant2? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAIResponsesLLMRequest? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAIResponsesLLMRequestVariant2? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiAuth? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiAuthDiscriminator? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.VertexAiAuthDiscriminatorType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateVertexAILLMRequest? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AnthropicAuth? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AnthropicAuthDiscriminator? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AnthropicAuthDiscriminatorType? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAnthropicLLMRequest? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLLMRequest? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLLMRequestDiscriminator? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLLMRequestDiscriminatorType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DiscoverLLMsRequest? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DiscoveredLLM? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DiscoverLLMsResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DiscoveredLLM>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OpenAILLMUpdateBase? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAILLMRequest? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAILLMRequestVariant2? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAIResponsesLLMRequest? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateVertexAILLMRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAnthropicLLMRequest? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLLMRequest? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLLMRequestDiscriminator? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLLMRequestDiscriminatorType? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionRequestMessage? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaBase? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaDefinition? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaObject? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaValue? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaDefinitionDiscriminator? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaDefinitionDiscriminatorType? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaObjectVariant2? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.JsonSchemaDefinition>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaValueVariant2? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.JsonSchemaDefinition>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaSpec? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ResponseFormat? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ResponseFormatType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionRequest? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ChatCompletionRequestMessage>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionResponseMessage? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionResponseChoice? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionResponse? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionResponseObject? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ChatCompletionResponseChoice>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionStreamResponseDelta? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatCompletionStreamResponseChoice? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionStreamResponse? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateChatCompletionStreamResponseObject? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ChatCompletionStreamResponseChoice>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationPresetOwnership? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenerationPreset? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListGenerationPresetsResponse? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.GenerationPreset>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGenerationPresetRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EvaluateFactualConsistencyRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EvaluateFactualConsistencyRequestModelParameters? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EvaluateFactualConsistencyResponse? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Encoder? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListEncodersResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Encoder>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateOpenAIEncoderRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateVLlmEncoderRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEncoderRequest? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEncoderRequestDiscriminator? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEncoderRequestDiscriminatorType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Reranker? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListRerankersResponse? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Reranker>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TableExtractor? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTableExtractorsResponse? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.TableExtractor>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HallucinationCorrector? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListHallucinationCorrectorsResponse? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.HallucinationCorrector>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HcmSourceDocument? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HallucinationCorrectionRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.HcmSourceDocument>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorrectionItem? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HallucinationCorrectionResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CorrectionItem>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobState? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobProgress? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobProgressPhase? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Job? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JobType? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListJobsResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Job>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiRole? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorpusRole? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorpusRoleRole? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentRole? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentRoleRole? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiOperationPolicy? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiPolicy? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.ApiOperationPolicy>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.User? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ApiRole>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CorpusRole>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentRole>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListUsersResponse? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.User>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateUserRequest? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateUserRequest? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiKeyRole? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ApiKey? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListApiKeysResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ApiKey>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateApiKeyRequest? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateApiKeyRequest? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AppClient? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAppClientsResponse? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AppClient>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateClientCredentialsRequest? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAppClientRequest? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAppClientRequestDiscriminator? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAppClientRequestDiscriminatorType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAppClientRequest? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolServerType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolServerTransport? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolServer? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolServersResponse? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ToolServer>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolServerRequest? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolServerRequest? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolBase? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraTool? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraToolVariant2? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolAnnotations? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpTool? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolVariant2? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchTool? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolVariant2? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchTool? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolVariant2? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetTool? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolVariant2? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecutionConfiguration? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FunctionDefinition? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FunctionDefinitionLanguage? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FunctionDefinitionValidationStatus? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputOffloadingConfiguration? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputOffloadingConfigurationMode? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolConfigurationBase? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolConfigurationReference? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolConfigurationReferenceVariant2? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraToolConfiguration? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DynamicVectaraToolConfigurationVariant2? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolConfiguration? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.McpToolConfigurationVariant2? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolParameters? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EagerReference? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentKeyedSearchCorpus? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<string, global::Vectara.EagerReference>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSearchCorporaParameters? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentKeyedSearchCorpus>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentCorporaSearchQueryConfiguration? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolConfiguration? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CorporaSearchToolConfigurationVariant2? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolParameters? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolParametersProvider? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolConfiguration? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSearchToolConfigurationVariant2? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetHeaderValue? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.WebGetHeaderValue>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetNoAuth? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetBearerAuth? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetHeaderAuth? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthClientCredentialsAuth? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthRefreshTokenAuth? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthTokenExchangeAuth? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAwsSigV4Auth? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAuth? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAuthDiscriminator? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAuthDiscriminatorType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolParameters? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolParametersMethod? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<global::System.Collections.Generic.Dictionary<string, global::Vectara.WebGetHeaderValue>, global::Vectara.EagerReference>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<bool?, global::Vectara.EagerReference>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<int?, global::Vectara.EagerReference>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OneOf<long?, global::Vectara.EagerReference>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolParametersResponseMode? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolConfiguration? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetToolConfigurationVariant2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolConfiguration? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolConfigurationVariant2? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolConfiguration? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolConfigurationVariant2? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolParameters? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentSessionMode? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentConfiguration? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolConfiguration? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolConfigurationVariant2? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolParameters? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolParametersEncoding? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadConfiguration? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolConfiguration? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolConfigurationVariant2? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolParameters? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolConfiguration? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolConfigurationVariant2? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolParameters? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolParametersDetail? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolConfiguration? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolConfigurationVariant2? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolParameters? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolParametersOutputFormat? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolConfiguration? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolConfigurationVariant2? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextParameters? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextConfiguration? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextConfigurationMetadata? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextToolConfiguration? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextToolConfigurationVariant2? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentToolConfiguration? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentToolConfigurationDiscriminator? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentToolConfigurationDiscriminatorType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaTool? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolVariant2? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.LambdaToolVariant2Language? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentToolConfiguration>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentTool? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolVariant2? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactCreateTool? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactCreateToolVariant2? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadTool? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReadToolVariant2? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepTool? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactGrepToolVariant2? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadTool? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadToolVariant2? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionTool? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DocumentConversionToolVariant2? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextTool? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetDocumentTextToolVariant2? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientTool? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolVariant2? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Tool? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolDiscriminator? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolDiscriminatorType? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolsResponse? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Tool>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLambdaToolRequest? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateLambdaToolRequestLanguage? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateClientToolRequest? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolRequest? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolRequestDiscriminator? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolRequestDiscriminatorType? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolContextAgent? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolContextSession? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolContext? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolRequest? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolRequestLanguage? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponse? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseValidation? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseValidationStatus? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseExecution? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseExecutionError? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResponseExecutionValidationResults? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolHeartbeatEvent? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResultEvent? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolStreamedResponse? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolStreamedResponseDiscriminator? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolStreamedResponseDiscriminatorType? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateMcpToolRequest? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateLambdaToolRequest? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateClientToolRequest? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolRequest? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolRequestDiscriminator? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateToolRequestDiscriminatorType? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolSuccessResponse? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolSuccessResponseValidationResults? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolErrorResponse? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolErrorResponseError? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResponse? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResponseDiscriminator? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResponseDiscriminatorType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResultEvent? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolStreamedResponse? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolStreamedResponseDiscriminator? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolStreamedResponseDiscriminatorType? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TemplateType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InitialInstruction? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Instruction? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionDiscriminator? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionDiscriminatorType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListInstructionsResponse? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Instruction>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionRequestBase? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInitialInstructionRequest? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInitialInstructionRequestVariant2? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInstructionRequest? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInstructionRequestDiscriminator? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInstructionRequestDiscriminatorType? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInitialInstructionRequest? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInstructionRequest? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInstructionRequestDiscriminator? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateInstructionRequestDiscriminatorType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestInstructionRequest? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestInstructionResponse? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSkill? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RetryConfiguration? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentModel? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepType? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InstructionReference? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReferenceInstruction? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReferenceInstructionVariant2? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InlineInstruction? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InlineInstructionVariant2? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepInstruction? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepInstructionDiscriminator? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepInstructionDiscriminatorType? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DefaultOutputParser? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredOutputParser? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputParser? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputParserDiscriminator? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputParserDiscriminatorType? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TemplatedReminder? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.TemplatedReminderHook>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TemplatedReminderHook? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GlossaryExpansionReminder? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepReminder? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepReminderDiscriminator? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepReminderDiscriminatorType? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.NextStep? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallOnFailureBase? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallEndTurn? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallEndTurnVariant2? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallContinue? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallContinueVariant2? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallNextStep? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallNextStepVariant2? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallOnFailure? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallOnFailureDiscriminator? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallOnFailureDiscriminatorType? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStepToolCall? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FirstAgentStep? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentStepInstruction>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentStepReminder>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.NextStep>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentStepToolCall>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStep? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionConfig? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionConfigToolEventPolicy? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionEnrichmentToolCall? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionEnrichmentConfig? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.SessionEnrichmentToolCall>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionDescriptionConfiguration? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Agent? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentSkill>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentStep>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentsResponse? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Agent>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentRequest? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAgentRequest? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAgentRequestVariant2? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateFirstAgentStep? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentStep? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentRequest? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.UpdateAgentStep>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputTokens? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputTokens? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionContextUsage? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSession? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSessionStatus? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentSessionsResponse? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentSession>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentSessionRequest? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentSessionRequestFromSession? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentSessionRequest? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEventBase? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTextInput? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSkillInput? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentInput? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentInputDiscriminator? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentInputDiscriminatorType? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputMessageEvent? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputMessageEventVariant2? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentInput>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SkillLoadEvent? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SkillLoadEventVariant2? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactReference? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactUploadEvent? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactUploadEventVariant2? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ArtifactReference>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallSource? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolInputEvent? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolInputEventVariant2? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputEvent? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolOutputEventVariant2? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingEvent? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingEventVariant2? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputEvent? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputEventVariant2? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredOutputEvent? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StructuredOutputEventVariant2? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextLimitExceededEvent? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextLimitExceededEventVariant2? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionLimitExceededEvent? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionLimitExceededEventVariant2? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionInterruptedEvent? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionInterruptedEventVariant2? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentErrorEvent? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolPendingCall? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolPendingEvent? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolPendingEventVariant2? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ClientToolPendingCall>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadEvent? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadEventVariant2? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadEventVariant2Detail? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionEvent? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionEventVariant2? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionEvent? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionEventVariant2? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEvent? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEventDiscriminator? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEventDiscriminatorType? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentEventsResponse? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentEvent>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SurfaceDescription? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequestBase? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionArtifactReference? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InputBehavior? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputMessageRequest? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputMessageRequestVariant2? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.SessionArtifactReference>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInterruptRequest? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInterruptRequestVariant2? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCompactRequest? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCompactRequestVariant2? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputBase? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputSuccess? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputSuccessVariant2? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputError? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputErrorVariant2? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputRequest? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputRequestDiscriminator? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateToolOutputRequestDiscriminatorType? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolOutputRequest? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ClientToolOutputRequestVariant2? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.CreateToolOutputRequest>? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequest? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequestDiscriminator? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateInputRequestDiscriminatorType? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MultipartInputEvent? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentResponse? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingAgentOutput? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingAgentOutputEnd? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingThinking? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StreamingThinkingEnd? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionDescriptionEvent? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ContextConsumedEvent? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionStartedEvent? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionStartedEventVariant2? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEventBase? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenericToolActivityEvent? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GenericToolActivityEventVariant2? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolActivityEvent? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SubAgentToolActivityEventVariant2? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEvent? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEventDiscriminator? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ToolActivityEventDiscriminatorActivityType? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStreamedResponse? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStreamedResponseDiscriminator? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentStreamedResponseDiscriminatorType? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutstandingClientToolCallsResponse? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SessionArtifact? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListSessionArtifactsResponse? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.SessionArtifact>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IntervalScheduleConfiguration? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IntervalScheduleConfigurationType? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CronScheduleConfiguration? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CronScheduleConfigurationType? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScheduleConfiguration? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSchedule? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentSchedulesResponse? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentSchedule>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentScheduleRequest? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentScheduleRequest? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentScheduleExecution? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentScheduleExecutionStatus? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentScheduleExecutionsResponse? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentScheduleExecution>? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentIdentityMode? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentIdentity? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentIdentityRequest? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentSecrets? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAgentSecretsRequest? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentSecretsRequest? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorStatus? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentOutputType? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfigurationBase? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SlackConnectorConfiguration? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SlackConnectorConfigurationVariant2? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GchatConnectorConfiguration? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GchatConnectorConfigurationVariant2? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ZoomConnectorConfiguration? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ZoomConnectorConfigurationVariant2? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetPresentation? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetSignIn? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetConnectorConfiguration? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetConnectorConfigurationVariant2? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfiguration? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfigurationDiscriminator? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfigurationDiscriminatorType? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorWebhookStatus? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentConnector? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentConnectorType? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentConnectorsResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentConnector>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestBase? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationBase? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateSlackConnectorConfiguration? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateSlackConnectorConfigurationVariant2? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGchatConnectorConfiguration? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGchatConnectorConfigurationVariant2? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateZoomConnectorConfiguration? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateZoomConnectorConfigurationVariant2? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateWidgetConnectorConfiguration? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateWidgetConnectorConfigurationVariant2? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfiguration? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationDiscriminator? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationDiscriminatorType? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequest? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestVariant2? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestVariant2Type? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWidgetConnectorConfiguration? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConnectorConfiguration? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConnectorConfigurationDiscriminator? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConnectorConfigurationDiscriminatorType? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentConnectorRequest? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PublicSignIn? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PublicConnector? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateVisitorResponse? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentInterface? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentProvider? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentExtension? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentCapabilities? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentExtension>? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03ApiKeySecurityScheme? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03HttpAuthSecurityScheme? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AuthorizationCodeOAuthFlow? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03ClientCredentialsOAuthFlow? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03ImplicitOAuthFlow? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03PasswordOAuthFlow? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03OAuthFlows? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03OAuth2SecurityScheme? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03OpenIdConnectSecurityScheme? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03MutualTlsSecurityScheme? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SecurityScheme? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentSkill? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentCardSignature? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AgentCard? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentInterface>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.A2aV03SecurityScheme>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentSkill>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentCardSignature>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Role? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03FilePart? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03DataPart? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Part? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Message? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03Part>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03AuthenticationInfo? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03PushNotificationConfig? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SendMessageConfiguration? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SendMessageRequest? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskState? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskStatus? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Artifact? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03Task? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03Artifact>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03Message>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03SendMessageResponse? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskStatusUpdateEvent? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03TaskArtifactUpdateEvent? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV03StreamResponse? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentInterface? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentProvider? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentExtension? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentCapabilities? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentExtension>? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentSkill? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentCardSignature? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AgentCard? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentInterface>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentSkill>? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentCardSignature>? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Role? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Part? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Message? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Part>? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1AuthenticationInfo? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskPushNotificationConfig? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1SendMessageConfiguration? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1SendMessageRequest? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskState? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskStatus? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Artifact? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1Task? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Artifact>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Message>? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1SendMessageResponse? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskStatusUpdateEvent? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1TaskArtifactUpdateEvent? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1StreamResponse? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.A2aV1ListTasksResponse? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Task>? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SingleRuleTargets? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WeightedTarget? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WeightedRuleTargets? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.WeightedTarget>? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RuleTargets? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RuleTargetsDiscriminator? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RuleTargetsDiscriminatorType? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasRule? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RoutedAliasPolicy? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AliasRule>? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasPolicy? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasPolicyDiscriminator? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AliasPolicyDiscriminatorType? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentAlias? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentAliasesResponse? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentAlias>? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentAliasRequest? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateAgentAliasRequest? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceAliasPolicyRequest? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserSession? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserSessionStatus? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListEndUserSessionsResponse? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.EndUserSession>? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserSessionRequest? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEventBase? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserInputMessageEvent? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserInputMessageEventVariant2? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentOutputEvent? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentOutputEventVariant2? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserErrorEvent? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserErrorEventVariant2? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEvent? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEventDiscriminator? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserEventDiscriminatorType? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListEndUserEventsResponse? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.EndUserEvent>? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestBase? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputMessageRequest? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputMessageRequestVariant2? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInterruptRequest? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInterruptRequestVariant2? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserToolOutputRequest? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserToolOutputRequestVariant2? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequest? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestDiscriminator? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestDiscriminatorType? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserMultipartInputEvent? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentResponse? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentStreamedResponse? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentStreamedResponseDiscriminator? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentStreamedResponseDiscriminatorType? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TrustedTokenIssuer? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTrustedTokenIssuersResponse? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.TrustedTokenIssuer>? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateTrustedTokenIssuerRequest? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ReplaceTrustedTokenIssuerRequest? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineStatus? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AclAccessLevel? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AclMetadata? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SourceRecordMetadata? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseSharepointSourceConfiguration? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SharepointSourceConfiguration? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseS3SourceConfiguration? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.S3SourceConfiguration? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SharedGoogleDriveScope? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MyGoogleDriveScope? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveScope? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveScopeDiscriminator? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveScopeDiscriminatorType? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseGoogleDriveSourceConfiguration? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.GoogleDriveScope>? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveSourceConfiguration? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BoxCcgAuth? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseBoxSourceConfiguration? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BoxSourceConfiguration? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenArticleStatus? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfiguration? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfigurationKbApi? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.WolkenArticleStatus>? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenKbSourceConfiguration? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenFormsSourceConfiguration? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenFormsSourceConfiguration? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenTicketRequestType? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenTicketsSourceConfiguration? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.WolkenTicketRequestType>? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenTicketsSourceConfiguration? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceAttachmentsConfiguration? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceEmbeddedImagesConfiguration? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceEmbeddedImagesConfigurationHandling? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseConfluenceSourceConfiguration? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseConfluenceSourceConfigurationDeployment? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceSourceConfiguration? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FluidtopicsDocumentFetchMode? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseFluidtopicsSourceConfiguration? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseFluidtopicsSourceConfigurationContentScope? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.FluidtopicsDocumentFetchMode>? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FluidtopicsSourceConfiguration? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseScimSourceConfiguration? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseScimSourceConfigurationIncrementalStrategy? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScimSourceConfiguration? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseDoceboSourceConfiguration? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DoceboSourceConfiguration? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWebSource? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SitemapPagesSource? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseCrawlPagesSource? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CrawlPagesSource? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CrawlPagesSourceVariant2? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SitemapCrawlPagesSource? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SitemapCrawlPagesSourceVariant2? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebPagesSource? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebPagesSourceDiscriminator? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebPagesSourceDiscriminatorType? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSourceConfiguration? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSourceConfigurationVariant2? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSource? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSourceDiscriminator? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSourceDiscriminatorType? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CronTriggerConfiguration? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.IntervalTriggerConfiguration? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ManualTriggerConfiguration? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTrigger? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTriggerDiscriminator? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTriggerDiscriminatorType? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConditionVerification? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentVerification? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineVerification? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineVerificationDiscriminator? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineVerificationDiscriminatorType? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTransformConfiguration? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTransform? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTransformDiscriminator? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineTransformDiscriminatorType? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSyncMode? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineProcessingOptions? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineWatermark? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Pipeline? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelinesResponse? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Pipeline>? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreatePipelineRequest? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateSharepointSourceConfiguration? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateS3SourceConfiguration? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateGoogleDriveSourceConfiguration? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateBoxSourceConfiguration? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWolkenKbSourceConfiguration? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWolkenFormsSourceConfiguration? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWolkenTicketsSourceConfiguration? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConfluenceSourceConfiguration? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateFluidtopicsSourceConfiguration? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateScimSourceConfiguration? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateDoceboSourceConfiguration? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWebSourceConfiguration? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWebSourceConfigurationVariant2? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineSource? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineSourceDiscriminator? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineSourceDiscriminatorType? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdatePipelineRequest? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunStatus? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunTriggerType? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRun? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DeadLetterStatus? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DeadLetterOrigin? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineDeadLetterEntry? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelineDeadLetterEntriesResponse? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineDeadLetterEntry>? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreatePipelineDeadLetterEntryRequest? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ProcessPipelineDeadLetterEntriesRequest? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelineRunsResponse? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineRun>? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventType? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SortOrder? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventBase? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunStartedEvent? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunStartedEventVariant2? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunCompletedEventStatus? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunCompletedEvent? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RunCompletedEventVariant2? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordProcessingEventStatus? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordProcessingEvent? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.RecordProcessingEventVariant2? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WatermarkAdvancedEvent? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WatermarkAdvancedEventVariant2? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEvent? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventDiscriminator? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineRunEventDiscriminatorType? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelineRunEventsResponse? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineRunEvent>? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricOrigin? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptorBase? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricDescriptor? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricDescriptorVariant2? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricDescriptor? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricDescriptorVariant2? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentileEntry? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricDescriptor? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricDescriptorVariant2? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PercentileEntry>? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionBinDescriptor? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricDescriptor? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricDescriptorVariant2? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DistributionBinDescriptor>? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptor? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptorDiscriminator? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricDescriptorDiscriminatorType? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListMetricsResponse? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.MetricDescriptor>? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeriesBase? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScalarMetricPoint? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricSeries? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CounterMetricSeriesVariant2? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.ScalarMetricPoint>? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricSeries? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GaugeMetricSeriesVariant2? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricPoint? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricSeries? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PercentilesMetricSeriesVariant2? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PercentilesMetricPoint>? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.HistogramBin? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricPoint? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.HistogramBin>? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricSeries? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DistributionMetricSeriesVariant2? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.DistributionMetricPoint>? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeries? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeriesDiscriminator? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.MetricSeriesDiscriminatorType? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTrace? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceStatus? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentTracesResponse? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentTrace>? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanStatus? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanBase? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceInputFile? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentSpanAttributes? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentSpanAttributesOutputType? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentTraceInputFile>? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentSpanContent? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentTraceSpan? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.InvokeAgentTraceSpanVariant2? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatSpanAttributes? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatTraceSpan? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ChatTraceSpanVariant2? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolSpanAttributes? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolSpanContent? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolTraceSpan? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ExecuteToolTraceSpanVariant2? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingSpanContent? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingTraceSpan? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ThinkingTraceSpanVariant2? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputSpanContent? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputTraceSpan? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.OutputTraceSpanVariant2? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionSpanAttributes? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionTraceSpan? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepTransitionTraceSpanVariant2? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadSpanAttributes? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadTraceSpan? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ImageReadTraceSpanVariant2? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionSpanAttributes? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionTraceSpan? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CompactionTraceSpanVariant2? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpan? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanDiscriminator? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentTraceSpanDiscriminatorOperation? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentTraceSpansResponse? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.AgentTraceSpan>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.Glossary? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListGlossariesResponse? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.Glossary>? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGlossaryRequest? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateGlossaryRequest? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GlossaryEntry? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GlossaryEntriesResponse? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.GlossaryEntry>? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpsertGlossaryEntriesRequest? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DeleteGlossaryEntriesRequest? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetOAuthTokenRequest? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateCorpusDocumentWaitFor? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.JobState>? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolServersType? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListToolsType? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListInstructionsType? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListSessionArtifactsSortBy? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListSessionArtifactsOrderBy? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAgentConnectorsType? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAliasRoutedSessionArtifactsSortBy? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListAliasRoutedSessionArtifactsOrderBy? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListPipelinesSourceType? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vectara.PipelineRunEventType>? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesStatus? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesErrorType? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesOperation? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTracesToolErrorType? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ListTraceSpansOperation? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AllOf<global::Vectara.User, global::Vectara.CreateUserResponse2>? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateUserResponse2? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ResetUserPasswordResponse? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GetTokenResponse? Type1142 { get; set; }

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
        public global::System.Collections.Generic.List<global::Vectara.Usage>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Prompt>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Llm>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.DiscoveredLLM>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.JsonSchemaDefinition>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ChatCompletionRequestMessage>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ChatCompletionResponseChoice>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ChatCompletionStreamResponseChoice>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.GenerationPreset>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Encoder>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Reranker>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.TableExtractor>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.HallucinationCorrector>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.HcmSourceDocument>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.CorrectionItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Job>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ApiRole>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.CorpusRole>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentRole>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.User>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ApiKey>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AppClient>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ToolServer>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentKeyedSearchCorpus>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Tool>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Instruction>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.TemplatedReminderHook>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentStepInstruction>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentStepReminder>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.NextStep>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentStepToolCall>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.SessionEnrichmentToolCall>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Agent>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentSession>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentInput>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ArtifactReference>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ClientToolPendingCall>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentEvent>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.SessionArtifactReference>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.CreateToolOutputRequest>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.SessionArtifact>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentSchedule>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentScheduleExecution>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentOutputType>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentConnector>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03AgentExtension>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03AgentInterface>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03AgentSkill>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03AgentCardSignature>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03Part>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03Artifact>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV03Message>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1AgentExtension>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1AgentInterface>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1AgentSkill>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1AgentCardSignature>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1Part>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1Artifact>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1Message>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.A2aV1Task>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.WeightedTarget>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AliasRule>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentAlias>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.EndUserSession>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.EndUserEvent>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.TrustedTokenIssuer>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.GoogleDriveScope>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.WolkenArticleStatus>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.WolkenTicketRequestType>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Pipeline>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PipelineDeadLetterEntry>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PipelineRun>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PipelineRunEvent>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PercentileEntry>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.DistributionBinDescriptor>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.MetricDescriptor>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.ScalarMetricPoint>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PercentilesMetricPoint>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.HistogramBin>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.DistributionMetricPoint>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentTrace>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentTraceInputFile>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.AgentTraceSpan>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.Glossary>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.GlossaryEntry>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.JobState>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vectara.PipelineRunEventType>? ListType118 { get; set; }
    }
}