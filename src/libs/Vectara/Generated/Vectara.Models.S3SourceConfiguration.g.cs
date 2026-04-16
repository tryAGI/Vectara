#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting objects from any S3-compatible source (Amazon S3, MinIO, Ceph, etc.).
    /// </summary>
    public readonly partial struct S3SourceConfiguration : global::System.IEquatable<S3SourceConfiguration>
    {
        /// <summary>
        /// Base S3 source configuration with all fields optional.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseS3SourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseS3SourceConfiguration? Base { get; }
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
#if NET6_0_OR_GREATER
        public object? S3SourceConfigurationVariant2 { get; init; }
#else
        public object? S3SourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S3SourceConfigurationVariant2))]
#endif
        public bool IsS3SourceConfigurationVariant2 => S3SourceConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator S3SourceConfiguration(global::Vectara.BaseS3SourceConfiguration value) => new S3SourceConfiguration((global::Vectara.BaseS3SourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseS3SourceConfiguration?(S3SourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public S3SourceConfiguration(global::Vectara.BaseS3SourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public S3SourceConfiguration(
            global::Vectara.BaseS3SourceConfiguration? @base,
            object? s3SourceConfigurationVariant2
            )
        {
            Base = @base;
            S3SourceConfigurationVariant2 = s3SourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            S3SourceConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            S3SourceConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsS3SourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseS3SourceConfiguration?, TResult>? @base = null,
            global::System.Func<object?, TResult>? s3SourceConfigurationVariant2 = null,
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
            else if (IsS3SourceConfigurationVariant2 && s3SourceConfigurationVariant2 != null)
            {
                return s3SourceConfigurationVariant2(S3SourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseS3SourceConfiguration?>? @base = null,
            global::System.Action<object?>? s3SourceConfigurationVariant2 = null,
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
            else if (IsS3SourceConfigurationVariant2)
            {
                s3SourceConfigurationVariant2?.Invoke(S3SourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseS3SourceConfiguration),
                S3SourceConfigurationVariant2,
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
        public bool Equals(S3SourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseS3SourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(S3SourceConfigurationVariant2, other.S3SourceConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(S3SourceConfiguration obj1, S3SourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<S3SourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(S3SourceConfiguration obj1, S3SourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is S3SourceConfiguration o && Equals(o);
        }
    }
}
