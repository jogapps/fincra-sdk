namespace Fincra.SDK
{
	public interface IVirtualAccountApi
	{
        ApiResponse<dynamic> CreateVirtualAccount(CreateQuoteRequest request);
    }
}

