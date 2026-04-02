#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a reusable configuration for a web get tool with predefined parameters that can be applied to agents.
    /// </summary>
    public readonly partial struct CreateWebGetToolConfigurationRequest : global::System.IEquatable<CreateWebGetToolConfigurationRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateWebGetToolConfigurationRequestVariant1? CreateWebGetToolConfigurationRequestVariant1 { get; init; }
#else
        public global::Vectara.CreateWebGetToolConfigurationRequestVariant1? CreateWebGetToolConfigurationRequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateWebGetToolConfigurationRequestVariant1))]
#endif
        public bool IsCreateWebGetToolConfigurationRequestVariant1 => CreateWebGetToolConfigurationRequestVariant1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateWebGetToolConfigurationRequest(global::Vectara.CreateWebGetToolConfigurationRequestVariant1 value) => new CreateWebGetToolConfigurationRequest((global::Vectara.CreateWebGetToolConfigurationRequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateWebGetToolConfigurationRequestVariant1?(CreateWebGetToolConfigurationRequest @this) => @this.CreateWebGetToolConfigurationRequestVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CreateWebGetToolConfigurationRequest(global::Vectara.CreateWebGetToolConfigurationRequestVariant1? value)
        {
            CreateWebGetToolConfigurationRequestVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateWebGetToolConfigurationRequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateWebGetToolConfigurationRequestVariant1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateWebGetToolConfigurationRequestVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateWebGetToolConfigurationRequestVariant1?, TResult>? createWebGetToolConfigurationRequestVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateWebGetToolConfigurationRequestVariant1 && createWebGetToolConfigurationRequestVariant1 != null)
            {
                return createWebGetToolConfigurationRequestVariant1(CreateWebGetToolConfigurationRequestVariant1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateWebGetToolConfigurationRequestVariant1?>? createWebGetToolConfigurationRequestVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateWebGetToolConfigurationRequestVariant1)
            {
                createWebGetToolConfigurationRequestVariant1?.Invoke(CreateWebGetToolConfigurationRequestVariant1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateWebGetToolConfigurationRequestVariant1,
                typeof(global::Vectara.CreateWebGetToolConfigurationRequestVariant1),
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
        public bool Equals(CreateWebGetToolConfigurationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateWebGetToolConfigurationRequestVariant1?>.Default.Equals(CreateWebGetToolConfigurationRequestVariant1, other.CreateWebGetToolConfigurationRequestVariant1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateWebGetToolConfigurationRequest obj1, CreateWebGetToolConfigurationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateWebGetToolConfigurationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateWebGetToolConfigurationRequest obj1, CreateWebGetToolConfigurationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateWebGetToolConfigurationRequest o && Equals(o);
        }
    }
}
