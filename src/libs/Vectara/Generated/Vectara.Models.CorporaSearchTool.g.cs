#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A corpora search tool that searches through Vectara corpora to find relevant information.
    /// </summary>
    public readonly partial struct CorporaSearchTool : global::System.IEquatable<CorporaSearchTool>
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
        public global::Vectara.CorporaSearchToolVariant2? CorporaSearchToolVariant2 { get; init; }
#else
        public global::Vectara.CorporaSearchToolVariant2? CorporaSearchToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CorporaSearchToolVariant2))]
#endif
        public bool IsCorporaSearchToolVariant2 => CorporaSearchToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CorporaSearchTool(global::Vectara.ToolBase value) => new CorporaSearchTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(CorporaSearchTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CorporaSearchTool(global::Vectara.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CorporaSearchTool(global::Vectara.CorporaSearchToolVariant2 value) => new CorporaSearchTool((global::Vectara.CorporaSearchToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CorporaSearchToolVariant2?(CorporaSearchTool @this) => @this.CorporaSearchToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CorporaSearchTool(global::Vectara.CorporaSearchToolVariant2? value)
        {
            CorporaSearchToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CorporaSearchTool(
            global::Vectara.ToolBase? @base,
            global::Vectara.CorporaSearchToolVariant2? corporaSearchToolVariant2
            )
        {
            Base = @base;
            CorporaSearchToolVariant2 = corporaSearchToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CorporaSearchToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CorporaSearchToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCorporaSearchToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.CorporaSearchToolVariant2?, TResult>? corporaSearchToolVariant2 = null,
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
            else if (IsCorporaSearchToolVariant2 && corporaSearchToolVariant2 != null)
            {
                return corporaSearchToolVariant2(CorporaSearchToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolBase?>? @base = null,
            global::System.Action<global::Vectara.CorporaSearchToolVariant2?>? corporaSearchToolVariant2 = null,
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
            else if (IsCorporaSearchToolVariant2)
            {
                corporaSearchToolVariant2?.Invoke(CorporaSearchToolVariant2!);
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
                CorporaSearchToolVariant2,
                typeof(global::Vectara.CorporaSearchToolVariant2),
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
        public bool Equals(CorporaSearchTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CorporaSearchToolVariant2?>.Default.Equals(CorporaSearchToolVariant2, other.CorporaSearchToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CorporaSearchTool obj1, CorporaSearchTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CorporaSearchTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CorporaSearchTool obj1, CorporaSearchTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CorporaSearchTool o && Equals(o);
        }
    }
}
