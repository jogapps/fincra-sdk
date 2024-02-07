namespace Fincra.SDK
{
	public interface IWalletApi
	{
        ApiResponse<dynamic> ListWallet(WalletParams request);

        ApiResponse<dynamic> ListWalletLogs(WalletLogParams request);
    }
}

