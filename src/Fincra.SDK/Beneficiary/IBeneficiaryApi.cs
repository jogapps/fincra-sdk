namespace Fincra.SDK
{
	public interface IBeneficiaryApi
	{
        ApiResponse<BeneficiaryResponse> CreateBeneficiary(string BusinessId, BeneficiaryRequest request);

        ApiResponse<BeneficiaryResponse> DeleteBeneficiary(string BusinessId, string BeneficiaryID);

        ApiResponse<BeneficiaryResponse> FetchBeneficiary(string BusinessId, string BeneficiaryID);

        ApiResponseList<BeneficiaryResponse> ListBeneficiaries(string BusinessId, int Page = 1, int PerPage = 100);

        ApiResponse<BeneficiaryResponse> UpdateBeneficiary(string BusinessId, string BeneficiaryID, BeneficiaryRequest request);
    }
}