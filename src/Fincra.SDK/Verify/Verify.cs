using Newtonsoft.Json;

namespace Fincra.SDK
{
	public class VerifyBankAccountRequest
    {
        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }
        public bool ShouldSerializeAccountNumber() => !string.IsNullOrEmpty(AccountNumber);

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }
        public bool ShouldSerializeBankCode() => !string.IsNullOrEmpty(BankCode);

        [JsonProperty("type")]
        public string? Type { get; set; }
        public bool ShouldSerializeType() => !string.IsNullOrEmpty(Type);

        [JsonProperty("iban")]
        public string? Iban { get; set; }
        public bool ShouldSerializeIban() => !string.IsNullOrEmpty(Iban);
    }

    public class ResolveBvnRequest
    {
        [JsonProperty("bvn")]
        public string? Bvn { get; set; }

        [JsonProperty("business")]
        public string? Business { get; set; }
    }
}

