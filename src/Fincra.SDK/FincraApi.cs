using System.Net;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace Fincra.SDK
{
    public interface IFincraApi
    {
        IBusinessApi Business { get; }
        IBeneficiaryApi Beneficiary { get; }
        IChargeBackApi ChargeBacks { get; }
        ICollectionApi Collection { get; }
        IConversionApi Conversion { get; }
        IQuoteApi Quote { get; }
        IVerifyApi Verify { get; }
        IWalletApi Wallet { get; }
    }

    public class FincraApi : IFincraApi
    {
        private readonly HttpClient _client;

        public FincraApi(string secretKey, bool sandbox = true)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string baseUrl = sandbox ? FincraRoutes.SANDBOX_BASE_URL : FincraRoutes.PROD_BASE_URL;
            _client = new HttpClient { BaseAddress = new Uri($"{baseUrl}") };
            _client.DefaultRequestHeaders.Add("Api-Key", secretKey);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Business = new BusinessApi(this);
            Beneficiary = new BeneficiaryApi(this);
            ChargeBacks = new ChargeBackApi(this);
            Collection = new CollectionApi(this);
            Conversion = new ConversionApi(this);
            Quote = new QuoteApi(this);
            Verify = new VerifyApi(this);
            Wallet = new WalletApi(this);
        }

        //public static JsonSerializerSettings SerializerSettings { get; } = new JsonSerializerSettings
        //{
        //    ContractResolver = new CamelCasePropertyNamesContractResolver(),
        //    DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate
        //};

        public IBusinessApi Business { get; }
        public IBeneficiaryApi Beneficiary { get; }
        public IChargeBackApi ChargeBacks { get; }
        public ICollectionApi Collection { get; }
        public IConversionApi Conversion { get; }
        public IQuoteApi Quote { get; }
        public IVerifyApi Verify { get; }
        public IWalletApi Wallet { get; }


        //private static T ParseAndResolveData<T>(ref string rawJson)
        //{
        //    var jo = JObject.Parse(rawJson);
        //    var data = jo["data"];
        //    rawJson = data.ToString();

        //    var response = JsonConvert.DeserializeObject<T>(rawJson);

        //    return response;
        //}

        /// <summary>
        /// Make Get requests to Fincra API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <returns></returns>
        internal T Get<T>(string relativeUrl)
        {
            string responseStr = _client.GetAsync(relativeUrl)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;

            Console.WriteLine(responseStr);
            return JsonConvert.DeserializeObject<T>(responseStr); ;
        }

        /// <summary>
        /// Make Get requests to Fincra API with query parameters
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <param name="queryParameters">Dictionary of query parameters</param>
        /// <returns></returns>
        internal T Get<T>(string relativeUrl, Dictionary<string, string> queryParameters)
        {
            string queryString = "?";

            foreach (var param in queryParameters)
            {
                queryString += param.Key + "=" + param.Value + "&";
            }

            string responseStr = _client.GetAsync(relativeUrl + queryString)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;

            Console.WriteLine(responseStr);
            return JsonConvert.DeserializeObject<T>(responseStr);
        }

        internal T Get<T>(string relativeUrl,
            Dictionary<string, string> queryParameters = null,
            Dictionary<string, string> customHeaders = null)
        {
            string queryString = "?";

            if (queryParameters != null)
            {
                foreach (var param in queryParameters)
                {
                    queryString += param.Key + "=" + param.Value + "&";
                }
            }

            if (customHeaders != null)
            {
                foreach (var header in customHeaders)
                {
                    _client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }

            string responseStr = _client.GetAsync(relativeUrl + queryString)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;

            Console.WriteLine(responseStr);
            return JsonConvert.DeserializeObject<T>(responseStr);
        }

        /// <summary>
        /// Make Post requests to Fincra API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <param name="data">Payload to pass in body of request</param>
        /// <param name="queryParameters">Dictionary of query parameters</param>
        /// <returns></returns>
        internal T Post<T>(string relativeUrl,
                           object data,
                           Dictionary<string, string> queryParameters = null)
        {
            StringContent jsonData = null;

            if (data != null)
            {
                jsonData = new StringContent(JsonConvert.SerializeObject(data),
                                             Encoding.UTF8,
                                             "application/json");
            }

            string queryString = "?";

            if (queryParameters != null)
            {
                foreach (var param in queryParameters)
                {
                    queryString += param.Key + "=" + param.Value + "&";
                }
            }

            string responseStr = _client.PostAsync(relativeUrl + queryString, jsonData)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;
            Console.WriteLine(responseStr);

            return JsonConvert.DeserializeObject<T>(responseStr);
        }

        /// <summary>
        /// Make Post requests to Fincra API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <param name="data">Payload to pass in body of request</param>
        /// <param name="queryParameters">Dictionary of query parameters</param>
        /// <returns></returns>
        internal T Patch<T>(string relativeUrl,
                           object data,
                           Dictionary<string, string> queryParameters = null)
        {
            StringContent jsonData = null;

            if (data != null)
            {
                jsonData = new StringContent(JsonConvert.SerializeObject(data),
                                             Encoding.UTF8,
                                             "application/json");
            }

            string queryString = "?";

            if (queryParameters != null)
            {
                foreach (var param in queryParameters)
                {
                    queryString += param.Key + "=" + param.Value + "&";
                }
            }

            string responseStr = _client.PatchAsync(relativeUrl + queryString, jsonData)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;
            Console.WriteLine(responseStr);

            return JsonConvert.DeserializeObject<T>(responseStr);
        }

        /// <summary>
        /// Make Delete requests to Fincra to API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <returns></returns>
        internal T Delete<T>(string relativeUrl)
        {
            string responseStr = _client.DeleteAsync(relativeUrl)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;

            Console.WriteLine(responseStr);
            return JsonConvert.DeserializeObject<T>(responseStr);
        }
    }
}

