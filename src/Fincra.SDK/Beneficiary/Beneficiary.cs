using Newtonsoft.Json;

namespace Fincra.SDK
{
    public class Address
    {
        [JsonProperty("country")]
        public required string Country { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }
        public bool ShouldSerializeState() => !string.IsNullOrEmpty(State);

        [JsonProperty("zip")]
        public string? Zip { get; set; }
        public bool ShouldSerializeZip() => !string.IsNullOrEmpty(Zip);

        [JsonProperty("city")]
        public string? City { get; set; }
        public bool ShouldSerializeCity() => !string.IsNullOrEmpty(City);

        [JsonProperty("street")]
        public string? Street { get; set; }
        public bool ShouldSerializeStreet() => !string.IsNullOrEmpty(Street);
    }

    public class Bank
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
        public bool ShouldSerializeName() => !string.IsNullOrEmpty(Name);

        [JsonProperty("code")]
        public string? Code { get; set; }
        public bool ShouldSerializeCode() => !string.IsNullOrEmpty(Code);

        [JsonProperty("sortCode")]
        public string SortCode { get; set; }
        public bool ShouldSerializeSortCode() => !string.IsNullOrEmpty(SortCode);

        [JsonProperty("address")]
        public Address? Address { get; set; }
        public bool ShouldSerializeAddress() => Address != null;
    }

    public class BeneficiaryRequest
	{
        [JsonProperty("firstName")]
        public required string FirstName { get; set; }

        [JsonProperty("lastName")]
        public  string? LastName { get; set; }
        public bool ShouldSerializeLastName() => !string.IsNullOrEmpty(LastName);

        [JsonProperty("email")]
        public string? Email { get; set; }
        public bool ShouldSerializeEmail() => !string.IsNullOrEmpty(Email);

        [JsonProperty("phoneNumber")]
        public string? PhoneNumber { get; set; }
        public bool ShouldSerializePhoneNumber() => !string.IsNullOrEmpty(PhoneNumber);

        [JsonProperty("accountHolderName")]
        public required string AccountHolderName { get; set; }

        [JsonProperty("bank")]
        public Bank? Bank { get; set; }
        public bool ShouldSerializeBank() => Bank != null;

        [JsonProperty("address")]
        public required Address Address { get; set; }

        [JsonProperty("type")]
        public required string Type { get; set; }

        [JsonProperty("currency")]
        public required string Currency { get; set; }

        [JsonProperty("paymentDestination")]
        public required string PaymentDestination { get; set; }

        [JsonProperty("uniqueIdentifier")]
        public string? UniqueIdentifier { get; set; }
        public bool ShouldSerializeUniqueIdentifier() => !string.IsNullOrEmpty(UniqueIdentifier);

        [JsonProperty("destinationAddress")]
        public required string destinationAddress { get; set; }
    }

    public class BeneficiaryResponse
    {
        [JsonProperty("_id")]
        public required string Id { get; set; }

        [JsonProperty("firstName")]
        public string? FirstName { get; set; }

        [JsonProperty("lastName")]
        public string? LastName { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("accountHolderName")]
        public string? AccountHolderName { get; set; }

        [JsonProperty("bank")]
        public Bank? Bank { get; set; }

        [JsonProperty("address")]
        public Address? Address { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("paymentDestination")]
        public string? PaymentDestination { get; set; }

        [JsonProperty("uniqueIdentifier")]
        public string? UniqueIdentifier { get; set; }

        [JsonProperty("destinationAddress")]
        public string? destinationAddress { get; set; }

        [JsonProperty("business")]
        public string? Business { get; set; }

        [JsonProperty("paymentScheme")]
        public dynamic? PaymentScheme { get; set; }

        [JsonProperty("isResolved")]
        public bool IsResolved { get; set; }

        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
    }
}

