#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Partial update for Wolken tickets source configuration. Only provided fields are merged.<br/>
    /// An update cannot return `backfill_window` or `note_response_type_ids` to its unset state.<br/>
    /// A `null` value for either is accepted and ignored, keeping the stored value, and an empty<br/>
    /// `note_response_type_ids` is not a reset but the distinct no-notes state. To unset either<br/>
    /// field, replace the pipeline with `PUT /v2/pipelines/{pipeline_key}` using a configuration<br/>
    /// that omits it.
    /// </summary>
    public readonly partial struct UpdateWolkenTicketsSourceConfiguration : global::System.IEquatable<UpdateWolkenTicketsSourceConfiguration>
    {
        /// <summary>
        /// Base Wolken ServiceDesk tickets source configuration. Ingests incidents and service requests<br/>
        /// from a Wolken ServiceDesk instance. Each ticket becomes one document carrying the ticket<br/>
        /// subject, description, and conversation notes, with the ticket classification fields such as<br/>
        /// status, priority, category, and team as document metadata for attribute-based filtering.<br/>
        /// Requires Wolken credentials with read access to the incident and service request listing,<br/>
        /// detail, and notes endpoints.<br/>
        /// Incremental syncs read only the tickets updated since the previous run. Tickets are<br/>
        /// re-ingested when notes are added. A ticket whose notes cannot be read is not ingested.<br/>
        /// Deletions are not propagated. A ticket deleted or restricted in Wolken keeps its last<br/>
        /// indexed content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseWolkenTicketsSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseWolkenTicketsSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseWolkenTicketsSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseWolkenTicketsSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateWolkenTicketsSourceConfiguration(global::Vectara.BaseWolkenTicketsSourceConfiguration value) => new UpdateWolkenTicketsSourceConfiguration((global::Vectara.BaseWolkenTicketsSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.BaseWolkenTicketsSourceConfiguration?(UpdateWolkenTicketsSourceConfiguration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public UpdateWolkenTicketsSourceConfiguration(global::Vectara.BaseWolkenTicketsSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateWolkenTicketsSourceConfiguration FromBase(global::Vectara.BaseWolkenTicketsSourceConfiguration? value) => new UpdateWolkenTicketsSourceConfiguration(value);

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
            global::System.Func<global::Vectara.BaseWolkenTicketsSourceConfiguration, TResult>? @base = null,
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
            global::System.Action<global::Vectara.BaseWolkenTicketsSourceConfiguration>? @base = null,
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
            global::System.Action<global::Vectara.BaseWolkenTicketsSourceConfiguration>? @base = null,
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
                typeof(global::Vectara.BaseWolkenTicketsSourceConfiguration),
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
        public bool Equals(UpdateWolkenTicketsSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseWolkenTicketsSourceConfiguration?>.Default.Equals(Base, other.Base)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateWolkenTicketsSourceConfiguration obj1, UpdateWolkenTicketsSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateWolkenTicketsSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateWolkenTicketsSourceConfiguration obj1, UpdateWolkenTicketsSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateWolkenTicketsSourceConfiguration o && Equals(o);
        }
    }
}
