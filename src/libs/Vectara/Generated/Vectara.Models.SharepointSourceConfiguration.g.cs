#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting documents from a SharePoint site.
    /// </summary>
    public readonly partial struct SharepointSourceConfiguration : global::System.IEquatable<SharepointSourceConfiguration>
    {
        /// <summary>
        /// Base SharePoint source configuration with all fields optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseSharepointSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseSharepointSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseSharepointSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseSharepointSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? SharepointSourceConfigurationVariant2 { get; init; }
#else
        public object? SharepointSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SharepointSourceConfigurationVariant2))]
#endif
        public bool IsSharepointSourceConfigurationVariant2 => SharepointSourceConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSharepointSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = SharepointSourceConfigurationVariant2;
            return IsSharepointSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickSharepointSourceConfigurationVariant2() => IsSharepointSourceConfigurationVariant2
            ? SharepointSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SharepointSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SharepointSourceConfiguration(global::Vectara.BaseSharepointSourceConfiguration value) => new SharepointSourceConfiguration((global::Vectara.BaseSharepointSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseSharepointSourceConfiguration?(SharepointSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SharepointSourceConfiguration(global::Vectara.BaseSharepointSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SharepointSourceConfiguration FromBase(global::Vectara.BaseSharepointSourceConfiguration? value) => new SharepointSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public SharepointSourceConfiguration(
            global::Vectara.BaseSharepointSourceConfiguration? @base,
            object? sharepointSourceConfigurationVariant2
            )
        {
            Base = @base;
            SharepointSourceConfigurationVariant2 = sharepointSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SharepointSourceConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SharepointSourceConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSharepointSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseSharepointSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? sharepointSourceConfigurationVariant2 = null,
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
            else if (IsSharepointSourceConfigurationVariant2 && sharepointSourceConfigurationVariant2 != null)
            {
                return sharepointSourceConfigurationVariant2(SharepointSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseSharepointSourceConfiguration>? @base = null,

            global::System.Action<object>? sharepointSourceConfigurationVariant2 = null,
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
            else if (IsSharepointSourceConfigurationVariant2)
            {
                sharepointSourceConfigurationVariant2?.Invoke(SharepointSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseSharepointSourceConfiguration>? @base = null,
            global::System.Action<object>? sharepointSourceConfigurationVariant2 = null,
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
            else if (IsSharepointSourceConfigurationVariant2)
            {
                sharepointSourceConfigurationVariant2?.Invoke(SharepointSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseSharepointSourceConfiguration),
                SharepointSourceConfigurationVariant2,
                typeof(object),
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
        public bool Equals(SharepointSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseSharepointSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(SharepointSourceConfigurationVariant2, other.SharepointSourceConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SharepointSourceConfiguration obj1, SharepointSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SharepointSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SharepointSourceConfiguration obj1, SharepointSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SharepointSourceConfiguration o && Equals(o);
        }
    }
}
