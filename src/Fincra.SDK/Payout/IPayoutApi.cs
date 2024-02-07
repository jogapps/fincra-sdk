namespace Fincra.SDK
{
	public interface IPayoutApi
	{
        ApiResponse<dynamic> CreatePayout(CreatePayoutRequest request);
    }
}

