#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Authentication configuration for Anthropic LLM via direct Anthropic API (use RemoteAuth with header "x-api-key"), AWS Bedrock, or GCP Vertex AI Model Garden
    /// </summary>
    public readonly partial struct AnthropicAuth : global::System.IEquatable<AnthropicAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AnthropicAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// Bearer token authentication
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BearerAuth? Bearer { get; init; }
#else
        public global::Vectara.BearerAuth? Bearer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bearer))]
#endif
        public bool IsBearer => Bearer != null;

        /// <summary>
        /// Custom header-based authentication
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.HeaderAuth? Header { get; init; }
#else
        public global::Vectara.HeaderAuth? Header { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Header))]
#endif
        public bool IsHeader => Header != null;

        /// <summary>
        /// AWS Bedrock authentication with explicit IAM credentials
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BedrockStaticIAMAuth? BedrockStaticIam { get; init; }
#else
        public global::Vectara.BedrockStaticIAMAuth? BedrockStaticIam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BedrockStaticIam))]
#endif
        public bool IsBedrockStaticIam => BedrockStaticIam != null;

        /// <summary>
        /// AWS Bedrock API key authentication
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BedrockApiKeyAuth? BedrockApiKey { get; init; }
#else
        public global::Vectara.BedrockApiKeyAuth? BedrockApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BedrockApiKey))]
#endif
        public bool IsBedrockApiKey => BedrockApiKey != null;

        /// <summary>
        /// Google Cloud Vertex AI service account authentication
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.VertexServiceAccountAuth? VertexServiceAccount { get; init; }
#else
        public global::Vectara.VertexServiceAccountAuth? VertexServiceAccount { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VertexServiceAccount))]
#endif
        public bool IsVertexServiceAccount => VertexServiceAccount != null;

        /// <summary>
        /// Google Cloud Vertex AI access token authentication
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.VertexAccessTokenAuth? VertexAccessToken { get; init; }
#else
        public global::Vectara.VertexAccessTokenAuth? VertexAccessToken { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VertexAccessToken))]
