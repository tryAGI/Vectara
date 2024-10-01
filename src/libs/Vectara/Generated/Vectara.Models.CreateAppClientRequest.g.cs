using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateAppClientRequest : global::System.IEquatable<CreateAppClientRequest>
    {
        /// <summary>
        /// Create an App Client which allows you to call Vectara APIs using OAuth 2.0 client credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateClientCredentialsRequest? Credentials { get; init; }
#else
        public global::Vectara.CreateClientCredentialsRequest? Credentials { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Credentials))]
#endif
        public bool IsCredentials => Credentials != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAppClientRequest(global::Vectara.CreateClientCredentialsRequest value) => new CreateAppClientRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateClientCredentialsRequest?(CreateAppClientRequest @this) => @this.Credentials;

        /// <summary>
        /// 
        /// </summary>
        public CreateAppClientRequest(global::Vectara.CreateClientCredentialsRequest? value)
        {
            Credentials = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Credentials as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCredentials;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateClientCredentialsRequest?, TResult>? credentials = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCredentials && credentials != null)
            {
                return credentials(Credentials!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateClientCredentialsRequest?>? credentials = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCredentials)
            {
                credentials?.Invoke(Credentials!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Credentials,
                typeof(global::Vectara.CreateClientCredentialsRequest),
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
        public bool Equals(CreateAppClientRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateClientCredentialsRequest?>.Default.Equals(Credentials, other.Credentials) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateAppClientRequest obj1, CreateAppClientRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAppClientRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateAppClientRequest obj1, CreateAppClientRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAppClientRequest o && Equals(o);
        }
    }
}
