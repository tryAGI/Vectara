using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Rerank results of the search. Rerankers are very powerful tools to better order search results.<br/>
    /// By default the search will use the most powerful reranker available to the customer's plan.<br/>
    /// To disable reranking set the reranker `type` to `"none"`.
    /// </summary>
    public readonly partial struct SearchReranker : global::System.IEquatable<SearchReranker>
    {
        /// <summary>
        /// Reranker that is specific to the customer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CustomerSpecificReranker? CustomerSpecific { get; init; }
#else
        public global::Vectara.CustomerSpecificReranker? CustomerSpecific { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerSpecific))]
#endif
        public bool IsCustomerSpecific => CustomerSpecific != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::Vectara.CustomerSpecificReranker value) => new SearchReranker(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CustomerSpecificReranker?(SearchReranker @this) => @this.CustomerSpecific;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::Vectara.CustomerSpecificReranker? value)
        {
            CustomerSpecific = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UserFunctionReranker? UserFunction { get; init; }
#else
        public global::Vectara.UserFunctionReranker? UserFunction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserFunction))]
#endif
        public bool IsUserFunction => UserFunction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::Vectara.UserFunctionReranker value) => new SearchReranker(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UserFunctionReranker?(SearchReranker @this) => @this.UserFunction;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::Vectara.UserFunctionReranker? value)
        {
            UserFunction = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.MMRReranker? MR { get; init; }
#else
        public global::Vectara.MMRReranker? MR { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MR))]
#endif
        public bool IsMR => MR != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::Vectara.MMRReranker value) => new SearchReranker(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MMRReranker?(SearchReranker @this) => @this.MR;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::Vectara.MMRReranker? value)
        {
            MR = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ChainReranker? Chain { get; init; }
#else
        public global::Vectara.ChainReranker? Chain { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chain))]
#endif
        public bool IsChain => Chain != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::Vectara.ChainReranker value) => new SearchReranker(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ChainReranker?(SearchReranker @this) => @this.Chain;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::Vectara.ChainReranker? value)
        {
            Chain = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.NoneReranker? None { get; init; }
#else
        public global::Vectara.NoneReranker? None { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(None))]
#endif
        public bool IsNone => None != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::Vectara.NoneReranker value) => new SearchReranker(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.NoneReranker?(SearchReranker @this) => @this.None;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::Vectara.NoneReranker? value)
        {
            None = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(
            global::Vectara.CustomerSpecificReranker? customerSpecific,
            global::Vectara.UserFunctionReranker? userFunction,
            global::Vectara.MMRReranker? mR,
            global::Vectara.ChainReranker? chain,
            global::Vectara.NoneReranker? none
            )
        {
            CustomerSpecific = customerSpecific;
            UserFunction = userFunction;
            MR = mR;
            Chain = chain;
            None = none;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            None as object ??
            Chain as object ??
            MR as object ??
            UserFunction as object ??
            CustomerSpecific as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomerSpecific && !IsUserFunction && !IsMR && !IsChain && !IsNone || !IsCustomerSpecific && IsUserFunction && !IsMR && !IsChain && !IsNone || !IsCustomerSpecific && !IsUserFunction && IsMR && !IsChain && !IsNone || !IsCustomerSpecific && !IsUserFunction && !IsMR && IsChain && !IsNone || !IsCustomerSpecific && !IsUserFunction && !IsMR && !IsChain && IsNone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CustomerSpecificReranker?, TResult>? customerSpecific = null,
            global::System.Func<global::Vectara.UserFunctionReranker?, TResult>? userFunction = null,
            global::System.Func<global::Vectara.MMRReranker?, TResult>? mR = null,
            global::System.Func<global::Vectara.ChainReranker?, TResult>? chain = null,
            global::System.Func<global::Vectara.NoneReranker?, TResult>? none = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerSpecific && customerSpecific != null)
            {
                return customerSpecific(CustomerSpecific!);
            }
            else if (IsUserFunction && userFunction != null)
            {
                return userFunction(UserFunction!);
            }
            else if (IsMR && mR != null)
            {
                return mR(MR!);
            }
            else if (IsChain && chain != null)
            {
                return chain(Chain!);
            }
            else if (IsNone && none != null)
            {
                return none(None!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CustomerSpecificReranker?>? customerSpecific = null,
            global::System.Action<global::Vectara.UserFunctionReranker?>? userFunction = null,
            global::System.Action<global::Vectara.MMRReranker?>? mR = null,
            global::System.Action<global::Vectara.ChainReranker?>? chain = null,
            global::System.Action<global::Vectara.NoneReranker?>? none = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerSpecific)
            {
                customerSpecific?.Invoke(CustomerSpecific!);
            }
            else if (IsUserFunction)
            {
                userFunction?.Invoke(UserFunction!);
            }
            else if (IsMR)
            {
                mR?.Invoke(MR!);
            }
            else if (IsChain)
            {
                chain?.Invoke(Chain!);
            }
            else if (IsNone)
            {
                none?.Invoke(None!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomerSpecific,
                typeof(global::Vectara.CustomerSpecificReranker),
                UserFunction,
                typeof(global::Vectara.UserFunctionReranker),
                MR,
                typeof(global::Vectara.MMRReranker),
                Chain,
                typeof(global::Vectara.ChainReranker),
                None,
                typeof(global::Vectara.NoneReranker),
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
        public bool Equals(SearchReranker other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CustomerSpecificReranker?>.Default.Equals(CustomerSpecific, other.CustomerSpecific) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UserFunctionReranker?>.Default.Equals(UserFunction, other.UserFunction) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MMRReranker?>.Default.Equals(MR, other.MR) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ChainReranker?>.Default.Equals(Chain, other.Chain) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.NoneReranker?>.Default.Equals(None, other.None) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchReranker obj1, SearchReranker obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchReranker>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchReranker obj1, SearchReranker obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchReranker o && Equals(o);
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
        public static global::Vectara.SearchReranker? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Vectara.SearchReranker),
                jsonSerializerContext) as global::Vectara.SearchReranker?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Vectara.SearchReranker? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Vectara.SearchReranker>(
                json,
                jsonSerializerOptions);
        }

    }
}
