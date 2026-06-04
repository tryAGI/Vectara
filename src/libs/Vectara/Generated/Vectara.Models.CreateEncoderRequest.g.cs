#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a new encoder. Use `openai-compatible` for text-only endpoints that implement OpenAI's `/v1/embeddings`. Use `vllm-compatible` for endpoints that additionally support image embeddings.
    /// </summary>
    public readonly partial struct CreateEncoderRequest : global::System.IEquatable<CreateEncoderRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateEncoderRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Configuration for a text-only encoder served by an endpoint that implements OpenAI's `/v1/embeddings` request shape.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateOpenAIEncoderRequest? OpenaiCompatible { get; init; }
#else
        public global::Vectara.CreateOpenAIEncoderRequest? OpenaiCompatible { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiCompatible))]
#endif
        public bool IsOpenaiCompatible => OpenaiCompatible != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenaiCompatible(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateOpenAIEncoderRequest? value)
        {
            value = OpenaiCompatible;
            return IsOpenaiCompatible;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateOpenAIEncoderRequest PickOpenaiCompatible() => IsOpenaiCompatible
            ? OpenaiCompatible!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenaiCompatible' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for a vLLM-served embedding encoder. The endpoint must accept text-embedding requests and, when `image_encoding` is true, image-embedding requests.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateVLlmEncoderRequest? VllmCompatible { get; init; }
#else
        public global::Vectara.CreateVLlmEncoderRequest? VllmCompatible { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VllmCompatible))]
#endif
        public bool IsVllmCompatible => VllmCompatible != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVllmCompatible(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateVLlmEncoderRequest? value)
        {
            value = VllmCompatible;
            return IsVllmCompatible;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateVLlmEncoderRequest PickVllmCompatible() => IsVllmCompatible
            ? VllmCompatible!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VllmCompatible' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEncoderRequest(global::Vectara.CreateOpenAIEncoderRequest value) => new CreateEncoderRequest((global::Vectara.CreateOpenAIEncoderRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateOpenAIEncoderRequest?(CreateEncoderRequest @this) => @this.OpenaiCompatible;

        /// <summary>
        /// 
        /// </summary>
        public CreateEncoderRequest(global::Vectara.CreateOpenAIEncoderRequest? value)
        {
            OpenaiCompatible = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateEncoderRequest FromOpenaiCompatible(global::Vectara.CreateOpenAIEncoderRequest? value) => new CreateEncoderRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEncoderRequest(global::Vectara.CreateVLlmEncoderRequest value) => new CreateEncoderRequest((global::Vectara.CreateVLlmEncoderRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateVLlmEncoderRequest?(CreateEncoderRequest @this) => @this.VllmCompatible;

        /// <summary>
        /// 
        /// </summary>
        public CreateEncoderRequest(global::Vectara.CreateVLlmEncoderRequest? value)
        {
            VllmCompatible = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateEncoderRequest FromVllmCompatible(global::Vectara.CreateVLlmEncoderRequest? value) => new CreateEncoderRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateEncoderRequest(
            global::Vectara.CreateEncoderRequestDiscriminatorType? type,
            global::Vectara.CreateOpenAIEncoderRequest? openaiCompatible,
            global::Vectara.CreateVLlmEncoderRequest? vllmCompatible
            )
        {
            Type = type;

            OpenaiCompatible = openaiCompatible;
            VllmCompatible = vllmCompatible;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VllmCompatible as object ??
            OpenaiCompatible as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenaiCompatible?.ToString() ??
            VllmCompatible?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenaiCompatible && !IsVllmCompatible || !IsOpenaiCompatible && IsVllmCompatible;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateOpenAIEncoderRequest, TResult>? openaiCompatible = null,
            global::System.Func<global::Vectara.CreateVLlmEncoderRequest, TResult>? vllmCompatible = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenaiCompatible && openaiCompatible != null)
            {
                return openaiCompatible(OpenaiCompatible!);
            }
            else if (IsVllmCompatible && vllmCompatible != null)
            {
                return vllmCompatible(VllmCompatible!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateOpenAIEncoderRequest>? openaiCompatible = null,

            global::System.Action<global::Vectara.CreateVLlmEncoderRequest>? vllmCompatible = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenaiCompatible)
            {
                openaiCompatible?.Invoke(OpenaiCompatible!);
            }
            else if (IsVllmCompatible)
            {
                vllmCompatible?.Invoke(VllmCompatible!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateOpenAIEncoderRequest>? openaiCompatible = null,
            global::System.Action<global::Vectara.CreateVLlmEncoderRequest>? vllmCompatible = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenaiCompatible)
            {
                openaiCompatible?.Invoke(OpenaiCompatible!);
            }
            else if (IsVllmCompatible)
            {
                vllmCompatible?.Invoke(VllmCompatible!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenaiCompatible,
                typeof(global::Vectara.CreateOpenAIEncoderRequest),
                VllmCompatible,
                typeof(global::Vectara.CreateVLlmEncoderRequest),
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
        public bool Equals(CreateEncoderRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateOpenAIEncoderRequest?>.Default.Equals(OpenaiCompatible, other.OpenaiCompatible) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateVLlmEncoderRequest?>.Default.Equals(VllmCompatible, other.VllmCompatible) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateEncoderRequest obj1, CreateEncoderRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEncoderRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateEncoderRequest obj1, CreateEncoderRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEncoderRequest o && Equals(o);
        }
    }
}
