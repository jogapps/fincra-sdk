namespace Fincra.SDK
{
	public class ConversionApi: IConversionApi
	{
        private readonly FincraApi _api;
        public ConversionApi(FincraApi api)
        {
            _api = api;
        }
    }
}

