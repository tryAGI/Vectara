#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Partial update for Wolken forms source configuration. Only provided fields are merged.
    /// </summary>
    public readonly partial struct UpdateWolkenFormsSourceConfiguration : global::System.IEquatable<UpdateWolkenFormsSourceConfiguration>
    {
        /// <summary>
        /// Base Wolken ServiceDesk forms source configuration. Ingests the end-user-facing service catalog<br/>
        /// forms of a Wolken ServiceDesk instance, covering both incident forms and service request forms.<br/>
        /// Each form becomes one document carrying the form's title, description, and category. When<br/>
        /// `include_form_details` is true, the document also carries the form's FAQs, field definitions,<br/>
        /// and option values. Requires Wolken credentials with read access to the service catalog listing<br/>
        /// endpoint. When `include_form_details` is true, the credentials also need read access to the<br/>
        /// form metadata, special instructions, and lookup value endpoints.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseWolkenFormsSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseWolkenFormsSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseWolkenFormsSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseWolkenFormsSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateWolkenFormsSourceConfiguration(global::Vectara.BaseWolkenFormsSourceConfiguration value) => new UpdateWolkenFormsSourceConfiguration((global::Vectara.BaseWolkenFormsSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseWolkenFormsSourceConfiguration?(UpdateWolkenFormsSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public UpdateWolkenFormsSourceConfiguration(global::Vectara.BaseWolkenFormsSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateWolkenFormsSourceConfiguration FromBase(global::Vectara.BaseWolkenFormsSourceConfiguration? value) => new UpdateWolkenFormsSourceConfiguration(value);

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
            global::System.Func<global::Vectara.BaseWolkenFormsSourceConfiguration, TResult>? @base = null,
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
            global::System.Action<global::Vectara.BaseWolkenFormsSourceConfiguration>? @base = null,
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
            global::System.Action<global::Vectara.BaseWolkenFormsSourceConfiguration>? @base = null,
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
                typeof(global::Vectara.BaseWolkenFormsSourceConfiguration),
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
        public bool Equals(UpdateWolkenFormsSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseWolkenFormsSourceConfiguration?>.Default.Equals(Base, other.Base) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateWolkenFormsSourceConfiguration obj1, UpdateWolkenFormsSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateWolkenFormsSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateWolkenFormsSourceConfiguration obj1, UpdateWolkenFormsSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateWolkenFormsSourceConfiguration o && Equals(o);
        }
    }
}
