#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to update a reusable configuration for an artifact read tool with predefined parameters.
    /// </summary>
    public readonly partial struct UpdateArtifactReadToolConfigurationRequest : global::System.IEquatable<UpdateArtifactReadToolConfigurationRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1? UpdateArtifactReadToolConfigurationRequestVariant1 { get; init; }
#else
        public global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1? UpdateArtifactReadToolConfigurationRequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateArtifactReadToolConfigurationRequestVariant1))]
#endif
        public bool IsUpdateArtifactReadToolConfigurationRequestVariant1 => UpdateArtifactReadToolConfigurationRequestVariant1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateArtifactReadToolConfigurationRequest(global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1 value) => new UpdateArtifactReadToolConfigurationRequest((global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1?(UpdateArtifactReadToolConfigurationRequest @this) => @this.UpdateArtifactReadToolConfigurationRequestVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UpdateArtifactReadToolConfigurationRequest(global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1? value)
        {
            UpdateArtifactReadToolConfigurationRequestVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateArtifactReadToolConfigurationRequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UpdateArtifactReadToolConfigurationRequestVariant1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUpdateArtifactReadToolConfigurationRequestVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1?, TResult>? updateArtifactReadToolConfigurationRequestVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateArtifactReadToolConfigurationRequestVariant1 && updateArtifactReadToolConfigurationRequestVariant1 != null)
            {
                return updateArtifactReadToolConfigurationRequestVariant1(UpdateArtifactReadToolConfigurationRequestVariant1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1?>? updateArtifactReadToolConfigurationRequestVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateArtifactReadToolConfigurationRequestVariant1)
            {
                updateArtifactReadToolConfigurationRequestVariant1?.Invoke(UpdateArtifactReadToolConfigurationRequestVariant1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UpdateArtifactReadToolConfigurationRequestVariant1,
                typeof(global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1),
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
        public bool Equals(UpdateArtifactReadToolConfigurationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateArtifactReadToolConfigurationRequestVariant1?>.Default.Equals(UpdateArtifactReadToolConfigurationRequestVariant1, other.UpdateArtifactReadToolConfigurationRequestVariant1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateArtifactReadToolConfigurationRequest obj1, UpdateArtifactReadToolConfigurationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateArtifactReadToolConfigurationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateArtifactReadToolConfigurationRequest obj1, UpdateArtifactReadToolConfigurationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateArtifactReadToolConfigurationRequest o && Equals(o);
        }
    }
}
