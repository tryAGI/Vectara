#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reminder that is injected into the agent conversation when specific event types occur.
    /// </summary>
    public readonly partial struct AgentStepReminder : global::System.IEquatable<AgentStepReminder>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentStepReminderDiscriminatorType? Type { get; }

        /// <summary>
        /// A templated reminder with a Velocity template that is compiled at session start and injected into messages matching the specified hooks.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.TemplatedReminder? Templated { get; init; }
#else
        public global::Vectara.TemplatedReminder? Templated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Templated))]
#endif
        public bool IsTemplated => Templated != null;

        /// <summary>
        /// A reminder that expands terms, acronyms, and abbreviations in user messages using a glossary.<br/>
        /// When attached to a step, user input is run through the glossary's lookup index and matching<br/>
        /// terms are expanded before the message reaches the LLM.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GlossaryExpansionReminder? GlossaryExpansion { get; init; }
#else
        public global::Vectara.GlossaryExpansionReminder? GlossaryExpansion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GlossaryExpansion))]
#endif
        public bool IsGlossaryExpansion => GlossaryExpansion != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStepReminder(global::Vectara.TemplatedReminder value) => new AgentStepReminder((global::Vectara.TemplatedReminder?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.TemplatedReminder?(AgentStepReminder @this) => @this.Templated;

        /// <summary>
        /// 
        /// </summary>
        public AgentStepReminder(global::Vectara.TemplatedReminder? value)
        {
            Templated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStepReminder(global::Vectara.GlossaryExpansionReminder value) => new AgentStepReminder((global::Vectara.GlossaryExpansionReminder?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GlossaryExpansionReminder?(AgentStepReminder @this) => @this.GlossaryExpansion;

        /// <summary>
        /// 
        /// </summary>
        public AgentStepReminder(global::Vectara.GlossaryExpansionReminder? value)
        {
            GlossaryExpansion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentStepReminder(
            global::Vectara.AgentStepReminderDiscriminatorType? type,
            global::Vectara.TemplatedReminder? templated,
            global::Vectara.GlossaryExpansionReminder? glossaryExpansion
            )
        {
            Type = type;

            Templated = templated;
            GlossaryExpansion = glossaryExpansion;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GlossaryExpansion as object ??
            Templated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Templated?.ToString() ??
            GlossaryExpansion?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTemplated && !IsGlossaryExpansion || !IsTemplated && IsGlossaryExpansion;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.TemplatedReminder?, TResult>? templated = null,
            global::System.Func<global::Vectara.GlossaryExpansionReminder?, TResult>? glossaryExpansion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTemplated && templated != null)
            {
                return templated(Templated!);
            }
            else if (IsGlossaryExpansion && glossaryExpansion != null)
            {
                return glossaryExpansion(GlossaryExpansion!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.TemplatedReminder?>? templated = null,
            global::System.Action<global::Vectara.GlossaryExpansionReminder?>? glossaryExpansion = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTemplated)
            {
                templated?.Invoke(Templated!);
            }
            else if (IsGlossaryExpansion)
            {
                glossaryExpansion?.Invoke(GlossaryExpansion!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Templated,
                typeof(global::Vectara.TemplatedReminder),
                GlossaryExpansion,
                typeof(global::Vectara.GlossaryExpansionReminder),
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
        public bool Equals(AgentStepReminder other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.TemplatedReminder?>.Default.Equals(Templated, other.Templated) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GlossaryExpansionReminder?>.Default.Equals(GlossaryExpansion, other.GlossaryExpansion) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentStepReminder obj1, AgentStepReminder obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentStepReminder>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentStepReminder obj1, AgentStepReminder obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentStepReminder o && Equals(o);
        }
    }
}
