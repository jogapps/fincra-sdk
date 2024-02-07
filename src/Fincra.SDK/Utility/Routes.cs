namespace Fincra.SDK
{
	public class FincraRoutes
	{
		public const string SANDBOX_BASE_URL = "https://sandboxapi.fincra.com";
		public const string PROD_BASE_URL = "https://api.fincra.com";
        public const string Profile = "/profile/business/me";
		public const string Beneficiary = "/profile/beneficiaries/business";
		public const string ChargeBack = "/collections/chargebacks";
		public const string VirtualAccount = "/profile/virtual-accounts/transfer";
		public const string Wallet = "/wallets";
        public const string Collection = "/collections";
		public const string Conversion = "/conversions";
		public const string Quote = "/quotes/generate";
		public const string Core = "/core";
		public const string Checkout = "/checkout/payments";
    }
}

