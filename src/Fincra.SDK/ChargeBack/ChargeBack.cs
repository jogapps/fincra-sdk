using Newtonsoft.Json;

namespace Fincra.SDK
{
    public class ChargeBackRequest
    {
        [JsonProperty("business_reject_reason")]
        public string? BusinessRejectReason { get; set; }
        public bool ShouldSerializeBusinessRejectReason() => !string.IsNullOrEmpty(BusinessRejectReason);
    }
}

