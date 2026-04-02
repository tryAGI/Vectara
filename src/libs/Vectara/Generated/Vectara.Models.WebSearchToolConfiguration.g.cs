#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for a web search tool that stores predefined search parameters and settings.
    /// </summary>
    public readonly partial struct WebSearchToolConfiguration : global::System.IEquatable<WebSearchToolConfiguration>
    {
        /// <summary>
        /// Base properties shared by all tool configuration types.
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
#if NET6_0_OR_GREATER
        public global::Vectara.WebSearchToolConfigurationVariant2? WebSearchToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.WebSearchToolConfigurationVariant2? WebSearchToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchToolConfigurationVariant2))]
#endif
        public bool IsWebSearchToolConfigurationVariant2 => WebSearchToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSearchToolConfiguration(global::Vectara.ToolConfigurationBase value) => new WebSearchToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(WebSearchToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSearchToolConfiguration(global::Vectara.WebSearchToolConfigurationVariant2 value) => new WebSearchToolConfiguration((global::Vectara.WebSearchToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WebSearchToolConfigurationVariant2?(WebSearchToolConfiguration @this) => @this.WebSearchToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolConfiguration(global::Vectara.WebSearchToolConfigurationVariant2? value)
        {
            WebSearchToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.WebSearchToolConfigurationVariant2? webSearchToolConfigurationVariant2
            )
        {
            Base = @base;
            WebSearchToolConfigurationVariant2 = webSearchToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearchToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WebSearchToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWebSearchToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.WebSearchToolConfigurationVariant2?, TResult>? webSearchToolConfigurationVariant2 = null,
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
            else if (IsWebSearchToolConfigurationVariant2 && webSearchToolConfigurationVariant2 != null)
            {
                return webSearchToolConfigurationVariant2(WebSearchToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase?>? @base = null,
            global::System.Action<global::Vectara.WebSearchToolConfigurationVariant2?>? webSearchToolConfigurationVariant2 = null,
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
            else if (IsWebSearchToolConfigurationVariant2)
            {
                webSearchToolConfigurationVariant2?.Invoke(WebSearchToolConfigurationVariant2!);
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
                WebSearchToolConfigurationVariant2,
                typeof(global::Vectara.WebSearchToolConfigurationVariant2),
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
        public bool Equals(WebSearchToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebSearchToolConfigurationVariant2?>.Default.Equals(WebSearchToolConfigurationVariant2, other.WebSearchToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebSearchToolConfiguration obj1, WebSearchToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSearchToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebSearchToolConfiguration obj1, WebSearchToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchToolConfiguration o && Equals(o);
        }
    }
}
