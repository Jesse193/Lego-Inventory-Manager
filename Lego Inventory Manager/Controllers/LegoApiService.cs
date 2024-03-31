using LegoInventoryManager.Models;
using System.Text.Json;

namespace LegoInventoryManager.Controllers
{
    public interface ILegoApiService
    {
        Task<LegoModel> GetPart(string partNumber);
    }
    public class LegoApiService : ILegoApiService
    {
        private readonly IConfiguration _config;

        public LegoApiService(IConfiguration config)
        {
            _config = config;
        }

        private static readonly HttpClient client;
        static LegoApiService()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://rebrickable.com")
            };
        }

        public async Task<LegoModel> GetPart(string partNumber)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/lego/parts/{partNumber}?key={apiKey}");
            var result = new LegoModel();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();           

                result = JsonSerializer.Deserialize<LegoModel>(stringResponse);
            }
            return result;
        }
    }
}