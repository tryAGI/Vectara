#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a new encoder
    /// </summary>
    public readonly partial struct CreateEncoderRequest : global::System.IEquatable<CreateEncoderRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateEncoderRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Configuration for an OpenAI-compatible encoder
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateOpenAIEncoderRequest? Openai { get; init; }
#else
        public global::Vectara.CreateOpenAIEncoderRequest? Openai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openai))]
#endif
        public bool IsOpenai => Openai != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEncoderRequest(global::Vectara.CreateOpenAIEncoderRequest value) => new CreateEncoderRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateOpenAIEncoderRequest?(CreateEncoderRequest @this) => @this.Openai;

        /// <summary>
        /// 
        /// </summary>
        public CreateEncoderRequest(global::Vectara.CreateOpenAIEncoderRequest? value)
        {
            Openai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateEncoderRequest(
            global::Vectara.CreateEncoderRequestDiscriminatorType? type,
            global::Vectara.CreateOpenAIEncoderRequest? openai
            )
        {
            Type = type;

            Openai = openai;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Openai as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenai;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateOpenAIEncoderRequest?, TResult>? openai = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenai && openai != null)
            {
                return openai(Openai!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateOpenAIEncoderRequest?>? openai = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenai)
            {
                openai?.Invoke(Openai!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Openai,
                typeof(global::Vectara.CreateOpenAIEncoderRequest),
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateOpenAIEncoderRequest?>.Default.Equals(Openai, other.Openai) 
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
