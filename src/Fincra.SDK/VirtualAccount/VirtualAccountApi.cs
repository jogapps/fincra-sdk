using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public ApiResponse<dynamic> DeactivateVirtualAccount(string VirtualAccountId)
        {
            return _api.Patch<ApiResponse<dynamic>>($"{FincraRoutes.VirtualAccount}/inactive",
                JsonConvert.SerializeObject(new
                {
                    Id = VirtualAccountId
                }));
        }

        public ApiResponse<dynamic> FetchSingleVirtualAccount(string VirtualAccountId)
        {
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.VirtualAccount}/{VirtualAccountId}");
        }

        public ApiResponse<dynamic> FetchVirtualAccountByCurrency(string Currency)
        {
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.VirtualAccount}?currency={Currency}");
        }

        public ApiResponse<dynamic> ListMerchantVirtual(VirtualAccountParams request)
        {
            var queryParameters = new Dictionary<string, string> {};

            if (!string.IsNullOrEmpty(request.Currency))
            {
                queryParameters.Add("currency", request.Currency);
            }

            if (!string.IsNullOrEmpty(request.BusinessName))
            {
                queryParameters.Add("businessName", request.BusinessName);
            }

            if (!string.IsNullOrEmpty(request.IssuedDate))
            {
                queryParameters.Add("issuedDate", request.IssuedDate);
            }

            if (!string.IsNullOrEmpty(request.RequestedDate))
            {
                queryParameters.Add("requestedDate", request.RequestedDate);
            }

            if (!string.IsNullOrEmpty(request.AccountNumber))
            {
                queryParameters.Add("accountNumber", request.AccountNumber);
            }

            if (!string.IsNullOrEmpty(request.Status))
            {
                queryParameters.Add("status", request.Status);
            }
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.VirtualAccount}", queryParameters);
        }

        public ApiResponse<dynamic> ListSubVirtualAccounts(VirtualAccountParams request)
        {
            if (request.Page <= 0) request.Page = 1;
            if (request.PerPage <= 0) request.PerPage = 100;

            var queryParameters = new Dictionary<string, string>
            {
                { "page", request.Page.ToString() },
                { "perPage", request.PerPage.ToString() }
            };
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.VirtualAccount}/business/${request.BusinessId}/sub-accounts/${request.SubAccountId}", queryParameters);
        }

        public ApiResponse<dynamic> ListVirtualAccountRequests()
        {
            return _api.Get<ApiResponse<dynamic>>($"{FincraRoutes.VirtualAccount}/requests");
        }
    }
}