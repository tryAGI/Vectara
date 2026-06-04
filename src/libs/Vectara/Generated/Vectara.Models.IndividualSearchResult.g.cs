#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A ranked search result from a query. Discriminated by result_type.
    /// </summary>
    public readonly partial struct IndividualSearchResult : global::System.IEquatable<IndividualSearchResult>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.IndividualSearchResultDiscriminatorResultType? ResultType { get; }

        /// <summary>
        /// A text document part that matched a query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.TextSearchResult? Text { get; init; }
#else
        public global::Vectara.TextSearchResult? Text { get; }
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
            out global::Vectara.TextSearchResult? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.TextSearchResult PickText() => IsText
            ? Text!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// An image embedding that matched a query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ImageSearchResult? Image { get; init; }
#else
        public global::Vectara.ImageSearchResult? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ImageSearchResult? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ImageSearchResult PickImage() => IsImage
            ? Image!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndividualSearchResult(global::Vectara.TextSearchResult value) => new IndividualSearchResult((global::Vectara.TextSearchResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.TextSearchResult?(IndividualSearchResult @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public IndividualSearchResult(global::Vectara.TextSearchResult? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndividualSearchResult FromText(global::Vectara.TextSearchResult? value) => new IndividualSearchResult(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndividualSearchResult(global::Vectara.ImageSearchResult value) => new IndividualSearchResult((global::Vectara.ImageSearchResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageSearchResult?(IndividualSearchResult @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public IndividualSearchResult(global::Vectara.ImageSearchResult? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndividualSearchResult FromImage(global::Vectara.ImageSearchResult? value) => new IndividualSearchResult(value);

        /// <summary>
        /// 
        /// </summary>
        public IndividualSearchResult(
            global::Vectara.IndividualSearchResultDiscriminatorResultType? resultType,
            global::Vectara.TextSearchResult? text,
            global::Vectara.ImageSearchResult? image
            )
        {
            ResultType = resultType;

            Text = text;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage || !IsText && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.TextSearchResult?, TResult>? text = null,
            global::System.Func<global::Vectara.ImageSearchResult?, TResult>? image = null,
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
            else if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.TextSearchResult?>? text = null,

            global::System.Action<global::Vectara.ImageSearchResult?>? image = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.TextSearchResult?>? text = null,
            global::System.Action<global::Vectara.ImageSearchResult?>? image = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
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
                typeof(global::Vectara.TextSearchResult),
                Image,
                typeof(global::Vectara.ImageSearchResult),
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
        public bool Equals(IndividualSearchResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.TextSearchResult?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageSearchResult?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IndividualSearchResult obj1, IndividualSearchResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IndividualSearchResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IndividualSearchResult obj1, IndividualSearchResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IndividualSearchResult o && Equals(o);
        }
    }
}
