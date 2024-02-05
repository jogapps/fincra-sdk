using Fincra.SDK;

namespace Fincra.Test
{
    public class FincraApiTest
    {
        private static IFincraApi _api;

        static FincraApiTest()
        {
            // Get FINCRA secret key from environmental variables
            string? fincraSecretKey = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("FINCRA_SECRET_KEY"))
                ? Constants.TEST_SECRET_KEY
                : Environment.GetEnvironmentVariable("FINCRA_SECRET_KEY");

            _api = new FincraApi(fincraSecretKey, true);
        }

        public static IFincraApi Api => _api;
    }

}

