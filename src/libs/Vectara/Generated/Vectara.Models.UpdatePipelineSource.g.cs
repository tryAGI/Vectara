#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Source configuration for partial updates. Only provided fields are changed; credentials are optional.
    /// </summary>
    public readonly partial struct UpdatePipelineSource : global::System.IEquatable<UpdatePipelineSource>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdatePipelineSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Partial update for SharePoint source configuration. Only provided fields are merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateSharepointSourceConfiguration? Sharepoint { get; init; }
#else
        public global::Vectara.UpdateSharepointSourceConfiguration? Sharepoint { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharepoint))]
#endif
        public bool IsSharepoint => Sharepoint != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSharepoint(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.UpdateSharepointSourceConfiguration? value)
        {
            value = Sharepoint;
            return IsSharepoint;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateSharepointSourceConfiguration PickSharepoint() => IsSharepoint
            ? Sharepoint!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharepoint' but the value was {ToString()}.");

        /// <summary>
        /// Partial update for S3 source configuration. Only provided fields are merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateS3SourceConfiguration? S3 { get; init; }
#else
        public global::Vectara.UpdateS3SourceConfiguration? S3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S3))]
#endif
        public bool IsS3 => S3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickS3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.UpdateS3SourceConfiguration? value)
        {
            value = S3;
            return IsS3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateS3SourceConfiguration PickS3() => IsS3
            ? S3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3' but the value was {ToString()}.");

        /// <summary>
        /// Partial update for Google Drive source configuration. Only provided fields are merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateGoogleDriveSourceConfiguration? GoogleDrive { get; init; }
#else
        public global::Vectara.UpdateGoogleDriveSourceConfiguration? GoogleDrive { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleDrive))]
#endif
        public bool IsGoogleDrive => GoogleDrive != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleDrive(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.UpdateGoogleDriveSourceConfiguration? value)
        {
            value = GoogleDrive;
            return IsGoogleDrive;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateGoogleDriveSourceConfiguration PickGoogleDrive() => IsGoogleDrive
            ? GoogleDrive!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleDrive' but the value was {ToString()}.");

        /// <summary>
        /// Partial update for Box source configuration. Only provided fields are merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateBoxSourceConfiguration? Box { get; init; }
#else
        public global::Vectara.UpdateBoxSourceConfiguration? Box { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Box))]
#endif
        public bool IsBox => Box != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBox(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.UpdateBoxSourceConfiguration? value)
        {
            value = Box;
            return IsBox;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateBoxSourceConfiguration PickBox() => IsBox
            ? Box!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Box' but the value was {ToString()}.");

        /// <summary>
        /// Partial update for Wolken source configuration. Only provided fields are merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateWolkenKbSourceConfiguration? WolkenKb { get; init; }
#else
        public global::Vectara.UpdateWolkenKbSourceConfiguration? WolkenKb { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WolkenKb))]
#endif
        public bool IsWolkenKb => WolkenKb != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWolkenKb(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.UpdateWolkenKbSourceConfiguration? value)
        {
            value = WolkenKb;
            return IsWolkenKb;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateWolkenKbSourceConfiguration PickWolkenKb() => IsWolkenKb
            ? WolkenKb!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WolkenKb' but the value was {ToString()}.");

        /// <summary>
        /// Partial update for Confluence source configuration. Only provided fields are merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateConfluenceSourceConfiguration? Confluence { get; init; }
#else
        public global::Vectara.UpdateConfluenceSourceConfiguration? Confluence { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Confluence))]
