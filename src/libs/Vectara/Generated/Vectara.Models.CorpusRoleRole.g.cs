
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The role assigned for this specific corpus.
    /// </summary>
    public enum CorpusRoleRole
    {
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Administrator,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
        /// <summary>
        /// 
        /// </summary>
        Editor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CorpusRoleRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CorpusRoleRole value)
        {
            return value switch
            {
                CorpusRoleRole.Owner => "owner",
                CorpusRoleRole.Administrator => "administrator",
                CorpusRoleRole.Viewer => "viewer",
                CorpusRoleRole.Editor => "editor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CorpusRoleRole? ToEnum(string value)
        {
            return value switch
            {
                "owner" => CorpusRoleRole.Owner,
                "administrator" => CorpusRoleRole.Administrator,
                "viewer" => CorpusRoleRole.Viewer,
                "editor" => CorpusRoleRole.Editor,
                _ => null,
            };
        }
    }
}