#endif
        public bool IsVertexAccessToken => VertexAccessToken != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::Vectara.BearerAuth value) => new AnthropicAuth((global::Vectara.BearerAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BearerAuth?(AnthropicAuth @this) => @this.Bearer;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::Vectara.BearerAuth? value)
        {
            Bearer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::Vectara.HeaderAuth value) => new AnthropicAuth((global::Vectara.HeaderAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.HeaderAuth?(AnthropicAuth @this) => @this.Header;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::Vectara.HeaderAuth? value)
        {
            Header = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::Vectara.BedrockStaticIAMAuth value) => new AnthropicAuth((global::Vectara.BedrockStaticIAMAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BedrockStaticIAMAuth?(AnthropicAuth @this) => @this.BedrockStaticIam;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::Vectara.BedrockStaticIAMAuth? value)
        {
            BedrockStaticIam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::Vectara.BedrockApiKeyAuth value) => new AnthropicAuth((global::Vectara.BedrockApiKeyAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BedrockApiKeyAuth?(AnthropicAuth @this) => @this.BedrockApiKey;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::Vectara.BedrockApiKeyAuth? value)
        {
            BedrockApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::Vectara.VertexServiceAccountAuth value) => new AnthropicAuth((global::Vectara.VertexServiceAccountAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.VertexServiceAccountAuth?(AnthropicAuth @this) => @this.VertexServiceAccount;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::Vectara.VertexServiceAccountAuth? value)
        {
            VertexServiceAccount = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::Vectara.VertexAccessTokenAuth value) => new AnthropicAuth((global::Vectara.VertexAccessTokenAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.VertexAccessTokenAuth?(AnthropicAuth @this) => @this.VertexAccessToken;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::Vectara.VertexAccessTokenAuth? value)
        {
            VertexAccessToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(
            global::Vectara.AnthropicAuthDiscriminatorType? type,
            global::Vectara.BearerAuth? bearer,
            global::Vectara.HeaderAuth? header,
            global::Vectara.BedrockStaticIAMAuth? bedrockStaticIam,
            global::Vectara.BedrockApiKeyAuth? bedrockApiKey,
            global::Vectara.VertexServiceAccountAuth? vertexServiceAccount,
            global::Vectara.VertexAccessTokenAuth? vertexAccessToken
            )
        {
            Type = type;

            Bearer = bearer;
            Header = header;
            BedrockStaticIam = bedrockStaticIam;
            BedrockApiKey = bedrockApiKey;
            VertexServiceAccount = vertexServiceAccount;
            VertexAccessToken = vertexAccessToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VertexAccessToken as object ??
            VertexServiceAccount as object ??
            BedrockApiKey as object ??
            BedrockStaticIam as object ??
            Header as object ??
            Bearer as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Bearer?.ToString() ??
            Header?.ToString() ??
            BedrockStaticIam?.ToString() ??
            BedrockApiKey?.ToString() ??
            VertexServiceAccount?.ToString() ??
            VertexAccessToken?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBearer && !IsHeader && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken || !IsBearer && IsHeader && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken || !IsBearer && !IsHeader && IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken || !IsBearer && !IsHeader && !IsBedrockStaticIam && IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken || !IsBearer && !IsHeader && !IsBedrockStaticIam && !IsBedrockApiKey && IsVertexServiceAccount && !IsVertexAccessToken || !IsBearer && !IsHeader && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && IsVertexAccessToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BearerAuth?, TResult>? bearer = null,
            global::System.Func<global::Vectara.HeaderAuth?, TResult>? header = null,
            global::System.Func<global::Vectara.BedrockStaticIAMAuth?, TResult>? bedrockStaticIam = null,
            global::System.Func<global::Vectara.BedrockApiKeyAuth?, TResult>? bedrockApiKey = null,
            global::System.Func<global::Vectara.VertexServiceAccountAuth?, TResult>? vertexServiceAccount = null,
            global::System.Func<global::Vectara.VertexAccessTokenAuth?, TResult>? vertexAccessToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBearer && bearer != null)
            {
                return bearer(Bearer!);
            }
            else if (IsHeader && header != null)
            {
                return header(Header!);
            }
            else if (IsBedrockStaticIam && bedrockStaticIam != null)
            {
                return bedrockStaticIam(BedrockStaticIam!);
            }
            else if (IsBedrockApiKey && bedrockApiKey != null)
            {
                return bedrockApiKey(BedrockApiKey!);
            }
            else if (IsVertexServiceAccount && vertexServiceAccount != null)
            {
                return vertexServiceAccount(VertexServiceAccount!);
            }
            else if (IsVertexAccessToken && vertexAccessToken != null)
            {
                return vertexAccessToken(VertexAccessToken!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BearerAuth?>? bearer = null,
            global::System.Action<global::Vectara.HeaderAuth?>? header = null,
            global::System.Action<global::Vectara.BedrockStaticIAMAuth?>? bedrockStaticIam = null,
            global::System.Action<global::Vectara.BedrockApiKeyAuth?>? bedrockApiKey = null,
            global::System.Action<global::Vectara.VertexServiceAccountAuth?>? vertexServiceAccount = null,
            global::System.Action<global::Vectara.VertexAccessTokenAuth?>? vertexAccessToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBearer)
            {
                bearer?.Invoke(Bearer!);
            }
            else if (IsHeader)
            {
                header?.Invoke(Header!);
            }
            else if (IsBedrockStaticIam)
            {
                bedrockStaticIam?.Invoke(BedrockStaticIam!);
            }
            else if (IsBedrockApiKey)
            {
                bedrockApiKey?.Invoke(BedrockApiKey!);
            }
            else if (IsVertexServiceAccount)
            {
                vertexServiceAccount?.Invoke(VertexServiceAccount!);
            }
            else if (IsVertexAccessToken)
            {
                vertexAccessToken?.Invoke(VertexAccessToken!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Bearer,
                typeof(global::Vectara.BearerAuth),
                Header,
                typeof(global::Vectara.HeaderAuth),
                BedrockStaticIam,
                typeof(global::Vectara.BedrockStaticIAMAuth),
                BedrockApiKey,
                typeof(global::Vectara.BedrockApiKeyAuth),
                VertexServiceAccount,
                typeof(global::Vectara.VertexServiceAccountAuth),
                VertexAccessToken,
                typeof(global::Vectara.VertexAccessTokenAuth),
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
        public bool Equals(AnthropicAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BearerAuth?>.Default.Equals(Bearer, other.Bearer) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.HeaderAuth?>.Default.Equals(Header, other.Header) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BedrockStaticIAMAuth?>.Default.Equals(BedrockStaticIam, other.BedrockStaticIam) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BedrockApiKeyAuth?>.Default.Equals(BedrockApiKey, other.BedrockApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.VertexServiceAccountAuth?>.Default.Equals(VertexServiceAccount, other.VertexServiceAccount) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.VertexAccessTokenAuth?>.Default.Equals(VertexAccessToken, other.VertexAccessToken) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicAuth obj1, AnthropicAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicAuth obj1, AnthropicAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicAuth o && Equals(o);
        }
    }
}
