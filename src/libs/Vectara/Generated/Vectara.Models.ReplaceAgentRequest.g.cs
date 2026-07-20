#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Full replacement of an existing agent. Accepts every field that agent creation accepts;<br/>
    /// created_at and updated_at may be included but are ignored, so the body returned by<br/>
    /// getAgent can be sent back unmodified.
    /// </summary>
    public readonly partial struct ReplaceAgentRequest : global::System.IEquatable<ReplaceAgentRequest>
    {
        /// <summary>
        /// Request object for creating a new agent.<br/>
        /// The entry point must be defined via first_step_name (preferred) or first_step (deprecated).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateAgentRequest? Create { get; init; }
#else
        public global::Vectara.CreateAgentRequest? Create { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Create))]
#endif
        public bool IsCreate => Create != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateAgentRequest? value)
        {
            value = Create;
            return IsCreate;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateAgentRequest PickCreate() => IsCreate
            ? Create!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Create' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ReplaceAgentRequestVariant2? ReplaceAgentRequestVariant2 { get; init; }
#else
        public global::Vectara.ReplaceAgentRequestVariant2? ReplaceAgentRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReplaceAgentRequestVariant2))]
#endif
        public bool IsReplaceAgentRequestVariant2 => ReplaceAgentRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReplaceAgentRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ReplaceAgentRequestVariant2? value)
        {
            value = ReplaceAgentRequestVariant2;
            return IsReplaceAgentRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ReplaceAgentRequestVariant2 PickReplaceAgentRequestVariant2() => IsReplaceAgentRequestVariant2
            ? ReplaceAgentRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReplaceAgentRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReplaceAgentRequest(global::Vectara.CreateAgentRequest value) => new ReplaceAgentRequest((global::Vectara.CreateAgentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateAgentRequest?(ReplaceAgentRequest @this) => @this.Create;

        /// <summary>
        /// 
        /// </summary>
        public ReplaceAgentRequest(global::Vectara.CreateAgentRequest? value)
        {
            Create = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReplaceAgentRequest FromCreate(global::Vectara.CreateAgentRequest? value) => new ReplaceAgentRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReplaceAgentRequest(global::Vectara.ReplaceAgentRequestVariant2 value) => new ReplaceAgentRequest((global::Vectara.ReplaceAgentRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ReplaceAgentRequestVariant2?(ReplaceAgentRequest @this) => @this.ReplaceAgentRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ReplaceAgentRequest(global::Vectara.ReplaceAgentRequestVariant2? value)
        {
            ReplaceAgentRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReplaceAgentRequest FromReplaceAgentRequestVariant2(global::Vectara.ReplaceAgentRequestVariant2? value) => new ReplaceAgentRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public ReplaceAgentRequest(
            global::Vectara.CreateAgentRequest? create,
            global::Vectara.ReplaceAgentRequestVariant2? replaceAgentRequestVariant2
            )
        {
            Create = create;
            ReplaceAgentRequestVariant2 = replaceAgentRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReplaceAgentRequestVariant2 as object ??
            Create as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Create?.ToString() ??
            ReplaceAgentRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreate && IsReplaceAgentRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateAgentRequest, TResult>? create = null,
            global::System.Func<global::Vectara.ReplaceAgentRequestVariant2, TResult>? replaceAgentRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreate && create != null)
            {
                return create(Create!);
            }
            else if (IsReplaceAgentRequestVariant2 && replaceAgentRequestVariant2 != null)
            {
                return replaceAgentRequestVariant2(ReplaceAgentRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateAgentRequest>? create = null,

            global::System.Action<global::Vectara.ReplaceAgentRequestVariant2>? replaceAgentRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreate)
            {
                create?.Invoke(Create!);
            }
            else if (IsReplaceAgentRequestVariant2)
            {
                replaceAgentRequestVariant2?.Invoke(ReplaceAgentRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateAgentRequest>? create = null,
            global::System.Action<global::Vectara.ReplaceAgentRequestVariant2>? replaceAgentRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreate)
            {
                create?.Invoke(Create!);
            }
            else if (IsReplaceAgentRequestVariant2)
            {
                replaceAgentRequestVariant2?.Invoke(ReplaceAgentRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Create,
                typeof(global::Vectara.CreateAgentRequest),
                ReplaceAgentRequestVariant2,
                typeof(global::Vectara.ReplaceAgentRequestVariant2),
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
        public bool Equals(ReplaceAgentRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateAgentRequest?>.Default.Equals(Create, other.Create) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ReplaceAgentRequestVariant2?>.Default.Equals(ReplaceAgentRequestVariant2, other.ReplaceAgentRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReplaceAgentRequest obj1, ReplaceAgentRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReplaceAgentRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReplaceAgentRequest obj1, ReplaceAgentRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReplaceAgentRequest o && Equals(o);
        }
    }
}
