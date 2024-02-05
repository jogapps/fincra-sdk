namespace Fincra.SDK
{
    public class CollectionApi : ICollectionApi
    {
        private readonly FincraApi _api;
        public CollectionApi(FincraApi api)
        {
            _api = api;
        }

        public ApiResponse<dynamic> PayWithTransfer(PayWithTransferRequest request)
        {
            return _api.Post<ApiResponse<dynamic>>($"{FincraRoutes.VirtualAccount}", request);
        }

        public ApiResponse<dynamic> ListCollectionMain(CollectionParams request)
        {
            if (request.Page <= 0) request.Page = 1;
            if (request.PerPage <= 0) request.PerPage = 100;

            var queryParameters = new Dictionary<string, string>
            {
                { "business", request.Business },
                { "reference", request.Reference },
                { "page", request.Page.ToString() },
                { "perPage", request.PerPage.ToString() }
            };
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Wallet}", queryParameters);
        }

        public ApiResponse<dynamic> ListCollectionAdditional(CollectionParams request)
        {
            if (request.Page <= 0) request.Page = 1;
            if (request.PerPage <= 0) request.PerPage = 100;

            var queryParameters = new Dictionary<string, string>
            {
                { "business", request.Business },
                { "reference", request.Reference },
                { "page", request.Page.ToString() },
                { "perPage", request.PerPage.ToString() }
            };
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Collection}", queryParameters);
        }
    }
}

