
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The Wolken API family used to read the knowledge base. `data_api` reads through the<br/>
    /// provisioned data API endpoint and supports server-side update-time filters. `kb_module`<br/>
    /// reads through the Knowledge Base module REST API. That API lists articles by category<br/>
    /// and offers no server-side filters, so update detection happens after listing. The<br/>
    /// Wolken administrator determines which family a deployment provisions.<br/>
    /// Default Value: data_api
    /// </summary>
    public enum BaseWolkenKbSourceConfigurationKbApi
    {
        /// <summary>
        /// 
        /// </summary>
        DataApi,
        /// <summary>
        /// 
        /// </summary>
        KbModule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseWolkenKbSourceConfigurationKbApiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseWolkenKbSourceConfigurationKbApi value)
        {
            return value switch
            {
                BaseWolkenKbSourceConfigurationKbApi.DataApi => "data_api",
                BaseWolkenKbSourceConfigurationKbApi.KbModule => "kb_module",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseWolkenKbSourceConfigurationKbApi? ToEnum(string value)
        {
            return value switch
            {
                "data_api" => BaseWolkenKbSourceConfigurationKbApi.DataApi,
                "kb_module" => BaseWolkenKbSourceConfigurationKbApi.KbModule,
                _ => null,
            };
        }
    }
}