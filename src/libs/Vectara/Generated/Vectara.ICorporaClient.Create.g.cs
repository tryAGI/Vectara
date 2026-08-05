#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Create a corpus<br/>
        /// Creates a corpus to store and manage your documents. A corpus is a container for documents and their associated metadata. You can set the corpus key, name, description, encoder, and filter attributes.<br/>
        /// ## Corpus object<br/>
        /// The `key` property is required and uniquely identifies the corpus. The `name` property is optional and defaults to the value of `key`. The optional `description` property provides additional information about the corpus. You can choose a `key` that follows a naming convention of your choice. An identifiable key makes a corpus easier to manage and reference in your application.<br/>
        /// Use the `queries_are_answers` and `documents_are_questions` boolean properties to treat queries or documents in the corpus as questions or answers. These settings affect the semantics of the encoder at query time and indexing time.<br/>
        /// ## Add metadata as filter attributes<br/>
        /// Define metadata fields with the `filter_attributes` object when you create a corpus with this endpoint or the Vectara Console. The corpus then supports filtering on specific metadata attributes at the document level or the part level.<br/>
        /// Filter attributes attach metadata to your data at the document (`doc`) or `part` level. You can use this metadata later in filter expressions to narrow the scope of your queries. A filter attribute must specify a unique `name` (up to 64 characters long) and a `level` of `doc` or `part`. At indexing time, the platform extracts metadata with this name and makes it available to filter expressions. [Learn more](https://docs.vectara.com/docs/build/prepare-data/metadata-filters)<br/>
        /// ### Doc and part filter levels<br/>
        /// The `doc` attribute applies to the entire document. Use this for metadata that is consistent across the whole document, such as author, publication date, and document ID.<br/>
        /// The `part` attribute applies to specific sections or chunks within a document. Use this for metadata that varies within different parts of the document, such as sections, page numbers, and sentiment scores.<br/>
        /// If `indexed` is true, the platform builds an index on the extracted values. This index improves the performance of filter expressions that use the attribute.<br/>
        /// Filter attributes must specify a `type`. The platform validates the type when documents are indexed. The four supported types are:<br/>
        /// * `integer`: stores signed whole-number values up to eight bytes in length.<br/>
        /// * `real`: stores floating point values in [IEEE 754 8-byte format].<br/>
        /// * `text`: stores textual strings in [UTF-8 encoding].<br/>
        /// * `boolean`: stores true/false values.<br/>
        /// After you define filter attributes, you can use them within your queries. For example:<br/>
        /// * Document-level attribute: `doc.publication_year &gt; 2020`<br/>
        /// * Part-level attribute: `part.sentiment_score &gt; 0.7`<br/>
        /// ## Custom dimensions<br/>
        /// Custom dimensions add user-defined values to your data, in addition to what the platform automatically extracts and stores from the text. For example, *upvotes* can be a custom dimension. For an example, see [Add custom dimensions to boost content](/docs/tutorials/add-custom-dimensions).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Corpus> CreateAsync(

            global::Vectara.CreateCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a corpus<br/>
        /// Creates a corpus to store and manage your documents. A corpus is a container for documents and their associated metadata. You can set the corpus key, name, description, encoder, and filter attributes.<br/>
        /// ## Corpus object<br/>
        /// The `key` property is required and uniquely identifies the corpus. The `name` property is optional and defaults to the value of `key`. The optional `description` property provides additional information about the corpus. You can choose a `key` that follows a naming convention of your choice. An identifiable key makes a corpus easier to manage and reference in your application.<br/>
        /// Use the `queries_are_answers` and `documents_are_questions` boolean properties to treat queries or documents in the corpus as questions or answers. These settings affect the semantics of the encoder at query time and indexing time.<br/>
        /// ## Add metadata as filter attributes<br/>
        /// Define metadata fields with the `filter_attributes` object when you create a corpus with this endpoint or the Vectara Console. The corpus then supports filtering on specific metadata attributes at the document level or the part level.<br/>
        /// Filter attributes attach metadata to your data at the document (`doc`) or `part` level. You can use this metadata later in filter expressions to narrow the scope of your queries. A filter attribute must specify a unique `name` (up to 64 characters long) and a `level` of `doc` or `part`. At indexing time, the platform extracts metadata with this name and makes it available to filter expressions. [Learn more](https://docs.vectara.com/docs/build/prepare-data/metadata-filters)<br/>
        /// ### Doc and part filter levels<br/>
        /// The `doc` attribute applies to the entire document. Use this for metadata that is consistent across the whole document, such as author, publication date, and document ID.<br/>
        /// The `part` attribute applies to specific sections or chunks within a document. Use this for metadata that varies within different parts of the document, such as sections, page numbers, and sentiment scores.<br/>
        /// If `indexed` is true, the platform builds an index on the extracted values. This index improves the performance of filter expressions that use the attribute.<br/>
        /// Filter attributes must specify a `type`. The platform validates the type when documents are indexed. The four supported types are:<br/>
        /// * `integer`: stores signed whole-number values up to eight bytes in length.<br/>
        /// * `real`: stores floating point values in [IEEE 754 8-byte format].<br/>
        /// * `text`: stores textual strings in [UTF-8 encoding].<br/>
        /// * `boolean`: stores true/false values.<br/>
        /// After you define filter attributes, you can use them within your queries. For example:<br/>
        /// * Document-level attribute: `doc.publication_year &gt; 2020`<br/>
        /// * Part-level attribute: `part.sentiment_score &gt; 0.7`<br/>
        /// ## Custom dimensions<br/>
        /// Custom dimensions add user-defined values to your data, in addition to what the platform automatically extracts and stores from the text. For example, *upvotes* can be a custom dimension. For an example, see [Add custom dimensions to boost content](/docs/tutorials/add-custom-dimensions).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.Corpus>> CreateAsResponseAsync(

            global::Vectara.CreateCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a corpus<br/>
        /// Creates a corpus to store and manage your documents. A corpus is a container for documents and their associated metadata. You can set the corpus key, name, description, encoder, and filter attributes.<br/>
        /// ## Corpus object<br/>
        /// The `key` property is required and uniquely identifies the corpus. The `name` property is optional and defaults to the value of `key`. The optional `description` property provides additional information about the corpus. You can choose a `key` that follows a naming convention of your choice. An identifiable key makes a corpus easier to manage and reference in your application.<br/>
        /// Use the `queries_are_answers` and `documents_are_questions` boolean properties to treat queries or documents in the corpus as questions or answers. These settings affect the semantics of the encoder at query time and indexing time.<br/>
        /// ## Add metadata as filter attributes<br/>
        /// Define metadata fields with the `filter_attributes` object when you create a corpus with this endpoint or the Vectara Console. The corpus then supports filtering on specific metadata attributes at the document level or the part level.<br/>
        /// Filter attributes attach metadata to your data at the document (`doc`) or `part` level. You can use this metadata later in filter expressions to narrow the scope of your queries. A filter attribute must specify a unique `name` (up to 64 characters long) and a `level` of `doc` or `part`. At indexing time, the platform extracts metadata with this name and makes it available to filter expressions. [Learn more](https://docs.vectara.com/docs/build/prepare-data/metadata-filters)<br/>
        /// ### Doc and part filter levels<br/>
        /// The `doc` attribute applies to the entire document. Use this for metadata that is consistent across the whole document, such as author, publication date, and document ID.<br/>
        /// The `part` attribute applies to specific sections or chunks within a document. Use this for metadata that varies within different parts of the document, such as sections, page numbers, and sentiment scores.<br/>
        /// If `indexed` is true, the platform builds an index on the extracted values. This index improves the performance of filter expressions that use the attribute.<br/>
        /// Filter attributes must specify a `type`. The platform validates the type when documents are indexed. The four supported types are:<br/>
        /// * `integer`: stores signed whole-number values up to eight bytes in length.<br/>
        /// * `real`: stores floating point values in [IEEE 754 8-byte format].<br/>
        /// * `text`: stores textual strings in [UTF-8 encoding].<br/>
        /// * `boolean`: stores true/false values.<br/>
        /// After you define filter attributes, you can use them within your queries. For example:<br/>
        /// * Document-level attribute: `doc.publication_year &gt; 2020`<br/>
        /// * Part-level attribute: `part.sentiment_score &gt; 0.7`<br/>
        /// ## Custom dimensions<br/>
        /// Custom dimensions add user-defined values to your data, in addition to what the platform automatically extracts and stores from the text. For example, *upvotes* can be a custom dimension. For an example, see [Add custom dimensions to boost content](/docs/tutorials/add-custom-dimensions).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="key">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="name">
        /// The name for the corpus. This value defaults to the key.<br/>
        /// Example: My corpus
        /// </param>
        /// <param name="description">
        /// Description of the corpus.<br/>
        /// Example: Documents with important information for my prompt.
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save corpus queries to query history by default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="queriesAreAnswers">
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="documentsAreQuestions">
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encoderName">
        /// The encoder used by the corpus, `boomerang-2023-q3`.<br/>
        /// Example: boomerang-2023-q3
        /// </param>
        /// <param name="filterAttributes">
        /// The filter attributes of the corpus. If unset, the corpus does not have filter attributes.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="customDimensions">
        /// A custom dimension is an additional numerical field attached to a document part. You can then multiply this numerical field with a query time custom dimension of the same name. This allows boosting (or burying) document parts for arbitrary reasons. This feature is only enabled for Pro and Enterprise customers.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Corpus> CreateAsync(
            string key,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            bool? saveHistory = default,
            bool? queriesAreAnswers = default,
            bool? documentsAreQuestions = default,
            string? encoderName = default,
            global::System.Collections.Generic.IList<global::Vectara.FilterAttribute>? filterAttributes = default,
            global::System.Collections.Generic.IList<global::Vectara.CorpusCustomDimension>? customDimensions = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}