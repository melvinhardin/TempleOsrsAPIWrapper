using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace TempleOsrsAPIWrapper.Utils
{
    public class HttpRequestHandler
    {
        private readonly HttpClient _httpclient;

        public HttpRequestHandler(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }

        public async Task<TResponse?> GetRequest<TResponse>(string endpoint) where TResponse : class
        {
            HttpResponseMessage response = await _httpclient.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TResponse>();
            }
            else
            {
                return null;
            }
        }
        public async Task<TResponse?> GetRequestUnwrapped<TResponse>(string endpoint) where TResponse : List<string>
        {
            HttpResponseMessage response = await _httpclient.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TResponse>();
            }
            else
            {
                return null;
            }
        }
        public async Task<string?> PostRequest<TContent>(string endpoint, TContent content) where TContent : class
        {
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
            string json = JsonSerializer.Serialize(content, options);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpclient.PostAsync(endpoint, httpContent);
            Console.WriteLine($"Status Code: {(int)response.StatusCode} - {response.StatusCode}");
            Console.WriteLine("Headers:");
            foreach (var header in response.Headers)
            {
                Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
            }
            Console.WriteLine("Content:");
            Console.WriteLine(string.IsNullOrWhiteSpace(response.Content.ToString()) ? "[EMPTY]" : await response.Content.ReadAsStringAsync());
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Success");
                Console.WriteLine(response.StatusCode.ToString(), " ", response.ToString(), response.Headers.ToString());
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                Console.WriteLine("Failure");
                return response.ToString();

            }
        }
        public async Task<TResponse?> PostRequestModel<TContent, TResponse>(string endpoint, TContent content) where TContent : class where TResponse : class
        {
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
            string json = JsonSerializer.Serialize(content, options);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpclient.PostAsync(endpoint, httpContent);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Success");
                return await response.Content.ReadFromJsonAsync<TResponse>();
            }
            else
            {
                Console.WriteLine("Failure");
                return null;

            }
        }
    }
}
