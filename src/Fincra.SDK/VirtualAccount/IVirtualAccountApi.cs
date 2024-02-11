namespace Fincra.SDK
{
	public interface IVirtualAccountApi
	{
        ApiResponse<dynamic> CreateVirtualAccount(CreateVirtualAccountRequest request);
        ApiResponse<dynamic> ListMerchantVirtual(VirtualAccountParams request);
        ApiResponse<dynamic> ListVirtualAccountRequests();
        ApiResponse<dynamic> FetchVirtualAccountByCurrency(string Currency);
        ApiResponse<dynamic> FetchSingleVirtualAccount(string VirtualAccountId);
        ApiResponse<dynamic> ListSubVirtualAccounts(VirtualAccountParams request);
        ApiResponse<dynamic> DeactivateVirtualAccount(string VirtualAccountId);
    }
}