#endif
        public bool IsConfluence => Confluence != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConfluence(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.UpdateConfluenceSourceConfiguration? value)
        {
            value = Confluence;
            return IsConfluence;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateConfluenceSourceConfiguration PickConfluence() => IsConfluence
            ? Confluence!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Confluence' but the value was {ToString()}.");

        /// <summary>
        /// Partial update for a `web` source configuration. Top-level fields are merged into the existing<br/>
        /// record; if `pages_source` is provided, the entire `pages_source` object is replaced (i.e.,<br/>
        /// switching modes or changing per-mode fields requires a complete `pages_source` object).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateWebSourceConfiguration? Web { get; init; }
#else
        public global::Vectara.UpdateWebSourceConfiguration? Web { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Web))]
#endif
        public bool IsWeb => Web != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWeb(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.UpdateWebSourceConfiguration? value)
        {
            value = Web;
            return IsWeb;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.UpdateWebSourceConfiguration PickWeb() => IsWeb
            ? Web!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Web' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdatePipelineSource(global::Vectara.UpdateSharepointSourceConfiguration value) => new UpdatePipelineSource((global::Vectara.UpdateSharepointSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateSharepointSourceConfiguration?(UpdatePipelineSource @this) => @this.Sharepoint;

        /// <summary>
        /// 
        /// </summary>
        public UpdatePipelineSource(global::Vectara.UpdateSharepointSourceConfiguration? value)
        {
            Sharepoint = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdatePipelineSource FromSharepoint(global::Vectara.UpdateSharepointSourceConfiguration? value) => new UpdatePipelineSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdatePipelineSource(global::Vectara.UpdateS3SourceConfiguration value) => new UpdatePipelineSource((global::Vectara.UpdateS3SourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateS3SourceConfiguration?(UpdatePipelineSource @this) => @this.S3;

        /// <summary>
        /// 
        /// </summary>
        public UpdatePipelineSource(global::Vectara.UpdateS3SourceConfiguration? value)
        {
            S3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdatePipelineSource FromS3(global::Vectara.UpdateS3SourceConfiguration? value) => new UpdatePipelineSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdatePipelineSource(global::Vectara.UpdateGoogleDriveSourceConfiguration value) => new UpdatePipelineSource((global::Vectara.UpdateGoogleDriveSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateGoogleDriveSourceConfiguration?(UpdatePipelineSource @this) => @this.GoogleDrive;

        /// <summary>
        /// 
        /// </summary>
        public UpdatePipelineSource(global::Vectara.UpdateGoogleDriveSourceConfiguration? value)
        {
            GoogleDrive = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdatePipelineSource FromGoogleDrive(global::Vectara.UpdateGoogleDriveSourceConfiguration? value) => new UpdatePipelineSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdatePipelineSource(global::Vectara.UpdateBoxSourceConfiguration value) => new UpdatePipelineSource((global::Vectara.UpdateBoxSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateBoxSourceConfiguration?(UpdatePipelineSource @this) => @this.Box;

        /// <summary>
        /// 
        /// </summary>
        public UpdatePipelineSource(global::Vectara.UpdateBoxSourceConfiguration? value)
        {
            Box = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdatePipelineSource FromBox(global::Vectara.UpdateBoxSourceConfiguration? value) => new UpdatePipelineSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdatePipelineSource(global::Vectara.UpdateWolkenKbSourceConfiguration value) => new UpdatePipelineSource((global::Vectara.UpdateWolkenKbSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateWolkenKbSourceConfiguration?(UpdatePipelineSource @this) => @this.WolkenKb;

        /// <summary>
        /// 
        /// </summary>
        public UpdatePipelineSource(global::Vectara.UpdateWolkenKbSourceConfiguration? value)
        {
            WolkenKb = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdatePipelineSource FromWolkenKb(global::Vectara.UpdateWolkenKbSourceConfiguration? value) => new UpdatePipelineSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdatePipelineSource(global::Vectara.UpdateConfluenceSourceConfiguration value) => new UpdatePipelineSource((global::Vectara.UpdateConfluenceSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateConfluenceSourceConfiguration?(UpdatePipelineSource @this) => @this.Confluence;

        /// <summary>
        /// 
        /// </summary>
        public UpdatePipelineSource(global::Vectara.UpdateConfluenceSourceConfiguration? value)
        {
            Confluence = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdatePipelineSource FromConfluence(global::Vectara.UpdateConfluenceSourceConfiguration? value) => new UpdatePipelineSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdatePipelineSource(global::Vectara.UpdateWebSourceConfiguration value) => new UpdatePipelineSource((global::Vectara.UpdateWebSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateWebSourceConfiguration?(UpdatePipelineSource @this) => @this.Web;

        /// <summary>
        /// 
        /// </summary>
        public UpdatePipelineSource(global::Vectara.UpdateWebSourceConfiguration? value)
        {
            Web = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdatePipelineSource FromWeb(global::Vectara.UpdateWebSourceConfiguration? value) => new UpdatePipelineSource(value);

        /// <summary>
        /// 
        /// </summary>
        public UpdatePipelineSource(
            global::Vectara.UpdatePipelineSourceDiscriminatorType? type,
            global::Vectara.UpdateSharepointSourceConfiguration? sharepoint,
            global::Vectara.UpdateS3SourceConfiguration? s3,
            global::Vectara.UpdateGoogleDriveSourceConfiguration? googleDrive,
            global::Vectara.UpdateBoxSourceConfiguration? box,
            global::Vectara.UpdateWolkenKbSourceConfiguration? wolkenKb,
            global::Vectara.UpdateConfluenceSourceConfiguration? confluence,
            global::Vectara.UpdateWebSourceConfiguration? web
            )
        {
            Type = type;

            Sharepoint = sharepoint;
            S3 = s3;
            GoogleDrive = googleDrive;
            Box = box;
            WolkenKb = wolkenKb;
            Confluence = confluence;
            Web = web;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Web as object ??
            Confluence as object ??
            WolkenKb as object ??
            Box as object ??
            GoogleDrive as object ??
            S3 as object ??
            Sharepoint as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Sharepoint?.ToString() ??
            S3?.ToString() ??
            GoogleDrive?.ToString() ??
            Box?.ToString() ??
            WolkenKb?.ToString() ??
            Confluence?.ToString() ??
            Web?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsConfluence && !IsWeb || !IsSharepoint && IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsConfluence && !IsWeb || !IsSharepoint && !IsS3 && IsGoogleDrive && !IsBox && !IsWolkenKb && !IsConfluence && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && IsBox && !IsWolkenKb && !IsConfluence && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && IsWolkenKb && !IsConfluence && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && IsConfluence && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsConfluence && IsWeb;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.UpdateSharepointSourceConfiguration?, TResult>? sharepoint = null,
            global::System.Func<global::Vectara.UpdateS3SourceConfiguration?, TResult>? s3 = null,
            global::System.Func<global::Vectara.UpdateGoogleDriveSourceConfiguration?, TResult>? googleDrive = null,
            global::System.Func<global::Vectara.UpdateBoxSourceConfiguration?, TResult>? box = null,
            global::System.Func<global::Vectara.UpdateWolkenKbSourceConfiguration?, TResult>? wolkenKb = null,
            global::System.Func<global::Vectara.UpdateConfluenceSourceConfiguration?, TResult>? confluence = null,
            global::System.Func<global::Vectara.UpdateWebSourceConfiguration?, TResult>? web = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharepoint && sharepoint != null)
            {
                return sharepoint(Sharepoint!);
            }
            else if (IsS3 && s3 != null)
            {
                return s3(S3!);
            }
            else if (IsGoogleDrive && googleDrive != null)
            {
                return googleDrive(GoogleDrive!);
            }
            else if (IsBox && box != null)
            {
                return box(Box!);
            }
            else if (IsWolkenKb && wolkenKb != null)
            {
                return wolkenKb(WolkenKb!);
            }
            else if (IsConfluence && confluence != null)
            {
                return confluence(Confluence!);
            }
            else if (IsWeb && web != null)
            {
                return web(Web!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.UpdateSharepointSourceConfiguration?>? sharepoint = null,

            global::System.Action<global::Vectara.UpdateS3SourceConfiguration?>? s3 = null,

            global::System.Action<global::Vectara.UpdateGoogleDriveSourceConfiguration?>? googleDrive = null,

            global::System.Action<global::Vectara.UpdateBoxSourceConfiguration?>? box = null,

            global::System.Action<global::Vectara.UpdateWolkenKbSourceConfiguration?>? wolkenKb = null,

            global::System.Action<global::Vectara.UpdateConfluenceSourceConfiguration?>? confluence = null,

            global::System.Action<global::Vectara.UpdateWebSourceConfiguration?>? web = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharepoint)
            {
                sharepoint?.Invoke(Sharepoint!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsGoogleDrive)
            {
                googleDrive?.Invoke(GoogleDrive!);
            }
            else if (IsBox)
            {
                box?.Invoke(Box!);
            }
            else if (IsWolkenKb)
            {
                wolkenKb?.Invoke(WolkenKb!);
            }
            else if (IsConfluence)
            {
                confluence?.Invoke(Confluence!);
            }
            else if (IsWeb)
            {
                web?.Invoke(Web!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.UpdateSharepointSourceConfiguration?>? sharepoint = null,
            global::System.Action<global::Vectara.UpdateS3SourceConfiguration?>? s3 = null,
            global::System.Action<global::Vectara.UpdateGoogleDriveSourceConfiguration?>? googleDrive = null,
            global::System.Action<global::Vectara.UpdateBoxSourceConfiguration?>? box = null,
            global::System.Action<global::Vectara.UpdateWolkenKbSourceConfiguration?>? wolkenKb = null,
            global::System.Action<global::Vectara.UpdateConfluenceSourceConfiguration?>? confluence = null,
            global::System.Action<global::Vectara.UpdateWebSourceConfiguration?>? web = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharepoint)
            {
                sharepoint?.Invoke(Sharepoint!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsGoogleDrive)
            {
                googleDrive?.Invoke(GoogleDrive!);
            }
            else if (IsBox)
            {
                box?.Invoke(Box!);
            }
            else if (IsWolkenKb)
            {
                wolkenKb?.Invoke(WolkenKb!);
            }
            else if (IsConfluence)
            {
                confluence?.Invoke(Confluence!);
            }
            else if (IsWeb)
            {
                web?.Invoke(Web!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharepoint,
                typeof(global::Vectara.UpdateSharepointSourceConfiguration),
                S3,
                typeof(global::Vectara.UpdateS3SourceConfiguration),
                GoogleDrive,
                typeof(global::Vectara.UpdateGoogleDriveSourceConfiguration),
                Box,
                typeof(global::Vectara.UpdateBoxSourceConfiguration),
                WolkenKb,
                typeof(global::Vectara.UpdateWolkenKbSourceConfiguration),
                Confluence,
                typeof(global::Vectara.UpdateConfluenceSourceConfiguration),
                Web,
                typeof(global::Vectara.UpdateWebSourceConfiguration),
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
        public bool Equals(UpdatePipelineSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateSharepointSourceConfiguration?>.Default.Equals(Sharepoint, other.Sharepoint) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateS3SourceConfiguration?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateGoogleDriveSourceConfiguration?>.Default.Equals(GoogleDrive, other.GoogleDrive) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateBoxSourceConfiguration?>.Default.Equals(Box, other.Box) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateWolkenKbSourceConfiguration?>.Default.Equals(WolkenKb, other.WolkenKb) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateConfluenceSourceConfiguration?>.Default.Equals(Confluence, other.Confluence) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateWebSourceConfiguration?>.Default.Equals(Web, other.Web) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdatePipelineSource obj1, UpdatePipelineSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdatePipelineSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdatePipelineSource obj1, UpdatePipelineSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdatePipelineSource o && Equals(o);
        }
    }
}
