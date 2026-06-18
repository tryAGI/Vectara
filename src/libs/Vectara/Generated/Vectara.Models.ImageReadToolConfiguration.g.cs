#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for an image read tool that loads images into the conversation context.
    /// </summary>
    public readonly partial struct ImageReadToolConfiguration : global::System.IEquatable<ImageReadToolConfiguration>
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
        public global::Vectara.ImageReadToolConfigurationVariant2? ImageReadToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.ImageReadToolConfigurationVariant2? ImageReadToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageReadToolConfigurationVariant2))]
#endif
        public bool IsImageReadToolConfigurationVariant2 => ImageReadToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageReadToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ImageReadToolConfigurationVariant2? value)
        {
            value = ImageReadToolConfigurationVariant2;
            return IsImageReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ImageReadToolConfigurationVariant2 PickImageReadToolConfigurationVariant2() => IsImageReadToolConfigurationVariant2
            ? ImageReadToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageReadToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageReadToolConfiguration(global::Vectara.ToolConfigurationBase value) => new ImageReadToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(ImageReadToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ImageReadToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageReadToolConfiguration FromBase(global::Vectara.ToolConfigurationBase? value) => new ImageReadToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageReadToolConfiguration(global::Vectara.ImageReadToolConfigurationVariant2 value) => new ImageReadToolConfiguration((global::Vectara.ImageReadToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageReadToolConfigurationVariant2?(ImageReadToolConfiguration @this) => @this.ImageReadToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageReadToolConfiguration(global::Vectara.ImageReadToolConfigurationVariant2? value)
        {
            ImageReadToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageReadToolConfiguration FromImageReadToolConfigurationVariant2(global::Vectara.ImageReadToolConfigurationVariant2? value) => new ImageReadToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public ImageReadToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.ImageReadToolConfigurationVariant2? imageReadToolConfigurationVariant2
            )
        {
            Base = @base;
            ImageReadToolConfigurationVariant2 = imageReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageReadToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ImageReadToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsImageReadToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.ImageReadToolConfigurationVariant2, TResult>? imageReadToolConfigurationVariant2 = null,
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
            else if (IsImageReadToolConfigurationVariant2 && imageReadToolConfigurationVariant2 != null)
            {
                return imageReadToolConfigurationVariant2(ImageReadToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.ImageReadToolConfigurationVariant2>? imageReadToolConfigurationVariant2 = null,
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
            else if (IsImageReadToolConfigurationVariant2)
            {
                imageReadToolConfigurationVariant2?.Invoke(ImageReadToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.ImageReadToolConfigurationVariant2>? imageReadToolConfigurationVariant2 = null,
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
            else if (IsImageReadToolConfigurationVariant2)
            {
                imageReadToolConfigurationVariant2?.Invoke(ImageReadToolConfigurationVariant2!);
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
                ImageReadToolConfigurationVariant2,
                typeof(global::Vectara.ImageReadToolConfigurationVariant2),
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
        public bool Equals(ImageReadToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageReadToolConfigurationVariant2?>.Default.Equals(ImageReadToolConfigurationVariant2, other.ImageReadToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageReadToolConfiguration obj1, ImageReadToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageReadToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageReadToolConfiguration obj1, ImageReadToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageReadToolConfiguration o && Equals(o);
        }
    }
}
