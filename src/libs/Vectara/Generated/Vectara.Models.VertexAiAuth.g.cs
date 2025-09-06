#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Authentication configuration for Vertex AI
    /// </summary>
    public readonly partial struct VertexAiAuth : global::System.IEquatable<VertexAiAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.VertexAiAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// API key authentication for Vertex AI
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.VertexAiApiKeyAuth? ApiKey { get; init; }
#else
        public global::Vectara.VertexAiApiKeyAuth? ApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKey))]
#endif
        public bool IsApiKey => ApiKey != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VertexAiAuth(global::Vectara.VertexAiApiKeyAuth value) => new VertexAiAuth((global::Vectara.VertexAiApiKeyAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.VertexAiApiKeyAuth?(VertexAiAuth @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public VertexAiAuth(global::Vectara.VertexAiApiKeyAuth? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// Service account authentication for Vertex AI
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.VertexAiServiceAccountAuth? ServiceAccount { get; init; }
#else
        public global::Vectara.VertexAiServiceAccountAuth? ServiceAccount { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServiceAccount))]
#endif
        public bool IsServiceAccount => ServiceAccount != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VertexAiAuth(global::Vectara.VertexAiServiceAccountAuth value) => new VertexAiAuth((global::Vectara.VertexAiServiceAccountAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.VertexAiServiceAccountAuth?(VertexAiAuth @this) => @this.ServiceAccount;

        /// <summary>
        /// 
        /// </summary>
        public VertexAiAuth(global::Vectara.VertexAiServiceAccountAuth? value)
        {
            ServiceAccount = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VertexAiAuth(
            global::Vectara.VertexAiAuthDiscriminatorType? type,
            global::Vectara.VertexAiApiKeyAuth? apiKey,
            global::Vectara.VertexAiServiceAccountAuth? serviceAccount
            )
        {
            Type = type;

            ApiKey = apiKey;
            ServiceAccount = serviceAccount;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ServiceAccount as object ??
            ApiKey as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApiKey?.ToString() ??
            ServiceAccount?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApiKey && !IsServiceAccount || !IsApiKey && IsServiceAccount;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.VertexAiApiKeyAuth?, TResult>? apiKey = null,
            global::System.Func<global::Vectara.VertexAiServiceAccountAuth?, TResult>? serviceAccount = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKey && apiKey != null)
            {
                return apiKey(ApiKey!);
            }
            else if (IsServiceAccount && serviceAccount != null)
            {
                return serviceAccount(ServiceAccount!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.VertexAiApiKeyAuth?>? apiKey = null,
            global::System.Action<global::Vectara.VertexAiServiceAccountAuth?>? serviceAccount = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKey)
            {
                apiKey?.Invoke(ApiKey!);
            }
            else if (IsServiceAccount)
            {
                serviceAccount?.Invoke(ServiceAccount!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApiKey,
                typeof(global::Vectara.VertexAiApiKeyAuth),
                ServiceAccount,
                typeof(global::Vectara.VertexAiServiceAccountAuth),
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
        public bool Equals(VertexAiAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.VertexAiApiKeyAuth?>.Default.Equals(ApiKey, other.ApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.VertexAiServiceAccountAuth?>.Default.Equals(ServiceAccount, other.ServiceAccount) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VertexAiAuth obj1, VertexAiAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VertexAiAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VertexAiAuth obj1, VertexAiAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VertexAiAuth o && Equals(o);
        }
    }
}
