
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenericToolActivityEventVariant2
    {
        /// <summary>
        /// Discriminator for ToolActivityEvent subtypes.<br/>
        /// Default Value: generic<br/>
        /// Example: generic
        /// </summary>
        /// <default>"generic"</default>
        /// <example>generic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActivityType { get; set; } = "generic";

        /// <summary>
        /// Human-readable progress update. Safe to render directly to the user.<br/>
        /// Example: Sub-agent finished step 2 of 5
        /// </summary>
        /// <example>Sub-agent finished step 2 of 5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericToolActivityEventVariant2" /> class.
        /// </summary>
        /// <param name="activityType">
        /// Discriminator for ToolActivityEvent subtypes.<br/>
        /// Default Value: generic<br/>
        /// Example: generic
        /// </param>
        /// <param name="message">
        /// Human-readable progress update. Safe to render directly to the user.<br/>
        /// Example: Sub-agent finished step 2 of 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenericToolActivityEventVariant2(
            string activityType,
            string message)
        {
            this.ActivityType = activityType ?? throw new global::System.ArgumentNullException(nameof(activityType));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericToolActivityEventVariant2" /> class.
        /// </summary>
        public GenericToolActivityEventVariant2()
        {
        }

    }
}