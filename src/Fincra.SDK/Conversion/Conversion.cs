namespace Fincra.SDK
{
    public class CreateConversionRequest
    {
        [JsonProperty("business")]
        public string? Business { get; set; }

        [JsonProperty("quoteReference")]
        public string? QuoteReference { get; set; }

        [JsonProperty("customerReference")]
        public string? CustomerReference { get; set; }
    }
}

