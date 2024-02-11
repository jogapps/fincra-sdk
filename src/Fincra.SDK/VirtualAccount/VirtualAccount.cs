using Newtonsoft.Json;

namespace Fincra.SDK
{
    public class KYCInformation
    {
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

        [JsonProperty("phone")]
        public string? Phone { get; set; }
        public bool ShouldSerializePhone() => !string.IsNullOrEmpty(Phone);

        [JsonProperty("birthDate")]
        public string? BirthDate { get; set; }
        public bool ShouldSerializeBirthDate() => !string.IsNullOrEmpty(BirthDate);

        [JsonProperty("nationality")]
        public string? Nationality { get; set; }
        public bool ShouldSerializeNationality() => !string.IsNullOrEmpty(Nationality);

        [JsonProperty("bvn")]
        public string? Bvn { get; set; }
        public bool ShouldSerializeBvn() => !string.IsNullOrEmpty(Bvn);

        [JsonProperty("businessName")]
        public string? BusinessName { get; set; }
        public bool ShouldSerializeBusinessName() => !string.IsNullOrEmpty(BusinessName);

        [JsonProperty("bvnName")]
        public string? BvnName { get; set; }
        public bool ShouldSerializeBvnName() => !string.IsNullOrEmpty(BvnName);

        [JsonProperty("businessCategory")]
        public string? BusinessCategory { get; set; }
        public bool ShouldSerializeBusinessCategory() => !string.IsNullOrEmpty(BusinessCategory);

        [JsonProperty("occupation")]
        public string? Occupation { get; set; }
        public bool ShouldSerializeOccupation() => !string.IsNullOrEmpty(Occupation);

        [JsonProperty("accountDesignation")]
        public string? AccountDesignation { get; set; }
        public bool ShouldSerializeAccountDesignation() => !string.IsNullOrEmpty(AccountDesignation);

        [JsonProperty("sourceOfIncome")]
        public string? SourceOfIncome { get; set; }
        public bool ShouldSerializeSourceOfIncome() => !string.IsNullOrEmpty(SourceOfIncome);

        [JsonProperty("employmentStatus")]
        public string? EmploymentStatus { get; set; }
        public bool ShouldSerializeEmploymentStatus() => !string.IsNullOrEmpty(EmploymentStatus);

        [JsonProperty("incomeBand")]
        public string? IncomeBand { get; set; }
        public bool ShouldSerializeIncomeBand() => !string.IsNullOrEmpty(IncomeBand);
    }

    public class CreateVirtualAccountRequest
    {
        [JsonProperty("currency")]
        public string? Currency { get; set; }
        public bool ShouldSerializeCurrency() => !string.IsNullOrEmpty(Currency);

        [JsonProperty("utilityBill")]
        public string? UtilityBill { get; set; }
        public bool ShouldSerializeUtilityBill() => !string.IsNullOrEmpty(UtilityBill);

        [JsonProperty("bankStatement")]
        public string? BankStatement { get; set; }
        public bool ShouldSerializeBankStatement() => !string.IsNullOrEmpty(BankStatement);

        [JsonProperty("accountType")]
        public string? AccountType { get; set; }
        public bool ShouldSerializeBusiness() => !string.IsNullOrEmpty(AccountType);

        [JsonProperty("KYCInformation")]
        public KYCInformation? KYCInformation { get; set; }
        public bool ShouldSerializeKYCInformation() => KYCInformation != null;

        [JsonProperty("dateOfBirth")]
        public string? DateOfBirth { get; set; }
        public bool ShouldSerializeDateOfBirth() => !string.IsNullOrEmpty(DateOfBirth);

        [JsonProperty("meansOfId")]
        public string? MeansOfId { get; set; }
        public bool ShouldSerializeMeansOfId() => !string.IsNullOrEmpty(MeansOfId);

        [JsonProperty("reason")]
        public string? Reason { get; set; }
        public bool ShouldSerializeReason() => !string.IsNullOrEmpty(Reason);

        [JsonProperty("monthlyVolume")]
        public string? MonthlyVolume { get; set; }
        public bool ShouldSerializeMonthlyVolume() => !string.IsNullOrEmpty(MonthlyVolume);

        [JsonProperty("paymentFlowDescription")]
        public string? PaymentFlowDescription { get; set; }
        public bool ShouldSerializePaymentFlowDescription() => !string.IsNullOrEmpty(PaymentFlowDescription);

        [JsonProperty("entityName")]
        public string? EntityName { get; set; }
        public bool ShouldSerializeEntityName() => !string.IsNullOrEmpty(EntityName);

        [JsonProperty("channel")]
        public string? Channel { get; set; }
        public bool ShouldSerializeChannel() => !string.IsNullOrEmpty(Channel);

        [JsonProperty("merchantReference")]
        public string? MerchantReference { get; set; }
        public bool ShouldSerializeMerchantReference() => !string.IsNullOrEmpty(MerchantReference);
    }

    public class VirtualAccountParams
    {
        public string? Currency { get; set; }

        public string? Status { get; set; }

        public string? BusinessName { get; set; }

        public string? IssuedDate { get; set; }

        public string? RequestedDate { get; set; }

        public string? AccountNumber { get; set; }

        public string? BusinessId { get; set; }

        public string? SubAccountId { get; set; }

        public int? Page { get; set; }

        public int? PerPage { get; set; }
    }

    public class DeactivateVirtualAccountRequest
    {
        [JsonProperty("business_reject_reason")]
        public string? BusinessRejectReason { get; set; }
        public bool ShouldSerializeBusinessRejectReason() => !string.IsNullOrEmpty(BusinessRejectReason);
    }
}

