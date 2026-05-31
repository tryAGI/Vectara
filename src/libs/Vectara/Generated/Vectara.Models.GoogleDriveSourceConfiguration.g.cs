#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting files from Google Drive using a service account.
    /// </summary>
    public readonly partial struct GoogleDriveSourceConfiguration : global::System.IEquatable<GoogleDriveSourceConfiguration>
    {
        /// <summary>
        /// Base Google Drive source configuration. The `scopes` list enumerates one or more starting<br/>
        /// points — each entry is either a shared drive (`shared`) or a single user's My Drive accessed<br/>
        /// via domain-wide delegation (`my_drive`). The service account configured here must have read<br/>
        /// access to every listed drive and be authorized for each impersonated user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseGoogleDriveSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseGoogleDriveSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseGoogleDriveSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseGoogleDriveSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? GoogleDriveSourceConfigurationVariant2 { get; init; }
#else
        public object? GoogleDriveSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleDriveSourceConfigurationVariant2))]
#endif
        public bool IsGoogleDriveSourceConfigurationVariant2 => GoogleDriveSourceConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleDriveSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = GoogleDriveSourceConfigurationVariant2;
            return IsGoogleDriveSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickGoogleDriveSourceConfigurationVariant2() => IsGoogleDriveSourceConfigurationVariant2
            ? GoogleDriveSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleDriveSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GoogleDriveSourceConfiguration(global::Vectara.BaseGoogleDriveSourceConfiguration value) => new GoogleDriveSourceConfiguration((global::Vectara.BaseGoogleDriveSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseGoogleDriveSourceConfiguration?(GoogleDriveSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public GoogleDriveSourceConfiguration(global::Vectara.BaseGoogleDriveSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GoogleDriveSourceConfiguration FromBase(global::Vectara.BaseGoogleDriveSourceConfiguration? value) => new GoogleDriveSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public GoogleDriveSourceConfiguration(
            global::Vectara.BaseGoogleDriveSourceConfiguration? @base,
            object? googleDriveSourceConfigurationVariant2
            )
        {
            Base = @base;
            GoogleDriveSourceConfigurationVariant2 = googleDriveSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GoogleDriveSourceConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GoogleDriveSourceConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGoogleDriveSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseGoogleDriveSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? googleDriveSourceConfigurationVariant2 = null,
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
            else if (IsGoogleDriveSourceConfigurationVariant2 && googleDriveSourceConfigurationVariant2 != null)
            {
                return googleDriveSourceConfigurationVariant2(GoogleDriveSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseGoogleDriveSourceConfiguration>? @base = null,

            global::System.Action<object>? googleDriveSourceConfigurationVariant2 = null,
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
            else if (IsGoogleDriveSourceConfigurationVariant2)
            {
                googleDriveSourceConfigurationVariant2?.Invoke(GoogleDriveSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseGoogleDriveSourceConfiguration>? @base = null,
            global::System.Action<object>? googleDriveSourceConfigurationVariant2 = null,
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
            else if (IsGoogleDriveSourceConfigurationVariant2)
            {
                googleDriveSourceConfigurationVariant2?.Invoke(GoogleDriveSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseGoogleDriveSourceConfiguration),
                GoogleDriveSourceConfigurationVariant2,
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
        public bool Equals(GoogleDriveSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseGoogleDriveSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(GoogleDriveSourceConfigurationVariant2, other.GoogleDriveSourceConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GoogleDriveSourceConfiguration obj1, GoogleDriveSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GoogleDriveSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GoogleDriveSourceConfiguration obj1, GoogleDriveSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GoogleDriveSourceConfiguration o && Equals(o);
        }
    }
}
