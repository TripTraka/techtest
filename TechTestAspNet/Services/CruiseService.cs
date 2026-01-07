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
            //Implement loading JSON from file here

            return new ApiResponse();
        }
    }
}
