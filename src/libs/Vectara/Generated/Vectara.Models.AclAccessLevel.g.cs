
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Access level a grant confers on a record. `none` means the access concept applies to the record but<br/>
    /// no grant was made. New levels may be added over time; clients should treat unknown values as opaque.
    /// </summary>
    public enum AclAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Commenter,
        /// <summary>
        /// 
        /// </summary>
        Editor,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Reader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AclAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AclAccessLevel value)
        {
            return value switch
            {
                AclAccessLevel.Commenter => "commenter",
                AclAccessLevel.Editor => "editor",
                AclAccessLevel.None => "none",
                AclAccessLevel.Reader => "reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AclAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "commenter" => AclAccessLevel.Commenter,
                "editor" => AclAccessLevel.Editor,
                "none" => AclAccessLevel.None,
                "reader" => AclAccessLevel.Reader,
                _ => null,
            };
        }
    }
}