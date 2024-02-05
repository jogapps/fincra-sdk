namespace Fincra.SDK
{
    public class CreateQuoteRequest
    {
        [JsonProperty("action")]
        public string? Action { get; set; }

        [JsonProperty("amount")]
        public string? Amount { get; set; }

        [JsonProperty("beneficiaryType")]
        public string? BeneficiaryType { get; set; }

        [JsonProperty("business")]
        public string? Business { get; set; }

        [JsonProperty("destinationCurrency")]
        public string? DestinationCurrency { get; set; }

        [JsonProperty("feeBearer")]
        public string? FeeBearer { get; set; }

        [JsonProperty("paymentDestination")]
        public string? PaymentDestination { get; set; }


        [JsonProperty("paymentScheme")]
        public string? PaymentScheme { get; set; }

        [JsonProperty("sourceCurrency")]
        public string? SourceCurrency { get; set; }

        [JsonProperty("transactionType")]
        public string? TransactionType { get; set; }
    }
}