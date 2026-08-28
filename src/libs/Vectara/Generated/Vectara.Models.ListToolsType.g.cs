
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Example: mcp
    /// </summary>
    public enum ListToolsType
    {
        /// <summary>
        /// `vectara` matches the built-in Vectara tools, `mcp` tools provided by a tool server, `lambda` user-defined Python tools, and `client` tools executed by the calling client.
        /// </summary>
        Client,
        /// <summary>
        /// `vectara` matches the built-in Vectara tools, `mcp` tools provided by a tool server, `lambda` user-defined Python tools, and `client` tools executed by the calling client.
        /// </summary>
        Lambda,
        /// <summary>
        /// `vectara` matches the built-in Vectara tools, `mcp` tools provided by a tool server, `lambda` user-defined Python tools, and `client` tools executed by the calling client.
        /// </summary>
        Mcp,
        /// <summary>
        /// `vectara` matches the built-in Vectara tools, `mcp` tools provided by a tool server, `lambda` user-defined Python tools, and `client` tools executed by the calling client.
        /// </summary>
        Vectara,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListToolsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListToolsType value)
        {
            return value switch
            {
                ListToolsType.Client => "client",
                ListToolsType.Lambda => "lambda",
                ListToolsType.Mcp => "mcp",
                ListToolsType.Vectara => "vectara",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListToolsType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ListToolsType.Client,
                "lambda" => ListToolsType.Lambda,
                "mcp" => ListToolsType.Mcp,
                "vectara" => ListToolsType.Vectara,
                _ => null,
            };
        }
    }
}