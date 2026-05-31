
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum GoogleDriveScopeDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        MyDrive,
        /// <summary>
        /// 
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleDriveScopeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleDriveScopeDiscriminatorType value)
        {
            return value switch
            {
                GoogleDriveScopeDiscriminatorType.MyDrive => "my_drive",
                GoogleDriveScopeDiscriminatorType.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleDriveScopeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "my_drive" => GoogleDriveScopeDiscriminatorType.MyDrive,
                "shared" => GoogleDriveScopeDiscriminatorType.Shared,
                _ => null,
            };
        }
    }
}