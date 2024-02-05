namespace Fincra.SDK
{
	public class ConversionApi: IConversionApi
	{
        private readonly FincraApi _api;
        public ConversionApi(FincraApi api)
        {
            _api = api;
        }

        public ApiResponse<dynamic> CreateConversion(CreateConversionRequest request)
        {
            return _api.Post<ApiResponse<dynamic>>($"{FincraRoutes.Conversion}/initiate", request);
        }

        public ApiResponse<dynamic> FetchConversion(string ConversionId)
        {
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Conversion}/reference/{ConversionId}");
        }

        public ApiResponse<dynamic> GetBusinessConversions(string BusinessId)
        {
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Conversion}?business={BusinessId}");
        }
    }
}

