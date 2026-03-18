
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response containing a list of customer configurations.
    /// </summary>
    public sealed partial class ListCustomerConfigurationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.CustomerConfiguration> Configurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomerConfigurationsResponse" /> class.
        /// </summary>
        /// <param name="configurations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCustomerConfigurationsResponse(
            global::System.Collections.Generic.IList<global::Vectara.CustomerConfiguration> configurations)
        {
            this.Configurations = configurations ?? throw new global::System.ArgumentNullException(nameof(configurations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomerConfigurationsResponse" /> class.
        /// </summary>
        public ListCustomerConfigurationsResponse()
        {
        }
    }
}