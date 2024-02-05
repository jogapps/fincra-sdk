namespace Fincra.SDK
{
    public interface IQuoteApi
    {
        ApiResponse<dynamic> CreateQuote(CreateQuoteRequest request);
    }
}

