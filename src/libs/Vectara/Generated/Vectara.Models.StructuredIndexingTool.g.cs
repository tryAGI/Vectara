#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool that indexes structured documents into the Vectara platform with full control over document structure, sections, metadata, tables, and images.
    /// </summary>
    public readonly partial struct StructuredIndexingTool : global::System.IEquatable<StructuredIndexingTool>
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
        public global::Vectara.StructuredIndexingToolVariant2? StructuredIndexingToolVariant2 { get; init; }
#else
        public global::Vectara.StructuredIndexingToolVariant2? StructuredIndexingToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StructuredIndexingToolVariant2))]
#endif
        public bool IsStructuredIndexingToolVariant2 => StructuredIndexingToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StructuredIndexingTool(global::Vectara.ToolBase value) => new StructuredIndexingTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(StructuredIndexingTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public StructuredIndexingTool(global::Vectara.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StructuredIndexingTool(global::Vectara.StructuredIndexingToolVariant2 value) => new StructuredIndexingTool((global::Vectara.StructuredIndexingToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StructuredIndexingToolVariant2?(StructuredIndexingTool @this) => @this.StructuredIndexingToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StructuredIndexingTool(global::Vectara.StructuredIndexingToolVariant2? value)
        {
            StructuredIndexingToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StructuredIndexingTool(
            global::Vectara.ToolBase? @base,
            global::Vectara.StructuredIndexingToolVariant2? structuredIndexingToolVariant2
            )
        {
            Base = @base;
            StructuredIndexingToolVariant2 = structuredIndexingToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StructuredIndexingToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            StructuredIndexingToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsStructuredIndexingToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.StructuredIndexingToolVariant2?, TResult>? structuredIndexingToolVariant2 = null,
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
            else if (IsStructuredIndexingToolVariant2 && structuredIndexingToolVariant2 != null)
            {
                return structuredIndexingToolVariant2(StructuredIndexingToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolBase?>? @base = null,
            global::System.Action<global::Vectara.StructuredIndexingToolVariant2?>? structuredIndexingToolVariant2 = null,
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
            else if (IsStructuredIndexingToolVariant2)
            {
                structuredIndexingToolVariant2?.Invoke(StructuredIndexingToolVariant2!);
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
                StructuredIndexingToolVariant2,
                typeof(global::Vectara.StructuredIndexingToolVariant2),
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
        public bool Equals(StructuredIndexingTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StructuredIndexingToolVariant2?>.Default.Equals(StructuredIndexingToolVariant2, other.StructuredIndexingToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StructuredIndexingTool obj1, StructuredIndexingTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StructuredIndexingTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StructuredIndexingTool obj1, StructuredIndexingTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StructuredIndexingTool o && Equals(o);
        }
    }
}
