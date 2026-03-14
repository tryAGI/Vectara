#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a Large Language Model connection for generative capabilities.
    /// </summary>
    public readonly partial struct CreateLLMRequest : global::System.IEquatable<CreateLLMRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateLLMRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request to create an OpenAI-compatible Large Language Model connection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateOpenAILLMRequest? OpenaiCompatible { get; init; }
#else
        public global::Vectara.CreateOpenAILLMRequest? OpenaiCompatible { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiCompatible))]
#endif
        public bool IsOpenaiCompatible => OpenaiCompatible != null;

        /// <summary>
        /// Request to create an OpenAI Responses API Large Language Model connection for reasoning models like o1, o3.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateOpenAIResponsesLLMRequest? OpenaiResponses { get; init; }
#else
        public global::Vectara.CreateOpenAIResponsesLLMRequest? OpenaiResponses { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiResponses))]
#endif
        public bool IsOpenaiResponses => OpenaiResponses != null;

        /// <summary>
        /// Request to create a Vertex AI Large Language Model connection for Gemini models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateVertexAILLMRequest? VertexAi { get; init; }
#else
        public global::Vectara.CreateVertexAILLMRequest? VertexAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VertexAi))]
#endif
        public bool IsVertexAi => VertexAi != null;

        /// <summary>
        /// Request to create an Anthropic Large Language Model connection for Claude models (direct API, Bedrock, or Vertex).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateAnthropicLLMRequest? Anthropic { get; init; }
#else
        public global::Vectara.CreateAnthropicLLMRequest? Anthropic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anthropic))]
#endif
        public bool IsAnthropic => Anthropic != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateLLMRequest(global::Vectara.CreateOpenAILLMRequest value) => new CreateLLMRequest((global::Vectara.CreateOpenAILLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateOpenAILLMRequest?(CreateLLMRequest @this) => @this.OpenaiCompatible;

        /// <summary>
        /// 
        /// </summary>
        public CreateLLMRequest(global::Vectara.CreateOpenAILLMRequest? value)
        {
            OpenaiCompatible = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateLLMRequest(global::Vectara.CreateOpenAIResponsesLLMRequest value) => new CreateLLMRequest((global::Vectara.CreateOpenAIResponsesLLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateOpenAIResponsesLLMRequest?(CreateLLMRequest @this) => @this.OpenaiResponses;

        /// <summary>
        /// 
        /// </summary>
        public CreateLLMRequest(global::Vectara.CreateOpenAIResponsesLLMRequest? value)
        {
            OpenaiResponses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateLLMRequest(global::Vectara.CreateVertexAILLMRequest value) => new CreateLLMRequest((global::Vectara.CreateVertexAILLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateVertexAILLMRequest?(CreateLLMRequest @this) => @this.VertexAi;

        /// <summary>
        /// 
        /// </summary>
        public CreateLLMRequest(global::Vectara.CreateVertexAILLMRequest? value)
        {
            VertexAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateLLMRequest(global::Vectara.CreateAnthropicLLMRequest value) => new CreateLLMRequest((global::Vectara.CreateAnthropicLLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateAnthropicLLMRequest?(CreateLLMRequest @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public CreateLLMRequest(global::Vectara.CreateAnthropicLLMRequest? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateLLMRequest(
            global::Vectara.CreateLLMRequestDiscriminatorType? type,
            global::Vectara.CreateOpenAILLMRequest? openaiCompatible,
            global::Vectara.CreateOpenAIResponsesLLMRequest? openaiResponses,
            global::Vectara.CreateVertexAILLMRequest? vertexAi,
            global::Vectara.CreateAnthropicLLMRequest? anthropic
            )
        {
            Type = type;

            OpenaiCompatible = openaiCompatible;
            OpenaiResponses = openaiResponses;
            VertexAi = vertexAi;
            Anthropic = anthropic;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Anthropic as object ??
            VertexAi as object ??
            OpenaiResponses as object ??
            OpenaiCompatible as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenaiCompatible?.ToString() ??
            OpenaiResponses?.ToString() ??
            VertexAi?.ToString() ??
            Anthropic?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenaiCompatible && !IsOpenaiResponses && !IsVertexAi && !IsAnthropic || !IsOpenaiCompatible && IsOpenaiResponses && !IsVertexAi && !IsAnthropic || !IsOpenaiCompatible && !IsOpenaiResponses && IsVertexAi && !IsAnthropic || !IsOpenaiCompatible && !IsOpenaiResponses && !IsVertexAi && IsAnthropic;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateOpenAILLMRequest?, TResult>? openaiCompatible = null,
            global::System.Func<global::Vectara.CreateOpenAIResponsesLLMRequest?, TResult>? openaiResponses = null,
            global::System.Func<global::Vectara.CreateVertexAILLMRequest?, TResult>? vertexAi = null,
            global::System.Func<global::Vectara.CreateAnthropicLLMRequest?, TResult>? anthropic = null,
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
            else if (IsOpenaiResponses && openaiResponses != null)
            {
                return openaiResponses(OpenaiResponses!);
            }
            else if (IsVertexAi && vertexAi != null)
            {
                return vertexAi(VertexAi!);
            }
            else if (IsAnthropic && anthropic != null)
            {
                return anthropic(Anthropic!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateOpenAILLMRequest?>? openaiCompatible = null,
            global::System.Action<global::Vectara.CreateOpenAIResponsesLLMRequest?>? openaiResponses = null,
            global::System.Action<global::Vectara.CreateVertexAILLMRequest?>? vertexAi = null,
            global::System.Action<global::Vectara.CreateAnthropicLLMRequest?>? anthropic = null,
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
            else if (IsOpenaiResponses)
            {
                openaiResponses?.Invoke(OpenaiResponses!);
            }
            else if (IsVertexAi)
            {
                vertexAi?.Invoke(VertexAi!);
            }
            else if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
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
                typeof(global::Vectara.CreateOpenAILLMRequest),
                OpenaiResponses,
                typeof(global::Vectara.CreateOpenAIResponsesLLMRequest),
                VertexAi,
                typeof(global::Vectara.CreateVertexAILLMRequest),
                Anthropic,
                typeof(global::Vectara.CreateAnthropicLLMRequest),
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
        public bool Equals(CreateLLMRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateOpenAILLMRequest?>.Default.Equals(OpenaiCompatible, other.OpenaiCompatible) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateOpenAIResponsesLLMRequest?>.Default.Equals(OpenaiResponses, other.OpenaiResponses) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateVertexAILLMRequest?>.Default.Equals(VertexAi, other.VertexAi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateAnthropicLLMRequest?>.Default.Equals(Anthropic, other.Anthropic) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateLLMRequest obj1, CreateLLMRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateLLMRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateLLMRequest obj1, CreateLLMRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateLLMRequest o && Equals(o);
        }
    }
}
