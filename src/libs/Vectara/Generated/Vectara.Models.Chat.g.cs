
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A chat conversation with associated metadata and settings.
    /// </summary>
    public sealed partial class Chat
    {
        /// <summary>
        /// ID of the chat.<br/>
        /// Example: cht_123456789
        /// </summary>
        /// <example>cht_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The first query of the chat.<br/>
        /// Example: What are the arbitration terms in the Delaware employment contract?
        /// </summary>
        /// <example>What are the arbitration terms in the Delaware employment contract?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_query")]
        public string? FirstQuery { get; set; }

        /// <summary>
        /// The first answer of the chat.<br/>
        /// Example: Clause 9.2 mandates binding arbitration through AAA with venue in Delaware and a 30-day opt-out. California law governs the agreement.
        /// </summary>
        /// <example>Clause 9.2 mandates binding arbitration through AAA with venue in Delaware and a 30-day opt-out. California law governs the agreement.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_answer")]
        public string? FirstAnswer { get; set; }

        /// <summary>
        /// Indicates whether this chat is enabled and can have further turns.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies when this chat was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the chat.<br/>
        /// Example: cht_123456789
        /// </param>
        /// <param name="firstQuery">
        /// The first query of the chat.<br/>
        /// Example: What are the arbitration terms in the Delaware employment contract?
        /// </param>
        /// <param name="firstAnswer">
        /// The first answer of the chat.<br/>
        /// Example: Clause 9.2 mandates binding arbitration through AAA with venue in Delaware and a 30-day opt-out. California law governs the agreement.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether this chat is enabled and can have further turns.<br/>
        /// Example: true
        /// </param>
        /// <param name="createdAt">
        /// Specifies when this chat was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Chat(
            string? id,
            string? firstQuery,
            string? firstAnswer,
            bool? enabled,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.FirstQuery = firstQuery;
            this.FirstAnswer = firstAnswer;
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        public Chat()
        {
        }
    }
}