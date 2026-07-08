
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Which Fluid Topics content layer to ingest. `documents` enumerates standalone documents;<br/>
    /// `topics` enumerates the topics within publications, iterating map by map so each topic carries<br/>
    /// its parent map's identity and classification.<br/>
    /// Default Value: documents
    /// </summary>
    public enum BaseFluidtopicsSourceConfigurationContentScope
    {
        /// <summary>
        /// 
        /// </summary>
        Documents,
        /// <summary>
        /// 
        /// </summary>
        Topics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseFluidtopicsSourceConfigurationContentScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseFluidtopicsSourceConfigurationContentScope value)
        {
            return value switch
            {
                BaseFluidtopicsSourceConfigurationContentScope.Documents => "documents",
                BaseFluidtopicsSourceConfigurationContentScope.Topics => "topics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseFluidtopicsSourceConfigurationContentScope? ToEnum(string value)
        {
            return value switch
            {
                "documents" => BaseFluidtopicsSourceConfigurationContentScope.Documents,
                "topics" => BaseFluidtopicsSourceConfigurationContentScope.Topics,
                _ => null,
            };
        }
    }
}