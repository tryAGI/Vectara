
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Which Fluid Topics content layer to ingest:<br/>
    /// - `documents`: enumerates standalone documents.<br/>
    /// - `topics`: enumerates the topics within maps, iterating map by map so each topic carries<br/>
    ///   its parent map's identity and classification.<br/>
    /// - `maps`: enumerates maps, emitting one record each.<br/>
    /// Under `maps`, `query` is ignored. `filters`, `locale`, `include_sources`, and<br/>
    /// `exclude_sources` apply, matched against each map's metadata.<br/>
    /// Default Value: documents
    /// </summary>
    public enum BaseFluidtopicsSourceConfigurationContentScope
    {
        /// <summary>
        /// enumerates standalone documents.
        /// </summary>
        Documents,
        /// <summary>
        /// enumerates the topics within maps, iterating map by map so each topic carries
        /// </summary>
        Maps,
        /// <summary>
        /// enumerates the topics within maps, iterating map by map so each topic carries
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
                BaseFluidtopicsSourceConfigurationContentScope.Maps => "maps",
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
                "maps" => BaseFluidtopicsSourceConfigurationContentScope.Maps,
                "topics" => BaseFluidtopicsSourceConfigurationContentScope.Topics,
                _ => null,
            };
        }
    }
}