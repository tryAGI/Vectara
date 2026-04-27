#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single span within an agent trace. The shape of attributes and content varies by operation type.
    /// </summary>
    public readonly partial struct AgentTraceSpan : global::System.IEquatable<AgentTraceSpan>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentTraceSpanDiscriminatorOperation? Operation { get; }

        /// <summary>
        /// A span representing a top-level agent invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InvokeAgentTraceSpan? InvokeAgent { get; init; }
#else
        public global::Vectara.InvokeAgentTraceSpan? InvokeAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InvokeAgent))]
#endif
        public bool IsInvokeAgent => InvokeAgent != null;

        /// <summary>
        /// A span representing a single LLM chat completion call within an agent turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ChatTraceSpan? Chat { get; init; }
#else
        public global::Vectara.ChatTraceSpan? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        /// A span representing a tool execution within an agent turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ExecuteToolTraceSpan? ExecuteTool { get; init; }
#else
        public global::Vectara.ExecuteToolTraceSpan? ExecuteTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecuteTool))]
#endif
        public bool IsExecuteTool => ExecuteTool != null;

        /// <summary>
        /// A span representing extended thinking output from the LLM.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ThinkingTraceSpan? Thinking { get; init; }
#else
        public global::Vectara.ThinkingTraceSpan? Thinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        /// A span representing the final text output of an agent turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.OutputTraceSpan? Output { get; init; }
#else
        public global::Vectara.OutputTraceSpan? Output { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Output))]
#endif
        public bool IsOutput => Output != null;

        /// <summary>
        /// A span representing a guardrail safety check on tool call results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GuardrailTraceSpan? Guardrail { get; init; }
#else
        public global::Vectara.GuardrailTraceSpan? Guardrail { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Guardrail))]
#endif
        public bool IsGuardrail => Guardrail != null;

        /// <summary>
        /// A span representing a transition between agent steps.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StepTransitionTraceSpan? StepTransition { get; init; }
#else
        public global::Vectara.StepTransitionTraceSpan? StepTransition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepTransition))]
#endif
        public bool IsStepTransition => StepTransition != null;

        /// <summary>
        /// A span representing an image being loaded into conversation context.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ImageReadTraceSpan? ImageRead { get; init; }
#else
        public global::Vectara.ImageReadTraceSpan? ImageRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageRead))]
#endif
        public bool IsImageRead => ImageRead != null;

        /// <summary>
        /// A span representing context compaction (summarization of older conversation turns).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CompactionTraceSpan? Compaction { get; init; }
#else
        public global::Vectara.CompactionTraceSpan? Compaction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compaction))]
