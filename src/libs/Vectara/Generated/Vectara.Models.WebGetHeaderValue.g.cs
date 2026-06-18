#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// The value for a single HTTP header in the web_get tool.<br/>
    /// Either a literal string or an EagerReference ({"$ref": "agent.secrets.foo"}) that resolves at session start so the secret value never appears in the tool configuration.
    /// </summary>
    public readonly partial struct WebGetHeaderValue : global::System.IEquatable<WebGetHeaderValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? WebGetHeaderValueVariant1 { get; init; }
#else
        public string? WebGetHeaderValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebGetHeaderValueVariant1))]
#endif
        public bool IsWebGetHeaderValueVariant1 => WebGetHeaderValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebGetHeaderValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = WebGetHeaderValueVariant1;
            return IsWebGetHeaderValueVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickWebGetHeaderValueVariant1() => IsWebGetHeaderValueVariant1
            ? WebGetHeaderValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebGetHeaderValueVariant1' but the value was {ToString()}.");

        /// <summary>
        /// A reference to a value resolved from the session context at the start of each turn. Resolution occurs when a new message is submitted to the agent session, before any LLM processing begins. The resolved value remains constant throughout the turn and is not re-evaluated during the agent's response or subsequent tool calls within the same turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.EagerReference? EagerReference { get; init; }
#else
        public global::Vectara.EagerReference? EagerReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EagerReference))]
#endif
        public bool IsEagerReference => EagerReference != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEagerReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.EagerReference? value)
        {
            value = EagerReference;
            return IsEagerReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.EagerReference PickEagerReference() => IsEagerReference
            ? EagerReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EagerReference' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebGetHeaderValue(string value) => new WebGetHeaderValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(WebGetHeaderValue @this) => @this.WebGetHeaderValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public WebGetHeaderValue(string? value)
        {
            WebGetHeaderValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebGetHeaderValue FromWebGetHeaderValueVariant1(string? value) => new WebGetHeaderValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebGetHeaderValue(global::Vectara.EagerReference value) => new WebGetHeaderValue((global::Vectara.EagerReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.EagerReference?(WebGetHeaderValue @this) => @this.EagerReference;

        /// <summary>
        /// 
        /// </summary>
        public WebGetHeaderValue(global::Vectara.EagerReference? value)
        {
            EagerReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebGetHeaderValue FromEagerReference(global::Vectara.EagerReference? value) => new WebGetHeaderValue(value);

        /// <summary>
        /// 
        /// </summary>
        public WebGetHeaderValue(
            string? webGetHeaderValueVariant1,
            global::Vectara.EagerReference? eagerReference
            )
        {
            WebGetHeaderValueVariant1 = webGetHeaderValueVariant1;
            EagerReference = eagerReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EagerReference as object ??
            WebGetHeaderValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WebGetHeaderValueVariant1?.ToString() ??
            EagerReference?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebGetHeaderValueVariant1 && !IsEagerReference || !IsWebGetHeaderValueVariant1 && IsEagerReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? webGetHeaderValueVariant1 = null,
            global::System.Func<global::Vectara.EagerReference, TResult>? eagerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebGetHeaderValueVariant1 && webGetHeaderValueVariant1 != null)
            {
                return webGetHeaderValueVariant1(WebGetHeaderValueVariant1!);
            }
            else if (IsEagerReference && eagerReference != null)
            {
                return eagerReference(EagerReference!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? webGetHeaderValueVariant1 = null,

            global::System.Action<global::Vectara.EagerReference>? eagerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebGetHeaderValueVariant1)
            {
                webGetHeaderValueVariant1?.Invoke(WebGetHeaderValueVariant1!);
            }
            else if (IsEagerReference)
            {
                eagerReference?.Invoke(EagerReference!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? webGetHeaderValueVariant1 = null,
            global::System.Action<global::Vectara.EagerReference>? eagerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebGetHeaderValueVariant1)
            {
                webGetHeaderValueVariant1?.Invoke(WebGetHeaderValueVariant1!);
            }
            else if (IsEagerReference)
            {
                eagerReference?.Invoke(EagerReference!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebGetHeaderValueVariant1,
                typeof(string),
                EagerReference,
                typeof(global::Vectara.EagerReference),
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
        public bool Equals(WebGetHeaderValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(WebGetHeaderValueVariant1, other.WebGetHeaderValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EagerReference?>.Default.Equals(EagerReference, other.EagerReference) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebGetHeaderValue obj1, WebGetHeaderValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebGetHeaderValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebGetHeaderValue obj1, WebGetHeaderValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebGetHeaderValue o && Equals(o);
        }
    }
}
