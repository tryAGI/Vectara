#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for a web get tool that stores predefined parameters for fetching content from URLs.
    /// </summary>
    public readonly partial struct WebGetToolConfiguration : global::System.IEquatable<WebGetToolConfiguration>
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
        public global::Vectara.WebGetToolConfigurationVariant2? WebGetToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.WebGetToolConfigurationVariant2? WebGetToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebGetToolConfigurationVariant2))]
#endif
        public bool IsWebGetToolConfigurationVariant2 => WebGetToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebGetToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WebGetToolConfigurationVariant2? value)
        {
            value = WebGetToolConfigurationVariant2;
            return IsWebGetToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.WebGetToolConfigurationVariant2 PickWebGetToolConfigurationVariant2() => IsWebGetToolConfigurationVariant2
            ? WebGetToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebGetToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebGetToolConfiguration(global::Vectara.ToolConfigurationBase value) => new WebGetToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(WebGetToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public WebGetToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebGetToolConfiguration FromBase(global::Vectara.ToolConfigurationBase? value) => new WebGetToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebGetToolConfiguration(global::Vectara.WebGetToolConfigurationVariant2 value) => new WebGetToolConfiguration((global::Vectara.WebGetToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WebGetToolConfigurationVariant2?(WebGetToolConfiguration @this) => @this.WebGetToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WebGetToolConfiguration(global::Vectara.WebGetToolConfigurationVariant2? value)
        {
            WebGetToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebGetToolConfiguration FromWebGetToolConfigurationVariant2(global::Vectara.WebGetToolConfigurationVariant2? value) => new WebGetToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public WebGetToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.WebGetToolConfigurationVariant2? webGetToolConfigurationVariant2
            )
        {
            Base = @base;
            WebGetToolConfigurationVariant2 = webGetToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebGetToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WebGetToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWebGetToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.WebGetToolConfigurationVariant2, TResult>? webGetToolConfigurationVariant2 = null,
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
            else if (IsWebGetToolConfigurationVariant2 && webGetToolConfigurationVariant2 != null)
            {
                return webGetToolConfigurationVariant2(WebGetToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.WebGetToolConfigurationVariant2>? webGetToolConfigurationVariant2 = null,
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
            else if (IsWebGetToolConfigurationVariant2)
            {
                webGetToolConfigurationVariant2?.Invoke(WebGetToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.WebGetToolConfigurationVariant2>? webGetToolConfigurationVariant2 = null,
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
            else if (IsWebGetToolConfigurationVariant2)
            {
                webGetToolConfigurationVariant2?.Invoke(WebGetToolConfigurationVariant2!);
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
                WebGetToolConfigurationVariant2,
                typeof(global::Vectara.WebGetToolConfigurationVariant2),
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
        public bool Equals(WebGetToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebGetToolConfigurationVariant2?>.Default.Equals(WebGetToolConfigurationVariant2, other.WebGetToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebGetToolConfiguration obj1, WebGetToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebGetToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebGetToolConfiguration obj1, WebGetToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebGetToolConfiguration o && Equals(o);
        }
    }
}