#endif
        public bool IsCompaction => Compaction != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTraceSpan(global::Vectara.InvokeAgentTraceSpan value) => new AgentTraceSpan((global::Vectara.InvokeAgentTraceSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InvokeAgentTraceSpan?(AgentTraceSpan @this) => @this.InvokeAgent;

        /// <summary>
        /// 
        /// </summary>
        public AgentTraceSpan(global::Vectara.InvokeAgentTraceSpan? value)
        {
            InvokeAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTraceSpan(global::Vectara.ChatTraceSpan value) => new AgentTraceSpan((global::Vectara.ChatTraceSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ChatTraceSpan?(AgentTraceSpan @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public AgentTraceSpan(global::Vectara.ChatTraceSpan? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTraceSpan(global::Vectara.ExecuteToolTraceSpan value) => new AgentTraceSpan((global::Vectara.ExecuteToolTraceSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ExecuteToolTraceSpan?(AgentTraceSpan @this) => @this.ExecuteTool;

        /// <summary>
        /// 
        /// </summary>
        public AgentTraceSpan(global::Vectara.ExecuteToolTraceSpan? value)
        {
            ExecuteTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTraceSpan(global::Vectara.ThinkingTraceSpan value) => new AgentTraceSpan((global::Vectara.ThinkingTraceSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ThinkingTraceSpan?(AgentTraceSpan @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public AgentTraceSpan(global::Vectara.ThinkingTraceSpan? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTraceSpan(global::Vectara.OutputTraceSpan value) => new AgentTraceSpan((global::Vectara.OutputTraceSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.OutputTraceSpan?(AgentTraceSpan @this) => @this.Output;

        /// <summary>
        /// 
        /// </summary>
        public AgentTraceSpan(global::Vectara.OutputTraceSpan? value)
        {
            Output = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTraceSpan(global::Vectara.GuardrailTraceSpan value) => new AgentTraceSpan((global::Vectara.GuardrailTraceSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GuardrailTraceSpan?(AgentTraceSpan @this) => @this.Guardrail;

        /// <summary>
        /// 
        /// </summary>
        public AgentTraceSpan(global::Vectara.GuardrailTraceSpan? value)
        {
            Guardrail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTraceSpan(global::Vectara.StepTransitionTraceSpan value) => new AgentTraceSpan((global::Vectara.StepTransitionTraceSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StepTransitionTraceSpan?(AgentTraceSpan @this) => @this.StepTransition;

        /// <summary>
        /// 
        /// </summary>
        public AgentTraceSpan(global::Vectara.StepTransitionTraceSpan? value)
        {
            StepTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTraceSpan(global::Vectara.ImageReadTraceSpan value) => new AgentTraceSpan((global::Vectara.ImageReadTraceSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageReadTraceSpan?(AgentTraceSpan @this) => @this.ImageRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentTraceSpan(global::Vectara.ImageReadTraceSpan? value)
        {
            ImageRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTraceSpan(global::Vectara.CompactionTraceSpan value) => new AgentTraceSpan((global::Vectara.CompactionTraceSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CompactionTraceSpan?(AgentTraceSpan @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public AgentTraceSpan(global::Vectara.CompactionTraceSpan? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentTraceSpan(
            global::Vectara.AgentTraceSpanDiscriminatorOperation? operation,
            global::Vectara.InvokeAgentTraceSpan? invokeAgent,
            global::Vectara.ChatTraceSpan? chat,
            global::Vectara.ExecuteToolTraceSpan? executeTool,
            global::Vectara.ThinkingTraceSpan? thinking,
            global::Vectara.OutputTraceSpan? output,
            global::Vectara.GuardrailTraceSpan? guardrail,
            global::Vectara.StepTransitionTraceSpan? stepTransition,
            global::Vectara.ImageReadTraceSpan? imageRead,
            global::Vectara.CompactionTraceSpan? compaction
            )
        {
            Operation = operation;

            InvokeAgent = invokeAgent;
            Chat = chat;
            ExecuteTool = executeTool;
            Thinking = thinking;
            Output = output;
            Guardrail = guardrail;
            StepTransition = stepTransition;
            ImageRead = imageRead;
            Compaction = compaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Compaction as object ??
            ImageRead as object ??
            StepTransition as object ??
            Guardrail as object ??
            Output as object ??
            Thinking as object ??
            ExecuteTool as object ??
            Chat as object ??
            InvokeAgent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InvokeAgent?.ToString() ??
            Chat?.ToString() ??
            ExecuteTool?.ToString() ??
            Thinking?.ToString() ??
            Output?.ToString() ??
            Guardrail?.ToString() ??
            StepTransition?.ToString() ??
            ImageRead?.ToString() ??
            Compaction?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInvokeAgent && !IsChat && !IsExecuteTool && !IsThinking && !IsOutput && !IsGuardrail && !IsStepTransition && !IsImageRead && !IsCompaction || !IsInvokeAgent && IsChat && !IsExecuteTool && !IsThinking && !IsOutput && !IsGuardrail && !IsStepTransition && !IsImageRead && !IsCompaction || !IsInvokeAgent && !IsChat && IsExecuteTool && !IsThinking && !IsOutput && !IsGuardrail && !IsStepTransition && !IsImageRead && !IsCompaction || !IsInvokeAgent && !IsChat && !IsExecuteTool && IsThinking && !IsOutput && !IsGuardrail && !IsStepTransition && !IsImageRead && !IsCompaction || !IsInvokeAgent && !IsChat && !IsExecuteTool && !IsThinking && IsOutput && !IsGuardrail && !IsStepTransition && !IsImageRead && !IsCompaction || !IsInvokeAgent && !IsChat && !IsExecuteTool && !IsThinking && !IsOutput && IsGuardrail && !IsStepTransition && !IsImageRead && !IsCompaction || !IsInvokeAgent && !IsChat && !IsExecuteTool && !IsThinking && !IsOutput && !IsGuardrail && IsStepTransition && !IsImageRead && !IsCompaction || !IsInvokeAgent && !IsChat && !IsExecuteTool && !IsThinking && !IsOutput && !IsGuardrail && !IsStepTransition && IsImageRead && !IsCompaction || !IsInvokeAgent && !IsChat && !IsExecuteTool && !IsThinking && !IsOutput && !IsGuardrail && !IsStepTransition && !IsImageRead && IsCompaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.InvokeAgentTraceSpan?, TResult>? invokeAgent = null,
            global::System.Func<global::Vectara.ChatTraceSpan?, TResult>? chat = null,
            global::System.Func<global::Vectara.ExecuteToolTraceSpan?, TResult>? executeTool = null,
            global::System.Func<global::Vectara.ThinkingTraceSpan?, TResult>? thinking = null,
            global::System.Func<global::Vectara.OutputTraceSpan?, TResult>? output = null,
            global::System.Func<global::Vectara.GuardrailTraceSpan?, TResult>? guardrail = null,
            global::System.Func<global::Vectara.StepTransitionTraceSpan?, TResult>? stepTransition = null,
            global::System.Func<global::Vectara.ImageReadTraceSpan?, TResult>? imageRead = null,
            global::System.Func<global::Vectara.CompactionTraceSpan?, TResult>? compaction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInvokeAgent && invokeAgent != null)
            {
                return invokeAgent(InvokeAgent!);
            }
            else if (IsChat && chat != null)
            {
                return chat(Chat!);
            }
            else if (IsExecuteTool && executeTool != null)
            {
                return executeTool(ExecuteTool!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsOutput && output != null)
            {
                return output(Output!);
            }
            else if (IsGuardrail && guardrail != null)
            {
                return guardrail(Guardrail!);
            }
            else if (IsStepTransition && stepTransition != null)
            {
                return stepTransition(StepTransition!);
            }
            else if (IsImageRead && imageRead != null)
            {
                return imageRead(ImageRead!);
            }
            else if (IsCompaction && compaction != null)
            {
                return compaction(Compaction!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.InvokeAgentTraceSpan?>? invokeAgent = null,
            global::System.Action<global::Vectara.ChatTraceSpan?>? chat = null,
            global::System.Action<global::Vectara.ExecuteToolTraceSpan?>? executeTool = null,
            global::System.Action<global::Vectara.ThinkingTraceSpan?>? thinking = null,
            global::System.Action<global::Vectara.OutputTraceSpan?>? output = null,
            global::System.Action<global::Vectara.GuardrailTraceSpan?>? guardrail = null,
            global::System.Action<global::Vectara.StepTransitionTraceSpan?>? stepTransition = null,
            global::System.Action<global::Vectara.ImageReadTraceSpan?>? imageRead = null,
            global::System.Action<global::Vectara.CompactionTraceSpan?>? compaction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInvokeAgent)
            {
                invokeAgent?.Invoke(InvokeAgent!);
            }
            else if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
            else if (IsExecuteTool)
            {
                executeTool?.Invoke(ExecuteTool!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsOutput)
            {
                output?.Invoke(Output!);
            }
            else if (IsGuardrail)
            {
                guardrail?.Invoke(Guardrail!);
            }
            else if (IsStepTransition)
            {
                stepTransition?.Invoke(StepTransition!);
            }
            else if (IsImageRead)
            {
                imageRead?.Invoke(ImageRead!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InvokeAgent,
                typeof(global::Vectara.InvokeAgentTraceSpan),
                Chat,
                typeof(global::Vectara.ChatTraceSpan),
                ExecuteTool,
                typeof(global::Vectara.ExecuteToolTraceSpan),
                Thinking,
                typeof(global::Vectara.ThinkingTraceSpan),
                Output,
                typeof(global::Vectara.OutputTraceSpan),
                Guardrail,
                typeof(global::Vectara.GuardrailTraceSpan),
                StepTransition,
                typeof(global::Vectara.StepTransitionTraceSpan),
                ImageRead,
                typeof(global::Vectara.ImageReadTraceSpan),
                Compaction,
                typeof(global::Vectara.CompactionTraceSpan),
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
        public bool Equals(AgentTraceSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InvokeAgentTraceSpan?>.Default.Equals(InvokeAgent, other.InvokeAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ChatTraceSpan?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ExecuteToolTraceSpan?>.Default.Equals(ExecuteTool, other.ExecuteTool) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ThinkingTraceSpan?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.OutputTraceSpan?>.Default.Equals(Output, other.Output) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GuardrailTraceSpan?>.Default.Equals(Guardrail, other.Guardrail) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepTransitionTraceSpan?>.Default.Equals(StepTransition, other.StepTransition) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageReadTraceSpan?>.Default.Equals(ImageRead, other.ImageRead) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CompactionTraceSpan?>.Default.Equals(Compaction, other.Compaction) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentTraceSpan obj1, AgentTraceSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentTraceSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentTraceSpan obj1, AgentTraceSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentTraceSpan o && Equals(o);
        }
    }
}
