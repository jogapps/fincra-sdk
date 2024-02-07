using Newtonsoft.Json;

namespace Fincra.SDK
{
    public class CreateQuoteRequest
    {
        [JsonProperty("action")]
        public string? Action { get; set; }
        public bool ShouldSerializeAction() => !string.IsNullOrEmpty(Action);

        [JsonProperty("amount")]
        public string? Amount { get; set; }
        public bool ShouldSerializeAmount() => !string.IsNullOrEmpty(Amount);

        [JsonProperty("beneficiaryType")]
        public string? BeneficiaryType { get; set; }
        public bool ShouldSerializeBeneficiaryType() => !string.IsNullOrEmpty(BeneficiaryType);

        [JsonProperty("business")]
        public string? Business { get; set; }
        public bool ShouldSerializeBusiness() => !string.IsNullOrEmpty(Business);

        [JsonProperty("destinationCurrency")]
        public string? DestinationCurrency { get; set; }
        public bool ShouldSerializeDestinationCurrency() => !string.IsNullOrEmpty(DestinationCurrency);

        [JsonProperty("feeBearer")]
        public string? FeeBearer { get; set; }
        public bool ShouldSerializeFeeBearer() => !string.IsNullOrEmpty(FeeBearer);

        [JsonProperty("paymentDestination")]
        public string? PaymentDestination { get; set; }
        public bool ShouldSerializePaymentDestination() => !string.IsNullOrEmpty(PaymentDestination);

        [JsonProperty("paymentScheme")]
        public string? PaymentScheme { get; set; }
        public bool ShouldSerializePaymentScheme() => !string.IsNullOrEmpty(PaymentScheme);

        [JsonProperty("sourceCurrency")]
        public string? SourceCurrency { get; set; }
        public bool ShouldSerializeSourceCurrency() => !string.IsNullOrEmpty(SourceCurrency);

        [JsonProperty("transactionType")]
        public string? TransactionType { get; set; }
        public bool ShouldSerializeTransactionType() => !string.IsNullOrEmpty(TransactionType);
    }
}