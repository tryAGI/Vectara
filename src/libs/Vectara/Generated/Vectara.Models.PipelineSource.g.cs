#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// The source system to ingest data from.
    /// </summary>
    public readonly partial struct PipelineSource : global::System.IEquatable<PipelineSource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.PipelineSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Configuration for ingesting documents from a SharePoint site.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SharepointSourceConfiguration? Sharepoint { get; init; }
#else
        public global::Vectara.SharepointSourceConfiguration? Sharepoint { get; }
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
            out global::Vectara.SharepointSourceConfiguration? value)
        {
            value = Sharepoint;
            return IsSharepoint;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SharepointSourceConfiguration PickSharepoint() => IsSharepoint
            ? Sharepoint!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharepoint' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting objects from any S3-compatible source (Amazon S3, MinIO, Ceph, etc.).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.S3SourceConfiguration? S3 { get; init; }
#else
        public global::Vectara.S3SourceConfiguration? S3 { get; }
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
            out global::Vectara.S3SourceConfiguration? value)
        {
            value = S3;
            return IsS3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.S3SourceConfiguration PickS3() => IsS3
            ? S3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting files from Google Drive using a service account.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GoogleDriveSourceConfiguration? GoogleDrive { get; init; }
#else
        public global::Vectara.GoogleDriveSourceConfiguration? GoogleDrive { get; }
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
            out global::Vectara.GoogleDriveSourceConfiguration? value)
        {
            value = GoogleDrive;
            return IsGoogleDrive;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GoogleDriveSourceConfiguration PickGoogleDrive() => IsGoogleDrive
            ? GoogleDrive!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleDrive' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting files from a Box enterprise, inheriting Box collaborations as document-level ACL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BoxSourceConfiguration? Box { get; init; }
#else
        public global::Vectara.BoxSourceConfiguration? Box { get; }
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
            out global::Vectara.BoxSourceConfiguration? value)
        {
            value = Box;
            return IsBox;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BoxSourceConfiguration PickBox() => IsBox
            ? Box!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Box' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting knowledge-base articles from a Wolken ServiceDesk instance.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WolkenKbSourceConfiguration? WolkenKb { get; init; }
#else
        public global::Vectara.WolkenKbSourceConfiguration? WolkenKb { get; }
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
            out global::Vectara.WolkenKbSourceConfiguration? value)
        {
            value = WolkenKb;
            return IsWolkenKb;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenKbSourceConfiguration PickWolkenKb() => IsWolkenKb
            ? WolkenKb!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WolkenKb' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting end-user-facing service catalog forms from a Wolken ServiceDesk instance.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WolkenFormsSourceConfiguration? WolkenForms { get; init; }
#else
        public global::Vectara.WolkenFormsSourceConfiguration? WolkenForms { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WolkenForms))]
#endif
        public bool IsWolkenForms => WolkenForms != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWolkenForms(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WolkenFormsSourceConfiguration? value)
        {
            value = WolkenForms;
            return IsWolkenForms;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenFormsSourceConfiguration PickWolkenForms() => IsWolkenForms
            ? WolkenForms!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WolkenForms' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting incidents and service requests from a Wolken ServiceDesk instance.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WolkenTicketsSourceConfiguration? WolkenTickets { get; init; }
#else
        public global::Vectara.WolkenTicketsSourceConfiguration? WolkenTickets { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WolkenTickets))]
#endif
        public bool IsWolkenTickets => WolkenTickets != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWolkenTickets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WolkenTicketsSourceConfiguration? value)
        {
            value = WolkenTickets;
            return IsWolkenTickets;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WolkenTicketsSourceConfiguration PickWolkenTickets() => IsWolkenTickets
            ? WolkenTickets!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WolkenTickets' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting pages from a Confluence instance.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ConfluenceSourceConfiguration? Confluence { get; init; }
#else
        public global::Vectara.ConfluenceSourceConfiguration? Confluence { get; }
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
            out global::Vectara.ConfluenceSourceConfiguration? value)
        {
            value = Confluence;
            return IsConfluence;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConfluenceSourceConfiguration PickConfluence() => IsConfluence
            ? Confluence!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Confluence' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting content from a Fluid Topics tenant via the Knowledge Hub REST API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.FluidtopicsSourceConfiguration? Fluidtopics { get; init; }
#else
        public global::Vectara.FluidtopicsSourceConfiguration? Fluidtopics { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fluidtopics))]
