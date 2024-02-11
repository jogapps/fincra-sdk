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

        public ApiResponse<dynamic> FetchCustomerPayout(string CustomerReference)
        {
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Payout}/customer-reference/{CustomerReference}");
        }

        public ApiResponse<dynamic> FetchPayout(string Reference)
        {
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Payout}/reference/{Reference}");
        }

        public ApiResponse<dynamic> ListBanks()
        {
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Core}/banks?currency=NGN&country=NG");
        }


        public ApiResponse<dynamic> ListPayouts(ListPayoutParams request)
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
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.Payout}", queryParameters);
        }

        public ApiResponse<dynamic> UploadTransactionDocument(UploadTransactionDocumentRequest request)
        {
            return _api.Post<ApiResponse<dynamic>>($"{FincraRoutes.Payout}/documents-upload", request);
        }

        public ApiResponse<dynamic> WalletToWalletTransfer(WalletTransferRequest request)
        {
            return _api.Post<ApiResponse<dynamic>>($"{FincraRoutes.Payout}", request);
        }
    }
}

