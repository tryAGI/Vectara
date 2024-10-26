using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An individual event sent with Server-sent Events (SSE) when the query request is streamed.
    /// </summary>
    public readonly partial struct QueryStreamedResponse : global::System.IEquatable<QueryStreamedResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.QueryStreamedResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// The search response results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamSearchResponse? SearchResults { get; init; }
#else
        public global::Vectara.StreamSearchResponse? SearchResults { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResults))]
#endif
        public bool IsSearchResults => SearchResults != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::Vectara.StreamSearchResponse value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamSearchResponse?(QueryStreamedResponse @this) => @this.SearchResults;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::Vectara.StreamSearchResponse? value)
        {
            SearchResults = value;
        }

        /// <summary>
        /// The chunk response from the generation, which may be a partial generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamGenerationChunk? GenerationChunk { get; init; }
#else
        public global::Vectara.StreamGenerationChunk? GenerationChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationChunk))]
#endif
        public bool IsGenerationChunk => GenerationChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::Vectara.StreamGenerationChunk value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamGenerationChunk?(QueryStreamedResponse @this) => @this.GenerationChunk;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::Vectara.StreamGenerationChunk? value)
        {
            GenerationChunk = value;
        }

        /// <summary>
        /// The end of generation. There may still be more information such as the<br/>
        /// factual consistency score, but generation has stopped.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamGenerationEnd? GenerationEnd { get; init; }
#else
        public global::Vectara.StreamGenerationEnd? GenerationEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationEnd))]
#endif
        public bool IsGenerationEnd => GenerationEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::Vectara.StreamGenerationEnd value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamGenerationEnd?(QueryStreamedResponse @this) => @this.GenerationEnd;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::Vectara.StreamGenerationEnd? value)
        {
            GenerationEnd = value;
        }

        /// <summary>
        /// The end of a query response stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamResponseEnd? End { get; init; }
#else
        public global::Vectara.StreamResponseEnd? End { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(End))]
#endif
        public bool IsEnd => End != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::Vectara.StreamResponseEnd value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamResponseEnd?(QueryStreamedResponse @this) => @this.End;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::Vectara.StreamResponseEnd? value)
        {
            End = value;
        }

        /// <summary>
        /// Event containing the factual consistency score.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.FactualConsistencyScore? FactualConsistencyScore { get; init; }
#else
        public global::Vectara.FactualConsistencyScore? FactualConsistencyScore { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FactualConsistencyScore))]
#endif
        public bool IsFactualConsistencyScore => FactualConsistencyScore != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::Vectara.FactualConsistencyScore value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.FactualConsistencyScore?(QueryStreamedResponse @this) => @this.FactualConsistencyScore;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::Vectara.FactualConsistencyScore? value)
        {
            FactualConsistencyScore = value;
        }

        /// <summary>
        /// Event containing information on how the generation was accomplished.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GenerationInfo? GenerationInfo { get; init; }
#else
        public global::Vectara.GenerationInfo? GenerationInfo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationInfo))]
#endif
        public bool IsGenerationInfo => GenerationInfo != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::Vectara.GenerationInfo value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GenerationInfo?(QueryStreamedResponse @this) => @this.GenerationInfo;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::Vectara.GenerationInfo? value)
        {
            GenerationInfo = value;
        }

        /// <summary>
        /// Event signaling there was an error with the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamError? Error { get; init; }
