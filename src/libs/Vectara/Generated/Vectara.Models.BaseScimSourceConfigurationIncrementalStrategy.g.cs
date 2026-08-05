
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How incremental syncs detect changed users. `last_modified_filter` pushes the change<br/>
    /// window into the SCIM filter query parameter as a `meta.lastModified` range.<br/>
    /// `client_side` enumerates every user on each run and evaluates the change window<br/>
    /// locally. Support for the filter query parameter is optional in the SCIM 2.0<br/>
    /// specification. Set `client_side` when the service provider does not support<br/>
    /// filtering on `meta.lastModified`.<br/>
    /// Default Value: last_modified_filter
    /// </summary>
    public enum BaseScimSourceConfigurationIncrementalStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        ClientSide,
        /// <summary>
        /// 
        /// </summary>
        LastModifiedFilter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseScimSourceConfigurationIncrementalStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseScimSourceConfigurationIncrementalStrategy value)
        {
            return value switch
            {
                BaseScimSourceConfigurationIncrementalStrategy.ClientSide => "client_side",
                BaseScimSourceConfigurationIncrementalStrategy.LastModifiedFilter => "last_modified_filter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseScimSourceConfigurationIncrementalStrategy? ToEnum(string value)
        {
            return value switch
            {
                "client_side" => BaseScimSourceConfigurationIncrementalStrategy.ClientSide,
                "last_modified_filter" => BaseScimSourceConfigurationIncrementalStrategy.LastModifiedFilter,
                _ => null,
            };
        }
    }
}