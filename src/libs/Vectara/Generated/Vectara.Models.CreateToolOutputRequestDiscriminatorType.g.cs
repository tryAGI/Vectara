
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateToolOutputRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateToolOutputRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolOutputRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateToolOutputRequestDiscriminatorType.Error => "error",
                CreateToolOutputRequestDiscriminatorType.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolOutputRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateToolOutputRequestDiscriminatorType.Error,
                "success" => CreateToolOutputRequestDiscriminatorType.Success,
                _ => null,
            };
        }
    }
}