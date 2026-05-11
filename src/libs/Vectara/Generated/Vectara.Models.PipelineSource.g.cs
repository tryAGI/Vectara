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
        /// Configuration for ingesting pages from a website. Politeness, limits, and auth are configured<br/>
        /// here; the `pages_source` field selects how URLs are discovered (sitemap, crawl, or both).
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
            global::Vectara.S3SourceConfiguration? s3,
            global::Vectara.WebSourceConfiguration? web
            )
        {
            Type = type;

            S3 = s3;
            Web = web;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Web as object ??
            S3 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            S3?.ToString() ??
            Web?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsS3 && !IsWeb || !IsS3 && IsWeb;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.S3SourceConfiguration?, TResult>? s3 = null,
            global::System.Func<global::Vectara.WebSourceConfiguration?, TResult>? web = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsS3 && s3 != null)
            {
                return s3(S3!);
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
            global::System.Action<global::Vectara.S3SourceConfiguration?>? s3 = null,

            global::System.Action<global::Vectara.WebSourceConfiguration?>? web = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsS3)
            {
                s3?.Invoke(S3!);
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
            global::System.Action<global::Vectara.S3SourceConfiguration?>? s3 = null,
            global::System.Action<global::Vectara.WebSourceConfiguration?>? web = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsS3)
            {
                s3?.Invoke(S3!);
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
                S3,
                typeof(global::Vectara.S3SourceConfiguration),
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.S3SourceConfiguration?>.Default.Equals(S3, other.S3) &&
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
