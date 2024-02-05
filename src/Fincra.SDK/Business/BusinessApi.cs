namespace Fincra.SDK
{
	public class BusinessApi: IBusinessApi
	{
        private readonly FincraApi _api;
		public BusinessApi(FincraApi api)
		{
            _api = api;
		}

        public ApiResponse<BusinessProfileResponse> GetBusinessId()
        {
            return _api.Get<ApiResponse<BusinessProfileResponse>>($"{FincraRoutes.Profile}");
        }
    }
}

