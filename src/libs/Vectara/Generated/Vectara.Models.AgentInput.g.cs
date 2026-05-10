#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An input that can be provided to an agent message.
    /// </summary>
    public readonly partial struct AgentInput : global::System.IEquatable<AgentInput>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentInputDiscriminatorType? Type { get; }

        /// <summary>
        /// A text input for an agent message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentTextInput? Text { get; init; }
#else
        public global::Vectara.AgentTextInput? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.AgentTextInput? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentTextInput PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// An input that invokes a skill by name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentSkillInput? Skill { get; init; }
#else
        public global::Vectara.AgentSkillInput? Skill { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Skill))]
#endif
        public bool IsSkill => Skill != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSkill(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.AgentSkillInput? value)
        {
            value = Skill;
            return IsSkill;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentSkillInput PickSkill() => IsSkill
            ? Skill!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Skill' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentInput(global::Vectara.AgentTextInput value) => new AgentInput((global::Vectara.AgentTextInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentTextInput?(AgentInput @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public AgentInput(global::Vectara.AgentTextInput? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentInput FromText(global::Vectara.AgentTextInput? value) => new AgentInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentInput(global::Vectara.AgentSkillInput value) => new AgentInput((global::Vectara.AgentSkillInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentSkillInput?(AgentInput @this) => @this.Skill;

        /// <summary>
        /// 
        /// </summary>
        public AgentInput(global::Vectara.AgentSkillInput? value)
        {
            Skill = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentInput FromSkill(global::Vectara.AgentSkillInput? value) => new AgentInput(value);

        /// <summary>
        /// 
        /// </summary>
        public AgentInput(
            global::Vectara.AgentInputDiscriminatorType? type,
            global::Vectara.AgentTextInput? text,
            global::Vectara.AgentSkillInput? skill
            )
        {
            Type = type;

            Text = text;
            Skill = skill;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Skill as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Skill?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsSkill || !IsText && IsSkill;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentTextInput, TResult>? text = null,
            global::System.Func<global::Vectara.AgentSkillInput, TResult>? skill = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsSkill && skill != null)
            {
                return skill(Skill!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentTextInput>? text = null,

            global::System.Action<global::Vectara.AgentSkillInput>? skill = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsSkill)
            {
                skill?.Invoke(Skill!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentTextInput>? text = null,
            global::System.Action<global::Vectara.AgentSkillInput>? skill = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsSkill)
            {
                skill?.Invoke(Skill!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Vectara.AgentTextInput),
                Skill,
                typeof(global::Vectara.AgentSkillInput),
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
        public bool Equals(AgentInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentTextInput?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentSkillInput?>.Default.Equals(Skill, other.Skill) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentInput obj1, AgentInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentInput obj1, AgentInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentInput o && Equals(o);
        }
    }
}
