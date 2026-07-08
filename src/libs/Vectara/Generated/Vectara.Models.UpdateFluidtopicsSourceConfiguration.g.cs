#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Partial update for Fluid Topics source configuration. Only provided fields are merged.
    /// </summary>
    public readonly partial struct UpdateFluidtopicsSourceConfiguration : global::System.IEquatable<UpdateFluidtopicsSourceConfiguration>
    {
        /// <summary>
        /// Base Fluid Topics source configuration. Ingests content from a Fluid Topics tenant via the<br/>
        /// Knowledge Hub REST API. `content_scope` selects which layer to ingest — `documents` (standalone<br/>
        /// items) or `topics` (the sections inside publications, each carrying its parent map's identity and<br/>
        /// classification). Every record carries its full Fluid Topics metadata, including classification and<br/>
        /// entitlement fields, as document metadata for attribute-based filtering and access control. Requires<br/>
        /// a Fluid Topics API key with read access to the configured content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseFluidtopicsSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseFluidtopicsSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseFluidtopicsSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseFluidtopicsSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateFluidtopicsSourceConfiguration(global::Vectara.BaseFluidtopicsSourceConfiguration value) => new UpdateFluidtopicsSourceConfiguration((global::Vectara.BaseFluidtopicsSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseFluidtopicsSourceConfiguration?(UpdateFluidtopicsSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public UpdateFluidtopicsSourceConfiguration(global::Vectara.BaseFluidtopicsSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateFluidtopicsSourceConfiguration FromBase(global::Vectara.BaseFluidtopicsSourceConfiguration? value) => new UpdateFluidtopicsSourceConfiguration(value);

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
            global::System.Func<global::Vectara.BaseFluidtopicsSourceConfiguration, TResult>? @base = null,
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
            global::System.Action<global::Vectara.BaseFluidtopicsSourceConfiguration>? @base = null,
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
            global::System.Action<global::Vectara.BaseFluidtopicsSourceConfiguration>? @base = null,
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
                typeof(global::Vectara.BaseFluidtopicsSourceConfiguration),
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
        public bool Equals(UpdateFluidtopicsSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseFluidtopicsSourceConfiguration?>.Default.Equals(Base, other.Base) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateFluidtopicsSourceConfiguration obj1, UpdateFluidtopicsSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateFluidtopicsSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateFluidtopicsSourceConfiguration obj1, UpdateFluidtopicsSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateFluidtopicsSourceConfiguration o && Equals(o);
        }
    }
}
