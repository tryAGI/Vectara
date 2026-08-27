#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Authentication configuration for the outgoing HTTP request.
    /// </summary>
    public readonly partial struct WebGetAuth : global::System.IEquatable<WebGetAuth>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// Explicitly disables authentication.<br/>
        /// Useful in argument_override to force a tool config to clear any auth the agent would otherwise supply, since merge semantics ignore null patches.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebGetNoAuth? None { get; init; }
#else
        public global::Vectara.WebGetNoAuth? None { get; }
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
        public bool TryPickNone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WebGetNoAuth? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetNoAuth PickNone() => IsNone
            ? None!
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");

        /// <summary>
        /// Static bearer token authentication. Adds `Authorization: Bearer &lt;token&gt;`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebGetBearerAuth? Bearer { get; init; }
#else
        public global::Vectara.WebGetBearerAuth? Bearer { get; }
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
            out global::Vectara.WebGetBearerAuth? value)
        {
            value = Bearer;
            return IsBearer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetBearerAuth PickBearer() => IsBearer
            ? Bearer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bearer' but the value was {ToString()}.");

        /// <summary>
        /// Static custom-header authentication, suitable for API keys.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebGetHeaderAuth? Header { get; init; }
#else
        public global::Vectara.WebGetHeaderAuth? Header { get; }
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
            out global::Vectara.WebGetHeaderAuth? value)
        {
            value = Header;
            return IsHeader;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetHeaderAuth PickHeader() => IsHeader
            ? Header!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Header' but the value was {ToString()}.");

        /// <summary>
        /// OAuth 2.0 client-credentials grant.<br/>
        /// The platform fetches an access token from the token endpoint and caches it until it expires.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebGetOAuthClientCredentialsAuth? OauthClientCredentials { get; init; }
#else
        public global::Vectara.WebGetOAuthClientCredentialsAuth? OauthClientCredentials { get; }
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
            out global::Vectara.WebGetOAuthClientCredentialsAuth? value)
        {
            value = OauthClientCredentials;
            return IsOauthClientCredentials;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthClientCredentialsAuth PickOauthClientCredentials() => IsOauthClientCredentials
            ? OauthClientCredentials!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OauthClientCredentials' but the value was {ToString()}.");

        /// <summary>
        /// OAuth 2.0 refresh-token grant.<br/>
        /// The platform exchanges a long-lived refresh token for an access token and caches the result until it expires.<br/>
        /// Supports refresh-token rotation: if the IdP returns a new refresh_token, subsequent refreshes use it automatically.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebGetOAuthRefreshTokenAuth? OauthRefreshToken { get; init; }
#else
        public global::Vectara.WebGetOAuthRefreshTokenAuth? OauthRefreshToken { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OauthRefreshToken))]
#endif
        public bool IsOauthRefreshToken => OauthRefreshToken != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOauthRefreshToken(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WebGetOAuthRefreshTokenAuth? value)
        {
            value = OauthRefreshToken;
            return IsOauthRefreshToken;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthRefreshTokenAuth PickOauthRefreshToken() => IsOauthRefreshToken
            ? OauthRefreshToken!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OauthRefreshToken' but the value was {ToString()}.");

        /// <summary>
        /// Two-legged OAuth token exchange. The platform first mints a subject token via the client-credentials grant at `token_endpoint`, scoped to `subject_audience`. It then exchanges the subject token at `exchange_endpoint` for the token sent to the target service. Configurable to cover both RFC 8693 and non-standard STS endpoints that present the subject token or parameters differently. The platform caches both tokens until they expire.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebGetOAuthTokenExchangeAuth? OauthTokenExchange { get; init; }
#else
        public global::Vectara.WebGetOAuthTokenExchangeAuth? OauthTokenExchange { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OauthTokenExchange))]
