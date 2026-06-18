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
        public WebGetAuth(
            global::Vectara.WebGetAuthDiscriminatorType? type,
            global::Vectara.WebGetNoAuth? none,
            global::Vectara.WebGetBearerAuth? bearer,
            global::Vectara.WebGetHeaderAuth? header,
            global::Vectara.WebGetOAuthClientCredentialsAuth? oauthClientCredentials,
            global::Vectara.WebGetOAuthRefreshTokenAuth? oauthRefreshToken
            )
        {
            Type = type;

            None = none;
            Bearer = bearer;
            Header = header;
            OauthClientCredentials = oauthClientCredentials;
            OauthRefreshToken = oauthRefreshToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            OauthRefreshToken?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNone && !IsBearer && !IsHeader && !IsOauthClientCredentials && !IsOauthRefreshToken || !IsNone && IsBearer && !IsHeader && !IsOauthClientCredentials && !IsOauthRefreshToken || !IsNone && !IsBearer && IsHeader && !IsOauthClientCredentials && !IsOauthRefreshToken || !IsNone && !IsBearer && !IsHeader && IsOauthClientCredentials && !IsOauthRefreshToken || !IsNone && !IsBearer && !IsHeader && !IsOauthClientCredentials && IsOauthRefreshToken;
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetOAuthRefreshTokenAuth?>.Default.Equals(OauthRefreshToken, other.OauthRefreshToken) 
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
