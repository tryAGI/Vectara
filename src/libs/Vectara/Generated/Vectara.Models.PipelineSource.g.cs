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
            global::Vectara.S3SourceConfiguration? s3
            )
        {
            Type = type;

            S3 = s3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            S3 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            S3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsS3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.S3SourceConfiguration?, TResult>? s3 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.S3SourceConfiguration?>? s3 = null,
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
