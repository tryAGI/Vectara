
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
            typeof(global::Vectara.JsonConverters.LanguageJsonConverter),
            typeof(global::Vectara.JsonConverters.LanguageNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.CitationParametersStyleJsonConverter),
            typeof(global::Vectara.JsonConverters.CitationParametersStyleNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.SearchSemanticsJsonConverter),
            typeof(global::Vectara.JsonConverters.SearchSemanticsNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.ApiKeyRoleJsonConverter),
            typeof(global::Vectara.JsonConverters.ApiKeyRoleNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.ApiRoleJsonConverter),
            typeof(global::Vectara.JsonConverters.ApiRoleNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.JobTypeJsonConverter),
            typeof(global::Vectara.JsonConverters.JobTypeNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.JobStateJsonConverter),
            typeof(global::Vectara.JsonConverters.JobStateNullableJsonConverter),
            typeof(global::Vectara.JsonConverters.SearchRerankerJsonConverter),
            typeof(global::Vectara.JsonConverters.SearchCorporaParametersJsonConverter),
            typeof(global::Vectara.JsonConverters.KeyedSearchCorpusJsonConverter),
            typeof(global::Vectara.JsonConverters.AllOfJsonConverterFactory2),
            typeof(global::Vectara.JsonConverters.QueryStreamedResponseJsonConverter),
            typeof(global::Vectara.JsonConverters.CreateDocumentRequestJsonConverter),
            typeof(global::Vectara.JsonConverters.ChatStreamedResponseJsonConverter),
            typeof(global::Vectara.JsonConverters.CreateAppClientRequestJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vectara.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}