#endif
        public bool IsFluidtopics => Fluidtopics != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFluidtopics(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.FluidtopicsSourceConfiguration? value)
        {
            value = Fluidtopics;
            return IsFluidtopics;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.FluidtopicsSourceConfiguration PickFluidtopics() => IsFluidtopics
            ? Fluidtopics!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fluidtopics' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting user records from a SCIM 2.0 service provider.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ScimSourceConfiguration? Scim { get; init; }
#else
        public global::Vectara.ScimSourceConfiguration? Scim { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Scim))]
#endif
        public bool IsScim => Scim != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScim(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ScimSourceConfiguration? value)
        {
            value = Scim;
            return IsScim;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ScimSourceConfiguration PickScim() => IsScim
            ? Scim!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scim' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting the course catalog of a Docebo LMS instance via the Learn REST API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DoceboSourceConfiguration? Docebo { get; init; }
#else
        public global::Vectara.DoceboSourceConfiguration? Docebo { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Docebo))]
#endif
        public bool IsDocebo => Docebo != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDocebo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.DoceboSourceConfiguration? value)
        {
            value = Docebo;
            return IsDocebo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.DoceboSourceConfiguration PickDocebo() => IsDocebo
            ? Docebo!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Docebo' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for ingesting pages from a website. Politeness, limits, and auth are configured<br/>
        /// here. The `pages_source` field selects how URLs are discovered (sitemap, crawl, or both).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WebSourceConfiguration? Web { get; init; }
#else
        public global::Vectara.WebSourceConfiguration? Web { get; }
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
            out global::Vectara.WebSourceConfiguration? value)
        {
            value = Web;
            return IsWeb;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WebSourceConfiguration PickWeb() => IsWeb
            ? Web!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Web' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.SharepointSourceConfiguration value) => new PipelineSource((global::Vectara.SharepointSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.SharepointSourceConfiguration?(PipelineSource @this) => @this.Sharepoint;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.SharepointSourceConfiguration? value)
        {
            Sharepoint = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromSharepoint(global::Vectara.SharepointSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.S3SourceConfiguration value) => new PipelineSource((global::Vectara.S3SourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.S3SourceConfiguration?(PipelineSource @this) => @this.S3;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.S3SourceConfiguration? value)
        {
            S3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromS3(global::Vectara.S3SourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.GoogleDriveSourceConfiguration value) => new PipelineSource((global::Vectara.GoogleDriveSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.GoogleDriveSourceConfiguration?(PipelineSource @this) => @this.GoogleDrive;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.GoogleDriveSourceConfiguration? value)
        {
            GoogleDrive = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromGoogleDrive(global::Vectara.GoogleDriveSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.BoxSourceConfiguration value) => new PipelineSource((global::Vectara.BoxSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.BoxSourceConfiguration?(PipelineSource @this) => @this.Box;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.BoxSourceConfiguration? value)
        {
            Box = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromBox(global::Vectara.BoxSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.WolkenKbSourceConfiguration value) => new PipelineSource((global::Vectara.WolkenKbSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WolkenKbSourceConfiguration?(PipelineSource @this) => @this.WolkenKb;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.WolkenKbSourceConfiguration? value)
        {
            WolkenKb = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromWolkenKb(global::Vectara.WolkenKbSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.WolkenFormsSourceConfiguration value) => new PipelineSource((global::Vectara.WolkenFormsSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WolkenFormsSourceConfiguration?(PipelineSource @this) => @this.WolkenForms;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.WolkenFormsSourceConfiguration? value)
        {
            WolkenForms = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromWolkenForms(global::Vectara.WolkenFormsSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.WolkenTicketsSourceConfiguration value) => new PipelineSource((global::Vectara.WolkenTicketsSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WolkenTicketsSourceConfiguration?(PipelineSource @this) => @this.WolkenTickets;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.WolkenTicketsSourceConfiguration? value)
        {
            WolkenTickets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromWolkenTickets(global::Vectara.WolkenTicketsSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.ConfluenceSourceConfiguration value) => new PipelineSource((global::Vectara.ConfluenceSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ConfluenceSourceConfiguration?(PipelineSource @this) => @this.Confluence;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.ConfluenceSourceConfiguration? value)
        {
            Confluence = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromConfluence(global::Vectara.ConfluenceSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.FluidtopicsSourceConfiguration value) => new PipelineSource((global::Vectara.FluidtopicsSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.FluidtopicsSourceConfiguration?(PipelineSource @this) => @this.Fluidtopics;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.FluidtopicsSourceConfiguration? value)
        {
            Fluidtopics = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromFluidtopics(global::Vectara.FluidtopicsSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.ScimSourceConfiguration value) => new PipelineSource((global::Vectara.ScimSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ScimSourceConfiguration?(PipelineSource @this) => @this.Scim;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.ScimSourceConfiguration? value)
        {
            Scim = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromScim(global::Vectara.ScimSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.DoceboSourceConfiguration value) => new PipelineSource((global::Vectara.DoceboSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.DoceboSourceConfiguration?(PipelineSource @this) => @this.Docebo;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.DoceboSourceConfiguration? value)
        {
            Docebo = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromDocebo(global::Vectara.DoceboSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PipelineSource(global::Vectara.WebSourceConfiguration value) => new PipelineSource((global::Vectara.WebSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WebSourceConfiguration?(PipelineSource @this) => @this.Web;

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(global::Vectara.WebSourceConfiguration? value)
        {
            Web = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PipelineSource FromWeb(global::Vectara.WebSourceConfiguration? value) => new PipelineSource(value);

        /// <summary>
        ///
        /// </summary>
        public PipelineSource(
            global::Vectara.PipelineSourceDiscriminatorType? type,
            global::Vectara.SharepointSourceConfiguration? sharepoint,
            global::Vectara.S3SourceConfiguration? s3,
            global::Vectara.GoogleDriveSourceConfiguration? googleDrive,
            global::Vectara.BoxSourceConfiguration? box,
            global::Vectara.WolkenKbSourceConfiguration? wolkenKb,
            global::Vectara.WolkenFormsSourceConfiguration? wolkenForms,
            global::Vectara.WolkenTicketsSourceConfiguration? wolkenTickets,
            global::Vectara.ConfluenceSourceConfiguration? confluence,
            global::Vectara.FluidtopicsSourceConfiguration? fluidtopics,
            global::Vectara.ScimSourceConfiguration? scim,
            global::Vectara.DoceboSourceConfiguration? docebo,
            global::Vectara.WebSourceConfiguration? web
            )
        {
            Type = type;

            Sharepoint = sharepoint;
            S3 = s3;
            GoogleDrive = googleDrive;
            Box = box;
            WolkenKb = wolkenKb;
            WolkenForms = wolkenForms;
            WolkenTickets = wolkenTickets;
            Confluence = confluence;
            Fluidtopics = fluidtopics;
            Scim = scim;
            Docebo = docebo;
            Web = web;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Web as object ??
            Docebo as object ??
            Scim as object ??
            Fluidtopics as object ??
            Confluence as object ??
            WolkenTickets as object ??
            WolkenForms as object ??
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
            WolkenForms?.ToString() ??
            WolkenTickets?.ToString() ??
            Confluence?.ToString() ??
            Fluidtopics?.ToString() ??
            Scim?.ToString() ??
            Docebo?.ToString() ??
            Web?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsWolkenForms && !IsWolkenTickets && !IsConfluence && !IsFluidtopics && !IsScim && !IsDocebo && !IsWeb || !IsSharepoint && IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsWolkenForms && !IsWolkenTickets && !IsConfluence && !IsFluidtopics && !IsScim && !IsDocebo && !IsWeb || !IsSharepoint && !IsS3 && IsGoogleDrive && !IsBox && !IsWolkenKb && !IsWolkenForms && !IsWolkenTickets && !IsConfluence && !IsFluidtopics && !IsScim && !IsDocebo && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && IsBox && !IsWolkenKb && !IsWolkenForms && !IsWolkenTickets && !IsConfluence && !IsFluidtopics && !IsScim && !IsDocebo && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && IsWolkenKb && !IsWolkenForms && !IsWolkenTickets && !IsConfluence && !IsFluidtopics && !IsScim && !IsDocebo && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && IsWolkenForms && !IsWolkenTickets && !IsConfluence && !IsFluidtopics && !IsScim && !IsDocebo && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsWolkenForms && IsWolkenTickets && !IsConfluence && !IsFluidtopics && !IsScim && !IsDocebo && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsWolkenForms && !IsWolkenTickets && IsConfluence && !IsFluidtopics && !IsScim && !IsDocebo && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsWolkenForms && !IsWolkenTickets && !IsConfluence && IsFluidtopics && !IsScim && !IsDocebo && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsWolkenForms && !IsWolkenTickets && !IsConfluence && !IsFluidtopics && IsScim && !IsDocebo && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsWolkenForms && !IsWolkenTickets && !IsConfluence && !IsFluidtopics && !IsScim && IsDocebo && !IsWeb || !IsSharepoint && !IsS3 && !IsGoogleDrive && !IsBox && !IsWolkenKb && !IsWolkenForms && !IsWolkenTickets && !IsConfluence && !IsFluidtopics && !IsScim && !IsDocebo && IsWeb;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SharepointSourceConfiguration?, TResult>? sharepoint = null,
            global::System.Func<global::Vectara.S3SourceConfiguration?, TResult>? s3 = null,
            global::System.Func<global::Vectara.GoogleDriveSourceConfiguration?, TResult>? googleDrive = null,
            global::System.Func<global::Vectara.BoxSourceConfiguration?, TResult>? box = null,
            global::System.Func<global::Vectara.WolkenKbSourceConfiguration?, TResult>? wolkenKb = null,
            global::System.Func<global::Vectara.WolkenFormsSourceConfiguration?, TResult>? wolkenForms = null,
            global::System.Func<global::Vectara.WolkenTicketsSourceConfiguration?, TResult>? wolkenTickets = null,
            global::System.Func<global::Vectara.ConfluenceSourceConfiguration?, TResult>? confluence = null,
            global::System.Func<global::Vectara.FluidtopicsSourceConfiguration?, TResult>? fluidtopics = null,
            global::System.Func<global::Vectara.ScimSourceConfiguration?, TResult>? scim = null,
            global::System.Func<global::Vectara.DoceboSourceConfiguration?, TResult>? docebo = null,
            global::System.Func<global::Vectara.WebSourceConfiguration?, TResult>? web = null,
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
            else if (IsWolkenForms && wolkenForms != null)
            {
                return wolkenForms(WolkenForms!);
            }
            else if (IsWolkenTickets && wolkenTickets != null)
            {
                return wolkenTickets(WolkenTickets!);
            }
            else if (IsConfluence && confluence != null)
            {
                return confluence(Confluence!);
            }
            else if (IsFluidtopics && fluidtopics != null)
            {
                return fluidtopics(Fluidtopics!);
            }
            else if (IsScim && scim != null)
            {
                return scim(Scim!);
            }
            else if (IsDocebo && docebo != null)
            {
                return docebo(Docebo!);
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
            global::System.Action<global::Vectara.SharepointSourceConfiguration?>? sharepoint = null,

            global::System.Action<global::Vectara.S3SourceConfiguration?>? s3 = null,

            global::System.Action<global::Vectara.GoogleDriveSourceConfiguration?>? googleDrive = null,

            global::System.Action<global::Vectara.BoxSourceConfiguration?>? box = null,

            global::System.Action<global::Vectara.WolkenKbSourceConfiguration?>? wolkenKb = null,

            global::System.Action<global::Vectara.WolkenFormsSourceConfiguration?>? wolkenForms = null,

            global::System.Action<global::Vectara.WolkenTicketsSourceConfiguration?>? wolkenTickets = null,

            global::System.Action<global::Vectara.ConfluenceSourceConfiguration?>? confluence = null,

            global::System.Action<global::Vectara.FluidtopicsSourceConfiguration?>? fluidtopics = null,

            global::System.Action<global::Vectara.ScimSourceConfiguration?>? scim = null,

            global::System.Action<global::Vectara.DoceboSourceConfiguration?>? docebo = null,

            global::System.Action<global::Vectara.WebSourceConfiguration?>? web = null,
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
            else if (IsWolkenForms)
            {
                wolkenForms?.Invoke(WolkenForms!);
            }
            else if (IsWolkenTickets)
            {
                wolkenTickets?.Invoke(WolkenTickets!);
            }
            else if (IsConfluence)
            {
                confluence?.Invoke(Confluence!);
            }
            else if (IsFluidtopics)
            {
                fluidtopics?.Invoke(Fluidtopics!);
            }
            else if (IsScim)
            {
                scim?.Invoke(Scim!);
            }
            else if (IsDocebo)
            {
                docebo?.Invoke(Docebo!);
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
            global::System.Action<global::Vectara.SharepointSourceConfiguration?>? sharepoint = null,
            global::System.Action<global::Vectara.S3SourceConfiguration?>? s3 = null,
            global::System.Action<global::Vectara.GoogleDriveSourceConfiguration?>? googleDrive = null,
            global::System.Action<global::Vectara.BoxSourceConfiguration?>? box = null,
            global::System.Action<global::Vectara.WolkenKbSourceConfiguration?>? wolkenKb = null,
            global::System.Action<global::Vectara.WolkenFormsSourceConfiguration?>? wolkenForms = null,
            global::System.Action<global::Vectara.WolkenTicketsSourceConfiguration?>? wolkenTickets = null,
            global::System.Action<global::Vectara.ConfluenceSourceConfiguration?>? confluence = null,
            global::System.Action<global::Vectara.FluidtopicsSourceConfiguration?>? fluidtopics = null,
            global::System.Action<global::Vectara.ScimSourceConfiguration?>? scim = null,
            global::System.Action<global::Vectara.DoceboSourceConfiguration?>? docebo = null,
            global::System.Action<global::Vectara.WebSourceConfiguration?>? web = null,
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
            else if (IsWolkenForms)
            {
                wolkenForms?.Invoke(WolkenForms!);
            }
            else if (IsWolkenTickets)
            {
                wolkenTickets?.Invoke(WolkenTickets!);
            }
            else if (IsConfluence)
            {
                confluence?.Invoke(Confluence!);
            }
            else if (IsFluidtopics)
            {
                fluidtopics?.Invoke(Fluidtopics!);
            }
            else if (IsScim)
            {
                scim?.Invoke(Scim!);
            }
            else if (IsDocebo)
            {
                docebo?.Invoke(Docebo!);
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
                typeof(global::Vectara.SharepointSourceConfiguration),
                S3,
                typeof(global::Vectara.S3SourceConfiguration),
                GoogleDrive,
                typeof(global::Vectara.GoogleDriveSourceConfiguration),
                Box,
                typeof(global::Vectara.BoxSourceConfiguration),
                WolkenKb,
                typeof(global::Vectara.WolkenKbSourceConfiguration),
                WolkenForms,
                typeof(global::Vectara.WolkenFormsSourceConfiguration),
                WolkenTickets,
                typeof(global::Vectara.WolkenTicketsSourceConfiguration),
                Confluence,
                typeof(global::Vectara.ConfluenceSourceConfiguration),
                Fluidtopics,
                typeof(global::Vectara.FluidtopicsSourceConfiguration),
                Scim,
                typeof(global::Vectara.ScimSourceConfiguration),
                Docebo,
                typeof(global::Vectara.DoceboSourceConfiguration),
                Web,
                typeof(global::Vectara.WebSourceConfiguration),
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
        public bool Equals(PipelineSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SharepointSourceConfiguration?>.Default.Equals(Sharepoint, other.Sharepoint) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.S3SourceConfiguration?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GoogleDriveSourceConfiguration?>.Default.Equals(GoogleDrive, other.GoogleDrive) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BoxSourceConfiguration?>.Default.Equals(Box, other.Box) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WolkenKbSourceConfiguration?>.Default.Equals(WolkenKb, other.WolkenKb) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WolkenFormsSourceConfiguration?>.Default.Equals(WolkenForms, other.WolkenForms) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WolkenTicketsSourceConfiguration?>.Default.Equals(WolkenTickets, other.WolkenTickets) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ConfluenceSourceConfiguration?>.Default.Equals(Confluence, other.Confluence) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.FluidtopicsSourceConfiguration?>.Default.Equals(Fluidtopics, other.Fluidtopics) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ScimSourceConfiguration?>.Default.Equals(Scim, other.Scim) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DoceboSourceConfiguration?>.Default.Equals(Docebo, other.Docebo) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WebSourceConfiguration?>.Default.Equals(Web, other.Web)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PipelineSource obj1, PipelineSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PipelineSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PipelineSource obj1, PipelineSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PipelineSource o && Equals(o);
        }
    }
}
