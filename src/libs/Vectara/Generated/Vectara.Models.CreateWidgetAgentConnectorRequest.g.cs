#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for creating a web widget connector.
    /// </summary>
    public readonly partial struct CreateWidgetAgentConnectorRequest : global::System.IEquatable<CreateWidgetAgentConnectorRequest>
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
        public global::Vectara.CreateWidgetAgentConnectorRequestVariant2? CreateWidgetAgentConnectorRequestVariant2 { get; init; }
#else
        public global::Vectara.CreateWidgetAgentConnectorRequestVariant2? CreateWidgetAgentConnectorRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateWidgetAgentConnectorRequestVariant2))]
#endif
        public bool IsCreateWidgetAgentConnectorRequestVariant2 => CreateWidgetAgentConnectorRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateWidgetAgentConnectorRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateWidgetAgentConnectorRequestVariant2? value)
        {
            value = CreateWidgetAgentConnectorRequestVariant2;
            return IsCreateWidgetAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateWidgetAgentConnectorRequestVariant2 PickCreateWidgetAgentConnectorRequestVariant2() => IsCreateWidgetAgentConnectorRequestVariant2
            ? CreateWidgetAgentConnectorRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateWidgetAgentConnectorRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateWidgetAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestBase value) => new CreateWidgetAgentConnectorRequest((global::Vectara.CreateAgentConnectorRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateAgentConnectorRequestBase?(CreateWidgetAgentConnectorRequest @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public CreateWidgetAgentConnectorRequest(global::Vectara.CreateAgentConnectorRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateWidgetAgentConnectorRequest FromBase(global::Vectara.CreateAgentConnectorRequestBase? value) => new CreateWidgetAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateWidgetAgentConnectorRequest(global::Vectara.CreateWidgetAgentConnectorRequestVariant2 value) => new CreateWidgetAgentConnectorRequest((global::Vectara.CreateWidgetAgentConnectorRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateWidgetAgentConnectorRequestVariant2?(CreateWidgetAgentConnectorRequest @this) => @this.CreateWidgetAgentConnectorRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public CreateWidgetAgentConnectorRequest(global::Vectara.CreateWidgetAgentConnectorRequestVariant2? value)
        {
            CreateWidgetAgentConnectorRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateWidgetAgentConnectorRequest FromCreateWidgetAgentConnectorRequestVariant2(global::Vectara.CreateWidgetAgentConnectorRequestVariant2? value) => new CreateWidgetAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateWidgetAgentConnectorRequest(
            global::Vectara.CreateAgentConnectorRequestBase? @base,
            global::Vectara.CreateWidgetAgentConnectorRequestVariant2? createWidgetAgentConnectorRequestVariant2
            )
        {
            Base = @base;
            CreateWidgetAgentConnectorRequestVariant2 = createWidgetAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateWidgetAgentConnectorRequestVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateWidgetAgentConnectorRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateWidgetAgentConnectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateAgentConnectorRequestBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateWidgetAgentConnectorRequestVariant2, TResult>? createWidgetAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateWidgetAgentConnectorRequestVariant2 && createWidgetAgentConnectorRequestVariant2 != null)
            {
                return createWidgetAgentConnectorRequestVariant2(CreateWidgetAgentConnectorRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateAgentConnectorRequestBase>? @base = null,

            global::System.Action<global::Vectara.CreateWidgetAgentConnectorRequestVariant2>? createWidgetAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateWidgetAgentConnectorRequestVariant2)
            {
                createWidgetAgentConnectorRequestVariant2?.Invoke(CreateWidgetAgentConnectorRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateAgentConnectorRequestBase>? @base = null,
            global::System.Action<global::Vectara.CreateWidgetAgentConnectorRequestVariant2>? createWidgetAgentConnectorRequestVariant2 = null,
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
            else if (IsCreateWidgetAgentConnectorRequestVariant2)
            {
                createWidgetAgentConnectorRequestVariant2?.Invoke(CreateWidgetAgentConnectorRequestVariant2!);
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
                CreateWidgetAgentConnectorRequestVariant2,
                typeof(global::Vectara.CreateWidgetAgentConnectorRequestVariant2),
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
        public bool Equals(CreateWidgetAgentConnectorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateAgentConnectorRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateWidgetAgentConnectorRequestVariant2?>.Default.Equals(CreateWidgetAgentConnectorRequestVariant2, other.CreateWidgetAgentConnectorRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateWidgetAgentConnectorRequest obj1, CreateWidgetAgentConnectorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateWidgetAgentConnectorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateWidgetAgentConnectorRequest obj1, CreateWidgetAgentConnectorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateWidgetAgentConnectorRequest o && Equals(o);
        }
    }
}
