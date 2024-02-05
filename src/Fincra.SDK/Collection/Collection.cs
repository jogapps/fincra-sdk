using Newtonsoft.Json;

namespace Fincra.SDK
{
    public class PayWithTransferRequest
    {
        private string? _channel;

        [JsonProperty("expiresAt")]
        public string? ExpiresAt { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("merchantReference")]
        public string? MerchantReference { get; set; }

        [JsonProperty("channel")]
        public string? Channel
        {
            get { return _channel ?? "globus"; }
            set { _channel = value; }
        }
    }

    public class CollectionParams
    {
        public string? Business { get; set; }

        public string? Reference { get; set; }

        public int? Page { get; set; }

        public int? PerPage { get; set; }

        public string[]? Status { get; set; } = Array.Empty<string>();

        public string? SourceCurrency { get; set; }

        public string? DestinationCurrency { get; set; }

        public string? SubAccount { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }
    }
}

