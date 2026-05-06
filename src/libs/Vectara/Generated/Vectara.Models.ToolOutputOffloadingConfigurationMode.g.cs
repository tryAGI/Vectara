
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How a large tool output is handled once it has been selected for offloading.<br/>
    /// In `artifact` mode, the full output is stored as a session artifact and replaced in<br/>
    /// the conversation with a compact reference containing the artifact id, size, shape,<br/>
    /// and hints for the available artifact tools. The agent can then use artifact_read,<br/>
    /// artifact_grep, or artifact_jq to retrieve just the parts it needs.<br/>
    /// In `truncate` mode, the output is shortened in place to fit within the target size.<br/>
    /// The head and tail are preserved and the middle is replaced with a short notice<br/>
    /// explaining that content was omitted. No artifact is created.<br/>
    /// When unset, the default is `artifact` if the agent has any of artifact_read,<br/>
    /// artifact_grep, or artifact_jq configured, and `truncate` otherwise.<br/>
    /// Example: artifact
    /// </summary>
    public enum ToolOutputOffloadingConfigurationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Artifact,
        /// <summary>
        /// 
        /// </summary>
        Truncate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolOutputOffloadingConfigurationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolOutputOffloadingConfigurationMode value)
        {
            return value switch
            {
                ToolOutputOffloadingConfigurationMode.Artifact => "artifact",
                ToolOutputOffloadingConfigurationMode.Truncate => "truncate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolOutputOffloadingConfigurationMode? ToEnum(string value)
        {
            return value switch
            {
                "artifact" => ToolOutputOffloadingConfigurationMode.Artifact,
                "truncate" => ToolOutputOffloadingConfigurationMode.Truncate,
                _ => null,
            };
        }
    }
}