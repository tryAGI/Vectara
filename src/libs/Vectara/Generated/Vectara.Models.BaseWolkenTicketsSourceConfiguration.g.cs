
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base Wolken ServiceDesk tickets source configuration. Ingests incidents and service requests<br/>
    /// from a Wolken ServiceDesk instance. Each ticket becomes one document carrying the ticket<br/>
    /// subject, description, and conversation notes, with the ticket classification fields such as<br/>
    /// status, priority, category, and team as document metadata for attribute-based filtering.<br/>
    /// Requires Wolken credentials with read access to the incident and service request listing,<br/>
    /// detail, and notes endpoints.<br/>
    /// Incremental syncs read only the tickets updated since the previous run. Tickets are<br/>
    /// re-ingested when notes are added. A ticket whose notes cannot be read is not ingested.<br/>
    /// Deletions are not propagated. A ticket deleted or restricted in Wolken keeps its last<br/>
    /// indexed content.
    /// </summary>
    public sealed partial class BaseWolkenTicketsSourceConfiguration
    {
        /// <summary>
        /// Discriminator value identifying this source configuration as `wolken_tickets`.<br/>
        /// Default Value: wolken_tickets<br/>
        /// Example: wolken_tickets
        /// </summary>
        /// <default>"wolken_tickets"</default>
        /// <example>wolken_tickets</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "wolken_tickets";

        /// <summary>
        /// Base URL of the Wolken API.<br/>
        /// Example: https://example-api.wolkenservicedesk.com
        /// </summary>
        /// <example>https://example-api.wolkenservicedesk.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// The value of the `domain` header issued with your Wolken API credentials. Depending on the deployment this is either a tenant name or a full hostname.<br/>
        /// Example: example.wolkenservicedesk.com
        /// </summary>
        /// <example>example.wolkenservicedesk.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// The Wolken request types to ingest. When unset or empty, both incidents and service<br/>
        /// requests are ingested.<br/>
        /// Example: [incident, service_request]
        /// </summary>
        /// <example>[incident, service_request]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_types")]
        public global::System.Collections.Generic.IList<global::Vectara.WolkenTicketRequestType>? RequestTypes { get; set; }

        /// <summary>
        /// An ISO-8601 duration bounding how far back ingestion reaches. Applies when the pipeline<br/>
        /// has no watermark, which is the case on the first run and on every `full_refresh` run.<br/>
        /// Tickets whose last update is older than this duration before the run are not ingested.<br/>
        /// Days are the largest supported unit. A non-positive duration is rejected. When unset,<br/>
        /// the entire ticket history is ingested. On create and replace, a `null` value is<br/>
        /// equivalent to omitting the field. On update it is ignored and the stored value is<br/>
        /// kept. To unset this field, replace the pipeline with `PUT /v2/pipelines/{pipeline_key}`<br/>
        /// using a configuration that omits it.<br/>
        /// Example: P90D
        /// </summary>
        /// <example>P90D</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_window")]
        public string? BackfillWindow { get; set; }

        /// <summary>
        /// Wolken status IDs to restrict ingestion to. Status IDs are specific to your Wolken<br/>
        /// deployment. When unset or empty, tickets of every status are ingested. Unrecognized<br/>
        /// status IDs match no tickets. The filter applies to each ingested request type<br/>
        /// separately, and a ticket that leaves the configured statuses keeps its last indexed<br/>
        /// content until it returns to one of them.<br/>
        /// Example: [1, 3, 8]
        /// </summary>
        /// <example>[1, 3, 8]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_ids")]
        public global::System.Collections.Generic.IList<int>? StatusIds { get; set; }

        /// <summary>
        /// Wolken response type IDs selecting the notes included in each ticket document. Every<br/>
        /// note on a Wolken ticket carries a response type that classifies it, for example as an<br/>
        /// internal work note or an outbound comment to the requester. The IDs behind those<br/>
        /// classifications are specific to your Wolken deployment. When unset, notes of every<br/>
        /// response type are included. When empty, notes are not ingested. On create and<br/>
        /// replace, a `null` value is equivalent to omitting the field. On update it is ignored<br/>
        /// and the stored value is kept. To unset this field, replace the pipeline with<br/>
        /// `PUT /v2/pipelines/{pipeline_key}` using a configuration that omits it.<br/>
        /// Example: [2, 7]
        /// </summary>
        /// <example>[2, 7]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("note_response_type_ids")]
        public global::System.Collections.Generic.IList<int>? NoteResponseTypeIds { get; set; }

        /// <summary>
        /// Template for the portal URL of a ticket. The `{ticket_id}` placeholder is replaced with<br/>
        /// the ticket's numeric ID. When omitted, documents carry no URL metadata.<br/>
        /// Example: https://example.wolkenservicedesk.com/wolken-support/ticket_details?ticketId={ticket_id}
        /// </summary>
        /// <example>https://example.wolkenservicedesk.com/wolken-support/ticket_details?ticketId={ticket_id}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ticket_url_template")]
        public string? TicketUrlTemplate { get; set; }

        /// <summary>
        /// Wolken OAuth client ID.<br/>
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2
        /// </summary>
        /// <example>a1b2c3d4e5f6g7h8i9j0k1l2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Wolken service account the API calls run as. Sent as a header on API requests.<br/>
        /// Example: svc-tickets-reader@example.com
        /// </summary>
        /// <example>svc-tickets-reader@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account")]
        public string? ServiceAccount { get; set; }

        /// <summary>
        /// The auth code Wolken issues for the instance, used with `refresh_token` to obtain access<br/>
        /// tokens. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_code")]
        public string? AuthCode { get; set; }

        /// <summary>
        /// Long-lived refresh token exchanged for access tokens. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWolkenTicketsSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value identifying this source configuration as `wolken_tickets`.<br/>
        /// Default Value: wolken_tickets<br/>
        /// Example: wolken_tickets
        /// </param>
        /// <param name="baseUrl">
        /// Base URL of the Wolken API.<br/>
        /// Example: https://example-api.wolkenservicedesk.com
        /// </param>
        /// <param name="domain">
        /// The value of the `domain` header issued with your Wolken API credentials. Depending on the deployment this is either a tenant name or a full hostname.<br/>
        /// Example: example.wolkenservicedesk.com
        /// </param>
        /// <param name="requestTypes">
        /// The Wolken request types to ingest. When unset or empty, both incidents and service<br/>
        /// requests are ingested.<br/>
        /// Example: [incident, service_request]
        /// </param>
        /// <param name="backfillWindow">
        /// An ISO-8601 duration bounding how far back ingestion reaches. Applies when the pipeline<br/>
        /// has no watermark, which is the case on the first run and on every `full_refresh` run.<br/>
        /// Tickets whose last update is older than this duration before the run are not ingested.<br/>
        /// Days are the largest supported unit. A non-positive duration is rejected. When unset,<br/>
        /// the entire ticket history is ingested. On create and replace, a `null` value is<br/>
        /// equivalent to omitting the field. On update it is ignored and the stored value is<br/>
        /// kept. To unset this field, replace the pipeline with `PUT /v2/pipelines/{pipeline_key}`<br/>
        /// using a configuration that omits it.<br/>
        /// Example: P90D
        /// </param>
        /// <param name="statusIds">
        /// Wolken status IDs to restrict ingestion to. Status IDs are specific to your Wolken<br/>
        /// deployment. When unset or empty, tickets of every status are ingested. Unrecognized<br/>
        /// status IDs match no tickets. The filter applies to each ingested request type<br/>
        /// separately, and a ticket that leaves the configured statuses keeps its last indexed<br/>
        /// content until it returns to one of them.<br/>
        /// Example: [1, 3, 8]
        /// </param>
        /// <param name="noteResponseTypeIds">
        /// Wolken response type IDs selecting the notes included in each ticket document. Every<br/>
        /// note on a Wolken ticket carries a response type that classifies it, for example as an<br/>
        /// internal work note or an outbound comment to the requester. The IDs behind those<br/>
        /// classifications are specific to your Wolken deployment. When unset, notes of every<br/>
        /// response type are included. When empty, notes are not ingested. On create and<br/>
        /// replace, a `null` value is equivalent to omitting the field. On update it is ignored<br/>
        /// and the stored value is kept. To unset this field, replace the pipeline with<br/>
        /// `PUT /v2/pipelines/{pipeline_key}` using a configuration that omits it.<br/>
        /// Example: [2, 7]
        /// </param>
        /// <param name="ticketUrlTemplate">
        /// Template for the portal URL of a ticket. The `{ticket_id}` placeholder is replaced with<br/>
        /// the ticket's numeric ID. When omitted, documents carry no URL metadata.<br/>
        /// Example: https://example.wolkenservicedesk.com/wolken-support/ticket_details?ticketId={ticket_id}
        /// </param>
        /// <param name="clientId">
        /// Wolken OAuth client ID.<br/>
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2
        /// </param>
        /// <param name="serviceAccount">
        /// Wolken service account the API calls run as. Sent as a header on API requests.<br/>
        /// Example: svc-tickets-reader@example.com
        /// </param>
        /// <param name="authCode">
        /// The auth code Wolken issues for the instance, used with `refresh_token` to obtain access<br/>
        /// tokens. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="refreshToken">
        /// Long-lived refresh token exchanged for access tokens. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseWolkenTicketsSourceConfiguration(
            string type,
            string? baseUrl,
            string? domain,
            global::System.Collections.Generic.IList<global::Vectara.WolkenTicketRequestType>? requestTypes,
            string? backfillWindow,
            global::System.Collections.Generic.IList<int>? statusIds,
            global::System.Collections.Generic.IList<int>? noteResponseTypeIds,
            string? ticketUrlTemplate,
            string? clientId,
            string? serviceAccount,
            string? authCode,
            string? refreshToken)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.BaseUrl = baseUrl;
            this.Domain = domain;
            this.RequestTypes = requestTypes;
            this.BackfillWindow = backfillWindow;
            this.StatusIds = statusIds;
            this.NoteResponseTypeIds = noteResponseTypeIds;
            this.TicketUrlTemplate = ticketUrlTemplate;
            this.ClientId = clientId;
            this.ServiceAccount = serviceAccount;
            this.AuthCode = authCode;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWolkenTicketsSourceConfiguration" /> class.
        /// </summary>
        public BaseWolkenTicketsSourceConfiguration()
        {
        }

    }
}