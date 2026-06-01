#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Delivers outputs for `tool_input` events emitted by a prior client tool invocation. Submit one<br/>
    /// entry per pending event ID listed in the `client_tool_pending` event.
    /// </summary>
    public readonly partial struct ClientToolOutputRequest : global::System.IEquatable<ClientToolOutputRequest>
    {
        /// <summary>
        /// Base properties shared by all input request types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateInputRequestBase? CreateInputBase { get; init; }
#else
        public global::Vectara.CreateInputRequestBase? CreateInputBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateInputBase))]
#endif
        public bool IsCreateInputBase => CreateInputBase != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateInputBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateInputRequestBase? value)
        {
            value = CreateInputBase;
            return IsCreateInputBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateInputRequestBase PickCreateInputBase() => IsCreateInputBase
            ? CreateInputBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateInputBase' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ClientToolOutputRequestVariant2? ClientToolOutputRequestVariant2 { get; init; }
#else
        public global::Vectara.ClientToolOutputRequestVariant2? ClientToolOutputRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolOutputRequestVariant2))]
#endif
        public bool IsClientToolOutputRequestVariant2 => ClientToolOutputRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickClientToolOutputRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ClientToolOutputRequestVariant2? value)
        {
            value = ClientToolOutputRequestVariant2;
            return IsClientToolOutputRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ClientToolOutputRequestVariant2 PickClientToolOutputRequestVariant2() => IsClientToolOutputRequestVariant2
            ? ClientToolOutputRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientToolOutputRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClientToolOutputRequest(global::Vectara.CreateInputRequestBase value) => new ClientToolOutputRequest((global::Vectara.CreateInputRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateInputRequestBase?(ClientToolOutputRequest @this) => @this.CreateInputBase;

        /// <summary>
        /// 
        /// </summary>
        public ClientToolOutputRequest(global::Vectara.CreateInputRequestBase? value)
        {
            CreateInputBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ClientToolOutputRequest FromCreateInputBase(global::Vectara.CreateInputRequestBase? value) => new ClientToolOutputRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClientToolOutputRequest(global::Vectara.ClientToolOutputRequestVariant2 value) => new ClientToolOutputRequest((global::Vectara.ClientToolOutputRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ClientToolOutputRequestVariant2?(ClientToolOutputRequest @this) => @this.ClientToolOutputRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ClientToolOutputRequest(global::Vectara.ClientToolOutputRequestVariant2? value)
        {
            ClientToolOutputRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ClientToolOutputRequest FromClientToolOutputRequestVariant2(global::Vectara.ClientToolOutputRequestVariant2? value) => new ClientToolOutputRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public ClientToolOutputRequest(
            global::Vectara.CreateInputRequestBase? createInputBase,
            global::Vectara.ClientToolOutputRequestVariant2? clientToolOutputRequestVariant2
            )
        {
            CreateInputBase = createInputBase;
            ClientToolOutputRequestVariant2 = clientToolOutputRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClientToolOutputRequestVariant2 as object ??
            CreateInputBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateInputBase?.ToString() ??
            ClientToolOutputRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateInputBase && IsClientToolOutputRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateInputRequestBase, TResult>? createInputBase = null,
            global::System.Func<global::Vectara.ClientToolOutputRequestVariant2, TResult>? clientToolOutputRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateInputBase && createInputBase != null)
            {
                return createInputBase(CreateInputBase!);
            }
            else if (IsClientToolOutputRequestVariant2 && clientToolOutputRequestVariant2 != null)
            {
                return clientToolOutputRequestVariant2(ClientToolOutputRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateInputRequestBase>? createInputBase = null,

            global::System.Action<global::Vectara.ClientToolOutputRequestVariant2>? clientToolOutputRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateInputBase)
            {
                createInputBase?.Invoke(CreateInputBase!);
            }
            else if (IsClientToolOutputRequestVariant2)
            {
                clientToolOutputRequestVariant2?.Invoke(ClientToolOutputRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateInputRequestBase>? createInputBase = null,
            global::System.Action<global::Vectara.ClientToolOutputRequestVariant2>? clientToolOutputRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateInputBase)
            {
                createInputBase?.Invoke(CreateInputBase!);
            }
            else if (IsClientToolOutputRequestVariant2)
            {
                clientToolOutputRequestVariant2?.Invoke(ClientToolOutputRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateInputBase,
                typeof(global::Vectara.CreateInputRequestBase),
                ClientToolOutputRequestVariant2,
                typeof(global::Vectara.ClientToolOutputRequestVariant2),
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
        public bool Equals(ClientToolOutputRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateInputRequestBase?>.Default.Equals(CreateInputBase, other.CreateInputBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ClientToolOutputRequestVariant2?>.Default.Equals(ClientToolOutputRequestVariant2, other.ClientToolOutputRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ClientToolOutputRequest obj1, ClientToolOutputRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ClientToolOutputRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ClientToolOutputRequest obj1, ClientToolOutputRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ClientToolOutputRequest o && Equals(o);
        }
    }
}
