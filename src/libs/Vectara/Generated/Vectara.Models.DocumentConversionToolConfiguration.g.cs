#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for a document conversion tool that converts document artifacts to various formats.
    /// </summary>
    public readonly partial struct DocumentConversionToolConfiguration : global::System.IEquatable<DocumentConversionToolConfiguration>
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
        public global::Vectara.DocumentConversionToolConfigurationVariant2? DocumentConversionToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.DocumentConversionToolConfigurationVariant2? DocumentConversionToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentConversionToolConfigurationVariant2))]
#endif
        public bool IsDocumentConversionToolConfigurationVariant2 => DocumentConversionToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentConversionToolConfiguration(global::Vectara.ToolConfigurationBase value) => new DocumentConversionToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(DocumentConversionToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DocumentConversionToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentConversionToolConfiguration(global::Vectara.DocumentConversionToolConfigurationVariant2 value) => new DocumentConversionToolConfiguration((global::Vectara.DocumentConversionToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DocumentConversionToolConfigurationVariant2?(DocumentConversionToolConfiguration @this) => @this.DocumentConversionToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DocumentConversionToolConfiguration(global::Vectara.DocumentConversionToolConfigurationVariant2? value)
        {
            DocumentConversionToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentConversionToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.DocumentConversionToolConfigurationVariant2? documentConversionToolConfigurationVariant2
            )
        {
            Base = @base;
            DocumentConversionToolConfigurationVariant2 = documentConversionToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DocumentConversionToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            DocumentConversionToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsDocumentConversionToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.DocumentConversionToolConfigurationVariant2?, TResult>? documentConversionToolConfigurationVariant2 = null,
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
            else if (IsDocumentConversionToolConfigurationVariant2 && documentConversionToolConfigurationVariant2 != null)
            {
                return documentConversionToolConfigurationVariant2(DocumentConversionToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase?>? @base = null,
            global::System.Action<global::Vectara.DocumentConversionToolConfigurationVariant2?>? documentConversionToolConfigurationVariant2 = null,
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
            else if (IsDocumentConversionToolConfigurationVariant2)
            {
                documentConversionToolConfigurationVariant2?.Invoke(DocumentConversionToolConfigurationVariant2!);
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
                DocumentConversionToolConfigurationVariant2,
                typeof(global::Vectara.DocumentConversionToolConfigurationVariant2),
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
        public bool Equals(DocumentConversionToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DocumentConversionToolConfigurationVariant2?>.Default.Equals(DocumentConversionToolConfigurationVariant2, other.DocumentConversionToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DocumentConversionToolConfiguration obj1, DocumentConversionToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DocumentConversionToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DocumentConversionToolConfiguration obj1, DocumentConversionToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DocumentConversionToolConfiguration o && Equals(o);
        }
    }
}
