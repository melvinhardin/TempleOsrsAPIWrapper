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
        static async void LogPostRequest(HttpResponseMessage response)
        {
            string logString = $"Status Code: {(int)response.StatusCode} - {response.StatusCode}\nHeaders:\n";
            foreach (var header in response.Headers)
            {
                logString += $"{header.Key}: {string.Join(", ", header.Value)} \n";
            }
            logString += "Content:\n";
            logString += string.IsNullOrWhiteSpace(response.Content.ToString()) ? "[EMPTY]" : await response.Content.ReadAsStringAsync();
            string currentTime = DateTime.Now.ToString("yyyy-MM-ddHHmmssff");
            string filePath = $"post_requests_log{currentTime}.txt";
            byte[] encodedText = Encoding.Unicode.GetBytes(logString);
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            }
        }
        public async Task<TResponse?> GetRequest<TResponse>(string endpoint) where TResponse : class
        {
            HttpResponseMessage response = await _httpclient.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    return await response.Content.ReadFromJsonAsync<TResponse>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deserializing response: {ex.Message}");
                    return null;
                }

            }
            else
            {
                Console.WriteLine($"Request failed with status code: {(int)response.StatusCode} - {response.StatusCode}");
                return null;
            }
        }
        public async Task<TResponse?> GetRequestUnwrapped<TResponse>(string endpoint) where TResponse : List<string>
        {
            HttpResponseMessage response = await _httpclient.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    return await response.Content.ReadFromJsonAsync<TResponse>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deserializing response: {ex.Message}");
                    return null;
                }

            }
            else
            {
                Console.WriteLine($"Request failed with status code: {(int)response.StatusCode} - {response.StatusCode}");
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
            LogPostRequest(response);
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    return await response.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading response content: {ex.Message}");
                    return null;
                }
            }
            else
            {
                Console.WriteLine($"Request failed with status code: {(int)response.StatusCode} - {response.StatusCode}");
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
            LogPostRequest(response);
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    return await response.Content.ReadFromJsonAsync<TResponse>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deserializing response: {ex.Message}");
                    return null;
                }
            }
            else
            {
                Console.WriteLine($"Request failed with status code: {(int)response.StatusCode} - {response.StatusCode}");
                return null;
            }
        }
    }
}
