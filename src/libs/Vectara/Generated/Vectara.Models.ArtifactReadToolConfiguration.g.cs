#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for an artifact read tool that reads artifacts from the session workspace.
    /// </summary>
    public readonly partial struct ArtifactReadToolConfiguration : global::System.IEquatable<ArtifactReadToolConfiguration>
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
        public global::Vectara.ArtifactReadToolConfigurationVariant2? ArtifactReadToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.ArtifactReadToolConfigurationVariant2? ArtifactReadToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactReadToolConfigurationVariant2))]
#endif
        public bool IsArtifactReadToolConfigurationVariant2 => ArtifactReadToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickArtifactReadToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ArtifactReadToolConfigurationVariant2? value)
        {
            value = ArtifactReadToolConfigurationVariant2;
            return IsArtifactReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ArtifactReadToolConfigurationVariant2 PickArtifactReadToolConfigurationVariant2() => IsArtifactReadToolConfigurationVariant2
            ? ArtifactReadToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactReadToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactReadToolConfiguration(global::Vectara.ToolConfigurationBase value) => new ArtifactReadToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(ArtifactReadToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactReadToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ArtifactReadToolConfiguration FromBase(global::Vectara.ToolConfigurationBase? value) => new ArtifactReadToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactReadToolConfiguration(global::Vectara.ArtifactReadToolConfigurationVariant2 value) => new ArtifactReadToolConfiguration((global::Vectara.ArtifactReadToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactReadToolConfigurationVariant2?(ArtifactReadToolConfiguration @this) => @this.ArtifactReadToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactReadToolConfiguration(global::Vectara.ArtifactReadToolConfigurationVariant2? value)
        {
            ArtifactReadToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ArtifactReadToolConfiguration FromArtifactReadToolConfigurationVariant2(global::Vectara.ArtifactReadToolConfigurationVariant2? value) => new ArtifactReadToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public ArtifactReadToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.ArtifactReadToolConfigurationVariant2? artifactReadToolConfigurationVariant2
            )
        {
            Base = @base;
            ArtifactReadToolConfigurationVariant2 = artifactReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ArtifactReadToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ArtifactReadToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsArtifactReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.ArtifactReadToolConfigurationVariant2, TResult>? artifactReadToolConfigurationVariant2 = null,
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
            else if (IsArtifactReadToolConfigurationVariant2 && artifactReadToolConfigurationVariant2 != null)
            {
                return artifactReadToolConfigurationVariant2(ArtifactReadToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.ArtifactReadToolConfigurationVariant2>? artifactReadToolConfigurationVariant2 = null,
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
            else if (IsArtifactReadToolConfigurationVariant2)
            {
                artifactReadToolConfigurationVariant2?.Invoke(ArtifactReadToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.ArtifactReadToolConfigurationVariant2>? artifactReadToolConfigurationVariant2 = null,
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
            else if (IsArtifactReadToolConfigurationVariant2)
            {
                artifactReadToolConfigurationVariant2?.Invoke(ArtifactReadToolConfigurationVariant2!);
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
                ArtifactReadToolConfigurationVariant2,
                typeof(global::Vectara.ArtifactReadToolConfigurationVariant2),
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
        public bool Equals(ArtifactReadToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactReadToolConfigurationVariant2?>.Default.Equals(ArtifactReadToolConfigurationVariant2, other.ArtifactReadToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ArtifactReadToolConfiguration obj1, ArtifactReadToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ArtifactReadToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ArtifactReadToolConfiguration obj1, ArtifactReadToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArtifactReadToolConfiguration o && Equals(o);
        }
    }
}
