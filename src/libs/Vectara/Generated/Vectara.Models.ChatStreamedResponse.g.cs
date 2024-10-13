using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An individual event when the response is streamed.
    /// </summary>
    public readonly partial struct ChatStreamedResponse : global::System.IEquatable<ChatStreamedResponse>
    {
        /// <summary>
        /// The search response results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamSearchResponse? StreamSearch { get; init; }
#else
        public global::Vectara.StreamSearchResponse? StreamSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamSearch))]
#endif
        public bool IsStreamSearch => StreamSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatStreamedResponse(global::Vectara.StreamSearchResponse value) => new ChatStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamSearchResponse?(ChatStreamedResponse @this) => @this.StreamSearch;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamedResponse(global::Vectara.StreamSearchResponse? value)
        {
            StreamSearch = value;
        }

        /// <summary>
        /// Information about the chat.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ChatInfoResponse? Info { get; init; }
#else
        public global::Vectara.ChatInfoResponse? Info { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Info))]
#endif
        public bool IsInfo => Info != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatStreamedResponse(global::Vectara.ChatInfoResponse value) => new ChatStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ChatInfoResponse?(ChatStreamedResponse @this) => @this.Info;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamedResponse(global::Vectara.ChatInfoResponse? value)
        {
            Info = value;
        }

        /// <summary>
        /// The chunk response from the generation, which may be a partial generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamGenerationChunk? StreamGenerationChunk { get; init; }
#else
        public global::Vectara.StreamGenerationChunk? StreamGenerationChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamGenerationChunk))]
#endif
        public bool IsStreamGenerationChunk => StreamGenerationChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatStreamedResponse(global::Vectara.StreamGenerationChunk value) => new ChatStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamGenerationChunk?(ChatStreamedResponse @this) => @this.StreamGenerationChunk;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamedResponse(global::Vectara.StreamGenerationChunk? value)
        {
            StreamGenerationChunk = value;
        }

        /// <summary>
        /// The end of generation. There may still be more information such as the<br/>
        /// factual consistency score, but generation has stopped.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamGenerationEnd? StreamGenerationEnd { get; init; }
#else
        public global::Vectara.StreamGenerationEnd? StreamGenerationEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamGenerationEnd))]
#endif
        public bool IsStreamGenerationEnd => StreamGenerationEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatStreamedResponse(global::Vectara.StreamGenerationEnd value) => new ChatStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamGenerationEnd?(ChatStreamedResponse @this) => @this.StreamGenerationEnd;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamedResponse(global::Vectara.StreamGenerationEnd? value)
        {
            StreamGenerationEnd = value;
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
        public static implicit operator ChatStreamedResponse(global::Vectara.FactualConsistencyScore value) => new ChatStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.FactualConsistencyScore?(ChatStreamedResponse @this) => @this.FactualConsistencyScore;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamedResponse(global::Vectara.FactualConsistencyScore? value)
        {
            FactualConsistencyScore = value;
        }

        /// <summary>
        /// The end of a query response stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamResponseEnd? StreamEnd { get; init; }
#else
        public global::Vectara.StreamResponseEnd? StreamEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEnd))]
#endif
        public bool IsStreamEnd => StreamEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatStreamedResponse(global::Vectara.StreamResponseEnd value) => new ChatStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamResponseEnd?(ChatStreamedResponse @this) => @this.StreamEnd;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamedResponse(global::Vectara.StreamResponseEnd? value)
        {
            StreamEnd = value;
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
        public static implicit operator ChatStreamedResponse(global::Vectara.GenerationInfo value) => new ChatStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GenerationInfo?(ChatStreamedResponse @this) => @this.GenerationInfo;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamedResponse(global::Vectara.GenerationInfo? value)
        {
            GenerationInfo = value;
        }

        /// <summary>
        /// Event signaling there was an error with the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StreamError? StreamError { get; init; }
#else
        public global::Vectara.StreamError? StreamError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamError))]
