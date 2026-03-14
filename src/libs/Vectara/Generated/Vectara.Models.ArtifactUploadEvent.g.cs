#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Event representing files uploaded to the agent workspace as artifacts.<br/>
    /// This event is created when users upload one or more files to an agent session using multipart requests. The event becomes part of the session's conversation history and contains references to all artifacts that were uploaded in the request. Each uploaded file is assigned a unique artifact identifier and stored in the session's workspace.<br/>
    /// When an agent processes this event, it becomes aware that new files are available in the session and can use various tools to read, analyze, or transform these artifacts. For example, after receiving an artifact upload event with a PDF, the agent might use the document conversion tool to extract and analyze the document's contents.<br/>
    /// See the `ArtifactReference` schema for comprehensive details about what artifacts are, how they are stored, their lifecycle, and how agents interact with them.
    /// </summary>
    public readonly partial struct ArtifactUploadEvent : global::System.IEquatable<ArtifactUploadEvent>
    {
        /// <summary>
        /// Base properties shared by all agent event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentEventBase? Value1 { get; init; }
#else
        public global::Vectara.AgentEventBase? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ArtifactUploadEventVariant2? Value2 { get; init; }
#else
        public global::Vectara.ArtifactUploadEventVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactUploadEvent(global::Vectara.AgentEventBase value) => new ArtifactUploadEvent((global::Vectara.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentEventBase?(ArtifactUploadEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactUploadEvent(global::Vectara.AgentEventBase? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactUploadEvent(global::Vectara.ArtifactUploadEventVariant2 value) => new ArtifactUploadEvent((global::Vectara.ArtifactUploadEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ArtifactUploadEventVariant2?(ArtifactUploadEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactUploadEvent(global::Vectara.ArtifactUploadEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ArtifactUploadEvent(
            global::Vectara.AgentEventBase? value1,
            global::Vectara.ArtifactUploadEventVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentEventBase?, TResult>? value1 = null,
            global::System.Func<global::Vectara.ArtifactUploadEventVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentEventBase?>? value1 = null,
            global::System.Action<global::Vectara.ArtifactUploadEventVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Vectara.AgentEventBase),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentEventBase?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ArtifactUploadEventVariant2?>.Default.Equals(Value2, other.Value2) 
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
