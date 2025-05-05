using System.Text.Json;
using TechTestAspNet.Models;

namespace TechTestAspNet.Services
{
    public interface ICruiseService
    {
        Task<ApiResponse> LoadJsonAsync();
    }

    public class CruiseService : ICruiseService
    {
        public async Task<ApiResponse> LoadJsonAsync()
        {
            string filePath = "Data/eu2025.json";
            string json = await File.ReadAllTextAsync(filePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var response = JsonSerializer.Deserialize<ApiResponse>(json, options);
            return response;
        }
    }
}
