
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Roles that a user or an app client can take on.
    /// </summary>
    public enum ApiRole
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
        BillingAdministrator,
        /// <summary>
        /// 
        /// </summary>
        CorpusAdministrator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiRole value)
        {
            return value switch
            {
                ApiRole.Owner => "owner",
                ApiRole.Administrator => "administrator",
                ApiRole.BillingAdministrator => "billing_administrator",
                ApiRole.CorpusAdministrator => "corpus_administrator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiRole? ToEnum(string value)
        {
            return value switch
            {
                "owner" => ApiRole.Owner,
                "administrator" => ApiRole.Administrator,
                "billing_administrator" => ApiRole.BillingAdministrator,
                "corpus_administrator" => ApiRole.CorpusAdministrator,
                _ => null,
            };
        }
    }
}