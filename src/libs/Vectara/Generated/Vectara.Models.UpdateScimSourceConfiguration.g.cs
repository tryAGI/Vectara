#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Partial update for SCIM source configuration. Only provided fields are merged.
    /// </summary>
    public readonly partial struct UpdateScimSourceConfiguration : global::System.IEquatable<UpdateScimSourceConfiguration>
    {
        /// <summary>
        /// Base SCIM source configuration. Ingests user records from a SCIM 2.0 service provider<br/>
        /// through the Users endpoint. Each user becomes one document carrying profile, group<br/>
        /// membership, and enterprise attributes as document metadata for attribute-based filtering.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseScimSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseScimSourceConfiguration? Base { get; }
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
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.BaseScimSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseScimSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateScimSourceConfiguration(global::Vectara.BaseScimSourceConfiguration value) => new UpdateScimSourceConfiguration((global::Vectara.BaseScimSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseScimSourceConfiguration?(UpdateScimSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public UpdateScimSourceConfiguration(global::Vectara.BaseScimSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateScimSourceConfiguration FromBase(global::Vectara.BaseScimSourceConfiguration? value) => new UpdateScimSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseScimSourceConfiguration, TResult>? @base = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseScimSourceConfiguration>? @base = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseScimSourceConfiguration>? @base = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Vectara.BaseScimSourceConfiguration),
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
        public bool Equals(UpdateScimSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseScimSourceConfiguration?>.Default.Equals(Base, other.Base) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateScimSourceConfiguration obj1, UpdateScimSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateScimSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateScimSourceConfiguration obj1, UpdateScimSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateScimSourceConfiguration o && Equals(o);
        }
    }
}
