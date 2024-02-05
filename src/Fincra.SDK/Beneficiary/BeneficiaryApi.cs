namespace Fincra.SDK
{
	public class BeneficiaryApi: IBeneficiaryApi
	{
        private readonly FincraApi _api;
        public BeneficiaryApi(FincraApi api)
		{
            _api = api;
        }

        public ApiResponse<BeneficiaryResponse> CreateBeneficiary(string BusinessId, BeneficiaryRequest request)
        {
            return _api.Post<ApiResponse<BeneficiaryResponse>>($"{FincraRoutes.Beneficiary}/{BusinessId}", request);
        }

        public ApiResponse<BeneficiaryResponse> DeleteBeneficiary(string BusinessId, string BeneficiaryID)
        {
            return _api.Delete<ApiResponse<BeneficiaryResponse>>($"{FincraRoutes.Beneficiary}/{BusinessId}/{BeneficiaryID}");
        }

        public ApiResponse<BeneficiaryResponse> FetchBeneficiary(string BusinessId, string BeneficiaryID)
        {
            return _api.Get<ApiResponse<BeneficiaryResponse>>($"{FincraRoutes.Beneficiary}/{BusinessId}/{BeneficiaryID}");
        }

        public ApiResponseList<BeneficiaryResponse> ListBeneficiaries(string BusinessId, int Page, int PerPage)
        {
            if (Page <= 0) Page = 1;
            if (PerPage <= 0) PerPage = 100;

            var queryParameters = new Dictionary<string, string>
            {
                { "page", Page.ToString() },
                { "perPage", PerPage.ToString() }
            };

            return _api.Get<ApiResponseList<BeneficiaryResponse>>($"{FincraRoutes.Beneficiary}/{BusinessId}", queryParameters);
        }

        public ApiResponse<BeneficiaryResponse> UpdateBeneficiary(string BusinessId, string BeneficiaryID, BeneficiaryRequest request)
        {
            return _api.Patch<ApiResponse<BeneficiaryResponse>>($"{FincraRoutes.Beneficiary}/{BusinessId}/{BeneficiaryID}", request);
        }
    }
}

