namespace Fincra.SDK
{
	public class PayoutApi: IPayoutApi
	{
        private readonly FincraApi _api;
        public PayoutApi(FincraApi api)
        {
            _api = api;
        }

        public ApiResponse<dynamic> CreatePayout(CreatePayoutRequest request)
        {
            return _api.Post<ApiResponse<dynamic>>($"{FincraRoutes.Payout}", request);
        }
    }
}

