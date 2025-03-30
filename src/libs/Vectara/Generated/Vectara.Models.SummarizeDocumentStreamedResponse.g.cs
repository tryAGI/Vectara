#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An individual event sent with Server-sent Events (SSE) when the document summarization request is streamed.
    /// </summary>
    public readonly partial struct SummarizeDocumentStreamedResponse : global::System.IEquatable<SummarizeDocumentStreamedResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType? Type { get; }

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
        public static implicit operator SummarizeDocumentStreamedResponse(global::Vectara.StreamGenerationChunk value) => new SummarizeDocumentStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamGenerationChunk?(SummarizeDocumentStreamedResponse @this) => @this.GenerationChunk;

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(global::Vectara.StreamGenerationChunk? value)
        {
            GenerationChunk = value;
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
        public static implicit operator SummarizeDocumentStreamedResponse(global::Vectara.GenerationInfo value) => new SummarizeDocumentStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GenerationInfo?(SummarizeDocumentStreamedResponse @this) => @this.GenerationInfo;

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(global::Vectara.GenerationInfo? value)
        {
            GenerationInfo = value;
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
        public static implicit operator SummarizeDocumentStreamedResponse(global::Vectara.StreamGenerationEnd value) => new SummarizeDocumentStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamGenerationEnd?(SummarizeDocumentStreamedResponse @this) => @this.GenerationEnd;

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(global::Vectara.StreamGenerationEnd? value)
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
        public static implicit operator SummarizeDocumentStreamedResponse(global::Vectara.StreamResponseEnd value) => new SummarizeDocumentStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamResponseEnd?(SummarizeDocumentStreamedResponse @this) => @this.End;

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(global::Vectara.StreamResponseEnd? value)
        {
            End = value;
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
        public static implicit operator SummarizeDocumentStreamedResponse(global::Vectara.StreamError value) => new SummarizeDocumentStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StreamError?(SummarizeDocumentStreamedResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(global::Vectara.StreamError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SummarizeDocumentStreamedResponse(
            global::Vectara.SummarizeDocumentStreamedResponseDiscriminatorType? type,
            global::Vectara.StreamGenerationChunk? generationChunk,
            global::Vectara.GenerationInfo? generationInfo,
            global::Vectara.StreamGenerationEnd? generationEnd,
            global::Vectara.StreamResponseEnd? end,
            global::Vectara.StreamError? error
            )
        {
            Type = type;

            GenerationChunk = generationChunk;
            GenerationInfo = generationInfo;
            GenerationEnd = generationEnd;
            End = end;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            End as object ??
            GenerationEnd as object ??
            GenerationInfo as object ??
            GenerationChunk as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GenerationChunk?.ToString() ??
            GenerationInfo?.ToString() ??
            GenerationEnd?.ToString() ??
            End?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerationChunk && !IsGenerationInfo && !IsGenerationEnd && !IsEnd && !IsError || !IsGenerationChunk && IsGenerationInfo && !IsGenerationEnd && !IsEnd && !IsError || !IsGenerationChunk && !IsGenerationInfo && IsGenerationEnd && !IsEnd && !IsError || !IsGenerationChunk && !IsGenerationInfo && !IsGenerationEnd && IsEnd && !IsError || !IsGenerationChunk && !IsGenerationInfo && !IsGenerationEnd && !IsEnd && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.StreamGenerationChunk?, TResult>? generationChunk = null,
            global::System.Func<global::Vectara.GenerationInfo?, TResult>? generationInfo = null,
            global::System.Func<global::Vectara.StreamGenerationEnd?, TResult>? generationEnd = null,
            global::System.Func<global::Vectara.StreamResponseEnd?, TResult>? end = null,
            global::System.Func<global::Vectara.StreamError?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationChunk && generationChunk != null)
            {
                return generationChunk(GenerationChunk!);
            }
            else if (IsGenerationInfo && generationInfo != null)
            {
                return generationInfo(GenerationInfo!);
            }
            else if (IsGenerationEnd && generationEnd != null)
            {
                return generationEnd(GenerationEnd!);
            }
            else if (IsEnd && end != null)
            {
                return end(End!);
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
            global::System.Action<global::Vectara.StreamGenerationChunk?>? generationChunk = null,
            global::System.Action<global::Vectara.GenerationInfo?>? generationInfo = null,
            global::System.Action<global::Vectara.StreamGenerationEnd?>? generationEnd = null,
            global::System.Action<global::Vectara.StreamResponseEnd?>? end = null,
            global::System.Action<global::Vectara.StreamError?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationChunk)
            {
                generationChunk?.Invoke(GenerationChunk!);
            }
            else if (IsGenerationInfo)
            {
                generationInfo?.Invoke(GenerationInfo!);
            }
            else if (IsGenerationEnd)
            {
                generationEnd?.Invoke(GenerationEnd!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
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
                GenerationChunk,
                typeof(global::Vectara.StreamGenerationChunk),
                GenerationInfo,
                typeof(global::Vectara.GenerationInfo),
                GenerationEnd,
                typeof(global::Vectara.StreamGenerationEnd),
                End,
                typeof(global::Vectara.StreamResponseEnd),
                Error,
                typeof(global::Vectara.StreamError),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(SummarizeDocumentStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamGenerationChunk?>.Default.Equals(GenerationChunk, other.GenerationChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GenerationInfo?>.Default.Equals(GenerationInfo, other.GenerationInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamGenerationEnd?>.Default.Equals(GenerationEnd, other.GenerationEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamResponseEnd?>.Default.Equals(End, other.End) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StreamError?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SummarizeDocumentStreamedResponse obj1, SummarizeDocumentStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SummarizeDocumentStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SummarizeDocumentStreamedResponse obj1, SummarizeDocumentStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SummarizeDocumentStreamedResponse o && Equals(o);
        }
    }
}
