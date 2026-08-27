#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for creating a Zoom Contact Center connector.
    /// </summary>
    public readonly partial struct CreateZoomAgentConnectorRequest : global::System.IEquatable<CreateZoomAgentConnectorRequest>
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
        public global::Vectara.CreateZoomAgentConnectorRequestVariant2? CreateZoomAgentConnectorRequestVariant2 { get; init; }
#else
        public global::Vectara.CreateZoomAgentConnectorRequestVariant2? CreateZoomAgentConnectorRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateZoomAgentConnectorRequestVariant2))]
#endif
        public bool IsCreateZoomAgentConnectorRequestVariant2 => CreateZoomAgentConnectorRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateZoomAgentConnectorRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateZoomAgentConnectorRequestVariant2? value)
        {
            value = CreateZoomAgentConnectorRequestVariant2;
            return IsCreateZoomAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateZoomAgentConnectorRequestVariant2 PickCreateZoomAgentConnectorRequestVariant2() => IsCreateZoomAgentConnectorRequestVariant2
            ? CreateZoomAgentConnectorRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateZoomAgentConnectorRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateZoomAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestBase value) => new CreateZoomAgentConnectorRequest((global::Vectara.CreateAgentConnectorRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateAgentConnectorRequestBase?(CreateZoomAgentConnectorRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public CreateZoomAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateZoomAgentConnectorRequest FromBase(global::Vectara.CreateAgentConnectorRequestBase? value) => new CreateZoomAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateZoomAgentConnectorRequest(global::Vectara.CreateZoomAgentConnectorRequestVariant2 value) => new CreateZoomAgentConnectorRequest((global::Vectara.CreateZoomAgentConnectorRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateZoomAgentConnectorRequestVariant2?(CreateZoomAgentConnectorRequest @this) => @this.CreateZoomAgentConnectorRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public CreateZoomAgentConnectorRequest(global::Vectara.CreateZoomAgentConnectorRequestVariant2? value)
        {
            CreateZoomAgentConnectorRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateZoomAgentConnectorRequest FromCreateZoomAgentConnectorRequestVariant2(global::Vectara.CreateZoomAgentConnectorRequestVariant2? value) => new CreateZoomAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateZoomAgentConnectorRequest(
            global::Vectara.CreateAgentConnectorRequestBase? @base,
            global::Vectara.CreateZoomAgentConnectorRequestVariant2? createZoomAgentConnectorRequestVariant2
            )
        {
            Base = @base;
            CreateZoomAgentConnectorRequestVariant2 = createZoomAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateZoomAgentConnectorRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateZoomAgentConnectorRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateZoomAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateAgentConnectorRequestBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateZoomAgentConnectorRequestVariant2, TResult>? createZoomAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateZoomAgentConnectorRequestVariant2 && createZoomAgentConnectorRequestVariant2 != null)
            {
                return createZoomAgentConnectorRequestVariant2(CreateZoomAgentConnectorRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateAgentConnectorRequestBase>? @base = null,

            global::System.Action<global::Vectara.CreateZoomAgentConnectorRequestVariant2>? createZoomAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateZoomAgentConnectorRequestVariant2)
            {
                createZoomAgentConnectorRequestVariant2?.Invoke(CreateZoomAgentConnectorRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateAgentConnectorRequestBase>? @base = null,
            global::System.Action<global::Vectara.CreateZoomAgentConnectorRequestVariant2>? createZoomAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateZoomAgentConnectorRequestVariant2)
            {
                createZoomAgentConnectorRequestVariant2?.Invoke(CreateZoomAgentConnectorRequestVariant2!);
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
                CreateZoomAgentConnectorRequestVariant2,
                typeof(global::Vectara.CreateZoomAgentConnectorRequestVariant2),
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
        public bool Equals(CreateZoomAgentConnectorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateAgentConnectorRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateZoomAgentConnectorRequestVariant2?>.Default.Equals(CreateZoomAgentConnectorRequestVariant2, other.CreateZoomAgentConnectorRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateZoomAgentConnectorRequest obj1, CreateZoomAgentConnectorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateZoomAgentConnectorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateZoomAgentConnectorRequest obj1, CreateZoomAgentConnectorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateZoomAgentConnectorRequest o && Equals(o);
        }
    }
}
