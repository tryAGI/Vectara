#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool that loads image artifacts into the conversation context for viewing and analysis.
    /// </summary>
    public readonly partial struct ImageReadTool : global::System.IEquatable<ImageReadTool>
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
        public global::Vectara.ImageReadToolVariant2? ImageReadToolVariant2 { get; init; }
#else
        public global::Vectara.ImageReadToolVariant2? ImageReadToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageReadToolVariant2))]
#endif
        public bool IsImageReadToolVariant2 => ImageReadToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageReadTool(global::Vectara.ToolBase value) => new ImageReadTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(ImageReadTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ImageReadTool(global::Vectara.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageReadTool(global::Vectara.ImageReadToolVariant2 value) => new ImageReadTool((global::Vectara.ImageReadToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageReadToolVariant2?(ImageReadTool @this) => @this.ImageReadToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageReadTool(global::Vectara.ImageReadToolVariant2? value)
        {
            ImageReadToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageReadTool(
            global::Vectara.ToolBase? @base,
            global::Vectara.ImageReadToolVariant2? imageReadToolVariant2
            )
        {
            Base = @base;
            ImageReadToolVariant2 = imageReadToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageReadToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ImageReadToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsImageReadToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.ImageReadToolVariant2?, TResult>? imageReadToolVariant2 = null,
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
            else if (IsImageReadToolVariant2 && imageReadToolVariant2 != null)
            {
                return imageReadToolVariant2(ImageReadToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolBase?>? @base = null,
            global::System.Action<global::Vectara.ImageReadToolVariant2?>? imageReadToolVariant2 = null,
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
            else if (IsImageReadToolVariant2)
            {
                imageReadToolVariant2?.Invoke(ImageReadToolVariant2!);
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
                ImageReadToolVariant2,
                typeof(global::Vectara.ImageReadToolVariant2),
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
        public bool Equals(ImageReadTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageReadToolVariant2?>.Default.Equals(ImageReadToolVariant2, other.ImageReadToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageReadTool obj1, ImageReadTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageReadTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageReadTool obj1, ImageReadTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageReadTool o && Equals(o);
        }
    }
}
