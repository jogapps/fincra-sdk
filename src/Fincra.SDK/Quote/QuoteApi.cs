namespace Fincra.SDK
{
    public class QuoteApi : IQuoteApi
    {
        private readonly FincraApi _api;
        public QuoteApi(FincraApi api)
        {
            _api = api;
        }

        public ApiResponse<dynamic> CreateQuote(CreateQuoteRequest request)
        {
            return _api.Post<ApiResponse<dynamic>>($"{FincraRoutes.Quote}", request);
        }
    }
}

