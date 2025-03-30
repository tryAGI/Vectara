#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Authentication configuration for an LLM
    /// </summary>
    public readonly partial struct RemoteAuth : global::System.IEquatable<RemoteAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.RemoteAuthDiscriminatorType? Type { get; }

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
        public static implicit operator RemoteAuth(global::Vectara.BearerAuth value) => new RemoteAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BearerAuth?(RemoteAuth @this) => @this.Bearer;

        /// <summary>
        /// 
        /// </summary>
        public RemoteAuth(global::Vectara.BearerAuth? value)
        {
            Bearer = value;
        }

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
        public static implicit operator RemoteAuth(global::Vectara.HeaderAuth value) => new RemoteAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.HeaderAuth?(RemoteAuth @this) => @this.Header;

        /// <summary>
        /// 
        /// </summary>
        public RemoteAuth(global::Vectara.HeaderAuth? value)
        {
            Header = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RemoteAuth(
            global::Vectara.RemoteAuthDiscriminatorType? type,
            global::Vectara.BearerAuth? bearer,
            global::Vectara.HeaderAuth? header
            )
        {
            Type = type;

            Bearer = bearer;
            Header = header;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Header as object ??
            Bearer as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Bearer?.ToString() ??
            Header?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBearer && !IsHeader || !IsBearer && IsHeader;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BearerAuth?, TResult>? bearer = null,
            global::System.Func<global::Vectara.HeaderAuth?, TResult>? header = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BearerAuth?>? bearer = null,
            global::System.Action<global::Vectara.HeaderAuth?>? header = null,
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
        public bool Equals(RemoteAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BearerAuth?>.Default.Equals(Bearer, other.Bearer) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.HeaderAuth?>.Default.Equals(Header, other.Header) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RemoteAuth obj1, RemoteAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RemoteAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RemoteAuth obj1, RemoteAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RemoteAuth o && Equals(o);
        }
    }
}
