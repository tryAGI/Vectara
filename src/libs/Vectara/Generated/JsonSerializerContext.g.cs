
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
            typeof(global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeJsonConverter),
            typeof(global::Vectara.JsonConverters.SearchRerankerDiscriminatorTypeNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.LanguageJsonConverter),
            typeof(global::Vectara.JsonConverters.LanguageNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.CitationParametersStyleJsonConverter),
            typeof(global::Vectara.JsonConverters.CitationParametersStyleNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.SearchSemanticsJsonConverter),
            typeof(global::Vectara.JsonConverters.SearchSemanticsNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.QueryWarningJsonConverter),
            typeof(global::Vectara.JsonConverters.QueryWarningNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.QueryStreamedResponseDiscriminatorTypeJsonConverter),
            typeof(global::Vectara.JsonConverters.QueryStreamedResponseDiscriminatorTypeNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.ChunkingStrategyDiscriminatorTypeJsonConverter),
            typeof(global::Vectara.JsonConverters.ChunkingStrategyDiscriminatorTypeNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.CreateDocumentRequestDiscriminatorTypeJsonConverter),
            typeof(global::Vectara.JsonConverters.CreateDocumentRequestDiscriminatorTypeNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.ChatStreamedResponseDiscriminatorTypeJsonConverter),
            typeof(global::Vectara.JsonConverters.ChatStreamedResponseDiscriminatorTypeNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.ApiKeyRoleJsonConverter),
            typeof(global::Vectara.JsonConverters.ApiKeyRoleNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.ApiRoleJsonConverter),
            typeof(global::Vectara.JsonConverters.ApiRoleNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.CreateAppClientRequestDiscriminatorTypeJsonConverter),
            typeof(global::Vectara.JsonConverters.CreateAppClientRequestDiscriminatorTypeNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.JobTypeJsonConverter),
            typeof(global::Vectara.JsonConverters.JobTypeNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.JobStateJsonConverter),
            typeof(global::Vectara.JsonConverters.JobStateNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.QueryHistorySpanDiscriminatorTypeJsonConverter),
            typeof(global::Vectara.JsonConverters.QueryHistorySpanDiscriminatorTypeNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.SearchRerankerJsonConverter),
            typeof(global::Vectara.JsonConverters.SearchCorporaParametersJsonConverter),
            typeof(global::Vectara.JsonConverters.KeyedSearchCorpusJsonConverter),
            typeof(global::Vectara.JsonConverters.QueryStreamedResponseJsonConverter),
            typeof(global::Vectara.JsonConverters.ChunkingStrategyJsonConverter),
            typeof(global::Vectara.JsonConverters.CreateDocumentRequestJsonConverter),
            typeof(global::Vectara.JsonConverters.ChatStreamedResponseJsonConverter),
            typeof(global::Vectara.JsonConverters.CreateAppClientRequestJsonConverter),
            typeof(global::Vectara.JsonConverters.QueryHistorySpanJsonConverter),
            typeof(global::Vectara.JsonConverters.AllOfJsonConverter<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>),
            typeof(global::Vectara.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}