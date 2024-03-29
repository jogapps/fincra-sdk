﻿using Newtonsoft.Json;

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
        public bool ShouldSerializeCountry() => !string.IsNullOrEmpty(Country);

        [JsonProperty("address")]
        public Address? Address { get; set; }
        public bool ShouldSerializeAddress() => Address != null;

        [JsonProperty("document")]
        public Document? Document { get; set; }
        public bool ShouldSerializeDocument() => Document != null;

        [JsonProperty("firstName")]
        public string? FirstName { get; set; }
        public bool ShouldSerializeirstName() => !string.IsNullOrEmpty(FirstName);

        [JsonProperty("lastName")]
        public string? LastName { get; set; }
        public bool ShouldSerializeLastName() => !string.IsNullOrEmpty(LastName);

        [JsonProperty("email")]
        public string? Email { get; set; }
        public bool ShouldSerializeEmail() => !string.IsNullOrEmpty(Email);

        [JsonProperty("type")]
        public string? Type { get; set; }
        public bool ShouldSerializeType() => !string.IsNullOrEmpty(Type);

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

    public class WalletTransferRequest
    {
        [JsonProperty("amount")]
        public string? Amount { get; set; }
        public bool ShouldSerializeAmount() => !string.IsNullOrEmpty(Amount);

        [JsonProperty("business")]
        public string? Business { get; set; }
        public bool ShouldSerializeBusiness() => !string.IsNullOrEmpty(Business);

        [JsonProperty("customerReference")]
        public string? CustomerReference { get; set; }
        public bool ShouldSerializeCustomerReference() => !string.IsNullOrEmpty(CustomerReference);

        [JsonProperty("description")]
        public string? Description { get; set; }
        public bool ShouldSerializeDescription() => !string.IsNullOrEmpty(Description);

        [JsonProperty("BeneficiaryWalletNumber")]
        public string? BeneficiaryWalletNumber { get; set; }
        public bool ShouldSerializeBeneficiaryWalletNumber() => !string.IsNullOrEmpty(BeneficiaryWalletNumber);
    }

    public class ListPayoutParams
    {
        public string[]? Status { get; set; } = Array.Empty<string>();

        public string? Business { get; set; }

        public string? SourceCurrency { get; set; }

        public string? DestinationCurrency { get; set; }

        public string? SubAccount { get; set; }

        public int? Page { get; set; }

        public int? PerPage { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }
    }

    public class UploadTransactionDocumentRequest
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
        public bool ShouldSerializeName() => !string.IsNullOrEmpty(Name);

        [JsonProperty("type")]
        public string? Type { get; set; }
        public bool ShouldSerializeType() => !string.IsNullOrEmpty(Type);

        [JsonProperty("reference")]
        public string? Reference { get; set; }
        public bool ShouldSerializeReference() => !string.IsNullOrEmpty(Reference);

        [JsonProperty("file")]
        public string? File { get; set; }
        public bool ShouldSerializeFile() => !string.IsNullOrEmpty(File);
    }

}