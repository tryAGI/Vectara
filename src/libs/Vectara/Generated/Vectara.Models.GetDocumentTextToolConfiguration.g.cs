#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for a get document text tool that fetches document text content from a corpus.
    /// </summary>
    public readonly partial struct GetDocumentTextToolConfiguration : global::System.IEquatable<GetDocumentTextToolConfiguration>
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
        public global::Vectara.GetDocumentTextToolConfigurationVariant2? GetDocumentTextToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.GetDocumentTextToolConfigurationVariant2? GetDocumentTextToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetDocumentTextToolConfigurationVariant2))]
#endif
        public bool IsGetDocumentTextToolConfigurationVariant2 => GetDocumentTextToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetDocumentTextToolConfiguration(global::Vectara.ToolConfigurationBase value) => new GetDocumentTextToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(GetDocumentTextToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public GetDocumentTextToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetDocumentTextToolConfiguration(global::Vectara.GetDocumentTextToolConfigurationVariant2 value) => new GetDocumentTextToolConfiguration((global::Vectara.GetDocumentTextToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GetDocumentTextToolConfigurationVariant2?(GetDocumentTextToolConfiguration @this) => @this.GetDocumentTextToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GetDocumentTextToolConfiguration(global::Vectara.GetDocumentTextToolConfigurationVariant2? value)
        {
            GetDocumentTextToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetDocumentTextToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.GetDocumentTextToolConfigurationVariant2? getDocumentTextToolConfigurationVariant2
            )
        {
            Base = @base;
            GetDocumentTextToolConfigurationVariant2 = getDocumentTextToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetDocumentTextToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GetDocumentTextToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGetDocumentTextToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.GetDocumentTextToolConfigurationVariant2?, TResult>? getDocumentTextToolConfigurationVariant2 = null,
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
            else if (IsGetDocumentTextToolConfigurationVariant2 && getDocumentTextToolConfigurationVariant2 != null)
            {
                return getDocumentTextToolConfigurationVariant2(GetDocumentTextToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase?>? @base = null,
            global::System.Action<global::Vectara.GetDocumentTextToolConfigurationVariant2?>? getDocumentTextToolConfigurationVariant2 = null,
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
            else if (IsGetDocumentTextToolConfigurationVariant2)
            {
                getDocumentTextToolConfigurationVariant2?.Invoke(GetDocumentTextToolConfigurationVariant2!);
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
                GetDocumentTextToolConfigurationVariant2,
                typeof(global::Vectara.GetDocumentTextToolConfigurationVariant2),
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
        public bool Equals(GetDocumentTextToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GetDocumentTextToolConfigurationVariant2?>.Default.Equals(GetDocumentTextToolConfigurationVariant2, other.GetDocumentTextToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetDocumentTextToolConfiguration obj1, GetDocumentTextToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetDocumentTextToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetDocumentTextToolConfiguration obj1, GetDocumentTextToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetDocumentTextToolConfiguration o && Equals(o);
        }
    }
}
