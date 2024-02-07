namespace Fincra.SDK
{
	public interface IVerifyApi
	{
        ApiResponse<dynamic> VerifyBankAccount(VerifyBankAccountRequest request);

        ApiResponse<dynamic> VerifyPayment(string xBusinessId, string Reference);

        ApiResponse<dynamic> ResolveBvn(ResolveBvnRequest request);
    }
}

