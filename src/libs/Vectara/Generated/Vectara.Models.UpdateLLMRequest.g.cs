#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to update a Large Language Model connection. All fields are optional - only provide fields you want to change. Only the name field is immutable.
    /// </summary>
    public readonly partial struct UpdateLLMRequest : global::System.IEquatable<UpdateLLMRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateLLMRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request to update an OpenAI-compatible Large Language Model connection. All fields are optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateOpenAILLMRequest? OpenaiCompatible { get; init; }
#else
        public global::Vectara.UpdateOpenAILLMRequest? OpenaiCompatible { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiCompatible))]
#endif
        public bool IsOpenaiCompatible => OpenaiCompatible != null;

        /// <summary>
        /// Request to update an OpenAI Responses API Large Language Model connection. All fields are optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateOpenAIResponsesLLMRequest? OpenaiResponses { get; init; }
#else
        public global::Vectara.UpdateOpenAIResponsesLLMRequest? OpenaiResponses { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiResponses))]
#endif
        public bool IsOpenaiResponses => OpenaiResponses != null;

        /// <summary>
        /// Request to update a Vertex AI Large Language Model connection. All fields are optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateVertexAILLMRequest? VertexAi { get; init; }
#else
        public global::Vectara.UpdateVertexAILLMRequest? VertexAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VertexAi))]
#endif
        public bool IsVertexAi => VertexAi != null;

        /// <summary>
        /// Request to update an Anthropic Large Language Model connection. All fields are optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateAnthropicLLMRequest? Anthropic { get; init; }
#else
        public global::Vectara.UpdateAnthropicLLMRequest? Anthropic { get; }
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
        public static implicit operator UpdateLLMRequest(global::Vectara.UpdateOpenAILLMRequest value) => new UpdateLLMRequest((global::Vectara.UpdateOpenAILLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateOpenAILLMRequest?(UpdateLLMRequest @this) => @this.OpenaiCompatible;

        /// <summary>
        /// 
        /// </summary>
        public UpdateLLMRequest(global::Vectara.UpdateOpenAILLMRequest? value)
        {
            OpenaiCompatible = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateLLMRequest(global::Vectara.UpdateOpenAIResponsesLLMRequest value) => new UpdateLLMRequest((global::Vectara.UpdateOpenAIResponsesLLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateOpenAIResponsesLLMRequest?(UpdateLLMRequest @this) => @this.OpenaiResponses;

        /// <summary>
        /// 
        /// </summary>
        public UpdateLLMRequest(global::Vectara.UpdateOpenAIResponsesLLMRequest? value)
        {
            OpenaiResponses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateLLMRequest(global::Vectara.UpdateVertexAILLMRequest value) => new UpdateLLMRequest((global::Vectara.UpdateVertexAILLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateVertexAILLMRequest?(UpdateLLMRequest @this) => @this.VertexAi;

        /// <summary>
        /// 
        /// </summary>
        public UpdateLLMRequest(global::Vectara.UpdateVertexAILLMRequest? value)
        {
            VertexAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateLLMRequest(global::Vectara.UpdateAnthropicLLMRequest value) => new UpdateLLMRequest((global::Vectara.UpdateAnthropicLLMRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateAnthropicLLMRequest?(UpdateLLMRequest @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public UpdateLLMRequest(global::Vectara.UpdateAnthropicLLMRequest? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateLLMRequest(
            global::Vectara.UpdateLLMRequestDiscriminatorType? type,
            global::Vectara.UpdateOpenAILLMRequest? openaiCompatible,
            global::Vectara.UpdateOpenAIResponsesLLMRequest? openaiResponses,
            global::Vectara.UpdateVertexAILLMRequest? vertexAi,
            global::Vectara.UpdateAnthropicLLMRequest? anthropic
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
            global::System.Func<global::Vectara.UpdateOpenAILLMRequest?, TResult>? openaiCompatible = null,
            global::System.Func<global::Vectara.UpdateOpenAIResponsesLLMRequest?, TResult>? openaiResponses = null,
            global::System.Func<global::Vectara.UpdateVertexAILLMRequest?, TResult>? vertexAi = null,
            global::System.Func<global::Vectara.UpdateAnthropicLLMRequest?, TResult>? anthropic = null,
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
            global::System.Action<global::Vectara.UpdateOpenAILLMRequest?>? openaiCompatible = null,
            global::System.Action<global::Vectara.UpdateOpenAIResponsesLLMRequest?>? openaiResponses = null,
            global::System.Action<global::Vectara.UpdateVertexAILLMRequest?>? vertexAi = null,
            global::System.Action<global::Vectara.UpdateAnthropicLLMRequest?>? anthropic = null,
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
                typeof(global::Vectara.UpdateOpenAILLMRequest),
                OpenaiResponses,
                typeof(global::Vectara.UpdateOpenAIResponsesLLMRequest),
                VertexAi,
                typeof(global::Vectara.UpdateVertexAILLMRequest),
                Anthropic,
                typeof(global::Vectara.UpdateAnthropicLLMRequest),
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
        public bool Equals(UpdateLLMRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateOpenAILLMRequest?>.Default.Equals(OpenaiCompatible, other.OpenaiCompatible) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateOpenAIResponsesLLMRequest?>.Default.Equals(OpenaiResponses, other.OpenaiResponses) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateVertexAILLMRequest?>.Default.Equals(VertexAi, other.VertexAi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateAnthropicLLMRequest?>.Default.Equals(Anthropic, other.Anthropic) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateLLMRequest obj1, UpdateLLMRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateLLMRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateLLMRequest obj1, UpdateLLMRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateLLMRequest o && Equals(o);
        }
    }
}
