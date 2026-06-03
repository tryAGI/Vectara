#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Which Drive content to ingest. Discriminated by `type`: `shared` ingests from a Google<br/>
    /// Workspace shared drive the service account has been added to; `my_drive` ingests from a<br/>
    /// single user's My Drive via domain-wide delegation.
    /// </summary>
    public readonly partial struct GoogleDriveScope : global::System.IEquatable<GoogleDriveScope>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GoogleDriveScopeDiscriminatorType? Type { get; }

        /// <summary>
        /// Ingest from a Google Workspace shared drive. The service account (`client_email`) must<br/>
        /// be added as a member of the shared drive — or of the linked folder — with at least Viewer<br/>
        /// access. No domain-wide delegation is required.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SharedGoogleDriveScope? Shared { get; init; }
#else
        public global::Vectara.SharedGoogleDriveScope? Shared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared))]
#endif
        public bool IsShared => Shared != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickShared(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SharedGoogleDriveScope? value)
        {
            value = Shared;
            return IsShared;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SharedGoogleDriveScope PickShared() => IsShared
            ? Shared!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared' but the value was {ToString()}.");

        /// <summary>
        /// Ingest from a single user's My Drive via Google Workspace domain-wide delegation. Requires<br/>
        /// the Workspace admin to authorize the service account's client ID with the `drive.readonly`<br/>
        /// OAuth scope.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.MyGoogleDriveScope? MyDrive { get; init; }
#else
        public global::Vectara.MyGoogleDriveScope? MyDrive { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MyDrive))]
#endif
        public bool IsMyDrive => MyDrive != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMyDrive(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.MyGoogleDriveScope? value)
        {
            value = MyDrive;
            return IsMyDrive;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.MyGoogleDriveScope PickMyDrive() => IsMyDrive
            ? MyDrive!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MyDrive' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GoogleDriveScope(global::Vectara.SharedGoogleDriveScope value) => new GoogleDriveScope((global::Vectara.SharedGoogleDriveScope?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SharedGoogleDriveScope?(GoogleDriveScope @this) => @this.Shared;

        /// <summary>
        /// 
        /// </summary>
        public GoogleDriveScope(global::Vectara.SharedGoogleDriveScope? value)
        {
            Shared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GoogleDriveScope FromShared(global::Vectara.SharedGoogleDriveScope? value) => new GoogleDriveScope(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GoogleDriveScope(global::Vectara.MyGoogleDriveScope value) => new GoogleDriveScope((global::Vectara.MyGoogleDriveScope?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MyGoogleDriveScope?(GoogleDriveScope @this) => @this.MyDrive;

        /// <summary>
        /// 
        /// </summary>
        public GoogleDriveScope(global::Vectara.MyGoogleDriveScope? value)
        {
            MyDrive = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GoogleDriveScope FromMyDrive(global::Vectara.MyGoogleDriveScope? value) => new GoogleDriveScope(value);

        /// <summary>
        /// 
        /// </summary>
        public GoogleDriveScope(
            global::Vectara.GoogleDriveScopeDiscriminatorType? type,
            global::Vectara.SharedGoogleDriveScope? shared,
            global::Vectara.MyGoogleDriveScope? myDrive
            )
        {
            Type = type;

            Shared = shared;
            MyDrive = myDrive;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MyDrive as object ??
            Shared as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Shared?.ToString() ??
            MyDrive?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsShared && !IsMyDrive || !IsShared && IsMyDrive;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SharedGoogleDriveScope, TResult>? shared = null,
            global::System.Func<global::Vectara.MyGoogleDriveScope, TResult>? myDrive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared && shared != null)
            {
                return shared(Shared!);
            }
            else if (IsMyDrive && myDrive != null)
            {
                return myDrive(MyDrive!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.SharedGoogleDriveScope>? shared = null,

            global::System.Action<global::Vectara.MyGoogleDriveScope>? myDrive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared)
            {
                shared?.Invoke(Shared!);
            }
            else if (IsMyDrive)
            {
                myDrive?.Invoke(MyDrive!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.SharedGoogleDriveScope>? shared = null,
            global::System.Action<global::Vectara.MyGoogleDriveScope>? myDrive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared)
            {
                shared?.Invoke(Shared!);
            }
            else if (IsMyDrive)
            {
                myDrive?.Invoke(MyDrive!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared,
                typeof(global::Vectara.SharedGoogleDriveScope),
                MyDrive,
                typeof(global::Vectara.MyGoogleDriveScope),
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
        public bool Equals(GoogleDriveScope other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SharedGoogleDriveScope?>.Default.Equals(Shared, other.Shared) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MyGoogleDriveScope?>.Default.Equals(MyDrive, other.MyDrive) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GoogleDriveScope obj1, GoogleDriveScope obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GoogleDriveScope>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GoogleDriveScope obj1, GoogleDriveScope obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GoogleDriveScope o && Equals(o);
        }
    }
}
