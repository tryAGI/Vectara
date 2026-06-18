#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A client tool configuration.<br/>
    /// When invoked, the agent emits a `tool_input` event and waits for the calling client to submit a matching tool output.<br/>
    /// Only valid inline on an agent; client tools are not reusable across agents.
    /// </summary>
    public readonly partial struct ClientToolConfiguration : global::System.IEquatable<ClientToolConfiguration>
    {
        /// <summary>
        /// Base properties shared by all tool configuration types.<br/>
        /// The identity properties (`key`, `name`, `description`, `enabled`, `metadata`) apply to reusable configurations managed via the `/v2/tool_configurations` endpoints; they are ignored when the configuration is defined inline in an agent's `tool_configurations` map, where the map key is the tool's name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ToolConfigurationBase? Base { get; init; }
#else
        public global::Vectara.ToolConfigurationBase? Base { get; }
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
            out global::Vectara.ToolConfigurationBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ToolConfigurationBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ClientToolConfigurationVariant2? ClientToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.ClientToolConfigurationVariant2? ClientToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolConfigurationVariant2))]
#endif
        public bool IsClientToolConfigurationVariant2 => ClientToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickClientToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ClientToolConfigurationVariant2? value)
        {
            value = ClientToolConfigurationVariant2;
            return IsClientToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ClientToolConfigurationVariant2 PickClientToolConfigurationVariant2() => IsClientToolConfigurationVariant2
            ? ClientToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClientToolConfiguration(global::Vectara.ToolConfigurationBase value) => new ClientToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(ClientToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ClientToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ClientToolConfiguration FromBase(global::Vectara.ToolConfigurationBase? value) => new ClientToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClientToolConfiguration(global::Vectara.ClientToolConfigurationVariant2 value) => new ClientToolConfiguration((global::Vectara.ClientToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ClientToolConfigurationVariant2?(ClientToolConfiguration @this) => @this.ClientToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ClientToolConfiguration(global::Vectara.ClientToolConfigurationVariant2? value)
        {
            ClientToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ClientToolConfiguration FromClientToolConfigurationVariant2(global::Vectara.ClientToolConfigurationVariant2? value) => new ClientToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public ClientToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.ClientToolConfigurationVariant2? clientToolConfigurationVariant2
            )
        {
            Base = @base;
            ClientToolConfigurationVariant2 = clientToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClientToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ClientToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsClientToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.ClientToolConfigurationVariant2, TResult>? clientToolConfigurationVariant2 = null,
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
            else if (IsClientToolConfigurationVariant2 && clientToolConfigurationVariant2 != null)
            {
                return clientToolConfigurationVariant2(ClientToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.ClientToolConfigurationVariant2>? clientToolConfigurationVariant2 = null,
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
            else if (IsClientToolConfigurationVariant2)
            {
                clientToolConfigurationVariant2?.Invoke(ClientToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.ClientToolConfigurationVariant2>? clientToolConfigurationVariant2 = null,
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
            else if (IsClientToolConfigurationVariant2)
            {
                clientToolConfigurationVariant2?.Invoke(ClientToolConfigurationVariant2!);
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
                typeof(global::Vectara.ToolConfigurationBase),
                ClientToolConfigurationVariant2,
                typeof(global::Vectara.ClientToolConfigurationVariant2),
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
        public bool Equals(ClientToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ClientToolConfigurationVariant2?>.Default.Equals(ClientToolConfigurationVariant2, other.ClientToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ClientToolConfiguration obj1, ClientToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ClientToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ClientToolConfiguration obj1, ClientToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ClientToolConfiguration o && Equals(o);
        }
    }
}
