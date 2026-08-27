#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for creating a Slack connector.
    /// </summary>
    public readonly partial struct CreateSlackAgentConnectorRequest : global::System.IEquatable<CreateSlackAgentConnectorRequest>
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
        public global::Vectara.CreateSlackAgentConnectorRequestVariant2? CreateSlackAgentConnectorRequestVariant2 { get; init; }
#else
        public global::Vectara.CreateSlackAgentConnectorRequestVariant2? CreateSlackAgentConnectorRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateSlackAgentConnectorRequestVariant2))]
#endif
        public bool IsCreateSlackAgentConnectorRequestVariant2 => CreateSlackAgentConnectorRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateSlackAgentConnectorRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateSlackAgentConnectorRequestVariant2? value)
        {
            value = CreateSlackAgentConnectorRequestVariant2;
            return IsCreateSlackAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateSlackAgentConnectorRequestVariant2 PickCreateSlackAgentConnectorRequestVariant2() => IsCreateSlackAgentConnectorRequestVariant2
            ? CreateSlackAgentConnectorRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateSlackAgentConnectorRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateSlackAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestBase value) => new CreateSlackAgentConnectorRequest((global::Vectara.CreateAgentConnectorRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateAgentConnectorRequestBase?(CreateSlackAgentConnectorRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public CreateSlackAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateSlackAgentConnectorRequest FromBase(global::Vectara.CreateAgentConnectorRequestBase? value) => new CreateSlackAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateSlackAgentConnectorRequest(global::Vectara.CreateSlackAgentConnectorRequestVariant2 value) => new CreateSlackAgentConnectorRequest((global::Vectara.CreateSlackAgentConnectorRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateSlackAgentConnectorRequestVariant2?(CreateSlackAgentConnectorRequest @this) => @this.CreateSlackAgentConnectorRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public CreateSlackAgentConnectorRequest(global::Vectara.CreateSlackAgentConnectorRequestVariant2? value)
        {
            CreateSlackAgentConnectorRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateSlackAgentConnectorRequest FromCreateSlackAgentConnectorRequestVariant2(global::Vectara.CreateSlackAgentConnectorRequestVariant2? value) => new CreateSlackAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateSlackAgentConnectorRequest(
            global::Vectara.CreateAgentConnectorRequestBase? @base,
            global::Vectara.CreateSlackAgentConnectorRequestVariant2? createSlackAgentConnectorRequestVariant2
            )
        {
            Base = @base;
            CreateSlackAgentConnectorRequestVariant2 = createSlackAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateSlackAgentConnectorRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateSlackAgentConnectorRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateSlackAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateAgentConnectorRequestBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateSlackAgentConnectorRequestVariant2, TResult>? createSlackAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateSlackAgentConnectorRequestVariant2 && createSlackAgentConnectorRequestVariant2 != null)
            {
                return createSlackAgentConnectorRequestVariant2(CreateSlackAgentConnectorRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateAgentConnectorRequestBase>? @base = null,

            global::System.Action<global::Vectara.CreateSlackAgentConnectorRequestVariant2>? createSlackAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateSlackAgentConnectorRequestVariant2)
            {
                createSlackAgentConnectorRequestVariant2?.Invoke(CreateSlackAgentConnectorRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateAgentConnectorRequestBase>? @base = null,
            global::System.Action<global::Vectara.CreateSlackAgentConnectorRequestVariant2>? createSlackAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateSlackAgentConnectorRequestVariant2)
            {
                createSlackAgentConnectorRequestVariant2?.Invoke(CreateSlackAgentConnectorRequestVariant2!);
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
                CreateSlackAgentConnectorRequestVariant2,
                typeof(global::Vectara.CreateSlackAgentConnectorRequestVariant2),
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
        public bool Equals(CreateSlackAgentConnectorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateAgentConnectorRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateSlackAgentConnectorRequestVariant2?>.Default.Equals(CreateSlackAgentConnectorRequestVariant2, other.CreateSlackAgentConnectorRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateSlackAgentConnectorRequest obj1, CreateSlackAgentConnectorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSlackAgentConnectorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateSlackAgentConnectorRequest obj1, CreateSlackAgentConnectorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSlackAgentConnectorRequest o && Equals(o);
        }
    }
}
