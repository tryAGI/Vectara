#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to update a tool. Supports updating MCP, Python lambda, and client tools.
    /// </summary>
    public readonly partial struct UpdateToolRequest : global::System.IEquatable<UpdateToolRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateToolRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request object for updating an existing MCP tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateMcpToolRequest? Mcp { get; init; }
#else
        public global::Vectara.UpdateMcpToolRequest? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.UpdateMcpToolRequest? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateMcpToolRequest PickMcp() => IsMcp
            ? Mcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        /// Request to update a lambda tool, allowing modifications to code, configuration, and metadata.<br/>
        /// When code is updated, input and output schemas are automatically re-discovered from function parameter type annotations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateLambdaToolRequest? Lambda { get; init; }
#else
        public global::Vectara.UpdateLambdaToolRequest? Lambda { get; }
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
            out global::Vectara.UpdateLambdaToolRequest? value)
        {
            value = Lambda;
            return IsLambda;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateLambdaToolRequest PickLambda() => IsLambda
            ? Lambda!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Lambda' but the value was {ToString()}.");

        /// <summary>
        /// Request to update an existing client tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateClientToolRequest? Client { get; init; }
#else
        public global::Vectara.UpdateClientToolRequest? Client { get; }
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
            out global::Vectara.UpdateClientToolRequest? value)
        {
            value = Client;
            return IsClient;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateClientToolRequest PickClient() => IsClient
            ? Client!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Client' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateToolRequest(global::Vectara.UpdateMcpToolRequest value) => new UpdateToolRequest((global::Vectara.UpdateMcpToolRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateMcpToolRequest?(UpdateToolRequest @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public UpdateToolRequest(global::Vectara.UpdateMcpToolRequest? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateToolRequest FromMcp(global::Vectara.UpdateMcpToolRequest? value) => new UpdateToolRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateToolRequest(global::Vectara.UpdateLambdaToolRequest value) => new UpdateToolRequest((global::Vectara.UpdateLambdaToolRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateLambdaToolRequest?(UpdateToolRequest @this) => @this.Lambda;

        /// <summary>
        /// 
        /// </summary>
        public UpdateToolRequest(global::Vectara.UpdateLambdaToolRequest? value)
        {
            Lambda = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateToolRequest FromLambda(global::Vectara.UpdateLambdaToolRequest? value) => new UpdateToolRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateToolRequest(global::Vectara.UpdateClientToolRequest value) => new UpdateToolRequest((global::Vectara.UpdateClientToolRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateClientToolRequest?(UpdateToolRequest @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public UpdateToolRequest(global::Vectara.UpdateClientToolRequest? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateToolRequest FromClient(global::Vectara.UpdateClientToolRequest? value) => new UpdateToolRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public UpdateToolRequest(
            global::Vectara.UpdateToolRequestDiscriminatorType? type,
            global::Vectara.UpdateMcpToolRequest? mcp,
            global::Vectara.UpdateLambdaToolRequest? lambda,
            global::Vectara.UpdateClientToolRequest? client
            )
        {
            Type = type;

            Mcp = mcp;
            Lambda = lambda;
            Client = client;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Client as object ??
            Lambda as object ??
            Mcp as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Mcp?.ToString() ??
            Lambda?.ToString() ??
            Client?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMcp && !IsLambda && !IsClient || !IsMcp && IsLambda && !IsClient || !IsMcp && !IsLambda && IsClient;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.UpdateMcpToolRequest, TResult>? mcp = null,
            global::System.Func<global::Vectara.UpdateLambdaToolRequest, TResult>? lambda = null,
            global::System.Func<global::Vectara.UpdateClientToolRequest, TResult>? client = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsLambda && lambda != null)
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
            global::System.Action<global::Vectara.UpdateMcpToolRequest>? mcp = null,

            global::System.Action<global::Vectara.UpdateLambdaToolRequest>? lambda = null,

            global::System.Action<global::Vectara.UpdateClientToolRequest>? client = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsLambda)
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
            global::System.Action<global::Vectara.UpdateMcpToolRequest>? mcp = null,
            global::System.Action<global::Vectara.UpdateLambdaToolRequest>? lambda = null,
            global::System.Action<global::Vectara.UpdateClientToolRequest>? client = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsLambda)
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
                Mcp,
                typeof(global::Vectara.UpdateMcpToolRequest),
                Lambda,
                typeof(global::Vectara.UpdateLambdaToolRequest),
                Client,
                typeof(global::Vectara.UpdateClientToolRequest),
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
        public bool Equals(UpdateToolRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateMcpToolRequest?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateLambdaToolRequest?>.Default.Equals(Lambda, other.Lambda) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateClientToolRequest?>.Default.Equals(Client, other.Client) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateToolRequest obj1, UpdateToolRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateToolRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateToolRequest obj1, UpdateToolRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateToolRequest o && Equals(o);
        }
    }
}
