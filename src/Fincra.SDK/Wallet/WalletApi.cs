namespace Fincra.SDK
{
    public class WalletApi : IWalletApi
    {
        private readonly FincraApi _api;
        public WalletApi(FincraApi api)
        {
            _api = api;
        }

        public ApiResponse<dynamic> ListWallet(WalletParams request)
        {
            if (request.Page <= 0) request.Page = 1;
            if (request.PerPage <= 0) request.PerPage = 100;

            var queryParameters = new Dictionary<string, string>
            {
                { "page", request.Page.ToString() },
                { "perPage", request.PerPage.ToString() }
            };

            if (!string.IsNullOrEmpty(request.Business))
            {
                queryParameters.Add("business", request.Business);
            }

            if (!string.IsNullOrEmpty(request.Reference))
            {
                queryParameters.Add("reference", request.Reference);
            }

            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Wallet}/topups", queryParameters);
        }

        public ApiResponse<dynamic> ListWalletLogs(WalletLogParams request)
        {
            if (request.Page <= 0) request.Page = 1;
            if (request.PerPage <= 0) request.PerPage = 100;

            var queryParameters = new Dictionary<string, string>
            {
                { "page", request.Page.ToString() },
                { "perPage", request.PerPage.ToString() }
            };

            if (!string.IsNullOrEmpty(request.Business))
            {
                queryParameters.Add("business", request.Business);
            }

            if (!string.IsNullOrEmpty(request.Action))
            {
                queryParameters.Add("action", request.Action);
            }

            if (!string.IsNullOrEmpty(request.Amount))
            {
                queryParameters.Add("amount", request.Amount);
            }

            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Wallet}/logs", queryParameters);
        }
    }
}