#endif
        public bool IsStreamError => StreamError != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatStreamedResponse(global::Vectara.StreamError value) => new ChatStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamError?(ChatStreamedResponse @this) => @this.StreamError;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamedResponse(global::Vectara.StreamError? value)
        {
            StreamError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamedResponse(
            global::Vectara.StreamSearchResponse? streamSearch,
            global::Vectara.ChatInfoResponse? info,
            global::Vectara.StreamGenerationChunk? streamGenerationChunk,
            global::Vectara.StreamGenerationEnd? streamGenerationEnd,
            global::Vectara.FactualConsistencyScore? factualConsistencyScore,
            global::Vectara.StreamResponseEnd? streamEnd,
            global::Vectara.GenerationInfo? generationInfo,
            global::Vectara.StreamError? streamError
            )
        {
            StreamSearch = streamSearch;
            Info = info;
            StreamGenerationChunk = streamGenerationChunk;
            StreamGenerationEnd = streamGenerationEnd;
            FactualConsistencyScore = factualConsistencyScore;
            StreamEnd = streamEnd;
            GenerationInfo = generationInfo;
            StreamError = streamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamError as object ??
            GenerationInfo as object ??
            StreamEnd as object ??
            FactualConsistencyScore as object ??
            StreamGenerationEnd as object ??
            StreamGenerationChunk as object ??
            Info as object ??
            StreamSearch as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamSearch && !IsInfo && !IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsFactualConsistencyScore && !IsStreamEnd && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && IsInfo && !IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsFactualConsistencyScore && !IsStreamEnd && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsInfo && IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsFactualConsistencyScore && !IsStreamEnd && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsInfo && !IsStreamGenerationChunk && IsStreamGenerationEnd && !IsFactualConsistencyScore && !IsStreamEnd && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsInfo && !IsStreamGenerationChunk && !IsStreamGenerationEnd && IsFactualConsistencyScore && !IsStreamEnd && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsInfo && !IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsFactualConsistencyScore && IsStreamEnd && !IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsInfo && !IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsFactualConsistencyScore && !IsStreamEnd && IsGenerationInfo && !IsStreamError || !IsStreamSearch && !IsInfo && !IsStreamGenerationChunk && !IsStreamGenerationEnd && !IsFactualConsistencyScore && !IsStreamEnd && !IsGenerationInfo && IsStreamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.StreamSearchResponse?, TResult>? streamSearch = null,
            global::System.Func<global::Vectara.ChatInfoResponse?, TResult>? info = null,
            global::System.Func<global::Vectara.StreamGenerationChunk?, TResult>? streamGenerationChunk = null,
            global::System.Func<global::Vectara.StreamGenerationEnd?, TResult>? streamGenerationEnd = null,
            global::System.Func<global::Vectara.FactualConsistencyScore?, TResult>? factualConsistencyScore = null,
            global::System.Func<global::Vectara.StreamResponseEnd?, TResult>? streamEnd = null,
            global::System.Func<global::Vectara.GenerationInfo?, TResult>? generationInfo = null,
            global::System.Func<global::Vectara.StreamError?, TResult>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamSearch && streamSearch != null)
            {
                return streamSearch(StreamSearch!);
            }
            else if (IsInfo && info != null)
            {
                return info(Info!);
            }
            else if (IsStreamGenerationChunk && streamGenerationChunk != null)
            {
                return streamGenerationChunk(StreamGenerationChunk!);
            }
            else if (IsStreamGenerationEnd && streamGenerationEnd != null)
            {
                return streamGenerationEnd(StreamGenerationEnd!);
            }
            else if (IsFactualConsistencyScore && factualConsistencyScore != null)
            {
                return factualConsistencyScore(FactualConsistencyScore!);
            }
            else if (IsStreamEnd && streamEnd != null)
            {
                return streamEnd(StreamEnd!);
            }
            else if (IsGenerationInfo && generationInfo != null)
            {
                return generationInfo(GenerationInfo!);
            }
            else if (IsStreamError && streamError != null)
            {
                return streamError(StreamError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.StreamSearchResponse?>? streamSearch = null,
            global::System.Action<global::Vectara.ChatInfoResponse?>? info = null,
            global::System.Action<global::Vectara.StreamGenerationChunk?>? streamGenerationChunk = null,
            global::System.Action<global::Vectara.StreamGenerationEnd?>? streamGenerationEnd = null,
            global::System.Action<global::Vectara.FactualConsistencyScore?>? factualConsistencyScore = null,
            global::System.Action<global::Vectara.StreamResponseEnd?>? streamEnd = null,
            global::System.Action<global::Vectara.GenerationInfo?>? generationInfo = null,
            global::System.Action<global::Vectara.StreamError?>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamSearch)
            {
                streamSearch?.Invoke(StreamSearch!);
            }
            else if (IsInfo)
            {
                info?.Invoke(Info!);
            }
            else if (IsStreamGenerationChunk)
            {
                streamGenerationChunk?.Invoke(StreamGenerationChunk!);
            }
            else if (IsStreamGenerationEnd)
            {
                streamGenerationEnd?.Invoke(StreamGenerationEnd!);
            }
            else if (IsFactualConsistencyScore)
            {
                factualConsistencyScore?.Invoke(FactualConsistencyScore!);
            }
            else if (IsStreamEnd)
            {
                streamEnd?.Invoke(StreamEnd!);
            }
            else if (IsGenerationInfo)
            {
                generationInfo?.Invoke(GenerationInfo!);
            }
            else if (IsStreamError)
            {
                streamError?.Invoke(StreamError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamSearch,
                typeof(global::Vectara.StreamSearchResponse),
                Info,
                typeof(global::Vectara.ChatInfoResponse),
                StreamGenerationChunk,
                typeof(global::Vectara.StreamGenerationChunk),
                StreamGenerationEnd,
                typeof(global::Vectara.StreamGenerationEnd),
                FactualConsistencyScore,
                typeof(global::Vectara.FactualConsistencyScore),
                StreamEnd,
                typeof(global::Vectara.StreamResponseEnd),
                GenerationInfo,
                typeof(global::Vectara.GenerationInfo),
                StreamError,
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
        public bool Equals(ChatStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamSearchResponse?>.Default.Equals(StreamSearch, other.StreamSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ChatInfoResponse?>.Default.Equals(Info, other.Info) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamGenerationChunk?>.Default.Equals(StreamGenerationChunk, other.StreamGenerationChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamGenerationEnd?>.Default.Equals(StreamGenerationEnd, other.StreamGenerationEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.FactualConsistencyScore?>.Default.Equals(FactualConsistencyScore, other.FactualConsistencyScore) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamResponseEnd?>.Default.Equals(StreamEnd, other.StreamEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GenerationInfo?>.Default.Equals(GenerationInfo, other.GenerationInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamError?>.Default.Equals(StreamError, other.StreamError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatStreamedResponse obj1, ChatStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatStreamedResponse obj1, ChatStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatStreamedResponse o && Equals(o);
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
        public static global::Vectara.ChatStreamedResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Vectara.ChatStreamedResponse),
                jsonSerializerContext) as global::Vectara.ChatStreamedResponse?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Vectara.ChatStreamedResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Vectara.ChatStreamedResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}
