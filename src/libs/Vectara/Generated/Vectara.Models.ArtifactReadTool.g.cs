#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool that reads artifact content from the agent session workspace with flexible size and range options.
    /// </summary>
    public readonly partial struct ArtifactReadTool : global::System.IEquatable<ArtifactReadTool>
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
        public global::Vectara.ArtifactReadToolVariant2? ArtifactReadToolVariant2 { get; init; }
#else
        public global::Vectara.ArtifactReadToolVariant2? ArtifactReadToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactReadToolVariant2))]
#endif
        public bool IsArtifactReadToolVariant2 => ArtifactReadToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactReadTool(global::Vectara.ToolBase value) => new ArtifactReadTool((global::Vectara.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolBase?(ArtifactReadTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactReadTool(global::Vectara.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactReadTool(global::Vectara.ArtifactReadToolVariant2 value) => new ArtifactReadTool((global::Vectara.ArtifactReadToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactReadToolVariant2?(ArtifactReadTool @this) => @this.ArtifactReadToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactReadTool(global::Vectara.ArtifactReadToolVariant2? value)
        {
            ArtifactReadToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ArtifactReadTool(
            global::Vectara.ToolBase? @base,
            global::Vectara.ArtifactReadToolVariant2? artifactReadToolVariant2
            )
        {
            Base = @base;
            ArtifactReadToolVariant2 = artifactReadToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ArtifactReadToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ArtifactReadToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsArtifactReadToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.ArtifactReadToolVariant2?, TResult>? artifactReadToolVariant2 = null,
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
            else if (IsArtifactReadToolVariant2 && artifactReadToolVariant2 != null)
            {
                return artifactReadToolVariant2(ArtifactReadToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolBase?>? @base = null,
            global::System.Action<global::Vectara.ArtifactReadToolVariant2?>? artifactReadToolVariant2 = null,
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
            else if (IsArtifactReadToolVariant2)
            {
                artifactReadToolVariant2?.Invoke(ArtifactReadToolVariant2!);
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
                ArtifactReadToolVariant2,
                typeof(global::Vectara.ArtifactReadToolVariant2),
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
        public bool Equals(ArtifactReadTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactReadToolVariant2?>.Default.Equals(ArtifactReadToolVariant2, other.ArtifactReadToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ArtifactReadTool obj1, ArtifactReadTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ArtifactReadTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ArtifactReadTool obj1, ArtifactReadTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArtifactReadTool o && Equals(o);
        }
    }
}