#else
        public global::Vectara.StreamError? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryStreamedResponse(global::Vectara.StreamError value) => new QueryStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamError?(QueryStreamedResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(global::Vectara.StreamError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryStreamedResponse(
            global::Vectara.QueryStreamedResponseDiscriminatorType? type,
            global::Vectara.StreamSearchResponse? searchResults,
            global::Vectara.StreamGenerationChunk? generationChunk,
            global::Vectara.StreamGenerationEnd? generationEnd,
            global::Vectara.StreamResponseEnd? end,
            global::Vectara.FactualConsistencyScore? factualConsistencyScore,
            global::Vectara.GenerationInfo? generationInfo,
            global::Vectara.StreamError? error
            )
        {
            Type = type;

            SearchResults = searchResults;
            GenerationChunk = generationChunk;
            GenerationEnd = generationEnd;
            End = end;
            FactualConsistencyScore = factualConsistencyScore;
            GenerationInfo = generationInfo;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            GenerationInfo as object ??
            FactualConsistencyScore as object ??
            End as object ??
            GenerationEnd as object ??
            GenerationChunk as object ??
            SearchResults as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchResults && !IsGenerationChunk && !IsGenerationEnd && !IsEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsError || !IsSearchResults && IsGenerationChunk && !IsGenerationEnd && !IsEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsError || !IsSearchResults && !IsGenerationChunk && IsGenerationEnd && !IsEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsError || !IsSearchResults && !IsGenerationChunk && !IsGenerationEnd && IsEnd && !IsFactualConsistencyScore && !IsGenerationInfo && !IsError || !IsSearchResults && !IsGenerationChunk && !IsGenerationEnd && !IsEnd && IsFactualConsistencyScore && !IsGenerationInfo && !IsError || !IsSearchResults && !IsGenerationChunk && !IsGenerationEnd && !IsEnd && !IsFactualConsistencyScore && IsGenerationInfo && !IsError || !IsSearchResults && !IsGenerationChunk && !IsGenerationEnd && !IsEnd && !IsFactualConsistencyScore && !IsGenerationInfo && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.StreamSearchResponse?, TResult>? searchResults = null,
            global::System.Func<global::Vectara.StreamGenerationChunk?, TResult>? generationChunk = null,
            global::System.Func<global::Vectara.StreamGenerationEnd?, TResult>? generationEnd = null,
            global::System.Func<global::Vectara.StreamResponseEnd?, TResult>? end = null,
            global::System.Func<global::Vectara.FactualConsistencyScore?, TResult>? factualConsistencyScore = null,
            global::System.Func<global::Vectara.GenerationInfo?, TResult>? generationInfo = null,
            global::System.Func<global::Vectara.StreamError?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchResults && searchResults != null)
            {
                return searchResults(SearchResults!);
            }
            else if (IsGenerationChunk && generationChunk != null)
            {
                return generationChunk(GenerationChunk!);
            }
            else if (IsGenerationEnd && generationEnd != null)
            {
                return generationEnd(GenerationEnd!);
            }
            else if (IsEnd && end != null)
            {
                return end(End!);
            }
            else if (IsFactualConsistencyScore && factualConsistencyScore != null)
            {
                return factualConsistencyScore(FactualConsistencyScore!);
            }
            else if (IsGenerationInfo && generationInfo != null)
            {
                return generationInfo(GenerationInfo!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.StreamSearchResponse?>? searchResults = null,
            global::System.Action<global::Vectara.StreamGenerationChunk?>? generationChunk = null,
            global::System.Action<global::Vectara.StreamGenerationEnd?>? generationEnd = null,
            global::System.Action<global::Vectara.StreamResponseEnd?>? end = null,
            global::System.Action<global::Vectara.FactualConsistencyScore?>? factualConsistencyScore = null,
            global::System.Action<global::Vectara.GenerationInfo?>? generationInfo = null,
            global::System.Action<global::Vectara.StreamError?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchResults)
            {
                searchResults?.Invoke(SearchResults!);
            }
            else if (IsGenerationChunk)
            {
                generationChunk?.Invoke(GenerationChunk!);
            }
            else if (IsGenerationEnd)
            {
                generationEnd?.Invoke(GenerationEnd!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
            }
            else if (IsFactualConsistencyScore)
            {
                factualConsistencyScore?.Invoke(FactualConsistencyScore!);
            }
            else if (IsGenerationInfo)
            {
                generationInfo?.Invoke(GenerationInfo!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchResults,
                typeof(global::Vectara.StreamSearchResponse),
                GenerationChunk,
                typeof(global::Vectara.StreamGenerationChunk),
                GenerationEnd,
                typeof(global::Vectara.StreamGenerationEnd),
                End,
                typeof(global::Vectara.StreamResponseEnd),
                FactualConsistencyScore,
                typeof(global::Vectara.FactualConsistencyScore),
                GenerationInfo,
                typeof(global::Vectara.GenerationInfo),
                Error,
                typeof(global::Vectara.StreamError),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(QueryStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamSearchResponse?>.Default.Equals(SearchResults, other.SearchResults) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamGenerationChunk?>.Default.Equals(GenerationChunk, other.GenerationChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamGenerationEnd?>.Default.Equals(GenerationEnd, other.GenerationEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamResponseEnd?>.Default.Equals(End, other.End) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.FactualConsistencyScore?>.Default.Equals(FactualConsistencyScore, other.FactualConsistencyScore) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GenerationInfo?>.Default.Equals(GenerationInfo, other.GenerationInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamError?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QueryStreamedResponse obj1, QueryStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QueryStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QueryStreamedResponse obj1, QueryStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QueryStreamedResponse o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Vectara.QueryStreamedResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Vectara.QueryStreamedResponse),
                jsonSerializerContext) as global::Vectara.QueryStreamedResponse?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Vectara.QueryStreamedResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Vectara.QueryStreamedResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}
