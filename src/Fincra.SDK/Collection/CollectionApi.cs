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
                { "page", request.Page.ToString() },
                { "perPage", request.PerPage.ToString() }
            };

            if (!string.IsNullOrEmpty(request.Business))
            {
                queryParameters.Add("business", request.Business);
            }

            if (!string.IsNullOrEmpty(request.SourceCurrency))
            {
                queryParameters.Add("sourceCurrency", request.SourceCurrency);
            }

            if (!string.IsNullOrEmpty(request.DestinationCurrency))
            {
                queryParameters.Add("destinationCurrency", request.DestinationCurrency);
            }

            if (!string.IsNullOrEmpty(request.SubAccount))
            {
                queryParameters.Add("subAccount", request.SubAccount);
            }

            if (request.DateFrom != null)
            {
                queryParameters.Add("dateFrom", request.DateFrom.ToString());
            }

            if (request.DateTo != null)
            {
                queryParameters.Add("dateTo", request.DateTo.ToString());
            }

            if (request.Status != null)
            {
                for (int i = 0; i < request.Status.Length; i++)
                {
                    string key = $"status";
                    string value = request.Status[i];
                    queryParameters.Add(key, value);
                }
            }
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Collection}", queryParameters);
        }

        public ApiResponse<dynamic> FetchCollectionAddition(string BusinessId, string Reference)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "business", BusinessId },
            };
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Collection}/reference/{Reference}", queryParameters);
        }
    }
}

