
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Confluence deployment type. `cloud` for Atlassian-hosted Confluence Cloud. `data_center`<br/>
    /// for a self-hosted Confluence Data Center or legacy Server instance.<br/>
    /// Default Value: cloud
    /// </summary>
    public enum BaseConfluenceSourceConfigurationDeployment
    {
        /// <summary>
        /// 
        /// </summary>
        Cloud,
        /// <summary>
        /// 
        /// </summary>
        DataCenter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseConfluenceSourceConfigurationDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseConfluenceSourceConfigurationDeployment value)
        {
            return value switch
            {
                BaseConfluenceSourceConfigurationDeployment.Cloud => "cloud",
                BaseConfluenceSourceConfigurationDeployment.DataCenter => "data_center",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseConfluenceSourceConfigurationDeployment? ToEnum(string value)
        {
            return value switch
            {
                "cloud" => BaseConfluenceSourceConfigurationDeployment.Cloud,
                "data_center" => BaseConfluenceSourceConfigurationDeployment.DataCenter,
                _ => null,
            };
        }
    }
}