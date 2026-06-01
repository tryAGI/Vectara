#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool whose execution is performed by the calling client. When invoked, the platform emits a `tool_input` event with the tool call arguments. The client submits the result as a `tool_output` input via `createAgentInput`.
    /// </summary>
    public readonly partial struct ClientTool : global::System.IEquatable<ClientTool>
    {
        /// <summary>
        /// Base properties shared by all tool types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ToolBase? Base { get; init; }
#else
        public global::Vectara.ToolBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ToolBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ToolBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ClientToolVariant2? ClientToolVariant2 { get; init; }
#else
        public global::Vectara.ClientToolVariant2? ClientToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolVariant2))]
#endif
        public bool IsClientToolVariant2 => ClientToolVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickClientToolVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ClientToolVariant2? value)
        {
            value = ClientToolVariant2;
            return IsClientToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ClientToolVariant2 PickClientToolVariant2() => IsClientToolVariant2
            ? ClientToolVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientToolVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClientTool(global::Vectara.ToolBase value) => new ClientTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(ClientTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ClientTool(global::Vectara.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ClientTool FromBase(global::Vectara.ToolBase? value) => new ClientTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClientTool(global::Vectara.ClientToolVariant2 value) => new ClientTool((global::Vectara.ClientToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ClientToolVariant2?(ClientTool @this) => @this.ClientToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ClientTool(global::Vectara.ClientToolVariant2? value)
        {
            ClientToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ClientTool FromClientToolVariant2(global::Vectara.ClientToolVariant2? value) => new ClientTool(value);

        /// <summary>
        /// 
        /// </summary>
        public ClientTool(
            global::Vectara.ToolBase? @base,
            global::Vectara.ClientToolVariant2? clientToolVariant2
            )
        {
            Base = @base;
            ClientToolVariant2 = clientToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClientToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ClientToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsClientToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolBase, TResult>? @base = null,
            global::System.Func<global::Vectara.ClientToolVariant2, TResult>? clientToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsClientToolVariant2 && clientToolVariant2 != null)
            {
                return clientToolVariant2(ClientToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolBase>? @base = null,

            global::System.Action<global::Vectara.ClientToolVariant2>? clientToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsClientToolVariant2)
            {
                clientToolVariant2?.Invoke(ClientToolVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolBase>? @base = null,
            global::System.Action<global::Vectara.ClientToolVariant2>? clientToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsClientToolVariant2)
            {
                clientToolVariant2?.Invoke(ClientToolVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Vectara.ToolBase),
                ClientToolVariant2,
                typeof(global::Vectara.ClientToolVariant2),
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
        public bool Equals(ClientTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ClientToolVariant2?>.Default.Equals(ClientToolVariant2, other.ClientToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ClientTool obj1, ClientTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ClientTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ClientTool obj1, ClientTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ClientTool o && Equals(o);
        }
    }
}
