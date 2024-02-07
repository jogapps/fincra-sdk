using Newtonsoft.Json;

namespace Fincra.SDK
{
    public class CreateConversionRequest
    {
        [JsonProperty("business")]
        public string? Business { get; set; }
        public bool ShouldSerializeBusiness() => !string.IsNullOrEmpty(Business);

        [JsonProperty("quoteReference")]
        public string? QuoteReference { get; set; }
        public bool ShouldSerializeQuoteReference() => !string.IsNullOrEmpty(QuoteReference);

        [JsonProperty("customerReference")]
        public string? CustomerReference { get; set; }
        public bool ShouldSerializeCustomerReference() => !string.IsNullOrEmpty(CustomerReference);
    }
}

