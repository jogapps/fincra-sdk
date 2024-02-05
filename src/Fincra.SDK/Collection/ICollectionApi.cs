namespace Fincra.SDK
{
	public interface ICollectionApi
	{
        ApiResponse<dynamic> PayWithTransfer(PayWithTransferRequest request);
        ApiResponse<dynamic> ListCollectionMain(CollectionParams request);
        ApiResponse<dynamic> ListCollectionAdditional(CollectionParams request);
        ApiResponse<dynamic> FetchCollectionAddition(string BusinessId, string Reference);
    }
}

