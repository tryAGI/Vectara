#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a new generation preset.
    /// </summary>
    public readonly partial struct CreateGenerationPresetRequest : global::System.IEquatable<CreateGenerationPresetRequest>
    {
        /// <summary>
        /// Bundle of default values used when calling generation. All values except model name can be overridden at generation time.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GenerationPreset? GenerationPreset { get; init; }
#else
        public global::Vectara.GenerationPreset? GenerationPreset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationPreset))]
#endif
        public bool IsGenerationPreset => GenerationPreset != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateGenerationPresetRequest(global::Vectara.GenerationPreset value) => new CreateGenerationPresetRequest((global::Vectara.GenerationPreset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GenerationPreset?(CreateGenerationPresetRequest @this) => @this.GenerationPreset;

        /// <summary>
        /// 
        /// </summary>
        public CreateGenerationPresetRequest(global::Vectara.GenerationPreset? value)
        {
            GenerationPreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenerationPreset as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GenerationPreset?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerationPreset;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.GenerationPreset?, TResult>? generationPreset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationPreset && generationPreset != null)
            {
                return generationPreset(GenerationPreset!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.GenerationPreset?>? generationPreset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationPreset)
            {
                generationPreset?.Invoke(GenerationPreset!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GenerationPreset,
                typeof(global::Vectara.GenerationPreset),
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
        public bool Equals(CreateGenerationPresetRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GenerationPreset?>.Default.Equals(GenerationPreset, other.GenerationPreset) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateGenerationPresetRequest obj1, CreateGenerationPresetRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateGenerationPresetRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateGenerationPresetRequest obj1, CreateGenerationPresetRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateGenerationPresetRequest o && Equals(o);
        }
    }
}
