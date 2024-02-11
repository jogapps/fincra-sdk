namespace Fincra.SDK
{
	public interface IPayoutApi
	{
        ApiResponse<dynamic> CreatePayout(CreatePayoutRequest request);
        ApiResponse<dynamic> WalletToWalletTransfer(WalletTransferRequest request);
        ApiResponse<dynamic> ListPayouts(ListPayoutParams request);
        ApiResponse<dynamic> UploadTransactionDocument(UploadTransactionDocumentRequest request);
        ApiResponse<dynamic> FetchPayout(string Reference);
        ApiResponse<dynamic> FetchCustomerPayout(string CustomerReference);
        ApiResponse<dynamic> ListBanks();
    }
}

