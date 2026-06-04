
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum IndividualSearchResultDiscriminatorResultType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndividualSearchResultDiscriminatorResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndividualSearchResultDiscriminatorResultType value)
        {
            return value switch
            {
                IndividualSearchResultDiscriminatorResultType.Image => "image",
                IndividualSearchResultDiscriminatorResultType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndividualSearchResultDiscriminatorResultType? ToEnum(string value)
        {
            return value switch
            {
                "image" => IndividualSearchResultDiscriminatorResultType.Image,
                "text" => IndividualSearchResultDiscriminatorResultType.Text,
                _ => null,
            };
        }
    }
}