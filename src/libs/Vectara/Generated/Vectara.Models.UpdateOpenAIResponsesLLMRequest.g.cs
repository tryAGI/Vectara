#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to update an OpenAI Responses API Large Language Model connection. All fields are optional.
    /// </summary>
    public readonly partial struct UpdateOpenAIResponsesLLMRequest : global::System.IEquatable<UpdateOpenAIResponsesLLMRequest>
    {
        /// <summary>
        /// Common updatable fields for OpenAI-compatible and Responses API LLM requests.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.OpenAILLMUpdateBase? Value1 { get; init; }
#else
        public global::Vectara.OpenAILLMUpdateBase? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2? Value2 { get; init; }
#else
        public global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOpenAIResponsesLLMRequest(global::Vectara.OpenAILLMUpdateBase value) => new UpdateOpenAIResponsesLLMRequest((global::Vectara.OpenAILLMUpdateBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.OpenAILLMUpdateBase?(UpdateOpenAIResponsesLLMRequest @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOpenAIResponsesLLMRequest(global::Vectara.OpenAILLMUpdateBase? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOpenAIResponsesLLMRequest(global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2 value) => new UpdateOpenAIResponsesLLMRequest((global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2?(UpdateOpenAIResponsesLLMRequest @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOpenAIResponsesLLMRequest(global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateOpenAIResponsesLLMRequest(
            global::Vectara.OpenAILLMUpdateBase? value1,
            global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.OpenAILLMUpdateBase?, TResult>? value1 = null,
            global::System.Func<global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.OpenAILLMUpdateBase?>? value1 = null,
            global::System.Action<global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Vectara.OpenAILLMUpdateBase),
                Value2,
                typeof(global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2),
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
        public bool Equals(UpdateOpenAIResponsesLLMRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.OpenAILLMUpdateBase?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateOpenAIResponsesLLMRequestVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateOpenAIResponsesLLMRequest obj1, UpdateOpenAIResponsesLLMRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateOpenAIResponsesLLMRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateOpenAIResponsesLLMRequest obj1, UpdateOpenAIResponsesLLMRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateOpenAIResponsesLLMRequest o && Equals(o);
        }
    }
}
