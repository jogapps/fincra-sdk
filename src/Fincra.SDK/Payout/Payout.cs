using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fincra.SDK
{
    public class Document
    {
        [JsonProperty("type")]
        public string? Type { get; set; }
        public bool ShouldSerializeState() => !string.IsNullOrEmpty(Type);

        [JsonProperty("number")]
        public string? Number { get; set; }
        public bool ShouldSerializeNumber() => !string.IsNullOrEmpty(Number);

        [JsonProperty("issuedCountryCode")]
        public string? IssuedCountryCode { get; set; }
        public bool ShouldSerializeIssuedCountryCode() => !string.IsNullOrEmpty(IssuedCountryCode);

        [JsonProperty("issuedBy")]
        public string? IssuedBy { get; set; }
        public bool ShouldSerializeIssuedBy() => !string.IsNullOrEmpty(IssuedBy);

        [JsonProperty("issuedDate")]
        public string? IssuedDate { get; set; }
        public bool ShouldSerializeIssuedDate() => !string.IsNullOrEmpty(IssuedDate);

        [JsonProperty("expirationDate")]
        public string? ExpirationDate { get; set; }
        public bool ShouldSerializeExpirationDate() => !string.IsNullOrEmpty(ExpirationDate);
    }

    public class Beneficiary
    {
        [JsonProperty("country")]
        public string? Country { get; set; }
        public bool ShouldSerializeLastCountry() => !string.IsNullOrEmpty(Country);

        [JsonProperty("address")]
        public Address? Address { get; set; }

        [JsonProperty("document")]
        public Document? Document { get; set; }

        [JsonProperty("firstName")]
        public string? FirstName { get; set; }

        [JsonProperty("lastName")]
        public string? LastName { get; set; }
        public bool ShouldSerializeLastName() => !string.IsNullOrEmpty(LastName);

        [JsonProperty("email")]
        public string? Email { get; set; }
        public bool ShouldSerializeEmail() => !string.IsNullOrEmpty(Email);

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("accountHolderName")]
        public string? AccountHolderName { get; set; }
        public bool ShouldSerializeAccountHolderName() => !string.IsNullOrEmpty(AccountHolderName);

        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }
        public bool ShouldSerializeAccountNumber() => !string.IsNullOrEmpty(AccountNumber);

        [JsonProperty("mobileMoneyCode")]
        public string? MobileMoneyCode { get; set; }
        public bool ShouldSerializeMobileMoneyCode() => !string.IsNullOrEmpty(MobileMoneyCode);

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }
        public bool ShouldSerializeBankCode() => !string.IsNullOrEmpty(BankCode);


        [JsonProperty("bankSwiftCode")]
        public string? BankSwiftCode { get; set; }
        public bool ShouldSerializeBankSwiftCode() => !string.IsNullOrEmpty(BankSwiftCode);


        [JsonProperty("sortCode")]
        public string? SortCode { get; set; }
        public bool ShouldSerializeBankSortCode() => !string.IsNullOrEmpty(SortCode);

        [JsonProperty("registrationNumber")]
        public string? RegistrationNumber { get; set; }
        public bool ShouldSerializeRegistrationNumber() => !string.IsNullOrEmpty(RegistrationNumber);
    }

    public class CreatePayoutRequest
    {
        [JsonProperty("sourceCurrency")]
        public string? SourceCurrency { get; set; }
        public bool ShouldSerializeSourceCurrency() => !string.IsNullOrEmpty(SourceCurrency);

        [JsonProperty("destinationCurrency")]
        public string? DestinationCurrency { get; set; }
        public bool ShouldSerializeDestinationCurrency() => !string.IsNullOrEmpty(DestinationCurrency);

        [JsonProperty("beneficiary")]
        public Beneficiary? Beneficiary { get; set; }

        [JsonProperty("paymentDestination")]
        public string? PaymentDestination { get; set; }
        public bool ShouldSerializePaymentDestination() => !string.IsNullOrEmpty(PaymentDestination);

        [JsonProperty("amount")]
        public string? Amount { get; set; }
        public bool ShouldSerializeAmount() => !string.IsNullOrEmpty(Amount);

        [JsonProperty("business")]
        public string? Business { get; set; }
        public bool ShouldSerializeBusiness() => !string.IsNullOrEmpty(Business);

        [JsonProperty("description")]
        public string? Description { get; set; }
        public bool ShouldSerializeDescription() => !string.IsNullOrEmpty(Description);

        [JsonProperty("customerReference")]
        public string? CustomerReference { get; set; }
        public bool ShouldSerializeCustomerReference() => !string.IsNullOrEmpty(CustomerReference);

        [JsonProperty("paymentScheme")]
        public string? PaymentScheme { get; set; }
        public bool ShouldSerializePaymentScheme() => !string.IsNullOrEmpty(PaymentScheme);

        [JsonProperty("quoteReference")]
        public string? QuoteReference { get; set; }
        public bool ShouldSerializeQuoteReference() => !string.IsNullOrEmpty(QuoteReference);
    }

}