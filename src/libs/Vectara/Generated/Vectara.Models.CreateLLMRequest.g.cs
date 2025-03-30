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
        /// 
        /// </summary>
        public static implicit operator CreateLLMRequest(global::Vectara.CreateOpenAILLMRequest value) => new CreateLLMRequest(value);

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
        public CreateLLMRequest(
            global::Vectara.CreateLLMRequestDiscriminatorType? type,
            global::Vectara.CreateOpenAILLMRequest? openaiCompatible
            )
        {
            Type = type;

            OpenaiCompatible = openaiCompatible;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenaiCompatible as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenaiCompatible?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenaiCompatible;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateOpenAILLMRequest?, TResult>? openaiCompatible = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateOpenAILLMRequest?>? openaiCompatible = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateOpenAILLMRequest?>.Default.Equals(OpenaiCompatible, other.OpenaiCompatible) 
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
