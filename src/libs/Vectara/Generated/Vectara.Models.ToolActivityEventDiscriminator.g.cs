
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolActivityEventDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.ToolActivityEventDiscriminatorActivityTypeJsonConverter))]
        public global::Vectara.ToolActivityEventDiscriminatorActivityType? ActivityType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolActivityEventDiscriminator" /> class.
        /// </summary>
        /// <param name="activityType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolActivityEventDiscriminator(
            global::Vectara.ToolActivityEventDiscriminatorActivityType? activityType)
        {
            this.ActivityType = activityType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolActivityEventDiscriminator" /> class.
        /// </summary>
        public ToolActivityEventDiscriminator()
        {
        }

    }
}