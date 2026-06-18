#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting files from a Box enterprise, inheriting Box collaborations as document-level ACL.
    /// </summary>
    public readonly partial struct BoxSourceConfiguration : global::System.IEquatable<BoxSourceConfiguration>
    {
        /// <summary>
        /// Base Box source configuration. Ingests files from a Box enterprise starting at `folder_id`,<br/>
        /// walking every descendant subfolder and inheriting each item's Box collaborations as<br/>
        /// document-level ACL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseBoxSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseBoxSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseBoxSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseBoxSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? BoxSourceConfigurationVariant2 { get; init; }
#else
        public object? BoxSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BoxSourceConfigurationVariant2))]
#endif
        public bool IsBoxSourceConfigurationVariant2 => BoxSourceConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBoxSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = BoxSourceConfigurationVariant2;
            return IsBoxSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickBoxSourceConfigurationVariant2() => IsBoxSourceConfigurationVariant2
            ? BoxSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BoxSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BoxSourceConfiguration(global::Vectara.BaseBoxSourceConfiguration value) => new BoxSourceConfiguration((global::Vectara.BaseBoxSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseBoxSourceConfiguration?(BoxSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public BoxSourceConfiguration(global::Vectara.BaseBoxSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BoxSourceConfiguration FromBase(global::Vectara.BaseBoxSourceConfiguration? value) => new BoxSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public BoxSourceConfiguration(
            global::Vectara.BaseBoxSourceConfiguration? @base,
            object? boxSourceConfigurationVariant2
            )
        {
            Base = @base;
            BoxSourceConfigurationVariant2 = boxSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BoxSourceConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            BoxSourceConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsBoxSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseBoxSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? boxSourceConfigurationVariant2 = null,
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
            else if (IsBoxSourceConfigurationVariant2 && boxSourceConfigurationVariant2 != null)
            {
                return boxSourceConfigurationVariant2(BoxSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseBoxSourceConfiguration>? @base = null,

            global::System.Action<object>? boxSourceConfigurationVariant2 = null,
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
            else if (IsBoxSourceConfigurationVariant2)
            {
                boxSourceConfigurationVariant2?.Invoke(BoxSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseBoxSourceConfiguration>? @base = null,
            global::System.Action<object>? boxSourceConfigurationVariant2 = null,
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
            else if (IsBoxSourceConfigurationVariant2)
            {
                boxSourceConfigurationVariant2?.Invoke(BoxSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseBoxSourceConfiguration),
                BoxSourceConfigurationVariant2,
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
        public bool Equals(BoxSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseBoxSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(BoxSourceConfigurationVariant2, other.BoxSourceConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BoxSourceConfiguration obj1, BoxSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BoxSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BoxSourceConfiguration obj1, BoxSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BoxSourceConfiguration o && Equals(o);
        }
    }
}
