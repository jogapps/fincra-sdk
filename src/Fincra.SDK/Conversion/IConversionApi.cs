namespace Fincra.SDK
{
	public interface IConversionApi
	{
        ApiResponse<dynamic> CreateConversion(CreateConversionRequest request);
        ApiResponse<dynamic> FetchConversion(string ConversionId);
        ApiResponse<dynamic> GetBusinessConversions(string BusinessId);
    }
}

