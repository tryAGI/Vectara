#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for an artifact grep tool that searches through artifact content.
    /// </summary>
    public readonly partial struct ArtifactGrepToolConfiguration : global::System.IEquatable<ArtifactGrepToolConfiguration>
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
        public global::Vectara.ArtifactGrepToolConfigurationVariant2? ArtifactGrepToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.ArtifactGrepToolConfigurationVariant2? ArtifactGrepToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactGrepToolConfigurationVariant2))]
#endif
        public bool IsArtifactGrepToolConfigurationVariant2 => ArtifactGrepToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickArtifactGrepToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ArtifactGrepToolConfigurationVariant2? value)
        {
            value = ArtifactGrepToolConfigurationVariant2;
            return IsArtifactGrepToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ArtifactGrepToolConfigurationVariant2 PickArtifactGrepToolConfigurationVariant2() => IsArtifactGrepToolConfigurationVariant2
            ? ArtifactGrepToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactGrepToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactGrepToolConfiguration(global::Vectara.ToolConfigurationBase value) => new ArtifactGrepToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(ArtifactGrepToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactGrepToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ArtifactGrepToolConfiguration FromBase(global::Vectara.ToolConfigurationBase? value) => new ArtifactGrepToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactGrepToolConfiguration(global::Vectara.ArtifactGrepToolConfigurationVariant2 value) => new ArtifactGrepToolConfiguration((global::Vectara.ArtifactGrepToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactGrepToolConfigurationVariant2?(ArtifactGrepToolConfiguration @this) => @this.ArtifactGrepToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactGrepToolConfiguration(global::Vectara.ArtifactGrepToolConfigurationVariant2? value)
        {
            ArtifactGrepToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ArtifactGrepToolConfiguration FromArtifactGrepToolConfigurationVariant2(global::Vectara.ArtifactGrepToolConfigurationVariant2? value) => new ArtifactGrepToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public ArtifactGrepToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.ArtifactGrepToolConfigurationVariant2? artifactGrepToolConfigurationVariant2
            )
        {
            Base = @base;
            ArtifactGrepToolConfigurationVariant2 = artifactGrepToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ArtifactGrepToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ArtifactGrepToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsArtifactGrepToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.ArtifactGrepToolConfigurationVariant2, TResult>? artifactGrepToolConfigurationVariant2 = null,
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
            else if (IsArtifactGrepToolConfigurationVariant2 && artifactGrepToolConfigurationVariant2 != null)
            {
                return artifactGrepToolConfigurationVariant2(ArtifactGrepToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.ArtifactGrepToolConfigurationVariant2>? artifactGrepToolConfigurationVariant2 = null,
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
            else if (IsArtifactGrepToolConfigurationVariant2)
            {
                artifactGrepToolConfigurationVariant2?.Invoke(ArtifactGrepToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.ArtifactGrepToolConfigurationVariant2>? artifactGrepToolConfigurationVariant2 = null,
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
            else if (IsArtifactGrepToolConfigurationVariant2)
            {
                artifactGrepToolConfigurationVariant2?.Invoke(ArtifactGrepToolConfigurationVariant2!);
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
                ArtifactGrepToolConfigurationVariant2,
                typeof(global::Vectara.ArtifactGrepToolConfigurationVariant2),
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
        public bool Equals(ArtifactGrepToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactGrepToolConfigurationVariant2?>.Default.Equals(ArtifactGrepToolConfigurationVariant2, other.ArtifactGrepToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ArtifactGrepToolConfiguration obj1, ArtifactGrepToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ArtifactGrepToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ArtifactGrepToolConfiguration obj1, ArtifactGrepToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArtifactGrepToolConfiguration o && Equals(o);
        }
    }
}
