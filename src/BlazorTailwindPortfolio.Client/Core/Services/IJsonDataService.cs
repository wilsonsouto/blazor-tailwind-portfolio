namespace BlazorTailwindPortfolio.Client.Core.Services
{
    public interface IJsonDataService
    {
        Task<T?> LoadAsync<T>(string relativePath);
    }
}
