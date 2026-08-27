#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for creating a Google Chat connector.
    /// </summary>
    public readonly partial struct CreateGchatAgentConnectorRequest : global::System.IEquatable<CreateGchatAgentConnectorRequest>
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
        public global::Vectara.CreateGchatAgentConnectorRequestVariant2? CreateGchatAgentConnectorRequestVariant2 { get; init; }
#else
        public global::Vectara.CreateGchatAgentConnectorRequestVariant2? CreateGchatAgentConnectorRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateGchatAgentConnectorRequestVariant2))]
#endif
        public bool IsCreateGchatAgentConnectorRequestVariant2 => CreateGchatAgentConnectorRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateGchatAgentConnectorRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateGchatAgentConnectorRequestVariant2? value)
        {
            value = CreateGchatAgentConnectorRequestVariant2;
            return IsCreateGchatAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGchatAgentConnectorRequestVariant2 PickCreateGchatAgentConnectorRequestVariant2() => IsCreateGchatAgentConnectorRequestVariant2
            ? CreateGchatAgentConnectorRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateGchatAgentConnectorRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateGchatAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestBase value) => new CreateGchatAgentConnectorRequest((global::Vectara.CreateAgentConnectorRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateAgentConnectorRequestBase?(CreateGchatAgentConnectorRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public CreateGchatAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateGchatAgentConnectorRequest FromBase(global::Vectara.CreateAgentConnectorRequestBase? value) => new CreateGchatAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateGchatAgentConnectorRequest(global::Vectara.CreateGchatAgentConnectorRequestVariant2 value) => new CreateGchatAgentConnectorRequest((global::Vectara.CreateGchatAgentConnectorRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateGchatAgentConnectorRequestVariant2?(CreateGchatAgentConnectorRequest @this) => @this.CreateGchatAgentConnectorRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public CreateGchatAgentConnectorRequest(global::Vectara.CreateGchatAgentConnectorRequestVariant2? value)
        {
            CreateGchatAgentConnectorRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateGchatAgentConnectorRequest FromCreateGchatAgentConnectorRequestVariant2(global::Vectara.CreateGchatAgentConnectorRequestVariant2? value) => new CreateGchatAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateGchatAgentConnectorRequest(
            global::Vectara.CreateAgentConnectorRequestBase? @base,
            global::Vectara.CreateGchatAgentConnectorRequestVariant2? createGchatAgentConnectorRequestVariant2
            )
        {
            Base = @base;
            CreateGchatAgentConnectorRequestVariant2 = createGchatAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateGchatAgentConnectorRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateGchatAgentConnectorRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateGchatAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateAgentConnectorRequestBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateGchatAgentConnectorRequestVariant2, TResult>? createGchatAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateGchatAgentConnectorRequestVariant2 && createGchatAgentConnectorRequestVariant2 != null)
            {
                return createGchatAgentConnectorRequestVariant2(CreateGchatAgentConnectorRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateAgentConnectorRequestBase>? @base = null,

            global::System.Action<global::Vectara.CreateGchatAgentConnectorRequestVariant2>? createGchatAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateGchatAgentConnectorRequestVariant2)
            {
                createGchatAgentConnectorRequestVariant2?.Invoke(CreateGchatAgentConnectorRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateAgentConnectorRequestBase>? @base = null,
            global::System.Action<global::Vectara.CreateGchatAgentConnectorRequestVariant2>? createGchatAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateGchatAgentConnectorRequestVariant2)
            {
                createGchatAgentConnectorRequestVariant2?.Invoke(CreateGchatAgentConnectorRequestVariant2!);
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
                CreateGchatAgentConnectorRequestVariant2,
                typeof(global::Vectara.CreateGchatAgentConnectorRequestVariant2),
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
        public bool Equals(CreateGchatAgentConnectorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateAgentConnectorRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateGchatAgentConnectorRequestVariant2?>.Default.Equals(CreateGchatAgentConnectorRequestVariant2, other.CreateGchatAgentConnectorRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateGchatAgentConnectorRequest obj1, CreateGchatAgentConnectorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateGchatAgentConnectorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateGchatAgentConnectorRequest obj1, CreateGchatAgentConnectorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateGchatAgentConnectorRequest o && Equals(o);
        }
    }
}
