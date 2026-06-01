#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a tool. Supports lambda tools for user-defined functions and client tools whose execution is performed by the calling client.
    /// </summary>
    public readonly partial struct CreateToolRequest : global::System.IEquatable<CreateToolRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateToolRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request to create a new lambda tool. Lambda tools are user-defined functions that run in a secure, sandboxed environment with Python 3.12.<br/>
        /// Input and output schemas are automatically discovered from function parameter type annotations in your code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateLambdaToolRequest? Lambda { get; init; }
#else
        public global::Vectara.CreateLambdaToolRequest? Lambda { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lambda))]
#endif
        public bool IsLambda => Lambda != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLambda(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateLambdaToolRequest? value)
        {
            value = Lambda;
            return IsLambda;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateLambdaToolRequest PickLambda() => IsLambda
            ? Lambda!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Lambda' but the value was {ToString()}.");

        /// <summary>
        /// Request to create a new client tool. When invoked, the platform emits a `tool_input` event; the client performs the work and submits a `tool_output` input via `createAgentInput`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateClientToolRequest? Client { get; init; }
#else
        public global::Vectara.CreateClientToolRequest? Client { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Client))]
#endif
        public bool IsClient => Client != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickClient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateClientToolRequest? value)
        {
            value = Client;
            return IsClient;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateClientToolRequest PickClient() => IsClient
            ? Client!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Client' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolRequest(global::Vectara.CreateLambdaToolRequest value) => new CreateToolRequest((global::Vectara.CreateLambdaToolRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateLambdaToolRequest?(CreateToolRequest @this) => @this.Lambda;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolRequest(global::Vectara.CreateLambdaToolRequest? value)
        {
            Lambda = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolRequest FromLambda(global::Vectara.CreateLambdaToolRequest? value) => new CreateToolRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolRequest(global::Vectara.CreateClientToolRequest value) => new CreateToolRequest((global::Vectara.CreateClientToolRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateClientToolRequest?(CreateToolRequest @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolRequest(global::Vectara.CreateClientToolRequest? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolRequest FromClient(global::Vectara.CreateClientToolRequest? value) => new CreateToolRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateToolRequest(
            global::Vectara.CreateToolRequestDiscriminatorType? type,
            global::Vectara.CreateLambdaToolRequest? lambda,
            global::Vectara.CreateClientToolRequest? client
            )
        {
            Type = type;

            Lambda = lambda;
            Client = client;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Client as object ??
            Lambda as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Lambda?.ToString() ??
            Client?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLambda && !IsClient || !IsLambda && IsClient;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateLambdaToolRequest, TResult>? lambda = null,
            global::System.Func<global::Vectara.CreateClientToolRequest, TResult>? client = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLambda && lambda != null)
            {
                return lambda(Lambda!);
            }
            else if (IsClient && client != null)
            {
                return client(Client!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateLambdaToolRequest>? lambda = null,

            global::System.Action<global::Vectara.CreateClientToolRequest>? client = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLambda)
            {
                lambda?.Invoke(Lambda!);
            }
            else if (IsClient)
            {
                client?.Invoke(Client!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateLambdaToolRequest>? lambda = null,
            global::System.Action<global::Vectara.CreateClientToolRequest>? client = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLambda)
            {
                lambda?.Invoke(Lambda!);
            }
            else if (IsClient)
            {
                client?.Invoke(Client!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Lambda,
                typeof(global::Vectara.CreateLambdaToolRequest),
                Client,
                typeof(global::Vectara.CreateClientToolRequest),
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
        public bool Equals(CreateToolRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateLambdaToolRequest?>.Default.Equals(Lambda, other.Lambda) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateClientToolRequest?>.Default.Equals(Client, other.Client) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateToolRequest obj1, CreateToolRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateToolRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateToolRequest obj1, CreateToolRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateToolRequest o && Equals(o);
        }
    }
}
