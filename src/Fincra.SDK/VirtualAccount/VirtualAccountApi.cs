namespace Fincra.SDK
{
	public class VirtualAccountApi: IVirtualAccountApi
	{
        private readonly FincraApi _api;
        public VirtualAccountApi(FincraApi api)
        {
            _api = api;
        }

        public ApiResponse<dynamic> CreateVirtualAccount(CreateVirtualAccountRequest request)
        {
            return _api.Post<ApiResponse<dynamic>>($"{FincraRoutes.VirtualAccount}/requests", request);
        }
    }
}

