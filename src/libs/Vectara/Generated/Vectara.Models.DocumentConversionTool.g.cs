#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool that converts document artifacts (PDF, Word, PowerPoint, etc.) to various formats.
    /// </summary>
    public readonly partial struct DocumentConversionTool : global::System.IEquatable<DocumentConversionTool>
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
#if NET6_0_OR_GREATER
        public global::Vectara.DocumentConversionToolVariant2? DocumentConversionToolVariant2 { get; init; }
#else
        public global::Vectara.DocumentConversionToolVariant2? DocumentConversionToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentConversionToolVariant2))]
#endif
        public bool IsDocumentConversionToolVariant2 => DocumentConversionToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentConversionTool(global::Vectara.ToolBase value) => new DocumentConversionTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(DocumentConversionTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DocumentConversionTool(global::Vectara.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentConversionTool(global::Vectara.DocumentConversionToolVariant2 value) => new DocumentConversionTool((global::Vectara.DocumentConversionToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DocumentConversionToolVariant2?(DocumentConversionTool @this) => @this.DocumentConversionToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DocumentConversionTool(global::Vectara.DocumentConversionToolVariant2? value)
        {
            DocumentConversionToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentConversionTool(
            global::Vectara.ToolBase? @base,
            global::Vectara.DocumentConversionToolVariant2? documentConversionToolVariant2
            )
        {
            Base = @base;
            DocumentConversionToolVariant2 = documentConversionToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DocumentConversionToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            DocumentConversionToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsDocumentConversionToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.DocumentConversionToolVariant2?, TResult>? documentConversionToolVariant2 = null,
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
            else if (IsDocumentConversionToolVariant2 && documentConversionToolVariant2 != null)
            {
                return documentConversionToolVariant2(DocumentConversionToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolBase?>? @base = null,
            global::System.Action<global::Vectara.DocumentConversionToolVariant2?>? documentConversionToolVariant2 = null,
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
            else if (IsDocumentConversionToolVariant2)
            {
                documentConversionToolVariant2?.Invoke(DocumentConversionToolVariant2!);
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
                DocumentConversionToolVariant2,
                typeof(global::Vectara.DocumentConversionToolVariant2),
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
        public bool Equals(DocumentConversionTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DocumentConversionToolVariant2?>.Default.Equals(DocumentConversionToolVariant2, other.DocumentConversionToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DocumentConversionTool obj1, DocumentConversionTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DocumentConversionTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DocumentConversionTool obj1, DocumentConversionTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DocumentConversionTool o && Equals(o);
        }
    }
}
