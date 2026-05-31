#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Authentication configuration for an LLM. Union over every variant any LLM provider accepts. When returned on `GET`, secret fields contain the literal string `****`.
    /// </summary>
    public readonly partial struct LLMAuth : global::System.IEquatable<LLMAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.LLMAuthDiscriminatorType? Type { get; }

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
        /// 
        /// </summary>
        public bool TryPickBearer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.BearerAuth? value)
        {
            value = Bearer;
            return IsBearer;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BearerAuth PickBearer() => IsBearer
            ? Bearer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bearer' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickHeader(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.HeaderAuth? value)
        {
            value = Header;
            return IsHeader;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.HeaderAuth PickHeader() => IsHeader
            ? Header!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Header' but the value was {ToString()}.");

        /// <summary>
        /// OAuth 2.0 client credentials authentication. The platform acquires an access token from the token endpoint before connecting to the remote service.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.OAuthClientCredentialsAuth? OauthClientCredentials { get; init; }
#else
        public global::Vectara.OAuthClientCredentialsAuth? OauthClientCredentials { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OauthClientCredentials))]
#endif
        public bool IsOauthClientCredentials => OauthClientCredentials != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOauthClientCredentials(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.OAuthClientCredentialsAuth? value)
        {
            value = OauthClientCredentials;
            return IsOauthClientCredentials;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.OAuthClientCredentialsAuth PickOauthClientCredentials() => IsOauthClientCredentials
            ? OauthClientCredentials!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OauthClientCredentials' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickBedrockStaticIam(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.BedrockStaticIAMAuth? value)
        {
            value = BedrockStaticIam;
            return IsBedrockStaticIam;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BedrockStaticIAMAuth PickBedrockStaticIam() => IsBedrockStaticIam
            ? BedrockStaticIam!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BedrockStaticIam' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickBedrockApiKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.BedrockApiKeyAuth? value)
        {
            value = BedrockApiKey;
            return IsBedrockApiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BedrockApiKeyAuth PickBedrockApiKey() => IsBedrockApiKey
            ? BedrockApiKey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BedrockApiKey' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickVertexServiceAccount(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.VertexServiceAccountAuth? value)
        {
            value = VertexServiceAccount;
            return IsVertexServiceAccount;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.VertexServiceAccountAuth PickVertexServiceAccount() => IsVertexServiceAccount
            ? VertexServiceAccount!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VertexServiceAccount' but the value was {ToString()}.");

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
        public bool TryPickVertexAccessToken(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.VertexAccessTokenAuth? value)
        {
            value = VertexAccessToken;
            return IsVertexAccessToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.VertexAccessTokenAuth PickVertexAccessToken() => IsVertexAccessToken
            ? VertexAccessToken!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VertexAccessToken' but the value was {ToString()}.");

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
        public bool TryPickApiKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.VertexAiApiKeyAuth? value)
        {
            value = ApiKey;
            return IsApiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.VertexAiApiKeyAuth PickApiKey() => IsApiKey
            ? ApiKey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiKey' but the value was {ToString()}.");

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
        public bool TryPickServiceAccount(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.VertexAiServiceAccountAuth? value)
        {
            value = ServiceAccount;
            return IsServiceAccount;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.VertexAiServiceAccountAuth PickServiceAccount() => IsServiceAccount
            ? ServiceAccount!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServiceAccount' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMAuth(global::Vectara.BearerAuth value) => new LLMAuth((global::Vectara.BearerAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BearerAuth?(LLMAuth @this) => @this.Bearer;

        /// <summary>
        /// 
        /// </summary>
        public LLMAuth(global::Vectara.BearerAuth? value)
        {
            Bearer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LLMAuth FromBearer(global::Vectara.BearerAuth? value) => new LLMAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMAuth(global::Vectara.HeaderAuth value) => new LLMAuth((global::Vectara.HeaderAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.HeaderAuth?(LLMAuth @this) => @this.Header;

        /// <summary>
        /// 
        /// </summary>
        public LLMAuth(global::Vectara.HeaderAuth? value)
        {
            Header = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LLMAuth FromHeader(global::Vectara.HeaderAuth? value) => new LLMAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMAuth(global::Vectara.OAuthClientCredentialsAuth value) => new LLMAuth((global::Vectara.OAuthClientCredentialsAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.OAuthClientCredentialsAuth?(LLMAuth @this) => @this.OauthClientCredentials;

        /// <summary>
        /// 
        /// </summary>
        public LLMAuth(global::Vectara.OAuthClientCredentialsAuth? value)
        {
            OauthClientCredentials = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LLMAuth FromOauthClientCredentials(global::Vectara.OAuthClientCredentialsAuth? value) => new LLMAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMAuth(global::Vectara.BedrockStaticIAMAuth value) => new LLMAuth((global::Vectara.BedrockStaticIAMAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BedrockStaticIAMAuth?(LLMAuth @this) => @this.BedrockStaticIam;

        /// <summary>
        /// 
        /// </summary>
        public LLMAuth(global::Vectara.BedrockStaticIAMAuth? value)
        {
            BedrockStaticIam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LLMAuth FromBedrockStaticIam(global::Vectara.BedrockStaticIAMAuth? value) => new LLMAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMAuth(global::Vectara.BedrockApiKeyAuth value) => new LLMAuth((global::Vectara.BedrockApiKeyAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BedrockApiKeyAuth?(LLMAuth @this) => @this.BedrockApiKey;

        /// <summary>
        /// 
        /// </summary>
        public LLMAuth(global::Vectara.BedrockApiKeyAuth? value)
        {
            BedrockApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LLMAuth FromBedrockApiKey(global::Vectara.BedrockApiKeyAuth? value) => new LLMAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMAuth(global::Vectara.VertexServiceAccountAuth value) => new LLMAuth((global::Vectara.VertexServiceAccountAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.VertexServiceAccountAuth?(LLMAuth @this) => @this.VertexServiceAccount;

        /// <summary>
        /// 
        /// </summary>
        public LLMAuth(global::Vectara.VertexServiceAccountAuth? value)
        {
            VertexServiceAccount = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LLMAuth FromVertexServiceAccount(global::Vectara.VertexServiceAccountAuth? value) => new LLMAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMAuth(global::Vectara.VertexAccessTokenAuth value) => new LLMAuth((global::Vectara.VertexAccessTokenAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.VertexAccessTokenAuth?(LLMAuth @this) => @this.VertexAccessToken;

        /// <summary>
        /// 
        /// </summary>
        public LLMAuth(global::Vectara.VertexAccessTokenAuth? value)
        {
            VertexAccessToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LLMAuth FromVertexAccessToken(global::Vectara.VertexAccessTokenAuth? value) => new LLMAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMAuth(global::Vectara.VertexAiApiKeyAuth value) => new LLMAuth((global::Vectara.VertexAiApiKeyAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.VertexAiApiKeyAuth?(LLMAuth @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public LLMAuth(global::Vectara.VertexAiApiKeyAuth? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LLMAuth FromApiKey(global::Vectara.VertexAiApiKeyAuth? value) => new LLMAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMAuth(global::Vectara.VertexAiServiceAccountAuth value) => new LLMAuth((global::Vectara.VertexAiServiceAccountAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.VertexAiServiceAccountAuth?(LLMAuth @this) => @this.ServiceAccount;

        /// <summary>
        /// 
        /// </summary>
        public LLMAuth(global::Vectara.VertexAiServiceAccountAuth? value)
        {
            ServiceAccount = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LLMAuth FromServiceAccount(global::Vectara.VertexAiServiceAccountAuth? value) => new LLMAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public LLMAuth(
            global::Vectara.LLMAuthDiscriminatorType? type,
            global::Vectara.BearerAuth? bearer,
            global::Vectara.HeaderAuth? header,
            global::Vectara.OAuthClientCredentialsAuth? oauthClientCredentials,
            global::Vectara.BedrockStaticIAMAuth? bedrockStaticIam,
            global::Vectara.BedrockApiKeyAuth? bedrockApiKey,
            global::Vectara.VertexServiceAccountAuth? vertexServiceAccount,
            global::Vectara.VertexAccessTokenAuth? vertexAccessToken,
            global::Vectara.VertexAiApiKeyAuth? apiKey,
            global::Vectara.VertexAiServiceAccountAuth? serviceAccount
            )
        {
            Type = type;

            Bearer = bearer;
            Header = header;
            OauthClientCredentials = oauthClientCredentials;
            BedrockStaticIam = bedrockStaticIam;
            BedrockApiKey = bedrockApiKey;
            VertexServiceAccount = vertexServiceAccount;
            VertexAccessToken = vertexAccessToken;
            ApiKey = apiKey;
            ServiceAccount = serviceAccount;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ServiceAccount as object ??
            ApiKey as object ??
            VertexAccessToken as object ??
            VertexServiceAccount as object ??
            BedrockApiKey as object ??
            BedrockStaticIam as object ??
            OauthClientCredentials as object ??
            Header as object ??
            Bearer as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Bearer?.ToString() ??
            Header?.ToString() ??
            OauthClientCredentials?.ToString() ??
            BedrockStaticIam?.ToString() ??
            BedrockApiKey?.ToString() ??
            VertexServiceAccount?.ToString() ??
            VertexAccessToken?.ToString() ??
            ApiKey?.ToString() ??
            ServiceAccount?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBearer && !IsHeader && !IsOauthClientCredentials && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken && !IsApiKey && !IsServiceAccount || !IsBearer && IsHeader && !IsOauthClientCredentials && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken && !IsApiKey && !IsServiceAccount || !IsBearer && !IsHeader && IsOauthClientCredentials && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken && !IsApiKey && !IsServiceAccount || !IsBearer && !IsHeader && !IsOauthClientCredentials && IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken && !IsApiKey && !IsServiceAccount || !IsBearer && !IsHeader && !IsOauthClientCredentials && !IsBedrockStaticIam && IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken && !IsApiKey && !IsServiceAccount || !IsBearer && !IsHeader && !IsOauthClientCredentials && !IsBedrockStaticIam && !IsBedrockApiKey && IsVertexServiceAccount && !IsVertexAccessToken && !IsApiKey && !IsServiceAccount || !IsBearer && !IsHeader && !IsOauthClientCredentials && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && IsVertexAccessToken && !IsApiKey && !IsServiceAccount || !IsBearer && !IsHeader && !IsOauthClientCredentials && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken && IsApiKey && !IsServiceAccount || !IsBearer && !IsHeader && !IsOauthClientCredentials && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken && !IsApiKey && IsServiceAccount;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BearerAuth, TResult>? bearer = null,
            global::System.Func<global::Vectara.HeaderAuth, TResult>? header = null,
            global::System.Func<global::Vectara.OAuthClientCredentialsAuth, TResult>? oauthClientCredentials = null,
            global::System.Func<global::Vectara.BedrockStaticIAMAuth, TResult>? bedrockStaticIam = null,
            global::System.Func<global::Vectara.BedrockApiKeyAuth, TResult>? bedrockApiKey = null,
            global::System.Func<global::Vectara.VertexServiceAccountAuth, TResult>? vertexServiceAccount = null,
            global::System.Func<global::Vectara.VertexAccessTokenAuth, TResult>? vertexAccessToken = null,
            global::System.Func<global::Vectara.VertexAiApiKeyAuth, TResult>? apiKey = null,
            global::System.Func<global::Vectara.VertexAiServiceAccountAuth, TResult>? serviceAccount = null,
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
            else if (IsOauthClientCredentials && oauthClientCredentials != null)
            {
                return oauthClientCredentials(OauthClientCredentials!);
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
            else if (IsApiKey && apiKey != null)
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
            global::System.Action<global::Vectara.BearerAuth>? bearer = null,

            global::System.Action<global::Vectara.HeaderAuth>? header = null,

            global::System.Action<global::Vectara.OAuthClientCredentialsAuth>? oauthClientCredentials = null,

            global::System.Action<global::Vectara.BedrockStaticIAMAuth>? bedrockStaticIam = null,

            global::System.Action<global::Vectara.BedrockApiKeyAuth>? bedrockApiKey = null,

            global::System.Action<global::Vectara.VertexServiceAccountAuth>? vertexServiceAccount = null,

            global::System.Action<global::Vectara.VertexAccessTokenAuth>? vertexAccessToken = null,

            global::System.Action<global::Vectara.VertexAiApiKeyAuth>? apiKey = null,

            global::System.Action<global::Vectara.VertexAiServiceAccountAuth>? serviceAccount = null,
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
            else if (IsOauthClientCredentials)
            {
                oauthClientCredentials?.Invoke(OauthClientCredentials!);
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
            else if (IsApiKey)
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
        public void Switch(
            global::System.Action<global::Vectara.BearerAuth>? bearer = null,
            global::System.Action<global::Vectara.HeaderAuth>? header = null,
            global::System.Action<global::Vectara.OAuthClientCredentialsAuth>? oauthClientCredentials = null,
            global::System.Action<global::Vectara.BedrockStaticIAMAuth>? bedrockStaticIam = null,
            global::System.Action<global::Vectara.BedrockApiKeyAuth>? bedrockApiKey = null,
            global::System.Action<global::Vectara.VertexServiceAccountAuth>? vertexServiceAccount = null,
            global::System.Action<global::Vectara.VertexAccessTokenAuth>? vertexAccessToken = null,
            global::System.Action<global::Vectara.VertexAiApiKeyAuth>? apiKey = null,
            global::System.Action<global::Vectara.VertexAiServiceAccountAuth>? serviceAccount = null,
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
            else if (IsOauthClientCredentials)
            {
                oauthClientCredentials?.Invoke(OauthClientCredentials!);
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
            else if (IsApiKey)
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
                Bearer,
                typeof(global::Vectara.BearerAuth),
                Header,
                typeof(global::Vectara.HeaderAuth),
                OauthClientCredentials,
                typeof(global::Vectara.OAuthClientCredentialsAuth),
                BedrockStaticIam,
                typeof(global::Vectara.BedrockStaticIAMAuth),
                BedrockApiKey,
                typeof(global::Vectara.BedrockApiKeyAuth),
                VertexServiceAccount,
                typeof(global::Vectara.VertexServiceAccountAuth),
                VertexAccessToken,
                typeof(global::Vectara.VertexAccessTokenAuth),
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
        public bool Equals(LLMAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BearerAuth?>.Default.Equals(Bearer, other.Bearer) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.HeaderAuth?>.Default.Equals(Header, other.Header) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.OAuthClientCredentialsAuth?>.Default.Equals(OauthClientCredentials, other.OauthClientCredentials) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BedrockStaticIAMAuth?>.Default.Equals(BedrockStaticIam, other.BedrockStaticIam) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BedrockApiKeyAuth?>.Default.Equals(BedrockApiKey, other.BedrockApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.VertexServiceAccountAuth?>.Default.Equals(VertexServiceAccount, other.VertexServiceAccount) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.VertexAccessTokenAuth?>.Default.Equals(VertexAccessToken, other.VertexAccessToken) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.VertexAiApiKeyAuth?>.Default.Equals(ApiKey, other.ApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.VertexAiServiceAccountAuth?>.Default.Equals(ServiceAccount, other.ServiceAccount) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LLMAuth obj1, LLMAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LLMAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LLMAuth obj1, LLMAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LLMAuth o && Equals(o);
        }
    }
}
