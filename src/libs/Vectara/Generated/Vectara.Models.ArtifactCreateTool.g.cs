#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool that creates artifacts from text or structured data content that can be stored and referenced later.
    /// </summary>
    public readonly partial struct ArtifactCreateTool : global::System.IEquatable<ArtifactCreateTool>
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
        public global::Vectara.ArtifactCreateToolVariant2? ArtifactCreateToolVariant2 { get; init; }
#else
        public global::Vectara.ArtifactCreateToolVariant2? ArtifactCreateToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactCreateToolVariant2))]
#endif
        public bool IsArtifactCreateToolVariant2 => ArtifactCreateToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactCreateTool(global::Vectara.ToolBase value) => new ArtifactCreateTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(ArtifactCreateTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactCreateTool(global::Vectara.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactCreateTool(global::Vectara.ArtifactCreateToolVariant2 value) => new ArtifactCreateTool((global::Vectara.ArtifactCreateToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactCreateToolVariant2?(ArtifactCreateTool @this) => @this.ArtifactCreateToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactCreateTool(global::Vectara.ArtifactCreateToolVariant2? value)
        {
            ArtifactCreateToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ArtifactCreateTool(
            global::Vectara.ToolBase? @base,
            global::Vectara.ArtifactCreateToolVariant2? artifactCreateToolVariant2
            )
        {
            Base = @base;
            ArtifactCreateToolVariant2 = artifactCreateToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ArtifactCreateToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ArtifactCreateToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsArtifactCreateToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.ArtifactCreateToolVariant2?, TResult>? artifactCreateToolVariant2 = null,
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
            else if (IsArtifactCreateToolVariant2 && artifactCreateToolVariant2 != null)
            {
                return artifactCreateToolVariant2(ArtifactCreateToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolBase?>? @base = null,
            global::System.Action<global::Vectara.ArtifactCreateToolVariant2?>? artifactCreateToolVariant2 = null,
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
            else if (IsArtifactCreateToolVariant2)
            {
                artifactCreateToolVariant2?.Invoke(ArtifactCreateToolVariant2!);
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
                ArtifactCreateToolVariant2,
                typeof(global::Vectara.ArtifactCreateToolVariant2),
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
        public bool Equals(ArtifactCreateTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactCreateToolVariant2?>.Default.Equals(ArtifactCreateToolVariant2, other.ArtifactCreateToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ArtifactCreateTool obj1, ArtifactCreateTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ArtifactCreateTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ArtifactCreateTool obj1, ArtifactCreateTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArtifactCreateTool o && Equals(o);
        }
    }
}
