namespace Fincra.SDK
{
    public class VerifyApi : IVerifyApi
    {
        private readonly FincraApi _api;
        public VerifyApi(FincraApi api)
        {
            _api = api;
        }

        public ApiResponse<dynamic> ResolveBvn(ResolveBvnRequest request)
        {
            return _api.Post<ApiResponse<dynamic>>($"{FincraRoutes.Core}/bvn-verification", request);
        }

        public ApiResponse<dynamic> VerifyBankAccount(VerifyBankAccountRequest request)
        {
            return _api.Post<ApiResponse<dynamic>>($"{FincraRoutes.Core}/accounts/resolve", request);
        }

        public ApiResponse<dynamic> VerifyPayment(string XBusinessId, string Reference)
        {
            var customHeaders = new Dictionary<string, string>
            {
                { "X-Business-Id", XBusinessId }
            };
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Checkout}/merchant-reference/{Reference}", null, customHeaders);
        }
    }
}

