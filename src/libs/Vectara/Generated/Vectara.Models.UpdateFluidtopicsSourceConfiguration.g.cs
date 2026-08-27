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
        /// Knowledge Hub REST API. `content_scope` selects which layer to ingest:<br/>
        /// - `documents`: standalone items.<br/>
        /// - `topics`: the sections inside maps, each carrying its parent map's identity and classification.<br/>
        /// - `maps`: whole maps, one record each.<br/>
        /// Every record carries its full Fluid Topics metadata, including classification and entitlement<br/>
        /// fields, as document metadata for attribute-based filtering and access control. Requires a<br/>
        /// Fluid Topics API key with read access to the configured content. Incremental runs that read<br/>
        /// dataflow reports additionally require administration scope.<br/>
        /// Unless `query` is set to a value other than `*` in the `documents` or `topics` scope,<br/>
        /// incremental runs read the tenant's dataflow reports since the previous run's watermark and<br/>
        /// ingest the content those reports flag as created or updated, including metadata-only changes.<br/>
        /// Such a run fails when its watermark window holds more than 1000 reports, and a full refresh<br/>
        /// is required to resync. Content the reports flag as deleted is not removed from the corpus.<br/>
        /// Full-refresh runs — and the first run, which has no watermark yet — enumerate all content.
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
