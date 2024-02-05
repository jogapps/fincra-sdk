namespace Fincra.SDK
{
	public interface ICollectionApi
	{
        ApiResponse<dynamic> PayWithTransfer(PayWithTransferRequest request);
        ApiResponse<dynamic> ListCollectionMain(PayWithTransferRequest request);
    }
}

