#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a reusable configuration for an artifact read tool with predefined parameters that can be applied to agents.
    /// </summary>
    public readonly partial struct CreateArtifactReadToolConfigurationRequest : global::System.IEquatable<CreateArtifactReadToolConfigurationRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateArtifactReadToolConfigurationRequestVariant1? CreateArtifactReadToolConfigurationRequestVariant1 { get; init; }
#else
        public global::Vectara.CreateArtifactReadToolConfigurationRequestVariant1? CreateArtifactReadToolConfigurationRequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateArtifactReadToolConfigurationRequestVariant1))]
#endif
        public bool IsCreateArtifactReadToolConfigurationRequestVariant1 => CreateArtifactReadToolConfigurationRequestVariant1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateArtifactReadToolConfigurationRequest(global::Vectara.CreateArtifactReadToolConfigurationRequestVariant1 value) => new CreateArtifactReadToolConfigurationRequest((global::Vectara.CreateArtifactReadToolConfigurationRequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateArtifactReadToolConfigurationRequestVariant1?(CreateArtifactReadToolConfigurationRequest @this) => @this.CreateArtifactReadToolConfigurationRequestVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CreateArtifactReadToolConfigurationRequest(global::Vectara.CreateArtifactReadToolConfigurationRequestVariant1? value)
        {
            CreateArtifactReadToolConfigurationRequestVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateArtifactReadToolConfigurationRequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateArtifactReadToolConfigurationRequestVariant1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateArtifactReadToolConfigurationRequestVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateArtifactReadToolConfigurationRequestVariant1?, TResult>? createArtifactReadToolConfigurationRequestVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateArtifactReadToolConfigurationRequestVariant1 && createArtifactReadToolConfigurationRequestVariant1 != null)
            {
                return createArtifactReadToolConfigurationRequestVariant1(CreateArtifactReadToolConfigurationRequestVariant1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateArtifactReadToolConfigurationRequestVariant1?>? createArtifactReadToolConfigurationRequestVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateArtifactReadToolConfigurationRequestVariant1)
            {
                createArtifactReadToolConfigurationRequestVariant1?.Invoke(CreateArtifactReadToolConfigurationRequestVariant1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateArtifactReadToolConfigurationRequestVariant1,
                typeof(global::Vectara.CreateArtifactReadToolConfigurationRequestVariant1),
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
        public bool Equals(CreateArtifactReadToolConfigurationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateArtifactReadToolConfigurationRequestVariant1?>.Default.Equals(CreateArtifactReadToolConfigurationRequestVariant1, other.CreateArtifactReadToolConfigurationRequestVariant1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateArtifactReadToolConfigurationRequest obj1, CreateArtifactReadToolConfigurationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateArtifactReadToolConfigurationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateArtifactReadToolConfigurationRequest obj1, CreateArtifactReadToolConfigurationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateArtifactReadToolConfigurationRequest o && Equals(o);
        }
    }
}
