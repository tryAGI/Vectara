
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Customer configuration.
    /// </summary>
    public sealed partial class CustomerConfiguration
    {
        /// <summary>
        /// The unique identifier of the customer.<br/>
        /// Example: 1234567890
        /// </summary>
        /// <example>1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CustomerId { get; set; }

        /// <summary>
        /// The operational status of the customer account.<br/>
        /// Example: ACTIVE
        /// </summary>
        /// <example>ACTIVE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operational_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.CustomerConfigurationOperationalStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.CustomerConfigurationOperationalStatus OperationalStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerConfiguration" /> class.
        /// </summary>
        /// <param name="customerId">
        /// The unique identifier of the customer.<br/>
        /// Example: 1234567890
        /// </param>
        /// <param name="operationalStatus">
        /// The operational status of the customer account.<br/>
        /// Example: ACTIVE
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerConfiguration(
            long customerId,
            global::Vectara.CustomerConfigurationOperationalStatus operationalStatus)
        {
            this.CustomerId = customerId;
            this.OperationalStatus = operationalStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerConfiguration" /> class.
        /// </summary>
        public CustomerConfiguration()
        {
        }
    }
}