#endif
        public bool IsOauthTokenExchange => OauthTokenExchange != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOauthTokenExchange(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WebGetOAuthTokenExchangeAuth? value)
        {
            value = OauthTokenExchange;
            return IsOauthTokenExchange;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetOAuthTokenExchangeAuth PickOauthTokenExchange() => IsOauthTokenExchange
            ? OauthTokenExchange!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OauthTokenExchange' but the value was {ToString()}.");

        /// <summary>
        /// AWS Signature Version 4 request signing, e.g. for reading an S3 bucket directly. The platform signs the final request (method, URL, query parameters, and body) with the supplied credentials. User-supplied headers ride along unsigned. The platform never follows redirects on signed requests. When `role_arn` is set, the platform first calls sts:AssumeRole with the static credentials and signs with the assumed-role credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebGetAwsSigV4Auth? AwsSigv4 { get; init; }
#else
        public global::Vectara.WebGetAwsSigV4Auth? AwsSigv4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AwsSigv4))]
#endif
        public bool IsAwsSigv4 => AwsSigv4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAwsSigv4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WebGetAwsSigV4Auth? value)
        {
            value = AwsSigv4;
            return IsAwsSigv4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebGetAwsSigV4Auth PickAwsSigv4() => IsAwsSigv4
            ? AwsSigv4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AwsSigv4' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebGetAuth(global::Vectara.WebGetNoAuth value) => new WebGetAuth((global::Vectara.WebGetNoAuth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WebGetNoAuth?(WebGetAuth @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public WebGetAuth(global::Vectara.WebGetNoAuth? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebGetAuth FromNone(global::Vectara.WebGetNoAuth? value) => new WebGetAuth(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebGetAuth(global::Vectara.WebGetBearerAuth value) => new WebGetAuth((global::Vectara.WebGetBearerAuth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WebGetBearerAuth?(WebGetAuth @this) => @this.Bearer;

        /// <summary>
        ///
        /// </summary>
        public WebGetAuth(global::Vectara.WebGetBearerAuth? value)
        {
            Bearer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebGetAuth FromBearer(global::Vectara.WebGetBearerAuth? value) => new WebGetAuth(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebGetAuth(global::Vectara.WebGetHeaderAuth value) => new WebGetAuth((global::Vectara.WebGetHeaderAuth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WebGetHeaderAuth?(WebGetAuth @this) => @this.Header;

        /// <summary>
        ///
        /// </summary>
        public WebGetAuth(global::Vectara.WebGetHeaderAuth? value)
        {
            Header = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebGetAuth FromHeader(global::Vectara.WebGetHeaderAuth? value) => new WebGetAuth(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebGetAuth(global::Vectara.WebGetOAuthClientCredentialsAuth value) => new WebGetAuth((global::Vectara.WebGetOAuthClientCredentialsAuth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WebGetOAuthClientCredentialsAuth?(WebGetAuth @this) => @this.OauthClientCredentials;

        /// <summary>
        ///
        /// </summary>
        public WebGetAuth(global::Vectara.WebGetOAuthClientCredentialsAuth? value)
        {
            OauthClientCredentials = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebGetAuth FromOauthClientCredentials(global::Vectara.WebGetOAuthClientCredentialsAuth? value) => new WebGetAuth(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebGetAuth(global::Vectara.WebGetOAuthRefreshTokenAuth value) => new WebGetAuth((global::Vectara.WebGetOAuthRefreshTokenAuth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WebGetOAuthRefreshTokenAuth?(WebGetAuth @this) => @this.OauthRefreshToken;

        /// <summary>
        ///
        /// </summary>
        public WebGetAuth(global::Vectara.WebGetOAuthRefreshTokenAuth? value)
        {
            OauthRefreshToken = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebGetAuth FromOauthRefreshToken(global::Vectara.WebGetOAuthRefreshTokenAuth? value) => new WebGetAuth(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebGetAuth(global::Vectara.WebGetOAuthTokenExchangeAuth value) => new WebGetAuth((global::Vectara.WebGetOAuthTokenExchangeAuth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WebGetOAuthTokenExchangeAuth?(WebGetAuth @this) => @this.OauthTokenExchange;

        /// <summary>
        ///
        /// </summary>
        public WebGetAuth(global::Vectara.WebGetOAuthTokenExchangeAuth? value)
        {
            OauthTokenExchange = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebGetAuth FromOauthTokenExchange(global::Vectara.WebGetOAuthTokenExchangeAuth? value) => new WebGetAuth(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebGetAuth(global::Vectara.WebGetAwsSigV4Auth value) => new WebGetAuth((global::Vectara.WebGetAwsSigV4Auth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WebGetAwsSigV4Auth?(WebGetAuth @this) => @this.AwsSigv4;

        /// <summary>
        ///
        /// </summary>
        public WebGetAuth(global::Vectara.WebGetAwsSigV4Auth? value)
        {
            AwsSigv4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebGetAuth FromAwsSigv4(global::Vectara.WebGetAwsSigV4Auth? value) => new WebGetAuth(value);

        /// <summary>
        ///
        /// </summary>
        public WebGetAuth(
            global::Vectara.WebGetAuthDiscriminatorType? type,
            global::Vectara.WebGetNoAuth? none,
            global::Vectara.WebGetBearerAuth? bearer,
            global::Vectara.WebGetHeaderAuth? header,
            global::Vectara.WebGetOAuthClientCredentialsAuth? oauthClientCredentials,
            global::Vectara.WebGetOAuthRefreshTokenAuth? oauthRefreshToken,
            global::Vectara.WebGetOAuthTokenExchangeAuth? oauthTokenExchange,
            global::Vectara.WebGetAwsSigV4Auth? awsSigv4
            )
        {
            Type = type;

            None = none;
            Bearer = bearer;
            Header = header;
            OauthClientCredentials = oauthClientCredentials;
            OauthRefreshToken = oauthRefreshToken;
            OauthTokenExchange = oauthTokenExchange;
            AwsSigv4 = awsSigv4;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AwsSigv4 as object ??
            OauthTokenExchange as object ??
            OauthRefreshToken as object ??
            OauthClientCredentials as object ??
            Header as object ??
            Bearer as object ??
            None as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            None?.ToString() ??
            Bearer?.ToString() ??
            Header?.ToString() ??
            OauthClientCredentials?.ToString() ??
            OauthRefreshToken?.ToString() ??
            OauthTokenExchange?.ToString() ??
            AwsSigv4?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNone && !IsBearer && !IsHeader && !IsOauthClientCredentials && !IsOauthRefreshToken && !IsOauthTokenExchange && !IsAwsSigv4 || !IsNone && IsBearer && !IsHeader && !IsOauthClientCredentials && !IsOauthRefreshToken && !IsOauthTokenExchange && !IsAwsSigv4 || !IsNone && !IsBearer && IsHeader && !IsOauthClientCredentials && !IsOauthRefreshToken && !IsOauthTokenExchange && !IsAwsSigv4 || !IsNone && !IsBearer && !IsHeader && IsOauthClientCredentials && !IsOauthRefreshToken && !IsOauthTokenExchange && !IsAwsSigv4 || !IsNone && !IsBearer && !IsHeader && !IsOauthClientCredentials && IsOauthRefreshToken && !IsOauthTokenExchange && !IsAwsSigv4 || !IsNone && !IsBearer && !IsHeader && !IsOauthClientCredentials && !IsOauthRefreshToken && IsOauthTokenExchange && !IsAwsSigv4 || !IsNone && !IsBearer && !IsHeader && !IsOauthClientCredentials && !IsOauthRefreshToken && !IsOauthTokenExchange && IsAwsSigv4;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.WebGetNoAuth, TResult>? none = null,
            global::System.Func<global::Vectara.WebGetBearerAuth, TResult>? bearer = null,
            global::System.Func<global::Vectara.WebGetHeaderAuth, TResult>? header = null,
            global::System.Func<global::Vectara.WebGetOAuthClientCredentialsAuth, TResult>? oauthClientCredentials = null,
            global::System.Func<global::Vectara.WebGetOAuthRefreshTokenAuth, TResult>? oauthRefreshToken = null,
            global::System.Func<global::Vectara.WebGetOAuthTokenExchangeAuth, TResult>? oauthTokenExchange = null,
            global::System.Func<global::Vectara.WebGetAwsSigV4Auth, TResult>? awsSigv4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone && none != null)
            {
                return none(None!);
            }
            else if (IsBearer && bearer != null)
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
            else if (IsOauthRefreshToken && oauthRefreshToken != null)
            {
                return oauthRefreshToken(OauthRefreshToken!);
            }
            else if (IsOauthTokenExchange && oauthTokenExchange != null)
            {
                return oauthTokenExchange(OauthTokenExchange!);
            }
            else if (IsAwsSigv4 && awsSigv4 != null)
            {
                return awsSigv4(AwsSigv4!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.WebGetNoAuth>? none = null,

            global::System.Action<global::Vectara.WebGetBearerAuth>? bearer = null,

            global::System.Action<global::Vectara.WebGetHeaderAuth>? header = null,

            global::System.Action<global::Vectara.WebGetOAuthClientCredentialsAuth>? oauthClientCredentials = null,

            global::System.Action<global::Vectara.WebGetOAuthRefreshTokenAuth>? oauthRefreshToken = null,

            global::System.Action<global::Vectara.WebGetOAuthTokenExchangeAuth>? oauthTokenExchange = null,

            global::System.Action<global::Vectara.WebGetAwsSigV4Auth>? awsSigv4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsBearer)
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
            else if (IsOauthRefreshToken)
            {
                oauthRefreshToken?.Invoke(OauthRefreshToken!);
            }
            else if (IsOauthTokenExchange)
            {
                oauthTokenExchange?.Invoke(OauthTokenExchange!);
            }
            else if (IsAwsSigv4)
            {
                awsSigv4?.Invoke(AwsSigv4!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.WebGetNoAuth>? none = null,
            global::System.Action<global::Vectara.WebGetBearerAuth>? bearer = null,
            global::System.Action<global::Vectara.WebGetHeaderAuth>? header = null,
            global::System.Action<global::Vectara.WebGetOAuthClientCredentialsAuth>? oauthClientCredentials = null,
            global::System.Action<global::Vectara.WebGetOAuthRefreshTokenAuth>? oauthRefreshToken = null,
            global::System.Action<global::Vectara.WebGetOAuthTokenExchangeAuth>? oauthTokenExchange = null,
            global::System.Action<global::Vectara.WebGetAwsSigV4Auth>? awsSigv4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsBearer)
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
            else if (IsOauthRefreshToken)
            {
                oauthRefreshToken?.Invoke(OauthRefreshToken!);
            }
            else if (IsOauthTokenExchange)
            {
                oauthTokenExchange?.Invoke(OauthTokenExchange!);
            }
            else if (IsAwsSigv4)
            {
                awsSigv4?.Invoke(AwsSigv4!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                None,
                typeof(global::Vectara.WebGetNoAuth),
                Bearer,
                typeof(global::Vectara.WebGetBearerAuth),
                Header,
                typeof(global::Vectara.WebGetHeaderAuth),
                OauthClientCredentials,
                typeof(global::Vectara.WebGetOAuthClientCredentialsAuth),
                OauthRefreshToken,
                typeof(global::Vectara.WebGetOAuthRefreshTokenAuth),
                OauthTokenExchange,
                typeof(global::Vectara.WebGetOAuthTokenExchangeAuth),
                AwsSigv4,
                typeof(global::Vectara.WebGetAwsSigV4Auth),
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
        public bool Equals(WebGetAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetNoAuth?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetBearerAuth?>.Default.Equals(Bearer, other.Bearer) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetHeaderAuth?>.Default.Equals(Header, other.Header) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetOAuthClientCredentialsAuth?>.Default.Equals(OauthClientCredentials, other.OauthClientCredentials) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetOAuthRefreshTokenAuth?>.Default.Equals(OauthRefreshToken, other.OauthRefreshToken) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetOAuthTokenExchangeAuth?>.Default.Equals(OauthTokenExchange, other.OauthTokenExchange) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetAwsSigV4Auth?>.Default.Equals(AwsSigv4, other.AwsSigv4)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebGetAuth obj1, WebGetAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebGetAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebGetAuth obj1, WebGetAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebGetAuth o && Equals(o);
        }
    }
}
