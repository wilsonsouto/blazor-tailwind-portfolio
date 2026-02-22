using System.Net.Http.Json;

namespace BlazorTailwindPortfolio.Client.Core.Services
{
    public class JsonDataService(HttpClient httpClient, ILogger<JsonDataService> logger) : IJsonDataService
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly ILogger<JsonDataService> _logger = logger;

        public async Task<T?> LoadAsync<T>(string relativePath)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<T>(relativePath);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading JSON from path: {Path}", relativePath);

                return default;
            }
        }
    }
}