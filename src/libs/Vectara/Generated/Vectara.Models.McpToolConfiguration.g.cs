#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for an MCP tool that stores predefined argument overrides and settings.
    /// </summary>
    public readonly partial struct McpToolConfiguration : global::System.IEquatable<McpToolConfiguration>
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
        public global::Vectara.McpToolConfigurationVariant2? McpToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.McpToolConfigurationVariant2? McpToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolConfigurationVariant2))]
#endif
        public bool IsMcpToolConfigurationVariant2 => McpToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcpToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.McpToolConfigurationVariant2? value)
        {
            value = McpToolConfigurationVariant2;
            return IsMcpToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.McpToolConfigurationVariant2 PickMcpToolConfigurationVariant2() => IsMcpToolConfigurationVariant2
            ? McpToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpToolConfiguration(global::Vectara.ToolConfigurationBase value) => new McpToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(McpToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public McpToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static McpToolConfiguration FromBase(global::Vectara.ToolConfigurationBase? value) => new McpToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpToolConfiguration(global::Vectara.McpToolConfigurationVariant2 value) => new McpToolConfiguration((global::Vectara.McpToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.McpToolConfigurationVariant2?(McpToolConfiguration @this) => @this.McpToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public McpToolConfiguration(global::Vectara.McpToolConfigurationVariant2? value)
        {
            McpToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static McpToolConfiguration FromMcpToolConfigurationVariant2(global::Vectara.McpToolConfigurationVariant2? value) => new McpToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public McpToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.McpToolConfigurationVariant2? mcpToolConfigurationVariant2
            )
        {
            Base = @base;
            McpToolConfigurationVariant2 = mcpToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            McpToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            McpToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsMcpToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.McpToolConfigurationVariant2, TResult>? mcpToolConfigurationVariant2 = null,
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
            else if (IsMcpToolConfigurationVariant2 && mcpToolConfigurationVariant2 != null)
            {
                return mcpToolConfigurationVariant2(McpToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.McpToolConfigurationVariant2>? mcpToolConfigurationVariant2 = null,
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
            else if (IsMcpToolConfigurationVariant2)
            {
                mcpToolConfigurationVariant2?.Invoke(McpToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.McpToolConfigurationVariant2>? mcpToolConfigurationVariant2 = null,
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
            else if (IsMcpToolConfigurationVariant2)
            {
                mcpToolConfigurationVariant2?.Invoke(McpToolConfigurationVariant2!);
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
                McpToolConfigurationVariant2,
                typeof(global::Vectara.McpToolConfigurationVariant2),
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
        public bool Equals(McpToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.McpToolConfigurationVariant2?>.Default.Equals(McpToolConfigurationVariant2, other.McpToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(McpToolConfiguration obj1, McpToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(McpToolConfiguration obj1, McpToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpToolConfiguration o && Equals(o);
        }
    }
}
