
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
        /// <summary>
        /// 
        /// </summary>
        CorpusDeveloper,
        /// <summary>
        /// 
        /// </summary>
        AgentAdministrator,
        /// <summary>
        /// 
        /// </summary>
        AgentViewer,
        /// <summary>
        /// 
        /// </summary>
        AgentDeveloper,
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
                ApiRole.CorpusDeveloper => "corpus_developer",
                ApiRole.AgentAdministrator => "agent_administrator",
                ApiRole.AgentViewer => "agent_viewer",
                ApiRole.AgentDeveloper => "agent_developer",
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
                "corpus_developer" => ApiRole.CorpusDeveloper,
                "agent_administrator" => ApiRole.AgentAdministrator,
                "agent_viewer" => ApiRole.AgentViewer,
                "agent_developer" => ApiRole.AgentDeveloper,
                _ => null,
            };
        }
    }
}