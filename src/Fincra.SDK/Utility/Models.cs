using Newtonsoft.Json;

namespace Fincra.SDK
{
	public class ApiResponse<T>
	{
        [JsonProperty("success")]
        public bool? Success { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("error")]
        public string? Error { get; set; }

        [JsonProperty("errorType")]
        public string? ErrorType { get; set; }

        [JsonProperty("data")]
        public T? Data { get; set; }
    }

    public class ResponseList<T>
    {
        public List<T>? Results { get; set; }
        public int? Total { get; set; }
    }

    public class ApiResponseList<T>
    {
        [JsonProperty("success")]
        public bool? Success { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("error")]
        public string? Error { get; set; }

        [JsonProperty("errorType")]
        public string? ErrorType { get; set; }

        [JsonProperty("data")]
        public ResponseList<T>? Data { get; set; }
    }

    public class ApiResponseListData<T>
    {
        [JsonProperty("success")]
        public bool? Success { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("error")]
        public string? Error { get; set; }

        [JsonProperty("errorType")]
        public string? ErrorType { get; set; }

        [JsonProperty("data")]
        public T? Data { get; set; }
    }
}

