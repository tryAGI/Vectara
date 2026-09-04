#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for creating a new agent connector. The connector type is<br/>
    /// taken from `configuration.type`. The top-level `type` is an optional<br/>
    /// confirmation of it: when supplied it must equal `configuration.type` or the<br/>
    /// request is rejected with `400`; when omitted the type is inferred from the<br/>
    /// configuration. The created connector is returned as `AgentConnector`.
    /// </summary>
    public readonly partial struct CreateAgentConnectorRequest : global::System.IEquatable<CreateAgentConnectorRequest>
    {
        /// <summary>
        /// Properties shared by every connector create request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateAgentConnectorRequestBase? Base { get; init; }
#else
        public global::Vectara.CreateAgentConnectorRequestBase? Base { get; }
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
            out global::Vectara.CreateAgentConnectorRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateAgentConnectorRequestVariant2? CreateAgentConnectorRequestVariant2 { get; init; }
#else
        public global::Vectara.CreateAgentConnectorRequestVariant2? CreateAgentConnectorRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateAgentConnectorRequestVariant2))]
#endif
        public bool IsCreateAgentConnectorRequestVariant2 => CreateAgentConnectorRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateAgentConnectorRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateAgentConnectorRequestVariant2? value)
        {
            value = CreateAgentConnectorRequestVariant2;
            return IsCreateAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestVariant2 PickCreateAgentConnectorRequestVariant2() => IsCreateAgentConnectorRequestVariant2
            ? CreateAgentConnectorRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateAgentConnectorRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestBase value) => new CreateAgentConnectorRequest((global::Vectara.CreateAgentConnectorRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateAgentConnectorRequestBase?(CreateAgentConnectorRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public CreateAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateAgentConnectorRequest FromBase(global::Vectara.CreateAgentConnectorRequestBase? value) => new CreateAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestVariant2 value) => new CreateAgentConnectorRequest((global::Vectara.CreateAgentConnectorRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateAgentConnectorRequestVariant2?(CreateAgentConnectorRequest @this) => @this.CreateAgentConnectorRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public CreateAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestVariant2? value)
        {
            CreateAgentConnectorRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateAgentConnectorRequest FromCreateAgentConnectorRequestVariant2(global::Vectara.CreateAgentConnectorRequestVariant2? value) => new CreateAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateAgentConnectorRequest(
            global::Vectara.CreateAgentConnectorRequestBase? @base,
            global::Vectara.CreateAgentConnectorRequestVariant2? createAgentConnectorRequestVariant2
            )
        {
            Base = @base;
            CreateAgentConnectorRequestVariant2 = createAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateAgentConnectorRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateAgentConnectorRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateAgentConnectorRequestBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateAgentConnectorRequestVariant2, TResult>? createAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateAgentConnectorRequestVariant2 && createAgentConnectorRequestVariant2 != null)
            {
                return createAgentConnectorRequestVariant2(CreateAgentConnectorRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateAgentConnectorRequestBase>? @base = null,

            global::System.Action<global::Vectara.CreateAgentConnectorRequestVariant2>? createAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateAgentConnectorRequestVariant2)
            {
                createAgentConnectorRequestVariant2?.Invoke(CreateAgentConnectorRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateAgentConnectorRequestBase>? @base = null,
            global::System.Action<global::Vectara.CreateAgentConnectorRequestVariant2>? createAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateAgentConnectorRequestVariant2)
            {
                createAgentConnectorRequestVariant2?.Invoke(CreateAgentConnectorRequestVariant2!);
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
                typeof(global::Vectara.CreateAgentConnectorRequestBase),
                CreateAgentConnectorRequestVariant2,
                typeof(global::Vectara.CreateAgentConnectorRequestVariant2),
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
        public bool Equals(CreateAgentConnectorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateAgentConnectorRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateAgentConnectorRequestVariant2?>.Default.Equals(CreateAgentConnectorRequestVariant2, other.CreateAgentConnectorRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateAgentConnectorRequest obj1, CreateAgentConnectorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAgentConnectorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateAgentConnectorRequest obj1, CreateAgentConnectorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAgentConnectorRequest o && Equals(o);
        }
    }
}
