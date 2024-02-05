using Newtonsoft.Json;

namespace Fincra.SDK
{
    public class Settings
    {
        [JsonProperty("feeBearer")]
        public string? FeeBearer { get; set; }

        [JsonProperty("settlementDestination")]
        public string? SettlementDestination { get; set; }

        [JsonProperty("enableWebhook")]
        public bool? EnableWebhook { get; set; }

        [JsonProperty("callbackURL")]
        public string? callbackURL { get; set; }
    }

    public class BusinessProfileResponse
    {
        [JsonProperty("_id")]
        public string? Id { get; set; }

        [JsonProperty("settings")]
        public Settings? Settings { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("businessTag")]
        public string? BusinessTag { get; set; }

        [JsonProperty("emailSettings")]
        public dynamic? EmailSettings { get; set; }

        [JsonProperty("isKYCApproved")]
        public bool IsKYCApproved { get; set; }

        [JsonProperty("isBlocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("mobile")]
        public string? Mobile { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("businessKey")]
        public string? BusinessKey { get; set; }

        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
    }
}

