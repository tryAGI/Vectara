#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Partial update for Google Drive source configuration. Only provided fields are merged.
    /// </summary>
    public readonly partial struct UpdateGoogleDriveSourceConfiguration : global::System.IEquatable<UpdateGoogleDriveSourceConfiguration>
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
        public static implicit operator UpdateGoogleDriveSourceConfiguration(global::Vectara.BaseGoogleDriveSourceConfiguration value) => new UpdateGoogleDriveSourceConfiguration((global::Vectara.BaseGoogleDriveSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseGoogleDriveSourceConfiguration?(UpdateGoogleDriveSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public UpdateGoogleDriveSourceConfiguration(global::Vectara.BaseGoogleDriveSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateGoogleDriveSourceConfiguration FromBase(global::Vectara.BaseGoogleDriveSourceConfiguration? value) => new UpdateGoogleDriveSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseGoogleDriveSourceConfiguration, TResult>? @base = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseGoogleDriveSourceConfiguration>? @base = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseGoogleDriveSourceConfiguration>? @base = null,
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
        public bool Equals(UpdateGoogleDriveSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseGoogleDriveSourceConfiguration?>.Default.Equals(Base, other.Base) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateGoogleDriveSourceConfiguration obj1, UpdateGoogleDriveSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateGoogleDriveSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateGoogleDriveSourceConfiguration obj1, UpdateGoogleDriveSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateGoogleDriveSourceConfiguration o && Equals(o);
        }
    }
}
