#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create an OpenAI-compatible Large Language Model connection.
    /// </summary>
    public readonly partial struct CreateOpenAILLMRequest : global::System.IEquatable<CreateOpenAILLMRequest>
    {
        /// <summary>
        /// Common fields for OpenAI-compatible and Responses API LLM requests.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.OpenAILLMRequestBase? Base { get; init; }
#else
        public global::Vectara.OpenAILLMRequestBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateOpenAILLMRequestVariant2? CreateOpenAILLMRequestVariant2 { get; init; }
#else
        public global::Vectara.CreateOpenAILLMRequestVariant2? CreateOpenAILLMRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateOpenAILLMRequestVariant2))]
#endif
        public bool IsCreateOpenAILLMRequestVariant2 => CreateOpenAILLMRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateOpenAILLMRequest(global::Vectara.OpenAILLMRequestBase value) => new CreateOpenAILLMRequest((global::Vectara.OpenAILLMRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.OpenAILLMRequestBase?(CreateOpenAILLMRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateOpenAILLMRequest(global::Vectara.OpenAILLMRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateOpenAILLMRequest(global::Vectara.CreateOpenAILLMRequestVariant2 value) => new CreateOpenAILLMRequest((global::Vectara.CreateOpenAILLMRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateOpenAILLMRequestVariant2?(CreateOpenAILLMRequest @this) => @this.CreateOpenAILLMRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateOpenAILLMRequest(global::Vectara.CreateOpenAILLMRequestVariant2? value)
        {
            CreateOpenAILLMRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateOpenAILLMRequest(
            global::Vectara.OpenAILLMRequestBase? @base,
            global::Vectara.CreateOpenAILLMRequestVariant2? createOpenAILLMRequestVariant2
            )
        {
            Base = @base;
            CreateOpenAILLMRequestVariant2 = createOpenAILLMRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateOpenAILLMRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateOpenAILLMRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateOpenAILLMRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.OpenAILLMRequestBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateOpenAILLMRequestVariant2?, TResult>? createOpenAILLMRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsCreateOpenAILLMRequestVariant2 && createOpenAILLMRequestVariant2 != null)
            {
                return createOpenAILLMRequestVariant2(CreateOpenAILLMRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.OpenAILLMRequestBase?>? @base = null,
            global::System.Action<global::Vectara.CreateOpenAILLMRequestVariant2?>? createOpenAILLMRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsCreateOpenAILLMRequestVariant2)
            {
                createOpenAILLMRequestVariant2?.Invoke(CreateOpenAILLMRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Vectara.OpenAILLMRequestBase),
                CreateOpenAILLMRequestVariant2,
                typeof(global::Vectara.CreateOpenAILLMRequestVariant2),
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
        public bool Equals(CreateOpenAILLMRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.OpenAILLMRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateOpenAILLMRequestVariant2?>.Default.Equals(CreateOpenAILLMRequestVariant2, other.CreateOpenAILLMRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateOpenAILLMRequest obj1, CreateOpenAILLMRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateOpenAILLMRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateOpenAILLMRequest obj1, CreateOpenAILLMRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateOpenAILLMRequest o && Equals(o);
        }
    }
}
