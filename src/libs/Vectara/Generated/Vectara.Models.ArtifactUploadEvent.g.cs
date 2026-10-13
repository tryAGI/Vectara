#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Event representing files attached to an input as artifacts.<br/>
    /// This event is created when an input brings files into an agent session: either uploaded in a multipart request, or shared from another session through the `artifacts` field of an input message. The event becomes part of the session's event history, just before the input it belongs to. It contains references to all artifacts attached by that input. An uploaded file receives a new artifact identifier and is stored in the session's workspace. A shared artifact keeps its identifier.<br/>
    /// When an agent processes this event, it learns that new files are available in the session. The agent can then use its tools to read, analyze, or transform these artifacts. For example, after an upload that contains a PDF, the agent might use the document conversion tool to extract and analyze the document's contents.<br/>
    /// See the `ArtifactReference` schema for details about what artifacts are, how they are stored, their lifecycle, and how agents interact with them.
    /// </summary>
    public readonly partial struct ArtifactUploadEvent : global::System.IEquatable<ArtifactUploadEvent>
    {
        /// <summary>
        /// Base properties shared by all agent event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentEventBase? AgentBase { get; init; }
#else
        public global::Vectara.AgentEventBase? AgentBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentBase))]
#endif
        public bool IsAgentBase => AgentBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.AgentEventBase? value)
        {
            value = AgentBase;
            return IsAgentBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentEventBase PickAgentBase() => AgentBase is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ArtifactUploadEventVariant2? ArtifactUploadEventVariant2 { get; init; }
#else
        public global::Vectara.ArtifactUploadEventVariant2? ArtifactUploadEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactUploadEventVariant2))]
#endif
        public bool IsArtifactUploadEventVariant2 => ArtifactUploadEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArtifactUploadEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ArtifactUploadEventVariant2? value)
        {
            value = ArtifactUploadEventVariant2;
            return IsArtifactUploadEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ArtifactUploadEventVariant2 PickArtifactUploadEventVariant2() => ArtifactUploadEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtifactUploadEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ArtifactUploadEvent(global::Vectara.AgentEventBase value) => new ArtifactUploadEvent((global::Vectara.AgentEventBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.AgentEventBase?(ArtifactUploadEvent @this) => @this.AgentBase;

        /// <summary>
        ///
        /// </summary>
        public ArtifactUploadEvent(global::Vectara.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ArtifactUploadEvent FromAgentBase(global::Vectara.AgentEventBase? value) => new ArtifactUploadEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ArtifactUploadEvent(global::Vectara.ArtifactUploadEventVariant2 value) => new ArtifactUploadEvent((global::Vectara.ArtifactUploadEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ArtifactUploadEventVariant2?(ArtifactUploadEvent @this) => @this.ArtifactUploadEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public ArtifactUploadEvent(global::Vectara.ArtifactUploadEventVariant2? value)
        {
            ArtifactUploadEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ArtifactUploadEvent FromArtifactUploadEventVariant2(global::Vectara.ArtifactUploadEventVariant2? value) => new ArtifactUploadEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ArtifactUploadEvent(
            global::Vectara.AgentEventBase? agentBase,
            global::Vectara.ArtifactUploadEventVariant2? artifactUploadEventVariant2
            )
        {
            AgentBase = agentBase;
            ArtifactUploadEventVariant2 = artifactUploadEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ArtifactUploadEventVariant2 as object ??
            AgentBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ArtifactUploadEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsArtifactUploadEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentEventBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.ArtifactUploadEventVariant2, TResult>? artifactUploadEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AgentBase is { } __value0 && agentBase != null)
            {
                return agentBase(__value0);
            }
            else if (ArtifactUploadEventVariant2 is { } __value1 && artifactUploadEventVariant2 != null)
            {
                return artifactUploadEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentEventBase>? agentBase = null,

            global::System.Action<global::Vectara.ArtifactUploadEventVariant2>? artifactUploadEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AgentBase is { } __value0)
            {
                agentBase?.Invoke(__value0);
            }
            else if (ArtifactUploadEventVariant2 is { } __value1)
            {
                artifactUploadEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentEventBase>? agentBase = null,
            global::System.Action<global::Vectara.ArtifactUploadEventVariant2>? artifactUploadEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AgentBase is { } __value0)
            {
                agentBase?.Invoke(__value0);
            }
            else if (ArtifactUploadEventVariant2 is { } __value1)
            {
                artifactUploadEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentBase,
                typeof(global::Vectara.AgentEventBase),
                ArtifactUploadEventVariant2,
                typeof(global::Vectara.ArtifactUploadEventVariant2),
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
        public bool Equals(ArtifactUploadEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactUploadEventVariant2?>.Default.Equals(ArtifactUploadEventVariant2, other.ArtifactUploadEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ArtifactUploadEvent obj1, ArtifactUploadEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ArtifactUploadEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ArtifactUploadEvent obj1, ArtifactUploadEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArtifactUploadEvent o && Equals(o);
        }
    }
}
