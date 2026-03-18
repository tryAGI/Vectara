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
        /// Configuration for ingesting documents from OpenText Documentum.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DocumentumSourceConfiguration? Documentum { get; init; }
#else
        public global::Vectara.DocumentumSourceConfiguration? Documentum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Documentum))]
#endif
        public bool IsDocumentum => Documentum != null;

        /// <summary>
        /// Configuration for ingesting objects from an Amazon S3 bucket.
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
        public static implicit operator PipelineSource(global::Vectara.DocumentumSourceConfiguration value) => new PipelineSource((global::Vectara.DocumentumSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DocumentumSourceConfiguration?(PipelineSource @this) => @this.Documentum;

        /// <summary>
        /// 
        /// </summary>
        public PipelineSource(global::Vectara.DocumentumSourceConfiguration? value)
        {
            Documentum = value;
        }

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
        public PipelineSource(
            global::Vectara.PipelineSourceDiscriminatorType? type,
            global::Vectara.SharepointSourceConfiguration? sharepoint,
            global::Vectara.DocumentumSourceConfiguration? documentum,
            global::Vectara.S3SourceConfiguration? s3
            )
        {
            Type = type;

            Sharepoint = sharepoint;
            Documentum = documentum;
            S3 = s3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            S3 as object ??
            Documentum as object ??
            Sharepoint as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Sharepoint?.ToString() ??
            Documentum?.ToString() ??
            S3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSharepoint && !IsDocumentum && !IsS3 || !IsSharepoint && IsDocumentum && !IsS3 || !IsSharepoint && !IsDocumentum && IsS3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SharepointSourceConfiguration?, TResult>? sharepoint = null,
            global::System.Func<global::Vectara.DocumentumSourceConfiguration?, TResult>? documentum = null,
            global::System.Func<global::Vectara.S3SourceConfiguration?, TResult>? s3 = null,
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
            else if (IsDocumentum && documentum != null)
            {
                return documentum(Documentum!);
            }
            else if (IsS3 && s3 != null)
            {
                return s3(S3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.SharepointSourceConfiguration?>? sharepoint = null,
            global::System.Action<global::Vectara.DocumentumSourceConfiguration?>? documentum = null,
            global::System.Action<global::Vectara.S3SourceConfiguration?>? s3 = null,
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
            else if (IsDocumentum)
            {
                documentum?.Invoke(Documentum!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
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
                Documentum,
                typeof(global::Vectara.DocumentumSourceConfiguration),
                S3,
                typeof(global::Vectara.S3SourceConfiguration),
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DocumentumSourceConfiguration?>.Default.Equals(Documentum, other.Documentum) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.S3SourceConfiguration?>.Default.Equals(S3, other.S3) 
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
