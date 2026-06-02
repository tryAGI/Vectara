
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Example: slack
    /// </summary>
    public enum ListAgentConnectorsType
    {
        /// <summary>
        /// 
        /// </summary>
        Gchat,
        /// <summary>
        /// 
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAgentConnectorsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentConnectorsType value)
        {
            return value switch
            {
                ListAgentConnectorsType.Gchat => "gchat",
                ListAgentConnectorsType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentConnectorsType? ToEnum(string value)
        {
            return value switch
            {
                "gchat" => ListAgentConnectorsType.Gchat,
                "slack" => ListAgentConnectorsType.Slack,
                _ => null,
            };
        }
    }
}